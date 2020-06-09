Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        Me.Hide()
        Math.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play(My.Resources.OBI_WAN_HELLO_THERE, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        Tabla_Periodica.Show()
        Me.Hide()
    End Sub
End Class
