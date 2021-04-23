Imports System.Data
Imports System.IO
Imports System.Linq

Public Class Rfc4180Writer
    Public Shared Sub WriteDataTable(ByVal sourceTable As DataTable, ByVal writer As TextWriter, ByVal includeHeaders As Boolean, ByVal includeQuote As Boolean, ByVal commaSeparated As Boolean, Optional trimComma As Boolean = True, Optional trimRows As Boolean = True)
        Dim separator As String
        If (commaSeparated) Then
            separator = ","
        Else
            separator = vbTab
        End If

        If (includeHeaders) Then
            Dim headerValues As IEnumerable(Of String) = sourceTable.Columns.OfType(Of DataColumn).Select(Function(column) column.ColumnName)

            writer.WriteLine(String.Join(separator, headerValues))
        End If

        Dim items As IEnumerable(Of String) = Nothing

        For Each row As DataRow In sourceTable.Rows
            Dim str As String

            If (includeQuote) Then
                items = row.ItemArray.Select(Function(obj) QuoteValue(If(obj?.ToString().ToUpper(), String.Empty)))
            Else
                items = row.ItemArray.Select(Function(obj) obj?.ToString().ToUpper())
            End If

            If (trimComma) Then
                str = String.Join(separator, items).Replace(",,", "")
            Else
                str = String.Join(separator, items)
            End If

            If (trimRows) Then
                str = str.Replace(vbTab & vbTab & vbTab, "")
            End If

            writer.WriteLine(str)
        Next
        writer.Flush()
    End Sub

    Private Shared Function QuoteValue(ByVal value As String) As String
        Return String.Concat("""", value.Replace("""", """"""), """")
    End Function
End Class