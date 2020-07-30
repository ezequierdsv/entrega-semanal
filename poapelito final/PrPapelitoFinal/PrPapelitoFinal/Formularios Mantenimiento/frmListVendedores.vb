Imports System.Data
Imports System.Data.SqlClient
Public Class frmListVendedores
    Private dv As New DataView




    Private Sub VendedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VendedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaDataSet)


    End Sub

    Private Sub frmListVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaDataSet.Vendedor' Puede moverla o quitarla según sea necesario.
        Me.VendedorTableAdapter.Fill(Me.GFacHojillaDataSet.Vendedor)

    End Sub
    Private Sub AgregarVendedor()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmAgregarVendedor As frmAgregarVendedor = New frmAgregarVendedor()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmAgregarVendedor.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarVendedor()

    End Sub
    Private Sub btnMuestrAlt_Click(sender As Object, e As EventArgs) Handles btnMuestrAlt.Click
        Try
            'Declarando variables (Cadena de Conexión, Adaptador de Datos y DataSet)
            Dim conex As New SqlConnection("Data Source=DESKTOP-5G7MSS4\SQLEXPRESS;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
            'Consulta a la Tabla de la B.D.
            Dim da As New SqlDataAdapter("Select * From Vendedor", conex)
            Dim ds As New DataSet
            'Cargamos la Tabla de Datos dentro del DataGridView
            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtApellidos_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim Respuesta As Integer
        'Pedir Confirmación al usuario para Borrar definitivo
        Respuesta = MessageBox.Show("¿Está seguro(a) que desea Eliminar este Alumno?",
 "Registro de Alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'Si responde SI, lo borramos
        If (Respuesta = DialogResult.Yes) Then

            'Verificar que las cajas de texto NO ESTEN VACIAS
            If txtIdVendedor.Text = "" Then
                'Mensaje de Error
                MessageBox.Show("Debe escribir el Número de Cédula del Alumno. Revise", "FALTAN

DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Try
                    'Declaración de Variables. Cadena de conexión a la Base de Datos
                    Dim conex As New SqlConnection("Data Source=DESKTOP-5G7MSS4\SQLEXPRESS;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")

                    Dim cmd As New SqlCommand("BorrarVendedor", conex)
                    'Llamado al Procedimiento Almacenado
                    cmd.CommandType = CommandType.StoredProcedure
                    'Pasamos el Parámetro necesario al Procedimiento

                    cmd.Parameters.Add("@Original_IdVendedor", SqlDbType.VarChar).Value = Val(txtIdVendedor.Text)

                    'Abrimos la Conexión
                    conex.Open()
                    'Ejecutamos la Consulta
                    cmd.ExecuteNonQuery()
                    Me.VendedorTableAdapter.Fill(Me.GFacHojillaDataSet.Vendedor)
                    'Cerramos la Conexión
                    conex.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message) 'Mensaje en caso de Error

                End Try
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            'Declaración de Variables. Cadena de conexión a la Base de Datos
            Dim conex As New SqlConnection(("Data Source=DESKTOP-5G7MSS4\SQLEXPRESS;Initial Catalog=GFacHojilla;Integrated Security=SSPI;"))
            Dim cmd As New SqlCommand("ModificarVendedores", conex) 'Nombre del Procedimiento
            'Llamando al Procedimiento Almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Pasamos los Parámetros necesarios al Procedimiento

            cmd.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = txtNombres.Text
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = txtApellidos.Text
            cmd.Parameters.Add("@IdVendedor", SqlDbType.VarChar).Value = Val(txtIdVendedor.Text)
            cmd.Parameters.Add("@Teléfono", SqlDbType.VarChar).Value = Val(txtTelefono.Text)
            cmd.Parameters.Add("@Dirección", SqlDbType.VarChar).Value = txtDireccion.Text
            cmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = txtCedula.Text
            'Abrimos la Conexión
            conex.Open()
            'Ejecutamos la Consulta
            cmd.ExecuteNonQuery()
            'Cerramos la Conexión
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Mensaje en caso de Error
        End Try
    End Sub
End Class
