Imports MySql.Data.MySqlClient

Public Class frmRepair
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
                    'clean()
                    'cmd.CommandText = "SELECT count(pcbid) FROM epson_pcbtrace WHERE pcbid = '" + tbpcb.Text.ToString + "' and (aoistatus_bottom='ng' or aoistatus_top='ng' or ictstatus='ng' or fvistatus='ng' or obastatus='ng') "
                    '' MsgBox("SELECT count(pcbid) FROM epson_pcbtrace WHERE pcbid = '" + tbpcb.Text.ToString() + "' and (aoistatus_bottom='ng' or aoistatus_top='ng' or ictstatus='ng' or fvistatus='ng' or obastatus='ng') ")
                    'If cmd.ExecuteScalar = 0 Then
                    '    '  MsgBox(Val(cmd.ExecuteScalar()))
                    '    MessageBox.Show("PCB was not declared NG", "Prompt")
                    '    CHE()
                    '    Button1_KeyPress(sender, e)
                    'Else
                    cmd.CommandText = "SELECT category FROM gi_repairfifo WHERE pcbid = '" & tbpcb.Text & "'"
                    If cmd.ExecuteScalar.ToString = "Repair" Or cmd.ExecuteScalar.ToString = "IPD" Or cmd.ExecuteScalar.ToString = "RTS" Then
                        cmd.CommandText = "SELECT modelmatrixid FROM gi_pcbtrace WHERE pcbid = '" + tbpcb.Text + "'"
                        If cmd.ExecuteScalar Is Nothing Then

                        Else
                            lblmatrix.Text = cmd.ExecuteScalar.ToString
                            modelmatrix()
                        End If

                        refreshandget()
                        'rccounting()
                        'turcounting()
                        'racounting()
                        'tbpcb.Text = ""
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

    Public Sub refreshandget()
        checkrepro()
        'GetNGRecord()
        'checkbottop()
        'CheckTR()
        'CheckRARC()
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