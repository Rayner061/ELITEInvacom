Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Threading
Imports System.Data.SqlClient
Imports System.Diagnostics.Stopwatch
Imports System.Text

Public Class frmpanasonicmounter
    Dim mysqlcnt As Integer = 0
    Dim pcb0 As String = ""
    Dim modelmatrix As String = ""
    Dim folderPath As String = ""
    Dim palletrequirement = ""
    Dim sb As New StringBuilder
    Dim side As String

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Application.Restart()
    End Sub

    Private Sub frmpanasonicmounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        If lblstation.Text = "MOUNTER PANASONIC - BOTTOM" Then
            side = "bottom"
        Else
            side = "top"
        End If

        lblpalletlast.Text = ""
        dbConnect()
        sqlConnect()
        CheckForIllegalCrossThreadCalls = False

        txtscan.Focus()
        writeLogs("MOUNTER STATION LOADED.")
        lblAssemblyVersion.Text = "Version " & frmlogin.assemblyVersion & " (General Release)"
    End Sub

    Private Sub txtscan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtscan.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim pcblist As New List(Of String)
            Dim line As String = lblline.Text
            txtscan.Enabled = False
            txtscan.Update()
            writeLogs("SCAN: " & txtscan.Text)
            Try
                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = sqlconn
                Dim mycmd As New MySqlCommand
                mycmd.Connection = conn

                progressTransfer.Value = 0
                progressTransfer.Visible = False
                lblElapsed.Visible = False
                lblElapsedlabel.Visible = False

                Dim cmd As New MySqlCommand
                Dim myDA As New MySqlDataAdapter(cmd)
                Dim myDT As New DataTable
                cmd.Connection = conn

                cmd.CommandText = "SELECT * FROM gi_view_mounter_" & side & "_incomplete WHERE panel = '" & txtscan.Text & "' AND `line` = '" & lblline.Text & "'"
                myDA.Fill(myDT)

                If myDT.Rows.Count > 0 Then
                    process("mounter_" & side)
                Else
                    Select Case examinePanel(txtscan.Text)
                        Case "Wrong side"
                            writeLogs("Wrong side. Please call systems support for verification.")
                            MessageBox.Show("Wrong side. Please call systems support for verification.")
                            txtscan.Text = ""
                            txtscan.Focus()
                        Case "Done mounter"
                            'MessageBox.Show("Already passed mounter scanning.")
                            writeLogs("Already passed mounter scanning.")
                            txtscan.Text = ""
                            txtscan.Focus()
                        Case "Wrong line"
                            writeLogs("Wrong line. Please relogin. System will restart now.")
                            MessageBox.Show("Wrong line. Please relogin. System will restart now.")
                            Application.Restart()
                        Case "Wrong token"
                            writeLogs("Panel did not pass previous process.")
                            MessageBox.Show("Panel did not pass previous process.")
                            txtscan.Text = ""
                            txtscan.Focus()
                        Case "unknown"
                            writeLogs("Unknown panel. Maybe not registered at injection station. Please call systems support for verification.")
                            MessageBox.Show("Unknown panel. Maybe not registered at injection station. Please call systems support for verification.")
                    End Select
                End If

                progressTransfer.Visible = False
                lblElapsed.Visible = True
                lblElapsedlabel.Visible = True
                Me.Update()
                progressTransfer.Update()
                'Application.DoEvents()
                Thread.Sleep(1500)
                lblElapsedlabel.Visible = False
                lblElapsed.Visible = False

                txtscan.Enabled = True
                txtscan.Focus()
            Catch ex As Exception
                writeLogs("FATAL ERROR: " & ex.ToString() & Environment.NewLine & Environment.NewLine & "Please contact systems support.")
                MsgBox("FATAL ERROR: " & ex.ToString() & Environment.NewLine & Environment.NewLine & "Please contact systems support.")
                txtscan.Enabled = True
                txtscan.Focus()
                txtscan.Text = ""
            End Try
        End If
    End Sub
    Private Function examinePanel(scantext As String) As String
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        examinePanel = ""

        cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE (panel_bottom = '" & scantext & "' OR panel_top = '" & scantext & "') AND line_" & side & " = '" & lblline.Text & "'"
        If cmd.ExecuteScalar > 0 Then
            cmd.CommandText = "SELECT processtoken FROM gi_pcbtrace WHERE panel_" & side & " = '" & scantext & "' ORDER by mountertimestamp_" & side & " LIMIT 1"
            If Not cmd.ExecuteScalar.ToString.Contains(side) Then
                examinePanel = "Wrong side"
            ElseIf cmd.ExecuteScalar.ToString.Contains("mounter") Or cmd.ExecuteScalar.ToString.Contains("aoi") Then
                examinePanel = "Done mounter"
            Else
                examinePanel = "Wrong token"
            End If
        Else
            cmd.CommandText = "SELECT line_" & side & " FROM gi_pcbtrace WHERE panel_" & side & " = '" & txtscan.Text & "' LIMIT 1"
            If cmd.ExecuteScalar.ToString <> lblline.Text Then
                examinePanel = "Wrong line"
            Else
                examinePanel = "unknown"
            End If
        End If
        Return examinePanel
    End Function
    Private Sub frmpanasonicmounter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldt.Text = DateTime.Now().ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Public Sub Log(logMessage As String, w As TextWriter)
        w.WriteLine("{0} {2}", Now.ToString("yyyy-MM-dd HH:mm:ss"), "  :{0}", logMessage)
    End Sub

    Private Sub process(scantoken As String)
        Dim cmd As New MySqlCommand
        Dim cmd2nd As New MySqlCommand
        cmd2nd.Connection = conn
        cmd.Connection = conn
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        Dim sqlcmd As New SqlCommand
        Dim pcblist As New List(Of String)

        Dim fileName As String = ""
        Dim palletPCB As String = ""

        sqlcmd.Connection = sqlconn
        progressTransfer.Visible = True

        Dim start As New DateTime
        Dim endtime As New DateTime
        start = DateTime.Now


        cmd.CommandText = "SELECT carrier FROM gi_modelmatrix WHERE modelmatrixid = (SELECT modelmatrixid from gi_pcbtrace where panel_" & side & " ='" + txtscan.Text + "' LIMIT 1)"
        palletrequirement = cmd.ExecuteScalar().ToString()

        If palletrequirement = "pallet" Then
            cmd.CommandText = "UPDATE gi_palletinfo set scantoken = 'mounter_" & side & "' where palletID = '" + txtscan.Text + "'"
            cmd.ExecuteNonQuery()
        End If

        cmd.CommandText = "SELECT pcbid, injectiontime, injectionoperator FROM gi_view_mounter_" & side & "_incomplete WHERE panel = '" + txtscan.Text + "'"
        myDA.Fill(myDT)

        For i As Integer = 0 To myDT.Rows.Count - 1
            cmd.CommandText = "UPDATE gi_pcbtrace SET mountertimestamp_" & side & " = NOW(), mounteroperator_" & side & " = '" & lblname.Text & "', processtoken = 'mounter_" & side & "' WHERE pcbid = '" & myDT.Rows(i).Item(0).ToString() & "'"
            cmd.ExecuteNonQuery()
        Next


        Try
            Dim sqlda As New SqlDataAdapter(sqlcmd)
            Dim sqldt As New DataTable

            sqlcmd.CommandText = "SELECT LineName, CellName, ZoneName, ProductName, ModelString, PanelBarcode, Side, ReleaseTime, PuNumber, PartNum, RefDesignator, LotNum, Vendor, UserData, MaterialID, PatternNum, MountOperator FROM dbo.PFSA_PANA_TRACE_PLACE WHERE PanelBarCode = '" + txtscan.Text + "'"
            sqlda.Fill(sqldt)
            progressTransfer.Maximum = sqldt.Rows.Count
            progressTransfer.Value = 0

            For Each r As DataRow In myDT.Rows
                pcblist.Add(r("pcbid").ToString)
            Next
            pcblist.Sort()

            ''''''TBLPCBMOUNTERTRACE HOLDER''''''
            Dim pcb1 As String = pcblist(0)
            Dim pcb2 As String = ""
            Dim pcb3 As String = ""
            Dim pcb4 As String = ""
            Dim pcb5 As String = ""
            Dim pcb6 As String = ""

            If pcblist.Count > 1 Then
                pcb2 = pcblist(1)
            End If
            If pcblist.Count > 2 Then
                pcb3 = pcblist(2)
            End If
            If pcblist.Count > 3 Then
                pcb4 = pcblist(3)
            End If
            If pcblist.Count > 4 Then
                pcb5 = pcblist(4)
            End If
            If pcblist.Count > 5 Then
                pcb6 = pcblist(5)
            End If

            Dim pcb As String = "1"
            cmd2nd.CommandText = ""
            sb.Append("INSERT INTO gi_mountertrace_" & lblline.Text & "(pcbid, timestamp, pcbside, feederslot, partnumber, location, lotno, vendorno, datecode, materialcode, blockno) VALUES")
            For Each r As DataRow In sqldt.Rows
                If r("PatternNum") = 1 Then
                    pcb = pcblist(0)
                ElseIf r("PatternNum") = 2 Then
                    pcb = pcblist(1)
                ElseIf r("PatternNum") = 3 Then
                    pcb = pcblist(2)
                ElseIf r("PatternNum") = 4 Then
                    pcb = pcblist(3)
                ElseIf r("PatternNum") = 5 Then
                    pcb = pcblist(4)
                Else
                    pcb = pcblist(5)
                End If
                sb.Append("('" & pcb.ToString() & "', NOW(), '" & r("Side") & "', '" & r("PuNumber") & "', '" & r("PartNum") & "', '" & r("RefDesignator") & "', '" & r("LotNum").ToString() & "', '" & r("Vendor") & "', '" & r("UserData") & "', '" & r("MaterialID") & "', " & r("PatternNum") & "),")
                progressTransfer.PerformStep()
                progressTransfer.Update()
            Next

            sb.Length -= 1
            sb.Append(";")
            cmd2nd.CommandText = sb.ToString
            If sqldt.Rows.Count > 10 Then
                cmd2nd.ExecuteNonQuery()
            End If
            sb.Length = 0
            progressTransfer.Update()

            sqlcmd.CommandText = "DELETE FROM dbo.PFSA_PANA_TRACE_PLACE WHERE PanelBarCode = '" + txtscan.Text + "'"
            sqlcmd.ExecuteNonQuery()

            endtime = DateTime.Now
            Dim duration As TimeSpan = endtime - start
            lblElapsed.Text = duration.ToString("%s\.ff") & " second(s)"
            txtscan.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString())
            MsgBox(cmd2nd.CommandText)

        End Try

        lblpalletlast.Text = txtscan.Text
        myDT.Clear()

        cmd.CommandText = "SELECT pcbid, injectiontime, injectionoperator, mountertime, mounteroperator FROM gi_view_mounter_" & side & " WHERE panel = '" + txtscan.Text + "'"
        myDA.Fill(myDT)

        dgPCB.DataSource = myDT
        txtscan.Text = ""
    End Sub
End Class