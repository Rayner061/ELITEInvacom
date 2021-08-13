Imports MySql.Data.MySqlClient

Public Class frmrepairendorsement
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim cmd As New MySqlCommand With {
            .Connection = conn
        }
        Dim reader As MySqlDataReader
        Try

            If Asc(e.KeyChar) = 13 Then
                TextBox1.Text = TextBox1.Text.ToUpper()
                lblpcb.Text = TextBox1.Text

                Matrix()
                cmd.CommandText = "SELECT sum(bilang)  FROM
	(SELECT COUNT(*) as bilang FROM `gi_aoing_bottom` WHERE `pcbid` = '" & TextBox1.Text & "'  UNION ALL 
	 SELECT COUNT(*) as bilang   FROM `gi_aoing_top` WHERE `pcbid` = '" & TextBox1.Text & "' UNION ALL 
	 SELECT COUNT(*) as bilang FROM `gi_fving` WHERE `pcbid` = '" & TextBox1.Text & "' UNION ALL 
	 SELECT COUNT(*) as bilang FROM `gi_obang` WHERE `pcbid` = '" & TextBox1.Text & "' ) 
	 AS a1 "
                If CInt(cmd.ExecuteScalar) <> 0 Then


                    cmd.CommandText = "SELECT DISTINCT b.`timestamp`, b.`defectname`, b.`remarks`,  b.`station`, a.`line_bottom`, a.`line_top` FROM `gi_pcbtrace` a LEFT JOIN (SELECT `pcbid` 'pcbid',  `defectname` 'defectname', `remarks` 'remarks', `aoingtimestamp` 'timestamp',`STATION` 'station' FROM
	(SELECT `pcbid`,  `defectname`, `remarks`, `aoingtimestamp`, 'AOI BOTTOM' as 'station' FROM `gi_aoing_bottom` UNION ALL 
	 SELECT `pcbid`,  `defectname`, `remarks`, `aoingtimestamp` , 'AOI TOP' as 'station' FROM `gi_aoing_top` UNION ALL 
	 SELECT `pcbid`,  `defectname`, `remarks`, `timestamp` , 'FVI' as 'station'  FROM `gi_fving` UNION ALL 
	 SELECT `pcbid`,  `defectname`, `remarks`, `timestamp` , 'OBA' as 'station'  FROM `gi_obang` ) 
	 AS a1 ) b ON a.`pcbid` = b.`pcbid` WHERE a.`pcbid` = '" & TextBox1.Text & "' ORDER BY b.`timestamp` DESC"
                    reader = cmd.ExecuteReader()
                    While reader.Read()
                        lblngdatetime.Text = reader.Item(0)
                        lbldefect.Text = reader.Item(1).ToString()
                        lbllocation.Text = reader.Item(2).ToString()
                        lblastation.Text = reader.Item(3).ToString()
                        lblline_top.Text = reader.Item(5).ToString()
                        lblline_bot.Text = reader.Item(4).ToString()
                    End While
                    reader.Close()
                    If lblngdatetime.Text = "" Then
                        TextBox1.Text = ""
                        lblpcb.Text = ""
                        lblmodel.Text = ""
                        lblcodeallo.Text = ""
                        lbldefect.Text = ""
                        lblline_bot.Text = ""
                        lblline_top.Text = ""
                        TextBox1.Focus()
                        MsgBox("Invalid Action. Please verify PCB declaration if Good or NG.")
                    Else
                        cmd.CommandText = "INSERT IGNORE INTO `gi_repairfifo` (`pcbid`, `model`, `defect_date_time`, `defect_name`, `location`, `station`, `line_bot`, `line_top`, `endorse_date_time`, `pic`, `status`, `category`) VALUES ('" + lblpcb.Text.ToUpper.ToString + "', '" + lblmodel.Text + "', '" & lblngdatetime.Text & "', '" + lbldefect.Text + "', '" & lbllocation.Text & "', '" & lblastation.Text & "', '" + lblline_bot.Text + "', '" + lblline_top.Text + "', NOW() ,'" + lblname.Text + "', 'received','" + cmbcategory.Text + "')"
                        cmd.ExecuteNonQuery()
                        gridout()
                        TextBox1.Text = ""
                        TextBox1.Focus()
                        lblngdatetime.Text = ""
                    End If
                Else
                    MsgBox("Invalid Action. Please verify PCB declaration if Good or NG.")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("Invalid Action.")
            writeLogs(ex.ToString + cmd.CommandText)
        End Try

    End Sub

    Public Sub gridout()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        cmd.CommandText = "SELECT `pcbid`, `model`, `defect_date_time`, `defect_name`, `line_bot`, `line_top`, `endorse_date_time`, `pic` FROM `gi_repairfifo` WHERE `status` = 'received' ORDER BY `endorse_date_time` DESC LIMIT 100"
        myDA.Fill(myDT)
        DataGridView1.DataSource = myDT
        cmd.CommandText = "SELECT COUNT(`pcbid`) FROM `gi_repairfifo` WHERE `status` = 'received'"
        lblpending.Text = cmd.ExecuteScalar
    End Sub

    Private Sub Matrix()
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader
        cmd.Connection = conn
        cmd.CommandText = "SELECT `model`, `code_allocation` FROM `gi_pcbtrace` a LEFT JOIN `gi_modelmatrix` b ON a.`modelmatrixid` = b.`modelmatrixid` WHERE `pcbid` = '" + TextBox1.Text.ToUpper.ToString() + "'"
        reader = cmd.ExecuteReader()
        lblmodel.Text = ""
        lblcodeallo.Text = ""
        While reader.Read()
            lblmodel.Text = reader.Item(0).ToString()
            lblcodeallo.Text = reader.Item(1).ToString()
        End While
        reader.Close()
    End Sub

    Private Sub frmrepairendorsement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        dtpicker1.Value = Now.ToString("yyyy-MM-dd")
        dtpicker2.Value = Now.AddDays(1).ToString("yyyy-MM-dd")
        cmbcategory.SelectedIndex = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldt.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub frmrepairendorsement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnprocessed_Click(sender As Object, e As EventArgs) Handles btnprocessed.Click
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn
        If lblmodel2.Text = "" Then
            cmd.CommandText = "SELECT `pcbid`, `model`, `defect_date_time`, `defect_name`, `line_bot`, `line_top`, `endorse_date_time`, `pic`  FROM `gi_repairfifo` WHERE `category` = '" + cmbcategory.Text + "' AND status <> 'received' AND  `endorse_date_time` BETWEEN '" + dtpicker1.Value + "' AND '" + dtpicker2.Value + "'"
            myDA.Fill(myDT)
            DataGridView1.DataSource = myDT
        Else
            cmd.CommandText = "SELECT `pcbid`, `model`, `defect_date_time`, `defect_name`, `line_bot`, `line_top`, `endorse_date_time`, `pic`  FROM `gi_repairfifo` WHERE `category` = '" + cmbcategory.Text + "' AND status <> 'received' AND `model` = '" + lblmodel2.Text + "' AND  `endorse_date_time` BETWEEN '" + dtpicker1.Value + "' AND '" + dtpicker2.Value + "'"
            myDA.Fill(myDT)
            DataGridView1.DataSource = myDT
        End If
        btnprocessed.BackColor = Color.Lime
        btnpending.BackColor = Color.FromArgb(238, 238, 238)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmlogin.Show()
        Hide()
    End Sub
End Class