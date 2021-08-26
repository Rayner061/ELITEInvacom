Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmrepairfvi

    Dim modelMatrixID, customer, Side, SideRequirement As String
    Dim icprog As Boolean

    Private Sub txtScan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScan.KeyPress
        Dim cmd As New MySqlCommand

        cmd.Connection = conn
        If Asc(e.KeyChar) = 13 Then
            Try
                writeLogs("SCAN: " & txtScan.Text)
                Dim status As String = ""

                If Side = "dual" Then
                    cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_repairtrace WHERE pcbid = '" & txtScan.Text & "' AND processtoken = 'aoi_top' AND aoistatus_top = 'good'"
                    status = "aoi_top"
                Else
                    cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_repairtrace WHERE pcbid = '" & txtScan.Text & "' AND processtoken = 'aoi_bottom' AND aoistatus_bottom = 'good'"
                    status = "aoi_bottom"
                End If

                If lblScan.Text = "SCAN PCB:" Then
                    'If customer = "gs" Then

                    'Else
                    '    cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_repairtrace WHERE pcbid = '" & txtScan.Text & "' AND processtoken = 'ic_programming' AND aoistatus_bottom = 'good'"
                    '    status = "ic_programming"
                    'End If

                    If cmd.ExecuteScalar = 1 Then

                        Select Case ExaminePCB(txtScan.Text)
                            Case "valid"
                                Select Case ExamineProgramming(txtScan.Text)
                                    Case "good"

                                        cmd.CommandText = "UPDATE gi_repairtrace SET processtoken = 'fvi', fvitimestamp = NOW(), fvioperator = '" & lblname.Text & "', fvistatus = 'good' 
                                        WHERE pcbid = '" & txtScan.Text & "' AND processtoken = '" & status & "'"
                                        cmd.ExecuteNonQuery()
                                        frmerror.lblerror.Text = ""
                                    Case "duplicate"

                                        writeLogs("ERROR: Duplicate Serial")
                                        frmerror.lblerror.Text = "ERROR: Duplicate Serial"
                                        frmerror.ShowDialog()

                                    Case "nodata"

                                        writeLogs("ERROR: No PCBA Program!")
                                        frmerror.lblerror.Text = "ERROR: No PCBA Program!"
                                        frmerror.ShowDialog()
                                    Case "failedprogram"

                                        writeLogs("ERROR: Failed Program!")
                                        frmerror.lblerror.Text = "ERROR: Failed Program!"
                                        frmerror.ShowDialog()

                                    Case "nolatestresult"
                                        writeLogs("ERROR: No Latest Program!")
                                        frmerror.lblerror.Text = "ERROR:  No Latest Program!"
                                        frmerror.ShowDialog()
                                End Select

                            Case "wrongmodel"
                                writeLogs("ERROR: Wrong model.")
                                frmerror.lblerror.Text = "ERROR: Wrong model!"
                                frmerror.ShowDialog()

                            Case "wrongline"
                                writeLogs("ERROR: Wrong Line.")
                                frmerror.lblerror.Text = "ERROR: Wrong Line!"
                                frmerror.ShowDialog()
                        End Select
                    End If

                    CountGood()
                    gridout()
                    txtScan.Text = ""
                    txtScan.Focus()
                Else
                    If txtremarks.Text = "" Or cmbdefectname.Text = "" Then
                        MsgBox("Please complete all necessary information")
                    Else
                        cmd.CommandText = "UPDATE gi_repairtrace Set `fvistatus` = 'ng', `fvitimestamp` = NOW(), `fviremarks` = '" & txtremarks.Text & "', `processtoken` = 'fvi', `fvioperator` = '" & lblname.Text & "' WHERE pcbid = '" & txtScan.Text & "' AND (processtoken = '" & status & "' OR processtoken = 'fvi') AND (aoistatus_bottom = 'GOOD' or aoistatus_top = 'GOOD')"
                        cmd.ExecuteNonQuery()
                        If cmd.ExecuteNonQuery() = 0 Then
                            writeLogs("Either the PCB did not pass previous process or PCB already passed the next process")
                            frmerror.lblerror.Text = "Either the PCB did not pass previous process or PCB already passed the next process!"
                            frmerror.ShowDialog()
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
                MsgBox("Invalid PCBID")
                frmerror.lblerror.Text = "Invalid PCBID"
                frmerror.ShowDialog()
                MsgBox(ex.ToString)
                writeLogs(ex.ToString)
                txtScan.Text = ""
                txtScan.Focus()
            End Try
        End If
    End Sub

    Public Sub InsertNG()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "INSERT INTO gi_repairfving(`pcbid`, `timestamp`, `judgement`, `defectname`, `remarks`, `operator`, `line`) VALUES ('" & txtScan.Text & "', NOW(), 'ng', '" & cmbdefectname.Text & "','" & txtremarks.Text & "', '" & lblname.Text & "', '" & lblline.Text & "')"
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub gridout()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        If lblScan.Text = "SCAN PCB:" Then
            cmd.CommandText = "SELECT pcbid, fvitimestamp, fvioperator, fvistatus FROM gi_repairtrace WHERE fvitimestamp > (NOW() - INTERVAL 15 MINUTE) ORDER BY `fvitimestamp` DESC"

            myDA.Fill(myDT)
            dgpcb.DataSource = myDT
        Else
            cmd.CommandText = "SELECT pcbid, fvitimestamp, fvioperator, fvistatus FROM gi_repairtrace WHERE fvitimestamp > (NOW() - INTERVAL 15 MINUTE) AND fvistatus = 'ng'  ORDER BY `fvitimestamp` DESC"
            myDA.Fill(myDT)
            dgpcb.DataSource = myDT
        End If
    End Sub

    Private Function ExamineProgramming(ByVal scanText As String) As String
        Dim cmd As New MySqlCommand
        cmd.Connection = giconn

        Dim cmd1 As New MySqlCommand
        cmd1.Connection = conn
        Dim res As String
        Dim count, countfvi As Integer
        Dim Latest As String
        Dim LatestTime As DateTime
        Dim LatestTimeFVI As DateTime
        res = ""
        If icprog = True Then
            cmd.CommandText = "SELECT COUNT(*) FROM `prog` WHERE (SERIAL_NO = '" & scanText & "' or SERIAL_NO = '" & scanText.Substring(scanText.IndexOf("-") + 1) & "')"
            count = cmd.ExecuteScalar.ToString()


            If count = 0 Then
                res = "nodata"
            Else

                cmd.CommandText = "SELECT FAILCODE FROM `prog` WHERE (SERIAL_NO = '" & scanText & "' or SERIAL_NO = '" & scanText.Substring(scanText.IndexOf("-") + 1) & "') ORDER BY FIRST_TIME DESC LIMIT 1"
                Latest = cmd.ExecuteScalar.ToString()

                If Latest <> "NONE" Then
                    res = "failedprogram"
                Else
                    cmd.CommandText = "SELECT DATE_FORMAT(`FIRST_TIME`,'%Y-%m-%d %h:%i:%s') as `FIRST_TIME` FROM `prog` WHERE (SERIAL_NO = '" & scanText & "' or SERIAL_NO = '" & scanText.Substring(scanText.IndexOf("-") + 1) & "') ORDER BY FIRST_TIME DESC LIMIT 1"
                    LatestTime = cmd.ExecuteScalar.ToString()

                    cmd.CommandText = "SELECT COUNT(*) FROM `gi_pcbtrace` WHERE `pcbid` = '" & scanText & "' AND `fvitimestamp` IS NOT NULL"
                    countfvi = cmd.ExecuteScalar.ToString()

                    If countfvi = 0 Then
                        res = "good"
                    Else
                        cmd.CommandText = "SELECT DATE_FORMAT(`fvitimestamp`,'%Y-%m-%d %h:%i:%s') as `fvitimestamp` FROM `gi_pcbtrace` WHERE `pcbid` = '" & scanText & "'"
                        LatestTimeFVI = cmd1.ExecuteScalar.ToString()
                        If LatestTimeFVI < LatestTime Then
                            res = "good"
                        Else
                            res = "nolatestresult"
                        End If
                    End If
                End If
            End If
        Else
            res = "good"
        End If
        ExamineProgramming = res
    End Function

    Private Function ExaminePCB(ByVal scanText As String) As String
        Dim cmd As New MySqlCommand
        Dim res As String = ""

        cmd.Connection = conn
        cmd.CommandText = "SELECT modelmatrixid FROM gi_repairtrace WHERE pcbid = '" & scanText & "'"
        If cmd.ExecuteScalar.ToString() = modelMatrixID Then
            res = "valid"
        Else
            res = "wrongmodel"
        End If
        ExaminePCB = res
    End Function

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tblPnlDefect.BackColor = Color.Red Then
            tblPnlDefect.BackColor = Color.White
        Else
            tblPnlDefect.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnGOOD_Click(sender As Object, e As EventArgs) Handles btnGOOD.Click
        Try
            writeLogs("GOOD Selected")
            Timer1.Enabled = False
            tblPnlMain.BackColor = Color.White
            tblPnlDefect.BackColor = Color.Transparent
            tblPnlMain.BackgroundImage = ELITE_GI.My.Resources.Resources.elite_background_GI_214
            Timer2.Enabled = False
            lblScan.Text = "SCAN PCB:"
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


    Private Sub btnNG_Click(sender As Object, e As EventArgs) Handles btnNG.Click
        Try
            writeLogs("NG Selected")
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

    Private Sub frmrepairfvi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        txtScan.Focus()
        Timer1.Enabled = False
        tblPnlMain.BackColor = Color.White
        tblPnlDefect.BackColor = Color.Transparent
        Timer2.Enabled = False
        CountGood()
        txtScan.Focus()

        lblAssemblyVersion.Text = "Version " & frmlogin.assemblyVersion & " (General Release)"
    End Sub


    Private Sub populate()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT Defectname FROM gi_fvidefects"

        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable

        myDA.Fill(myDT)

        cmbdefectname.DataSource = myDT
        cmbdefectname.DisplayMember = "Defectname"
        cmbdefectname.ValueMember = "Defectname"
    End Sub

    Public Sub CountGood()
        Dim cmd As New MySqlCommand
        Dim input As Integer
        Dim ng As Integer
        Dim good As Integer
        Dim shift As String

        cmd.Connection = conn
        Dim h As Integer

        h = Date.Now.Hour
        If h >= 7 And h <= 18 Then
            shift = "day"
        Else
            shift = "night"
        End If

        cmd.CommandText = "SELECT SUM(count) FROM gi_view_fvi_input_" & shift & "_" & lblline.Text & ""
        input = cmd.ExecuteScalar

        cmd.CommandText = "SELECT SUM(count) FROM gi_view_fvi_ng_" & shift & "_" & lblline.Text & ""
        ng = cmd.ExecuteScalar

        good = input - ng

        lblcountgood.Text = good
        lblcountng.Text = ng

    End Sub

    Private Sub cmbdefectname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdefectname.SelectedIndexChanged
        txtremarks.Focus()
        txtScan.Enabled = True
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

        lblCodeAllocation.Text = ""
    End Sub

    Private Sub cbxModel_DropDownClosed(sender As Object, e As EventArgs) Handles cbxModel.DropDownClosed
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `code_allocation` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        lblCodeAllocation.Text = cmd.ExecuteScalar
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Dim db As String
        If cbxModel.Text <> "" Then
            cmd.CommandText = "SELECT DISTINCT `modelmatrixid` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
            modelMatrixID = cmd.ExecuteScalar


            cmd.CommandText = "SELECT DISTINCT IFNULL(`database`,'') FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
            db = cmd.ExecuteScalar
            If db <> "" Then
                icprog = True
                GIConnect(db)
            Else
                icprog = False
            End If

            CountGood()
            cbxModel.Enabled = False
            cbxBU.Enabled = False
            txtScan.Enabled = True
            txtScan.Focus()
        Else
            MsgBox("Complete Details")
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If tblPnlMain.BackColor = Color.Red Then
            tblPnlMain.BackColor = Color.White
        Else
            tblPnlMain.BackColor = Color.Red
        End If
    End Sub

    Private Sub txtremarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtremarks.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtScan.Enabled = True
            txtScan.Focus()
            Timer2.Enabled = True
            Timer1.Enabled = False
            tblPnlDefect.BackColor = Color.White
            tblPnlMain.BackColor = Color.White
        End If
    End Sub

    Public Sub Log(logMessage As String, w As TextWriter)
        w.WriteLine("{0} {2}", Now.ToString("yyyy-MM-dd HH:mm:ss"), "  :{0}", logMessage)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        lblDT.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Application.Restart()
    End Sub

    Private Sub frmrepairfvi_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class