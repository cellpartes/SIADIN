Imports System.Runtime.InteropServices
Public Class frmGrupoMaestros
    Private Sub AbrirFormInPanel(formhijo As Object)
        If frmPrincipal.PanelContenedor.Controls.Count > 0 Then
            frmPrincipal.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = formhijo
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        frmPrincipal.PanelContenedor.Controls.Add(fh)
        frmPrincipal.PanelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub btdProveedores_Click(sender As Object, e As EventArgs) Handles btdProveedores.Click
        AbrirFormInPanel(frmProveedores)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Proveedores"
    End Sub

    Private Sub btdClientes_Click(sender As Object, e As EventArgs) Handles btdClientes.Click
        AbrirFormInPanel(frmclientes)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Clientes"
    End Sub

    Private Sub btdEmpresasEnvio_Click(sender As Object, e As EventArgs) Handles btdEmpresasEnvio.Click
        AbrirFormInPanel(frmEmpresasEnvio)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Courier"
    End Sub

    Private Sub btdCatalogo_Click(sender As Object, e As EventArgs) Handles btdCatalogo.Click
        AbrirFormInPanel(frmCatalogo)
        frmPrincipal.txtTitulo.Text = "Mantenimiento del Catalogo"
    End Sub

    Private Sub btdCategorias_Click(sender As Object, e As EventArgs) Handles btdCategorias.Click
        AbrirFormInPanel(frmCategorias)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Categorías"
    End Sub

    Private Sub btdMarcas_Click(sender As Object, e As EventArgs) Handles btdMarcas.Click
        AbrirFormInPanel(frmMarcas)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Marcas"
    End Sub

    Private Sub btdSubCategorias_Click(sender As Object, e As EventArgs) Handles btdSubCategorias.Click
        AbrirFormInPanel(frmSubCategoria)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de SubCategorías"
    End Sub

    Private Sub btdServicios_Click(sender As Object, e As EventArgs) Handles btdServicios.Click
        AbrirFormInPanel(frmServicios)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Servicios"
    End Sub

    Private Sub btdVendedores_Click(sender As Object, e As EventArgs) Handles btdVendedores.Click
        AbrirFormInPanel(frmVendedores)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Vendedores"
    End Sub

    Private Sub btdBancos_Click(sender As Object, e As EventArgs) Handles btdBancos.Click
        AbrirFormInPanel(frmBancos)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Bancos"
    End Sub
End Class