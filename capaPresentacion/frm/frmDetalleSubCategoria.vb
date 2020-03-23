Imports CapaEntidad
Imports CapaNegocios
Public Class frmDetalleSubCategoria
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
    Private Sub btdOk_Click(sender As Object, e As EventArgs) Handles btdOk.Click
        If Me.Text = "Actualizar" Then
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
        End If
        If Me.Text = "Agregar" Then
            Try
                consulta = "SELECT count(*) as cant FROM  adm_subcategorias WHERE Descripcion = '" & txtNombre.Text & "';"
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
        Close()
        AbrirFormInPanel(frmSubCategoria)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de SubCategorias"
    End Sub

    Private Sub btdCancela_Click(sender As Object, e As EventArgs) Handles btdCancela.Click
        Close()
        AbrirFormInPanel(frmSubCategoria)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de SubCategoria"
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        If txtId.Text <> "" Then
            Try
                cnAccesoDatos.BusquedaSubCategoriaxId(txtId.Text)
                txtNombre.Text = ceSubCategorias.Descripcion
                txtCategoria.Text = ceSubCategorias.Categoria
                txtIdCategoria.Text = ceSubCategorias.idCategoria
            Catch ex As Exception
                MessageBox.Show("Error consultando adm_subcategorias, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        If txtIdCategoria.Text <> "" Then
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
        End If
        If Me.Text = "Agregar" Then
            Try
                consulta = "Select idCategoria as id, Descripcion from adm_categorias;"
                tabla = "adm_categorias"
                cbCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbCategoria.DisplayMember = "Descripcion"
                cbCategoria.ValueMember = "id"
            Catch ex As Exception
                MessageBox.Show("Error cargando Categoria, " + ex.Message, "SubCategorias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
End Class