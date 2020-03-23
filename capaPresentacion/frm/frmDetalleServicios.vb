Imports CapaEntidad
Imports CapaNegocios

Public Class frmDetalleServicios
    Dim lv_swcb As String
    Dim lv_sw As String
    Dim lv_id As String
    Dim consulta As String
    Dim n As Integer
    Dim tabla As String
    Dim cnAccesoDatos As New cnAccesoDatos
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
            lv_text = " a.descripcion = a.descripcion"
        Else
            lv_text = " a.descripcion Like '%" & txtBusca.Text & "%'"
        End If
        If cbCategoria.SelectedValue = "000" Then
            lv_Cat = "a.idCategoria = a.idCategoria"
        Else
            lv_Cat = "a.idCategoria = '" & cbCategoria.SelectedValue & "'"
        End If
        If cbSubCategoria.SelectedValue = "000" Then
            lv_SubCat = "a.idSubCategoria = a.idSubCategoria"
        Else
            lv_SubCat = "a.idSubCategoria = '" & cbSubCategoria.SelectedValue & "'"
        End If
        If cbMarca.SelectedValue = "000" Then
            lv_Marca = "a.idMarca = a.idMarca"
        Else
            lv_Marca = "a.idMarca = '" & cbMarca.SelectedValue & "';"
        End If
        Try
            consulta = "select a.idarticulo as id, a.descripcion, b.descripcion as categoria, c.descripcion as subcategoria, d.Descripcion as marca " _
                        & " from adm_catalogo a " _
                        & " inner join adm_categorias b on a.idCategoria=b.idCategoria " _
                        & " inner join adm_subcategorias c on a.idSubCategoria=c.idSubCategoria " _
                        & " inner join adm_marcas d on a.idMarca = d.idMarca " _
                        & " where " + lv_text + " and " + lv_Cat _
                        & " and " + lv_SubCat + " and " + lv_Marca
            tabla = "adm_catalogo"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 80
            dgvResultado.Columns(1).Width = 320
            dgvResultado.Columns(2).Width = 120
            dgvResultado.Columns(3).Width = 120
            dgvResultado.Columns(4).Width = 120
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btdOk_Click(sender As Object, e As EventArgs) Handles btdOk.Click
        If Me.Text = "Actualizar" Then
            Try
                consulta = "update adm_servicios " _
                         & "    Set monto = '" & txtMonto.Text & "', " _
                         & "        Activo = '" & Mid(cbActivo.Text, 1, 1) & "' " _
                         & " where idArticulo = '" & txtId.Text & "' and idEmpresa = '" & ceUsuarioActivo.idEmpresa & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Servicio Actualizado", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando Servicio, " + ex.Message, "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Close()
            AbrirFormInPanel(frmServicios)
            frmPrincipal.txtTitulo.Text = "Mantenimiento de Servicios"
        End If
        If Me.Text = "Agregar" Then
            If txtMonto.Text <> "" Then
                txtFechaUltMov.Text = Format(Now, "yyyy/MM/dd")
                Try
                    consulta = "SELECT count(*) as cant FROM adm_servicios where idArticulo = '" & txtId.Text & "' and idEmpresa = '" & ceUsuarioActivo.idEmpresa & "';"
                    n = cnAccesoDatos.ValorTabla(consulta)
                Catch ex As Exception
                    MessageBox.Show("Error consultando Servicios existentes, " + ex.Message, "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                If n = 0 Then
                    Try
                        consulta = "insert into adm_servicios (idArticulo, idEmpresa, monto, Activo, FechaUltMov) " _
                                 & "                    values('" & txtId.Text & "','" & ceUsuarioActivo.idEmpresa & "', " _
                                 & "                           '" & txtMonto.Text & "','" & Mid(cbActivo.Text, 1, 1) & "', " _
                                 & "                           '" & txtFechaUltMov.Text & "');"
                        cnAccesoDatos.DMLTabla(consulta)
                        MessageBox.Show("Servicio Agregado", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error insertando Servicio, " + ex.Message, "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Else
                    MessageBox.Show("Servicio ya Existe", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Close()
                AbrirFormInPanel(frmServicios)
                frmPrincipal.txtTitulo.Text = "Mantenimiento de Servicios"
            Else
                MessageBox.Show("Por favor ingresar un monto al Servicio", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub btdCancela_Click(sender As Object, e As EventArgs) Handles btdCancela.Click
        Close()
        AbrirFormInPanel(frmServicios)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Servicios"
    End Sub

    Private Sub frmDetalleServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                MuestraTablas()
            End Try
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

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub

    Private Sub dgvResultado_SelectionChanged(sender As Object, e As EventArgs) Handles dgvResultado.SelectionChanged
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        txtId.Text = dgvResultado.Rows(n).Cells(0).Value
        txtDescripcion.Text = dgvResultado.Rows(n).Cells(1).Value
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Try
            cnAccesoDatos.BusquedaServicioxId(txtId.Text)
            txtDescripcion.Text = ceServicios.Descripcion
            txtMonto.Text = ceServicios.Monto
            txtActivo.Text = ceServicios.Activo
            txtFechaUltMov.Text = ceServicios.FechaUltMov
        Catch ex As Exception
            MessageBox.Show("Error consultando adm_servicios, " + ex.Message, "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class