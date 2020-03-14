Imports CapaEntidad
Imports CapaNegocios
Public Class frmSubCategoria
    Dim lv_operacion As String
    Dim dr As System.Data.IDataReader
    Dim lv_sw As String
    Dim lv_swcb As String
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
        btdAgregar.Enabled = False
        btdEditar.Enabled = False
        btdEliminar.Enabled = False
        btdBuscar.Enabled = False
        btdImprimir.Enabled = False
        btdSalir.Enabled = False
        btdOk.Visible = True
        btdCancela.Visible = True
        txtCategoria.Visible = False
        cbCategoria.Visible = True
        txtNombre.Enabled = True
        txtNombre.Text = ""
        Try
            consulta = "SELECT max(idSubCategoria) + 1 as ProxId FROM adm_subcategorias;"
            txtId.Text = Format(cnAccesoDatos.ValorTabla(consulta), "000")
        Catch ex As Exception
            MessageBox.Show("Error consultado Proximo Id, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            consulta = "Select idCategoria as id, Descripcion from adm_categorias;"
            tabla = "adm_categorias"
            cbCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbCategoria.DisplayMember = "Descripcion"
            cbCategoria.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando Categoria, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        lv_operacion = "Agregar"
    End Sub

    Private Sub btdEditar_Click(sender As Object, e As EventArgs) Handles btdEditar.Click
        If txtId.Text <> "" Then
            btdAgregar.Enabled = False
            btdEditar.Enabled = False
            btdEliminar.Enabled = False
            btdBuscar.Enabled = False
            btdImprimir.Enabled = False
            btdSalir.Enabled = False
            btdOk.Visible = True
            btdCancela.Visible = True
            txtNombre.Enabled = True
            txtCategoria.Visible = False
            cbCategoria.Visible = True
            Try
                consulta = "Select idCategoria as id, Descripcion from adm_categorias;"
                tabla = "adm_categorias"
                cbCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbCategoria.DisplayMember = "Descripcion"
                cbCategoria.ValueMember = "id"
            Catch ex As Exception
                MessageBox.Show("Error cargando Categoria, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            cbCategoria.SelectedValue = txtIdCategoria.Text
            lv_operacion = "Editar"
        Else
            MessageBox.Show("Por favor seleccionar una SubCategoria", "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        If txtId.Text <> "" Then
            Try
                consulta = "delete from adm_subcategorias where idSubCategoria = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("SubCategoria Eliminada", "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtId.Text = ""
                txtNombre.Text = ""
            Catch ex As Exception
                MessageBox.Show("Error eliminando SubCategoria, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            MessageBox.Show("Por favor seleccionar una SubCategoria", "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        frmBusca.txtTitulo.Text = "Busqueda de SubCategorias"
        frmBusca.Text = "BusquedaSubCategorias"
        frmBusca.Show()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Try
            cnAccesoDatos.BusquedaSubCategoriaxId(txtId.Text)
            txtNombre.Text = ceSubCategorias.Descripcion
            txtCategoria.Text = ceSubCategorias.Categoria
            txtIdCategoria.Text = ceSubCategorias.idCategoria
        Catch ex As Exception
            MessageBox.Show("Error consultando adm_subcategorias, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        Try
            cnAccesoDatos.ExcelSubCategoria()
            MessageBox.Show("Archivo Creado", "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generando archivo, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btdCancela_Click(sender As Object, e As EventArgs) Handles btdCancela.Click
        btdAgregar.Enabled = True
        btdEditar.Enabled = True
        btdEliminar.Enabled = True
        btdBuscar.Enabled = True
        btdImprimir.Enabled = True
        btdSalir.Enabled = True
        btdOk.Visible = False
        btdCancela.Visible = False
        txtId.Text = ""
        txtNombre.Text = ""
        txtNombre.Enabled = False
        txtCategoria.Visible = True
        cbCategoria.Visible = False
    End Sub

    Private Sub btdOk_Click(sender As Object, e As EventArgs) Handles btdOk.Click
        btdAgregar.Enabled = True
        btdEditar.Enabled = True
        btdEliminar.Enabled = True
        btdBuscar.Enabled = True
        btdImprimir.Enabled = True
        btdSalir.Enabled = True
        btdOk.Visible = False
        btdCancela.Visible = False
        txtNombre.Enabled = False
        txtCategoria.Visible = True
        cbCategoria.Visible = False
        If lv_operacion = "Editar" Then
            Try
                consulta = "update adm_subcategorias set Descripcion = '" & txtNombre.Text & "', idCategoria = '" & cbCategoria.SelectedValue & "' where idSubCategoria = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                Try
                    cnAccesoDatos.BusquedaSubCategoriaxId(txtId.Text)
                    txtNombre.Text = ceSubCategorias.Descripcion
                    txtCategoria.Text = ceSubCategorias.Categoria
                    txtIdCategoria.Text = ceSubCategorias.idCategoria
                Catch ex As Exception
                    MessageBox.Show("Error consultando adm_subcategorias, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                MessageBox.Show("SubCategoria Actualizada", "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando SubCategoria, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf lv_operacion = "Agregar" Then
            Try
                consulta = "SELECT count(*) as cant FROM adm_subcategorias WHERE Descripcion = '" & txtNombre.Text & "';"
                n = cnAccesoDatos.ValorTabla(consulta)
            Catch ex As Exception
                MessageBox.Show("Error consultando SubCategorias existentes, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If n = 0 Then
                Try
                    consulta = "insert into adm_subcategorias (idSubCategoria,Descripcion,idCategoria) values ('" & txtId.Text & "','" & txtNombre.Text & "','" & cbCategoria.SelectedValue & "');"
                    cnAccesoDatos.DMLTabla(consulta)
                    MessageBox.Show("SubCategoria Agregada", "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        cnAccesoDatos.BusquedaSubCategoriaxId(txtId.Text)
                        txtNombre.Text = ceSubCategorias.Descripcion
                        txtCategoria.Text = ceSubCategorias.Categoria
                        txtIdCategoria.Text = ceSubCategorias.idCategoria
                    Catch ex As Exception
                        MessageBox.Show("Error consultando adm_subcategorias, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Error insertando SubCategoria, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("SubCategoria ya Existe", "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class