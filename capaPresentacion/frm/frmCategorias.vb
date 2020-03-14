Imports CapaEntidad
Imports CapaNegocios
Public Class frmCategorias
    Dim consulta As String
    Dim tabla As String
    Dim n As Integer
    Dim lv_id As String
    Dim cnAccesoDatos As New cnAccesoDatos()
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

    Private Sub btdSalir_Click(sender As Object, e As EventArgs) Handles btdSalir.Click
        Me.Close()
        AbrirFormInPanel(frmGrupoMaestros)
        frmPrincipal.txtTitulo.Text = "Maestros"
    End Sub

    Private Sub btdAgregar_Click(sender As Object, e As EventArgs) Handles btdAgregar.Click
        Close()
        Try
            consulta = "SELECT max(idCategoria) + 1 as ProxId FROM adm_categorias;"
            AbrirFormInPanel(frmDetalleCategorias)
            frmPrincipal.txtTitulo.Text = "Agregar Categorias"
            frmDetalleCategorias.Text = "Agregar"
            frmDetalleCategorias.txtId.Text = Format(cnAccesoDatos.ValorTabla(consulta), "000")
        Catch ex As Exception
            MessageBox.Show("Error consultado Proximo Id, " + ex.Message, "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btdEditar_Click(sender As Object, e As EventArgs) Handles btdEditar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        lv_id = dgvResultado.Rows(n).Cells(0).Value
        Close()
        AbrirFormInPanel(frmDetalleCategorias)
        frmPrincipal.txtTitulo.Text = "Actualizar Categorias"
        frmDetalleCategorias.Text = "Actualizar"
        frmDetalleCategorias.txtId.Text = lv_id
        frmDetalleCategorias.txtId.Enabled = False
    End Sub

    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        If dgvResultado.Rows(n).Cells(0).Value <> "" Then
            Dim result As DialogResult = MessageBox.Show("Desea Eliminar la Categoria " + dgvResultado.Rows(n).Cells(0).Value + "?", "Categorias", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = "6" Then
                Try
                    consulta = "delete from adm_categorias where idCategoria = '" & dgvResultado.Rows(n).Cells(0).Value & "';"
                    cnAccesoDatos.DMLTabla(consulta)
                Catch ex As Exception
                    MessageBox.Show("Error eliminando Categoría, " + ex.Message, "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
                MessageBox.Show("Categoria Eliminado", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consulta = "select idCategoria as id, Descripcion from adm_categorias;"
                tabla = "adm_categorias"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                dgvResultado.Columns(0).Width = 100
                dgvResultado.Columns(1).Width = 350
            End If
        End If
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        consulta = "SELECT idCategoria as id, Descripcion from adm_categorias where Descripcion like '%" & txtBusca.Text & "%';"
        tabla = "adm_categorias"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
    End Sub

    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        Try
            cnAccesoDatos.ExcelCategoria()
            MessageBox.Show("Archivo Creado", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generando archivo, " + ex.Message, "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta = "select idCategoria as id, Descripcion from adm_categorias;"
        tabla = "adm_categorias"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
        dgvResultado.Columns(0).Width = 100
        dgvResultado.Columns(1).Width = 350
    End Sub
End Class