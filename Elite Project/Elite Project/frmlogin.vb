Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Net.Sockets
Imports System.Reflection

Public Class frmlogin
    Public startMonth, startYear, assemblyVersion As String
    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            assemblyVersion = Assembly.GetExecutingAssembly.GetName.Version.ToString
            dbConnect()
            lbldt.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")

            writeLogs("ELITE Login")
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT `value` FROM `settings` WHERE `name` = 'e_gi_line'"
            lineString = cmd.ExecuteScalar.ToString.Split(",")
            cmbline.Items.Clear()
            For i = 0 To lineString.Length - 1
                cmbline.Items.Add(lineString(i).ToUpper)
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim strIP As String
        strIP = GetIPAddress()

        If strIP = "137.105.2.4" Then
            cmbstation.Items.Add("MOUNTER FUJI - BOTTOM")
            cmbstation.Items.Add("MOUNTER FUJI - TOP")
        Else
            cmbstation.Items.Add("MOUNTER PANASONIC - BOTTOM")
            cmbstation.Items.Add("MOUNTER PANASONIC - TOP")
            cmbstation.Items.Add("MOUNTER FUJI - BOTTOM")
            cmbstation.Items.Add("MOUNTER FUJI - TOP")
        End If

        'writeLogs("ELITE Login", cmd.ExecuteScalar().ToString())
    End Sub

    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
        Try
            If txtid.Text.Length > 6 Then
                txtpass.Enabled = True
            Else
                txtpass.Enabled = False
            End If
            If Asc(e.KeyChar) = 13 Then
                Dim cmd As New MySqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                lblname.Text = cmd.ExecuteScalar
                txtpass.Focus()
                writeLogs(txtid.Text + " " + lblname.Text + " " + cmbline.Text + " " + cmbstation.Text)

                If lblname.Text = "" Then
                    writeLogs("User is not Registered")
                    MsgBox("User is not Registered")
                    txtid.Focus()
                    txtid.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Application.Exit()

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            If cmbline.Text = "" Then
                MsgBox("Please select line")
                cmbline.Focus()
            Else
                cmd.CommandText = "SELECT COUNT(*) FROM tbluser WHERE userid = '" + txtid.Text + "' AND password = md5('" + txtpass.Text + "')"
                If cmd.ExecuteScalar.ToString() = "1" Then
                    If cmbstation.Text = "MOUNTER PANASONIC - TOP" Then
                        cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                        lblname.Text = cmd.ExecuteScalar
                        frmpanasonicmounter.lblname.Text = lblname.Text
                        frmpanasonicmounter.lblline.Text = cmbline.Text
                        frmpanasonicmounter.lblstation.Text = cmbstation.Text
                        frmpanasonicmounter.Show()
                        txtpass.Text = ""
                        lblname.Text = ""
                        cmbline.Text = ""
                        cmbstation.Text = ""
                        lbllevel.Text = ""
                        Hide()
                    ElseIf cmbstation.Text = "MOUNTER PANASONIC - BOTTOM" Then
                        cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                        lblname.Text = cmd.ExecuteScalar
                        frmpanasonicmounter.lblname.Text = lblname.Text
                        frmpanasonicmounter.lblline.Text = cmbline.Text
                        frmpanasonicmounter.lblstation.Text = cmbstation.Text
                        frmpanasonicmounter.Show()
                        txtpass.Text = ""
                        lblname.Text = ""
                        cmbline.Text = ""
                        cmbstation.Text = ""
                        lbllevel.Text = ""
                        Hide()
                    ElseIf cmbstation.Text.Contains("INJECTION") Then
                        cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                        lblname.Text = cmd.ExecuteScalar
                        frminjection.lblname.Text = lblname.Text
                        frminjection.lblline.Text = cmbline.Text
                        frminjection.lblstation.Text = cmbstation.Text
                        frminjection.Show()
                        txtpass.Text = ""
                        lblname.Text = ""
                        cmbline.Text = ""
                        cmbstation.Text = ""
                        lbllevel.Text = ""
                        Hide()
                    ElseIf cmbstation.Text = "AOI - TOP" Then
                        cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                        lblname.Text = cmd.ExecuteScalar
                        frmAOI.lblname.Text = lblname.Text
                        frmAOI.lblline.Text = cmbline.Text
                        frmAOI.lblStation.Text = cmbstation.Text
                        'frmAOI.CountNG()
                        frmAOI.Show()
                        txtpass.Text = ""
                        lblname.Text = ""
                        cmbline.Text = ""
                        lbllevel.Text = ""
                        cmbstation.Text = ""
                        Hide()
                    ElseIf cmbstation.Text = "AOI - BOTTOM" Then
                        cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                        lblname.Text = cmd.ExecuteScalar
                        frmAOI.lblname.Text = lblname.Text
                        frmAOI.lblline.Text = cmbline.Text
                        frmAOI.lblStation.Text = cmbstation.Text
                        'frmAOI.CountNG()
                        frmAOI.Show()
                        txtpass.Text = ""
                        lblname.Text = ""
                        cmbline.Text = ""
                        lbllevel.Text = ""
                        cmbstation.Text = ""
                        Hide()
                    ElseIf cmbstation.Text = "FVI" Then
                        cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                        lblname.Text = cmd.ExecuteScalar
                        frmFVI.lblname.Text = lblname.Text
                        frmFVI.lblline.Text = cmbline.Text
                        frmFVI.lblStation.Text = cmbstation.Text
                        'frmAOI.CountNG()
                        frmFVI.Show()
                        txtpass.Text = ""
                        lblname.Text = ""
                        cmbline.Text = ""
                        lbllevel.Text = ""
                        cmbstation.Text = ""
                        Hide()
                    ElseIf cmbstation.Text = "MOUNTER FUJI - BOTTOM" Then
                        cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                        lblname.Text = cmd.ExecuteScalar
                        frmfujimounter.lblname.Text = lblname.Text
                        frmfujimounter.lblline.Text = cmbline.Text
                        frmfujimounter.lblstation.Text = cmbstation.Text
                        frmfujimounter.Show()
                        txtpass.Text = ""
                        lblname.Text = ""
                        cmbline.Text = ""
                        cmbstation.Text = ""
                        lbllevel.Text = ""
                        Hide()
                    ElseIf cmbstation.Text = "MOUNTER FUJI - TOP" Then
                        cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                        lblname.Text = cmd.ExecuteScalar
                        frmfujimounter.lblname.Text = lblname.Text
                        frmfujimounter.lblline.Text = cmbline.Text
                        frmfujimounter.lblstation.Text = cmbstation.Text
                        frmfujimounter.Show()
                        txtpass.Text = ""
                        lblname.Text = ""
                        cmbline.Text = ""
                        cmbstation.Text = ""
                        lbllevel.Text = ""
                        Hide()
                    ElseIf cmbstation.Text = "OBA" Then
                        cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                        lblname.Text = cmd.ExecuteScalar
                        frmOBA.lblname.Text = lblname.Text
                        frmOBA.lblline.Text = cmbline.Text
                        frmOBA.lblStation.Text = cmbstation.Text
                        'frmAOI.CountNG()
                        frmOBA.Show()
                        txtpass.Text = ""
                        lblname.Text = ""
                        cmbline.Text = ""
                        lbllevel.Text = ""
                        cmbstation.Text = ""
                        Hide()
                    ElseIf cmbstation.Text = "IC PROGRAMMING" Then
                        cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                        lblname.Text = cmd.ExecuteScalar
                        frmICProgram.lblname.Text = lblname.Text
                        frmICProgram.lblline.Text = cmbline.Text
                        frmICProgram.lblStation.Text = cmbstation.Text
                        frmICProgram.Show()
                        txtpass.Text = ""
                        lblname.Text = ""
                        cmbline.Text = ""
                        lbllevel.Text = ""
                        cmbstation.Text = ""
                        Hide()
                    ElseIf cmbstation.Text = "NO SCANNING" Then
                        cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
                        lblname.Text = cmd.ExecuteScalar
                        frmnoscanning.lblname.Text = lblname.Text
                        frmnoscanning.lblline.Text = cmbline.Text
                        frmnoscanning.lblstation.Text = cmbstation.Text
                        frmnoscanning.Show()
                        txtpass.Text = ""
                        lblname.Text = ""
                        cmbline.Text = ""
                        lbllevel.Text = ""
                        cmbstation.Text = ""
                        Hide()
                    End If

                    writeLogs("Login Successful: " & txtid.Text)
                    txtid.Text = ""
                Else
                    writeLogs("Login Denied: " & txtid.Text)
                    MsgBox("Access Denied")
                    txtpass.Text = ""
                    txtpass.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnlogin_Click(sender, e)
        End If
    End Sub

    Private Sub frmlogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        btncancel_Click(sender, e)
    End Sub
    '=====================================================================================
    'Log File generator
    Public Sub Log(logMessage As String, w As TextWriter)
        w.WriteLine("{0} {2}", Now.ToString("yyyy-MM-dd HH:mm:ss"), "  :{0}", logMessage)
    End Sub

    Private Sub txtid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtid.KeyDown
        If e.KeyCode = Keys.Tab Then
            e.SuppressKeyPress = True
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT empname FROM tbluser WHERE userid = '" + txtid.Text + "'"
            lblname.Text = cmd.ExecuteScalar
            txtpass.Focus()
            writeLogs(txtid.Text + " " + lblname.Text + " " + cmbline.Text + " " + cmbstation.Text)
            If lblname.Text = "" Then
                writeLogs("User is not Registered")
                MsgBox("User is not Registered")
                txtid.Focus()
                txtid.Text = ""
            End If
        End If
    End Sub
    Private Function GetIPAddress() As String
        Dim IPList As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)
        For Each IPaddress In IPList.AddressList
            If (IPaddress.AddressFamily = AddressFamily.InterNetwork) Then
                Return IPaddress.ToString
            End If
        Next
        Return ""
    End Function

    Private Sub cmbstation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbstation.SelectedIndexChanged
        txtid.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldt.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub writeLogs(message As String)
        Dim mainDir As String = "C:\eliteonline\scanning\"
        Dim secondaryDir As String = "C:\41388badb2ff52b7b4b73ae9cc50fad3\721aec3fbaaa868e9cdafb2012e98567\"
        Dim publicDir As String = "C:\scanninglogs\"
        Dim mainFile As String = ""
        Dim secondaryFile As String = ""
        Dim publicFile As String = ""
        Dim monthYear As String

        If (Not Directory.Exists(mainDir)) Then
            Directory.CreateDirectory(mainDir)
        End If

        If (Not Directory.Exists(secondaryDir)) Then
            Directory.CreateDirectory(secondaryDir)
        End If

        If (Not Directory.Exists(publicDir)) Then
            Directory.CreateDirectory(publicDir)
        End If

        monthYear = Now.ToString("yyyyMM")

        If Not My.Computer.FileSystem.FileExists(mainDir & monthYear & "-log.txt") Then
            File.Create(mainDir & monthYear & "-log.txt").Dispose()
        End If
        If Not My.Computer.FileSystem.FileExists(secondaryDir & monthYear & "-log.txt") Then
            File.Create(secondaryDir & monthYear & "-log.txt").Dispose()
        End If
        If Not My.Computer.FileSystem.FileExists(publicDir & monthYear & "-log.txt") Then
            File.Create(publicDir & monthYear & "-log.txt").Dispose()
        End If

        mainFile = mainDir & monthYear & "-log.txt"
        secondaryFile = secondaryDir & monthYear & "-log.txt"
        publicFile = publicDir & monthYear & "-log.txt"

        Using swm As StreamWriter = File.AppendText(mainFile)
            swm.WriteLine("{0} {2}", lbldt.Text, "  :{0}", message)
        End Using

        Using sws As StreamWriter = File.AppendText(secondaryFile)
            sws.WriteLine("{0} {2}", lbldt.Text, "  :{0}", message)
        End Using

        Using swp As StreamWriter = File.AppendText(publicFile)
            swp.WriteLine("{0} {2}", lbldt.Text, "  :{0}", message)
        End Using
    End Sub
End Class
