<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Dim IdHojillaLabel As System.Windows.Forms.Label
        Dim NombreProductoLabel As System.Windows.Forms.Label
        Dim PrecioxPaqueteLabel As System.Windows.Forms.Label
        Dim PrecioVentaLabel As System.Windows.Forms.Label
        Dim CantidadxCajaLabel As System.Windows.Forms.Label
        Dim PrecioxCajaLabel As System.Windows.Forms.Label
        Dim txtGanaxCaja As System.Windows.Forms.Label
        Me.MercaderíaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.MercaderíaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtIdHojilla = New System.Windows.Forms.TextBox()
        Me.txtNombProduct = New System.Windows.Forms.TextBox()
        Me.txtPrecioPaquet = New System.Windows.Forms.TextBox()
        Me.txtPrecioVent = New System.Windows.Forms.TextBox()
        Me.txtCantCajasStock = New System.Windows.Forms.TextBox()
        Me.txtPrecioCaja = New System.Windows.Forms.TextBox()
        Me.txtGananciaXcaja = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.MercaderíaBindingSource = New System.Windows.Forms.BindingSource(Me.components)

        IdHojillaLabel = New System.Windows.Forms.Label()
        NombreProductoLabel = New System.Windows.Forms.Label()
        PrecioxPaqueteLabel = New System.Windows.Forms.Label()
        PrecioVentaLabel = New System.Windows.Forms.Label()
        CantidadxCajaLabel = New System.Windows.Forms.Label()
        PrecioxCajaLabel = New System.Windows.Forms.Label()
        txtGanaxCaja = New System.Windows.Forms.Label()
        CType(Me.MercaderíaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MercaderíaBindingNavigator.SuspendLayout()
        CType(Me.MercaderíaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFacHojillaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MercaderíaBindingNavigator
        '
        Me.MercaderíaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MercaderíaBindingNavigator.BindingSource = Me.MercaderíaBindingSource
        Me.MercaderíaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MercaderíaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MercaderíaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MercaderíaBindingNavigatorSaveItem})
        Me.MercaderíaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MercaderíaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MercaderíaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MercaderíaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MercaderíaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MercaderíaBindingNavigator.Name = "MercaderíaBindingNavigator"
        Me.MercaderíaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MercaderíaBindingNavigator.Size = New System.Drawing.Size(413, 25)
        Me.MercaderíaBindingNavigator.TabIndex = 0
        Me.MercaderíaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'MercaderíaBindingNavigatorSaveItem
        '
        Me.MercaderíaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MercaderíaBindingNavigatorSaveItem.Image = CType(resources.GetObject("MercaderíaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MercaderíaBindingNavigatorSaveItem.Name = "MercaderíaBindingNavigatorSaveItem"
        Me.MercaderíaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MercaderíaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdHojillaLabel
        '
        IdHojillaLabel.AutoSize = True
        IdHojillaLabel.Location = New System.Drawing.Point(97, 54)
        IdHojillaLabel.Name = "IdHojillaLabel"
        IdHojillaLabel.Size = New System.Drawing.Size(50, 13)
        IdHojillaLabel.TabIndex = 1
        IdHojillaLabel.Text = "Id Hojilla:"
        '
        'txtIdHojilla
        '
        Me.txtIdHojilla.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderíaBindingSource, "IdHojilla", True))
        Me.txtIdHojilla.Location = New System.Drawing.Point(196, 51)
        Me.txtIdHojilla.Name = "txtIdHojilla"
        Me.txtIdHojilla.Size = New System.Drawing.Size(100, 20)
        Me.txtIdHojilla.TabIndex = 2
        '
        'NombreProductoLabel
        '
        NombreProductoLabel.AutoSize = True
        NombreProductoLabel.Location = New System.Drawing.Point(97, 80)
        NombreProductoLabel.Name = "NombreProductoLabel"
        NombreProductoLabel.Size = New System.Drawing.Size(93, 13)
        NombreProductoLabel.TabIndex = 3
        NombreProductoLabel.Text = "Nombre Producto:"
        '
        'txtNombProduct
        '
        Me.txtNombProduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderíaBindingSource, "NombreProducto", True))
        Me.txtNombProduct.Location = New System.Drawing.Point(196, 77)
        Me.txtNombProduct.Name = "txtNombProduct"
        Me.txtNombProduct.Size = New System.Drawing.Size(100, 20)
        Me.txtNombProduct.TabIndex = 4
        '
        'PrecioxPaqueteLabel
        '
        PrecioxPaqueteLabel.AutoSize = True
        PrecioxPaqueteLabel.Location = New System.Drawing.Point(97, 106)
        PrecioxPaqueteLabel.Name = "PrecioxPaqueteLabel"
        PrecioxPaqueteLabel.Size = New System.Drawing.Size(88, 13)
        PrecioxPaqueteLabel.TabIndex = 5
        PrecioxPaqueteLabel.Text = "Preciox Paquete:"
        '
        'txtPrecioPaquet
        '
        Me.txtPrecioPaquet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderíaBindingSource, "PrecioxPaquete", True))
        Me.txtPrecioPaquet.Location = New System.Drawing.Point(196, 103)
        Me.txtPrecioPaquet.Name = "txtPrecioPaquet"
        Me.txtPrecioPaquet.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioPaquet.TabIndex = 6
        '
        'PrecioVentaLabel
        '
        PrecioVentaLabel.AutoSize = True
        PrecioVentaLabel.Location = New System.Drawing.Point(97, 132)
        PrecioVentaLabel.Name = "PrecioVentaLabel"
        PrecioVentaLabel.Size = New System.Drawing.Size(71, 13)
        PrecioVentaLabel.TabIndex = 7
        PrecioVentaLabel.Text = "Precio Venta:"
        '
        'txtPrecioVent
        '
        Me.txtPrecioVent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderíaBindingSource, "PrecioVenta", True))
        Me.txtPrecioVent.Location = New System.Drawing.Point(196, 129)
        Me.txtPrecioVent.Name = "txtPrecioVent"
        Me.txtPrecioVent.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioVent.TabIndex = 8
        '
        'CantidadxCajaLabel
        '
        CantidadxCajaLabel.AutoSize = True
        CantidadxCajaLabel.Location = New System.Drawing.Point(97, 158)
        CantidadxCajaLabel.Name = "CantidadxCajaLabel"
        CantidadxCajaLabel.Size = New System.Drawing.Size(81, 13)
        CantidadxCajaLabel.TabIndex = 9
        CantidadxCajaLabel.Text = "Cantidadx Caja:"
        '
        'txtCantCajasStock
        '
        Me.txtCantCajasStock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderíaBindingSource, "CantidadxCaja", True))
        Me.txtCantCajasStock.Location = New System.Drawing.Point(196, 155)
        Me.txtCantCajasStock.Name = "txtCantCajasStock"
        Me.txtCantCajasStock.Size = New System.Drawing.Size(100, 20)
        Me.txtCantCajasStock.TabIndex = 10
        '
        'PrecioxCajaLabel
        '
        PrecioxCajaLabel.AutoSize = True
        PrecioxCajaLabel.Location = New System.Drawing.Point(97, 184)
        PrecioxCajaLabel.Name = "PrecioxCajaLabel"
        PrecioxCajaLabel.Size = New System.Drawing.Size(69, 13)
        PrecioxCajaLabel.TabIndex = 11
        PrecioxCajaLabel.Text = "Preciox Caja:"
        '
        'txtPrecioCaja
        '
        Me.txtPrecioCaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderíaBindingSource, "PrecioxCaja", True))
        Me.txtPrecioCaja.Location = New System.Drawing.Point(196, 181)
        Me.txtPrecioCaja.Name = "txtPrecioCaja"
        Me.txtPrecioCaja.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioCaja.TabIndex = 12
        '
        'txtGanaxCaja
        '
        txtGanaxCaja.AutoSize = True
        txtGanaxCaja.Location = New System.Drawing.Point(97, 210)
        txtGanaxCaja.Name = "txtGanaxCaja"
        txtGanaxCaja.Size = New System.Drawing.Size(85, 13)
        txtGanaxCaja.TabIndex = 13
        txtGanaxCaja.Text = "Gananciax Caja:"
        '
        'txtGananciaXcaja
        '
        Me.txtGananciaXcaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderíaBindingSource, "GananciaxCaja", True))
        Me.txtGananciaXcaja.Location = New System.Drawing.Point(196, 207)
        Me.txtGananciaXcaja.Name = "txtGananciaXcaja"
        Me.txtGananciaXcaja.Size = New System.Drawing.Size(100, 20)
        Me.txtGananciaXcaja.TabIndex = 14
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(115, 256)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(248, 256)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(302, 49)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'MercaderíaBindingSource
        '
        Me.MercaderíaBindingSource.DataMember = "Mercadería"
        Me.MercaderíaBindingSource.DataSource = Me.GFacHojillaDataSet1
        '
        'GFacHojillaDataSet1
        '
        Me.GFacHojillaDataSet1.DataSetName = "GFacHojillaDataSet1"
        Me.GFacHojillaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MercaderíaTableAdapter
        '
        Me.MercaderíaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EntregasTableAdapter = Nothing
        Me.TableAdapterManager.MercaderíaTableAdapter = Me.MercaderíaTableAdapter

        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 317)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(IdHojillaLabel)
        Me.Controls.Add(Me.txtIdHojilla)
        Me.Controls.Add(NombreProductoLabel)
        Me.Controls.Add(Me.txtNombProduct)
        Me.Controls.Add(PrecioxPaqueteLabel)
        Me.Controls.Add(Me.txtPrecioPaquet)
        Me.Controls.Add(PrecioVentaLabel)
        Me.Controls.Add(Me.txtPrecioVent)
        Me.Controls.Add(CantidadxCajaLabel)
        Me.Controls.Add(Me.txtCantCajasStock)
        Me.Controls.Add(PrecioxCajaLabel)
        Me.Controls.Add(Me.txtPrecioCaja)
        Me.Controls.Add(txtGanaxCaja)
        Me.Controls.Add(Me.txtGananciaXcaja)
        Me.Controls.Add(Me.MercaderíaBindingNavigator)
        Me.Name = "frmProductos"
        Me.Text = "frmProductos"
        CType(Me.MercaderíaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MercaderíaBindingNavigator.ResumeLayout(False)
        Me.MercaderíaBindingNavigator.PerformLayout()
        CType(Me.MercaderíaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFacHojillaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GFacHojillaDataSet1 As GFacHojillaDataSet1
    Friend WithEvents MercaderíaBindingSource As BindingSource
    Friend WithEvents MercaderíaTableAdapter As GFacHojillaDataSet1TableAdapters.MercaderíaTableAdapter
    Friend WithEvents TableAdapterManager As GFacHojillaDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents MercaderíaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MercaderíaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtIdHojilla As TextBox
    Friend WithEvents txtNombProduct As TextBox
    Friend WithEvents txtPrecioPaquet As TextBox
    Friend WithEvents txtPrecioVent As TextBox
    Friend WithEvents txtCantCajasStock As TextBox
    Friend WithEvents txtPrecioCaja As TextBox
    Friend WithEvents txtGananciaXcaja As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
End Class
