Public Class frmerror
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.BackColor = Color.Red Then
            Me.BackColor = Color.Yellow
        Else
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class