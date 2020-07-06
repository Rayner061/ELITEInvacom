Imports MySql.Data.MySqlClient
Imports Oracle.ManagedDataAccess.Client
Imports System
Imports System.IO
Imports System.Threading
Imports System.Data.SqlClient
Imports System.Diagnostics.Stopwatch
Imports System.Text

Public Class frmfujimounter
    Dim mysqlcnt As Integer = 0
    Dim pcb0 As String = ""
    Dim modelmatrix As String = ""
    Dim folderPath As String = ""
    Dim sb As New StringBuilder
    Dim side As String
    Dim upp As Integer = 0
    Dim modelmatrixid As String = ""
    Dim mcid As String = ""
    Dim palletrequirement As String = ""
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Application.Restart()
    End Sub

    Private Sub frmfujimounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim lineMain As String = lblline.Text
            Select Case lineMain
                Case "1"
                Case "2"
                Case "3"
                Case "4"
                Case "5"
                Case "8"
                Case Else
                    writeLogs("Invalid line selection. Selected line: Line " & lblline.Text)
                    MsgBox("Invalid Line selection. Fuji mounters only support lines 1 to 5 and Line 8.")
                    MsgBox("Selected line: Line " & lblline.Text)
                    Application.Exit()
            End Select
            Dim strIP, lineKey As String

            strIP = getIPAddress()
            If strIP = "137.105.18.4" Then
                strIP = "137.105.8.4"
            End If

            lineKey = strIP.Substring(8, 1)

            If lineKey <> lineMain Then
                writeLogs("Wrong line selection. Application will restart now.")
                MsgBox("Wrong line selection. Application will restart now.")
                Application.Restart()
            Else
                Select Case lineKey
                    Case "1"
                        mcid = "1"
                    Case "2"
                        mcid = "2"
                    Case "3"
                        mcid = "3"
                    Case "4"
                        mcid = "4"
                    Case "5"
                        mcid = "5"
                    Case "8"
                        mcid = "6"
                End Select
            End If

            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            If lblstation.Text = "MOUNTER FUJI - BOTTOM" Then
                side = "bottom"
            Else
                side = "top"
            End If

            lblpalletlast.Text = ""
            dbConnect()
            oracleConnect()
            CheckForIllegalCrossThreadCalls = False

            txtscan.Focus()
            writeLogs("MOUNTER STATION LOADED.")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
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
                    cmd.CommandText = "SELECT DISTINCT `modelmatrixid` FROM `gi_pcbtrace` WHERE `panel_" & side & "` = '" & txtscan.Text & "'"
                    modelmatrixid = cmd.ExecuteScalar()
                    cmd.CommandText = "SELECT DISTINCT `upp` FROM `gi_modelmatrix` WHERE `modelmatrixid`= '" & modelmatrixid & "'"
                    upp = cmd.ExecuteScalar()
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

        Try
            cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE (panel_bottom = '" & scantext & "' OR panel_top = '" & scantext & "') AND line_" & side & " = '" & lblline.Text & "'"
            If cmd.ExecuteScalar > 0 Then
                cmd.CommandText = "SELECT processtoken FROM gi_pcbtrace WHERE panel_" & side & " = '" & scantext & "' LIMIT 1"
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
        Catch ex As Exception
            MsgBox(ex.ToString)
            txtscan.Text = ""
        End Try

        Return examinePanel
    End Function
    Private Sub frmfujimounter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

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
        Dim sqlcmd As New OracleCommand
        Dim pcblist As New List(Of String)

        Dim fileName As String = ""
        Dim palletPCB As String = ""

        sqlcmd.Connection = oracleconn
        progressTransfer.Visible = True

        Dim start As New DateTime
        Dim endtime As New DateTime
        start = DateTime.Now

        Try
            Dim sqlda As New OracleDataAdapter(sqlcmd)
            Dim sqldt As New DataTable
            Dim qry As String

            Dim panelID As String = txtscan.Text

            cmd.CommandText = "SELECT pcbid, injectiontime, injectionoperator FROM gi_view_mounter_" & side & "_incomplete WHERE panel = '" + txtscan.Text + "'"
            myDA.Fill(myDT)

            qry = "SELECT ln.linename, tblprofiler.starttime, tblprofiler.endtime, tblprofiler.pcbid AS PanelID, tblprofiler.PartNo, tblprofiler.ReelID, tblprofiler.FeederID,
                    tblprofiler.Vendor, tblprofiler.LotNo, tblprofiler.DateCode, tblprofiler.blockno, tblprofiler.Reference, tblprofiler.pcbrecno, tblprofiler.recno
                    FROM LineDesc@emsdb ld left outer JOIN linenames@emsdb ln ON ln.lineid = ld.lineid AND ld.mcid=" & mcid & " left outer JOIN machinenames@emsdb mn ON mn.mcid = ld.mcid AND mn.mcid=" & mcid & "
                    left outer JOIN (SELECT tpinfo.pcbrecno, tpinfo.recno, ttinfo.recipename, 
                        ttinfo.starttime, ttinfo.endtime, tpinfo.mcid, ttinfo.Lane, tpinfo.pcbid, tpinfo.errorinfo, tpinfo.seqno AS SequenceNo, tpinfo.moduleno AS ModuleNo, ttinfo.stageno AS StageNo, ttinfo.dtslotno AS SlotNo, ttinfo.partno AS PartNo, tpinfo.did AS ReelID, tpinfo.fidl AS FeederID,
                    ttinfo.Vendor, ttinfo.LotNo, ttinfo.DateCode, ttinfo.status, tpinfo.blockno, tpinfo.referencev AS Reference, tpinfo.part2d AS Part2DCode, tpinfo.nid AS NozzleID
                    FROM (SELECT pt.starttime, pt.endtime, dt.did, pt.lane, pt.status, pt.groupno, pt.modelname, pt.inspectresult, pt.side, pt.recipedate, pt.recipename, pt.mcid, pt.moduleno, pt.pcbid, pt.pcbrecno, dt.stageno, dt.devicecomment AS partno, dt.dtslotno, dt.vendor, dt.lotno, dt.datecode
                    FROM pcbtrace pt inner JOIN (SELECT dtt.did, dtt.stageno, dtt.devicecomment, dtt.vendor, dtt.lotno, dtt.datecode, dtt.moduleno, dtt.devicekey, dtt.mcid
                                                    , listagg(dtt.slotno, ';') within GROUP (ORDER BY dtt.slotno) AS DTSLOTNO
                                                    FROM devicetrace dtt WHERE substr(dtt.devicekey, 1, 8) >= to_char(SYSDATE - .25, 'YYYYMMDD') GROUP BY dtt.did, dtt.stageno, dtt.devicecomment, dtt.vendor, dtt.lotno, dtt.datecode, dtt.moduleno, dtt.devicekey, dtt.mcid) dt 
                                                    ON dt.devicekey = pt.devicekey AND dt.mcid = pt.mcid AND dt.moduleno = pt.moduleno
                    WHERE pt.mcid=" & mcid & " AND pt.pcbid = '" & panelID.ToUpper & "' AND pt.pcbrecno = (SELECT MAX(pcbrecno) FROM placement WHERE mcid=" & mcid & " AND moduleno = 1 AND pcbid = '" & panelID.ToUpper & "')) ttinfo
                    inner JOIN (SELECT p.mcid, p.pcbid, p.pcbrecno, p.recno, p.seqno, p.moduleno, p.errorinfo, dk.did, dk.fidl, p.blockno, NVL(rk.reference, 'UNKNOWN') AS referencev, NVL(p.part2dcode, 'NA') AS part2d, nk.nid
                             FROM placement p Inner JOIN dkey dk ON p.dkey = dk.dkey
                             Inner JOIN nkey nk ON p.nkey = nk.nkey
                             left outer JOIN rkey rk ON p.rkey = rk.rkey
                             WHERE p.mcid=" & mcid & " AND p.pcbid = '" & panelID.ToUpper & "' AND p.pcbrecno = (SELECT MAX(pcbrecno) FROM placement WHERE mcid=" & mcid & " AND moduleno = 1 AND pcbid = '" & panelID.ToUpper & "')) tpinfo ON
                    tpinfo.mcid = ttinfo.mcid AND tpinfo.moduleno = ttinfo.moduleno AND tpinfo.pcbid = ttinfo.pcbid AND tpinfo.pcbrecno = ttinfo.pcbrecno AND
                    tpinfo.did = ttinfo.did) tblprofiler ON tblprofiler.mcid = ld.mcid WHERE tblprofiler.errorinfo = 0 AND ln.linename IS NOT NULL"


            sqlcmd.CommandText = qry

            sqlda.Fill(sqldt)
            progressTransfer.Maximum = sqldt.Rows.Count
            progressTransfer.Value = 0

            For Each r As DataRow In myDT.Rows
                pcblist.Add(r("pcbid").ToString)
            Next
            pcblist.Sort()

            ''''''TBLPCBMOUNTERTRACE HOLDER''''''
            Dim pcb1 As String = pcblist(0)
            Dim pcb2 As String = pcblist(1)
            Dim pcb3 As String = ""
            Dim pcb4 As String = ""
            Dim pcb5 As String = ""
            Dim pcb6 As String = ""
            Dim pcb7 As String = ""
            Dim pcb8 As String = ""

            If upp > 2 Then
                pcb3 = pcblist(2)
                pcb4 = pcblist(3)
            End If

            If upp > 4 Then
                pcb5 = pcblist(4)
                pcb6 = pcblist(5)
                pcb7 = pcblist(6)
                pcb8 = pcblist(7)
            End If

            Dim pcb As String = "1"
            cmd2nd.CommandText = ""
            sb.Append("INSERT INTO gi_mountertrace_" & lblline.Text & "(pcbid, timestamp, pcbside, feederslot, partnumber, location, lotno, vendorno, datecode, materialcode, blockno) VALUES")
            For Each r As DataRow In sqldt.Rows
                If r("blockno") = 1 Then
                    pcb = pcblist(0)
                ElseIf r("blockno") = 2 Then
                    pcb = pcblist(1)
                ElseIf r("blockno") = 3 Then
                    pcb = pcblist(2)
                ElseIf r("blockno") = 4 Then
                    pcb = pcblist(3)
                ElseIf r("blockno") = 5 Then
                    pcb = pcblist(4)
                ElseIf r("blockno") = 6 Then
                    pcb = pcblist(5)
                ElseIf r("blockno") = 7 Then
                    pcb = pcblist(6)
                Else
                    pcb = pcblist(7)
                End If
                sb.Append("('" & pcb.ToString() & "', NOW(), '" & side.Substring(0, 1) & "', '" & r("FeederID") & "', '" & r("PartNo") & "', '" & r("Reference") & "', '" & r("LotNo").ToString() & "', '" & r("Vendor") & "', '" & r("DateCode") & "', 
                            '" & r("ReelID") & "', " & r("blockno") & "),")
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

            For i As Integer = 0 To (upp - 1)
                cmd.CommandText = "UPDATE gi_pcbtrace SET mountertimestamp_" & side & " = NOW(), mounteroperator_" & side & " = '" & lblname.Text & "', processtoken = 'mounter_" & side & "' WHERE pcbid = '" & myDT.Rows(i).Item(0).ToString() & "'"
                cmd.ExecuteNonQuery()
            Next

            cmd.CommandText = "SELECT carrier FROM gi_modelmatrix WHERE modelmatrixid = (SELECT modelmatrixid from gi_pcbtrace where panel_" & side & " ='" + txtscan.Text + "' LIMIT 1)"
            palletrequirement = cmd.ExecuteScalar().ToString()

            If palletrequirement = "pallet" Then
                cmd.CommandText = "UPDATE gi_palletinfo set scantoken = 'mounter_" & side & "' where palletID = '" + txtscan.Text + "'"
                cmd.ExecuteNonQuery()
            End If

            endtime = DateTime.Now
            Dim duration As TimeSpan = endtime - start
            lblElapsed.Text = duration.ToString("%s\.ff") & " second(s)"
            txtscan.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        lblpalletlast.Text = txtscan.Text
        myDT.Clear()

        cmd.CommandText = "SELECT pcbid, injectiontime, injectionoperator, mountertime, mounteroperator FROM gi_view_mounter_" & side & " WHERE panel = '" & txtscan.Text & "'"
        myDA.Fill(myDT)

        dgPCB.DataSource = myDT
        txtscan.Text = ""
    End Sub
End Class