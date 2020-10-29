Imports MySql.Data.MySqlClient

Public Class frmpcbinfo

    Private Sub frmpcbinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
    End Sub

    Private Sub btnpcbcancel_Click(sender As Object, e As EventArgs) Handles btnpcbcancel.Click
        frminjection.txtscan.Focus()
        frminjection.Enabled = True
        Me.Hide()
    End Sub

    Private Sub btnpcbsave_Click(sender As Object, e As EventArgs) Handles btnpcbsave.Click
        'frminjection.txtmodel.Text = cmbmodel.Text
        'frminjection.txtpetname.Text = cmbpetname.Text
        'frminjection.txtpcbtype.Text = cmbpcbtype.Text
        'frminjection.txtgrouprev.Text = txtinputrev.Text

        If cbxModel.Text = "" Then
            MsgBox("Invalid Action. Information might contain an invalid value")
        Else
            Dim reader As MySqlDataReader
            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            'If customer = "gs" Then
            '    lblFamily.Visible = True
            '    cbxFamily.Visible = True
            '    lblProductNumber.Visible = True
            '    cbxProductNumber.Visible = True
            '    lblPartNumber.Visible = True
            '    cbxPartNumber.Visible = True
            '    lblCodeDesignation.Text = "Product Type:"
            '    cbxFamily.Width = 194
            '    cbxProductNumber.Width = 194
            'Else
            '    lblFamily.Visible = False
            '    cbxFamily.Visible = False
            '    lblProductNumber.Visible = False
            '    cbxProductNumber.Visible = False
            '    lblPartNumber.Visible = False
            'cbxPartNumber.Visible = False
            'lblCodeDesignation.Text = "Code Designation:"

            'End If
            cmd.CommandText = "SELECT `modelmatrixid`, `code_allocation`, `upp`, `pcb_side`, `code_allocation`, `carrier` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
            reader = cmd.ExecuteReader
            While reader.Read()
                frminjection.modelMatrixID = reader.Item(0).ToString
                frminjection.codeAllocation = reader.Item(1).ToString
                frminjection.lblCodeAllocation.Text = reader.Item(1).ToString
                frminjection.upp = reader.Item(2).ToString
                frminjection.sideRequirement = reader.Item(3).ToString
                frminjection.codeAllocation = reader.Item(4).ToString
                frminjection.palletRequirement = reader.Item(5).ToString()
            End While
            reader.Close()

            cmd.CommandText = "UPDATE `eliteprototype`.`gi_injectioninfo` SET `modelmatrixid` = '" & frminjection.modelMatrixID & "', `pcbside` = '" & frminjection.side & "' WHERE `line` = '" & frminjection.lblline.Text & "'"
            cmd.ExecuteNonQuery()

            frminjection.refreshDetails()
            Me.Close()
            frminjection.Enabled = True
        End If
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
    End Sub
End Class