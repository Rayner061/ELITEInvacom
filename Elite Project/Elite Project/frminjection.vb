Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Graphics
Imports System
Imports System.IO
Imports System.Threading

Public Class frminjection
    Dim pcblist, panelList As New List(Of String)
    Dim customer, side, panel, codeAllocation, modelMatrixID, sideRequirement, palletRequirement As String
    Dim upp As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldt.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT DATE_FORMAT(NOW(),'%Y-%m-%d %H:%i:%s')"
        lbldt.Text = cmd.ExecuteScalar
    End Sub
    Private Sub frminjection_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        writeLogs("Injection Station Closed")
        Application.Exit()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        writeLogs("Injection Station Logout")
        Application.Restart()
        'frmlogin.Show()
        'Me.Hide()
    End Sub

    Private Sub txtscan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtscan.KeyPress

        If Asc(e.KeyChar) = 13 Then
            txtscan.Text = txtscan.Text.ToUpper()
            lblWarning.Visible = False
            Try
                Dim cmd As New MySqlCommand
                cmd.Connection = conn
                If side = "bottom" Then
                    writeLogs(lblscan.Text)
                    writeLogs("SCAN: " & txtscan.Text)
                    'If lblmodel.Text = "" Then
                    Dim scan As String = ExamineScan(txtscan.Text)
                    Dim label As String = lblscan.Text
                    Select Case True
                        Case (scan = "panel" And label <> "SCAN PCB:")
                            Select Case ExaminePanel(txtscan.Text)
                                Case "valid", "valid_bottom", "valid_top"
                                    If palletRequirement = "none" Then

                                        Select Case True
                                            Case label.Contains("TOP")
                                                lblPanelTop.Text = txtscan.Text
                                            Case label.Contains("BOTTOM")
                                                lblPanelBottom.Text = txtscan.Text
                                        End Select
                                    Else
                                        Select Case True
                                            Case label.Contains("BOTTOM")
                                                lblPanel.Text = txtscan.Text
                                                lblPanelTop.Text = txtscan.Text
                                                label = "SCAN PCB:"
                                        End Select
                                    End If
                                Case "invalid"
                                    notif("Invalid panel! Panel serial already used.")
                            End Select
                        Case (scan = "pcb" And label = "SCAN PCB:")
                            If pcblist.Contains(txtscan.Text) Then
                            Else
                                Select Case ExaminePCB(txtscan.Text)
                                    Case "duplicate"
                                        writeLogs("ERROR: Duplicate serial.")
                                    Case "validtop"
                                        writeLogs("ERROR: Wrong station. PCB is for scan at injection - top. Please verify selection if correct.")
                                        notif("ERROR: Wrong station. PCB is for scan at injection - top. Please verify selection if correct.")
                                    Case "wrongmodel"
                                        writeLogs("ERROR: Wrong model.")
                                        notif("ERROR: Wrong model.")
                                    Case "validpcb"
                                        pcblist.Add(txtscan.Text)
                                End Select
                            End If
                        Case (scan = "UNKNOWN")
                            notif("ERROR: " & txtscan.Text & " is unknown or invalid format.")
                            writeLogs("ERROR: " & txtscan.Text & " is unknown or invalid format.")
                            txtscan.Text = ""
                            txtscan.Focus()
                        Case (scan = "pcb" And label.Contains("PANEL"))
                            notif("ERROR: " & txtscan.Text & " is not a valid panel.")
                            writeLogs("ERROR: " & txtscan.Text & " is not a valid panel.")
                            txtscan.Text = ""
                            txtscan.Focus()
                        Case (scan = "panel" And label = "SCAN PCB:")
                            notif("ERROR: " & txtscan.Text & " is not a valid pcb.")
                            writeLogs("ERROR: " & txtscan.Text & " is not a valid pcb.")
                            txtscan.Text = ""
                            txtscan.Focus()
                    End Select

                    Select Case pcblist.Count()
                        Case 0
                            If lblPanelBottom.Text = "" And lblPanelTop.Text = "" Then
                                lblscan.Text = "SCAN PANEL (BOTTOM):"
                                lblscan.ForeColor = Color.FromArgb(37, 68, 65)
                            ElseIf lblPanelBottom.Text <> "" And lblPanelTop.Text = "" Then
                                lblscan.Text = "SCAN PANEL (TOP):"
                                lblscan.ForeColor = Color.FromArgb(37, 68, 65)
                            Else
                                lblscan.Text = "SCAN PCB:"
                                lblscan.ForeColor = Color.Green
                            End If

                            lblPCBholder1.BackColor = Color.Transparent
                            lblPCBholder2.BackColor = Color.Transparent
                            lblPCBholder3.BackColor = Color.Transparent
                            lblPCBholder4.BackColor = Color.Transparent
                            lblPCBholder5.BackColor = Color.Transparent
                            lblPCBholder6.BackColor = Color.Transparent

                            lblPCBholder1.ForeColor = Color.White
                            lblPCBholder2.ForeColor = Color.White
                            lblPCBholder3.ForeColor = Color.White
                            lblPCBholder4.ForeColor = Color.White
                            lblPCBholder5.ForeColor = Color.White
                            lblPCBholder6.ForeColor = Color.White

                            lblpcb1.BackColor = Color.Transparent
                            lblpcb2.BackColor = Color.Transparent
                            lblpcb3.BackColor = Color.Transparent
                            lblpcb4.BackColor = Color.Transparent
                            lblpcb5.BackColor = Color.Transparent
                            lblpcb6.BackColor = Color.Transparent

                            lblpcb1.Text = " "
                            lblpcb2.Text = " "
                            lblpcb3.Text = " "
                            lblpcb4.Text = " "
                            lblpcb5.Text = " "
                            lblpcb6.Text = " "
                            txtscan.Text = ""
                        Case 1
                            pcblist.Sort()
                            lblscan.Text = "SCAN PCB:"
                            lblscan.ForeColor = Color.Green
                            lblPCBholder1.BackColor = Color.Yellow
                            lblPCBholder1.ForeColor = Color.Black
                            lblpcb1.BackColor = Color.Yellow

                            lblpcb1.Text = pcblist(0)
                            If upp = 1 Then
                                SetPCB(pcblist(0))
                                pcblist.Clear()
                                lblPanelBottom.Text = ""
                                lblPanelTop.Text = ""
                                lblscan.Text = "SCAN PANEL (BOTTOM):"
                                lblscan.ForeColor = Color.FromArgb(37, 68, 65)
                            End If
                            txtscan.Text = ""
                        Case 2
                            pcblist.Sort()
                            lblscan.Text = "SCAN PCB:"
                            lblPCBholder1.BackColor = Color.Yellow
                            lblPCBholder2.BackColor = Color.Yellow

                            lblPCBholder1.ForeColor = Color.Black
                            lblPCBholder2.ForeColor = Color.Black

                            lblpcb1.BackColor = Color.Yellow
                            lblpcb2.BackColor = Color.Yellow

                            lblpcb1.Text = pcblist(0)
                            lblpcb2.Text = pcblist(1)
                            If upp = 2 Then
                                SetPCB(pcblist(0), pcblist(1))
                                pcblist.Clear()
                                lblPanelBottom.Text = ""
                                lblPanelTop.Text = ""
                                lblscan.Text = "SCAN PANEL (BOTTOM):"
                                lblscan.ForeColor = Color.FromArgb(37, 68, 65)
                            End If
                            txtscan.Text = ""
                        Case 3
                            pcblist.Sort()
                            lblscan.Text = "SCAN PCB:"
                            lblPCBholder1.BackColor = Color.Yellow
                            lblPCBholder2.BackColor = Color.Yellow
                            lblPCBholder3.BackColor = Color.Yellow

                            lblPCBholder1.ForeColor = Color.Black
                            lblPCBholder2.ForeColor = Color.Black
                            lblPCBholder3.ForeColor = Color.Black

                            lblpcb1.BackColor = Color.Yellow
                            lblpcb2.BackColor = Color.Yellow
                            lblpcb3.BackColor = Color.Yellow

                            lblpcb1.Text = pcblist(0)
                            lblpcb2.Text = pcblist(1)
                            lblpcb3.Text = pcblist(2)
                            If upp = 3 Then
                                SetPCB(pcblist(0), pcblist(1), pcblist(2))
                                pcblist.Clear()
                                lblPanelBottom.Text = ""
                                lblPanelTop.Text = ""
                                lblscan.Text = "SCAN PANEL (BOTTOM):"
                                lblscan.ForeColor = Color.FromArgb(37, 68, 65)
                            End If
                            txtscan.Text = ""
                        Case 4
                            pcblist.Sort()
                            lblPCBholder1.BackColor = Color.Yellow
                            lblPCBholder2.BackColor = Color.Yellow
                            lblPCBholder3.BackColor = Color.Yellow
                            lblPCBholder4.BackColor = Color.Yellow

                            lblPCBholder1.ForeColor = Color.Black
                            lblPCBholder2.ForeColor = Color.Black
                            lblPCBholder3.ForeColor = Color.Black
                            lblPCBholder4.ForeColor = Color.Black

                            lblpcb1.BackColor = Color.Yellow
                            lblpcb2.BackColor = Color.Yellow
                            lblpcb3.BackColor = Color.Yellow
                            lblpcb4.BackColor = Color.Yellow

                            lblpcb1.Text = pcblist(0)
                            lblpcb2.Text = pcblist(1)
                            lblpcb3.Text = pcblist(2)
                            lblpcb4.Text = pcblist(3)

                            If upp = 4 Then
                                SetPCB(pcblist(0), pcblist(1), pcblist(2), pcblist(3))
                                pcblist.Clear()
                                lblPanelBottom.Text = ""
                                lblPanelTop.Text = ""
                                lblscan.Text = "SCAN PANEL (BOTTOM):"
                                lblscan.ForeColor = Color.FromArgb(37, 68, 65)
                            End If
                            txtscan.Text = ""
                        Case 5
                            pcblist.Sort()
                            lblscan.Text = "SCAN PCB:"
                            lblPCBholder1.BackColor = Color.Yellow
                            lblPCBholder2.BackColor = Color.Yellow
                            lblPCBholder3.BackColor = Color.Yellow
                            lblPCBholder4.BackColor = Color.Yellow
                            lblPCBholder5.BackColor = Color.Yellow

                            lblPCBholder1.ForeColor = Color.Black
                            lblPCBholder2.ForeColor = Color.Black
                            lblPCBholder3.ForeColor = Color.Black
                            lblPCBholder4.ForeColor = Color.Black
                            lblPCBholder5.ForeColor = Color.Black

                            lblpcb1.BackColor = Color.Yellow
                            lblpcb2.BackColor = Color.Yellow
                            lblpcb3.BackColor = Color.Yellow
                            lblpcb4.BackColor = Color.Yellow
                            lblpcb5.BackColor = Color.Yellow

                            lblpcb1.Text = pcblist(0)
                            lblpcb2.Text = pcblist(1)
                            lblpcb3.Text = pcblist(2)
                            lblpcb4.Text = pcblist(3)
                            lblpcb5.Text = pcblist(4)

                            txtscan.Text = ""
                        Case 6
                            pcblist.Sort()
                            lblscan.Text = "SCAN PCB:"
                            lblPCBholder1.BackColor = Color.Yellow
                            lblPCBholder2.BackColor = Color.Yellow
                            lblPCBholder3.BackColor = Color.Yellow
                            lblPCBholder4.BackColor = Color.Yellow
                            lblPCBholder5.BackColor = Color.Yellow
                            lblPCBholder6.BackColor = Color.Yellow

                            lblPCBholder1.ForeColor = Color.Black
                            lblPCBholder2.ForeColor = Color.Black
                            lblPCBholder3.ForeColor = Color.Black
                            lblPCBholder4.ForeColor = Color.Black
                            lblPCBholder5.ForeColor = Color.Black
                            lblPCBholder6.ForeColor = Color.Black

                            lblpcb1.BackColor = Color.Yellow
                            lblpcb2.BackColor = Color.Yellow
                            lblpcb3.BackColor = Color.Yellow
                            lblpcb4.BackColor = Color.Yellow
                            lblpcb5.BackColor = Color.Yellow
                            lblpcb6.BackColor = Color.Yellow

                            lblpcb1.Text = pcblist(0)
                            lblpcb2.Text = pcblist(1)
                            lblpcb3.Text = pcblist(2)
                            lblpcb4.Text = pcblist(3)
                            lblpcb5.Text = pcblist(4)
                            lblpcb6.Text = pcblist(5)
                            If upp = 6 Then
                                SetPCB(pcblist(0), pcblist(1), pcblist(2), pcblist(3), pcblist(4), pcblist(5))
                                pcblist.Clear()
                                lblPanelBottom.Text = ""
                                lblPanelTop.Text = ""
                                lblscan.Text = "SCAN PANEL (BOTTOM):"
                                lblscan.ForeColor = Color.FromArgb(37, 68, 65)
                            End If
                            txtscan.Text = ""
                    End Select

                ElseIf side = "top" And sideRequirement = "dual" Then
                    writeLogs(lblscan.Text)
                    writeLogs("SCAN: " & txtscan.Text)
                    Dim scan As String = ExamineScan(txtscan.Text)
                    Dim label As String = lblscan.Text

                    Select Case True
                        Case (scan = "panel" And label = "SCAN PANEL (TOP):")
                            Select Case ExaminePanel(txtscan.Text)
                                Case "valid"
                                    lblPanelTop.Text = txtscan.Text
                                    txtscan.Text = ""
                                    lblscan.Text = "SCAN PCB:"
                                    txtscan.Focus()
                                Case "invalid"
                                    notif("Invalid panel!")
                                    lblPanelTop.Text = ""
                                    txtscan.Text = ""
                                    txtscan.Focus()
                            End Select
                        Case (scan = "pcb" And label = "SCAN PCB:")
                            Select Case ExaminePCB(txtscan.Text)
                                Case ""
                                Case "validtop"
                                    Dim reader As MySqlDataReader
                                    'MsgBox("Valid TOP")
                                    cmd.CommandText = "SELECT panel_bottom FROM gi_pcbtrace WHERE pcbid = '" & txtscan.Text & "'"
                                    lblPanelBottom.Text = cmd.ExecuteScalar().ToString()
                                    cmd.CommandText = "SELECT pcbid FROM gi_pcbtrace WHERE panel_bottom = '" & lblPanelBottom.Text & "' AND panelpcbid_bottom = (SELECT panelpcbid_bottom FROM gi_pcbtrace WHERE pcbid = '" & txtscan.Text & "')"
                                    reader = cmd.ExecuteReader
                                    While reader.Read
                                        pcblist.Add(reader(0).ToString)
                                    End While
                                    reader.Close()
                                    pcblist.Sort()
                                    'MsgBox(pcblist.Count)
                                    'MsgBox(upp)
                                    If pcblist.Count = upp Then
                                        If upp >= 2 Then
                                            lblPCBholder1.BackColor = Color.Yellow
                                            lblPCBholder2.BackColor = Color.Yellow
                                            lblPCBholder1.ForeColor = Color.Black
                                            lblPCBholder2.ForeColor = Color.Black
                                            lblpcb1.BackColor = Color.Yellow
                                            lblpcb2.BackColor = Color.Yellow
                                            lblpcb1.Text = pcblist(0)
                                            lblpcb2.Text = pcblist(1)
                                        End If

                                        If upp >= 3 Then
                                            lblPCBholder3.BackColor = Color.Yellow
                                            lblPCBholder3.ForeColor = Color.Black
                                            lblpcb3.BackColor = Color.Yellow
                                            lblpcb3.Text = pcblist(2)
                                        End If

                                        If upp >= 4 Then
                                            lblPCBholder4.BackColor = Color.Yellow
                                            lblPCBholder4.ForeColor = Color.Black
                                            lblpcb4.BackColor = Color.Yellow
                                            lblpcb4.Text = pcblist(3)
                                        End If

                                        If upp >= 6 Then
                                            lblPCBholder5.BackColor = Color.Yellow
                                            lblPCBholder6.BackColor = Color.Yellow

                                            lblPCBholder5.ForeColor = Color.Black
                                            lblPCBholder6.ForeColor = Color.Black

                                            lblpcb5.BackColor = Color.Yellow
                                            lblpcb6.BackColor = Color.Yellow

                                            lblpcb5.Text = pcblist(4)
                                            lblpcb6.Text = pcblist(5)
                                        End If
                                        Select Case upp
                                            Case 2
                                                SetPCB(pcblist(0), pcblist(1))
                                            Case 3
                                                SetPCB(pcblist(0), pcblist(1), pcblist(2))
                                            Case 4
                                                SetPCB(pcblist(0), pcblist(1), pcblist(2), pcblist(3))
                                            Case 6
                                                SetPCB(pcblist(0), pcblist(1), pcblist(2), pcblist(3), pcblist(4), pcblist(5))
                                        End Select
                                    Else
                                        notif("PCB and panel mismatch. Please verify.")
                                        notif(upp & " " & pcblist.Count)
                                    End If

                                    pcblist.Clear()
                                    lblPanelBottom.Text = ""
                                    lblPanelTop.Text = ""
                                    lblscan.Text = "SCAN PANEL (TOP):"
                                    lblscan.ForeColor = Color.FromArgb(37, 68, 65)

                                    txtscan.Text = ""
                                Case "validpcb"
                                Case "wrongmodel"
                                    writeLogs("ERROR: Wrong model.")
                                    notif("ERROR: Wrong model.")
                            End Select
                        Case (scan = "UNKNOWN")
                            notif("ERROR: " & txtscan.Text & " is unknown or invalid format.")
                            writeLogs("ERROR: " & txtscan.Text & " is unknown or invalid format.")
                            txtscan.Text = ""
                            txtscan.Focus()
                        Case (scan = "pcb" And label.Contains("PANEL"))
                            notif("ERROR: " & txtscan.Text & " is not a valid panel.")
                            writeLogs("ERROR: " & txtscan.Text & " is not a valid panel.")
                            txtscan.Text = ""
                            txtscan.Focus()
                        Case (scan = "panel" And label = "SCAN PCB:")
                            notif("ERROR: " & txtscan.Text & " is not a valid pcb.")
                            writeLogs("ERROR: " & txtscan.Text & " is not a valid pcb.")
                            txtscan.Text = ""
                            txtscan.Focus()
                    End Select
                ElseIf side = "top" And sideRequirement = "single" Then
                    notif("Single-sided PCB not allowed.")
                    txtscan.Text = ""
                    txtscan.Focus()
                End If
                refreshDetails()
            Catch ex As Exception
                MsgBox(ex.ToString())
                writeLogs("Invalid input")
                writeLogs(ex.ToString)
                txtscan.Text = ""
                notif("Invalid Input")
                txtscan.Focus()
            End Try
        End If
    End Sub

    Private Sub frminjection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        If lblstation.Text = "INJECTION - BOTTOM" Then
            side = "bottom"
            lblscan.Text = "SCAN PANEL (BOTTOM):"
        Else
            side = "top"
            lblscan.Text = "SCAN PANEL (TOP):"
        End If
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = "SELECT DATE_FORMAT(NOW(),'%Y-%m-%d %H:%i:%s')"
        lbldt.Text = cmd.ExecuteScalar

        refreshDetails()
        writeLogs("Injection Station Loaded")

        lblAssemblyVersion.Text = "Version " & frmlogin.assemblyVersion & " (General-Release)"

        cbxModel.Focus()
        stencilIssuance()
        stencilMinute()
        stencilLifespan()

    End Sub

    ''' <summary>
    ''' Refresh data.
    ''' </summary>
    Public Sub refreshDetails()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Try
            If upp = 4 Then
                TableLayoutPanel7.RowStyles(1).Height = 90
                TableLayoutPanel7.RowStyles(2).Height = 0
            ElseIf upp = 3 Then
                TableLayoutPanel7.RowStyles(1).Height = 90
                TableLayoutPanel7.RowStyles(2).Height = 0
                TableLayoutPanel7.ColumnStyles(4).Width = 0
            ElseIf upp = 2 Then
                TableLayoutPanel7.RowStyles(1).Height = 90
                TableLayoutPanel7.RowStyles(2).Height = 0
                TableLayoutPanel7.ColumnStyles(3).Width = 0
                TableLayoutPanel7.ColumnStyles(4).Width = 0
            ElseIf upp = 1 Then
                TableLayoutPanel7.RowStyles(1).Height = 90
                TableLayoutPanel7.RowStyles(2).Height = 0
                TableLayoutPanel7.ColumnStyles(2).Width = 0
                TableLayoutPanel7.ColumnStyles(3).Width = 0
                TableLayoutPanel7.ColumnStyles(4).Width = 0
            Else
                TableLayoutPanel7.RowStyles(1).Height = 45
                TableLayoutPanel7.RowStyles(2).Height = 45
            End If

            Dim h As Integer
            h = Date.Now.Hour
            If h >= 7 And h <= 18 Then
                cmd.CommandText = "SELECT `a`.`count` + `b`.`count`
                                    FROM (SELECT SUM(count) AS `count` FROM gi_view_injection_output_bottom_day_" & lblline.Text & ") a
                                    LEFT JOIN (SELECT SUM(count) AS `count` FROM gi_view_injection_output_top_day_" & lblline.Text & ") b ON `a`.`count` = `a`.`count`"
                lblpcbcounter.Text = cmd.ExecuteScalar.ToString
            Else
                cmd.CommandText = "SELECT `a`.`count` + `b`.`count`
                                    FROM (SELECT SUM(count) AS `count` FROM gi_view_injection_output_bottom_night_" & lblline.Text & ") a
                                    LEFT JOIN (SELECT SUM(count) AS `count` FROM gi_view_injection_output_top_night_" & lblline.Text & ") b ON `a`.`count` = `a`.`count`"
                lblpcbcounter.Text = cmd.ExecuteScalar.ToString
            End If

            lblpalletcounter.Text = Val(lblpcbcounter.Text) / upp
        Catch ex As Exception
            MsgBox(ex.ToString())
            notif(ex.ToString())
        End Try
    End Sub
    ''' <summary>
    ''' Determine scanned qrCode.
    ''' </summary>
    ''' <param name="scanText"></param>
    ''' <returns>Pallet or PCB</returns>
    Private Function ExamineScan(ByVal scanText As String) As String
        Dim res As String = ""
        Select Case txtscan.Text.Length
            Case 7, 11, 12, 13, 14, 15
                res = "pcb"
            Case = 9
                res = "panel"
            Case > 15
                notif("UNKNOWN!")
                res = "Unknown"
            Case 8, 9, 10, 11
                notif("UNKNOWN!")
                res = "Unknown"
        End Select
        ExamineScan = res
    End Function

    Private Function ExaminePCB(ByVal scanText As String) As String
        Dim cmd As New MySqlCommand
        Dim res As String = ""

        cmd.Connection = conn
        cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE pcbid = '" & scanText & "'"
        If cmd.ExecuteScalar = 1 Then
            cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE pcbid = '" & scanText & "' AND processtoken = 'aoi_bottom'"
            If cmd.ExecuteScalar = 1 Then
                res = "validtop"
            Else
                res = "duplicate"
            End If
        Else
            If txtscan.Text.Substring(0, codeAllocation.Length) = codeAllocation Then
                res = "validpcb"
            Else
                res = "wrongmodel"
            End If
        End If
        ExaminePCB = res
    End Function

    Private Function ExaminePanel(ByVal scanText As String) As String
        Dim cmd As New MySqlCommand
        Dim cnt As String = ""
        Dim res As String = ""
        cmd.Connection = conn
        Try
            If palletRequirement = "pallet" Then
                cmd.CommandText = "SELECT COUNT(`palletID`) FROM gi_palletinfo WHERE `palletID` = '" & scanText & "'"
                If cmd.ExecuteScalar = 0 Then
                    cmd.CommandText = "INSERT INTO `gi_palletinfo` (`palletID`, `modelmatrixid`, `scantoken`, `line`) VALUES ('" + scanText + "', '" + modelMatrixID + "', 'injection_" + side + "', '" + lblline.Text + "')"
                    cmd.ExecuteNonQuery()
                    If side = "bottom" Then
                        res = "valid_bottom"
                    Else
                        res = "valid_top"
                    End If
                Else
                    cmd.CommandText = "SELECT `scantoken` FROM `gi_palletinfo` WHERE `palletID` = '" + scanText + "'"
                    Dim scantoken As String = ""
                    scantoken = cmd.ExecuteScalar
                    If scantoken = "aoi_top" Then
                        res = "valid_bottom"
                    ElseIf scantoken = "aoi_bottom" Then
                        res = "valid_top"
                    Else
                        res = "invalid"
                    End If
                End If
            Else
                'If sideRequirement = "dual" Then
                cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_pcbtrace WHERE panel_bottom = '" & scanText & "' OR panel_top = '" & scanText & "' and processtoken ='injection_" & side & "'"
                If cmd.ExecuteScalar = 0 Then
                    res = "valid"
                Else
                    res = "invalid"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            notif(ex.ToString)
            writeLogs(ex.ToString)

        End Try
        Return res
    End Function
    Private Sub SetPCB(ByVal leadpcb As String, Optional ByVal pcb2 As String = "", Optional ByVal pcb3 As String = "", Optional ByVal pcb4 As String = "", Optional ByVal pcb5 As String = "", Optional ByVal pcb6 As String = "")
        Try
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            If side = "bottom" Then
                If sideRequirement = "single" Then

                    cmd.CommandText = "INSERT 
                    INTO gi_pcbtrace(pcbid, modelmatrixid, panel_bottom, panelpcbid_bottom, line_bottom, processtoken, injectiontimestamp_bottom, injectionoperator_bottom) 
                    VALUES
                        ('" & leadpcb & "', '" & modelMatrixID & "' , '" & lblPanel.Text & "', CONCAT('" & lblPanel.Text & "', '" & leadpcb & "'), '" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"
                    If upp >= 2 Then
                        cmd.CommandText = cmd.CommandText & ", ('" & pcb2 & "', '" & modelMatrixID & "' , '" & lblPanel.Text & "', CONCAT('" & lblPanel.Text & "', '" & leadpcb & "'), '" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"
                    End If

                    If upp >= 3 Then
                        cmd.CommandText = cmd.CommandText & ", ('" & pcb3 & "', '" & modelMatrixID & "' , '" & lblPanel.Text & "', CONCAT('" & lblPanel.Text & "', '" & leadpcb & "'), '" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"
                    End If

                    If upp >= 4 Then

                        cmd.CommandText = cmd.CommandText & ", ('" & pcb4 & "', '" & modelMatrixID & "', '" & lblPanel.Text & "', CONCAT('" & lblPanel.Text & "', '" & leadpcb & "'), '" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"
                    End If
                    If upp >= 5 Then
                        cmd.CommandText = cmd.CommandText & ",('" & pcb5 & "', '" & modelMatrixID & "', '" & lblPanel.Text & "', CONCAT('" & lblPanel.Text & "', '" & leadpcb & "'), '" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"
                    End If

                    If upp >= 6 Then
                        cmd.CommandText = cmd.CommandText & ", ('" & pcb6 & "', '" & modelMatrixID & "', '" & lblPanel.Text & "', CONCAT('" & lblPanel.Text & "', '" & leadpcb & "'), '" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"
                    End If
                Else
                    cmd.CommandText = "INSERT 
                    INTO gi_pcbtrace(pcbid, modelmatrixid, panel_bottom,panel_top, panelpcbid_bottom,panelpcbid_top, line_bottom, processtoken, injectiontimestamp_bottom, injectionoperator_bottom) 
                    VALUES
                        ('" & leadpcb & "', '" & modelMatrixID & "' , '" & lblPanelBottom.Text & "' , '" & lblPanelTop.Text & "', CONCAT('" & lblPanelBottom.Text & "', '" & leadpcb & "'), CONCAT('" & lblPanelTop.Text & "', '" & leadpcb & "'),'" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"

                    If upp >= 2 Then
                        cmd.CommandText = cmd.CommandText & ", ('" & pcb2 & "', '" & modelMatrixID & "' , '" & lblPanelBottom.Text & "' , '" & lblPanelTop.Text & "', CONCAT('" & lblPanelBottom.Text & "', '" & leadpcb & "'),CONCAT('" & lblPanelTop.Text & "', '" & leadpcb & "'), '" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"
                    End If

                    If upp >= 3 Then
                        cmd.CommandText = cmd.CommandText & ", ('" & pcb3 & "', '" & modelMatrixID & "' , '" & lblPanelBottom.Text & "' , '" & lblPanelTop.Text & "', CONCAT('" & lblPanelBottom.Text & "', '" & leadpcb & "'),CONCAT('" & lblPanelTop.Text & "', '" & leadpcb & "'), '" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"
                    End If

                    If upp >= 4 Then

                        cmd.CommandText = cmd.CommandText & ",('" & pcb4 & "', '" & modelMatrixID & "', '" & lblPanelBottom.Text & "' , '" & lblPanelTop.Text & "', CONCAT('" & lblPanelBottom.Text & "', '" & leadpcb & "'), CONCAT('" & lblPanelTop.Text & "', '" & leadpcb & "'), '" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"
                    End If

                    If upp >= 5 Then

                        cmd.CommandText = cmd.CommandText & ",('" & pcb5 & "', '" & modelMatrixID & "', '" & lblPanelBottom.Text & "' , '" & lblPanelTop.Text & "', CONCAT('" & lblPanelBottom.Text & "', '" & leadpcb & "'), CONCAT('" & lblPanelTop.Text & "', '" & leadpcb & "'), '" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"
                    End If

                    If upp >= 6 Then
                        cmd.CommandText = cmd.CommandText & ",('" & pcb6 & "', '" & modelMatrixID & "', '" & lblPanelBottom.Text & "' , '" & lblPanelTop.Text & "', CONCAT('" & lblPanelBottom.Text & "', '" & leadpcb & "'), CONCAT('" & lblPanelTop.Text & "', '" & leadpcb & "'), '" & lblline.Text & "', 'injection_bottom', NOW(), '" & lblname.Text & "')"
                    End If
                End If

            Else
                cmd.CommandText = "UPDATE gi_pcbtrace SET panel_top = '" & lblPanelTop.Text & "' , panelpcbid_top = CONCAT('" & lblPanelTop.Text & "', '" & leadpcb & "') ,line_top = '" & lblline.Text & "', processtoken = 'injection_top',
                                    injectiontimestamp_top = NOW(), injectionoperator_top = '" & lblname.Text & "' WHERE pcbid = '" & leadpcb & "' OR pcbid = '" & pcb2 & "' OR pcbid = '" & pcb3 & "' OR pcbid = '" & pcb4 & "' OR pcbid = '" & pcb5 & "' OR pcbid = '" & pcb6 & "'"
            End If
            cmd.ExecuteNonQuery()

            If palletRequirement = "pallet" Then
                cmd.CommandText = "UPDATE gi_palletinfo set leadpcbid = '" & leadpcb & "',pcb2 = '" & pcb2 & "',pcb3 = '" & pcb3 & "',pcb4= '" & pcb4 & "',pcb5= '" & pcb5 & "',pcb6= '" & pcb6 & "',scantoken = 'injection_" & side & "'  WHERE palletid = '" & lblPanel.Text & "'"
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            notif(ex.ToString)
            writeLogs(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

        frmpager.lblname.Text = lblname.Text
        frmpager.lblline.Text = lblline.Text
        frmpager.Show()
    End Sub

    Public Sub Log(logMessage As String, w As TextWriter)
        w.WriteLine("{0} {2}", Now.ToString("yyyy/MM/dd HH:mm:ss"), "  :{0}", logMessage)
    End Sub

    Private Sub btnwash_Click(sender As Object, e As EventArgs)
        writeLogs("PCB Wash")
        frminjectionwash.Show()
        'authform.Show()
    End Sub

    Private Sub btnpalletreset_Click(sender As Object, e As EventArgs) Handles btnpalletreset.Click
        Application.Restart()
    End Sub

    Private Sub cbxFamily_Click(sender As Object, e As EventArgs) Handles cbxFamily.Click
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `gs_family` FROM gi_modelmatrix WHERE `model` = '" & cbxModel.Text & "'"
        myDA.Fill(myDT)

        cbxFamily.DataSource = myDT
        cbxFamily.DisplayMember = "gs_family"
        cbxFamily.ValueMember = "gs_family"

        lblCodeAllocation.Text = ""
        cbxProductNumber.SelectedItem = Nothing
        cbxPartNumber.SelectedItem = Nothing
    End Sub

    Private Sub cbxProductNumber_Click(sender As Object, e As EventArgs) Handles cbxProductNumber.Click
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `gs_product_number` FROM gi_modelmatrix WHERE `model` = '" & cbxModel.Text & "' AND `gs_family` = '" & cbxFamily.Text & "'"
        myDA.Fill(myDT)

        cbxProductNumber.DataSource = myDT
        cbxProductNumber.DisplayMember = "gs_product_number"
        cbxProductNumber.ValueMember = "gs_product_number"

        lblCodeAllocation.Text = ""
        cbxPartNumber.SelectedItem = Nothing
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim proc As New Process()
        proc = Process.Start("C:\Program Files (x86)\EMS Group\PM DOWNTIME LOGS\PM DOWNTIME TRACE.exe")
    End Sub

    Private Sub cbxPartNumber_Click(sender As Object, e As EventArgs) Handles cbxPartNumber.Click
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `gs_part_number` FROM gi_modelmatrix WHERE `model` = '" & cbxModel.Text & "' AND `gs_family` = '" & cbxFamily.Text & "' AND `gs_product_number` = '" & cbxProductNumber.Text & "'"
        myDA.Fill(myDT)

        cbxPartNumber.DataSource = myDT
        cbxPartNumber.DisplayMember = "gs_part_number"
        cbxPartNumber.ValueMember = "gs_part_number"

        lblCodeAllocation.Text = ""
    End Sub

    Private Sub cbxModel_Click(sender As Object, e As EventArgs) Handles cbxModel.Click
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT model FROM gi_modelmatrix"
        myDA.Fill(myDT)

        cbxModel.DataSource = myDT
        cbxModel.DisplayMember = "model"
        cbxModel.ValueMember = "model"

        lblCodeAllocation.Text = ""
        cbxFamily.SelectedItem = Nothing
        cbxProductNumber.SelectedItem = Nothing
        cbxPartNumber.SelectedItem = Nothing
    End Sub

    Private Sub cbxModel_DropDownClosed(sender As Object, e As EventArgs) Handles cbxModel.DropDownClosed
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT `customer` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        customer = cmd.ExecuteScalar

        If customer = "gs" Then
            lblFamily.Visible = True
            cbxFamily.Visible = True
            lblProductNumber.Visible = True
            cbxProductNumber.Visible = True
            lblPartNumber.Visible = True
            cbxPartNumber.Visible = True
            lblCodeDesignation.Text = "Product Type:"
            cbxFamily.Width = 194
            cbxProductNumber.Width = 194
        Else
            lblFamily.Visible = False
            cbxFamily.Visible = False
            lblProductNumber.Visible = False
            cbxProductNumber.Visible = False
            lblPartNumber.Visible = False
            cbxPartNumber.Visible = False
            lblCodeDesignation.Text = "Code Designation:"

        End If
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader
        cmd.Connection = conn

        If cbxPartNumber.Text <> "" And cbxProductNumber.Text <> "" And cbxFamily.Text <> "" Then
            cmd.CommandText = "SELECT `modelmatrixid`, `code_allocation`, `upp`, `pcb_side`, `code_allocation`, `carrier` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "' AND `gs_family` = '" & cbxFamily.Text & "' AND `gs_product_number` = '" & cbxProductNumber.Text & "' 
                            AND `gs_part_number` = '" & cbxPartNumber.Text & "'"
        Else
            cmd.CommandText = "SELECT `modelmatrixid`, `code_allocation`, `upp`, `pcb_side`, `code_allocation`, `carrier` FROM `gi_modelmatrix` WHERE `model` = '" & cbxModel.Text & "'"
        End If
        reader = cmd.ExecuteReader

        While reader.Read()
            modelMatrixID = reader.Item(0).ToString
            codeAllocation = reader.Item(1).ToString
            lblCodeAllocation.Text = reader.Item(1).ToString
            upp = reader.Item(2).ToString
            sideRequirement = reader.Item(3).ToString
            codeAllocation = reader.Item(4).ToString
            palletRequirement = reader.Item(5).ToString()
        End While
        reader.Close()
        cmd.CommandText = "UPDATE `eliteprototype`.`gi_injectioninfo` SET `modelmatrixid` = '" & modelMatrixID & "', `pcbside` = '" & side & "' WHERE `line` = '" & lblline.Text & "'"
        cmd.ExecuteNonQuery()

        cbxFamily.Enabled = False
        cbxProductNumber.Enabled = False
        cbxPartNumber.Enabled = False
        cbxModel.Enabled = False
        txtscan.Enabled = True
        txtscan.Focus()
        refreshDetails()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs)
        txtscan.Focus()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        csmin()
        stencilMinute()
        refreshDetails()

        If lblCSMin.BackColor = Color.ForestGreen And lblCodeAllocation.Text <> "" And lblStencil.Text <> "" And Val(lblStencilLifespan.Text) > 0 And Val(lblStencilCleaning.Text) > 0 Then
            txtscan.Enabled = True
        Else
            txtscan.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick_1(sender As Object, e As EventArgs) Handles Timer3.Tick
        stencilLifespan()
    End Sub

    Private Sub btnStencil_Click(sender As Object, e As EventArgs) Handles btnStencil.Click

    End Sub

    Private Sub connectTimer_Tick(sender As Object, e As EventArgs) Handles connectTimer.Tick
        dbConnect()
    End Sub

    Private Sub notif(warning As String)
        lblWarning.Text = warning
        lblWarning.Visible = True
    End Sub

    Private Sub stencilLifespan()
        Try

            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "UPDATE `gi_stencil_lifespan` SET `lifespan`= (SELECT FLOOR(90000 - (SUM(`count`) / " & upp & ")) AS `lifespan` FROM (SELECT COUNT(`pcbid`) AS `count` FROM `epson_pcbtrace` WHERE `stencilid_bottom` = '" & lblStencil.Text & "' UNION ALL
                                SELECT COUNT(`pcbid`) AS `count` FROM `epson_pcbtrace` WHERE `stencilid_top` = '" & lblStencil.Text & "') `a`) WHERE `stencilid` = '" & lblStencil.Text & "'"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "SELECT `lifespan` FROM `epson_stencil_lifespan` WHERE `stencilid` = '" & lblStencil.Text & "'"
            lblStencilLifespan.Text = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub stencilMinute()
        Try
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT FLOOR(480 - (time_to_sec(timediff(NOW(), (SELECT `timestamp` FROM `gi_stencil` WHERE `stencilid` = '" & lblStencil.Text & "'))) / 60))"

            If IsDBNull(cmd.ExecuteScalar()) Then
                lblStencilCleaning.Text = "N/A"
            Else
                lblStencilCleaning.Text = cmd.ExecuteScalar.ToString()
            End If
            If Val(lblStencilCleaning.Text) > 90 Then
                lblStencilCleaning.BackColor = Color.ForestGreen
                lblStencilCleaning.ForeColor = Color.White
            ElseIf Val(lblStencilCleaning.Text) < 91 And Val(lblStencilCleaning.Text) > 30 Then
                lblStencilCleaning.BackColor = Color.Yellow
                lblStencilCleaning.ForeColor = Color.Black
            ElseIf Val(lblStencilCleaning.Text) < 31 Then
                lblStencilCleaning.BackColor = Color.Red
                lblStencilCleaning.ForeColor = Color.White
                txtscan.Enabled = False
            Else
                lblStencilCleaning.BackColor = Color.Gray
                lblStencilCleaning.ForeColor = Color.Black
                txtscan.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub stencilIssuance()
        Try
            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "SELECT `stencilid` FROM `gi_stencil` WHERE `location` = 'Line " & lblline.Text & "'"
            If cmd.ExecuteScalar Is Nothing Then
            Else
                lblStencil.Text = cmd.ExecuteScalar.ToString
            End If
        Catch ex As Exception
            lblStencil.Text = ""
            lblStencilCleaning.Text = ""
            lblStencilCleaning.BackColor = Color.White
            writeLogs(ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub csmin()
        creamissuance()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Dim datTim1 As DateTime = Now().ToString()
        Dim wD As Integer
        Try
            If lblCSMin.Text <> "" Then
                cmd.CommandText = "SELECT TIMESTAMPDIFF(MINUTE, `opendatetime`, NOW()) FROM gi_creamsolder WHERE creamid = '" & lblCreamSolder.Text & "'"
                wD = cmd.ExecuteScalar.ToString()

                lblCSMin.Text = 480 - wD

                If Val(lblCSMin.Text) < 0 Then
                    lblCSMin.BackColor = Color.Red
                    lblCSMin.ForeColor = Color.White
                    MsgBox("Cream Solder reached floor life limit. Please dispose immediately")
                    txtscan.Enabled = False
                ElseIf lblCSMin.Text = "N/A" Then
                    lblCSMin.ForeColor = Color.Black
                    lblCSMin.BackColor = Color.White
                    txtscan.Enabled = False
                Else
                    lblCSMin.BackColor = Color.ForestGreen
                    lblCSMin.ForeColor = Color.White
                End If
            Else
                txtscan.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    Public Sub creamissuance()
        Try
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT IFNULL(creamsolderid, 'none') FROM gi_injectioninfo WHERE line = '" & lblline.Text & "'"
            If cmd.ExecuteScalar() = "none" Or cmd.ExecuteScalar() Is Nothing Then
                lblCSMin.BackColor = Color.White
                lblCSMin.Text = "N/A"
                lblCSMin.Text = ""
            Else
                lblCreamSolder.Text = cmd.ExecuteScalar.ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
            writeLogs(ex.ToString)
        End Try
    End Sub
End Class
