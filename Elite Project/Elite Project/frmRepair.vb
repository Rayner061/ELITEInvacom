Imports MySql.Data.MySqlClient

Public Class frmRepair

    Public pcb, linetop, linebottom, turcount, rccount, racount, subs, modelamatrix As String

    Private Sub tbpcb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbpcb.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                tbpcb.Text = tbpcb.Text.ToUpper.Trim
                lblpcb.Text = tbpcb.Text
                Dim cmd As New MySqlCommand With {
                .Connection = conn,
                .CommandText = "SELECT COUNT(pcbid) FROM gi_repairfifo WHERE pcbid = '" & tbpcb.Text & "'"
            }
                If cmd.ExecuteScalar = 0 Then
                    MessageBox.Show("PCB was not properly endorsed.", "Prompt")
                Else

                    cmd.CommandText = "SELECT category FROM gi_repairfifo WHERE pcbid = '" & tbpcb.Text & "'"
                    If cmd.ExecuteScalar.ToString = "Repair" Or cmd.ExecuteScalar.ToString = "IPD" Or cmd.ExecuteScalar.ToString = "RTS" Then
                        cmd.CommandText = "SELECT modelmatrixid FROM gi_pcbtrace WHERE pcbid = '" + tbpcb.Text + "'"
                        If cmd.ExecuteScalar Is Nothing Then

                        Else
                            lblmatrix.Text = cmd.ExecuteScalar.ToString
                            modelmatrix()
                        End If

                        refreshandget()
                        rccounting()
                        turcounting()
                        racounting()
                        tbpcb.Text = ""
                        'Button1_KeyPress(sender, e)
                        'End If
                        cmd.CommandText = "UPDATE gi_repairfifo SET status = Now() WHERE pcbid = '" + tbpcb.Text + "'"
                        'cmd.ExecuteNonQuery()
                    ElseIf cmd.ExecuteScalar.ToString = "MRB" Then
                        MsgBox("This unit was scanned as MRB")
                    ElseIf cmd.ExecuteScalar.ToString = "Hold" Then
                        MsgBox("This unit was scanned as HOLD")
                    ElseIf cmd.ExecuteScalar.ToString = "Scrap" Then
                        MsgBox("This unit was scanned as Scrap")
                    ElseIf cmd.ExecuteScalar.ToString = "Old Inputs" Then
                        MsgBox("This unit was scanned as Old Inputs")

                    End If
                End If
                tbpcb.Text = ""
                tbpcb.Focus()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Public Sub racounting()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_reattached WHERE pcbid = '" + lblpcb.Text + "'"
        racount = Val(cmd.ExecuteScalar().ToString()) + 1


    End Sub
    Public Sub turcounting()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_touchuprepair WHERE pcbid = '" + lblpcb.Text + "'"
        turcount = Val(cmd.ExecuteScalar().ToString()) + 1
    End Sub

    Public Sub rccounting()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        cmd.CommandText = "SELECT COUNT(pcbid) FROM gi_replacecomponent WHERE pcbid = '" + lblpcb.Text + "'"
        rccount = Val(cmd.ExecuteScalar().ToString()) + 1

    End Sub

    Public Sub modelmatrix()
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader
        cmd.Connection = conn
        cmd.CommandText = "SELECT model,code_allocation FROM gi_modelmatrix WHERE modelmatrixid = '" + lblmatrix.Text + "'"
        reader = cmd.ExecuteReader()
        While reader.Read()
            lblmodel.Text = reader.Item(0).ToString()
            lblcodeallo.Text = reader.Item(1).ToString()
        End While
        reader.Close()
    End Sub


    Public Sub deleter()


        RC_lblpartcodep_bot.Text = ""
        RC_lbldid_bot.Text = ""
        RC_lbllotnum_bot.Text = ""
        RC_lblmaker_bot.Text = ""
        RC_cmbloc.SelectedIndex = -1

        RC_lbllocation.Text = ""
        RC_lblpartcoder.Text = ""

    End Sub

    Public Sub deleter1()


        RA_lblpartcode.Text = ""
        RA_lbldid.Text = ""
        RA_lbllotnum.Text = ""
        RA_lblmaker.Text = ""
        RA_cmbloc.SelectedIndex = -1

        RA_loc.Text = ""
        RA_partcode.Text = ""

    End Sub

    Private Sub RC_cmbloc_MouseClick(sender As Object, e As MouseEventArgs) Handles RC_cmbloc.MouseClick

        If RC_cmbloc_initial.SelectedIndex = -1 Then
            MsgBox("Please choose location initial before you proceed.")
        Else
            checkbottop()
            checksub()
            RC_cmbloc.DataSource = Nothing
            Dim sqlString As String


            'sqlString = "SELECT DISTINCT location FROM tblmountertrace where pcbid = '" + lblpcb.Text + "' "
            sqlString = "SELECT location FROM gi_mountertrace_" & linebottom & " where pcbid = '" + lblpcb.Text + "' and " + subs + " union all SELECT location FROM gi_mountertrace_" & linetop & " where pcbid = '" + lblpcb.Text + "' AND " + subs + " order by location asc "

            Dim cmd As New MySqlCommand(sqlString, conn)
            Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim myDT As New DataTable

            myDA.Fill(myDT)

            RC_cmbloc.DataSource = myDT
            RC_cmbloc.DisplayMember = "location"
            RC_cmbloc.ValueMember = "location"

            deleter()
        End If
    End Sub

    Public Sub checksub()
        If RC_cmbloc_initial.Text = "B" Then
            subs = "(SUBSTR(location, 1, 1) = 'B')"

        ElseIf RC_cmbloc_initial.Text = "C" Then
            subs = "(SUBSTR(location, 1, 1) = 'C')"

        ElseIf RC_cmbloc_initial.Text = "CN" Then
            subs = "(SUBSTR(location, 1, 2) = 'CN')"

        ElseIf RC_cmbloc_initial.Text = "CR" Then
            subs = "(SUBSTR(location, 1, 2) = 'CR')"

        ElseIf RC_cmbloc_initial.Text = "D" Then
            subs = "(SUBSTR(location, 1, 1) = 'D')"

        ElseIf RC_cmbloc_initial.Text = "DM" Then
            subs = "(SUBSTR(location, 1, 2) = 'DM')"

        ElseIf RC_cmbloc_initial.Text = "F" Then
            subs = "(SUBSTR(location, 1, 1) = 'F')"

        ElseIf RC_cmbloc_initial.Text = "FL" Then
            subs = "(SUBSTR(location, 1, 2) = 'FL')"

        ElseIf RC_cmbloc_initial.Text = "IC" Then
            subs = "(SUBSTR(location, 1, 2) = 'IC')"

        ElseIf RC_cmbloc_initial.Text = "L" Then
            subs = "(SUBSTR(location, 1, 1) = 'L')"

        ElseIf RC_cmbloc_initial.Text = "PC" Then
            subs = "(SUBSTR(location, 1, 2) = 'PC')"

        ElseIf RC_cmbloc_initial.Text = "Q" Then
            subs = "(SUBSTR(location, 1, 1) = 'Q')"

        ElseIf RC_cmbloc_initial.Text = "QF" Then
            subs = "(SUBSTR(location, 1, 2) = 'QF')"

        ElseIf RC_cmbloc_initial.Text = "QM" Then
            subs = "(SUBSTR(location, 1, 2) = 'QM')"

        ElseIf RC_cmbloc_initial.Text = "R" Then
            subs = "(SUBSTR(location, 1, 1) = 'R')"

        ElseIf RC_cmbloc_initial.Text = "TH" Then
            subs = "(SUBSTR(location, 1, 2) = 'TH')"

        ElseIf RC_cmbloc_initial.Text = "ZD" Then
            subs = "(SUBSTR(location, 1, 2) = 'ZD')"


        End If
    End Sub

    Private Sub RC_cmbloc_initial_MouseClick(sender As Object, e As MouseEventArgs) Handles RC_cmbloc_initial.MouseClick
        RC_cmbloc.DataSource = Nothing
        deleter()
    End Sub

    Private Sub RC_cmbloc_DropDownClosed(sender As Object, e As EventArgs) Handles RC_cmbloc.DropDownClosed
        Try
            If RC_cmbloc.Text = "" Then

            Else
                Dim cmd As New MySqlCommand
                Dim reader As MySqlDataReader

                cmd.Connection = conn

                cmd.CommandText = "SELECT * FROM gi_mountertrace_" & linebottom & " WHERE pcbid = '" + lblpcb.Text + "' AND location like '%" + RC_cmbloc.Text + "%'
							union all SELECT * FROM gi_mountertrace_" & linetop & " WHERE pcbid = '" + lblpcb.Text + "' AND location like '%" + RC_cmbloc.Text + "%' "
                ' MsgBox("SELECT * FROM epson_mountertrace_" & linebottom & " WHERE pcbid = '" + lblpcb.Text + "' AND location like '%" + RC_cmbloc.Text + "%'
                '  union all SELECT * FROM epson_mountertrace_" & linetop & " WHERE pcbid = '" + lblpcb.Text + "' AND location like '%" + RC_cmbloc.Text + "%' ")
                reader = cmd.ExecuteReader()

                While reader.Read()
                    RC_lblpartcodep_bot.Text = reader.Item(5).ToString()
                    RC_lbldid_bot.Text = reader.Item(10).ToString()
                    RC_lbllotnum_bot.Text = reader.Item(7).ToString()
                    RC_lblmaker_bot.Text = reader.Item(8).ToString()

                End While
                reader.Close()


                RC_lbllocation.Text = RC_cmbloc.Text
                'enabler()
                RC_tbscanqr.Enabled = True
                RC_tbscanqr.Focus()


                RC_tbdid.Text = ""
                RC_tblotnum.Text = ""
                RC_tbmaker.Text = ""

            End If
        Catch ex As Exception
            MsgBox("Please check if PCB has no tracability data or no mounter data.")
        End Try
    End Sub

    Private Sub RC_tbscanqr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RC_tbscanqr.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If RC_tbscanqr.Text = "" Then
                MessageBox.Show("Please scan qr label", "Error")
            Else
                Dim did As String = RC_tbscanqr.Text.Substring(0, 15)
                Dim cmd As New MySqlCommand With {
                    .Connection = conn
                }
                cmd.CommandText = "SELECT did,gcode,vendor,lot_no from gi_whissuance Where did = '" & did & "'"
                Dim rd As MySqlDataReader
                rd = cmd.ExecuteReader
                If rd.Read Then
                    RC_tbdid.Text = rd.Item(0).ToString
                    RC_tblotnum.Text = rd.Item(3).ToString
                    RC_tbmaker.Text = rd.Item(2).ToString
                    RC_lblpartcoder.Text = rd.Item(1).ToString
                End If
                rd.Close()
                If RC_tbdid.Text <> "" Then
                    RC_save.Enabled = True
                    RC_tbscanqr.Text = ""
                Else
                    RC_save.Enabled = False
                    RC_tbscanqr.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub RC_save_Click(sender As Object, e As EventArgs) Handles RC_save.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        If RC_tbdid.Text = "" Or RC_tblotnum.Text = "" Or RC_tbmaker.Text = "" Then
            MessageBox.Show("Invalid Entry. Please scan qr", "Error")
        Else
            If RC_lblpartcodep_bot.Text <> RC_lblpartcoder.Text Then
                MessageBox.Show("Invalid Entry. Part Number Mismatch", "Error")
            Else

                checkrepairtracedata(lblpcb.Text, "repair_rc")

                cmd.CommandText = "INSERT INTO gi_replacecomponent (	pcbid,	location,	materialcode,	partnumber,	lotnumber,	vendor,	repairdatetime,	repairman,	repairsequence	)
 VALUES ('" + lblpcb.Text + "', '" + RC_lbllocation.Text + "', '" + RC_tbdid.Text + "','" + RC_lblpartcoder.Text + "' , '" + RC_tblotnum.Text + "', '" + RC_tbmaker.Text + "', NOW(), '" + lblname.Text + "', '" + rccount + "' )"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Succesfully Saved", "Success")

                deleter()

                RC_lbllocation.Text = ""
                RC_lblpartcoder.Text = ""
                RC_tbdid.Text = ""
                RC_tblotnum.Text = ""
                RC_tbmaker.Text = ""
                RC_cmbloc_initial.SelectedIndex = -1

                rccounting()
                CheckTR()
                CheckRARC()
                CHE()

            End If
        End If
    End Sub

    Public Sub dels()

        lblcodeallo.Text = ""
        lblmodel.Text = ""
        ' FT_dgv.DataSource = Nothing
        RC_dgv.DataSource = Nothing

        tbpcb.Focus()
    End Sub

    Public Sub CHE()
        tbpcb.Text = ""
        tbpcb.Text = Nothing
        lblpcb.Text = ""
        VA_dgv.DataSource = Nothing
        ' FT_dgv.DataSource = Nothing
        tbpcb.Focus()

        RC_cmbloc.Enabled = False
        RC_cmbloc_initial.Enabled = False
        TR_tbremarks.Enabled = False
        TR_save.Enabled = False

        RC_lbllocation.Text = ""
        RC_lblpartcoder.Text = ""
        RC_tbdid.Text = ""
        RC_tblotnum.Text = ""
        RC_tbmaker.Text = ""
        RC_cmbloc_initial.SelectedIndex = -1
        RC_cmbloc.SelectedIndex = -1


        RA_cmbloc.Enabled = False
        RA_cmbloc_initial.Enabled = False
        RA_loc.Text = ""
        RA_partcode.Text = ""
        RA_tbdid.Text = ""
        RA_tblotnum.Text = ""
        RA_tbmaker.Text = ""
        RA_cmbloc_initial.SelectedIndex = -1
        RA_cmbloc.SelectedIndex = -1
        dels()
        deleter()
        deleter1()
        tbpcb.Text = ""
    End Sub

    Public Sub checkrepairtracedata(pcb As String, rep As String)
        Dim cmd As New MySqlCommand
        Dim aoilotnum As String
        cmd.Connection = conn

        modelchecker()

        Try
            cmd.CommandText = "SELECT count(*) FROM gi_repairtrace where pcbid = '" + pcb + "' "
            If Val(cmd.ExecuteScalar) = Val(0) Then
                '#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                cmd.CommandText = "INSERT INTO epson_repairtrace (pcbid, modelmatrix, processtoken, timestamp) VALUES ('" + pcb + "', '" + modelamatrix + "', '" + rep + "', NOW())"
                '#Enable Warning BC42104 ' Variable is used before it has been assigned a value
                cmd.ExecuteNonQuery()
            Else

                cmd.CommandText = "delete from epson_repairtrace  WHERE pcbid = '" + pcb + "' "
                cmd.ExecuteNonQuery()
                cmd.CommandText = "INSERT INTO epson_repairtrace (pcbid, modelmatrix, processtoken, timestamp, aoilotnum) VALUES ('" + pcb + "', '" + modelamatrix + "', '" + rep + "', NOW())"
                '#Enable Warning BC42104 ' Variable is used before it has been assigned a value
                cmd.ExecuteNonQuery()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        frmlogin.Show()
        Close()
    End Sub

    Private Sub TR_save_Click(sender As Object, e As EventArgs) Handles TR_save.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn

        If TR_tbremarks.Text = "" Then
            MessageBox.Show("Invalid Entry. Please input remarks.", "Error")
        Else

            cmd.CommandText = "INSERT INTO `epson_touchuprepair` (`pcbid`, `remarks`, `repairdatetime`, `repairman`, `repairsequence`) VALUES ('" + lblpcb.Text + "', '" + TR_tbremarks.Text + "', NOW(), '" + lblname.Text + "', '" + turcount + "' )"
            cmd.ExecuteNonQuery()

            checkrepairtracedata(lblpcb.Text, "repair_tr")
            MessageBox.Show("Succesfully Saved", "Success")
            TR_tbremarks.Text = ""
            lblcharcount.Text = TR_tbremarks.Text.Length & "/300 characters (max)"
            turcounting()
            CheckTR()
            CheckRARC()
            CHE()
        End If
    End Sub

    Private Sub RA_cmbloc_initial_MouseClick(sender As Object, e As MouseEventArgs) Handles RA_cmbloc_initial.MouseClick
        RA_cmbloc.DataSource = Nothing
        deleter()
    End Sub

    Private Sub RA_cmbloc_MouseClick(sender As Object, e As MouseEventArgs) Handles RA_cmbloc.MouseClick
        If RA_cmbloc_initial.SelectedIndex = -1 Then
            MsgBox("Please choose location initial before you proceed.")
        Else
            checkbottop()
            checksub1()
            RA_cmbloc.DataSource = Nothing
            Dim sqlString As String

            sqlString = "SELECT location FROM gi_mountertrace_" & linebottom & " where pcbid = '" + lblpcb.Text + "' and " + subs + " union all SELECT location FROM gi_mountertrace_" & linetop & " where pcbid = '" + lblpcb.Text + "' AND " + subs + " order by location asc "
            Dim cmd As New MySqlCommand(sqlString, conn)
            Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim myDT As New DataTable

            myDA.Fill(myDT)

            RA_cmbloc.DataSource = myDT
            RA_cmbloc.DisplayMember = "location"
            RA_cmbloc.ValueMember = "location"

            deleter1()
        End If
    End Sub

    Public Sub checksub1()
        If RA_cmbloc_initial.Text = "B" Then
            subs = "(SUBSTR(location, 1, 1) = 'B')"

        ElseIf RA_cmbloc_initial.Text = "C" Then
            subs = "(SUBSTR(location, 1, 1) = 'C')"

        ElseIf RA_cmbloc_initial.Text = "CN" Then
            subs = "(SUBSTR(location, 1, 2) = 'CN')"

        ElseIf RA_cmbloc_initial.Text = "CR" Then
            subs = "(SUBSTR(location, 1, 2) = 'CR')"

        ElseIf RA_cmbloc_initial.Text = "D" Then
            subs = "(SUBSTR(location, 1, 1) = 'D')"

        ElseIf RA_cmbloc_initial.Text = "DM" Then
            subs = "(SUBSTR(location, 1, 2) = 'DM')"

        ElseIf RA_cmbloc_initial.Text = "F" Then
            subs = "(SUBSTR(location, 1, 1) = 'F')"

        ElseIf RA_cmbloc_initial.Text = "FL" Then
            subs = "(SUBSTR(location, 1, 2) = 'FL')"

        ElseIf RA_cmbloc_initial.Text = "IC" Then
            subs = "(SUBSTR(location, 1, 2) = 'IC')"

        ElseIf RA_cmbloc_initial.Text = "L" Then
            subs = "(SUBSTR(location, 1, 1) = 'L')"

        ElseIf RA_cmbloc_initial.Text = "PC" Then
            subs = "(SUBSTR(location, 1, 2) = 'PC')"

        ElseIf RA_cmbloc_initial.Text = "Q" Then
            subs = "(SUBSTR(location, 1, 1) = 'Q')"

        ElseIf RA_cmbloc_initial.Text = "QF" Then
            subs = "(SUBSTR(location, 1, 2) = 'QF')"

        ElseIf RA_cmbloc_initial.Text = "QM" Then
            subs = "(SUBSTR(location, 1, 2) = 'QM')"

        ElseIf RA_cmbloc_initial.Text = "R" Then
            subs = "(SUBSTR(location, 1, 1) = 'R')"

        ElseIf RA_cmbloc_initial.Text = "TH" Then
            subs = "(SUBSTR(location, 1, 2) = 'TH')"

        ElseIf RA_cmbloc_initial.Text = "ZD" Then
            subs = "(SUBSTR(location, 1, 2) = 'ZD')"

        End If
    End Sub

    Public Sub modelchecker()
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Try
            cmd.CommandText = "SELECT modelmatrixid FROM gi_pcbtrace WHERE pcbid = '" + lblpcb.Text + "'"
            modelamatrix = cmd.ExecuteScalar
        Catch ex As Exception

            MsgBox("No Model Selected in PRIME Data.")
            'model = "E"
        End Try
    End Sub

    Public Sub refreshandget()
        checkrepro()
        GetNGRecord()
        checkbottop()
        CheckTR()
        CheckRARC()
    End Sub

    Public Sub CheckRARC()
        RC_dgv.Refresh()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT * FROM (SELECT pcbid as 'PCBID','REATTACHED' as 'TYPE',location as 'LOCATION',materialcode as 'DID',partnumber as 'PART NUMBER',lotnumber as 'LOT NUMBER',vendor as 'MAKER',topmark as 'TOPMARK', repairdatetime as 'REPAIR TIMESTAMP', repairman as 'OPERATOR',repairsequence as 'REPAIR COUNT' FROM gi_reattached WHERE pcbid = '" + lblpcb.Text + "' UNION SELECT pcbid as 'PCBID','REPLACE' as 'TYPE',location as 'LOCATION',materialcode as 'DID',partnumber as 'PART NUMBER',lotnumber as 'LOT NUMBER',vendor as 'MAKER',topmark as 'TOPMARK', repairdatetime as 'REPAIR TIMESTAMP', repairman as 'OPERATOR',repairsequence as 'REPAIR COUNT' FROM gi_replacecomponent WHERE pcbid = '" + lblpcb.Text + "') a"
        myDA.Fill(myDT)
        RC_dgv.DataSource = Nothing
        RC_dgv.DataSource = myDT
    End Sub

    Public Sub CheckTR()
        TR_dgv.Refresh()
        Dim cmd As New MySqlCommand
        Dim myDA As New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        cmd.Connection = conn

        cmd.CommandText = "SELECT pcbid as 'PCBID',remarks as 'REMARKS',repairdatetime as 'REPAIR TIMESTAMP',repairman as 'OPERATOR',repairsequence as 'REPAIR COUNT' FROM gi_touchuprepair WHERE pcbid = '" + lblpcb.Text + "'"
        myDA.Fill(myDT)
        TR_dgv.DataSource = myDT
    End Sub

    Public Sub checkbottop()
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader
        cmd.Connection = conn

        cmd.CommandText = "SELECT pcbid,line_bottom,line_top FROM gi_pcbtrace  WHERE pcbid = '" + lblpcb.Text + "'"
        reader = cmd.ExecuteReader()
        While reader.Read()
            pcb = reader.Item("pcbid").ToString()
            linebottom = reader.Item("line_bottom").ToString()
            linetop = reader.Item("line_top").ToString()
        End While
        reader.Close()

    End Sub

    Private Sub GetNGRecord()
		Dim dt As New DataTable
        Dim cmd As New MySqlCommand With {
            .Connection = conn,
            .CommandText = "Select DISTINCT b.`timestamp`, b.`station`, b.`defectname`, b.`remarks`  FROM (Select `pcbid` 'pcbid',  `defectname` 'defectname', `remarks` 'remarks', `aoingtimestamp` 'timestamp',`STATION` 'station' FROM
	(SELECT `pcbid`,  `defectname`, `remarks`, `aoingtimestamp`, 'AOI BOTTOM' as 'station' FROM `gi_aoing_bottom` UNION ALL 
	 Select `pcbid`,  `defectname`, `remarks`, `aoingtimestamp` , 'AOI TOP' as 'station' FROM `gi_aoing_top` UNION ALL  
	 Select `pcbid`,  `defectname`, `remarks`, `timestamp`, 'FVI' as 'station'   FROM `gi_fving` UNION ALL 
	 Select `pcbid`,  `defectname`, `remarks`, `timestamp` , 'OBA' as 'station'  FROM `gi_obang` ) 
	 AS a1 ) b  WHERE b.`pcbid` = '" & tbpcb.Text & "' ORDER BY b.`timestamp` DESC"
        }
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
		da.Fill(dt)

		VA_dgv.DataSource = Nothing
		VA_dgv.DataSource = dt.DefaultView

		If VA_dgv.Rows.Count <> 0 Then
			RC_cmbloc.Enabled = True
			RC_cmbloc_initial.Enabled = True
			TR_tbremarks.Enabled = True
			RA_cmbloc.Enabled = True
			RA_cmbloc_initial.Enabled = True
		Else
			MsgBox("NO NG RECORD FOUND.")
		End If
	End Sub

    Public Sub checkrepro()
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM gi_repairtrace WHERE pcbid = '" + lblpcb.Text + "'"
        reader = cmd.ExecuteReader
        While reader.Read


            lblaoitopdt.Text = reader.Item(4).ToString
            lblaoitopoperator.Text = reader.Item(5).ToString
            lblaoitopresult.Text = reader.Item(6).ToString
            lblaoitopdefectname.Text = reader.Item(7).ToString
            lblaoitopremarks.Text = reader.Item(8).ToString

            lblfvidt.Text = reader.Item(9).ToString
            lblfviop.Text = reader.Item(10).ToString
            lblfvire.Text = reader.Item(11).ToString
            lblfvidef.Text = reader.Item(12).ToString
            lblfvirem.Text = reader.Item(13).ToString

            lbloqcdt.Text = reader.Item(15).ToString
            lbloqcop.Text = reader.Item(16).ToString
            lbloqcre.Text = reader.Item(17).ToString
            lbloqcdef.Text = reader.Item(18).ToString
            lbloqcrem.Text = reader.Item(19).ToString

        End While
        reader.Close()
    End Sub
End Class