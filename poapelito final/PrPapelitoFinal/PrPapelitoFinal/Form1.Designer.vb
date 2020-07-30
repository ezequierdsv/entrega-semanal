<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mercaderia = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CleintesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalDeVentasEnElMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GananciaTotalObtenidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasPorVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MercaderíaMásVendidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElMayorYMenorVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.GestionDeVentasToolStripMenuItem, Me.EstadísticasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(651, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mercaderia, Me.VendedoresToolStripMenuItem, Me.CleintesToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'Mercaderia
        '
        Me.Mercaderia.Name = "Mercaderia"
        Me.Mercaderia.Size = New System.Drawing.Size(152, 22)
        Me.Mercaderia.Text = "Mercaderia"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'CleintesToolStripMenuItem
        '
        Me.CleintesToolStripMenuItem.Name = "CleintesToolStripMenuItem"
        Me.CleintesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CleintesToolStripMenuItem.Text = "Clintes"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'GestionDeVentasToolStripMenuItem
        '
        Me.GestionDeVentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntregasToolStripMenuItem, Me.FacturasToolStripMenuItem})
        Me.GestionDeVentasToolStripMenuItem.Name = "GestionDeVentasToolStripMenuItem"
        Me.GestionDeVentasToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.GestionDeVentasToolStripMenuItem.Text = "Gestion De Ventas"
        '
        'EntregasToolStripMenuItem
        '
        Me.EntregasToolStripMenuItem.Name = "EntregasToolStripMenuItem"
        Me.EntregasToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.EntregasToolStripMenuItem.Text = "Entregas"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalDeVentasEnElMesToolStripMenuItem, Me.GananciaTotalObtenidaToolStripMenuItem, Me.VentasPorVendedorToolStripMenuItem, Me.MercaderíaMásVendidaToolStripMenuItem, Me.ElMayorYMenorVendedorToolStripMenuItem})
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'TotalDeVentasEnElMesToolStripMenuItem
        '
        Me.TotalDeVentasEnElMesToolStripMenuItem.Name = "TotalDeVentasEnElMesToolStripMenuItem"
        Me.TotalDeVentasEnElMesToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.TotalDeVentasEnElMesToolStripMenuItem.Text = "Total de Ventas en el Mes"
        '
        'GananciaTotalObtenidaToolStripMenuItem
        '
        Me.GananciaTotalObtenidaToolStripMenuItem.Name = "GananciaTotalObtenidaToolStripMenuItem"
        Me.GananciaTotalObtenidaToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.GananciaTotalObtenidaToolStripMenuItem.Text = "Ganancia Total Obtenida"
        '
        'VentasPorVendedorToolStripMenuItem
        '
        Me.VentasPorVendedorToolStripMenuItem.Name = "VentasPorVendedorToolStripMenuItem"
        Me.VentasPorVendedorToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.VentasPorVendedorToolStripMenuItem.Text = "Ventas por Vendedor"
        '
        'MercaderíaMásVendidaToolStripMenuItem
        '
        Me.MercaderíaMásVendidaToolStripMenuItem.Name = "MercaderíaMásVendidaToolStripMenuItem"
        Me.MercaderíaMásVendidaToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.MercaderíaMásVendidaToolStripMenuItem.Text = "Mercadería más vendida"
        '
        'ElMayorYMenorVendedorToolStripMenuItem
        '
        Me.ElMayorYMenorVendedorToolStripMenuItem.Name = "ElMayorYMenorVendedorToolStripMenuItem"
        Me.ElMayorYMenorVendedorToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ElMayorYMenorVendedorToolStripMenuItem.Text = "El Mayor y Menor Vendedor"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 474)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Mercaderia As ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CleintesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalDeVentasEnElMesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GananciaTotalObtenidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasPorVendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MercaderíaMásVendidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ElMayorYMenorVendedorToolStripMenuItem As ToolStripMenuItem
End Class
