Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        Tabla_Periodica.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        Math.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        System.Threading.Thread.Sleep("500")
        End

    End Sub
End Class