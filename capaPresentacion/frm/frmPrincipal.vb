Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports CapaEntidad

Public Class frmPrincipal
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub btdCerrar_Click(sender As Object, e As EventArgs) Handles btdCerrar.Click
        Close()
    End Sub

    Private Sub btdMaximizar_Click(sender As Object, e As EventArgs) Handles btdMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        btdRestaurar.Visible = True
        btdMaximizar.Visible = False
    End Sub

    Private Sub btdRestaurar_Click(sender As Object, e As EventArgs) Handles btdRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btdRestaurar.Visible = False
        btdMaximizar.Visible = True
    End Sub

    Private Sub btdMinimizar_Click(sender As Object, e As EventArgs) Handles btdMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub AbrirFormInPanel(formhijo As Object)
        If PanelContenedor.Controls.Count > 0 Then
            PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = formhijo
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(fh)
        PanelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub btdConsultas_Click(sender As Object, e As EventArgs) Handles btdConsultas.Click
        AbrirFormInPanel(frmGrupoConsultas)
        txtTitulo.Text = "Consultas"

    End Sub

    Private Sub btdOperaciones_Click(sender As Object, e As EventArgs) Handles btdOperaciones.Click
        AbrirFormInPanel(frmGrupoOperaciones)
        txtTitulo.Text = "Operaciones"

    End Sub

    Private Sub BarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub BarraTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseUp
        Arrastre = False
    End Sub

    Private Sub BarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles BarraTitulo.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormInPanel(frmLogo)
        txtUsuario.Text = ceUsuarioActivo.Nombre + " - " + ceUsuarioActivo.Nivel
        txtEmpresa.Text = ceUsuarioActivo.Empresa
    End Sub

    Private Sub btnSlide_Click(sender As Object, e As EventArgs) Handles btnSlide.Click
        If MenuVertical.Width = 250 Then
            MenuVertical.Width = 50
        Else
            MenuVertical.Width = 250
        End If
    End Sub

    Private Sub btdMaestros_Click(sender As Object, e As EventArgs) Handles btdMaestros.Click
        AbrirFormInPanel(frmGrupoMaestros)
        txtTitulo.Text = "Maestros"
    End Sub

End Class