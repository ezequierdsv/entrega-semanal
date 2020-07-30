<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btnAgregar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdEntregaLabel As System.Windows.Forms.Label
        Dim IdVendedorLabel As System.Windows.Forms.Label
        Dim IdHojillaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CantCajasLabel As System.Windows.Forms.Label
        Dim ImporteTotalLabel As System.Windows.Forms.Label
        Dim NombreDeClienteLabel As System.Windows.Forms.Label
        Dim NombreDeVendedorLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtIdEntrega = New System.Windows.Forms.TextBox()
        Me.txtIdVende = New System.Windows.Forms.TextBox()
        Me.txtIdHojillas = New System.Windows.Forms.TextBox()
        Me.FechaDate = New System.Windows.Forms.DateTimePicker()
        Me.txtCantCajas = New System.Windows.Forms.TextBox()
        Me.txtImportToal = New System.Windows.Forms.TextBox()
        Me.Datos = New System.Windows.Forms.GroupBox()
        Me.lblIdVendedor = New System.Windows.Forms.Label()
        Me.btnBuscar1 = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtNombrCliente = New System.Windows.Forms.TextBox()
        Me.txtNombrVende = New System.Windows.Forms.TextBox()
        Me.EntregasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GFacHojillaDataSet = New PrPapelitoFinal.GFacHojillaDataSet()
        Me.IdEntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdHojillaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantCajasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDeClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDeVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntregasTableAdapter = New PrPapelitoFinal.GFacHojillaDataSetTableAdapters.EntregasTableAdapter()
        Me.TableAdapterManager = New PrPapelitoFinal.GFacHojillaDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        IdEntregaLabel = New System.Windows.Forms.Label()
        IdVendedorLabel = New System.Windows.Forms.Label()
        IdHojillaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CantCajasLabel = New System.Windows.Forms.Label()
        ImporteTotalLabel = New System.Windows.Forms.Label()
        NombreDeClienteLabel = New System.Windows.Forms.Label()
        NombreDeVendedorLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Datos.SuspendLayout()
        CType(Me.EntregasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFacHojillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdEntregaLabel
        '
        IdEntregaLabel.AutoSize = True
        IdEntregaLabel.Location = New System.Drawing.Point(65, 10)
        IdEntregaLabel.Name = "IdEntregaLabel"
        IdEntregaLabel.Size = New System.Drawing.Size(59, 13)
        IdEntregaLabel.TabIndex = 1
        IdEntregaLabel.Text = "Id Entrega:"
        '
        'IdVendedorLabel
        '
        IdVendedorLabel.AutoSize = True
        IdVendedorLabel.Location = New System.Drawing.Point(70, 88)
        IdVendedorLabel.Name = "IdVendedorLabel"
        IdVendedorLabel.Size = New System.Drawing.Size(68, 13)
        IdVendedorLabel.TabIndex = 3
        IdVendedorLabel.Text = "Id Vendedor:"
        '
        'IdHojillaLabel
        '
        IdHojillaLabel.AutoSize = True
        IdHojillaLabel.Location = New System.Drawing.Point(291, 14)
        IdHojillaLabel.Name = "IdHojillaLabel"
        IdHojillaLabel.Size = New System.Drawing.Size(50, 13)
        IdHojillaLabel.TabIndex = 5
        IdHojillaLabel.Text = "Id Hojilla:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(301, 40)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 7
        FechaLabel.Text = "Fecha:"
        '
        'CantCajasLabel
        '
        CantCajasLabel.AutoSize = True
        CantCajasLabel.Location = New System.Drawing.Point(280, 65)
        CantCajasLabel.Name = "CantCajasLabel"
        CantCajasLabel.Size = New System.Drawing.Size(61, 13)
        CantCajasLabel.TabIndex = 9
        CantCajasLabel.Text = "Cant Cajas:"
        '
        'ImporteTotalLabel
        '
        ImporteTotalLabel.AutoSize = True
        ImporteTotalLabel.Location = New System.Drawing.Point(280, 91)
        ImporteTotalLabel.Name = "ImporteTotalLabel"
        ImporteTotalLabel.Size = New System.Drawing.Size(72, 13)
        ImporteTotalLabel.TabIndex = 11
        ImporteTotalLabel.Text = "Importe Total:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEntregaDataGridViewTextBoxColumn, Me.IdVendedorDataGridViewTextBoxColumn, Me.IdHojillaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.CantCajasDataGridViewTextBoxColumn, Me.ImporteTotalDataGridViewTextBoxColumn, Me.NombreDeClienteDataGridViewTextBoxColumn, Me.NombreDeVendedorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EntregasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(138, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(841, 275)
        Me.DataGridView1.TabIndex = 1
        '
        'txtIdEntrega
        '
        Me.txtIdEntrega.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntregasBindingSource, "IdEntrega", True))
        Me.txtIdEntrega.Location = New System.Drawing.Point(144, 8)
        Me.txtIdEntrega.Name = "txtIdEntrega"
        Me.txtIdEntrega.Size = New System.Drawing.Size(28, 20)
        Me.txtIdEntrega.TabIndex = 2
        '
        'txtIdVende
        '
        Me.txtIdVende.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntregasBindingSource, "IdVendedor", True))
        Me.txtIdVende.Location = New System.Drawing.Point(144, 85)
        Me.txtIdVende.Name = "txtIdVende"
        Me.txtIdVende.Size = New System.Drawing.Size(28, 20)
        Me.txtIdVende.TabIndex = 4
        '
        'txtIdHojillas
        '
        Me.txtIdHojillas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntregasBindingSource, "IdHojilla", True))
        Me.txtIdHojillas.Location = New System.Drawing.Point(358, 11)
        Me.txtIdHojillas.Name = "txtIdHojillas"
        Me.txtIdHojillas.Size = New System.Drawing.Size(28, 20)
        Me.txtIdHojillas.TabIndex = 6
        '
        'FechaDate
        '
        Me.FechaDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EntregasBindingSource, "Fecha", True))
        Me.FechaDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDate.Location = New System.Drawing.Point(358, 36)
        Me.FechaDate.Name = "FechaDate"
        Me.FechaDate.Size = New System.Drawing.Size(99, 20)
        Me.FechaDate.TabIndex = 8
        '
        'txtCantCajas
        '
        Me.txtCantCajas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntregasBindingSource, "CantCajas", True))
        Me.txtCantCajas.Location = New System.Drawing.Point(358, 62)
        Me.txtCantCajas.Name = "txtCantCajas"
        Me.txtCantCajas.Size = New System.Drawing.Size(99, 20)
        Me.txtCantCajas.TabIndex = 10
        '
        'txtImportToal
        '
        Me.txtImportToal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntregasBindingSource, "ImporteTotal", True))
        Me.txtImportToal.Location = New System.Drawing.Point(358, 88)
        Me.txtImportToal.Name = "txtImportToal"
        Me.txtImportToal.Size = New System.Drawing.Size(99, 20)
        Me.txtImportToal.TabIndex = 12
        '
        'Datos
        '
        Me.Datos.Controls.Add(Me.Button1)
        Me.Datos.Controls.Add(NombreDeVendedorLabel)
        Me.Datos.Controls.Add(Me.btnBuscar1)
        Me.Datos.Controls.Add(IdEntregaLabel)
        Me.Datos.Controls.Add(Me.txtNombrVende)
        Me.Datos.Controls.Add(FechaLabel)
        Me.Datos.Controls.Add(Me.txtIdHojillas)
        Me.Datos.Controls.Add(Me.FechaDate)
        Me.Datos.Controls.Add(NombreDeClienteLabel)
        Me.Datos.Controls.Add(IdHojillaLabel)
        Me.Datos.Controls.Add(IdVendedorLabel)
        Me.Datos.Controls.Add(CantCajasLabel)
        Me.Datos.Controls.Add(Me.txtIdEntrega)
        Me.Datos.Controls.Add(Me.txtNombrCliente)
        Me.Datos.Controls.Add(Me.txtIdVende)
        Me.Datos.Controls.Add(Me.txtCantCajas)
        Me.Datos.Controls.Add(ImporteTotalLabel)
        Me.Datos.Controls.Add(Me.txtImportToal)
        Me.Datos.Location = New System.Drawing.Point(138, 12)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(496, 139)
        Me.Datos.TabIndex = 13
        Me.Datos.TabStop = False
        Me.Datos.Text = "Datos:"
        '
        'lblIdVendedor
        '
        Me.lblIdVendedor.AutoSize = True
        Me.lblIdVendedor.Location = New System.Drawing.Point(680, 23)
        Me.lblIdVendedor.Name = "lblIdVendedor"
        Me.lblIdVendedor.Size = New System.Drawing.Size(13, 13)
        Me.lblIdVendedor.TabIndex = 16
        Me.lblIdVendedor.Text = "0"
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(250, 30)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(24, 23)
        Me.btnBuscar1.TabIndex = 14
        Me.btnBuscar1.Text = "...."
        Me.btnBuscar1.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(27, 166)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 42)
        Me.btnMostrar.TabIndex = 15
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 42)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(27, 284)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 42)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(27, 399)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 42)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NombreDeClienteLabel
        '
        NombreDeClienteLabel.AutoSize = True
        NombreDeClienteLabel.Location = New System.Drawing.Point(25, 36)
        NombreDeClienteLabel.Name = "NombreDeClienteLabel"
        NombreDeClienteLabel.Size = New System.Drawing.Size(99, 13)
        NombreDeClienteLabel.TabIndex = 18
        NombreDeClienteLabel.Text = "Nombre De Cliente:"
        '
        'txtNombrCliente
        '
        Me.txtNombrCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntregasBindingSource, "NombreDeCliente", True))
        Me.txtNombrCliente.Location = New System.Drawing.Point(144, 32)
        Me.txtNombrCliente.Name = "txtNombrCliente"
        Me.txtNombrCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtNombrCliente.TabIndex = 19
        '
        'NombreDeVendedorLabel
        '
        NombreDeVendedorLabel.AutoSize = True
        NombreDeVendedorLabel.Location = New System.Drawing.Point(25, 62)
        NombreDeVendedorLabel.Name = "NombreDeVendedorLabel"
        NombreDeVendedorLabel.Size = New System.Drawing.Size(113, 13)
        NombreDeVendedorLabel.TabIndex = 19
        NombreDeVendedorLabel.Text = "Nombre De Vendedor:"
        '
        'txtNombrVende
        '
        Me.txtNombrVende.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntregasBindingSource, "NombreDeVendedor", True))
        Me.txtNombrVende.Location = New System.Drawing.Point(144, 59)
        Me.txtNombrVende.Name = "txtNombrVende"
        Me.txtNombrVende.Size = New System.Drawing.Size(100, 20)
        Me.txtNombrVende.TabIndex = 20
        '
        'EntregasBindingSource
        '
        Me.EntregasBindingSource.DataMember = "Entregas"
        Me.EntregasBindingSource.DataSource = Me.GFacHojillaDataSet
        '
        'GFacHojillaDataSet
        '
        Me.GFacHojillaDataSet.DataSetName = "GFacHojillaDataSet"
        Me.GFacHojillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdEntregaDataGridViewTextBoxColumn
        '
        Me.IdEntregaDataGridViewTextBoxColumn.DataPropertyName = "IdEntrega"
        Me.IdEntregaDataGridViewTextBoxColumn.HeaderText = "IdEntrega"
        Me.IdEntregaDataGridViewTextBoxColumn.Name = "IdEntregaDataGridViewTextBoxColumn"
        Me.IdEntregaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdVendedorDataGridViewTextBoxColumn
        '
        Me.IdVendedorDataGridViewTextBoxColumn.DataPropertyName = "IdVendedor"
        Me.IdVendedorDataGridViewTextBoxColumn.HeaderText = "IdVendedor"
        Me.IdVendedorDataGridViewTextBoxColumn.Name = "IdVendedorDataGridViewTextBoxColumn"
        Me.IdVendedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdHojillaDataGridViewTextBoxColumn
        '
        Me.IdHojillaDataGridViewTextBoxColumn.DataPropertyName = "IdHojilla"
        Me.IdHojillaDataGridViewTextBoxColumn.HeaderText = "IdHojilla"
        Me.IdHojillaDataGridViewTextBoxColumn.Name = "IdHojillaDataGridViewTextBoxColumn"
        Me.IdHojillaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantCajasDataGridViewTextBoxColumn
        '
        Me.CantCajasDataGridViewTextBoxColumn.DataPropertyName = "CantCajas"
        Me.CantCajasDataGridViewTextBoxColumn.HeaderText = "CantCajas"
        Me.CantCajasDataGridViewTextBoxColumn.Name = "CantCajasDataGridViewTextBoxColumn"
        Me.CantCajasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteTotalDataGridViewTextBoxColumn
        '
        Me.ImporteTotalDataGridViewTextBoxColumn.DataPropertyName = "ImporteTotal"
        Me.ImporteTotalDataGridViewTextBoxColumn.HeaderText = "ImporteTotal"
        Me.ImporteTotalDataGridViewTextBoxColumn.Name = "ImporteTotalDataGridViewTextBoxColumn"
        Me.ImporteTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDeClienteDataGridViewTextBoxColumn
        '
        Me.NombreDeClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreDeCliente"
        Me.NombreDeClienteDataGridViewTextBoxColumn.HeaderText = "NombreDeCliente"
        Me.NombreDeClienteDataGridViewTextBoxColumn.Name = "NombreDeClienteDataGridViewTextBoxColumn"
        Me.NombreDeClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDeVendedorDataGridViewTextBoxColumn
        '
        Me.NombreDeVendedorDataGridViewTextBoxColumn.DataPropertyName = "NombreDeVendedor"
        Me.NombreDeVendedorDataGridViewTextBoxColumn.HeaderText = "NombreDeVendedor"
        Me.NombreDeVendedorDataGridViewTextBoxColumn.Name = "NombreDeVendedorDataGridViewTextBoxColumn"
        Me.NombreDeVendedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EntregasTableAdapter
        '
        Me.EntregasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EntregasTableAdapter = Me.EntregasTableAdapter
        Me.TableAdapterManager.MercaderíaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrPapelitoFinal.GFacHojillaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Usuarios1TableAdapter = Nothing
        Me.TableAdapterManager.Usuarios2TableAdapter = Nothing
        Me.TableAdapterManager.Usuarios3TableAdapter = Nothing
        Me.TableAdapterManager.Usuarios4TableAdapter = Nothing
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 499)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblIdVendedor)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "btnAgregar"
        Me.Text = "frmVentas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        CType(Me.EntregasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFacHojillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GFacHojillaDataSet As GFacHojillaDataSet
    Friend WithEvents EntregasBindingSource As BindingSource
    Friend WithEvents EntregasTableAdapter As GFacHojillaDataSetTableAdapters.EntregasTableAdapter
    Friend WithEvents TableAdapterManager As GFacHojillaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtIdEntrega As TextBox
    Friend WithEvents txtIdVende As TextBox
    Friend WithEvents txtIdHojillas As TextBox
    Friend WithEvents FechaDate As DateTimePicker
    Friend WithEvents txtCantCajas As TextBox
    Friend WithEvents txtImportToal As TextBox
    Friend WithEvents Datos As GroupBox
    Friend WithEvents btnBuscar1 As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents lblIdVendedor As Label
    Friend WithEvents IdEntregaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdVendedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdHojillaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantCajasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDeClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDeVendedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtNombrVende As TextBox
    Friend WithEvents txtNombrCliente As TextBox
    Friend WithEvents Button1 As Button
End Class
