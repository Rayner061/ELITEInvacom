Imports MySql.Data.MySqlClient

Public Class frmnoscanning
    Dim bu, standby, ca, modelmatrixid As String

    Private Sub frmnoscanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpStart.Format = DateTimePickerFormat.Custom
        DtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        DtpEnd.Format = DateTimePickerFormat.Custom
        DtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss"


        checkRunning()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDT.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Application.Restart()
    End Sub

    Private Sub cbxBU_DropDownClosed(sender As Object, e As EventArgs) Handles cbxBU.DropDownClosed

        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        bu = ""
        Select Case cbxBU.Text
            Case "Toshiba"
                bu = "tblmodelmatrix"
                lblStandby.Text = "Petname"
                standby = "petname"

            Case "Epson"
                bu = "epson_modelmatrix"
                lblStandby.Text = "CodeRev"
                standby = "coderev"
            Case "Invacom"
                bu = "gi_modelmatrix"

                lblStandby.Text = "Code Allocation"
                standby = "code_allocation"
            Case "Skyware"
                bu = "gi_modelmatrix"
                lblStandby.Text = "Code Allocation"
                standby = "code_allocation"
        End Select

        If cbxBU.Text <> "" Then
            If cbxBU.Text = "Invacom" Then
                cmd.CommandText = "SELECT DISTINCT model FROM " & bu & " WHERE customer = 'gi'"
            ElseIf cbxBU.Text = "Skyware" Then
                cmd.CommandText = "SELECT DISTINCT model FROM " & bu & " WHERE customer = 'gs'"
            Else
                cmd.CommandText = "SELECT DISTINCT model FROM " & bu & ""
            End If
            myDA.Fill(myDT)

            lblStandby.Visible = True
            cbxStandby.Visible = True
            cbxModel.DataSource = myDT
            cbxModel.DisplayMember = "model"
            cbxModel.ValueMember = "model"
            cbxModel.SelectedIndex = -1
            cbxBU.Enabled = False
        End If
    End Sub

    Private Sub cbxModel_DropDownClosed(sender As Object, e As EventArgs) Handles cbxModel.DropDownClosed
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        If cbxBU.Text <> "" And cbxModel.Text <> "" Then
            cmd.CommandText = "SELECT distinct " & standby & " FROM " & bu & " WHERE model = '" & cbxModel.Text & "'"
            myDA.Fill(myDT)

            cbxModel.Enabled = False
            cbxStandby.Enabled = True
            cbxStandby.DataSource = myDT
            cbxStandby.DisplayMember = standby
            cbxStandby.ValueMember = standby
            cbxStandby.SelectedIndex = -1
        End If

    End Sub


    Private Sub cbxStandby_DropDownClosed(sender As Object, e As EventArgs) Handles cbxStandby.DropDownClosed
        If cbxStandby.Text <> "" Then
            Dim cmd As New MySqlCommand
            Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim myDT As New DataTable
            cmd.Connection = conn

            If cbxBU.Text = "Invacom" Then
                lblAllocation.Text = cbxStandby.Text
                cmd.CommandText = "SELECT modelmatrixid FROM " & bu & " WHERE model = '" & cbxModel.Text & "' and code_allocation = '" & cbxStandby.Text & "' and customer = 'gi'"
                modelmatrixid = cmd.ExecuteScalar

            ElseIf cbxBU.Text = "Epson" Then
                cmd.CommandText = "SELECT code_allocation FROM " & bu & " WHERE model = '" & cbxModel.Text & "' and coderev = '" & cbxStandby.Text & "'"
                lblAllocation.Text = cmd.ExecuteScalar()

                cmd.CommandText = "SELECT modelmatrixid FROM " & bu & " WHERE model = '" & cbxModel.Text & "' and coderev = '" & cbxStandby.Text & "' and code_allocation = '" & lblAllocation.Text & "'"
                modelmatrixid = cmd.ExecuteScalar
            ElseIf cbxBU.Text = "Skyware" Then
                lblAllocation.Text = cbxStandby.Text
                cmd.CommandText = "SELECT modelmatrixid FROM " & bu & " WHERE model = '" & cbxModel.Text & "' and code_allocation = '" & cbxStandby.Text & "' and customer = 'gs'"
                modelmatrixid = cmd.ExecuteScalar
            ElseIf cbxBU.Text = "Toshiba" Then

            End If



            cbxStandby.Enabled = False
            btnProduction.Enabled = True
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        If String.IsNullOrWhiteSpace(txtRemarks.Text) Then
            MsgBox("Input Remarks")
        Else
            If Convert.ToDateTime(DtpEnd.Text) > Convert.ToDateTime(DtpStart.Text) Then
                cmd.CommandText = "select count(*) from pm_dt_logs where time_start < '" & DtpStart.Text & "' and time_end > '" & DtpEnd.Text & "' and line = '" & lblline.Text & "' AND `type`= 'DOWNTIME'"
                If cmd.ExecuteScalar = "0" Then
                    cmd.CommandText = "INSERT INTO pm_dt_logs (line,time_start,time_start_pic,time_end,time_end_pic,type,bu,remarks) VALUES ('" & lblline.Text & "','" & DtpStart.Text & "','" & lblname.Text & "','" & DtpEnd.Text & "','" & lblname.Text & "','DOWNTIME','" & cbxBU.Text & "','" & txtRemarks.Text & "')"
                    cmd.ExecuteNonQuery()

                    MsgBox("Success")
                    txtRemarks.Text = ""
                Else
                    MsgBox("Downtime Already Logged with selected Time")
                End If
            Else
                    MsgBox("Invalid Time")
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cbxBU.SelectedIndex = -1
        cbxStandby.SelectedIndex = -1
        cbxModel.SelectedIndex = -1

        cbxModel.DataSource = Nothing
        cbxStandby.DataSource = Nothing

        cbxBU.Enabled = True
        cbxModel.Enabled = True
        cbxStandby.Enabled = True

        cbxStandby.Visible = False
        lblStandby.Visible = False

        lblStandby.Text = "-"
    End Sub

    Private Sub btnProduction_Click(sender As Object, e As EventArgs) Handles btnProduction.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        If cbxStandby.Text <> "" Then
            If btnProduction.Text = "Start Production" Then
                cmd.CommandText = "SELECT count(*) as total FROM `no_elite_scanning` WHERE line = '" & lblline.Text & "' and end is null"
                If cmd.ExecuteScalar = "0" Then
                    cmd.CommandText = "INSERT INTO `no_elite_scanning` (b_unit,petname,modelmatrixid,line,start,remarks) VALUES ('" & cbxBU.Text & "','" & cbxModel.Text & "','" & modelmatrixid & "','" & lblline.Text & "',now(),'No Elite Scanning')"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "INSERT INTO `no_scanning_info` (modelmatrixid,b_unit,line,model,code_allocation,coderev) VALUES ('" & modelmatrixid & "','" & cbxBU.Text & "','" & lblline.Text & "','" & cbxModel.Text & "','" & lblAllocation.Text & "','" & cbxStandby.Text & "')"
                    cmd.ExecuteNonQuery()

                    btnReset.Enabled = False
                    btnProduction.Text = "Stop Production"
                End If
                DgTable()
            Else
                cmd.CommandText = "UPDATE no_elite_scanning set end = now() WHERE line = '" & lblline.Text & "' and b_unit = '" & cbxBU.Text & "' and end is null"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "DELETE FROM no_scanning_info WHERE line = '" & lblline.Text & "'"
                cmd.ExecuteNonQuery()

                btnReset.Enabled = False
                btnProduction.Text = "Start Production"

                cbxBU.Enabled = True
                cbxModel.Enabled = True
                cbxStandby.Enabled = True


                cbxModel.DataSource = Nothing
                cbxStandby.DataSource = Nothing

                cbxBU.SelectedIndex = -1
                cbxModel.SelectedIndex = -1
                cbxStandby.SelectedIndex = -1

                lblAllocation.Text = "-"
            End If
        Else
            MsgBox("Complete all fields.")
        End If
    End Sub
    Public Sub DgTable()
        Try


            Dim cmd As New MySqlCommand
            Dim myDA As New MySqlDataAdapter(cmd)
            Dim myDT As New DataTable
            cmd.Connection = conn
            DgtRun.DataSource = Nothing
            If cbxBU.Text = "Toshiba" Then
                cmd.CommandText = "Select b_unit As `Business unit`,`start` As `Production start time`,`End` As `Production End time`,line,model,b.petname,pcbtype,grouprev,remarks from no_elite_scanning a,tblmodelmatrix b where a.modelmatrixid = b.modelmatrixid and a.line = '" & lblline.Text & "' order by start desc limit 10"
            ElseIf cbxBU.Text = "Epson" Then
                cmd.CommandText = "Select b_unit As `Business unit`,`start` As `Production start time`,`End` As `Production End time`,line,model,b.coderev,code_allocation,remarks from no_elite_scanning a,epson_modelmatrix b where a.modelmatrixid = b.modelmatrixid and a.line = '" & lblline.Text & "' order by start desc limit 10"
            ElseIf cbxBU.Text = "Invacom" Or cbxBU.Text = "Skyware" Then
                cmd.CommandText = "Select b_unit As `Business unit`,`start` As `Production start time`,`End` As `Production End time`,line,model,code_allocation,remarks from no_elite_scanning a,gi_modelmatrix b where a.modelmatrixid = b.modelmatrixid and a.line = '" & lblline.Text & "' order by start desc limit 10"
            End If

            myDA.Fill(myDT)
            DgtRun.DataSource = myDT
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub checkRunning()
        Dim cmd As New MySqlCommand
        Dim rdr As MySqlDataReader
        cmd.Connection = conn

        cmd.CommandText = "SELECT * FROM no_scanning_info WHERE line = '" & lblline.Text & "'"
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read
                cbxBU.Text = rdr(2)
                cbxModel.Items.Add(rdr(3))
                cbxModel.Text = rdr(3)
                cbxStandby.Items.Add(rdr(4))
                cbxStandby.Text = rdr(4)
                lblAllocation.Text = rdr(5)
            End While
            rdr.Close()

            cbxBU.Enabled = False
            cbxModel.Enabled = False
            cbxStandby.Enabled = False


            cbxStandby.Visible = True
            lblStandby.Visible = True

            Select Case cbxBU.Text
                Case "Toshiba"
                    standby = "petname"
                Case "Epson"
                    standby = "coderev"
                Case "Invacom"
                    standby = "code_allocation"
                Case "Skyware"
                    standby = "code_allocation"
            End Select

            btnReset.Enabled = False
            btnProduction.Text = "Stop Production"
            btnProduction.Enabled = True
            DgTable()
        End If
        rdr.Close()
    End Sub
End Class