Imports System.Runtime.InteropServices
Public Class frmGrupoOperaciones
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

    Private Sub btdVentas_Click(sender As Object, e As EventArgs)
        frmPrincipal.txtTitulo.Text = "Ventas"
    End Sub

    Private Sub btdCierreCaja_Click(sender As Object, e As EventArgs)
        frmPrincipal.txtTitulo.Text = "Apertura/Cierre de caja"
    End Sub

    Private Sub frmGrupoOperaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub ventasSalidas_Click(sender As Object, e As EventArgs) Handles ventasSalidas.Click
        AbrirFormInPanel(frmVentas)
        frmPrincipal.txtTitulo.Text = "Ventas Salidas"
    End Sub
End Class