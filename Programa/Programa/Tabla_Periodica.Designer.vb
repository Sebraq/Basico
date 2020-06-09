<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabla_Periodica
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
        Me.components = New System.ComponentModel.Container()
        Dim Numero_AtomicoLabel As System.Windows.Forms.Label
        Dim Peso_AtomicoLabel As System.Windows.Forms.Label
        Dim SimboloLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Me.bcerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Numero_AtomicoTextBox = New System.Windows.Forms.TextBox()
        Me.ElementosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseElementosDataSet = New Programa.BaseElementosDataSet()
        Me.Peso_AtomicoTextBox = New System.Windows.Forms.TextBox()
        Me.SimboloTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.b1 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b4 = New System.Windows.Forms.Button()
        Me.b5 = New System.Windows.Forms.Button()
        Me.b6 = New System.Windows.Forms.Button()
        Me.ElementosTableAdapter = New Programa.BaseElementosDataSetTableAdapters.ElementosTableAdapter()
        Me.TableAdapterManager = New Programa.BaseElementosDataSetTableAdapters.TableAdapterManager()
        Numero_AtomicoLabel = New System.Windows.Forms.Label()
        Peso_AtomicoLabel = New System.Windows.Forms.Label()
        SimboloLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CType(Me.ElementosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseElementosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Numero_AtomicoLabel
        '
        Numero_AtomicoLabel.AutoSize = True
        Numero_AtomicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Numero_AtomicoLabel.Location = New System.Drawing.Point(347, 76)
        Numero_AtomicoLabel.Name = "Numero_AtomicoLabel"
        Numero_AtomicoLabel.Size = New System.Drawing.Size(158, 24)
        Numero_AtomicoLabel.TabIndex = 3
        Numero_AtomicoLabel.Text = "Numero Atomico:"
        '
        'Peso_AtomicoLabel
        '
        Peso_AtomicoLabel.AutoSize = True
        Peso_AtomicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Peso_AtomicoLabel.Location = New System.Drawing.Point(373, 129)
        Peso_AtomicoLabel.Name = "Peso_AtomicoLabel"
        Peso_AtomicoLabel.Size = New System.Drawing.Size(132, 24)
        Peso_AtomicoLabel.TabIndex = 5
        Peso_AtomicoLabel.Text = "Peso Atomico:"
        '
        'SimboloLabel
        '
        SimboloLabel.AutoSize = True
        SimboloLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SimboloLabel.Location = New System.Drawing.Point(421, 179)
        SimboloLabel.Name = "SimboloLabel"
        SimboloLabel.Size = New System.Drawing.Size(84, 24)
        SimboloLabel.TabIndex = 7
        SimboloLabel.Text = "Simbolo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(421, 231)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(84, 24)
        NombreLabel.TabIndex = 9
        NombreLabel.Text = "Nombre:"
        '
        'bcerrar
        '
        Me.bcerrar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.bcerrar.Location = New System.Drawing.Point(993, 602)
        Me.bcerrar.Name = "bcerrar"
        Me.bcerrar.Size = New System.Drawing.Size(73, 21)
        Me.bcerrar.TabIndex = 0
        Me.bcerrar.Text = "Cerrar"
        Me.bcerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 618)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "#QuedateEnCasa"
        '
        'Numero_AtomicoTextBox
        '
        Me.Numero_AtomicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElementosBindingSource, "Numero_Atomico", True))
        Me.Numero_AtomicoTextBox.Location = New System.Drawing.Point(578, 80)
        Me.Numero_AtomicoTextBox.Name = "Numero_AtomicoTextBox"
        Me.Numero_AtomicoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Numero_AtomicoTextBox.TabIndex = 4
        '
        'ElementosBindingSource
        '
        Me.ElementosBindingSource.DataMember = "Elementos"
        Me.ElementosBindingSource.DataSource = Me.BaseElementosDataSet
        '
        'BaseElementosDataSet
        '
        Me.BaseElementosDataSet.DataSetName = "BaseElementosDataSet"
        Me.BaseElementosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Peso_AtomicoTextBox
        '
        Me.Peso_AtomicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElementosBindingSource, "Peso_Atomico", True))
        Me.Peso_AtomicoTextBox.Location = New System.Drawing.Point(578, 133)
        Me.Peso_AtomicoTextBox.Name = "Peso_AtomicoTextBox"
        Me.Peso_AtomicoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Peso_AtomicoTextBox.TabIndex = 6
        '
        'SimboloTextBox
        '
        Me.SimboloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElementosBindingSource, "Simbolo", True))
        Me.SimboloTextBox.Location = New System.Drawing.Point(578, 184)
        Me.SimboloTextBox.Name = "SimboloTextBox"
        Me.SimboloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SimboloTextBox.TabIndex = 8
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ElementosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(578, 235)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 10
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(331, 297)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(75, 23)
        Me.b1.TabIndex = 11
        Me.b1.Text = "Primero"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(438, 296)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(75, 23)
        Me.b2.TabIndex = 12
        Me.b2.Text = "Anterior"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(547, 296)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(75, 23)
        Me.b3.TabIndex = 13
        Me.b3.Text = "Siguiente"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.Location = New System.Drawing.Point(653, 296)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(75, 23)
        Me.b4.TabIndex = 14
        Me.b4.Text = "Ultimo"
        Me.b4.UseVisualStyleBackColor = True
        '
        'b5
        '
        Me.b5.Location = New System.Drawing.Point(438, 340)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(75, 41)
        Me.b5.TabIndex = 15
        Me.b5.Text = "Buscar por numero"
        Me.b5.UseVisualStyleBackColor = True
        '
        'b6
        '
        Me.b6.Location = New System.Drawing.Point(547, 340)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(75, 41)
        Me.b6.TabIndex = 16
        Me.b6.Text = "Buscar por nombre"
        Me.b6.UseVisualStyleBackColor = True
        '
        'ElementosTableAdapter
        '
        Me.ElementosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ElementosTableAdapter = Me.ElementosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Programa.BaseElementosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tabla_Periodica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1104, 651)
        Me.Controls.Add(Me.b6)
        Me.Controls.Add(Me.b5)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(SimboloLabel)
        Me.Controls.Add(Me.SimboloTextBox)
        Me.Controls.Add(Peso_AtomicoLabel)
        Me.Controls.Add(Me.Peso_AtomicoTextBox)
        Me.Controls.Add(Numero_AtomicoLabel)
        Me.Controls.Add(Me.Numero_AtomicoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bcerrar)
        Me.Name = "Tabla_Periodica"
        Me.Text = "Tabla_Periodica"
        CType(Me.ElementosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseElementosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bcerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BaseElementosDataSet As BaseElementosDataSet
    Friend WithEvents ElementosBindingSource As BindingSource
    Friend WithEvents ElementosTableAdapter As BaseElementosDataSetTableAdapters.ElementosTableAdapter
    Friend WithEvents TableAdapterManager As BaseElementosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Numero_AtomicoTextBox As TextBox
    Friend WithEvents Peso_AtomicoTextBox As TextBox
    Friend WithEvents SimboloTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents b1 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents b4 As Button
    Friend WithEvents b5 As Button
    Friend WithEvents b6 As Button
End Class
