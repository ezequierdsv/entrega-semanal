Public Class frmNombVende
    Private Sub VendedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VendedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaDataSet)

    End Sub

    Private Sub frmNombVende_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaDataSet.Vendedor' Puede moverla o quitarla según sea necesario.
        Me.VendedorTableAdapter.Fill(Me.GFacHojillaDataSet.Vendedor)

    End Sub
End Class