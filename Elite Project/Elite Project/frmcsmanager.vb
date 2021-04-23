Imports MySql.Data.MySqlClient
Imports System
Public Class frmcsmanager

    Dim creamidarray() As String = New String(6) {}

    Dim matrixid As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtdatetime.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
        Try

            Dim date1 As New DateTime(CInt(txtthaw1.Text.ToString().Substring(0, 4)), CInt(txtthaw1.Text.ToString().Substring(5, 2)), CInt(txtthaw1.Text.ToString().Substring(8, 2)), CInt(txtthaw1.Text.ToString().Substring(11, 2)), CInt(txtthaw1.Text.ToString().Substring(14, 2)), CInt(txtthaw1.Text.ToString().Substring(17, 2)))

            Dim diff As TimeSpan

            If txtbarcode1.Text = "" Then
                time1.Text = ""
            Else
                diff = Now.Subtract(date1)
                time1.Text = CInt(diff.TotalMinutes)
            End If

            Dim date2 As New DateTime(CInt(txtthaw2.Text.ToString().Substring(0, 4)), CInt(txtthaw2.Text.ToString().Substring(5, 2)), CInt(txtthaw2.Text.ToString().Substring(8, 2)), CInt(txtthaw2.Text.ToString().Substring(11, 2)), CInt(txtthaw2.Text.ToString().Substring(14, 2)), CInt(txtthaw2.Text.ToString().Substring(17, 2)))

            If txtbarcode2.Text = "" Then
                time2.Text = ""
            Else
                diff = Now.Subtract(date2)
                time2.Text = CInt(diff.TotalMinutes)
            End If

            Dim date3 As New DateTime(CInt(txtthaw3.Text.ToString().Substring(0, 4)), CInt(txtthaw3.Text.ToString().Substring(5, 2)), CInt(txtthaw3.Text.ToString().Substring(8, 2)), CInt(txtthaw3.Text.ToString().Substring(11, 2)), CInt(txtthaw3.Text.ToString().Substring(14, 2)), CInt(txtthaw3.Text.ToString().Substring(17, 2)))

            If txtbarcode3.Text = "" Then
                time3.Text = ""
            Else
                diff = Now.Subtract(date3)
                time3.Text = CInt(diff.TotalMinutes)
            End If

            Dim date4 As New DateTime(CInt(txtthaw4.Text.ToString().Substring(0, 4)), CInt(txtthaw4.Text.ToString().Substring(5, 2)), CInt(txtthaw4.Text.ToString().Substring(8, 2)), CInt(txtthaw4.Text.ToString().Substring(11, 2)), CInt(txtthaw4.Text.ToString().Substring(14, 2)), CInt(txtthaw4.Text.ToString().Substring(17, 2)))

            If txtbarcode4.Text = "" Then
                time4.Text = ""
            Else
                diff = Now.Subtract(date4)
                time4.Text = CInt(diff.TotalMinutes)
            End If

            Dim date5 As New DateTime(CInt(txtthaw5.Text.ToString().Substring(0, 4)), CInt(txtthaw5.Text.ToString().Substring(5, 2)), CInt(txtthaw5.Text.ToString().Substring(8, 2)), CInt(txtthaw5.Text.ToString().Substring(11, 2)), CInt(txtthaw5.Text.ToString().Substring(14, 2)), CInt(txtthaw5.Text.ToString().Substring(17, 2)))

            If txtbarcode5.Text = "" Then
                time5.Text = ""
            Else
                diff = Now.Subtract(date5)
                time5.Text = CInt(diff.TotalMinutes)
            End If

            Dim date6 As New DateTime(CInt(txtthaw6.Text.ToString().Substring(0, 4)), CInt(txtthaw6.Text.ToString().Substring(5, 2)), CInt(txtthaw6.Text.ToString().Substring(8, 2)), CInt(txtthaw6.Text.ToString().Substring(11, 2)), CInt(txtthaw6.Text.ToString().Substring(14, 2)), CInt(txtthaw6.Text.ToString().Substring(17, 2)))

            If txtbarcode6.Text = "" Then
                time6.Text = ""
            Else
                diff = Now.Subtract(date6)
                time6.Text = CInt(diff.TotalMinutes)
            End If

        Catch ex As Exception
            writeLogs(ex.ToString)
        End Try


        If Val(time1.Text) < 120 And Val(time1.Text) > 0 Then
            time1.BackColor = Color.Yellow
            time1.ForeColor = Color.Black
        ElseIf Val(time1.Text) > 119 And Val(time1.Text) < 4320 Then
            time1.BackColor = Color.Lime
            time1.ForeColor = Color.Black
        ElseIf Val(time1.Text) > 4319 Then
            time1.BackColor = Color.Red
            time1.ForeColor = Color.White
        Else
            time1.BackColor = Color.White
        End If

        If Val(time2.Text) < 120 And Val(time2.Text) > 0 Then
            time2.BackColor = Color.Yellow
            time2.ForeColor = Color.Black
        ElseIf Val(time2.Text) > 119 And Val(time2.Text) < 4320 Then
            time2.BackColor = Color.Lime
            time2.ForeColor = Color.Black
        ElseIf Val(time2.Text) > 4319 Then
            time2.BackColor = Color.Red
            time2.ForeColor = Color.White
        Else
            time2.BackColor = Color.White
        End If

        If Val(time3.Text) < 120 And Val(time3.Text) > 0 Then
            time3.BackColor = Color.Yellow
            time3.ForeColor = Color.Black
        ElseIf Val(time3.Text) > 119 And Val(time3.Text) < 4320 Then
            time3.BackColor = Color.Lime
            time3.ForeColor = Color.Black
        ElseIf Val(time3.Text) > 4319 Then
            time3.BackColor = Color.Red
            time3.ForeColor = Color.White
        Else
            time3.BackColor = Color.White
        End If

        If Val(time4.Text) < 120 And Val(time4.Text) > 0 Then
            time4.BackColor = Color.Yellow
            time4.ForeColor = Color.Black
        ElseIf Val(time4.Text) > 119 And Val(time4.Text) < 4320 Then
            time4.BackColor = Color.Lime
            time4.ForeColor = Color.Black
        ElseIf Val(time4.Text) > 4319 Then
            time4.BackColor = Color.Red
            time4.ForeColor = Color.White
        Else
            time4.BackColor = Color.White
        End If

        If Val(time5.Text) < 120 And Val(time5.Text) > 0 Then
            time5.BackColor = Color.Yellow
            time5.ForeColor = Color.Black
        ElseIf Val(time5.Text) > 119 And Val(time5.Text) < 4320 Then
            time5.BackColor = Color.Lime
            time5.ForeColor = Color.Black
        ElseIf Val(time5.Text) > 4319 Then
            time5.BackColor = Color.Red
            time5.ForeColor = Color.White
        Else
            time5.BackColor = Color.White
        End If

        If Val(time6.Text) < 120 And Val(time6.Text) > 0 Then
            time6.BackColor = Color.Yellow
            time6.ForeColor = Color.Black
        ElseIf Val(time6.Text) > 119 And Val(time6.Text) < 4320 Then
            time6.BackColor = Color.Lime
            time6.ForeColor = Color.Black
        ElseIf Val(time6.Text) > 4319 Then
            time6.BackColor = Color.Red
            time6.ForeColor = Color.White
        Else
            time6.BackColor = Color.White
        End If


    End Sub

    Private Sub cmbmode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmode.SelectedIndexChanged
        If cmbmode.Text = "Scrap" Then
            dgexpire.Visible = True
            dgcream.Visible = False
            refreshDetails3()
        Else
            dgexpire.Visible = False
            dgcream.Visible = True
            If cmbmode.Text = "Refrigerator" Then
                refreshDetails2()
            ElseIf cmbmode.Text = "Thawing" Then
                thawdetails()
            ElseIf cmbmode.Text = "Issuance" Then
                linedetails()
            ElseIf cmbmode.Text = "Restore" Then
                refreshDetails2()
            End If
        End If
        txtscan.Text = ""
        txtscan.Focus()
    End Sub

    Private Sub txtscan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtscan.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            Try
                If cmbmode.Text = "Refrigerator" Then
                    If txtscan.Text.Length = 36 Then
                        txtvalidity.Text = txtscan.Text.Substring(21, 10)
                        txtserial.Text = txtscan.Text.Substring(32, 4)
                        txtmfgdate.Text = txtscan.Text.Substring(10, 10)
                    ElseIf txtscan.Text.Length = 35 Then
                        txtvalidity.Text = txtscan.Text.Substring(17, 6)
                        txtserial.Text = txtscan.Text.Substring(32, 3)
                        txtmfgdate.Text = txtscan.Text.Substring(10, 6)
                    ElseIf txtscan.Text.Length = 28 Then
                        txtvalidity.Text = dateDecode(txtscan.Text.Substring(17, 6))
                        txtserial.Text = txtscan.Text.Substring(24, 4)
                        txtmfgdate.Text = dateDecode(txtscan.Text.Substring(10, 6))
                    Else
                        MsgBox("Unknown Cream Solder")
                        txtscan.Text = ""
                        txtscan.Focus()
                    End If
                    txtlot.Text = txtscan.Text.Substring(0, 9)
                    cmd.CommandText = "SELECT COUNT(creamid) FROM gi_creamsolder WHERE creamid = '" & txtscan.Text & "'"

                    If cmd.ExecuteScalar().ToString() = "0" Then
                        cmd.CommandText = "INSERT INTO gi_creamsolder(creamid, manufacturing_date, lotno, reftime, validitydate, serial) VALUES ('" & txtscan.Text & "', '" & txtmfgdate.Text & "', '" & txtlot.Text & "', NOW(), '" & txtvalidity.Text & "', '" & txtserial.Text & "')"
                        cmd.ExecuteNonQuery()
                    Else
                        MsgBox("Cream Solder ID already exist")
                        txtmfgdate.Text = ""
                        txtlot.Text = ""
                        txtvalidity.Text = ""
                        txtserial.Text = ""
                        txtscan.Text = ""
                    End If
                    refreshDetails2()
                    txtscan.Text = ""
                End If

                If cmbmode.Text = "Thawing" Then
                    Dim creamidexpected As String = ""

                    cmd.CommandText = "SELECT * FROM gi_view_cs_fifo"
                    creamidexpected = cmd.ExecuteScalar().ToString()

                    If creamidexpected = txtscan.Text Then
                        txtthaw.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")

                        cmd.CommandText = "SELECT COUNT(creamid) FROM gi_view_cream_validity WHERE creamid = '" & txtscan.Text & "' AND creamstatus = 'expired'"

                        If cmd.ExecuteScalar().ToString() = "1" Then
                            MsgBox("Action not permitted. Expired Cream Solder")
                        Else
                            cmd.CommandText = "SELECT timestampdiff(MINUTE, reftime, now()) from gi_creamsolder WHERE creamid = '" & txtscan.Text & "'"

                            cmd.CommandText = "UPDATE gi_creamsolder SET thawingtime = NOW() WHERE creamid = '" & txtscan.Text & "'"
                            cmd.ExecuteNonQuery()
                        End If
                    Else
                        MsgBox("Action not permitted. Next cream solder should be " & creamidexpected & ".")
                    End If
                    thawdetails()
                    txtscan.Text = ""
                End If

                If cmbmode.Text = "Issuance" Then
                    txtissue.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")

                    cmd.CommandText = "SELECT IFNULL(timestampdiff(MINUTE, thawingtime, now()), 0) from gi_creamsolder WHERE creamid = '" & txtscan.Text & "'"

                    If cmd.ExecuteScalar().ToString() < 120 Then
                        MsgBox("Action not permitted. Minimum Thawing: 2 Hours")
                    ElseIf cmd.ExecuteScalar().ToString() > 4319 Then
                        MsgBox("Action not permitted. Maximum Thawing: 72 Hours")
                    Else
                        cmd.CommandText = "UPDATE gi_creamsolder SET lineissuancetime = NOW() WHERE creamid = '" & txtscan.Text & "'"
                        cmd.ExecuteNonQuery()
                    End If
                    linedetails()
                    txtscan.Text = ""
                End If

                If cmbmode.Text = "Restore" Then
                    cmd.CommandText = "UPDATE gi_creamsolder SET reftime = '" & txtdatetime.Text & "', thawingtime = NULL, mixingtime = NULL, lineissuancetime = NULL, opendatetime = NULL WHERE creamid = '" & txtscan.Text & "'"
                    cmd.ExecuteNonQuery()
                    refreshDetails2()
                    txtscan.Text = ""
                End If

                If cmbmode.Text = "Scrap" Then
                    cmd.CommandText = "SELECT validitydate FROM gi_view_cream_validity WHERE creamid = '" & txtscan.Text & "'"
                    txtexpiration.Text = cmd.ExecuteScalar().ToString()

                    cmd.CommandText = "INSERT INTO gi_scrap_creamsolder VALUES('" & txtscan.Text & "', '" & txtexpiration.Text & "', '" & txtdatetime.Text & "')"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "DELETE FROM gi_creamsolder WHERE creamid = '" & txtscan.Text & "'"
                    cmd.ExecuteNonQuery()
                    txtexpiration.Text = ""
                End If
                refreshDetails()
                txtscan.Text = ""
            Catch ex As Exception
                txtscan.Text = ""
                MsgBox("Action not permitted.")
                MsgBox(ex.ToString)
                txtscan.Focus()
            End Try
        End If

    End Sub

    Private Sub frmcsmanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        refreshDetails()
        dgexpire.Visible = False
        lblAssemblyVersion.Text = "Version EPN-" & frmlogin.assemblyVersion & " (General Release)"
    End Sub

    Public Sub refreshDetails()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "Select COUNT(creamid) FROM gi_view_cream_validity WHERE creamstatus = 'expired'"

        If cmd.ExecuteScalar().ToString() = "0" Then
            lblrefcount.BackColor = Color.FromArgb(255, 192, 255, 192)
            lblrefcount.ForeColor = Color.Black
        Else
            lblrefcount.BackColor = Color.Red
            lblrefcount.ForeColor = Color.White
        End If

        picture1.Visible = False
        txtbarcode1.Text = ""
        txtthaw1.Text = ""
        time1.Text = ""
        picture2.Visible = False
        txtbarcode2.Text = ""
        txtthaw2.Text = ""
        time2.Text = ""
        picture3.Visible = False
        txtbarcode3.Text = ""
        txtthaw3.Text = ""
        time3.Text = ""
        picture4.Visible = False
        txtbarcode4.Text = ""
        txtthaw4.Text = ""
        time4.Text = ""
        picture5.Visible = False
        txtbarcode5.Text = ""
        txtthaw5.Text = ""
        time5.Text = ""
        picture6.Visible = False
        txtbarcode6.Text = ""
        txtthaw6.Text = ""
        time6.Text = ""

        Try
            Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim myDT As New DataTable

            cmd.CommandText = "SELECT COUNT(creamid) FROM gi_view_cream_validity"
            lblrefcount.Text = cmd.ExecuteScalar().ToString()

            cmd.CommandText = "SELECT COUNT(`creamid`) FROM `gi_creamsolder` WHERE `thawingtime` IS NOT NULL AND `lineissuancetime` IS NULL"
            lblthawcount.Text = cmd.ExecuteScalar().ToString()

            cmd.CommandText = "SELECT `creamid`, `thawingtime` FROM `gi_creamsolder` WHERE `thawingtime` IS NOT NULL AND `lineissuancetime` IS NULL ORDER BY `thawingtime` ASC LIMIT 6"
            myDA.Fill(myDT)

            cmd.CommandText = "SELECT COUNT(`creamid`) FROM `gi_creamsolder` WHERE `lineissuancetime` IS NOT NULL AND `opendatetime` IS NULL"
            lblissuecount.Text = cmd.ExecuteScalar().ToString()


            txtbarcode1.Text = myDT.Rows(0).Item(0).ToString()
            txtthaw1.Text = myDT.Rows(0).Item(1).ToString()
            picture1.Visible = True

            txtbarcode2.Text = myDT.Rows(1).Item(0).ToString()
            txtthaw2.Text = myDT.Rows(1).Item(1).ToString()
            picture2.Visible = True

            txtbarcode3.Text = myDT.Rows(2).Item(0).ToString()
            txtthaw3.Text = myDT.Rows(2).Item(1).ToString()
            picture3.Visible = True

            txtbarcode4.Text = myDT.Rows(3).Item(0).ToString()
            txtthaw4.Text = myDT.Rows(3).Item(1).ToString()
            picture4.Visible = True

            txtbarcode5.Text = myDT.Rows(4).Item(0).ToString()
            txtthaw5.Text = myDT.Rows(4).Item(1).ToString()
            picture5.Visible = True

            txtbarcode6.Text = myDT.Rows(5).Item(0).ToString()
            txtthaw6.Text = myDT.Rows(5).Item(1).ToString()
            picture6.Visible = True

        Catch ex As Exception

        End Try
        'refreshDetails2()
        refreshDetails3()
    End Sub

    Public Sub refreshDetails2()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        cmd.CommandText = "SELECT creamid, manufacturing_date, lotno, reftime, validitydate, serial FROM gi_creamsolder WHERE `manufacturing_date` IS NOT NULL AND `thawingtime` IS NULL"
        myDA.Fill(myDT)
        dgcream.DataSource = myDT
    End Sub

    Public Sub refreshDetails3()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        cmd.CommandText = "SELECT creamid, validitydate, creamstatus FROM gi_view_cream_validity WHERE creamstatus = 'expired'"
        myDA.Fill(myDT)
        dgexpire.DataSource = myDT

    End Sub

    Private Sub thawdetails()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        cmd.CommandText = "SELECT creamid, manufacturing_date, lotno, thawingtime, validitydate, serial FROM gi_creamsolder WHERE thawingtime is not NULL"
        myDA.Fill(myDT)
        dgcream.DataSource = myDT
    End Sub

    Private Sub linedetails()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        cmd.CommandText = "SELECT creamid, manufacturing_date, lotno, lineissuancetime, validitydate, serial FROM gi_creamsolder WHERE opendatetime is NULL AND lineissuancetime is not NULL"
        myDA.Fill(myDT)
        dgcream.DataSource = myDT
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        refreshDetails()
    End Sub

    Private Sub frmcsmanager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub GenerateBarcodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateBarcodesToolStripMenuItem.Click
        'frmcsprint.lblname.Text = txtuser.Text
        'frmcsprint.Show()
    End Sub
    Private Function dateDecode(dateString As String) As String
        Dim yy, mm, dd As String
        yy = "20" & dateString.Substring(0, 2)
        mm = dateString.Substring(2, 2)
        dd = dateString.Substring(4, 2)

        dateDecode = yy & "-" & mm & "-" & dd

        Return dateDecode
    End Function

    Private Sub PictureBox4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDoubleClick
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable

        cmd.Connection = conn

        cmd.CommandText = "SELECT * FROM gi_view_cs_fifo_list"
        myDA.Fill(myDT)

        Dim message As String = "Cream Solder FIFO List (Top 15)" & vbCrLf & vbCrLf

        For i As Integer = 0 To myDT.Rows.Count - 1
            message = message & (i + 1) & ". " & myDT.Rows(i).Item(0).ToString() & vbCrLf
        Next

        MessageBox.Show(message, "", MessageBoxButtons.OK)
    End Sub
End Class