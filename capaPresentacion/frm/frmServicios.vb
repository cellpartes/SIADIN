Imports CapaEntidad
Imports CapaNegocios
Public Class frmServicios
    Dim lv_operacion As String
    Dim dr As System.Data.IDataReader
    Dim lv_sw As String
    Dim lv_swcb As String
    Dim consulta As String
    Dim tabla As String
    Dim lv_busqueda As String
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
    Public Sub MuestraTablas()
        Dim lv_SubCat As String
        Dim lv_Marca As String
        Dim lv_text As String
        Dim lv_Cat As String

        If txtBusca.Text = "" Then
            lv_text = " b.descripcion = b.descripcion"
        Else
            lv_text = " b.descripcion like '%" & txtBusca.Text & "%'"
        End If
        If cbCategoria.SelectedValue = "000" Then
            lv_Cat = "b.idCategoria = b.idCategoria"
        Else
            lv_Cat = "b.idCategoria = '" & cbCategoria.SelectedValue & "'"
        End If
        If cbSubCategoria.SelectedValue = "000" Then
            lv_SubCat = "b.idSubCategoria = b.idSubCategoria"
        Else
            lv_SubCat = "b.idSubCategoria = '" & cbSubCategoria.SelectedValue & "'"
        End If
        If cbMarca.SelectedValue = "000" Then
            lv_Marca = "b.idMarca = b.idMarca"
        Else
            lv_Marca = "b.idMarca = '" & cbMarca.SelectedValue & "';"
        End If

        Try
            consulta = "select a.idArticulo, b.descripcion, c.descripcion as categoria, d.descripcion as subcategoria, e.Descripcion as marca " _
                        & "  from adm_servicios a " _
                        & " inner join adm_catalogo b on a.idArticulo = b.idArticulo " _
                        & " inner join adm_categorias c on b.idCategoria=c.idCategoria " _
                        & " inner join adm_subcategorias d on b.idSubCategoria=d.idSubCategoria " _
                        & " inner join adm_marcas e on b.idMarca = e.idMarca" _
                        & " where" + lv_text + " and " + lv_Cat _
                        & " and " + lv_SubCat + " and " + lv_Marca
            tabla = "adm_servicios"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 80
            dgvResultado.Columns(1).Width = 350
            dgvResultado.Columns(2).Width = 120
            dgvResultado.Columns(3).Width = 120
            dgvResultado.Columns(4).Width = 110
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btdSalir_Click(sender As Object, e As EventArgs) Handles btdSalir.Click
        Me.Close()
        AbrirFormInPanel(frmGrupoMaestros)
        frmPrincipal.txtTitulo.Text = "Maestros"
    End Sub
    Private Sub btdAgregar_Click(sender As Object, e As EventArgs) Handles btdAgregar.Click
        Close()
        AbrirFormInPanel(frmDetalleServicios)
        frmPrincipal.txtTitulo.Text = "Agregar Servicio"
        frmDetalleServicios.Text = "Agregar"
        frmDetalleServicios.txtDescripcion.Enabled = True
        frmDetalleServicios.txtMonto.Enabled = True
        frmDetalleServicios.txtActivo.Visible = False
        frmDetalleServicios.cbActivo.Visible = True
        frmDetalleServicios.cbActivo.SelectedValue = 1
    End Sub
    Private Sub btdEditar_Click(sender As Object, e As EventArgs) Handles btdEditar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        lv_id = dgvResultado.Rows(n).Cells(0).Value
        Close()
        AbrirFormInPanel(frmDetalleServicios)
        frmPrincipal.txtTitulo.Text = "Actualizar Servicio"
        frmDetalleServicios.Text = "Actualizar"
        frmDetalleServicios.txtId.Text = lv_id
        frmDetalleServicios.txtDescripcion.Enabled = True
        frmDetalleServicios.txtMonto.Enabled = True
        frmDetalleServicios.txtActivo.Visible = False
        frmDetalleServicios.cbActivo.Visible = True
        frmDetalleServicios.GroupBox1.Visible = False
        frmDetalleServicios.GroupBox2.Visible = False
    End Sub
    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        If dgvResultado.Rows(n).Cells(0).Value <> "" Then
            Dim result As DialogResult = MessageBox.Show("Desea Eliminar el Servicio " + dgvResultado.Rows(n).Cells(0).Value + "?", "Servicios", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = "6" Then
                Try
                    consulta = "delete from adm_servicios where idArticulo = '" & dgvResultado.Rows(n).Cells(0).Value & "' and idEmpresa = '" & ceUsuarioActivo.idEmpresa & "';"
                    cnAccesoDatos.DMLTabla(consulta)
                Catch ex As Exception
                    MessageBox.Show("Error eliminando Servicio, " + ex.Message, "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
                MessageBox.Show("Servicio Eliminado", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MuestraTablas()
            End If
        End If
    End Sub
    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        Try
            cnAccesoDatos.ExcelServicios()
            MessageBox.Show("Archivo Creado", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generando archivo, " + ex.Message, "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub

    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_swcb = "0"
        Try
            consulta = "Select idCategoria as id, Descripcion from adm_categorias;"
            tabla = "adm_categorias"
            cbCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbCategoria.DisplayMember = "Descripcion"
            cbCategoria.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando Categoria, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            If cbCategoria.SelectedValue.ToString <> "" Then
                lv_sw = cbCategoria.SelectedValue
            Else
                lv_sw = "002"
            End If
            consulta = "select '000' as id, 'Todos' as descripcion union select idsubcategoria as id, descripcion from adm_subcategorias where idcategoria = '" & lv_sw & "'"
            tabla = "adm_subcategorias"
            cbSubCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbSubCategoria.DisplayMember = "Descripcion"
            cbSubCategoria.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando SubCategoria, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            consulta = "select '000' as id, 'Todos' as descripcion union select idmarca as id, descripcion from adm_marcas;"
            tabla = "adm_marcas"
            cbMarca.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbMarca.DisplayMember = "Descripcion"
            cbMarca.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando Marcas, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        MuestraTablas()
        lv_swcb = "1"
    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged
        If lv_swcb = "1" Then
            Try
                If cbCategoria.SelectedValue.ToString <> "" Then
                    lv_sw = cbCategoria.SelectedValue
                Else
                    lv_sw = "002"
                End If
                consulta = "select '000' as id, 'Todos' as descripcion union select idsubcategoria as id, descripcion from adm_subcategorias where idcategoria = '" & lv_sw & "'"
                tabla = "adm_subcategorias"
                cbSubCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbSubCategoria.DisplayMember = "Descripcion"
                cbSubCategoria.ValueMember = "id"
            Catch ex As Exception
                MessageBox.Show("Error cargando SubCategoria, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
            MuestraTablas()
        End If
    End Sub
    Private Sub cbSubCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubCategoria.SelectedIndexChanged
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub

    Private Sub cbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMarca.SelectedIndexChanged
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub
End Class