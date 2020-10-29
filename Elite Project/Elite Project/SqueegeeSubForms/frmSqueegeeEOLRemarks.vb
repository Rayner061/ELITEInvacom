Imports MySql.Data.MySqlClient
Public Class frmSqueegeeEOLRemarks
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmsqueegeemanager.Enabled = True
        Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "UPDATE gi_squeegee SET location = 'scrap', timestamp = NOW() WHERE squeegeeid = '" + frmsqueegeemanager.txtSqueegeeA.Text + "'"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "UPDATE gi_squeegee SET location = 'scrap', timestamp = NOW() WHERE squeegeeid = '" + frmsqueegeemanager.txtSqueegeeB.Text + "'"
        cmd.ExecuteNonQuery()

        cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + frmsqueegeemanager.txtSqueegeeA.Text + "', NOW(), 'End Of Life - " + txtRemarks.Text + "', 'scrap', '" + frmsqueegeemanager.lblName.Text + "')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "INSERT INTO gi_squeegeehistory(squeegeeid, timestamp, action, location, operator) VALUES('" + frmsqueegeemanager.txtSqueegeeB.Text + "', NOW(), 'End Of Life - " + txtRemarks.Text + "', 'scrap', '" + frmsqueegeemanager.lblName.Text + "')"
        cmd.ExecuteNonQuery()

        frmsqueegeemanager.Enabled = True
        frmsqueegeemanager.txtSqueegeeA.Text = ""
        frmsqueegeemanager.txtSqueegeeB.Text = ""
        frmsqueegeemanager.refreshSqueegee()
        Close()
    End Sub
End Class