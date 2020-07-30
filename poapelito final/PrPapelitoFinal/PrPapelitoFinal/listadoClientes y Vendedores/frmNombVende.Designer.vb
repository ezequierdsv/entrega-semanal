<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNombVende
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNombVende))
        Dim NombresLabel As System.Windows.Forms.Label
        Dim IdVendedorLabel As System.Windows.Forms.Label
        Me.GFacHojillaDataSet = New PrPapelitoFinal.GFacHojillaDataSet()
        Me.VendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendedorTableAdapter = New PrPapelitoFinal.GFacHojillaDataSetTableAdapters.VendedorTableAdapter()
        Me.TableAdapterManager = New PrPapelitoFinal.GFacHojillaDataSetTableAdapters.TableAdapterManager()
        Me.VendedorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VendedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.IdVendedorTextBox = New System.Windows.Forms.TextBox()
        NombresLabel = New System.Windows.Forms.Label()
        IdVendedorLabel = New System.Windows.Forms.Label()
        CType(Me.GFacHojillaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VendedorBindingNavigator.SuspendLayout()
        CType(Me.VendedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GFacHojillaDataSet
        '
        Me.GFacHojillaDataSet.DataSetName = "GFacHojillaDataSet"
        Me.GFacHojillaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendedorBindingSource
        '
        Me.VendedorBindingSource.DataMember = "Vendedor"
        Me.VendedorBindingSource.DataSource = Me.GFacHojillaDataSet
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
        Me.TableAdapterManager.Usuarios2TableAdapter = Nothing
        Me.TableAdapterManager.Usuarios3TableAdapter = Nothing
        Me.TableAdapterManager.Usuarios4TableAdapter = Nothing
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Me.VendedorTableAdapter
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'VendedorBindingNavigator
        '
        Me.VendedorBindingNavigator.AddNewItem = Nothing
        Me.VendedorBindingNavigator.BindingSource = Me.VendedorBindingSource
        Me.VendedorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VendedorBindingNavigator.DeleteItem = Nothing
        Me.VendedorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.VendedorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VendedorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VendedorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VendedorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VendedorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VendedorBindingNavigator.Name = "VendedorBindingNavigator"
        Me.VendedorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VendedorBindingNavigator.Size = New System.Drawing.Size(363, 25)
        Me.VendedorBindingNavigator.TabIndex = 0
        Me.VendedorBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'VendedorDataGridView
        '
        Me.VendedorDataGridView.AutoGenerateColumns = False
        Me.VendedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VendedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.VendedorDataGridView.DataSource = Me.VendedorBindingSource
        Me.VendedorDataGridView.Location = New System.Drawing.Point(12, 63)
        Me.VendedorDataGridView.Name = "VendedorDataGridView"
        Me.VendedorDataGridView.Size = New System.Drawing.Size(337, 220)
        Me.VendedorDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdVendedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdVendedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cedula"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombres"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Teléfono"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Dirección"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
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
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(12, 35)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(47, 13)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombre:"
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(70, 32)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombresTextBox.TabIndex = 3
        '
        'IdVendedorLabel
        '
        IdVendedorLabel.AutoSize = True
        IdVendedorLabel.Location = New System.Drawing.Point(175, 35)
        IdVendedorLabel.Name = "IdVendedorLabel"
        IdVendedorLabel.Size = New System.Drawing.Size(68, 13)
        IdVendedorLabel.TabIndex = 4
        IdVendedorLabel.Text = "Id Vendedor:"
        '
        'IdVendedorTextBox
        '
        Me.IdVendedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "IdVendedor", True))
        Me.IdVendedorTextBox.Location = New System.Drawing.Point(249, 32)
        Me.IdVendedorTextBox.Name = "IdVendedorTextBox"
        Me.IdVendedorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdVendedorTextBox.TabIndex = 5
        '
        'frmNombVende
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 307)
        Me.Controls.Add(IdVendedorLabel)
        Me.Controls.Add(Me.IdVendedorTextBox)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(Me.VendedorDataGridView)
        Me.Controls.Add(Me.VendedorBindingNavigator)
        Me.Name = "frmNombVende"
        Me.Text = "frmNombVende"
        CType(Me.GFacHojillaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VendedorBindingNavigator.ResumeLayout(False)
        Me.VendedorBindingNavigator.PerformLayout()
        CType(Me.VendedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GFacHojillaDataSet As GFacHojillaDataSet
    Friend WithEvents VendedorBindingSource As BindingSource
    Friend WithEvents VendedorTableAdapter As GFacHojillaDataSetTableAdapters.VendedorTableAdapter
    Friend WithEvents TableAdapterManager As GFacHojillaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VendedorBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents VendedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents NombresTextBox As TextBox
    Friend WithEvents IdVendedorTextBox As TextBox
End Class
