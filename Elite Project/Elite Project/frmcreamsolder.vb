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

        If lblissuancetime.Text <> "" Then
            cmd.CommandText = "SELECT timestampdiff(MINUTE, thawingtime, now()) from gi_creamsolder WHERE creamid = '" & txtcsinput.Text & "'"
            If cmd.ExecuteScalar().ToString() > 4319 Then
                MsgBox("Action not permitted. Maximum Thawing: 72 Hours")
            Else
                setCreamSolder(txtcsinput.Text)
                frminjection.Enabled = True
                frminjection.refreshDetails()
                frminjection.csmin()
                Me.Hide()
            End If
        Else
            MsgBox("The cream solder is not yet ready to use")
        End If
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
End Class