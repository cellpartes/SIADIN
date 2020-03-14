Imports CapaEntidad
Imports CapaNegocios
Public Class frmDetalleMarcas
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
                consulta = "update adm_marcas set Descripcion = '" & txtNombre.Text & "' where idMarca = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Marca Actualizada", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando Marca, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        If Me.Text = "Agregar" Then
            Try
                consulta = "SELECT count(*) as cant FROM adm_marcas WHERE Descripcion = '" & txtNombre.Text & "';"
                n = cnAccesoDatos.ValorTabla(consulta)
            Catch ex As Exception
                MessageBox.Show("Error consultando Marcas existentes, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If n = 0 Then
                Try
                    consulta = "insert into adm_marcas (idMarca, Descripcion) values('" & txtId.Text & "','" & txtNombre.Text & "');"
                    cnAccesoDatos.DMLTabla(consulta)
                    MessageBox.Show("Marca Agregada", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        cnAccesoDatos.BusquedaMarcaxId(txtId.Text)
                        txtNombre.Text = ceMarcas.Descripcion
                    Catch ex As Exception
                        MessageBox.Show("Error consultando adm_marcas, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Error insertando Marca, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("Marca ya Existe", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Close()
        AbrirFormInPanel(frmMarcas)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Marcas"
    End Sub

    Private Sub btdCancela_Click(sender As Object, e As EventArgs) Handles btdCancela.Click
        Close()
        AbrirFormInPanel(frmMarcas)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Marcas"
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Try
            cnAccesoDatos.BusquedaMarcaxId(txtId.Text)
            txtNombre.Text = ceMarcas.Descripcion
        Catch ex As Exception
            MessageBox.Show("Error consultando adm_marcas, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class