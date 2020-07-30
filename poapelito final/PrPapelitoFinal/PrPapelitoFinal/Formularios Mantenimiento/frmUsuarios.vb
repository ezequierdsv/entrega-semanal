Public Class frmUsuarios
    Private Sub Usuarios2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()

        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaDataSet)

    End Sub

    Private Sub Usuarios2BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Usuarios2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Usuarios2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaDataSet)

    End Sub

    Private Sub frmUsuarios_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaDataSet.Usuarios2' Puede moverla o quitarla según sea necesario.
        Me.Usuarios2TableAdapter.Fill(Me.GFacHojillaDataSet.Usuarios2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class