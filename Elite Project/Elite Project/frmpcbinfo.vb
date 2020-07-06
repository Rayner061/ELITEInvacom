Imports MySql.Data.MySqlClient

Public Class frmpcbinfo

    Private Sub frmpcbinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnpcbcancel_Click(sender As Object, e As EventArgs) Handles btnpcbcancel.Click
        frminjection.txtscan.Focus()
        Me.Hide()
    End Sub


    Private Sub cmbmodel_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbmodel.MouseClick
        Dim sqlString As String
        sqlString = "SELECT DISTINCT model FROM tblmodelmatrix WHERE line" & frminjection.lblline.Text & "= 'yes'"
        Dim cmd As New MySqlCommand(sqlString, conn)
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable

        sqlString = "SELECT DISTINCT model FROM tblmodel"
        myDA.Fill(myDT)

        cmbmodel.DataSource = myDT
        cmbmodel.DisplayMember = "model"
        cmbmodel.ValueMember = "model"

        cmbpetname.Text = ""
        cmbpcbtype.Text = ""
        txtinputrev.Text = ""

    End Sub

    Private Sub cmbpetname_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbpetname.MouseClick
        Dim sqlString As String
        sqlString = "SELECT DISTINCT petname FROM tblmodelmatrix WHERE line" & frminjection.lblline.Text & " = 'yes' AND model = '" & cmbmodel.Text & "'"
        Dim cmd As New MySqlCommand(sqlString, conn)
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable

        myDA.Fill(myDT)

        cmbpetname.DataSource = myDT
        cmbpetname.DisplayMember = "petname"
        cmbpetname.ValueMember = "petname"

        cmbpcbtype.Text = ""
        txtinputrev.Text = ""
    End Sub

    Private Sub cmbpcbtype_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbpcbtype.MouseClick
        Dim sqlString As String
        sqlString = "SELECT DISTINCT pcbtype FROM tblmodelmatrix WHERE line" & frminjection.lblline.Text & " = 'yes' AND model = '" & cmbmodel.Text & "' AND petname = '" & cmbpetname.Text & "'"
        Dim cmd As New MySqlCommand(sqlString, conn)
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable

        myDA.Fill(myDT)

        cmbpcbtype.DataSource = myDT
        cmbpcbtype.DisplayMember = "pcbtype"
        cmbpcbtype.ValueMember = "pcbtype"
    End Sub

    Private Sub btnpcbsave_Click(sender As Object, e As EventArgs) Handles btnpcbsave.Click
        'frminjection.txtmodel.Text = cmbmodel.Text
        'frminjection.txtpetname.Text = cmbpetname.Text
        'frminjection.txtpcbtype.Text = cmbpcbtype.Text
        'frminjection.txtgrouprev.Text = txtinputrev.Text

        If cmbmodel.Text = "" Or cmbpetname.Text = "" Or cmbpcbtype.Text = "" Or txtinputrev.Text = "" Or cmbmaker.Text = "" Or Val(txtremain.Text) < 1 Or txtremain.Text = "" Then
            MsgBox("Invalid Action. Information might contain an invalid value")
        Else
            Dim cmd As New MySqlCommand
            Dim matrixid As String

            cmd.Connection = conn

            cmd.CommandText = "SELECT modelmatrixid FROM tblmodelmatrix WHERE model = '" + cmbmodel.Text + "' AND petname = '" + cmbpetname.Text + "' AND pcbtype = '" + cmbpcbtype.Text + "' AND grouprev = '" + txtinputrev.Text + "'"
            matrixid = cmd.ExecuteScalar().ToString()
            cmd.CommandText = "UPDATE tblinjectioninfo SET modelmatrixid = '" & matrixid & "', pwblot = '" & txtpwblot.Text & "', pwbmaker = '" & cmbmaker.Text & "', osp_date = '" & DateTimePicker1.Value & "' WHERE line = '" & frminjection.lblline.Text & "'"
            cmd.ExecuteNonQuery()

            frminjection.refreshDetails()
            frminjection.txtscan.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub cmbpcbtype_TextChanged(sender As Object, e As EventArgs) Handles cmbpcbtype.TextChanged
        Dim sqlString As String
        sqlString = "Select DISTINCT grouprev FROM tblmodelmatrix WHERE model = '" + cmbmodel.Text + "' AND petname = '" + cmbpetname.Text + "' AND pcbtype = '" + cmbpcbtype.Text + "'"
        Dim cmd As New MySqlCommand(sqlString, conn)
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable

        myDA.Fill(myDT)

        txtinputrev.DataSource = myDT
        txtinputrev.DisplayMember = "grouprev"
        txtinputrev.ValueMember = "grouprev"
    End Sub

    Private Sub txtinputrev_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtpwblot.Text = ""
            txtpwblot.Focus()
        End If
    End Sub

    Private Sub cmbmaker_TextChanged(sender As Object, e As EventArgs) Handles cmbmaker.TextChanged
        If cmbmaker.Text = "APEX" Then
            lblosp.Text = "Expiry Date:"
        ElseIf cmbmaker.Text = "MEIKO" Then
            lblosp.Text = "Expiry Date:"
        ElseIf cmbmaker.Text = "TRIPOD" Then
            lblosp.Text = "Finishing Date:"
        End If
        txtremain.Text = ""
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If cmbmaker.Text = "APEX" Or cmbmaker.Text = "MEIKO" Then
            Dim wD As Long = DateDiff(DateInterval.Day, Now(), DateTimePicker1.Value)
            txtremain.Text = wD
        Else
            Dim wD As Long = DateDiff(DateInterval.Day, Now(), DateTimePicker1.Value)
            txtremain.Text = wD + 180
        End If
    End Sub
End Class