Public Class ControlMental
    Public cont As Integer

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 90
        Timer1.Enabled = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cont < 101 Then
            ProgressBar1.Value = cont
            cont += 1
        Else
            Timer1.Enabled = False
            MessageBox.Show("Se ha terminado el tiempo!")
            Close()
        End If
    End Sub
End Class