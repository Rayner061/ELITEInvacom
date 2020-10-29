Imports MySql.Data.MySqlClient

Public Class frmStencilManager
    Dim upp As Integer = 0
    Private Sub frmStencilManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxAction.Enabled = False
        frminjection.Timer1.Enabled = False
        frminjection.Timer2.Enabled = False
        frminjection.connectTimer.Enabled = False
        lblline.Visible = False
        'lblID.Text = "GI-WA MKI-T-001"
        'MsgBox(lblID.Text.Substring(3).Substring(0, lblID.Text.Substring(3).IndexOf("-")))
        dbConnect()
        displayInventory()
    End Sub

    Private Sub txtScan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScan.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            Try
                If txtScan.Text.Substring(0, 3) = "GI-" Then
                    txtScan.Enabled = False
                    lblID.Text = txtScan.Text
                    cmd.CommandText = "SELECT COUNT(stencilid) FROM `gi_stencil` WHERE `stencilid` = '" & txtScan.Text & "'"
                    If cmd.ExecuteScalar > 0 Then
                        cbxAction.Enabled = True
                        Dim reader As MySqlDataReader
                        txtScan.Enabled = False
                        txtScan.Text = ""
                        cmd.CommandText = "SELECT DISTINCT `model` FROM `gi_modelmatrix` WHERE `model` LIKE '" & lblID.Text.Substring(3).Substring(0, lblID.Text.Substring(3).IndexOf("-")) & "%'"
                        lblModel.Text = cmd.ExecuteScalar
                        cmd.CommandText = "SELECT `location`, `registrationdate` FROM `gi_stencil` WHERE `stencilid` = '" & lblID.Text & "'"
                        reader = cmd.ExecuteReader
                        While reader.Read
                            lblStatus.Text = reader.Item(0).ToString
                            lblDR.Text = reader.Item(1).ToString
                        End While
                        reader.Close()
                        If lblStatus.Text = "storage" Then
                            cbxAction.Items.Add("Issue to Line")
                            cbxAction.Items.Add("Scrap")
                        ElseIf lblStatus.Text.Substring(0, 4) = "Line" Then
                            cbxAction.Items.Add("Remove")
                        ElseIf lblStatus.Text = "scrap" Then
                            cbxAction.Enabled = False
                            txtScan.Enabled = True
                            txtScan.Focus()
                        End If
                        cbxAction.Focus()
                        cbxAction.DroppedDown = True
                    Else
                        txtScan.Enabled = False
                        cbxAction.Enabled = True
                        cbxAction.Items.Clear()
                        cbxAction.Items.Add("Register")
                        cbxAction.Focus()
                    End If
                Else
                    MsgBox("Error: Invalid Stencil Format.")

                End If
                displayInventory()
                'txtScan.Enabled = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub cbxAction_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxAction.SelectionChangeCommitted
        Try
            lblline.Items.Clear()
            Select Case cbxAction.Text
                Case "Register"
                    lblline.Visible = False
                    btnSubmit.Enabled = True
                Case "Issue to Line"
                    Dim cmd As New MySqlCommand
                    cmd.Connection = conn
                    For Each line As String In lineString
                        cmd.CommandText = "SELECT COUNT(`location`) FROM `gi_stencil` WHERE (SUBSTR(`location`, POSITION(' ' IN `location`) + 1, LENGTH(`location`) - 5)) = '" & line & "'"
                        If cmd.ExecuteScalar = 0 Then
                            lblline.Items.Add(line)
                        End If
                    Next
                    lblline.Visible = True
                Case "Remove"
                    lblline.Visible = False
                    btnSubmit.Enabled = True
                Case "Scrap"
                Case Else
                    btnSubmit.Enabled = False
                    lblline.Visible = False
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Try
            displayInventory()
            Select Case cbxAction.Text
                Case "Register"
                    cmd.CommandText = "INSERT INTO `gi_stencil`(`stencilid`, `registrationdate`, `location`, `timestamp`) VALUES('" & txtScan.Text & "', NOW(), 'storage', NOW())"
                    cmd.ExecuteNonQuery()
                    addToLogs("Registration", "storage")
                    MsgBox("Registration Successful!")
                Case "Issue to Line"
                    updateLifespan(lblID.Text)
                    If isLifespanValid(lblID.Text) = True Then
                        If lblline.Text = "" Then
                            MsgBox("Complete necessary information")
                            lblline.Focus()
                        Else
                            cmd.CommandText = "UPDATE `gi_stencil` SET `location` = 'Line " & lblline.Text & "', timestamp = now() WHERE `stencilid` = '" & lblID.Text & "'"
                            cmd.ExecuteNonQuery()
                            addToLogs("Issuance", lblline.Text)
                        End If
                    Else
                        MsgBox("Invalid action. Lifespan exhausted.")
                    End If
                Case "Remove"
                    updateLifespan(lblID.Text)
                    cmd.CommandText = "UPDATE `gi_stencil` SET `location` = 'storage' WHERE `stencilid` = '" & lblID.Text & "'"
                    cmd.ExecuteNonQuery()
                    addToLogs("Remove", frminjection.lblline.Text)
                Case "Scrap"
                    updateLifespan(lblID.Text)
                    cmd.CommandText = "UPDATE `gi_stencil` SET `location` = 'scrap' WHERE `stencilid` = '" & lblID.Text & "'"
                    cmd.ExecuteNonQuery()
                    addToLogs("Scrap", "not applicable")
            End Select
            updateLifespan(lblID.Text)
            displayInventory()
            txtScan.Text = ""
            lblID.Text = ""
            lblModel.Text = ""
            lblStatus.Text = ""
            lblDR.Text = ""
            cbxAction.Items.Clear()
            cbxAction.Enabled = False
            btnSubmit.Enabled = False
            txtScan.Enabled = True
            txtScan.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub displayInventory()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        Dim dvStorage, dvInUse As DataView

        cmd.CommandText = "SELECT * FROM `gi_view_stencil`"
        myDA.Fill(myDT)
        dvStorage = New DataView(myDT, "location = 'storage'", "stencilid", DataViewRowState.CurrentRows)
        dvInUse = New DataView(myDT, "location LIKE '%Line%'", "stencilid", DataViewRowState.CurrentRows)
        dgStorage.DataSource = dvStorage
        dgInuse.DataSource = dvInUse
    End Sub

    Private Function isLifespanValid(stencilid As String) As Boolean
        Try
            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "SELECT SUM(`count`) FROM (SELECT COUNT(`pcbid`) AS `count` FROM `gi_pcbtrace` WHERE `stencilid_bottom` = '" & stencilid & "' UNION ALL
                                SELECT COUNT(`pcbid`) AS `count` FROM `gi_pcbtrace` WHERE `stencilid_top` = '" & stencilid & "') `a`"
            If (cmd.ExecuteScalar / upp) < 90000 Then
                isLifespanValid = True
            Else
                isLifespanValid = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            writeLogs(ex.ToString)
        End Try
        Return isLifespanValid
    End Function

    Private Sub updateLifespan(stencilid As String)
        Dim cmd As New MySqlCommand

        Dim modelCode As String = ""
        cmd.Connection = conn

        modelCode = stencilid.Substring(3).Substring(0, stencilid.Substring(3).IndexOf("-"))

        cmd.CommandText = "SELECT `upp` FROM `gi_modelmatrix` WHERE model = '" & modelCode & "'"
        upp = cmd.ExecuteScalar

        cmd.CommandText = "UPDATE `gi_stencil_lifespan` SET `lifespan`= (SELECT FLOOR(90000 - (SUM(`count`) / " & upp & ")) AS `lifespan` FROM (SELECT COUNT(`pcbid`) AS `count` FROM `gi_pcbtrace` WHERE `stencilid_bottom` = '" & stencilid & "' UNION ALL
                                SELECT COUNT(`pcbid`) AS `count` FROM `gi_pcbtrace` WHERE `stencilid_top` = '" & stencilid & "') `a`) WHERE `stencilid` = '" & stencilid & "'"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub addToLogs(action As String, location As String)
        Try
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            Dim myDA As New MySqlDataAdapter(cmd)
            Dim myDT As New DataTable

            cmd.CommandText = "INSERT INTO `gi_stencil_history`(`stencilid`, `timestamp`, `action`, `location`, `operator`) VALUES('" & lblID.Text & "', NOW(), '" & action & "', '" & location & "', 
                                    '" & frminjection.lblname.Text & "')"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "SELECT `stencilid`, `timestamp`, `action`, `location`, `operator` FROM `gi_stencil_history` WHERE `stencilid` = '" & lblID.Text & "' ORDER BY `timestamp` DESC"
            myDA.Fill(myDT)
            dgLogs.DataSource = myDT
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frminjection.Enabled = True
        Me.Hide()
    End Sub

    Private Sub frmStencilManager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frminjection.Enabled = True
        frminjection.refreshDetails()
    End Sub

End Class