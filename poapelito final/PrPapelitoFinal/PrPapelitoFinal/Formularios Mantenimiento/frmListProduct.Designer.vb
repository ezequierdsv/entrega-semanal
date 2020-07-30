<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListProduct))
        Me.GFacHojillaDataSet = New PrPapelitoFinal.GFacHojillaDataSet()
        Me.MercaderíaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MercaderíaTableAdapter = New PrPapelitoFinal.GFacHojillaDataSetTableAdapters.MercaderíaTableAdapter()
        Me.TableAdapterManager = New PrPapelitoFinal.GFacHojillaDataSetTableAdapters.TableAdapterManager()
        Me.MercaderíaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MercaderíaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MercaderíaDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdHojillaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioxPaqueteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadxCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioxCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GananciaxCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagenCajaDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GFacHojillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MercaderíaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MercaderíaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MercaderíaBindingNavigator.SuspendLayout()
        CType(Me.MercaderíaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GFacHojillaDataSet
        '
        Me.GFacHojillaDataSet.DataSetName = "GFacHojillaDataSet"
        Me.GFacHojillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MercaderíaBindingSource
        '
        Me.MercaderíaBindingSource.DataMember = "Mercadería"
        Me.MercaderíaBindingSource.DataSource = Me.GFacHojillaDataSet
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
        Me.TableAdapterManager.UpdateOrder = PrPapelitoFinal.GFacHojillaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
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
        Me.MercaderíaBindingNavigator.Size = New System.Drawing.Size(921, 25)
        Me.MercaderíaBindingNavigator.TabIndex = 0
        Me.MercaderíaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MercaderíaBindingNavigatorSaveItem
        '
        Me.MercaderíaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MercaderíaBindingNavigatorSaveItem.Image = CType(resources.GetObject("MercaderíaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MercaderíaBindingNavigatorSaveItem.Name = "MercaderíaBindingNavigatorSaveItem"
        Me.MercaderíaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MercaderíaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'MercaderíaDataGridView
        '
        Me.MercaderíaDataGridView.AllowUserToOrderColumns = True
        Me.MercaderíaDataGridView.AutoGenerateColumns = False
        Me.MercaderíaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MercaderíaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHojillaDataGridViewTextBoxColumn, Me.NombreProductoDataGridViewTextBoxColumn, Me.PrecioxPaqueteDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.CantidadxCajaDataGridViewTextBoxColumn, Me.PrecioxCajaDataGridViewTextBoxColumn, Me.GananciaxCajaDataGridViewTextBoxColumn, Me.ImagenCajaDataGridViewImageColumn})
        Me.MercaderíaDataGridView.DataSource = Me.MercaderíaBindingSource
        Me.MercaderíaDataGridView.Location = New System.Drawing.Point(129, 86)
        Me.MercaderíaDataGridView.Name = "MercaderíaDataGridView"
        Me.MercaderíaDataGridView.Size = New System.Drawing.Size(744, 304)
        Me.MercaderíaDataGridView.TabIndex = 1
        '
        'IdHojillaDataGridViewTextBoxColumn
        '
        Me.IdHojillaDataGridViewTextBoxColumn.DataPropertyName = "IdHojilla"
        Me.IdHojillaDataGridViewTextBoxColumn.HeaderText = "IdHojilla"
        Me.IdHojillaDataGridViewTextBoxColumn.Name = "IdHojillaDataGridViewTextBoxColumn"
        '
        'NombreProductoDataGridViewTextBoxColumn
        '
        Me.NombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.HeaderText = "NombreProducto"
        Me.NombreProductoDataGridViewTextBoxColumn.Name = "NombreProductoDataGridViewTextBoxColumn"
        '
        'PrecioxPaqueteDataGridViewTextBoxColumn
        '
        Me.PrecioxPaqueteDataGridViewTextBoxColumn.DataPropertyName = "PrecioxPaquete"
        Me.PrecioxPaqueteDataGridViewTextBoxColumn.HeaderText = "PrecioxPaquete"
        Me.PrecioxPaqueteDataGridViewTextBoxColumn.Name = "PrecioxPaqueteDataGridViewTextBoxColumn"
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        '
        'CantidadxCajaDataGridViewTextBoxColumn
        '
        Me.CantidadxCajaDataGridViewTextBoxColumn.DataPropertyName = "CantidadxCaja"
        Me.CantidadxCajaDataGridViewTextBoxColumn.HeaderText = "CantidadxCaja"
        Me.CantidadxCajaDataGridViewTextBoxColumn.Name = "CantidadxCajaDataGridViewTextBoxColumn"
        '
        'PrecioxCajaDataGridViewTextBoxColumn
        '
        Me.PrecioxCajaDataGridViewTextBoxColumn.DataPropertyName = "PrecioxCaja"
        Me.PrecioxCajaDataGridViewTextBoxColumn.HeaderText = "PrecioxCaja"
        Me.PrecioxCajaDataGridViewTextBoxColumn.Name = "PrecioxCajaDataGridViewTextBoxColumn"
        '
        'GananciaxCajaDataGridViewTextBoxColumn
        '
        Me.GananciaxCajaDataGridViewTextBoxColumn.DataPropertyName = "GananciaxCaja"
        Me.GananciaxCajaDataGridViewTextBoxColumn.HeaderText = "GananciaxCaja"
        Me.GananciaxCajaDataGridViewTextBoxColumn.Name = "GananciaxCajaDataGridViewTextBoxColumn"
        '
        'ImagenCajaDataGridViewImageColumn
        '
        Me.ImagenCajaDataGridViewImageColumn.DataPropertyName = "ImagenCaja"
        Me.ImagenCajaDataGridViewImageColumn.HeaderText = "ImagenCaja"
        Me.ImagenCajaDataGridViewImageColumn.Name = "ImagenCajaDataGridViewImageColumn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmListProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 433)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MercaderíaDataGridView)
        Me.Controls.Add(Me.MercaderíaBindingNavigator)
        Me.Name = "frmListProduct"
        Me.Text = "frmListProduct"
        CType(Me.GFacHojillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MercaderíaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MercaderíaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MercaderíaBindingNavigator.ResumeLayout(False)
        Me.MercaderíaBindingNavigator.PerformLayout()
        CType(Me.MercaderíaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GFacHojillaDataSet As GFacHojillaDataSet
    Friend WithEvents MercaderíaBindingSource As BindingSource
    Friend WithEvents MercaderíaTableAdapter As GFacHojillaDataSetTableAdapters.MercaderíaTableAdapter
    Friend WithEvents TableAdapterManager As GFacHojillaDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents MercaderíaDataGridView As DataGridView
    Friend WithEvents IdHojillaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioxPaqueteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadxCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioxCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GananciaxCajaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImagenCajaDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Button1 As Button
End Class
