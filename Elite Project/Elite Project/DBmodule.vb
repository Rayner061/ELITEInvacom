Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Net
Imports System.IO
Imports System.IO.Ports
Imports System.Net.Dns
Imports System.Net.Sockets

Module DBmodule
    Public conn As New MySqlConnection
    Public sqlconn As New SqlConnection
    Public giconn As New MySqlConnection
    Public lineString() As String

    Public Sub dbConnect()
        Dim ipaddress As String
        Try
            If My.Computer.Network.Ping("137.105.128.253", 2000) = True Then
                ipaddress = "137.105.128.253"
            ElseIf My.Computer.Network.Ping("192.168.6.253", 2000) = True Then
                ipaddress = "192.168.6.253"
            Else
                ipaddress = "137.105.128.253"
            End If
        Catch ex As Exception
            ipaddress = "192.168.6.253"
        End Try

        Try
            If conn.State = ConnectionState.Closed Then
                'ELITE Cloud
                'conn.ConnectionString = "server=115.84.252.4;userid=elitescanning;password=ElItE123!@#ScAnNiNg;database=eliteprototype"

                'ELITE SMT Connection
                'conn.ConnectionString = "server=137.105.128.253;userid=elitescanning;password=ElItE123!@#ScAnNiNg;database=eliteprototype"

                'ELITE EMS Connection
                conn.ConnectionString = "server=" & ipaddress & ";port=6033;userid=scanning;password=ESwliN2;database=eliteprototype"

                'Localhost
                'conn.ConnectionString = "server=localhost;userid=root;password=root;database=eliteprototype"
                'conn.ConnectionString = "server=127.0.0.1;userid=elitescanning;password=ElItE123!@#ScAnNiNg;database=eliteprototype"

                'PANACIM Connection
                'conn.ConnectionString = "server=192.168.22.253;userid=elitescanning;password=ElItE123!@#ScAnNiNg;database=eliteprototype"

                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("host: " & ipaddress)
        End Try
    End Sub

    Public Sub sqlConnect()
        Try
            If sqlconn.State = ConnectionState.Closed Then
                sqlconn.ConnectionString = "Data Source=137.105.128.3\ELINKDB;Initial Catalog=ELINK;User ID=sa;Password=Panasonic1!"
                sqlconn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Public Sub GIConnect(schema As String)
        Try
            If giconn.State = ConnectionState.Closed Then                'Invacom Connection
                giconn.ConnectionString = "server=SERVER-PHL-PROD;port=3306;userid=EMS_IT;database=" & schema
                giconn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub nonQuery(ByVal command As String)
        Dim cmd As New MySqlCommand
        cmd.CommandText = command
        cmd.CommandTimeout = 60
        cmd.Connection = conn
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub writeLogs(message As String)
        Dim mainDir As String = "C:\epson\eliteonline\scanning\"
        Dim secondaryDir As String = "C:\epson\41388badb2ff52b7b4b73ae9cc50fad3\721aec3fbaaa868e9cdafb2012e98567\"
        Dim publicDir As String = "C:\epson\scanninglogs\"
        Dim mainFile As String = ""
        Dim secondaryFile As String = ""
        Dim publicFile As String = ""
        Dim monthYear As String

        If (Not Directory.Exists(mainDir)) Then
            Directory.CreateDirectory(mainDir)
        End If

        If (Not Directory.Exists(secondaryDir)) Then
            Directory.CreateDirectory(secondaryDir)
        End If

        If (Not Directory.Exists(publicDir)) Then
            Directory.CreateDirectory(publicDir)
        End If

        dbConnect()
        monthYear = Now.ToString("yyyyMM")

        If Not My.Computer.FileSystem.FileExists(mainDir & monthYear & "-log.txt") Then
            File.Create(mainDir & monthYear & "-log.txt").Dispose()
        End If
        If Not My.Computer.FileSystem.FileExists(secondaryDir & monthYear & "-log.txt") Then
            File.Create(secondaryDir & monthYear & "-log.txt").Dispose()
        End If
        If Not My.Computer.FileSystem.FileExists(publicDir & monthYear & "-log.txt") Then
            File.Create(publicDir & monthYear & "-log.txt").Dispose()
        End If

        mainFile = mainDir & monthYear & "-log.txt"
        secondaryFile = secondaryDir & monthYear & "-log.txt"
        publicFile = publicDir & monthYear & "-log.txt"

        Using swm As StreamWriter = File.AppendText(mainFile)
            swm.WriteLine("{0} {2}", Now, "  :{0}", message)
        End Using

        Using sws As StreamWriter = File.AppendText(secondaryFile)
            sws.WriteLine("{0} {2}", Now, "  :{0}", message)
        End Using

        Using swp As StreamWriter = File.AppendText(publicFile)
            swp.WriteLine("{0} {2}", Now, "  :{0}", message)
        End Using
    End Sub
    Public Function getIPAddress() As String
        Dim IPList As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName)
        For Each IPaddress In IPList.AddressList
            If (IPaddress.AddressFamily = AddressFamily.InterNetwork) Then
                Return IPaddress.ToString
            End If
        Next
        Return ""
    End Function
End Module
