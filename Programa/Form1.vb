Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        Carga.Show()
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play(My.Resources.DOG_BARK_1, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play(My.Resources.IM_FAST_AS_F____BOI, AudioPlayMode.Background)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        Conversiones.Show()
        Me.Hide()
    End Sub

    Private Sub becono_Click(sender As Object, e As EventArgs) Handles becono.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        economia.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay
        Label3.Text = DateString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class