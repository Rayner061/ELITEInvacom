Imports MySql.Data.MySqlClient
Imports System.IO
Public Class spitest

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim folderPath As String = ""
        Dim fileName As String = "D:\PALLETA3772.csv"
        Dim palletPCB As String = "PALLETA3754AF77XLRPV"
        Dim line As String = "7"

        Dim sr As New IO.StreamReader(fileName)
        Dim dtContent As New DataTable
        sr.ReadLine()
        sr.ReadLine()
        sr.ReadLine()
        sr.ReadLine()
        sr.ReadLine()
        sr.ReadLine()

        Dim newContent() As String = sr.ReadLine.Split({","c})
        For Each s As String In newContent
            dtContent.Columns.Add(s.Replace("""", "").Trim())
        Next
        newContent = sr.ReadLine.Split({","c})
        For Each s As String In newContent
            newContent(Array.IndexOf(newContent, s.ToString())) = s.Replace("  ", "").Trim()
        Next
        While (Not sr.EndOfStream)
            newContent = sr.ReadLine.Split({","}, StringSplitOptions.None)

            For Each s As String In newContent
                newContent(Array.IndexOf(newContent, s.ToString())) = s.Replace("  ", "").Trim()
            Next
            Dim newContentRow As DataRow = dtContent.NewRow
            newContentRow.ItemArray = newContent
            dtContent.Rows.Add(newContentRow)
        End While
        DataGridView1.DataSource = dtContent
        'cmd.CommandText = "INSERT INTO tblspi_" & lblline.Text & "(palletpcbid, timestamp, pad_id, volume_prcnt, ave_height, max_height, offset_x_mm, offset_y_mm, size_x, size_y, volume_mmm) VALUES"
        'For Each r As DataRow In dtContent.Rows

        '    cmd.CommandText = cmd.CommandText & "('" & palletPCB.ToString() & "', NOW(), '" & r("Pad ID") & "', '" & r("PartNo") & "', '" & r("Reference") & "', '" & r("LotNo").ToString() & "', '" & r("Vendor") & "', '" & r("DateCode") & "', '" & r("ReelID") & "', " & r("BlockNo") & "),"
        '    progressTransfer.PerformStep()
        '    progressTransfer.Update()
        'Next

        sr.Close()
    End Sub

    Private Sub spitest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dbConnect()
    End Sub
End Class