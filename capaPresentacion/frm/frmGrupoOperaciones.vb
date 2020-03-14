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

    Private Sub btdVentas_Click(sender As Object, e As EventArgs) Handles btdVentas.Click
        'AbrirFormInPanel(frmVentas)
        frmPrincipal.txtTitulo.Text = "Ventas"
    End Sub

    Private Sub btdCirreCaja_Click(sender As Object, e As EventArgs) Handles btdCirreCaja.Click
        'AbrirFormInPanel(frmCierreCaja)
        frmPrincipal.txtTitulo.Text = "Apertura/Cierre de Caja"
    End Sub
End Class