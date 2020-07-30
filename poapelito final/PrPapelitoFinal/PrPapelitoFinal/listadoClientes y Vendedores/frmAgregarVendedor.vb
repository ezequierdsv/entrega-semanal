
Imports System.Data
Imports System.Data.SqlClient
Public Class frmAgregarVendedor
    Private dv As New DataView


    Private Sub VendedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VendedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaDataSet)

    End Sub



    Private Sub frmAgregarVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaDataSet.Vendedor' Puede moverla o quitarla según sea necesario.
        Me.VendedorTableAdapter.Fill(Me.GFacHojillaDataSet.Vendedor)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If txtCedula.Text = "" Or txtNombre.Text = "" Or txtApellidos.Text = "" Or
txtDireccion.Text = "" Or txtTelefono.Text = "" Then
            'Mensaje de Error
            MessageBox.Show("Los datos del Alumno no están completos. Revise", "FALTAN
DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                'Declaración de Variables. Cadena de conexión a la Base de Datos
                Dim conex As New SqlConnection(("Data Source=DESKTOP-5G7MSS4\SQLEXPRESS;Initial Catalog=GFacHojilla;Integrated Security=SSPI;"))
                Dim cmd As New SqlCommand("AgregarVendedor", conex) 'Nombre del Procedimiento
                'Llamando al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure
                'Pasamos los Parámetros necesarios al Procedimiento
                cmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = txtCedula.Text
                cmd.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = txtNombre.Text
                cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = txtApellidos.Text
                cmd.Parameters.Add("@IdVendedor", SqlDbType.VarChar).Value = Val(txtIdVendedor.Text)
                cmd.Parameters.Add("@Teléfono", SqlDbType.VarChar).Value = Val(txtTelefono.Text)
                cmd.Parameters.Add("@Dirección", SqlDbType.VarChar).Value = Val(txtDireccion.Text)
                'Limpiamos las Cajas de Textos después de Insertar
                txtCedula.Clear() : txtNombre.Clear() : txtApellidos.Clear() : txtDireccion.Clear() : txtIdVendedor.Clear() : txtTelefono.Clear()
                'Abrimos la Conexión
                conex.Open()
                'Ejecutamos la Consulta
                cmd.ExecuteNonQuery()

                'Cerramos la Conexión
                conex.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Mensaje en caso de Error
            End Try
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCedula.Clear()
        txtNombre.Clear()
        txtApellidos.Clear()
        txtDireccion.Clear()
        txtIdVendedor.Clear()
        txtTelefono.Clear()
    End Sub
    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
        'Verificamos que siempre se teclee NUMEROS
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Solo CTRL
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Por favor, solo Teclee Números")
        End If
    End Sub

    Private Sub txtIdVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdVendedor.KeyPress
        'Verificamos que siempre se teclee NUMEROS
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Solo CTRL
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Por favor, solo Teclee Números")
        End If
    End Sub
    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        'Verificamos que siempre se teclee NUMEROS
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Solo CTRL
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Por favor, solo Teclee Números")
        End If
    End Sub
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        'Verificamos que siempre se teclee LETRAS
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Solo CTRL
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then 'Solo Espacio en Blanco

            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then 'Solo el Punto
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Por favor, solo escriba Letras, Punto y Espacio")
        End If
    End Sub

    Private Sub txtApellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidos.KeyPress
        'Verificamos que siempre se teclee LETRAS
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then 'Solo CTRL
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then 'Solo Espacio en Blanco



            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then 'Solo el Punto
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Por favor, solo escriba Letras, Punto y Espacio")
        End If
    End Sub
End Class