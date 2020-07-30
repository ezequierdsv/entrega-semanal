
Imports System.Data
Imports System.Data.SqlClient
Public Class frmProductos
    Private dv As New DataView
    Private Sub MercaderíaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MercaderíaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MercaderíaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaDataSet1)

    End Sub

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaDataSet1.Mercadería' Puede moverla o quitarla según sea necesario.
        Me.MercaderíaTableAdapter.Fill(Me.GFacHojillaDataSet1.Mercadería)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If txtIdHojilla.Text = "" Or txtNombProduct.Text = "" Or txtPrecioCaja.Text = "" Or
txtPrecioPaquet.Text = "" Or txtPrecioVent.Text = "" Or txtCantCajasStock.Text = "" Or txtGananciaXcaja.Text = "" Then
            'Mensaje de Error
            MessageBox.Show("Los datos del Alumno no están completos. Revise", "FALTAN
DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                'Declaración de Variables. Cadena de conexión a la Base de Datos
                Dim conex As New SqlConnection(("Data Source=DESKTOP-5G7MSS4\SQLEXPRESS;Initial Catalog=GFacHojilla;Integrated Security=SSPI;"))
                Dim cmd As New SqlCommand("Agregar Productos", conex) 'Nombre del Procedimiento

                'Llamando al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure
                'Pasamos los Parámetros necesarios al Procedimiento

                cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = txtNombProduct.Text
                cmd.Parameters.Add("@IdHojilla", SqlDbType.VarChar).Value = Val(txtIdHojilla.Text)
                cmd.Parameters.Add("@PrecioxPaquete", SqlDbType.VarChar).Value = Val(txtPrecioPaquet.Text)
                cmd.Parameters.Add("@PrecioVenta", SqlDbType.VarChar).Value = Val(txtPrecioVent.Text)
                cmd.Parameters.Add("@CantidadxCaja", SqlDbType.VarChar).Value = Val(txtCantCajasStock.Text)
                cmd.Parameters.Add("@PrecioxCaja", SqlDbType.VarChar).Value = Val(txtPrecioCaja.Text)
                cmd.Parameters.Add("@GananciaxCaja", SqlDbType.VarChar).Value = Val(txtGananciaXcaja.Text)
                'Limpiamos las Cajas de Textos después de Insertar
                txtCantCajasStock.Clear() : txtGananciaXcaja.Clear() : txtIdHojilla.Clear() : txtNombProduct.Clear() : txtPrecioCaja.Clear() : txtPrecioPaquet.Clear() : txtPrecioVent.Clear()
                'Abrimos la Conexión
                conex.Open()
                'Ejecutamos la Consulta
                cmd.ExecuteNonQuery()
                MessageBox.Show("Agregado Correctamente", "FALTAN
DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Cerramos la Conexión
                conex.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Mensaje en caso de Error
            End Try
        End If
    End Sub
End Class