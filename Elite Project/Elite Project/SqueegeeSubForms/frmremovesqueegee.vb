Imports MySql.Data.MySqlClient
Public Class frmremovesqueegee
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmsqueegeemanager.Enabled = True
        Close()
    End Sub

    Private Sub txtSqueegeeA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSqueegeeA.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtSqueegeeA.Text.Length = 17 Then
                txtSqueegeeB.Focus()
            Else
                MsgBox("Invalid Squeegee blade")
                txtSqueegeeA.Text = ""
            End If
        End If
    End Sub

    Private Sub txtSqueegeeB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSqueegeeB.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtSqueegeeA.Text.Length = 17 And txtSqueegeeB.Text.Length = 17 Then
                Dim cmd As New MySqlCommand
                Dim QRA As String = ""
                Dim QRB As String = ""
                Dim line As String = ""
                cmd.Connection = conn

                Select Case frmsqueegeemanager.cmsn
                    Case "pbSqueegee1A", "pbSqueegee1B"
                        QRA = frmsqueegeemanager.lblQR1A.Text
                        QRB = frmsqueegeemanager.lblQR1B.Text
                        line = "Line 1"
                    Case "pbSqueegee2A", "pbSqueegee2B"
                        QRA = frmsqueegeemanager.lblQR2A.Text
                        QRB = frmsqueegeemanager.lblQR1B.Text
                        line = "Line 2"
                    Case "pbSqueegee6A", "pbSqueegee6B"
                        QRA = frmsqueegeemanager.lblQR6A.Text
                        QRB = frmsqueegeemanager.lblQR6B.Text
                        line = "Line 6"
                    Case "pbSqueegee12A", "pbSqueegee12B"
                        QRA = frmsqueegeemanager.lblQR12A.Text
                        QRB = frmsqueegeemanager.lblQR12B.Text
                        line = "Line 12"
                    Case "pbSqueegee14A", "pbSqueegee14B"
                        QRA = frmsqueegeemanager.lblQR14A.Text
                        QRB = frmsqueegeemanager.lblQR14B.Text
                        line = "Line 14"
                    Case "pbSqueegee15A", "pbSqueegee15B"
                        QRA = frmsqueegeemanager.lblQR15A.Text
                        QRB = frmsqueegeemanager.lblQR15B.Text
                        line = "Line 15"
                    Case "pbSqueegee17A", "pbSqueegee17B"
                        QRA = frmsqueegeemanager.lblQR17A.Text
                        QRB = frmsqueegeemanager.lblQR17B.Text
                        line = "Line 15"
                    Case ""
                        QRA = ""
                        QRB = ""
                        line = ""
                End Select

                If (txtSqueegeeA.Text = QRA And txtSqueegeeB.Text = QRB) Or (txtSqueegeeA.Text = QRB And txtSqueegeeB.Text = QRA) Then
                    cmd.CommandText = ("UPDATE gi_squeegee SET location = 'storage', timestamp = NOW() WHERE squeegeeid = '" & QRA & "' OR  squeegeeid = '" & QRB & "'")
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + QRA + "', NOW(), 'REMOVE SQUEEGEE', '" & line & "', '" & frmsqueegeemanager.lblName.Text & "')"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + QRB + "', NOW(), 'REMOVE SQUEEGEE', '" & line & "', '" & frmsqueegeemanager.lblName.Text & "')"
                    cmd.ExecuteNonQuery()
                    frmsqueegeemanager.refreshSqueegee()
                    frmsqueegeemanager.Enabled = True
                    Close()
                Else
                    MsgBox("Squeegee pair doesn't match the current issued in the selected line.")
                    txtSqueegeeA.Text = ""
                    txtSqueegeeB.Text = ""
                    txtSqueegeeA.Focus()
                End If
            Else
                MsgBox("Invalid Squeegee blade")
                txtSqueegeeB.Text = ""
            End If
        End If
    End Sub
End Class