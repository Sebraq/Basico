Public Class Conversiones
    Private Sub Bcerr_Click(sender As Object, e As EventArgs) Handles Bcerr.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        System.Threading.Thread.Sleep("500")
        End
    End Sub

    Private Sub Breg_Click(sender As Object, e As EventArgs) Handles Breg.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play(My.Resources.WHY_ARE_YOU_RUNNING__WITH_WOMAN_SCREAMING_, AudioPlayMode.Background)
    End Sub
End Class