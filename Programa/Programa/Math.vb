Public Class Math

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        End
    End Sub

    Private Sub btnsum_Click(sender As Object, e As EventArgs) Handles btnsum.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox2.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        End If
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        Label2.Text = "+"
    End Sub

    Private Sub btnres_Click(sender As Object, e As EventArgs) Handles btnres.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox2.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        End If
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        Label2.Text = "-"
    End Sub

    Private Sub btnmul_Click(sender As Object, e As EventArgs) Handles btnmul.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox2.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        End If
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        Label2.Text = "*"
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox2.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        End If
        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        Label2.Text = "/"
    End Sub

    Private Sub btnbor_Click(sender As Object, e As EventArgs) Handles btnbor.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label2.Text = ""


    End Sub


    Private Sub bcuad_Click(sender As Object, e As EventArgs) Handles bcuad.Click
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        End If
        TextBox5.Text = Val(TextBox4.Text) * Val(TextBox4.Text)
        Label7.Text = "^2"
    End Sub

    Private Sub Bcubo_Click(sender As Object, e As EventArgs) Handles Bcubo.Click
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        End If
        TextBox5.Text = Val(TextBox4.Text) * Val(TextBox4.Text) * Val(TextBox4.Text)
        Label7.Text = "^3"
    End Sub

    Private Sub Bborar_Click(sender As Object, e As EventArgs) Handles Bborar.Click
        TextBox4.Clear()
        TextBox5.Clear()
        Label7.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        End If
        TextBox5.Text = Val(TextBox4.Text) ^ (1 / 2)
        Label7.Text = "√"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not IsNumeric(TextBox4.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        End If
        TextBox5.Text = Val(TextBox4.Text) ^ (1 / 3)
        Label7.Text = "∛"
    End Sub
End Class