Imports MySql.Data.MySqlClient
Public Class frmwash2
    Dim pcbid2array() As String = New String(6) {}
    Dim pcbarray() As String = {"", "", "", "", "", ""}
    Dim pcblist As New List(Of String)
    Dim pcblist2 As New List(Of String)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldt.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub frmwash2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldt.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
        txtscan.Focus()
    End Sub

    Private Sub txtscan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtscan.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                Dim scan As String = ExamineScan(txtscan.Text)
                Dim label As String = lblscan.Text
                Select Case True
                    Case (scan = "pcb" And label = "SCAN PCB:")
                        'MsgBox("pcb")

                        If pcblist.Contains(txtscan.Text.ToString().Substring(0, 9)) Or pcblist2.Contains(txtscan.Text.ToString().Substring(0, 9)) Then
                        Else
                            Select Case IsValidPCB(txtscan.Text.ToString().Substring(0, 9))
                                Case True
                                    If pcblist.Count() < 6 Then
                                        'MsgBox(pcblist.Count().ToString)
                                        pcblist.Add(txtscan.Text.ToString().Substring(0, 9))
                                    Else
                                        pcblist2.Add(txtscan.Text.ToString().Substring(0, 9))
                                    End If
                                Case False
                                    MsgBox("Rewash count limit exceeded")
                            End Select
                        End If

                    Case (scan = "UNKNOWN")
                        MsgBox("ERROR: " & txtscan.Text & " is unknown or invalid.")

                        txtscan.Text = ""
                        txtscan.Focus()
                    Case (scan = "pcb" And label = "SCAN PALLET:")
                        MsgBox("ERROR: " & txtscan.Text & " is not a valid pcb.")

                        txtscan.Text = ""
                        txtscan.Focus()
                    Case (scan = "pallet" And label = "SCAN PCB:")
                        MsgBox("ERROR: " & txtscan.Text & " is not a valid pallet.")

                        txtscan.Text = ""
                        txtscan.Focus()
                End Select

#Region "Kulay ng mga box"
                'MsgBox(pcblist(0).ToString)
                Select Case pcblist.Count()

                    Case 0
                        lblscan.Text = "SCAN PCB:"

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
                        lblpcb1.Text = pcblist(0)
                        txtscan.Text = ""
                    Case 2
                        pcblist.Sort()
                        lblscan.Text = "SCAN PCB:"
                        lblpcb1.Text = pcblist(0)
                        lblpcb2.Text = pcblist(1)
                        txtscan.Text = ""
                    Case 3
                        pcblist.Sort()
                        lblscan.Text = "SCAN PCB:"
                        lblpcb1.Text = pcblist(0)
                        lblpcb2.Text = pcblist(1)
                        lblpcb3.Text = pcblist(2)
                        txtscan.Text = ""
                    Case 4
                        pcblist.Sort()
                        lblscan.Text = "SCAN PCB:"
                        lblpcb1.Text = pcblist(0)
                        lblpcb2.Text = pcblist(1)
                        lblpcb3.Text = pcblist(2)
                        lblpcb4.Text = pcblist(3)
                        txtscan.Text = ""
                    Case 5
                        pcblist.Sort()
                        lblscan.Text = "SCAN PCB:"
                        lblpcb1.Text = pcblist(0)
                        lblpcb2.Text = pcblist(1)
                        lblpcb3.Text = pcblist(2)
                        lblpcb4.Text = pcblist(3)
                        lblpcb5.Text = pcblist(4)
                        txtscan.Text = ""
                    Case 6
                        pcblist.Sort()
                        lblscan.Text = "SCAN PCB:"
                        lblpcb1.Text = pcblist(0)
                        lblpcb2.Text = pcblist(1)
                        lblpcb3.Text = pcblist(2)
                        lblpcb4.Text = pcblist(3)
                        lblpcb5.Text = pcblist(4)
                        lblpcb6.Text = pcblist(5)
                        'SetPCB(pcblist(0), pcblist(1), pcblist(2), pcblist(3), pcblist(4), pcblist(5))

                        txtscan.Text = ""
                End Select

                Select Case pcblist2.Count()
                    Case 0
                        lblscan.Text = "SCAN PCB:"

                        lblpcbnew1.Text = " "
                        lblpcbnew2.Text = " "
                        lblpcbnew3.Text = " "
                        lblpcbnew4.Text = " "
                        lblpcbnew5.Text = " "
                        lblpcbnew6.Text = " "
                        txtscan.Text = ""

                    Case 1
                        pcblist2.Sort()
                        lblscan.Text = "SCAN PCB:"
                        lblpcbnew1.Text = pcblist2(0)
                        txtscan.Text = ""
                    Case 2
                        pcblist2.Sort()
                        lblscan.Text = "SCAN PCB:"
                        lblpcbnew1.Text = pcblist2(0)
                        lblpcbnew2.Text = pcblist2(1)
                        txtscan.Text = ""
                    Case 3
                        pcblist2.Sort()
                        lblscan.Text = "SCAN PCB:"
                        lblpcbnew1.Text = pcblist2(0)
                        lblpcbnew2.Text = pcblist2(1)
                        lblpcbnew3.Text = pcblist2(2)
                        txtscan.Text = ""
                    Case 4
                        pcblist2.Sort()
                        lblscan.Text = "SCAN PCB:"
                        lblpcbnew1.Text = pcblist2(0)
                        lblpcbnew2.Text = pcblist2(1)
                        lblpcbnew3.Text = pcblist2(2)
                        lblpcbnew4.Text = pcblist2(3)
                        txtscan.Text = ""
                    Case 5
                        pcblist2.Sort()
                        lblscan.Text = "SCAN PCB:"
                        lblpcbnew1.Text = pcblist2(0)
                        lblpcbnew2.Text = pcblist2(1)
                        lblpcbnew3.Text = pcblist2(2)
                        lblpcbnew4.Text = pcblist2(3)
                        lblpcbnew5.Text = pcblist2(4)
                        txtscan.Text = ""
                    Case 6
                        pcblist2.Sort()
                        lblscan.Text = "SCAN PCB:"
                        lblpcbnew1.Text = pcblist2(0)
                        lblpcbnew2.Text = pcblist2(1)
                        lblpcbnew3.Text = pcblist2(2)
                        lblpcbnew4.Text = pcblist2(3)
                        lblpcbnew5.Text = pcblist2(4)
                        lblpcbnew6.Text = pcblist2(5)
                        SetPCB()
                        pcblist.Clear()
                        pcblist2.Clear()
                        txtscan.Text = ""
                End Select
#End Region


            Catch ex As Exception
                txtscan.Text = ""
                MsgBox("Invalid Input")
                MsgBox(ex.ToString)
                txtscan.Focus()
            End Try
        End If
    End Sub
    Private Function ExamineScan(ByVal scanText As String) As String
        Dim res As String = ""
        Select Case txtscan.Text.Length
            Case 22
                res = "pcb"
            Case <> 22
                MsgBox("UNKNOWN!")
                res = "Unknown"
        End Select
        ExamineScan = res
    End Function

    Private Function ExaminePCB(ByVal scanText As String) As String
        Dim cmd As New MySqlCommand
        Dim res As String = ""


        cmd.Connection = conn
        cmd.CommandText = "SELECT COUNT(pcbid2) FROM tblwashboard2 WHERE pcbid2 = '" + scanText + "'"
        If cmd.ExecuteScalar().ToString() = "1" Then
            res = ""
        Else
            res = "validpcb"
        End If
        ExaminePCB = res
    End Function

    'Private Sub checkpcb1()
    '    Dim cmd As New MySqlCommand

    '    If txtprevpcb1.Text = "" And txtcount.Text = "" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + lblpcb1.Text + "'"
    '        txtprevpcb1.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = "1"
    '        checkpcb1()
    '    ElseIf txtprevpcb1.Text <> "" And txtcount.Text = "1" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + txtprevpcb1.Text + "'"
    '        txtprevpcb2.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = 2
    '        checkpcb1()
    '    ElseIf txtprevpcb2.Text <> "" And txtcount.Text = "2" Then
    '        MsgBox("ReWash Limit Reached. PWB not accepted")
    '    End If

    'End Sub

    'Private Sub checkpcb2()
    '    Dim cmd As New MySqlCommand

    '    If txtprevpcb1.Text = "" And txtcount.Text = "" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + lblpcb2.Text + "'"
    '        txtprevpcb1.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = "1"
    '        checkpcb2()
    '    ElseIf txtprevpcb1.Text <> "" And txtcount.Text = "1" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + txtprevpcb1.Text + "'"
    '        txtprevpcb2.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = 2
    '        checkpcb2()
    '    ElseIf txtprevpcb2.Text <> "" And txtcount.Text = "2" Then
    '        MsgBox("ReWash Limit Reached. PWB not accepted")
    '    End If

    'End Sub

    'Private Sub checkpcb3()
    '    Dim cmd As New MySqlCommand

    '    If txtprevpcb1.Text = "" And txtcount.Text = "" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + lblpcb3.Text + "'"
    '        txtprevpcb1.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = "1"
    '        checkpcb3()
    '    ElseIf txtcount.Text = "1" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + txtprevpcb1.Text + "'"
    '        txtprevpcb2.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = 2
    '        checkpcb3()
    '    ElseIf txtcount.Text = "2" Then
    '        MsgBox("ReWash Limit Reached. PWB not accepted")
    '    End If

    'End Sub

    'Private Sub checkpcb4()
    '    Dim cmd As New MySqlCommand

    '    If txtprevpcb1.Text = "" And txtcount.Text = "" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + lblpcb4.Text + "'"
    '        txtprevpcb1.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = "1"
    '        checkpcb4()
    '    ElseIf txtcount.Text = "1" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + txtprevpcb1.Text + "'"
    '        txtprevpcb2.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = 2
    '        checkpcb4()
    '    ElseIf txtcount.Text = "2" Then
    '        MsgBox("ReWash Limit Reached. PWB not accepted")
    '    End If

    'End Sub

    'Private Sub checkpcb5()
    '    Dim cmd As New MySqlCommand

    '    If txtprevpcb1.Text = "" And txtcount.Text = "" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + lblpcb5.Text + "'"
    '        txtprevpcb1.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = "1"
    '        checkpcb5()
    '    ElseIf txtcount.Text = "1" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + txtprevpcb1.Text + "'"
    '        txtprevpcb2.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = 2
    '        checkpcb5()
    '    ElseIf txtcount.Text = "2" Then
    '        MsgBox("ReWash Limit Reached. PWB not accepted")
    '    End If

    'End Sub

    'Private Sub checkpcb6()
    '    Dim cmd As New MySqlCommand

    '    If txtprevpcb1.Text = "" And txtcount.Text = "" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + lblpcb6.Text + "'"
    '        txtprevpcb1.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = "1"
    '        checkpcb6()
    '    ElseIf txtcount.Text = "1" Then
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT pcb1 FROM tblwashboard2 WHERE pcbid2 = '" + txtprevpcb1.Text + "'"
    '        txtprevpcb2.Text = cmd.ExecuteScalar().ToString
    '        txtcount.Text = 2
    '        checkpcb6()
    '    ElseIf txtcount.Text = "2" Then
    '        MsgBox("ReWash Limit Reached. PWB not accepted")
    '    End If

    'End Sub
    Private Sub SetPCB()

        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        Try

            cmd.CommandText = "INSERT INTO tblwashboard2(pcbid1, pcbid2, wash_datetime, wash_pic) VALUES
('" + lblpcb1.Text + "', '" + lblpcbnew1.Text + "', NOW(), '" + lblname.Text + "'), 
('" + lblpcb2.Text + "', '" + lblpcbnew2.Text + "', NOW(), '" + lblname.Text + "'), 
('" + lblpcb3.Text + "', '" + lblpcbnew3.Text + "', NOW(), '" + lblname.Text + "'), 
('" + lblpcb4.Text + "', '" + lblpcbnew4.Text + "', NOW(), '" + lblname.Text + "'), 
('" + lblpcb5.Text + "', '" + lblpcbnew5.Text + "', NOW(), '" + lblname.Text + "'), 
('" + lblpcb6.Text + "', '" + lblpcbnew6.Text + "', NOW(), '" + lblname.Text + "')"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Invalid Action.")
        End Try
        lblpcb1.Text = " "
        lblpcb2.Text = " "
        lblpcb3.Text = " "
        lblpcb4.Text = " "
        lblpcb5.Text = " "
        lblpcb6.Text = " "

        lblpcbnew1.Text = " "
        lblpcbnew2.Text = " "
        lblpcbnew3.Text = " "
        lblpcbnew4.Text = " "
        lblpcbnew5.Text = " "
        lblpcbnew6.Text = " "
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Application.Restart()
    End Sub
    Private Function IsValidPCB(pcb As String) As Boolean
        Dim washcount As Integer = 0
        Dim oldpcb As String
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        oldpcb = pcb
        Do
            cmd.CommandText = "SELECT COUNT(pcbid2) FROM tblwashboard2 WHERE pcbid2 = '" & oldpcb & "'"
            If Val(cmd.ExecuteScalar().ToString()) > 0 Then
                washcount += 1
                cmd.CommandText = "SELECT pcbid1 FROM tblwashboard2 WHERE pcbid2 = '" & oldpcb & "'"
                oldpcb = cmd.ExecuteScalar().ToString()
            Else
                IsValidPCB = True
                Exit Do
            End If
        Loop Until washcount > 1
        If washcount > 1 Then
            IsValidPCB = False
        End If
        Return IsValidPCB
    End Function
End Class