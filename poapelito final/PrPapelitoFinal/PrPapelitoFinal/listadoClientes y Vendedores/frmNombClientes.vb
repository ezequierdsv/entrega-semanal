Public Class frmNombClientes
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaDataSet)

    End Sub

    Private Sub frmNombClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.GFacHojillaDataSet.Clientes)

    End Sub

    Private Sub ClientesDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class