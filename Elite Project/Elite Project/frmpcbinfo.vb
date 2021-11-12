Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmpcbinfo

    Dim Type As String = "PRIME"
    Dim PN As String = ""

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
            If cbxPO.Enabled = True And cbxPO.Text = "" Then
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

            frminjection.lblPO.Text = cbxPO.Text
            frminjection.refreshDetails()
            Me.Close()
                frminjection.Enabled = True


            End If
        End If
    End Sub

    Private Sub cbxModel_Click(sender As Object, e As EventArgs) Handles cbxModel.Click

        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        Dim customer As String

        cmd.Connection = conn

        If cbxPO.Enabled = True Then

            cmd.CommandText = "SELECT DISTINCT model FROM gi_modelmatrix WHERE ems_fg_partnumber = '" & PN & "'"
            myDA.Fill(myDT)

        Else

            customer = ""
            If cbxProduct.Text = "GLOBAL_SKYWARE" Then
                customer = "gs"
            Else
                customer = "gi"
            End If

            cmd.CommandText = "SELECT DISTINCT model FROM gi_modelmatrix WHERE active_status = 'yes' and customer = '" & customer & "'"
            myDA.Fill(myDT)
        End If

        cbxModel.Items.Clear()
        For Each i As DataRow In myDT.Rows
            cbxModel.Items.Add(i.Item(0).ToString)
        Next
    End Sub



    Private Sub cbxPO_DropDown(sender As Object, e As EventArgs) Handles cbxPO.DropDown
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.CommandText = "SELECT DISTINCT `order_id` FROM `sap_prodorder` `A` INNER JOIN `sap_workcenter` `B` ON `A`.`workcenter` = `B`.`workcenter` WHERE `B`.`product` = '" & cbxProduct.Text & "' AND `B`.`type` = '" & Type & "' AND `B`.`line` = '" & frminjection.lblline.Text & "'"
        myDA.Fill(myDT)
        cbxPO.Items.Clear()
        For Each dr As DataRow In myDT.Rows
            cbxPO.Items.Add(dr(0).ToString)
        Next

        cbxModel.SelectedIndex = -1
    End Sub


    Private Sub cbxProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProduct.SelectedIndexChanged
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        If cbxProduct.Text = "GLOBAL_INVACOM" Then
            cmd.CommandText = "SELECT count(*) as `status` FROM `settings` where `name`='elite_gi_sap_enable' and `value`='yes'"
            If cmd.ExecuteScalar = "1" Then
                cbxPO.Enabled = True
            Else
                cbxPO.Enabled = False
            End If
        Else
            cmd.CommandText = "SELECT count(*) as `status` FROM `settings` where `name`='elite_gs_sap_enable' and `value`='yes'"
            If cmd.ExecuteScalar = "1" Then
                cbxPO.Enabled = True
            Else
                cbxPO.Enabled = False
            End If
        End If

        cbxPO.SelectedIndex = -1
        cbxModel.SelectedIndex = -1
    End Sub

    Private Sub cbxPO_DropDownClosed(sender As Object, e As EventArgs) Handles cbxPO.DropDownClosed
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Dim rd As MySqlDataReader
        If cbxPO.SelectedIndex <> -1 Then
            cmd.CommandText = "SELECT `partnumber`, `description` FROM `sap_prodorder` WHERE `order_id` = '" & cbxPO.Text & "'"
            rd = cmd.ExecuteReader
            While rd.Read
                PN = rd.Item(0).ToString
                lblDesc.Text = rd.Item(1).ToString
            End While
            rd.Close()
            cbxModel.Enabled = True
        End If
    End Sub
End Class