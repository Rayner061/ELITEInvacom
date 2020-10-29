Imports MySql.Data.MySqlClient

Public Class frmreplacesqueegee
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub txtNewA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewA.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNewB.Enabled = True
            txtNewB.Focus()
            txtNewA.Enabled = False
        End If
    End Sub

    Private Sub txtNewB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewB.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtNewA.Text.Length = 17 And txtNewB.Text.Length = 17 And txtOldA.Text.Length = 17 And txtOldB.Text.Length = 17 Then
                Dim QRA As String = ""
                Dim QRB As String = ""
                Dim locationNewA As String = ""
                Dim locationNewB As String = ""

                Dim cmd As New MySqlCommand
                Dim Line As String
                cmd.Connection = conn
                Line = ""
                Select Case frmsqueegeemanager.cmsn
                    Case "pbSqueegee1A", "pbSqueegee1B"
                        Line = "Line 1"
                        QRA = frmsqueegeemanager.lblQR1A.Text
                        QRB = frmsqueegeemanager.lblQR1B.Text
                    Case "pbSqueegee2A", "pbSqueegee2B"
                        Line = "Line 2"
                        QRA = frmsqueegeemanager.lblQR2A.Text
                        QRB = frmsqueegeemanager.lblQR2B.Text
                    Case "pbSqueegee6A", "pbSqueegee6B"
                        Line = "Line 6"
                        QRA = frmsqueegeemanager.lblQR12A.Text
                        QRB = frmsqueegeemanager.lblQR12B.Text
                    Case "pbSqueegee12A", "pbSqueegee12B"
                        Line = "Line 12"
                        QRA = frmsqueegeemanager.lblQR12A.Text
                        QRB = frmsqueegeemanager.lblQR12B.Text
                    Case "pbSqueegee14A", "pbSqueegee14B"
                        Line = "Line 14"
                        QRA = frmsqueegeemanager.lblQR14A.Text
                        QRB = frmsqueegeemanager.lblQR14B.Text
                    Case "pbSqueegee15A", "pbSqueegee15B"
                        Line = "Line 15"
                        QRA = frmsqueegeemanager.lblQR15A.Text
                        QRB = frmsqueegeemanager.lblQR15B.Text
                    Case "pbSqueegee17A", "pbSqueegee17B"
                        Line = "Line 17"
                        QRA = frmsqueegeemanager.lblQR17A.Text
                        QRB = frmsqueegeemanager.lblQR17B.Text
                    Case ""
                        Line = ""
                        QRA = ""
                        QRB = ""
                End Select

                cmd.CommandText = "SELECT location FROM tblsqueegee WHERE squeegeeid = '" + txtNewA.Text + "'"
                locationNewA = cmd.ExecuteScalar.ToString()
                cmd.CommandText = "SELECT location FROM tblsqueegee WHERE squeegeeid = '" + txtNewB.Text + "'"
                locationNewB = cmd.ExecuteScalar.ToString()

                If locationNewA = "storage" And locationNewB = "storage" Then
                    If ((txtOldA.Text = QRA And txtOldB.Text = QRB) Or (txtOldA.Text = QRB And txtOldB.Text = QRA)) And (txtNewA.Text.Substring(0, 16) = txtNewB.Text.Substring(0, 16) And txtNewA.Text <> txtNewB.Text) Then

                        ''''''NEW'''''
                        cmd.CommandText = ("UPDATE tblsqueegee SET location = '" + Line + "', timestamp = NOW() WHERE squeegeeid = '" + txtNewA.Text + "'")
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = ("UPDATE tblsqueegee SET location = '" + Line + "', timestamp = NOW() WHERE squeegeeid = '" + txtNewB.Text + "'")
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + txtNewA.Text + "', NOW(), 'REPLACED " + txtOldA.Text + "', '" + Line + "', '" + frmsqueegeemanager.lblName.Text + "')"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + txtNewB.Text + "', NOW(), 'REPLACED " + txtOldB.Text + "', '" + Line + "', '" + frmsqueegeemanager.lblName.Text + "')"
                        cmd.ExecuteNonQuery()

                        ''''''OLD'''''
                        cmd.CommandText = ("UPDATE tblsqueegee SET location = 'storage', timestamp = NOW() WHERE squeegeeid = '" + QRA + "'")
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = ("UPDATE tblsqueegee SET location = 'storage', timestamp = NOW() WHERE squeegeeid = '" + QRB + "'")
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + QRA + "', NOW(), 'REPLACED BY " + txtNewA.Text + "', '" + Line + "', '" + frmsqueegeemanager.lblName.Text + "')"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + QRB + "', NOW(), 'REPLACED BY " + txtNewB.Text + "', '" + Line + "', '" + frmsqueegeemanager.lblName.Text + "')"
                        cmd.ExecuteNonQuery()
                        frmsqueegeemanager.refreshSqueegee()
                        frmsqueegeemanager.Enabled = True
                        Close()
                    Else
                        MsgBox("Invalid squeegee.")
                        txtOldA.Enabled = True
                        txtOldB.Enabled = False
                        txtNewA.Enabled = False
                        txtNewB.Enabled = False
                        txtOldA.Focus()

                        txtOldA.Text = ""
                        txtOldB.Text = ""
                        txtNewA.Text = ""
                        txtNewB.Text = ""
                    End If
                Else
                    Dim result As Integer = MessageBox.Show(txtNewA.Text + " is currently issued on the line. Do you still want to proceed?", "Warning", MessageBoxButtons.YesNo)
                    If result = DialogResult.Yes Then
                        If ((txtOldA.Text = QRA And txtOldB.Text = QRB) Or (txtOldA.Text = QRB And txtOldB.Text = QRA)) And (txtNewA.Text.Substring(0, 16) = txtNewB.Text.Substring(0, 16) And txtNewA.Text <> txtNewB.Text) Then

                            ''''''NEW'''''
                            cmd.CommandText = ("UPDATE tblsqueegee SET location = '" + Line + "', timestamp = NOW() WHERE squeegeeid = '" + txtNewA.Text + "'")
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = ("UPDATE tblsqueegee SET location = '" + Line + "', timestamp = NOW() WHERE squeegeeid = '" + txtNewB.Text + "'")
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + txtNewA.Text + "', NOW(), 'REPLACED " + txtOldA.Text + "', '" + Line + "', '" + frmsqueegeemanager.lblName.Text + "')"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + txtNewB.Text + "', NOW(), 'REPLACED " + txtOldB.Text + "', '" + Line + "', '" + frmsqueegeemanager.lblName.Text + "')"
                            cmd.ExecuteNonQuery()

                            ''''''OLD'''''
                            cmd.CommandText = ("UPDATE tblsqueegee SET location = 'storage', timestamp = NOW() WHERE squeegeeid = '" + QRA + "'")
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = ("UPDATE tblsqueegee SET location = 'storage', timestamp = NOW() WHERE squeegeeid = '" + QRB + "'")
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + QRA + "', NOW(), 'REPLACED BY " + txtNewA.Text + "', '" + Line + "', '" + frmsqueegeemanager.lblName.Text + "')"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + QRB + "', NOW(), 'REPLACED BY " + txtNewB.Text + "', '" + Line + "', '" + frmsqueegeemanager.lblName.Text + "')"
                            cmd.ExecuteNonQuery()
                            frmsqueegeemanager.refreshSqueegee()
                            frmsqueegeemanager.Enabled = True
                            Close()
                        Else
                            MsgBox("Invalid squeegee.")
                            txtOldA.Enabled = True
                            txtOldB.Enabled = False
                            txtNewA.Enabled = False
                            txtNewB.Enabled = False
                            txtOldA.Focus()

                            txtOldA.Text = ""
                            txtOldB.Text = ""
                            txtNewA.Text = ""
                            txtNewB.Text = ""
                        End If
                    Else
                        txtOldA.Enabled = True
                        txtOldB.Enabled = False
                        txtNewA.Enabled = False
                        txtNewB.Enabled = False
                        txtOldA.Focus()

                        txtOldA.Text = ""
                        txtOldB.Text = ""
                        txtNewA.Text = ""
                        txtNewB.Text = ""
                    End If
                End If
            Else
                MsgBox("Invalid set of squeegee blade")
                txtOldA.Enabled = True
                txtOldB.Enabled = False
                txtNewA.Enabled = False
                txtNewB.Enabled = False
                txtOldA.Focus()

                txtOldA.Text = ""
                txtOldB.Text = ""
                txtNewA.Text = ""
                txtNewB.Text = ""
            End If
        End If
    End Sub

    Private Sub txtOldA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOldA.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtOldB.Enabled = True
            txtOldB.Focus()
            txtOldA.Enabled = False
        End If
    End Sub

    Private Sub txtOldB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOldB.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNewA.Enabled = True
            txtNewA.Focus()
            txtOldB.Enabled = False
        End If
    End Sub

    Private Sub frmreplacesqueegee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOldA.Enabled = True
        txtOldA.Focus()
    End Sub
    Private Sub replace(ByVal oldA, ByVal oldB, ByVal newA, ByVal newB, ByVal Line)
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

    End Sub
End Class