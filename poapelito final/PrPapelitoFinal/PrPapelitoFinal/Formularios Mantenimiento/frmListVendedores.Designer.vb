<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListVendedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdVendedorLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim DirecciónLabel As System.Windows.Forms.Label
        Dim TeléfonoLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdVendedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GFacHojillaDataSet = New PrPapelitoFinal.GFacHojillaDataSet()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnMuestrAlt = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtIdVendedor = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.VendedorTableAdapter = New PrPapelitoFinal.GFacHojillaDataSetTableAdapters.VendedorTableAdapter()
        Me.TableAdapterManager = New PrPapelitoFinal.GFacHojillaDataSetTableAdapters.TableAdapterManager()
        IdVendedorLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        DirecciónLabel = New System.Windows.Forms.Label()
        TeléfonoLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFacHojillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdVendedorLabel
        '
        IdVendedorLabel.AutoSize = True
        IdVendedorLabel.Location = New System.Drawing.Point(12, 203)
        IdVendedorLabel.Name = "IdVendedorLabel"
        IdVendedorLabel.Size = New System.Drawing.Size(113, 13)
        IdVendedorLabel.TabIndex = 18
        IdVendedorLabel.Text = "Numero De Vendedor:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Location = New System.Drawing.Point(21, 168)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(43, 13)
        CedulaLabel.TabIndex = 20
        CedulaLabel.Text = "Cedula:"
        '
        'DirecciónLabel
        '
        DirecciónLabel.AutoSize = True
        DirecciónLabel.Location = New System.Drawing.Point(12, 131)
        DirecciónLabel.Name = "DirecciónLabel"
        DirecciónLabel.Size = New System.Drawing.Size(55, 13)
        DirecciónLabel.TabIndex = 28
        DirecciónLabel.Text = "Dirección:"
        '
        'TeléfonoLabel
        '
        TeléfonoLabel.AutoSize = True
        TeléfonoLabel.Location = New System.Drawing.Point(12, 96)
        TeléfonoLabel.Name = "TeléfonoLabel"
        TeléfonoLabel.Size = New System.Drawing.Size(52, 13)
        TeléfonoLabel.TabIndex = 26
        TeléfonoLabel.Text = "Teléfono:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(12, 59)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(52, 13)
        ApellidosLabel.TabIndex = 24
        ApellidosLabel.Text = "Apellidos:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(12, 23)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(52, 13)
        NombresLabel.TabIndex = 22
        NombresLabel.Text = "Nombres:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdVendedorDataGridViewTextBoxColumn, Me.CedulaDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.DirecciónDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VendedorBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(185, 20)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(553, 200)
        Me.DataGridView1.TabIndex = 2
        '
        'IdVendedorDataGridViewTextBoxColumn
        '
        Me.IdVendedorDataGridViewTextBoxColumn.DataPropertyName = "IdVendedor"
        Me.IdVendedorDataGridViewTextBoxColumn.HeaderText = "IdVendedor"
        Me.IdVendedorDataGridViewTextBoxColumn.Name = "IdVendedorDataGridViewTextBoxColumn"
        Me.IdVendedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CedulaDataGridViewTextBoxColumn
        '
        Me.CedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.HeaderText = "Cedula"
        Me.CedulaDataGridViewTextBoxColumn.Name = "CedulaDataGridViewTextBoxColumn"
        Me.CedulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TeléfonoDataGridViewTextBoxColumn
        '
        Me.TeléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.Name = "TeléfonoDataGridViewTextBoxColumn"
        Me.TeléfonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DirecciónDataGridViewTextBoxColumn
        '
        Me.DirecciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.Name = "DirecciónDataGridViewTextBoxColumn"
        Me.DirecciónDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendedorBindingSource
        '
        Me.VendedorBindingSource.DataMember = "Vendedor"
        Me.VendedorBindingSource.DataSource = Me.GFacHojillaDataSet
        '
        'GFacHojillaDataSet
        '
        Me.GFacHojillaDataSet.DataSetName = "GFacHojillaDataSet"
        Me.GFacHojillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(328, 226)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(98, 40)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agragar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(432, 226)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(98, 40)
        Me.btnEditar.TabIndex = 14
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnMuestrAlt
        '
        Me.btnMuestrAlt.Location = New System.Drawing.Point(185, 226)
        Me.btnMuestrAlt.Name = "btnMuestrAlt"
        Me.btnMuestrAlt.Size = New System.Drawing.Size(137, 40)
        Me.btnMuestrAlt.TabIndex = 15
        Me.btnMuestrAlt.Text = "Mostrar/Actualizar"
        Me.btnMuestrAlt.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(536, 226)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(98, 40)
        Me.btnBorrar.TabIndex = 16
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(640, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 40)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "IdVendedor", True))
        Me.txtIdVendedor.Location = New System.Drawing.Point(131, 200)
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.Size = New System.Drawing.Size(35, 20)
        Me.txtIdVendedor.TabIndex = 19
        '
        'txtCedula
        '
        Me.txtCedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Cedula", True))
        Me.txtCedula.Location = New System.Drawing.Point(70, 165)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(96, 20)
        Me.txtCedula.TabIndex = 21
        '
        'txtTelefono
        '
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Teléfono", True))
        Me.txtTelefono.Location = New System.Drawing.Point(70, 93)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(96, 20)
        Me.txtTelefono.TabIndex = 27
        '
        'txtDireccion
        '
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Dirección", True))
        Me.txtDireccion.Location = New System.Drawing.Point(70, 128)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(96, 20)
        Me.txtDireccion.TabIndex = 29
        '
        'txtNombres
        '
        Me.txtNombres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Nombres", True))
        Me.txtNombres.Location = New System.Drawing.Point(70, 20)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(96, 20)
        Me.txtNombres.TabIndex = 23
        '
        'txtApellidos
        '
        Me.txtApellidos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Apellidos", True))
        Me.txtApellidos.Location = New System.Drawing.Point(70, 56)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(96, 20)
        Me.txtApellidos.TabIndex = 25
        '
        'VendedorTableAdapter
        '
        Me.VendedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EntregasTableAdapter = Nothing
        Me.TableAdapterManager.MercaderíaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrPapelitoFinal.GFacHojillaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Usuarios1TableAdapter = Nothing
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Me.VendedorTableAdapter
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'frmListVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 282)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(IdVendedorLabel)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtIdVendedor)
        Me.Controls.Add(TeléfonoLabel)
        Me.Controls.Add(CedulaLabel)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DirecciónLabel)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnMuestrAlt)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmListVendedores"
        Me.Text = "frmListVendedores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFacHojillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GFacHojillaDataSet As GFacHojillaDataSet
    Friend WithEvents VendedorBindingSource As BindingSource
    Friend WithEvents VendedorTableAdapter As GFacHojillaDataSetTableAdapters.VendedorTableAdapter
    Friend WithEvents TableAdapterManager As GFacHojillaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnMuestrAlt As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents IdVendedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents txtIdVendedor As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
End Class
