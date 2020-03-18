Imports CapaEntidad
Imports CapaNegocios
Public Class frmDetalleEmpresasEnvio
    Dim consulta As String
    Dim n As Integer
    Dim tabla As String
    Dim lv_sw As String
    Dim lv_swcb As String
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
                consulta = "update adm_empresas_envio set Nombre = '" & txtNombre.Text & "', Ubigeo_Distrito = '" & cbDistrito.SelectedValue.ToString & "' where idEmpresaEnvio = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Courier Actualizado", "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando Courier, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        If Me.Text = "Agregar" Then
            Try
                consulta = "SELECT count(*) as cant FROM adm_empresas_envio WHERE Nombre = '" & txtNombre.Text & "';"
                n = cnAccesoDatos.ValorTabla(consulta)
            Catch ex As Exception
                MessageBox.Show("Error consultando Courier existentes, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If n = 0 Then
                txtUbigeoDistrito.Text = cbDistrito.SelectedValue
                Try
                    consulta = "insert into adm_empresas_envio (idEmpresaEnvio, Nombre, Ubigeo_Distrito) " _
                             & "                        values('" & txtId.Text & "','" & txtNombre.Text & "','" & txtUbigeoDistrito.Text & "');"
                    cnAccesoDatos.DMLTabla(consulta)
                    MessageBox.Show("Courier Agregado", "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        cnAccesoDatos.BusquedaCiurierxId(txtId.Text)
                        txtNombre.Text = ceEmpresas_Envio.Nombre
                        txtUbigeoDistrito.Text = ceEmpresas_Envio.Ubigeo_Distrito
                        txtDepartamento.Text = ceEmpresas_Envio.Departamento
                        txtProvincia.Text = ceEmpresas_Envio.Provincia
                        txtDistrito.Text = ceEmpresas_Envio.Distrito
                    Catch ex As Exception
                        MessageBox.Show("Error mostrando Courier, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Error insertando cliente, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("Courier ya Existe", "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Close()
        AbrirFormInPanel(frmEmpresasEnvio)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Courier"
    End Sub

    Private Sub btdCancela_Click(sender As Object, e As EventArgs) Handles btdCancela.Click
        Close()
        AbrirFormInPanel(frmEmpresasEnvio)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Courier"
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        lv_sw = "1"
        If txtId.Text <> "" Then
            Try
                cnAccesoDatos.BusquedaCiurierxId(txtId.Text)
                txtNombre.Text = ceEmpresas_Envio.Nombre
                txtUbigeoDistrito.Text = ceEmpresas_Envio.Ubigeo_Distrito
                txtDepartamento.Text = ceEmpresas_Envio.Departamento
                txtProvincia.Text = ceEmpresas_Envio.Provincia
                txtDistrito.Text = ceEmpresas_Envio.Distrito
            Catch ex As Exception
                MessageBox.Show("Error consultando adm_empresas_envio, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Try
                consulta = "Select ubigeo_dpto, departamento from adm_departamentos"
                tabla = "adm_departamentos"
                cbDepartamento.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) ' DS.Tables(0)
                cbDepartamento.DisplayMember = "departamento"
                cbDepartamento.ValueMember = "ubigeo_dpto"
            Catch ex As Exception
                MessageBox.Show("Error cargando departamentos, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Try
                If cbDepartamento.SelectedValue.ToString <> "" Then
                    lv_sw = cbDepartamento.SelectedValue.ToString
                Else
                    lv_sw = "01"
                End If
                consulta = "select ubigeo_prov, provincia from adm_provincias where ubigeo_dpto = '" & lv_sw & "'"
                tabla = "adm_provincias"
                cbProvincia.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbProvincia.DisplayMember = "provincia"
                cbProvincia.ValueMember = "ubigeo_prov"
            Catch ex As Exception
                MessageBox.Show("Error cargando provincias, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Try
                If cbProvincia.SelectedValue.ToString <> "" Then
                    lv_sw = cbProvincia.SelectedValue.ToString
                Else
                    lv_sw = "0101"
                End If
                consulta = "select ubigeo_distrito, distrito from adm_distritos where ubigeo_prov = '" & lv_sw & "'"
                tabla = "adm_distritos"
                cbDistrito.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
                cbDistrito.DisplayMember = "distrito"
                cbDistrito.ValueMember = "ubigeo_distrito"
            Catch ex As Exception
                MessageBox.Show("Error cargando distritos 3, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            lv_swcb = "0"
        End If
        If txtUbigeoDistrito.Text <> "" Then
            Try
                consulta = "Select ubigeo_dpto, departamento from adm_departamentos"
                tabla = "adm_departamentos"
                cbDepartamento.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) ' DS.Tables(0)
                cbDepartamento.DisplayMember = "departamento"
                cbDepartamento.ValueMember = "ubigeo_dpto"
            Catch ex As Exception
                MessageBox.Show("Error cargando departamentos, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            cbDepartamento.SelectedValue = Mid(txtUbigeoDistrito.Text, 1, 2)
            Try
                If cbDepartamento.SelectedValue.ToString <> "" Then
                    lv_sw = cbDepartamento.SelectedValue.ToString
                Else
                    lv_sw = "01"
                End If
                consulta = "select ubigeo_prov, provincia from adm_provincias where ubigeo_dpto = '" & lv_sw & "'"
                tabla = "adm_provincias"
                cbProvincia.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbProvincia.DisplayMember = "provincia"
                cbProvincia.ValueMember = "ubigeo_prov"
            Catch ex As Exception
                MessageBox.Show("Error cargando provincias, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            cbProvincia.SelectedValue = Mid(txtUbigeoDistrito.Text, 1, 4)
            Try
                If cbProvincia.SelectedValue.ToString <> "" Then
                    lv_sw = cbProvincia.SelectedValue.ToString
                Else
                    lv_sw = "0101"
                End If
                consulta = "select ubigeo_distrito, distrito from adm_distritos where ubigeo_prov = '" & lv_sw & "'"
                tabla = "adm_distritos"
                cbDistrito.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
                cbDistrito.DisplayMember = "distrito"
                cbDistrito.ValueMember = "ubigeo_distrito"
            Catch ex As Exception
                MessageBox.Show("Error cargando distritos, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            cbDistrito.SelectedValue = txtUbigeoDistrito.Text
        End If
    End Sub

    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        If lv_swcb = "0" Then
            Try
                If cbDepartamento.SelectedValue.ToString <> "" Then
                    lv_sw = cbDepartamento.SelectedValue.ToString
                Else
                    lv_sw = "01"
                End If
                consulta = "select ubigeo_prov, provincia from adm_provincias where ubigeo_dpto = '" & lv_sw & "'"
                tabla = "adm_provincias"
                cbProvincia.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbProvincia.DisplayMember = "provincia"
                cbProvincia.ValueMember = "ubigeo_prov"
            Catch ex As Exception
                MessageBox.Show("Error cargando provincias, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Try
                If cbProvincia.SelectedValue.ToString <> "" Then
                    lv_sw = cbProvincia.SelectedValue.ToString
                Else
                    lv_sw = "0101"
                End If
                consulta = "select ubigeo_distrito, distrito from adm_distritos where ubigeo_prov = '" & lv_sw & "'"
                tabla = "adm_distritos"
                cbDistrito.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
                cbDistrito.DisplayMember = "distrito"
                cbDistrito.ValueMember = "ubigeo_distrito"
            Catch ex As Exception
                MessageBox.Show("Error cargando distritos 1, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub cbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvincia.SelectedIndexChanged
        If lv_swcb = "0" Then
            Try
                If cbProvincia.SelectedValue.ToString <> "" Then
                    lv_sw = cbProvincia.SelectedValue.ToString
                Else
                    lv_sw = "0101"
                End If
                consulta = "select ubigeo_distrito, distrito from adm_distritos where ubigeo_prov = '" & lv_sw & "'"
                tabla = "adm_distritos"
                cbDistrito.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbDistrito.DisplayMember = "distrito"
                cbDistrito.ValueMember = "ubigeo_distrito"
            Catch ex As Exception
                MessageBox.Show("Error cargando distritos 2, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
End Class