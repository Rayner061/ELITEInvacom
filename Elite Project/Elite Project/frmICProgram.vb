Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Linq

Public Class frmICProgram
    Dim modelMatrixID, reqchar, customer, status, side As String

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

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `modelmatrixid` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        modelMatrixID = cmd.ExecuteScalar

        cmd.CommandText = "SELECT DISTINCT `req_char` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        reqchar = cmd.ExecuteScalar

        cmd.CommandText = "SELECT DISTINCT `customer` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        customer = cmd.ExecuteScalar

        cmd.CommandText = "SELECT DISTINCT `pcb_side` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        side = cmd.ExecuteScalar

        cbxModel.Enabled = False
        txtScan.Enabled = True
        txtScan.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDT.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub frmICProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        frmlogin.Show()
    End Sub

    Private Sub cbxModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxModel.SelectedIndexChanged
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `code_allocation` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        lblCodeAllocation.Text = cmd.ExecuteScalar
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        pcbstatus.Visible = False
        Timer4.Stop()
    End Sub

    Private Sub txtScan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScan.KeyPress

        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        If Asc(e.KeyChar) = 13 Then
            Try
                writeLogs("SCAN :" & txtScan.Text)
                If customer = "gi" Then
                    If side = "dual" Then
                        cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE pcbid = '" & txtScan.Text & "' AND processtoken = 'aoi_top' AND aoistatus_top = 'good' and aoistatus_bottom = 'good'"
                        status = "aoi_top"
                    ElseIf side = "single" Then
                        cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE pcbid = '" & txtScan.Text & "' AND processtoken = 'aoi_bottom' AND aoistatus_bottom = 'good'"
                        status = "aoi_bottom"
                    End If
                Else
                    writeLogs("For invacom unit only!")
                    pcbstat("visible", "ng", "For invacom unit only!")
                End If
                If cmd.ExecuteScalar = 1 Then
                    Select Case ExaminePCB(txtScan.Text)
                        Case "valid"
                            cmd.CommandText = "UPDATE gi_pcbtrace SET processtoken = 'ic_programming' WHERE pcbid = '" & txtScan.Text & "' AND processtoken = '" & status & "'"
                            cmd.ExecuteNonQuery()
                            pcbstat("visible", "good", "Good")
                        Case "wrongmodel"
                            writeLogs("ERROR: Wrong model.")
                            pcbstat("visible", "ng", "Wrong Model!")
                        Case "wrongline"
                            writeLogs("ERROR: Wrong model.")
                            pcbstat("visible", "ng", "Wrong Line!")
                    End Select
                Else
                    writeLogs("PCB did not pass previous process!")
                    pcbstat("visible", "ng", "PCB did not pass previous process!")
                End If
                gridout()
                txtScan.Text = ""
                txtScan.Focus()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub gridout()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        cmd.CommandText = "SELECT pcbid, processtoken FROM gi_pcbtrace WHERE pcbid = '" & txtScan.Text & "'"
        myDA.Fill(myDT)
        dgpcb.DataSource = myDT
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

    Private Sub pcbstat(ByVal pcbstat As String, ByVal pcbgood As String, ByVal pcbtext As String)
        If pcbstat = "visible" Then
            pcbstatus.Visible = True
        ElseIf pcbstat = "not" Then
            pcbstatus.Visible = False
        End If

        If pcbgood = "good" Then
            pcbstatus.Text = pcbtext
            pcbstatus.BackColor = Color.Green
        ElseIf pcbgood = "ng" Then
            pcbstatus.Text = pcbtext
            pcbstatus.BackColor = Color.Red
        End If
        Timer4.Start()
    End Sub
End Class