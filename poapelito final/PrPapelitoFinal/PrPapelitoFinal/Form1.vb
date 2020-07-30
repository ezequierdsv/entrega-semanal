Public Class Form1
    'armamos todos los procedimientos para luego asignarlos a los botones que nos abriran las ventanas 
    Private Sub VendedoresList()
        Dim frmListVendedores As frmListVendedores = New frmListVendedores()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmListVendedores.Show()

    End Sub
    Private Sub UsuarioList()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmUsuarios As frmUsuarios = New frmUsuarios()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmUsuarios.Show()
    End Sub


    Private Sub ClientesList()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmListClientes As frmListClientes = New frmListClientes()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmListClientes.Show()
    End Sub

    Private Sub Facturas()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmFacturas As frmFacturas = New frmFacturas()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmFacturas.Show()
    End Sub

    Private Sub Entragas()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmEntregas As btnAgregar = New btnAgregar()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmEntregas.Show()
    End Sub

    Private Sub ElMenElma()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmElmaElme As frmElmaElme = New frmElmaElme()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmElmaElme.Show()
    End Sub
    Private Sub GananciaTot()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmGananciaTotal As frmGananciaTotal = New frmGananciaTotal()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmGananciaTotal.Show()
    End Sub
    Private Sub MercaMasVendida()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmMercMasVend As frmMercMasVend = New frmMercMasVend()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmMercMasVend.Show()
    End Sub
    Private Sub MercaMenosVendida()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmVentMenosVend As frmVentMenosVend = New frmVentMenosVend()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmVentMenosVend.Show()
    End Sub
    Private Sub VentasPorVendedor()
        Dim frmVentasPorVendedor As frmVentasPorVendedor = New frmVentasPorVendedor()
        frmVentasPorVendedor.Show()
    End Sub
    Private Sub TotalDeVentas()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmTotalVent As frmTotalVent = New frmTotalVent()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmTotalVent.Show()
    End Sub
    Private Sub ListaProductos()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmListProduct As frmListProduct = New frmListProduct()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmListProduct.Show()
    End Sub
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mercaderia.Click
        ListaProductos()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmUsuarios.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedoresToolStripMenuItem.Click
        VendedoresList()
    End Sub

    Private Sub CleintesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleintesToolStripMenuItem.Click
        ClientesList()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EntregasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregasToolStripMenuItem.Click
        Entragas()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem.Click
        Facturas()
    End Sub

    Private Sub TotalDeVentasEnElMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalDeVentasEnElMesToolStripMenuItem.Click
        TotalDeVentas()
    End Sub

    Private Sub GananciaTotalObtenidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GananciaTotalObtenidaToolStripMenuItem.Click
        GananciaTot()
    End Sub

    Private Sub VentasPorVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasPorVendedorToolStripMenuItem.Click
        VentasPorVendedor()
    End Sub

    Private Sub MercaderíaMásVendidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MercaderíaMásVendidaToolStripMenuItem.Click
        MercaMenosVendida()
    End Sub

    Private Sub ElMayorYMenorVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElMayorYMenorVendedorToolStripMenuItem.Click
        ElMenElma()
    End Sub
End Class
