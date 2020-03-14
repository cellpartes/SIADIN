Imports CapaEntidad
Imports CapaNegocios
Public Class frmDetalleCategorias
    Dim consulta As String
    Dim n As Integer
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
                consulta = "update adm_categorias set Descripcion = '" & txtNombre.Text & "' where idCategoria = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Categoría Actualizada", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando Categoría, " + ex.Message, "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        If Me.Text = "Agregar" Then
            Try
                consulta = "SELECT count(*) as cant FROM adm_categorias WHERE Descripcion = '" & txtNombre.Text & "';"
                n = cnAccesoDatos.ValorTabla(consulta)
            Catch ex As Exception
                MessageBox.Show("Error consultando Categorías existentes, " + ex.Message, "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If n = 0 Then
                Try
                    consulta = "insert into adm_categorias (idCategoria,Descripcion) values ('" & txtId.Text & "','" & txtNombre.Text & "');"
                    cnAccesoDatos.DMLTabla(consulta)
                    MessageBox.Show("Categoría Agregada", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        cnAccesoDatos.BusquedaCategoriaxId(txtId.Text)
                        txtNombre.Text = ceCategorias.Descripcion
                    Catch ex As Exception
                        MessageBox.Show("Error consultando adm_categorias, " + ex.Message, "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Error insertando Categoría, " + ex.Message, "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("Categoría ya Existe", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Close()
        AbrirFormInPanel(frmCategorias)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Categorias"
    End Sub

    Private Sub btdCancela_Click(sender As Object, e As EventArgs) Handles btdCancela.Click
        Close()
        AbrirFormInPanel(frmCategorias)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Categorias"
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Try
            cnAccesoDatos.BusquedaCategoriaxId(txtId.Text)
            txtNombre.Text = ceCategorias.Descripcion
        Catch ex As Exception
            MessageBox.Show("Error consultando adm_categorias, " + ex.Message, "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class