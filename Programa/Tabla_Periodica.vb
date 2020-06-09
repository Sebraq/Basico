Public Class Tabla_Periodica
    Dim num As Integer
    Dim nom As String

    Private Sub bcerrar_Click(sender As Object, e As EventArgs) Handles bcerrar.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        System.Threading.Thread.Sleep("500")
        End
    End Sub

    Private Sub Tabla_Periodica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BaseElementosDataSet.Elementos' table. You can move, or remove it, as needed.
        Me.ElementosTableAdapter.Fill(Me.BaseElementosDataSet.Elementos)

    End Sub

    Private Sub ElementosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ElementosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BaseElementosDataSet)

    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        Me.ElementosBindingSource.MoveFirst()
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        Me.ElementosBindingSource.MoveLast()
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        Me.ElementosBindingSource.MovePrevious()
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        Me.ElementosBindingSource.MoveNext()
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        num = Val(InputBox("Ingrese el Numero Atomico", "Busqueda Numero Atomico", "Ingrese el numero"))
        Me.ElementosTableAdapter.BuscarAtomico(Me.BaseElementosDataSet.Elementos, num)

    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        nom = Val(InputBox("Ingrese el nombre", "Busqueda nombre", "Ingrese el nombre"))
        Me.ElementosTableAdapter.BuscarNombre(Me.BaseElementosDataSet.Elementos, nom)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.MOUSE_CLICK, AudioPlayMode.Background)
        Form1.Show()
        Me.Hide()
    End Sub
End Class