Imports Transitions
Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class frmsqueegeemanager
    Public cmsn As String

    Private Sub animateBounce_Tick(sender As Object, e As EventArgs) Handles animateBounce.Tick
        Try
            If pbSqueegee1A.BackColor = Color.Red Then
                Transition.run(pbSqueegee1A, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee2A.BackColor = Color.Red Then
                Transition.run(pbSqueegee2A, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee6A.BackColor = Color.Red Then
                Transition.run(pbSqueegee6A, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee12A.BackColor = Color.Red Then
                Transition.run(pbSqueegee12A, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee14A.BackColor = Color.Red Then
                Transition.run(pbSqueegee14A, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee15A.BackColor = Color.Red Then
                Transition.run(pbSqueegee15A, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee17A.BackColor = Color.Red Then
                Transition.run(pbSqueegee17A, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If


            If pbSqueegee1B.BackColor = Color.Red Then
                Transition.run(pbSqueegee1B, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee2B.BackColor = Color.Red Then
                Transition.run(pbSqueegee2B, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee6B.BackColor = Color.Red Then
                Transition.run(pbSqueegee6B, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee12B.BackColor = Color.Red Then
                Transition.run(pbSqueegee12B, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee14B.BackColor = Color.Red Then
                Transition.run(pbSqueegee14B, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee15B.BackColor = Color.Red Then
                Transition.run(pbSqueegee15B, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If
            If pbSqueegee17B.BackColor = Color.Red Then
                Transition.run(pbSqueegee17B, "Top", 445, New TransitionType_ThrowAndCatch(500))
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        cmsn = ctsMenu.SourceControl.Name
        frmremovesqueegee.Show()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        cmsn = ctsMenu.SourceControl.Name
        frmreplacesqueegee.Show()
    End Sub

    Private Sub txtSqueegeeA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSqueegeeA.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtSqueegeeA.Enabled = False
            txtSqueegeeB.Enabled = True
            txtSqueegeeB.Focus()
        End If
    End Sub
    Private Sub txtSqueegeeB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSqueegeeB.KeyPress
        If Asc(e.KeyChar) = 13 Then
            decode(txtSqueegeeB.Text)
        End If
    End Sub
    Private Sub decode(ByVal code As String)
        If code.Length = 17 Then
            If txtSqueegeeA.Text.Substring(0, 16) = txtSqueegeeB.Text.Substring(0, 16) And txtSqueegeeA.Text <> txtSqueegeeB.Text Then
                Dim machine As String = code.Substring(0, 3)
                Dim dateYYYY As String = code.Substring(6, 4)
                Dim dateMM As String = code.Substring(4, 2)
                Dim serial As String = code.Substring(11, 4)
                Dim FR As String = code.Substring(16, 1)
                txtSqueegeeB.Enabled = False
                cmbActions.Focus()
            Else
                MsgBox("Invalid pair")
                txtSqueegeeA.Enabled = True
                txtSqueegeeB.Enabled = False
                txtSqueegeeA.Text = ""
                txtSqueegeeB.Text = ""
                txtSqueegeeA.Focus()
            End If
        Else
            MsgBox("Invalid pair")
            txtSqueegeeA.Enabled = True
            txtSqueegeeB.Enabled = False
            txtSqueegeeA.Text = ""
            txtSqueegeeB.Text = ""
            txtSqueegeeA.Focus()
        End If
    End Sub

    Private Sub txtSqueegee_TextChanged(sender As Object, e As EventArgs) Handles txtSqueegeeA.TextChanged

    End Sub
    Private Sub txtSqueegeeB_TextChanged(sender As Object, e As EventArgs) Handles txtSqueegeeB.TextChanged
        If txtSqueegeeA.Text.Length = 17 And txtSqueegeeB.Text.Length = 17 Then
            If txtSqueegeeA.Text.Substring(0, 16) = txtSqueegeeB.Text.Substring(0, 16) And txtSqueegeeA.Text <> txtSqueegeeB.Text Then
                cmbActions.Enabled = True
                btnOK.Enabled = True
            End If
        Else
            cmbActions.Enabled = False
            btnOK.Enabled = False
        End If
    End Sub

    Private Sub frmsqueegeemanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        dbConnect()
        lblAssemblyVersion.Text = "Version " & frmlogin.assemblyVersion & " (Pre-Release)"

        'Dim cmd As New MySqlCommand
        'Dim myDT As New DataTable
        'Dim myDA As New MySqlDataAdapter(cmd)
        'Dim dvStorage As DataView

        'cmd.Connection = conn
        'cmd.CommandText = "SELECT * FROM view_squeegee"
        'myDA.Fill(myDT)

        'dvStorage = New DataView(myDT, "location = 'storage'", "squeegeeid asc", DataViewRowState.CurrentRows)
        'dgStore.DataSource = dvStorage
        'dgStore.Columns.Remove("location")

        refreshSqueegee()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            Dim cmd As New MySqlCommand
            Dim myDT As New DataTable
            Dim myDA As New MySqlDataAdapter(cmd)

            cmd.Connection = conn

            Select Case cmbActions.Text
                Case "Register"
                    cmd.CommandText = "INSERT INTO gi_squeegee(squeegeeid, registrationdate, location, position, timestamp) VALUES('" & txtSqueegeeA.Text & "', curdate(), 'storage', 'front', NOW()) ON DUPLICATE KEY UPDATE location = 'storage', position = 'front', timestamp = NOW()"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "INSERT INTO gi_squeegee(squeegeeid, registrationdate, location, position, timestamp) VALUES('" & txtSqueegeeB.Text & "', curdate(), 'storage', 'rear', NOW()) ON DUPLICATE KEY UPDATE location = 'storage', position = 'rear', timestamp = NOW()"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" & txtSqueegeeA.Text & "', NOW(), 'NEW SQUEEGEE BLADE REGISTRATION', 'storage', '" & lblName.Text & "')"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" & txtSqueegeeB.Text & "', NOW(), 'NEW SQUEEGEE BLADE REGISTRATION', 'storage', '" & lblName.Text & "')"
                    cmd.ExecuteNonQuery()
                    txtSqueegeeA.Text = ""
                    txtSqueegeeB.Text = ""
                    lblMachine.Text = ""
                    lblLocation.Text = ""
                    lblDateReceived.Text = ""
                    txtSqueegeeA.Enabled = True
                    txtSqueegeeB.Enabled = True
                    MsgBox("Registration successful!")
                    txtSqueegeeA.Focus()
                    refreshSqueegee()
                Case "Issue to Line"
                    frmissuesqueegee.Show()
                    Me.Enabled = False
                    txtSqueegeeA.Enabled = True
                    txtSqueegeeA.Focus()
                Case "Store"
                    cmd.CommandText = "INSERT INTO gi_squeegee(squeegeeid, registrationdate, location, timestamp) VALUES('" + txtSqueegeeA.Text + "', curdate(), 'storage', NOW()) ON DUPLICATE KEY UPDATE location = 'storage'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + txtSqueegeeA.Text + "', NOW(), 'STORE', 'storage', '" + lblName.Text + "')"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "INSERT INTO gi_squeegee(squeegeeid, registrationdate, location, timestamp) VALUES('" + txtSqueegeeB.Text + "', curdate(), 'storage', NOW()) ON DUPLICATE KEY UPDATE location = 'storage'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + txtSqueegeeB.Text + "', NOW(), 'STORE', 'storage', '" + lblName.Text + "')"
                    cmd.ExecuteNonQuery()
                    txtSqueegeeA.Text = ""
                    txtSqueegeeB.Text = ""
                    lblMachine.Text = ""
                    lblLocation.Text = ""
                    lblDateReceived.Text = ""
                    txtSqueegeeA.Enabled = True
                    txtSqueegeeB.Enabled = True
                    cmbActions.Text = ""
                    txtSqueegeeA.Focus()
                    refreshSqueegee()
                Case "End of Life"
                    frmSqueegeeEOLRemarks.Show()
                    Me.Enabled = False
                Case "View History"
                    frmSqueegeeLogs.Show()
                    Me.Enabled = False
            End Select
            tmrRefreshInfo.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub tmrRefreshInfo_Tick(sender As Object, e As EventArgs) Handles tmrRefreshInfo.Tick
        refreshSqueegee()
    End Sub

    Private Sub tmrRefreshLine_Tick(sender As Object, e As EventArgs) Handles tmrRefreshLine.Tick
        If lblQR1A.Text <> "" Then
            Select Case Val(lblRemainingLife1.Text)
                Case 20001 To 60000
                    pbSqueegee1A.BackColor = Color.Green
                    pbSqueegee1B.BackColor = Color.Green
                    pbSqueegee1A.Visible = True
                Case 5001 To 20000
                    pbSqueegee1A.BackColor = Color.Yellow
                    pbSqueegee1B.BackColor = Color.Yellow
                    pbSqueegee1A.Visible = True
                Case 1 To 5000
                    pbSqueegee1A.BackColor = Color.Red
                    pbSqueegee1B.BackColor = Color.Red
                    pbSqueegee1A.Visible = True
                Case <= 0
                    pbSqueegee1A.BackColor = Color.Silver
                    pbSqueegee1B.BackColor = Color.Silver
                    pbSqueegee1A.Visible = True
                Case "0"
                    pbSqueegee1A.Visible = False
                    pbSqueegee1B.Visible = False
            End Select
        Else
            pbSqueegee1A.BackColor = Color.Gray
            pbSqueegee1B.BackColor = Color.Gray
        End If
        If lblQR2A.Text <> "" Then
            Select Case Val(lblRemainingLife2.Text)
                Case 20001 To 60000
                    pbSqueegee2A.BackColor = Color.Green
                    pbSqueegee2B.BackColor = Color.Green
                    pbSqueegee2A.Visible = True
                Case 5001 To 20000
                    pbSqueegee2A.BackColor = Color.Yellow
                    pbSqueegee2B.BackColor = Color.Yellow
                    pbSqueegee2A.Visible = True
                Case 1 To 5000
                    pbSqueegee2A.BackColor = Color.Red
                    pbSqueegee2B.BackColor = Color.Red
                    pbSqueegee2A.Visible = True
                Case <= 0
                    pbSqueegee2A.BackColor = Color.Silver
                    pbSqueegee2B.BackColor = Color.Silver
                    pbSqueegee2A.Visible = True
                Case "0"
                    pbSqueegee2A.Visible = False
                    pbSqueegee2B.Visible = False
            End Select
        Else
            pbSqueegee2A.BackColor = Color.Gray
            pbSqueegee2B.BackColor = Color.Gray
        End If
        If lblQR6A.Text <> "" Then
            Select Case Val(lblRemainingLife6.Text)
                Case 20001 To 60000
                    pbSqueegee6A.BackColor = Color.Green
                    pbSqueegee6B.BackColor = Color.Green
                    pbSqueegee6A.Visible = True
                Case 5001 To 20000
                    pbSqueegee6A.BackColor = Color.Yellow
                    pbSqueegee6B.BackColor = Color.Yellow
                    pbSqueegee6A.Visible = True
                Case 1 To 5000
                    pbSqueegee6A.BackColor = Color.Red
                    pbSqueegee6B.BackColor = Color.Red
                    pbSqueegee6A.Visible = True
                Case <= 0
                    pbSqueegee6A.BackColor = Color.Silver
                    pbSqueegee6B.BackColor = Color.Silver
                    pbSqueegee6A.Visible = True
                Case "0"
                    pbSqueegee6A.Visible = False
                    pbSqueegee6B.Visible = False
            End Select
        Else
            pbSqueegee6A.BackColor = Color.Gray
            pbSqueegee6B.BackColor = Color.Gray
        End If
        If lblQR12A.Text <> "" Then
            Select Case Val(lblRemainingLife12.Text)
                Case 20001 To 60000
                    pbSqueegee12A.BackColor = Color.Green
                    pbSqueegee12B.BackColor = Color.Green
                    pbSqueegee12A.Visible = True
                Case 5001 To 20000
                    pbSqueegee12A.BackColor = Color.Yellow
                    pbSqueegee12B.BackColor = Color.Yellow
                    pbSqueegee12A.Visible = True
                Case 1 To 5000
                    pbSqueegee12A.BackColor = Color.Red
                    pbSqueegee12B.BackColor = Color.Red
                    pbSqueegee12A.Visible = True
                Case <= 0
                    pbSqueegee12A.BackColor = Color.Silver
                    pbSqueegee12B.BackColor = Color.Silver
                    pbSqueegee12A.Visible = True
                Case "0"
                    pbSqueegee12A.Visible = False
                    pbSqueegee12B.Visible = False
            End Select
        Else
            pbSqueegee12A.BackColor = Color.Gray
            pbSqueegee12B.BackColor = Color.Gray
        End If
        If lblQR14A.Text <> "" Then
            Select Case Val(lblRemainingLife14.Text)
                Case 20001 To 60000
                    pbSqueegee14A.BackColor = Color.Green
                    pbSqueegee14B.BackColor = Color.Green
                    pbSqueegee14A.Visible = True
                Case 5001 To 20000
                    pbSqueegee14A.BackColor = Color.Yellow
                    pbSqueegee14B.BackColor = Color.Yellow
                    pbSqueegee14A.Visible = True
                Case 1 To 5000
                    pbSqueegee14A.BackColor = Color.Red
                    pbSqueegee14B.BackColor = Color.Red
                    pbSqueegee14A.Visible = True
                Case <= 0
                    pbSqueegee14A.BackColor = Color.Silver
                    pbSqueegee14B.BackColor = Color.Silver
                    pbSqueegee14A.Visible = True
                Case "0"
                    pbSqueegee14A.Visible = False
                    pbSqueegee14B.Visible = False
            End Select
        Else
            pbSqueegee14A.BackColor = Color.Gray
            pbSqueegee14B.BackColor = Color.Gray
        End If
        If lblQR15A.Text <> "" Then
            Select Case Val(lblRemainingLife15.Text)
                Case 20001 To 60000
                    pbSqueegee15A.BackColor = Color.Green
                    pbSqueegee15B.BackColor = Color.Green
                    pbSqueegee15A.Visible = True
                Case 5001 To 20000
                    pbSqueegee15A.BackColor = Color.Yellow
                    pbSqueegee15B.BackColor = Color.Yellow
                    pbSqueegee15A.Visible = True
                Case 1 To 5000
                    pbSqueegee15A.BackColor = Color.Red
                    pbSqueegee15B.BackColor = Color.Red
                    pbSqueegee15A.Visible = True
                Case <= 0
                    pbSqueegee15A.BackColor = Color.Silver
                    pbSqueegee15B.BackColor = Color.Silver
                    pbSqueegee15A.Visible = True
                Case "0"
                    pbSqueegee15A.Visible = False
                    pbSqueegee15B.Visible = False
            End Select
        Else
            pbSqueegee15A.BackColor = Color.Gray
            pbSqueegee15B.BackColor = Color.Gray
        End If
        If lblQR17A.Text <> "" Then
            Select Case Val(lblRemainingLife17.Text)
                Case 20001 To 60000
                    pbSqueegee17A.BackColor = Color.Green
                    pbSqueegee17B.BackColor = Color.Green
                    pbSqueegee17A.Visible = True
                Case 5001 To 20000
                    pbSqueegee17A.BackColor = Color.Yellow
                    pbSqueegee17B.BackColor = Color.Yellow
                    pbSqueegee17A.Visible = True
                Case 1 To 5000
                    pbSqueegee17A.BackColor = Color.Red
                    pbSqueegee17B.BackColor = Color.Red
                    pbSqueegee17A.Visible = True
                Case <= 0
                    pbSqueegee17A.BackColor = Color.Silver
                    pbSqueegee17B.BackColor = Color.Silver
                    pbSqueegee17A.Visible = True
                Case "0"
                    pbSqueegee17A.Visible = False
                    pbSqueegee17B.Visible = False
            End Select
        Else
            pbSqueegee17A.BackColor = Color.Gray
            pbSqueegee17B.BackColor = Color.Gray
        End If


    End Sub

    Private Sub frmsqueegeemanager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If txtprevprocess.Text = "INJECTION" Then
            frminjection.bladeissuance()
            frminjection.squeegeemin()
        End If
    End Sub

    Public Sub refreshSqueegee()
        lblQR1A.Text = ""
        lblQR2A.Text = ""
        lblQR15A.Text = ""
        lblQR6A.Text = ""
        lblQR12A.Text = ""
        lblQR14A.Text = ""
        lblQR17A.Text = ""

        lblQR1B.Text = ""
        lblQR2B.Text = ""
        lblQR15B.Text = ""
        lblQR6B.Text = ""
        lblQR12B.Text = ""
        lblQR14B.Text = ""
        lblQR17B.Text = ""

        lblRemainingLife1.Text = ""
        lblRemainingLife2.Text = ""
        lblRemainingLife15.Text = ""
        lblRemainingLife6.Text = ""
        lblRemainingLife12.Text = ""
        lblRemainingLife14.Text = ""
        lblRemainingLife17.Text = ""


        Dim cmd As New MySqlCommand
        Dim myDT As New DataTable
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim dvStorage As DataView
        Dim dvLine1 As DataView
        Dim dvLine2 As DataView
        Dim dvLine6 As DataView
        Dim dvLine12 As DataView
        Dim dvLine14 As DataView
        Dim dvLine15 As DataView
        Dim dvLine17 As DataView

        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM gi_view_squeegee"
        myDA.Fill(myDT)

        dvStorage = New DataView(myDT, "location = 'storage'", "squeegeeid asc", DataViewRowState.CurrentRows)
        dgStore.DataSource = dvStorage
        dgStore.Columns.Remove("location")

        dvLine1 = New DataView(myDT, "location = 'Line 1'", "squeegeeid asc", DataViewRowState.CurrentRows)
        If dvLine1.Count > 1 Then
            lblQR1A.Text = dvLine1.Item(0).Item(0).ToString()
            lblQR1B.Text = dvLine1.Item(1).Item(0).ToString()
            lblRemainingLife1.Text = dvLine1.Item(0).Item(3).ToString()
        End If

        dvLine2 = New DataView(myDT, "location = 'Line 2'", "squeegeeid asc", DataViewRowState.CurrentRows)
        If dvLine2.Count > 1 Then
            lblQR2A.Text = dvLine2.Item(0).Item(0).ToString()
            lblQR2B.Text = dvLine2.Item(1).Item(0).ToString()
            lblRemainingLife2.Text = dvLine2.Item(0).Item(3).ToString()
        End If

        dvLine6 = New DataView(myDT, "location = 'Line 6'", "squeegeeid asc", DataViewRowState.CurrentRows)
        If dvLine6.Count > 1 Then
            lblQR6A.Text = dvLine6.Item(0).Item(0).ToString()
            lblQR6B.Text = dvLine6.Item(1).Item(0).ToString()
            lblRemainingLife6.Text = dvLine6.Item(0).Item(3).ToString()
        End If

        dvLine12 = New DataView(myDT, "location = 'Line 12'", "squeegeeid asc", DataViewRowState.CurrentRows)
        If dvLine12.Count > 1 Then
            lblQR12A.Text = dvLine12.Item(0).Item(0).ToString()
            lblQR12B.Text = dvLine12.Item(1).Item(0).ToString()
            lblRemainingLife12.Text = dvLine12.Item(0).Item(3).ToString()
        End If

        dvLine14 = New DataView(myDT, "location = 'Line 14'", "squeegeeid asc", DataViewRowState.CurrentRows)
        If dvLine14.Count > 1 Then
            lblQR14A.Text = dvLine14.Item(0).Item(0).ToString()
            lblQR14B.Text = dvLine14.Item(1).Item(0).ToString()
            lblRemainingLife14.Text = dvLine14.Item(0).Item(3).ToString()
        End If

        dvLine15 = New DataView(myDT, "location = 'Line 15'", "squeegeeid asc", DataViewRowState.CurrentRows)
        If dvLine15.Count > 1 Then
            lblQR15A.Text = dvLine15.Item(0).Item(0).ToString()
            lblQR15B.Text = dvLine15.Item(1).Item(0).ToString()
            lblRemainingLife15.Text = dvLine15.Item(0).Item(3).ToString()
        End If

        dvLine17 = New DataView(myDT, "location = 'Line 17'", "squeegeeid asc", DataViewRowState.CurrentRows)
        If dvLine17.Count > 1 Then
            lblQR17A.Text = dvLine17.Item(0).Item(0).ToString()
            lblQR17B.Text = dvLine17.Item(1).Item(0).ToString()
            lblRemainingLife17.Text = dvLine17.Item(0).Item(3).ToString()
        End If

        lblCount.Text = dvStorage.Count
    End Sub
End Class