Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmrepairaoi

    Dim modelMatrixID As String

    Private Sub txtScan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScan.KeyPress
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        If Asc(e.KeyChar) = 13 Then
            writeLogs(lblScan.Text.Replace(":", "") & "SCAN: " & txtScan.Text)
            Try
                If lblScan.Text = "SCAN PANEL:" Then
                    cmd.CommandText = "UPDATE gi_repairtrace SET aoistatus_top = 'good', aoitimestamp_top = NOW(), aoiremarks_top = '" & txtremarks.Text & "',processtoken = 'aoi_top'  WHERE pcbid = '" & txtScan.Text & "' AND (processtoken = 'repair_tr' or processtoken = 'repair_ra' processtoken = 'repair_rc')"
                    If cmd.ExecuteNonQuery <> 1 Then
                        Select Case examinePCB(txtScan.Text)
                            Case "Wrong model"
                                MessageBox.Show("Wrong model. Please verify.")
                                writeLogs("ERROR: Wrong model. Please verify.")
                            Case "Wrong token"
                                MessageBox.Show("PCB did not pass previous process.")
                                writeLogs("ERROR: PCB did not pass previous process.")
                            Case "No Repair"
                                MessageBox.Show("No Repair Data.")
                                writeLogs("ERROR: No Repair Data.")
                            Case "unknown"
                                MessageBox.Show("Unknown PCB. Maybe not registered at injection station. Please call systems support for verification.")
                                writeLogs("ERROR: Unknown PCB. Maybe not registered at injection station. Please call systems support for verification.")
                        End Select
                    End If


                    CountGood()
                    gridout()
                    txtScan.Text = ""
                    txtScan.Focus()
                Else
                    If txtremarks.Text = "" Or cmbdefectname.Text = "" Then
                        MsgBox("Please complete all necessary information")
                        writeLogs("ERROR: Please complete all necessary information")
                    Else
                        cmd.CommandText = "UPDATE gi_repairtrace SET aoistatus_top = 'ng', aoitimestamp_top = NOW(), aoiremarks_top = '" & txtremarks.Text & "',processtoken = 'aoi_top'  WHERE pcbid = '" & txtScan.Text & "' AND (processtoken = 'repair_tr' or processtoken = 'repair_ra' processtoken = 'repair_rc')"
                        cmd.ExecuteNonQuery()
                        If cmd.ExecuteNonQuery() = 0 Then
                            MsgBox("Either the Panel was not scanned or PCB already passed the next process")
                            writeLogs("ERROR: Either the Panel was not scanned or PCB already passed the next process")
                        Else
                            InsertNG()
                        End If
                    End If
                    CountGood()
                    gridout()
                    cmbdefectname.Text = ""
                    txtremarks.Text = ""
                    txtScan.Text = ""
                End If
            Catch ex As Exception
                MsgBox("Invalid Panel/PCB ID")
                writeLogs("ERROR: Invalid Panel/PCB ID")
                MsgBox(ex.ToString)
                writeLogs(ex.ToString)
                txtScan.Text = ""
                txtScan.Focus()
            End Try
        End If
    End Sub

    Private Function examinePCB(scantext As String) As String
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Dim res As String
        res = ""
        Try


            cmd.CommandText = "SELECT `modelmatrixid` FROM `gi_pcbtrace` WHERE `pcbid` =  '" + scantext + "'"
            If cmd.ExecuteScalar <> modelMatrixID Then
                res = "Wrong model"
            Else
                cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_repairtrace WHERE  `pcbid` =  '" + scantext + "'"
                If cmd.ExecuteScalar = 0 Then
                    res = "No Repair"
                Else
                    cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_repairtrace WHERE  `pcbid` =  '" + scantext + "' AND  (processtoken = 'repair_tr' or processtoken = 'repair_ra' processtoken = 'repair_rc')"
                    If cmd.ExecuteScalar = 0 Then
                        res = "Wrong token"
                    End If
                End If
            End If
        Catch ex As Exception
            res = "unknown"
        End Try
        examinePCB = res
    End Function

    Public Sub InsertNG()

        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "INSERT INTO gi_repairaoing_top (`pcbid`, `aoingtimestamp`, `judgement`, `defectname`, `remarks`, `aoioperator`, `line`) VALUES ('" & txtScan.Text & "', NOW(), 'ng', '" & cmbdefectname.Text & "','" & txtremarks.Text & "', '" & lblname.Text & "', '" & lblline.Text & "')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tblPnlDefect.BackColor = Color.Red Then
            tblPnlDefect.BackColor = Color.White
        Else
            tblPnlDefect.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnGOOD_Click(sender As Object, e As EventArgs) Handles btnGOOD.Click
        Try

            Timer1.Enabled = False
            tblPnlMain.BackColor = Color.White
            tblPnlDefect.BackColor = Color.White
            tblPnlMain.BackgroundImage = ELITE_GI.My.Resources.Resources.elite_background_GI_214
            Timer2.Enabled = False
            lblScan.Text = "SCAN PANEL:"
            lblScan.ForeColor = Color.Black
            cmbdefectname.Text = ""
            cmbdefectname.Enabled = False
            txtremarks.Enabled = False
            txtremarks.Text = ""
            btnNG.Enabled = True
            txtScan.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub frmrepairaoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbConnect()
        txtScan.Focus()
        Timer1.Enabled = False
        tblPnlMain.BackColor = Color.White
        tblPnlDefect.BackColor = Color.White
        Timer2.Enabled = False
        CountGood()
        txtScan.Focus()

        lblAssemblyVersion.Text = "Version " & frmlogin.assemblyVersion & " (Pre-Release)"
    End Sub

    Public Sub CountGood()
        Dim cmd As New MySqlCommand
        Dim input As Integer
        Dim ng As Integer
        Dim good As Integer

        cmd.Connection = conn
        Dim h As Integer

        h = Date.Now.Hour
        If h >= 7 And h <= 18 Then
            cmd.CommandText = "SELECT SUM(count) FROM gi_view_aoi_input_day_" + lblline.Text + ""
            MsgBox(cmd.CommandText)
            input = cmd.ExecuteScalar

            cmd.CommandText = "SELECT SUM(count) FROM gi_view_aoi_ng_day_" + lblline.Text + ""
            ng = cmd.ExecuteScalar

            good = input - ng
        Else
            cmd.CommandText = "SELECT SUM(count) FROM gi_view_aoi_input_night_" + lblline.Text + ""
            input = cmd.ExecuteScalar

            cmd.CommandText = "SELECT SUM(count) FROM gi_view_aoi_ng_night_" + lblline.Text + ""
            ng = cmd.ExecuteScalar

            good = input - ng
        End If
        lblcountgood.Text = good
        lblcountng.Text = ng
    End Sub

    Private Sub btnNG_Click(sender As Object, e As EventArgs) Handles btnNG.Click
        Try
            tblPnlMain.BackgroundImage.Dispose()
            tblPnlMain.BackgroundImage = Nothing
            Timer1.Enabled = True
            lblScan.Text = "SCAN NG PCB:"
            lblScan.ForeColor = Color.Red
            txtScan.Enabled = False
            cmbdefectname.Text = ""
            txtremarks.Text = ""
            cmbdefectname.Enabled = True
            txtremarks.Enabled = True
            populate()
            cmbdefectname.SelectedIndex = -1
            cmbdefectname.Focus()
            btnNG.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub populate()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT Defectname FROM gi_aoidefects"

        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable

        myDA.Fill(myDT)

        cmbdefectname.DataSource = myDT
        cmbdefectname.DisplayMember = "Defectname"
        cmbdefectname.ValueMember = "Defectname"
    End Sub
    Private Sub cmbdefectname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdefectname.SelectedIndexChanged
        txtremarks.Focus()
        txtScan.Enabled = True
    End Sub

    Private Sub cbxModel_DropDownClosed(sender As Object, e As EventArgs) Handles cbxModel.DropDownClosed
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `code_allocation` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        lblCodeAllocation.Text = cmd.ExecuteScalar
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim proc As New Process()
        proc = Process.Start("C:\Program Files (x86)\EMS Group\PM DOWNTIME LOGS\PM DOWNTIME TRACE.exe")
    End Sub

    Private Sub cbxBU_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBU.SelectedIndexChanged
        cbxModel.SelectedIndex = -1
    End Sub

    Private Sub cbxModel_DropDown(sender As Object, e As EventArgs) Handles cbxModel.DropDown
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        Dim customer As String = ""
        cmd.Connection = conn

        If cbxBU.Text = "GLOBAL_SKYWARE" Then
            customer = "gs"
        ElseIf cbxBU.Text = "GLOBAL_INVACOM" Then
            customer = "gi"
        End If

        cmd.CommandText = "SELECT DISTINCT model FROM gi_modelmatrix WHERE active_status = 'yes' AND customer ='" & customer & "'"
        myDA.Fill(myDT)
        cbxModel.Items.Clear()

        For Each i As DataRow In myDT.Rows
            cbxModel.Items.Add(i.Item(0).ToString)
        Next

        'cbxModel.DataSource = myDT
        'cbxModel.DisplayMember = "model"
        'cbxModel.ValueMember = "model"

        lblCodeAllocation.Text = ""
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `modelmatrixid` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        modelMatrixID = cmd.ExecuteScalar

        cbxModel.Enabled = False
        cbxBU.Enabled = False
        txtScan.Enabled = True
        txtScan.Focus()

    End Sub
    Private Sub frmAOI_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Application.Restart()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        lblDT.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Public Sub Log(logMessage As String, w As TextWriter)
        w.WriteLine("{0} {2}", Now.ToString("yyyy-MM-dd HH:mm:ss"), "  :{0}", logMessage)
    End Sub

    Public Sub gridout()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        If lblScan.Text = "SCAN PANEL:" Then
            cmd.CommandText = "SELECT pcbid, aoitimestamp_top, aoioperator_top,aoistatus_top,aoiremarks_top FROM gi_repairtrace WHERE pcbid = '" + txtScan.Text + "'"

            myDA.Fill(myDT)
            dgpcb.DataSource = myDT
        Else
            cmd.CommandText = "SELECT pcbid, timestamp, judgement, defectname, remarks FROM gi_repairaoing_top WHERE pcbid = '" & txtScan.Text & "'"
            myDA.Fill(myDT)
            dgpcb.DataSource = myDT
        End If
    End Sub
End Class