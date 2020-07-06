Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Linq

Public Class frmFVI
    Dim side, modelMatrixID, customer As String
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
            tblPnlDefect.BackColor = Color.White
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

    Private Sub frmFVI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        txtScan.Focus()
        Timer1.Enabled = False
        tblPnlMain.BackColor = Color.White
        tblPnlDefect.BackColor = Color.White
        Timer2.Enabled = False
        CountGood()
        txtScan.Focus()

        lblAssemblyVersion.Text = "Version " & frmlogin.assemblyVersion & " (General Release)"
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

    Public Sub InsertNG()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "INSERT INTO gi_fving(`pcbid`, `timestamp`, `judgement`, `defectname`, `remarks`, `operator`, `line`) VALUES ('" & txtScan.Text & "', NOW(), 'ng', '" & cmbdefectname.Text & "','" & txtremarks.Text & "', '" & lblname.Text & "', '" & lblline.Text & "')"
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub gridout()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        If lblScan.Text = "SCAN PCB:" Then
            cmd.CommandText = "SELECT pcbid, fvitimestamp, fvioperator, fvistatus FROM gi_pcbtrace WHERE line_top = '" & lblline.Text & "' AND fvitimestamp > (NOW() - INTERVAL 15 MINUTE)"

            myDA.Fill(myDT)
            dgpcb.DataSource = myDT
        Else
            cmd.CommandText = "SELECT pcbid, fvitimestamp, fvioperator, fvistatus FROM gi_pcbtrace WHERE line_top = '" & lblline.Text & "' AND fvitimestamp > (NOW() - INTERVAL 15 MINUTE) AND fvistatus = 'ng'"
            myDA.Fill(myDT)
            dgpcb.DataSource = myDT
        End If
    End Sub

    Private Sub frmFVI_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
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
        cmd.CommandText = "SELECT Defectname FROM gi_fvidefects"

        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable

        myDA.Fill(myDT)

        cmbdefectname.DataSource = myDT
        cmbdefectname.DisplayMember = "Defectname"
        cmbdefectname.ValueMember = "Defectname"
    End Sub

    Private Function ExaminePCB(ByVal scanText As String) As String
        Dim cmd As New MySqlCommand
        Dim res As String = ""

        cmd.Connection = conn
        cmd.CommandText = "SELECT modelmatrixid FROM gi_pcbtrace WHERE pcbid = '" & scanText & "'"
        If cmd.ExecuteScalar = modelMatrixID Then
            If side = "dual" Then
                cmd.CommandText = "SELECT line_top FROM gi_pcbtrace WHERE pcbid = '" & scanText & "'"
            Else
                cmd.CommandText = "SELECT line_bottom FROM gi_pcbtrace WHERE pcbid = '" & scanText & "'"
            End If
            If lblline.Text = cmd.ExecuteScalar Then
                res = "valid"
            Else
                res = "wrongline"
            End If
        Else
            res = "wrongmodel"
        End If
        ExaminePCB = res
    End Function

    Private Sub txtScan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScan.KeyPress
        Dim cmd As New MySqlCommand

        cmd.Connection = conn
        If Asc(e.KeyChar) = 13 Then
            Try
                writeLogs("SCAN: " & txtScan.Text)
                Dim status As String = ""
                If lblScan.Text = "SCAN PCB:" Then
                    If customer = "gs" Then
                        If side = "dual" Then
                            cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE pcbid = '" & txtScan.Text & "' AND processtoken = 'aoi_top' AND aoistatus_top = 'good'"
                            status = "aoi_top"
                        Else
                            cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE pcbid = '" & txtScan.Text & "' AND processtoken = 'aoi_bottom' AND aoistatus_bottom = 'good'"
                            status = "aoi_bottom"
                        End If
                    Else
                        cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE pcbid = '" & txtScan.Text & "' AND processtoken = 'ic_programming' AND aoistatus_bottom = 'good'"
                        status = "ic_programming"
                    End If

                    If cmd.ExecuteScalar = 1 Then

                        Select Case ExaminePCB(txtScan.Text)
                            Case "valid"
                                cmd.CommandText = "UPDATE gi_pcbtrace SET processtoken = 'fvi', fvitimestamp = NOW(), fvioperator = '" & lblname.Text & "', fvistatus = 'good' 
                                        WHERE pcbid = '" & txtScan.Text & "' AND processtoken = '" & status & "'"
                                cmd.ExecuteNonQuery()
                            Case "wrongmodel"
                                writeLogs("ERROR: Wrong model.")
                                MsgBox("Wrong model!")

                            Case "wrongline"
                                writeLogs("ERROR: Wrong model.")
                                MsgBox("Wrong line!")
                        End Select
                    Else
                        cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE pcbid = '" & txtScan.Text & "' AND processtoken = 'fvi'"
                        If cmd.ExecuteScalar = 1 Then
                        Else
                            writeLogs("PCB did not pass previous process!")
                            MsgBox("PCB did not pass previous process!")
                        End If
                    End If

                    CountGood()
                    gridout()
                    txtScan.Text = ""
                    txtScan.Focus()
                Else
                    If txtremarks.Text = "" Or cmbdefectname.Text = "" Then
                        MsgBox("Please complete all necessary information")
                    Else
                        cmd.CommandText = "UPDATE gi_pcbtrace SET `fvistatus` = 'ng', `fvitimestamp` = NOW(), `fviremarks` = '" & txtremarks.Text & "', `processtoken` = 'fvi', `fvioperator` = '" & lblname.Text & "' WHERE pcbid = '" & txtScan.Text & "' AND (processtoken = '" & status & "' OR processtoken = 'fvi') AND line_top = '" & lblline.Text & "'"
                        cmd.ExecuteNonQuery()
                        If cmd.ExecuteNonQuery() = 0 Then
                            writeLogs("Either the PCB did not pass previous process or PCB already passed the next process")
                            MsgBox("Either the PCB did not pass previous process or PCB already passed the next process")
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
                MsgBox(ex.ToString)
                writeLogs(ex.ToString)
                txtScan.Text = ""
                txtScan.Focus()
            End Try
        End If
    End Sub

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

    Private Sub cbxFamily_Click(sender As Object, e As EventArgs) Handles cbxFamily.Click
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `gs_family` FROM gi_modelmatrix WHERE `model` = '" & cbxModel.Text & "'"
        myDA.Fill(myDT)

        cbxFamily.DataSource = myDT
        cbxFamily.DisplayMember = "gs_family"
        cbxFamily.ValueMember = "gs_family"

        lblCodeAllocation.Text = ""
        cbxProductNumber.SelectedItem = Nothing
        cbxPartNumber.SelectedItem = Nothing
    End Sub

    Private Sub cbxProductNumber_Click(sender As Object, e As EventArgs) Handles cbxProductNumber.Click
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `gs_product_number` FROM gi_modelmatrix WHERE `model` = '" & cbxModel.Text & "' AND `gs_family` = '" & cbxFamily.Text & "'"
        myDA.Fill(myDT)

        cbxProductNumber.DataSource = myDT
        cbxProductNumber.DisplayMember = "gs_product_number"
        cbxProductNumber.ValueMember = "gs_product_number"

        lblCodeAllocation.Text = ""
        cbxPartNumber.SelectedItem = Nothing
    End Sub

    Private Sub cbxPartNumber_Click(sender As Object, e As EventArgs) Handles cbxPartNumber.Click
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `gs_part_number` FROM gi_modelmatrix WHERE `model` = '" & cbxModel.Text & "' AND `gs_family` = '" & cbxFamily.Text & "' AND `gs_product_number` = '" & cbxProductNumber.Text & "'"
        myDA.Fill(myDT)

        cbxPartNumber.DataSource = myDT
        cbxPartNumber.DisplayMember = "gs_part_number"
        cbxPartNumber.ValueMember = "gs_part_number"

        lblCodeAllocation.Text = ""
    End Sub

    Private Sub cbxModel_DropDownClosed(sender As Object, e As EventArgs) Handles cbxModel.DropDownClosed
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `customer` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        customer = cmd.ExecuteScalar

        If customer = "gs" Then
            lblFamily.Visible = True
            cbxFamily.Visible = True
            lblProductNumber.Visible = True
            cbxProductNumber.Visible = True
            lblPartNumber.Visible = True
            cbxPartNumber.Visible = True
            lblCodeDesignation.Text = "Product Type:"
            cbxFamily.Width = 194
            cbxProductNumber.Width = 194
        Else
            lblFamily.Visible = False
            cbxFamily.Visible = False
            lblProductNumber.Visible = False
            cbxProductNumber.Visible = False
            lblPartNumber.Visible = False
            cbxPartNumber.Visible = False
            lblCodeDesignation.Text = "Code Designation:"
            cmd.CommandText = "SELECT DISTINCT `code_allocation` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
            lblCodeAllocation.Text = cmd.ExecuteScalar
        End If
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `modelmatrixid` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        modelMatrixID = cmd.ExecuteScalar

        cmd.CommandText = "SELECT DISTINCT `pcb_side` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        side = cmd.ExecuteScalar

        cbxFamily.Enabled = False
        cbxProductNumber.Enabled = False
        cbxPartNumber.Enabled = False
        cbxModel.Enabled = False
        txtScan.Enabled = True
        txtScan.Focus()
    End Sub
End Class