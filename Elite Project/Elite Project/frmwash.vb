Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Public Class frmwash


    Public Sub Matrix()
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader

        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM tblmodel WHERE pcbtype = '" + txtscan.Text.ToString().Substring(10, 12) + "'"
        reader = cmd.ExecuteReader()

        lblmodel.Text = ""
        lblpetname.Text = ""
        lblmatrix.Text = ""
        lblrev.Text = ""
        lblpcbtype.Text = ""

        While reader.Read()
            lblmodel.Text = reader.Item(1).ToString()
            lblpetname.Text = reader.Item(2).ToString()
            lblmatrix.Text = reader.Item(0).ToString()
            lblrev.Text = reader.Item(4).ToString()
            lblpcbtype.Text = txtscan.Text.ToString().Substring(10, 12)

        End While
        reader.Close()
    End Sub

    Private Sub txtscan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtscan.KeyPress
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Try
            If Asc(e.KeyChar) = 13 Then
                Matrix()
                lblpcbid.Text = txtscan.Text.ToString().Substring(0, 9)
                cmd.CommandText = "INSERT INTO tblwashboard VALUES ('" + lblpcbid.Text + "', '" + lblmodel.Text + "',  '" + lblpetname.Text + "','" + lblmatrix.Text + "', '" + lblrev.Text + "', '" + lblpcbtype.Text + "','" + lblname.Text + "', NOW())"
                cmd.ExecuteNonQuery()
                gridout()
                txtscan.Text = ""
                txtscan.Focus()
            End If
        Catch ex As Exception

            MsgBox("Invalid Action. PCB ID already exist")
        End Try
    End Sub

    Public Sub gridout()

        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT pcbid, model, petname, rev, pcbtype, pic, datetime FROM tblwashboard WHERE datetime like '" + lbldt.Text.ToString.Substring(0, 10) + "%'"
        myDA.Fill(myDT)

        DataGridView1.DataSource = myDT

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub frmwash_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldt.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub frmwash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtscan.Focus()
    End Sub

    Public Sub Log(logMessage As String, w As TextWriter)
        w.WriteLine("{0} {2}", Now.ToString("yyyy-MM-dd HH:mm:ss"), "  :{0}", logMessage)
    End Sub
End Class