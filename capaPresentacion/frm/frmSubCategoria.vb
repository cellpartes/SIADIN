Imports CapaEntidad
Imports CapaNegocios
Public Class frmSubCategoria
    Dim lv_operacion As String
    Dim dr As System.Data.IDataReader
    Dim lv_id As String
    Dim consulta As String
    Dim tabla As String
    Dim n As Integer
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
            consulta = "SELECT max(idSubCategoria) + 1 ProxId FROM adm_subcategorias;"
            AbrirFormInPanel(frmDetalleSubCategoria)
            frmPrincipal.txtTitulo.Text = "Agregar Subcategoria"
            frmDetalleSubCategoria.Text = "Agregar"
            frmDetalleSubCategoria.txtCategoria.Visible = False
            frmDetalleSubCategoria.cbCategoria.Visible = True
            frmDetalleSubCategoria.txtNombre.Enabled = True
            frmDetalleSubCategoria.txtId.Text = Format(cnAccesoDatos.ValorTabla(consulta), "000")
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
        AbrirFormInPanel(frmDetalleSubCategoria)
        frmPrincipal.txtTitulo.Text = "Actualizar SubCategoria"
        frmDetalleSubCategoria.Text = "Actualizar"
        frmDetalleSubCategoria.txtId.Text = lv_id
        frmDetalleSubCategoria.txtId.Enabled = False
        frmDetalleSubCategoria.txtNombre.Enabled = True
        frmDetalleSubCategoria.txtCategoria.Visible = False

        frmDetalleSubCategoria.cbCategoria.Visible = True
        frmDetalleSubCategoria.cbCategoria.Enabled = True

    End Sub

    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        If dgvResultado.Rows(n).Cells(0).Value <> "" Then
            Dim result As DialogResult = MessageBox.Show("Desea Eliminar la SubCategoria " + dgvResultado.Rows(n).Cells(0).Value + "?", "Categorias", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = "6" Then
                Try
                    consulta = "delete from adm_subcategorias where idSubCategoria = '" & dgvResultado.Rows(n).Cells(0).Value & "';"
                    cnAccesoDatos.DMLTabla(consulta)
                Catch ex As Exception
                    MessageBox.Show("Error eliminando SubCategoría, " + ex.Message, "SubCategorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
                MessageBox.Show("SubCategoria Eliminado", "SubCategoria", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consulta = "select a.idSubCategoria as id, a.Descripcion, b.descripcion as Categoria " _
                & " from adm_subcategorias a " _
                & " inner join adm_categorias b on a.idCategoria = b.idCategoria;"
                tabla = "adm_subcategorias"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                dgvResultado.Columns(0).Width = 100
                dgvResultado.Columns(1).Width = 175
                dgvResultado.Columns(2).Width = 175
            End If
        End If
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        consulta = "select a.idSubCategoria as id, a.Descripcion, b.descripcion as Categoria " _
                         & "  from adm_subcategorias a  " _
                         & " inner join adm_categorias b on a.idCategoria = b.idCategoria " _
                         & " where a.Descripcion like '%" & txtBusca.Text & "%';"
        tabla = "adm_subcategorias"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
    End Sub
    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        Try
            cnAccesoDatos.ExcelSubCategoria()
            MessageBox.Show("Archivo Creado", "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generando archivo, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frmSubCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta = "select a.idSubCategoria as id, a.Descripcion, b.descripcion as Categoria " _
                 & " from adm_subcategorias a " _
                 & " inner join adm_categorias b on a.idCategoria = b.idCategoria;"
        tabla = "adm_subcategorias"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
        dgvResultado.Columns(0).Width = 80
        dgvResultado.Columns(1).Width = 175
        dgvResultado.Columns(2).Width = 175
    End Sub
End Class