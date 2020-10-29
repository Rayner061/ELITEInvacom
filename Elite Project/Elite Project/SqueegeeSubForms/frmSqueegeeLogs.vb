Imports MySql.Data.MySqlClient

Public Class frmSqueegeeLogs
    Private Sub frmStencilLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable

        cmd.Connection = conn
        cmd.CommandText = "SELECT timestamp, action, location as locationA, operator FROM gi_squeegeehistory WHERE squeegeeid = '" + frmsqueegeemanager.txtSqueegeeA.Text + "' OR squeegeeid = '" + frmsqueegeemanager.txtSqueegeeB.Text + "'"
        myDA.Fill(myDT)

        dgLogs.DataSource = myDT
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmsqueegeemanager.Enabled = True
        Close()
    End Sub
End Class