Public Class economia
    Dim subto, total, ultimoenlista, ahorro, diversion, salud, suma As Double

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play(My.Resources.SAY_HELLO_TO_MY_LITTLE_FRIEND, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        System.Threading.Thread.Sleep("500")
        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If TextBox4.Text = "" Or TextBox4.Text = 0 Then
                My.Computer.Audio.Play(My.Resources.Y_U_ALWAYS_LYING, AudioPlayMode.Background)
                MsgBox("Datos faltantes")
                Return
            Else
                My.Computer.Audio.Play(My.Resources.KA_CHING, AudioPlayMode.Background)
                ahorro = 0.05 * Val(TextBox4.Text)
                diversion = 0.03 * Val(TextBox4.Text)
                salud = 0.1 * Val(TextBox4.Text)
                TextBox5.Text = ahorro
                TextBox6.Text = salud
                TextBox7.Text = diversion
                suma = Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox4.Text)
                TextBox8.Text = suma
                MsgBox("Ustede debe de tener minimo un sueldo de:  " & TextBox8.Text)
            End If
        Catch ex As Exception
            My.Computer.Audio.Play(My.Resources.Y_U_ALWAYS_LYING, AudioPlayMode.Background)
            MsgBox("Datos faltantes")
        End Try




    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            ultimoenlista = ListBox1.Items.Count - 1
            If ultimoenlista >= 0 Then
                subto = (Val(ListBox3.Items(ultimoenlista))) * Val(ListBox1.Items(ultimoenlista))
                total = total - subto
                TextBox4.Text = total

                ListBox2.Items.RemoveAt(ultimoenlista)
                ListBox3.Items.RemoveAt(ultimoenlista)
                ListBox4.Items.RemoveAt(ultimoenlista)
                ListBox1.Items.RemoveAt(ultimoenlista)
            Else
                MsgBox("No puede borrar datos de una lista vacia")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text And TextBox3.Text = "" Then
            MsgBox("Tiene que ingresar una cantidad del producto")
            Return
        ElseIf Not IsNumeric(TextBox1.Text And TextBox3.Text) Then
            MsgBox("Ingrese una cantidad numerica")
            Return
        ElseIf TextBox2.Text = "" Then
            MsgBox("Ingrese un producto")
            Return
        Else
            ListBox1.Items.Add(TextBox1.Text)
            ListBox2.Items.Add(TextBox2.Text)
            ListBox3.Items.Add(TextBox3.Text)
            subto = Val(TextBox1.Text) * Val(TextBox3.Text)
            ListBox4.Items.Add(subto)
            total = total + subto
            TextBox4.Text = total

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            Me.TextBox1.Focus()
        End If
    End Sub
End Class