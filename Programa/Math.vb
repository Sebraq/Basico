Public Class Math

    Private Sub btnregresar_Click(sender As Object, e As EventArgs) Handles btnregresar.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        System.Threading.Thread.Sleep("500")
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

    Private Sub btmul_Click(sender As Object, e As EventArgs) Handles btmul.Click
        If Not IsNumeric(TextBox6.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox7.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox8.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox9.Text) Then
            MsgBox("No esta ingresando un numero")
            Return

        End If
        TextBox10.Text = Val(TextBox6.Text) * Val(TextBox8.Text)
        TextBox11.Text = Val(TextBox7.Text) * Val(TextBox9.Text)
        Label12.Text = "*"

    End Sub

    Private Sub btdi_Click(sender As Object, e As EventArgs) Handles btdi.Click
        If Not IsNumeric(TextBox6.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox7.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox8.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox9.Text) Then
            MsgBox("No esta ingresando un numero")
            Return

        End If
        TextBox10.Text = Val(TextBox6.Text) * Val(TextBox9.Text)
        TextBox11.Text = Val(TextBox7.Text) * Val(TextBox8.Text)
        Label12.Text = "/"
    End Sub

    Private Sub btsum_Click(sender As Object, e As EventArgs) Handles btsum.Click
        If Not IsNumeric(TextBox6.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox7.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox8.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox9.text) Then
            MsgBox("No esta ingresando un numero")
            Return

        End If
        If TextBox7.Text = TextBox9.Text Then
            TextBox10.Text = Val(TextBox6.Text) + Val(TextBox8.Text)
            TextBox11.Text = Val(TextBox7.Text)
            Label12.Text = "+"
        Else
            TextBox11.Text = Val(TextBox7.Text) * Val(TextBox9.Text)
            TextBox10.Text = (Val(TextBox6.Text) * Val(TextBox9.Text)) + (Val(TextBox7.Text) * Val(TextBox8.Text))
            Label12.Text = "+"
        End If

    End Sub

    Private Sub btre_Click(sender As Object, e As EventArgs) Handles btre.Click
        If Not IsNumeric(TextBox6.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox7.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox8.Text) Then
            MsgBox("No esta ingresando un numero")
            Return
        ElseIf Not IsNumeric(TextBox9.Text) Then
            MsgBox("No esta ingresando un numero")
            Return

        End If
        If TextBox7.Text = TextBox9.Text Then
            TextBox10.Text = Val(TextBox6.Text) - Val(TextBox8.Text)
            TextBox11.Text = Val(TextBox7.Text)
            Label12.Text = "-"
        Else
            TextBox11.Text = Val(TextBox7.Text) * Val(TextBox9.Text)
            TextBox10.Text = (Val(TextBox6.Text) * Val(TextBox9.Text)) - (Val(TextBox7.Text) * Val(TextBox8.Text))
            Label12.Text = "-"
        End If
    End Sub

    Private Sub btboa_Click(sender As Object, e As EventArgs) Handles btboa.Click
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        Label12.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub LineShape1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class