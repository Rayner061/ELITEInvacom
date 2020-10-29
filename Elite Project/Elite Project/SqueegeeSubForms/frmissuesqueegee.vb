Imports MySql.Data.MySqlClient

Public Class frmissuesqueegee
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            Dim locationNewA As String = ""
            Dim locationNewB As String = ""

            Dim remainingA As Integer = 0
            Dim remainingB As Integer = 0
            Dim remainingDT As New DataTable

            Dim invalidCount As Integer = 0

            Dim cmd As New MySqlCommand
            Dim myDA As New MySqlDataAdapter(cmd)
            cmd.Connection = conn

            cmd.CommandText = "SELECT location FROM gi_squeegee WHERE squeegeeid = '" & frmsqueegeemanager.txtSqueegeeA.Text & "'"
            locationNewA = cmd.ExecuteScalar.ToString()
            cmd.CommandText = "SELECT location FROM gi_squeegee WHERE squeegeeid = '" & frmsqueegeemanager.txtSqueegeeB.Text & "'"
            locationNewB = cmd.ExecuteScalar.ToString()

            If locationNewA = "storage" And locationNewB = "storage" Then
                cmd.CommandText = "SELECT COUNT(squeegeeid) FROM gi_squeegeehistory WHERE (squeegeeid = '" & frmsqueegeemanager.txtSqueegeeA.Text & "' OR squeegeeid = '" & frmsqueegeemanager.txtSqueegeeB.Text & "') AND `timestamp` BETWEEN (NOW() - INTERVAL 1440 MINUTE) AND (NOW()) AND location = '" & cboLine.Text & "' AND `action` = 'REMOVE SQUEEGEE'"
                invalidCount = Convert.ToInt32(cmd.ExecuteScalar)

                If invalidCount = 0 Then
                    cmd.CommandText = "SELECT remaining FROM gi_view_squeegee WHERE squeegeeid = '" & frmsqueegeemanager.txtSqueegeeA.Text & "' OR squeegeeid = '" & frmsqueegeemanager.txtSqueegeeB.Text & "'"
                    myDA.Fill(remainingDT)

                    remainingA = Convert.ToInt32(remainingDT.Rows(0).Item(0).ToString)
                    remainingB = Convert.ToInt32(remainingDT.Rows(1).Item(0).ToString)

                    If remainingA > 0 And remainingB > 0 Then
                        cmd.CommandText = "UPDATE gi_squeegee SET location = '" & cboLine.Text & "', timestamp = NOW() WHERE squeegeeid = '" & frmsqueegeemanager.txtSqueegeeA.Text & "' OR squeegeeid = '" & frmsqueegeemanager.txtSqueegeeB.Text & "'"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" & frmsqueegeemanager.txtSqueegeeA.Text & "', NOW(), 'ISSUE TO LINE', '" & cboLine.Text & "', '" & frmsqueegeemanager.lblName.Text & "')"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" & frmsqueegeemanager.txtSqueegeeB.Text & "', NOW(), 'ISSUE TO LINE', '" & cboLine.Text & "', '" & frmsqueegeemanager.lblName.Text & "')"
                        cmd.ExecuteNonQuery()
                        frmsqueegeemanager.Enabled = True
                        frmsqueegeemanager.txtSqueegeeA.Text = ""
                        frmsqueegeemanager.txtSqueegeeB.Text = ""
                        frmsqueegeemanager.lblMachine.Text = ""
                        frmsqueegeemanager.lblLocation.Text = ""
                        frmsqueegeemanager.lblDateReceived.Text = ""
                        frmsqueegeemanager.txtSqueegeeA.Focus()
                        frmsqueegeemanager.refreshSqueegee()
                        Close()
                    Else
                        MsgBox("Squeege blades exceeded its maximum life. Please replace them with a new pair.")
                        frmsqueegeemanager.Enabled = True
                        frmsqueegeemanager.txtSqueegeeA.Text = ""
                        frmsqueegeemanager.txtSqueegeeB.Text = ""
                        frmsqueegeemanager.lblMachine.Text = ""
                        frmsqueegeemanager.lblLocation.Text = ""
                        frmsqueegeemanager.lblDateReceived.Text = ""
                        frmsqueegeemanager.txtSqueegeeA.Focus()
                        Close()
                    End If
                Else
                    MsgBox("This pair of squeegee needs to be removed from this line for 24 hours. Please use another pair.")
                    frmsqueegeemanager.Enabled = True
                    frmsqueegeemanager.txtSqueegeeA.Text = ""
                    frmsqueegeemanager.txtSqueegeeB.Text = ""
                    frmsqueegeemanager.lblMachine.Text = ""
                    frmsqueegeemanager.lblLocation.Text = ""
                    frmsqueegeemanager.lblDateReceived.Text = ""
                    frmsqueegeemanager.txtSqueegeeA.Focus()
                    Close()
                End If
            Else
                MsgBox("Invalid squeegee.")
                frmsqueegeemanager.Enabled = True
                frmsqueegeemanager.txtSqueegeeA.Text = ""
                frmsqueegeemanager.txtSqueegeeB.Text = ""
                frmsqueegeemanager.lblMachine.Text = ""
                frmsqueegeemanager.lblLocation.Text = ""
                frmsqueegeemanager.lblDateReceived.Text = ""
                frmsqueegeemanager.txtSqueegeeA.Focus()
                Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmsqueegeemanager.Enabled = True
        Close()
    End Sub

    Private Sub frmissuestencil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If frmsqueegeemanager.lblQR1A.Text = "" And frmsqueegeemanager.lblQR1B.Text = "" Then
        '    cboLine.Items.Add("Line 1")
        'End If
        'If frmsqueegeemanager.lblQR2A.Text = "" And frmsqueegeemanager.lblQR2B.Text = "" Then
        '    cboLine.Items.Add("Line 2")
        'End If
        'If frmsqueegeemanager.lblQR3A.Text = "" And frmsqueegeemanager.lblQR3B.Text = "" Then
        '    cboLine.Items.Add("Line 3")
        'End If
        'If frmsqueegeemanager.lblQR4A.Text = "" And frmsqueegeemanager.lblQR4B.Text = "" Then
        '    cboLine.Items.Add("Line 4")
        'End If
        'If frmsqueegeemanager.lblQR5A.Text = "" And frmsqueegeemanager.lblQR5B.Text = "" Then
        '    cboLine.Items.Add("Line 5")
        'End If
        'If frmsqueegeemanager.lblQR6A.Text = "" And frmsqueegeemanager.lblQR6B.Text = "" Then
        '    cboLine.Items.Add("Line 6")
        'End If
        'If frmsqueegeemanager.lblQR7A.Text = "" And frmsqueegeemanager.lblQR7B.Text = "" Then
        '    cboLine.Items.Add("Line 7")
        'End If
        'If frmsqueegeemanager.lblQR8A.Text = "" And frmsqueegeemanager.lblQR8B.Text = "" Then
        '    cboLine.Items.Add("Line 8")
        'End If
        'If frmsqueegeemanager.lblQR10A.Text = "" And frmsqueegeemanager.lblQR10B.Text = "" Then
        '    cboLine.Items.Add("Line 9")
        'End If
        'If frmsqueegeemanager.lblQR11A.Text = "" And frmsqueegeemanager.lblQR11B.Text = "" Then
        '    cboLine.Items.Add("Line 10")
        'End If

        'Dim cmd As New MySqlCommand
        'cmd.Connection = conn

        'cmd.CommandText = "SELECT `value` FROM `settings` WHERE `name` = 'e_gi_line'"
        'For i As Integer = 1 To Val(cmd.ExecuteScalar)
        '    cboLine.Items.Add("Line " & i)
        'Next
    End Sub
End Class