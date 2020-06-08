<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Math
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnregresar = New System.Windows.Forms.Button()
        Me.btnsum = New System.Windows.Forms.Button()
        Me.btnres = New System.Windows.Forms.Button()
        Me.btnmul = New System.Windows.Forms.Button()
        Me.btndiv = New System.Windows.Forms.Button()
        Me.btnbor = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.bcuad = New System.Windows.Forms.Button()
        Me.Bcubo = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Bborar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "#QuedateEnCasa"
        '
        'btnregresar
        '
        Me.btnregresar.BackColor = System.Drawing.Color.Red
        Me.btnregresar.Location = New System.Drawing.Point(704, 415)
        Me.btnregresar.Name = "btnregresar"
        Me.btnregresar.Size = New System.Drawing.Size(75, 23)
        Me.btnregresar.TabIndex = 1
        Me.btnregresar.Text = "Cerrar"
        Me.btnregresar.UseVisualStyleBackColor = False
        '
        'btnsum
        '
        Me.btnsum.Location = New System.Drawing.Point(683, 12)
        Me.btnsum.Name = "btnsum"
        Me.btnsum.Size = New System.Drawing.Size(96, 23)
        Me.btnsum.TabIndex = 2
        Me.btnsum.Text = "Sumar"
        Me.btnsum.UseVisualStyleBackColor = True
        '
        'btnres
        '
        Me.btnres.Location = New System.Drawing.Point(683, 41)
        Me.btnres.Name = "btnres"
        Me.btnres.Size = New System.Drawing.Size(96, 23)
        Me.btnres.TabIndex = 3
        Me.btnres.Text = "Restar"
        Me.btnres.UseVisualStyleBackColor = True
        '
        'btnmul
        '
        Me.btnmul.Location = New System.Drawing.Point(683, 70)
        Me.btnmul.Name = "btnmul"
        Me.btnmul.Size = New System.Drawing.Size(96, 23)
        Me.btnmul.TabIndex = 4
        Me.btnmul.Text = "Multiplicar"
        Me.btnmul.UseVisualStyleBackColor = True
        '
        'btndiv
        '
        Me.btndiv.Location = New System.Drawing.Point(683, 99)
        Me.btndiv.Name = "btndiv"
        Me.btndiv.Size = New System.Drawing.Size(96, 23)
        Me.btndiv.TabIndex = 5
        Me.btndiv.Text = "Dividir"
        Me.btndiv.UseVisualStyleBackColor = True
        '
        'btnbor
        '
        Me.btnbor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbor.ForeColor = System.Drawing.Color.Black
        Me.btnbor.Location = New System.Drawing.Point(683, 128)
        Me.btnbor.Name = "btnbor"
        Me.btnbor.Size = New System.Drawing.Size(96, 23)
        Me.btnbor.TabIndex = 6
        Me.btnbor.Text = "Borrar"
        Me.btnbor.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(490, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Valor 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Valor 2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(283, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(458, 55)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 14
        '
        'bcuad
        '
        Me.bcuad.Location = New System.Drawing.Point(683, 181)
        Me.bcuad.Name = "bcuad"
        Me.bcuad.Size = New System.Drawing.Size(96, 22)
        Me.bcuad.TabIndex = 15
        Me.bcuad.Text = "Cuadrado"
        Me.bcuad.UseVisualStyleBackColor = True
        '
        'Bcubo
        '
        Me.Bcubo.Location = New System.Drawing.Point(683, 209)
        Me.Bcubo.Name = "Bcubo"
        Me.Bcubo.Size = New System.Drawing.Size(96, 22)
        Me.Bcubo.TabIndex = 16
        Me.Bcubo.Text = "Cubo"
        Me.Bcubo.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(114, 187)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(311, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 24)
        Me.Label7.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(408, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "="
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(458, 187)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(155, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Valor"
        '
        'Bborar
        '
        Me.Bborar.Location = New System.Drawing.Point(683, 296)
        Me.Bborar.Name = "Bborar"
        Me.Bborar.Size = New System.Drawing.Size(96, 23)
        Me.Bborar.TabIndex = 22
        Me.Bborar.Text = "Borrar"
        Me.Bborar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(493, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(683, 238)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = " Raiz ^2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(683, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Raiz ^3"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Math
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 448)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Bborar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Bcubo)
        Me.Controls.Add(Me.bcuad)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnbor)
        Me.Controls.Add(Me.btndiv)
        Me.Controls.Add(Me.btnmul)
        Me.Controls.Add(Me.btnres)
        Me.Controls.Add(Me.btnsum)
        Me.Controls.Add(Me.btnregresar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Math"
        Me.Text = "Math"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnregresar As Button
    Friend WithEvents btnsum As Button
    Friend WithEvents btnres As Button
    Friend WithEvents btnmul As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btnbor As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents bcuad As Button
    Friend WithEvents Bcubo As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Bborar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
