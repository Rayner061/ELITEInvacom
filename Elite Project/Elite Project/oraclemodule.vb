Imports Oracle.ManagedDataAccess.Client
Imports MySql.Data.MySqlClient

Module oracleModule
    Public oracleconn As New OracleConnection
    Public Sub oracleConnect()
        Try
            dbConnect()
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            Dim fujiService As String = ""
            Dim fujiIP As String = ""

            cmd.CommandText = "SELECT `value` FROM `settings` WHERE `name` = 'fuji_servicename'"
            fujiService = cmd.ExecuteScalar()
            cmd.CommandText = "SELECT `value` FROM `settings` WHERE `name` = 'fuji_ip'"
            fujiIP = cmd.ExecuteScalar()

            If oracleconn.State = ConnectionState.Closed Then
                oracleconn.ConnectionString = "Data Source=(DESCRIPTION=" _
                    & "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" & fujiIP & ")(PORT=1521)))" _
                    & "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=" & fujiService & ")));" _
                    & "User Id=fujiuser;Password=fujiuser;"
                oracleconn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Module
