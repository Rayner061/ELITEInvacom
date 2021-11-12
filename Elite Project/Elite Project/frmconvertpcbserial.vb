Imports MySql.Data.MySqlClient

Public Class frmconvertpcbserial

    Dim SelectedCodeallocation As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldt.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub frmconvertpcbserial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblaccount.Text = "user" Then
            txtoriginal.Enabled = False
            txtnew.Enabled = False
        Else
            txtoriginal.Enabled = True
            txtnew.Enabled = True
        End If
        btnsave.Enabled = False
        lblAssemblyVersion.Text = "Version " & frmlogin.assemblyVersion & " (General Release)"
    End Sub

    Private Sub cmbmodel_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbmodel.MouseClick
        Dim cmd As New MySqlCommand
        Dim myDA As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim myDT As New DataTable
        Dim customer As String = ""
        cmd.Connection = conn

        cmd.CommandText = "SELECT DISTINCT model FROM gi_modelmatrix WHERE active_status = 'yes'"
        myDA.Fill(myDT)
        cmbmodel.Items.Clear()

        For Each i As DataRow In myDT.Rows
            cmbmodel.Items.Add(i.Item(0).ToString)
        Next
    End Sub

    Private Sub txtoriginal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtoriginal.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                Dim cmd As New MySqlCommand
                Dim modematrixid As String
                cmd.Connection = conn
                cmd.CommandText = "SELECT modelmatrixid FROM gi_pcbtrace WHERE pcbid = '" + txtoriginal.Text + "'"
                modematrixid = cmd.ExecuteScalar.ToString
                cmd.CommandText = "SELECT code_allocation FROM gi_modelmatrix WHERE modelmatrixid = '" + modematrixid + "'"
                lblcodeorig.Text = cmd.ExecuteScalar.ToString

                cmd.CommandText = "SELECT model FROM gi_modelmatrix WHERE modelmatrixid = '" + modematrixid + "'"
                lblmodelorig.Text = cmd.ExecuteScalar.ToString

                txtnew.Focus()

                checkvalidityold(txtoriginal.Text)

                If lstOrig.Items.Count = 0 Then
                    txtoriginal.Enabled = False
                End If
            Catch ex As Exception
                MsgBox("Invalid PCB Number")
                txtoriginal.Text = ""
                txtoriginal.Focus()
            End Try
        End If
    End Sub

    Public Sub checkvalidityold(pcbidold As String)
        Dim cmd As New MySqlCommand
        Dim record, declaredfving, declaredFviSerialng, declaredobang, declaredObaSerialng As Boolean
        cmd.Connection = conn

        cmd.CommandText = "SELECT IF(COUNT(`pcbid`) > 0, TRUE, FALSE) FROM `gi_pcbtrace` WHERE `pcbid` = '" & pcbidold & "'"
        record = cmd.ExecuteScalar

        cmd.CommandText = "SELECT IF(COUNT(`pcbid`) > 0, TRUE, FALSE) FROM `gi_pcbtrace` WHERE `pcbid` = '" & pcbidold & "' AND fvistatus = 'ng'"
        declaredfving = cmd.ExecuteScalar

        cmd.CommandText = "SELECT IF(COUNT(`pcbid`) > 0, TRUE, FALSE) FROM `gi_fving` WHERE `pcbid` = '" & pcbidold & "' AND remarks = '%SERIAL%'"
        declaredFviSerialng = cmd.ExecuteScalar

        cmd.CommandText = "SELECT IF(COUNT(`pcbid`) > 0, TRUE, FALSE) FROM `gi_pcbtrace` WHERE `pcbid` = '" & pcbidold & "' AND obastatus = 'ng'"
        declaredobang = cmd.ExecuteScalar

        cmd.CommandText = "SELECT IF(COUNT(`pcbid`) > 0, TRUE, FALSE) FROM `gi_obang` WHERE `pcbid` = '" & pcbidold & "' AND remarks = '%SERIAL%'"
        declaredObaSerialng = cmd.ExecuteScalar

        If (declaredfving = True And declaredFviSerialng = False) Or (declaredobang = True And declaredObaSerialng = False) Then
            lstOrig.Items.Add("Not Declared As Serial NG!")
        End If

        If record = False Then
            lstOrig.Items.Add("Does not exist in records!")
        End If
    End Sub

    Private Sub txtnew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnew.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                If cmbmodel.Text <> "" Then
                    Dim cmd As New MySqlCommand
                    cmd.CommandText = "SELECT `code_allocation` FROM gi_modelmatrix WHERE model = '" + cmbmodel.Text + "'"
                    SelectedCodeallocation = cmd.ExecuteScalar
                    lblcodenew.Text = txtnew.Text.Substring(0, SelectedCodeallocation.Length)
                    checkvaliditynew(txtnew.Text)

                    If lstOrig.Items.Count = 0 Then
                        txtoriginal.Enabled = False
                    End If
                    cmbmodel.Enabled = False
                Else
                    MsgBox("Select Model")
                    txtnew.Text = ""
                    txtnew.Focus()
                End If
            Catch ex As Exception
                MsgBox("Invalid PCB Number")
                txtnew.Text = ""
                txtnew.Focus()
            End Try
        End If
    End Sub

    Public Sub checkvaliditynew(pcbidnew As String)
        Dim cmd As New MySqlCommand
        Dim code, record As Boolean
        cmd.Connection = conn

        cmd.CommandText = "SELECT IF(COUNT(`pcbid`) > 0, TRUE, FALSE) FROM `gi_pcbtrace` WHERE `pcbid` = '" & pcbidnew & "'"
        record = cmd.ExecuteScalar

        If SelectedCodeallocation = lblcodenew.Text Then
            code = True
        Else
            code = False
        End If


        lstNew.Items.Clear()

        If txtoriginal.Text = txtnew.Text Then
            lstNew.Items.Add("New PCB Must be Different")
        End If

        'If txtoriginal.Text.Length <> txtnew.Text.Length Then
        '    lstNew.Items.Add("Invalid Serial.")
        'End If

        If record = True Then
            lstNew.Items.Add("New PCB Has Already Data")
        End If

        If code = False Then
            lstNew.Items.Add("Code Allocation mismatch!")
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim cmd As New MySqlCommand
        cmd.Connection = conn
        Dim ModelMatrixID As String
        If lstOrig.Items.Count = 0 And lstNew.Items.Count = 0 Then
            cmd.CommandText = "SELECT `modelmatrixid` FROM gi_modelmatrix WHERE model = '" + cmbmodel.Text + "'"
            ModelMatrixID = cmd.ExecuteScalar

            cmd.CommandText = "UPDATE gi_pcbtrace set modelmatrixid = '" + ModelMatrixID + "' WHERE pcbid = '" + txtoriginal.Text + "'"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "UPDATE gi_repairtrace set modelmatrix = '" + ModelMatrixID + "' WHERE pcbid = '" + txtoriginal.Text + "'"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "gi_replace_pcb"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@oldPCBID", txtoriginal.Text.ToString())
            cmd.Parameters("@oldPCBID").Direction = ParameterDirection.Input

            cmd.Parameters.AddWithValue("@newPCBID", txtnew.Text.ToString())
            cmd.Parameters("@newPCBID").Direction = ParameterDirection.Input

            cmd.Parameters.AddWithValue("@affected", MySqlDbType.Int32)
            cmd.Parameters("@affected").Direction = ParameterDirection.Output

            cmd.Parameters.AddWithValue("@operator", lblname.Text.ToString)
            cmd.Parameters("@operator").Direction = ParameterDirection.Input

            cmd.ExecuteNonQuery()

            MsgBox("PCB ID replacement Successful!")
            txtnew.Text = ""
            txtoriginal.Text = ""
            lblmodelorig.Text = ""
            lblcodenew.Text = ""
            lblcodeorig.Text = ""

            txtoriginal.Focus()

            btnsave.Enabled = False
            cmbmodel.Enabled = True
        Else
            MsgBox("Action not permitted.")
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        frmlogin.Show()
        Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtnew.Text = ""
        txtoriginal.Text = ""

        txtoriginal.Enabled = True
        txtnew.Enabled = True
        cmbmodel.Enabled = True

        lblmodelorig.Text = ""
        lblcodenew.Text = ""
        lblcodeorig.Text = ""
        lstNew.Items.Clear()
        lstOrig.Items.Clear()
        txtoriginal.Focus()

        btnsave.Enabled = False
    End Sub
End Class