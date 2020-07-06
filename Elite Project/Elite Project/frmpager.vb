Imports MySql.Data.MySqlClient
Public Class frmpager
    Private Sub txtremarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtremarks.KeyPress
        lblcharcount.Text = txtremarks.Text.Length & "/100 characters (max)"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldt.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub cmbcategory_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbcategory.MouseClick


    End Sub

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        If cmbcategory.Text = "" Or cmbpic.Text = "" Or txtremarks.Text = "" Then
            MsgBox("Please fill up all fields competely!")
        Else
            cmd.CommandText = "INSERT INTO tblcallsystem(category, pic, details, line, status, reporter, datetime) VALUES('" + cmbcategory.Text + "', '" + cmbpic.Text + "', '" + txtremarks.Text + "', '" + lblline.Text + "', 'Unread', '" + lblname.Text + "', NOW())"
            cmd.ExecuteNonQuery()
        MsgBox("Notification Sent!")
        cmbcategory.Text = ""
        cmbpic.Text = ""
            txtremarks.Text = ""
        End If
    End Sub

    Private Sub cmbcategory_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbcategory.SelectionChangeCommitted
        If cmbcategory.Text = "" Then
        ElseIf cmbcategory.Text = "Equipment" Then
            cmbpic.Text = "Maintenance Personnel"
        ElseIf cmbcategory.Text = "Quality" Then
            cmbpic.Text = "QA Personnel"
        ElseIf cmbcategory.Text = "Process" Then
            cmbpic.Text = "Production Personnel"
        End If
    End Sub

    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged

    End Sub
End Class