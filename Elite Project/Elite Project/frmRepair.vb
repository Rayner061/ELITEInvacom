Imports MySql.Data.MySqlClient

Public Class frmRepair
    Private Sub tbpcb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbpcb.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                tbpcb.Text = tbpcb.Text.ToUpper.Trim
                lblpcb.Text = tbpcb.Text
                Dim cmd As New MySqlCommand With {
                .Connection = conn,
                .CommandText = "SELECT COUNT(pcbid) FROM epson_repairfifo WHERE pcbid = '" & tbpcb.Text & "'"
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
                    cmd.CommandText = "SELECT category FROM epson_repairfifo WHERE pcbid = '" & tbpcb.Text & "'"
                    If cmd.ExecuteScalar.ToString = "Repair" Or cmd.ExecuteScalar.ToString = "IPD" Or cmd.ExecuteScalar.ToString = "RTS" Then
                        cmd.CommandText = "SELECT modelmatrixid FROM epson_pcbtrace WHERE pcbid = '" + tbpcb.Text + "'"
                        If cmd.ExecuteScalar Is Nothing Then

                        Else
                            lblmatrix.Text = cmd.ExecuteScalar.ToString
                            'modelmatrix()
                        End If

                        'refreshandget()
                        'rccounting()
                        'turcounting()
                        'racounting()
                        'tbpcb.Text = ""
                        'Button1_KeyPress(sender, e)
                        'End If
                        cmd.CommandText = "UPDATE epson_repairfifo SET status = Now() WHERE pcbid = '" + tbpcb.Text + "'"
                        cmd.ExecuteNonQuery()
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
End Class