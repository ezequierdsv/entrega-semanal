Public Class frmListProduct
    Private Sub MercaderíaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MercaderíaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MercaderíaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaDataSet)

    End Sub

    Private Sub frmListProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaDataSet.Mercadería' Puede moverla o quitarla según sea necesario.
        Me.MercaderíaTableAdapter.Fill(Me.GFacHojillaDataSet.Mercadería)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class