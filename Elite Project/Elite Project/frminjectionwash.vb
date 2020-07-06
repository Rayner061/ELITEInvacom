Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Data.SqlClient
Public Class frminjectionwash
    Private Sub palletpcb()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT leadpcbid FROM tblpalletinfo WHERE palletID = '" + txtscan.Text + "'"
        txtleadpcb.Text = txtscan.Text + cmd.ExecuteScalar.ToString()
    End Sub
    Private Sub gridout()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT pcbid, palletid, injectiontimestamp, injectionoperator FROM tblpcbtrace WHERE palletpcbid = '" + txtleadpcb.Text + "'"
        myDA.Fill(myDT)

        DataGridView1.DataSource = myDT
    End Sub
    Private Sub deletepcb()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = "DELETE FROM tblpcbtrace WHERE palletpcbid = '" + txtleadpcb.Text + "' AND (processtoken = 'injection' OR processtoken = 'mounter')"
        If cmd.ExecuteNonQuery() = 0 Then
            MsgBox("Invalid Action. PCB is not qualified for washing")
        Else
            updatepallet()
            MsgBox("PCB history was deleted successfully. Proceed in washing")
        End If
    End Sub

    Private Sub updatepallet()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = "Update tblpalletinfo SET scantoken = 'wash' WHERE palletID = '" + txtscan.Text + "'"
        cmd.ExecuteNonQuery()

        cmd.CommandText = "INSERT INTO tblinjectionwash VALUES('" & DataGridView1.Rows(0).Cells(0).Value & "', '" & txtscan.Text & "', '" & txtleadpcb.Text & "', NOW(), '" & frminjection.lblname.Text & "')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "INSERT INTO tblinjectionwash VALUES('" & DataGridView1.Rows(1).Cells(0).Value & "', '" & txtscan.Text & "', '" & txtleadpcb.Text & "', NOW(), '" & frminjection.lblname.Text & "')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "INSERT INTO tblinjectionwash VALUES('" & DataGridView1.Rows(2).Cells(0).Value & "', '" & txtscan.Text & "', '" & txtleadpcb.Text & "', NOW(), '" & frminjection.lblname.Text & "')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "INSERT INTO tblinjectionwash VALUES('" & DataGridView1.Rows(3).Cells(0).Value & "', '" & txtscan.Text & "', '" & txtleadpcb.Text & "', NOW(), '" & frminjection.lblname.Text & "')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "INSERT INTO tblinjectionwash VALUES('" & DataGridView1.Rows(4).Cells(0).Value & "', '" & txtscan.Text & "', '" & txtleadpcb.Text & "', NOW(), '" & frminjection.lblname.Text & "')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "INSERT INTO tblinjectionwash VALUES('" & DataGridView1.Rows(5).Cells(0).Value & "', '" & txtscan.Text & "', '" & txtleadpcb.Text & "', NOW(), '" & frminjection.lblname.Text & "')"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub txtscan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtscan.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                Dim cmd As New MySqlCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT scantoken FROM tblpalletinfo WHERE palletID = '" + txtscan.Text + "'"
                If cmd.ExecuteScalar.ToString = "injection" Or cmd.ExecuteScalar.ToString = "mounter" Then
                    palletpcb()
                    gridout()
                    deletepcb()
                    deleteFromFuji()
                    deleteFromElink()
                    txtscan.Text = ""
                Else
                    MsgBox("This pallet did not pass wash board conditions. Contact support.")
                    txtscan.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Public Sub Log(logMessage As String, w As TextWriter)
        w.WriteLine("{0} {2}", Now.ToString("yyyy-MM-dd HH:mm:ss"), "  :{0}", logMessage)
    End Sub

    Private Sub deleteFromElink()
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = sqlconn

        sqlcmd.CommandText = "DELETE FROM dbo.PFSA_PANA_TRACE_PLACE WHERE PanelBarCode = '" + txtscan.Text + "'"
        sqlcmd.ExecuteNonQuery()
    End Sub
    Private Sub deleteFromFuji()
        Dim panelID As String
        panelID = "*" & txtscan.Text & "*"
        Dim folderPath As String = ""

        Dim fileName As String = ""
        Try
            For Each fileNameSearch As String In Directory.GetFiles(folderPath, panelID & ".dat")
                fileName = fileNameSearch
                If System.IO.File.Exists(fileName) = True Then
                    System.IO.File.Delete(fileName)
                End If
            Next
        Catch ex As Exception
            writeLogs(ex.ToString)
        End Try
    End Sub

    Private Sub frminjectionwash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        sqlConnect()
    End Sub
End Class