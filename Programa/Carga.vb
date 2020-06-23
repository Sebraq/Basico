Public Class Carga
    Private Sub Carga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(15)
        If ProgressBar1.Value = 110 Then
            Timer1.Stop()
            Form1.Hide()
            Me.Hide()
            Me.Close()
            Tabla_Periodica.Show()
        End If
    End Sub
End Class