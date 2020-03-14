Imports CapaEntidad
Imports CapaNegocios
Imports Microsoft.Office.Interop.Excel
Public Class frmEmpresasEnvio
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
        cbDistrito.Visible = True
        cbProvincia.Visible = True
        cbDepartamento.Visible = True
        txtNombre.Enabled = True
        txtNombre.Text = ""
        txtUbigeoDistrito.Text = ""
        txtDepartamento.Text = ""
        txtProvincia.Text = ""
        txtDistrito.Text = ""
        lv_swcb = "1"
        Try
            consulta = "SELECT max(idEmpresaEnvio) + 1 as ProxId FROM adm_empresas_envio;"
            txtId.Text = Format(cnAccesoDatos.ValorTabla(consulta), "00")
        Catch ex As Exception
            MessageBox.Show("Error consultado Proximo Id, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            cbDistrito.Visible = True
            cbProvincia.Visible = True
            cbDepartamento.Visible = True
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
            lv_operacion = "Editar"
        Else
            MessageBox.Show("Por favor buscar un Courier", "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        If txtId.Text <> "" Then
            Try
                consulta = "delete from adm_empresas_envio where idEmpresaEnvio = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Courier Eliminado", "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtId.Text = ""
                txtNombre.Text = ""
                txtDistrito.Text = ""
                txtProvincia.Text = ""
                txtDepartamento.Text = ""
            Catch ex As Exception
                MessageBox.Show("Error eliminando Courier, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            MessageBox.Show("Por favor seleccionar un Courier", "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        frmBusca.txtTitulo.Text = "Busqueda de Courier"
        frmBusca.Text = "BusquedaCourier"
        frmBusca.Show()
    End Sub

    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        Try
            cnAccesoDatos.ExcelCourier()
            MessageBox.Show("Archivo Creado", "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generando archivo, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        cbDistrito.Visible = False
        cbProvincia.Visible = False
        cbDepartamento.Visible = False
        txtDistrito.Text = ""
        txtProvincia.Text = ""
        txtDepartamento.Text = ""
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
        cbDistrito.Visible = False
        cbProvincia.Visible = False
        cbDepartamento.Visible = False
        If lv_operacion = "Editar" Then
            Try
                consulta = "update adm_empresas_envio set Nombre = '" & txtNombre.Text & "', Ubigeo_Distrito = '" & txtUbigeoDistrito.Text & "' where idEmpresaEnvio = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Courier Actualizado", "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando Courier, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf lv_operacion = "Agregar" Then
            Try
                consulta = "SELECT count(*) as cant FROM adm_empresas_envio WHERE Nombre = '" & txtNombre.Text & "';"
                n = cnAccesoDatos.ValorTabla(consulta)
            Catch ex As Exception
                MessageBox.Show("Error consultando Courier existentes, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If n = 0 Then

                txtUbigeoDistrito.Text = cbDistrito.SelectedValue
                Try
                    consulta = "insert into adm_empresas_envio (idEmpresaEnvio,Nombre,Ubigeo_Distrito) " _
                             & "                        values ('" & txtId.Text & "','" & txtNombre.Text & "', '" & txtUbigeoDistrito.Text & "');"
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
                cbDistrito.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
                cbDistrito.DisplayMember = "distrito"
                cbDistrito.ValueMember = "ubigeo_distrito"
            Catch ex As Exception
                MessageBox.Show("Error cargando distritos 2, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
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
    End Sub
End Class