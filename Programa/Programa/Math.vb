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
End Class