<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conversiones
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
        Me.Bcerr = New System.Windows.Forms.Button()
        Me.Breg = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bcerr
        '
        Me.Bcerr.Location = New System.Drawing.Point(907, 586)
        Me.Bcerr.Name = "Bcerr"
        Me.Bcerr.Size = New System.Drawing.Size(75, 23)
        Me.Bcerr.TabIndex = 0
        Me.Bcerr.Text = "Cerrar"
        Me.Bcerr.UseVisualStyleBackColor = True
        '
        'Breg
        '
        Me.Breg.Location = New System.Drawing.Point(826, 586)
        Me.Breg.Name = "Breg"
        Me.Breg.Size = New System.Drawing.Size(75, 23)
        Me.Breg.TabIndex = 1
        Me.Breg.Text = "Regresar"
        Me.Breg.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Programa.My.Resources.Resources.icon
        Me.PictureBox1.Location = New System.Drawing.Point(-8, 554)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Conversiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(994, 621)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Breg)
        Me.Controls.Add(Me.Bcerr)
        Me.Name = "Conversiones"
        Me.Text = "Conversiones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bcerr As Button
    Friend WithEvents Breg As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
