Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Linq

Public Class frmAOI
    Dim side, modelMatrixID As String
    Dim palletrequirement As String = ""
    Dim upp As String = ""
    Dim modelmatrix As String = ""
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
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

    Private Sub frmAOI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblStation.Text = "AOI - BOTTOM" Then
            side = "bottom"
        Else
            side = "top"
        End If
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

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        lblDT.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
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
            cmd.CommandText = "SELECT SUM(count) FROM gi_view_aoi_input_day_" & side & "_" + lblline.Text + ""
            input = cmd.ExecuteScalar

            cmd.CommandText = "SELECT SUM(count) FROM gi_view_aoi_ng_day_" & side & "_" + lblline.Text + ""
            ng = cmd.ExecuteScalar

            good = input - ng
        Else
            cmd.CommandText = "SELECT SUM(count) FROM gi_view_aoi_input_night_" & side & "_" + lblline.Text + ""
            input = cmd.ExecuteScalar

            cmd.CommandText = "SELECT SUM(count) FROM gi_view_aoi_ng_night_" & side & "_" + lblline.Text + ""
            ng = cmd.ExecuteScalar

            good = input - ng
        End If
        lblcountgood.Text = good
        lblcountng.Text = ng
    End Sub

    Public Sub InsertNG()

        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "INSERT INTO gi_aoing_" & side & "(`pcbid`, `aoingtimestamp`, `judgement`, `defectname`, `remarks`, `aoioperator`, `line`) VALUES ('" & txtScan.Text & "', NOW(), 'ng', '" & cmbdefectname.Text & "','" & txtremarks.Text & "', '" & lblname.Text & "', '" & lblline.Text & "')"
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub gridout()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        If lblScan.Text = "SCAN PANEL:" Then
            cmd.CommandText = "SELECT pcbid, panel, aoitime, aoioperator FROM gi_view_aoi_" & side & " WHERE panel = '" + txtScan.Text + "'"

            myDA.Fill(myDT)
            dgpcb.DataSource = myDT
        Else
            cmd.CommandText = "SELECT pcbid, aoingtimestamp, judgement, defectname, remarks FROM gi_aoing WHERE pcbid = '" & txtScan.Text & "'"
            myDA.Fill(myDT)
            dgpcb.DataSource = myDT
        End If
    End Sub

    Private Sub frmAOI_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Application.Restart()
    End Sub

    Public Sub Log(logMessage As String, w As TextWriter)
        w.WriteLine("{0} {2}", Now.ToString("yyyy-MM-dd HH:mm:ss"), "  :{0}", logMessage)
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

    Private Sub txtScan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScan.KeyPress
        Dim cmd As New MySqlCommand

        cmd.Connection = conn
        If Asc(e.KeyChar) = 13 Then
            writeLogs(lblScan.Text.Replace(":", "") & "SCAN: " & txtScan.Text)
            Try
                If lblScan.Text = "SCAN PANEL:" Then
                    cmd.CommandText = "UPDATE gi_pcbtrace SET processtoken = 'aoi_" & side & "', aoitimestamp_" & side & " = NOW(), aoioperator_" & side & " = '" & lblname.Text & "', aoistatus_" & side & " = 'GOOD' 
                                        WHERE panel_" & side & " = '" & txtScan.Text & "' AND line_" & side & " = '" & lblline.Text & "' AND processtoken = 'mounter_" & side & "' AND `modelmatrixid` = '" & modelMatrixID & "'"
                    If cmd.ExecuteNonQuery <> upp Then
                        Select Case examinePanel(txtScan.Text)
                            Case "Wrong side"
                                MessageBox.Show("Wrong side. Please call systems support for verification.")
                                writeLogs("ERROR: Wrong side. Please call systems support for verification.")
                            Case "Wrong model"
                                MessageBox.Show("Wrong model. Please verify.")
                                writeLogs("ERROR: Wrong model. Please verify.")
                            Case "Done mounter"
                                MessageBox.Show("Already passed aoi scanning.")
                                writeLogs("ERROR: Already passed aoi scanning.")
                            Case "Wrong line"
                                MessageBox.Show("Wrong line. Please relogin. System will restart now.")
                                writeLogs("ERROR: Wrong line. Please relogin. System will restart now.")
                                Application.Restart()
                            Case "Wrong token"
                                MessageBox.Show("Panel did not pass previous process.")
                                writeLogs("ERROR: Panel did not pass previous process.")
                            Case "unknown"
                                MessageBox.Show("Unknown panel. Maybe not registered at injection station. Please call systems support for verification.")
                                writeLogs("ERROR: Unknown panel. Maybe not registered at injection station. Please call systems support for verification.")
                        End Select
                    End If


                    If palletrequirement = "pallet" Then
                        cmd.CommandText = "UPDATE gi_palletinfo set scantoken = 'aoi_" & side & "' where palletID = '" + txtScan.Text + "'"
                        cmd.ExecuteNonQuery()
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
                        cmd.CommandText = "UPDATE gi_pcbtrace SET aoistatus_" & side & " = 'ng', aoitimestamp_" & side & " = NOW(), aoiremarks_" & side & " = '" & txtremarks.Text & "'  WHERE pcbid = '" & txtScan.Text & "' AND processtoken = 'aoi_" & side & "'  AND line_" & side & " = '" & lblline.Text & "'"
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

    Private Function examinePanel(scantext As String) As String
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        examinePanel = ""

        cmd.CommandText = "SELECT `modelmatrixid` FROM `gi_pcbtrace` WHERE `pcbid` = (SELECT `pcbid` FROM `gi_pcbtrace` WHERE `panel_" & side & "` = '" & scantext & "' LIMIT 1)"
        If cmd.ExecuteScalar <> modelMatrixID Then
            examinePanel = "Wrong model"
        Else
            cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE (panel_bottom = '" & scantext & "' OR panel_top = '" & scantext & "') AND line_" & side & " = '" & lblline.Text & "'"
            If cmd.ExecuteScalar > 0 Then
                cmd.CommandText = "SELECT processtoken FROM gi_pcbtrace WHERE panel_" & side & " = '" & scantext & "' LIMIT 1"
                If Not cmd.ExecuteScalar.ToString.Contains(side) Then
                    examinePanel = "Wrong side"
                ElseIf cmd.ExecuteScalar.ToString.Contains("aoi") Then
                    examinePanel = "Done aoi"
                Else
                    examinePanel = "Wrong token"
                End If
            Else
                cmd.CommandText = "SELECT line_" & side & " FROM gi_pcbtrace WHERE panel_" & side & " = '" & txtScan.Text & "' LIMIT 1"
                If cmd.ExecuteScalar.ToString <> lblline.Text Then
                    examinePanel = "Wrong line"
                Else
                    examinePanel = "unknown"
                End If
            End If
        End If
        Return examinePanel
    End Function

    Private Sub cmbdefectname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdefectname.SelectedIndexChanged
        txtremarks.Focus()
        txtScan.Enabled = True
    End Sub

    Private Sub cbxModel_Click(sender As Object, e As EventArgs) Handles cbxModel.Click
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT model FROM gi_modelmatrix"
        myDA.Fill(myDT)

        cbxModel.DataSource = myDT
        cbxModel.DisplayMember = "model"
        cbxModel.ValueMember = "model"

        lblCodeAllocation.Text = ""
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

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `modelmatrixid` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        modelMatrixID = cmd.ExecuteScalar

        cmd.CommandText = "SELECT DISTINCT `upp` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        upp = cmd.ExecuteScalar

        cmd.CommandText = "SELECT DISTINCT `carrier` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        palletrequirement = cmd.ExecuteScalar

        cbxModel.Enabled = False
        txtScan.Enabled = True
        txtScan.Focus()


    End Sub
End Class