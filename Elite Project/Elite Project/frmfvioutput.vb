Imports MySql.Data.MySqlClient

Public Class frmfvioutput
    Private Sub frmfvioutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridout()
    End Sub

    Public Sub gridout()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        Dim shift As String
        Dim h As Integer

        h = Date.Now.Hour
        If h >= 7 And h <= 18 Then
            shift = "day"
        Else
            shift = "night"
        End If

        cmd.CommandText = "SELECT * FROM gi_view_fvi_input_model_" + shift + "_" + lblline.Text
        myDA.Fill(myDT)
        outputdtg.DataSource = myDT
    End Sub

End Class