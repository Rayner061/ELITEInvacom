Imports MySql.Data.MySqlClient
Module ModelSelectionModule
    Dim myDA As New MySqlDataAdapter
    Dim modelDT As DataTable
    Dim petDT As DataTable
    Dim pcbcDT As DataTable
    Dim grprevDT As DataTable

    'Public Function ModelSource(line As String) As DataTable
    '    dbConnect()
    '    Dim cmd As New MySqlCommand
    '    Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
    '    Dim myDT As New DataTable
    '    cmd.Connection = conn

    '    Try
    '        cmd.CommandText = "SELECT DISTINCT model FROM tblmodelmatrix WHERE line" & lblline.Text & "= 'yes'"
    '        myDA.Fill(myDT)

    '        cmbmodel.DataSource = myDT

    '        cmbpetname.Text = ""
    '        cmbpcbtype.Text = ""
    '        cmbRev.Text = ""

    '        cmbpetname.DataSource = Nothing
    '        cmbpcbtype.DataSource = Nothing
    '        cmbRev.DataSource = Nothing
    '    Catch ex As MySqlException
    '        MsgBox(ex.Number & ": " & ex.ToString)
    '    End Try
    '    Return ModelSource
    'End Function
End Module
