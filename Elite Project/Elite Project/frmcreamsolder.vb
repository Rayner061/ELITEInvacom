Imports MySql.Data.MySqlClient
Public Class frmcreamsolder
    Dim openvalidity As String
    Private Sub frmcreamsolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcsinput.Text = ""
        txtcsinput.Focus()
    End Sub

    Private Sub btncreamcancel_Click(sender As Object, e As EventArgs) Handles btncreamcancel.Click
        txtcsinput.Text = ""
        frminjection.Enabled = True
        frminjection.txtscan.Focus()
        Me.Hide()
    End Sub

    Private Sub txtcsinput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcsinput.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                Dim cmd As New MySqlCommand
                Dim reader As MySqlDataReader
                Dim issuance, openvalidity As String

                issuance = ""
                openvalidity = ""

                cmd.Connection = conn
                cmd.CommandText = "SELECT 
                                    IF(`lineissuancetime` IS NOT NULL, 'pass', 'failed') AS `issuance`,
                                    IF(`opendatetime` IS NULL OR (TIME_TO_SEC(TIMEDIFF(NOW(), `opendatetime`)) < 28800), 'pass', 'failed') AS `openvalidity`
                                FROM
                                    `gi_creamsolder`
                                WHERE `creamid` = '" & txtcsinput.Text & "'"
                reader = cmd.ExecuteReader()
                While reader.Read()
                    issuance = reader.Item(0).ToString()
                    openvalidity = reader.Item(1).ToString()
                End While
                reader.Close()

                If issuance = "pass" And openvalidity = "pass" Then
                    cmd.CommandText = "SELECT reftime, thawingtime, lineissuancetime FROM gi_creamsolder WHERE creamid = '" + txtcsinput.Text + "'"
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        lblreftime.Text = reader.Item(0).ToString()
                        lblthawtime.Text = reader.Item(1).ToString()
                        lblissuancetime.Text = reader.Item(2).ToString()
                    End While
                    reader.Close()
                    txtcsinput.Enabled = False
                ElseIf issuance = "failed" Then
                    MsgBox("Error: Action not permitted. Cream Solder did not complete previous process.")
                    lblreftime.Text = ""
                    lblthawtime.Text = ""
                    lblmixtime.Text = ""
                    lblissuancetime.Text = ""
                    txtcsinput.Text = ""
                ElseIf openvalidity = "failed" Then
                    MsgBox("Error: Action not permitted. Anomaly detected. This cream solder passed the 8 hours normal usage of solder paste.")
                    lblreftime.Text = ""
                    lblthawtime.Text = ""
                    lblmixtime.Text = ""
                    lblissuancetime.Text = ""
                    txtcsinput.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btncreamsave_Click(sender As Object, e As EventArgs) Handles btncreamsave.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Try

            If lblissuancetime.Text <> "" Then
                cmd.CommandText = "SELECT timestampdiff(MINUTE, thawingtime, now()) from gi_creamsolder WHERE creamid = '" & txtcsinput.Text & "'"
                If cmd.ExecuteScalar().ToString() > 4319 Then
                    MsgBox("Action not permitted. Maximum Thawing: 72 Hours")
                Else
                    setCreamSolder(txtcsinput.Text)
                    saveSAP(txtcsinput.Text)
                    frminjection.Enabled = True
                    frminjection.refreshDetails()
                    frminjection.csmin()
                    Me.Hide()
                End If
            Else
                MsgBox("The cream solder is not yet ready to use")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtdt.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub setCreamSolder(csid As String)
        Try
            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "UPDATE gi_creamsolder SET status = 'empty' WHERE line = '" & txtline.Text & "' AND status = 'in use'"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "UPDATE gi_creamsolder SET opendatetime = NOW(), status = 'in use' WHERE creamid = '" & csid & "' AND opendatetime is NULL"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "UPDATE gi_injectioninfo SET creamsolderid = '" & csid & "' WHERE line = '" & frminjection.lblline.Text & "'"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub saveSAP(csid As String)
        Try
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            Dim Modelmatrixid, customer, partnumber, timestamp, transaction_type, materialcode, dr_number, sloc, dloc, finaltransaction As String

            Dim reader As MySqlDataReader

            partnumber = ""
            timestamp = ""
            transaction_type = ""
            materialcode = ""
            dr_number = ""
            sloc = ""
            dloc = ""
            finaltransaction = ""

            cmd.CommandText = "SELECT modelmatrixid FROM gi_injectioninfo WHERE line = '" & frminjection.lblline.Text & "'"
            Modelmatrixid = cmd.ExecuteScalar()

            cmd.CommandText = "SELECT customer FROM gi_modelmatrix WHERE modelmatrixid = '" & Modelmatrixid & "'"
            customer = cmd.ExecuteScalar()

            If customer = "gs" Then
                Dim Alltransaction() As String = {"GLOBAL_GIGS_RECEIVE", "GLOBAL_GIGS_ISSUANCE", "GLOBAL_GIGS_REISSUANCE", "GLOBAL_GIGS_RETURN"}

                For Each items As String In Alltransaction
                    cmd.CommandText = "SELECT COUNT(*) FROM temp_sap_inbound_mm_component WHERE materialcode = '" + csid + "' AND transaction = '" & items & "'"
                    If cmd.ExecuteScalar > 0 Then
                        cmd.CommandText = "SELECT partnumber, timestamp, transaction_type,materialcode,dr_number FROM temp_sap_inbound_mm_component WHERE materialcode = '" + csid + "' AND transaction = '" & items & "'"
                        reader = cmd.ExecuteReader()
                        While reader.Read()
                            partnumber = reader.Item(0).ToString()
                            timestamp = reader.Item(1).ToString()
                            transaction_type = reader.Item(2).ToString()
                            materialcode = reader.Item(3).ToString()
                            dr_number = reader.Item(4).ToString()
                        End While
                        reader.Close()

                        If items.Contains("RECEIVE") Then
                            sloc = "D051"
                            dloc = "D051"
                            finaltransaction = "GLOBAL_SKYWARE_RECEIVE"
                        ElseIf items.Contains("ISSUANCE") Then
                            sloc = "D051"
                            dloc = "2060"
                            finaltransaction = "GLOBAL_SKYWARE_ISSUANCE"
                        ElseIf items.Contains("RETURN") Then
                            sloc = "2060"
                            dloc = "D051"
                            finaltransaction = "GLOBAL_SKYWARE_RETURN"
                        ElseIf items.Contains("REISSUANCE") Then
                            sloc = "D051"
                            dloc = "2060"
                            finaltransaction = "GLOBAL_SKYWARE_REISSUANCE"
                        End If

                        If dr_number <> "" Then
                            cmd.CommandText = "INSERT INTO sap_inbound_mm_component (partnumber,timestamp,quantity,transaction_type,source_loc,dest_loc,materialcode,generated,dr_number,transaction) VALUES('" & partnumber & "','" & timestamp & "' ,'1','" & transaction_type & "','" & sloc & "','" & dloc & "','" & materialcode & "','no','" & dr_number & "','" & finaltransaction & "')"
                            cmd.ExecuteScalar()
                        End If

                        cmd.CommandText = "DELETE FROM temp_sap_inbound_mm_component WHERE materialcode = '" + csid + "' AND transaction = '" & items & "'"
                        cmd.ExecuteNonQuery()
                    End If
                    partnumber = ""
                    timestamp = ""
                    transaction_type = ""
                    materialcode = ""
                    dr_number = ""
                    sloc = ""
                    dloc = ""
                    finaltransaction = ""
                Next
            ElseIf customer = "gi" Then
                Dim Alltransaction() As String = {"GLOBAL_GIGS_RECEIVE", "GLOBAL_GIGS_ISSUANCE", "GLOBAL_GIGS_REISSUANCE", "GLOBAL_GIGS_RETURN"}

                For Each items As String In Alltransaction
                    cmd.CommandText = "SELECT COUNT(*) FROM temp_sap_inbound_mm_component WHERE materialcode = '" + csid + "' AND transaction = '" & items & "'"
                    If cmd.ExecuteScalar > 0 Then


                        cmd.CommandText = "SELECT partnumber, timestamp, transaction_type,materialcode,dr_number FROM temp_sap_inbound_mm_component WHERE materialcode = '" + csid + "' AND transaction = '" & items & "'"
                        reader = cmd.ExecuteReader()
                        While reader.Read()
                            partnumber = reader.Item(0).ToString()
                            timestamp = reader.Item(1).ToString()
                            transaction_type = reader.Item(2).ToString()
                            materialcode = reader.Item(3).ToString()
                            dr_number = reader.Item(4).ToString()
                        End While
                        reader.Close()

                        If items.Contains("RECEIVE") Then
                            sloc = "D050"
                            dloc = "D050"
                            finaltransaction = "GLOBAL_INVACOM_RECEIVE"
                        ElseIf items.Contains("ISSUANCE") Then
                            sloc = "D050"
                            dloc = "2050"
                            finaltransaction = "GLOBAL_INVACOM_ISSUANCE"
                        ElseIf items.Contains("RETURN") Then
                            sloc = "2050"
                            dloc = "D050"
                            finaltransaction = "GLOBAL_INVACOM_RETURN"
                        ElseIf items.Contains("REISSUANCE") Then
                            sloc = "D050"
                            dloc = "2050"
                            finaltransaction = "GLOBAL_INVACOM_REISSUANCE"
                        End If

                        If dr_number <> "" Then
                            cmd.CommandText = "INSERT INTO sap_inbound_mm_component (partnumber,timestamp,quantity,transaction_type,source_loc,dest_loc,materialcode,generated,dr_number,transaction) VALUES('" & partnumber & "','" & timestamp & "' ,'1','" & transaction_type & "','" & sloc & "','" & dloc & "','" & materialcode & "','no','" & dr_number & "','" & finaltransaction & "')"
                            cmd.ExecuteScalar()
                        End If

                        cmd.CommandText = "DELETE FROM temp_sap_inbound_mm_component WHERE materialcode = '" + csid + "' AND transaction = '" & items & "'"
                        cmd.ExecuteNonQuery()
                    End If
                    partnumber = ""
                    timestamp = ""
                    transaction_type = ""
                    materialcode = ""
                    dr_number = ""
                    sloc = ""
                    dloc = ""
                    finaltransaction = ""
                Next

            End If
            cmd.CommandText = "UPDATE gi_injectioninfo SET creamsolderid = '" & csid & "' WHERE line = '" & frminjection.lblline.Text & "'"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Select Model.")
        End Try
    End Sub

End Class