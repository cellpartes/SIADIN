Imports System.Runtime.InteropServices
Public Class frmGrupoConsultas
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

    Private Sub btdProveedoresXUbicacion_Click(sender As Object, e As EventArgs) Handles btdProveedoresXUbicacion.Click
        'AbrirFormInPanel(Ubicacion)
        frmPrincipal.txtTitulo.Text = "Consulta de Proveedores por Ubicación"
    End Sub

    Private Sub btdClientesXUbicacion_Click(sender As Object, e As EventArgs) Handles btdClientesXUbicacion.Click
        'AbrirFormInPanel(ClientesxUbicacion)
        frmPrincipal.txtTitulo.Text = "Consulta de Clientes por Ubicación"
    End Sub

    Private Sub btdRegistroVentas_Click(sender As Object, e As EventArgs) Handles btdRegistroVentas.Click
        'AbrirFormInPanel(frmResumenVenta)
        frmPrincipal.txtTitulo.Text = "Consulta de Resumen de Ventas"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'AbrirFormInPanel(VentasxUbicacion)
        frmPrincipal.txtTitulo.Text = "Consulta de Ventas por Ubiación"
    End Sub

    Private Sub frmGrupoConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class