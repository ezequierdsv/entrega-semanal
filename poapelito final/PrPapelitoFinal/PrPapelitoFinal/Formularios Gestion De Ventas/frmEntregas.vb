Imports System.Data
Imports System.Data.SqlClient

Public Class btnAgregar
    Private dv As New DataView
    Dim FilaSelecionada As DataGridViewRow


    Public Sub New()

        InitializeComponent()

    End Sub

    Public Sub New(FilaSelecionada As DataGridViewRow)
        Me.New()

        Me.FilaSelecionada = FilaSelecionada

    End Sub



    Private Sub EntregasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EntregasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaDataSet)

    End Sub

    Private Sub frmEntregas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaDataSet.Entregas' Puede moverla o quitarla según sea necesario.
        Me.EntregasTableAdapter.Fill(Me.GFacHojillaDataSet.Entregas)

    End Sub

    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        Dim frmNombClientes As frmNombClientes = New frmNombClientes()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmNombClientes.Show()

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        'Declarando variables (Cadena de Conexión, Adaptador de Datos y DataSet)
        Dim conex As New SqlConnection("Data Source=DESKTOP-5G7MSS4\SQLEXPRESS;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
        Dim da As New SqlDataAdapter("Select * From Entregas", conex)   'Consulta a la Tabla de la B.D.
        Dim ds As New DataSet

        'Cargamos la Tabla de Datos dentro del DataGridView
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        DataGridView1.DataSource = dv
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtIdEntrega.Text = "" Or txtCantCajas.Text = "" Or txtIdHojillas.Text = "" Or
txtImportToal.Text = "" Or txtIdVende.Text = "" Then
            'Mensaje de Error
            MessageBox.Show("Los datos del Alumno no están completos. Revise", "FALTAN
DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                'Declaración de Variables. Cadena de conexión a la Base de Datos
                Dim conex As New SqlConnection(("Data Source=DESKTOP-5G7MSS4\SQLEXPRESS;Initial Catalog=GFacHojilla;Integrated Security=SSPI;"))
                Dim cmd As New SqlCommand("AgregaEntrega", conex) 'Nombre del Procedimiento

                'Llamando al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure
                'Pasamos los Parámetros necesarios al Procedimiento
                cmd.Parameters.Add("@IdEntrega", SqlDbType.VarChar).Value = Val(txtIdEntrega.Text)
                cmd.Parameters.Add("@IdVendedor", SqlDbType.VarChar).Value = Val(txtIdVende.Text)
                cmd.Parameters.Add("@IdHojilla", SqlDbType.VarChar).Value = Val(txtIdHojillas.Text)
                cmd.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = FechaDate.Text
                cmd.Parameters.Add("@CantCajas", SqlDbType.VarChar).Value = Val(txtCantCajas.Text)
                cmd.Parameters.Add("@ImporteTotal", SqlDbType.VarChar).Value = Val(txtImportToal.Text)
                cmd.Parameters.Add("@NombreDeCliente", SqlDbType.VarChar).Value = txtNombrCliente.Text
                cmd.Parameters.Add("@NombreDeVendedor", SqlDbType.VarChar).Value = txtNombrVende.Text
                'Limpiamos las Cajas de Textos después de Insertar
                txtCantCajas.Clear() : txtIdEntrega.Clear() : txtIdVende.Clear() : txtImportToal.Clear() : txtIdHojillas.Clear()
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick, DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Identificador As Integer

        'Verifico que no se borre el Primer Usuario (ADMINISTRADOR del Sistema)
        Identificador = Val(txtIdEntrega.Text)     'Tomo el valor del ID que se quiere borrar

        If Identificador = 1 Then
            MessageBox.Show("No es posible ELIMINAR este usuario ya que es el ADMINISTRADOR del Sistema", "Usuario Protegido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                'Declaración de Variables. Cadena de conexión a la Base de Datos
                Dim conex As New SqlConnection("Data Source=DESKTOP-5G7MSS4\SQLEXPRESS;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
                Dim cmd As New SqlCommand("EliminarEntrega", conex)

                'Llamado al Procedimiento Almacenado 
                cmd.CommandType = CommandType.StoredProcedure

                'Pasamos los Parámetros necesarios al Procedimiento
                cmd.Parameters.Add("@Original_IdEntrega", SqlDbType.Int).Value = Val(txtIdEntrega.Text)

                'Oculto el Botón ELIMINAR
                btnEliminar.Visible = False

                'Garantizar que las Cajas de Textos y Controles estén vacías
                txtIdEntrega.Clear() : txtCantCajas.Clear() : txtIdHojillas.Clear()
                txtIdVende.Clear() : txtImportToal.Clear() : txtCantCajas.Text = ""

                'Abrimos la Conexión
                conex.Open()

                'Ejecutamos la Consulta
                cmd.ExecuteNonQuery()

                'Cerramos la Conexión
                conex.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmNombVende As frmNombVende = New frmNombVende()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmNombVende.Show()
    End Sub
End Class