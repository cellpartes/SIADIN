Imports CapaEntidad
Imports CapaNegocios
Public Class frmDetalleClientes
    Dim lv_sw As String
    Dim lv_swcb As String
    Dim consulta As String
    Dim tabla As String
    Dim n As Integer
    Dim cnAccesoDatos As New cnAccesoDatos
    Private Sub AbrirFormInPanel(frmhijo As Object)
        If frmPrincipal.PanelContenedor.Controls.Count > 0 Then
            frmPrincipal.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = frmhijo
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        frmPrincipal.PanelContenedor.Controls.Add(fh)
        frmPrincipal.PanelContenedor.Tag = fh
        fh.Show()
    End Sub
    Private Sub btdCancela_Click(sender As Object, e As EventArgs) Handles btdCancela.Click
        Close()
        AbrirFormInPanel(frmclientes)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Clientes"
    End Sub

    Private Sub btdOk_Click(sender As Object, e As EventArgs) Handles btdOk.Click
        If Me.Text = "Actualizar" Then
            Try
                consulta = "update adm_clientes " _
                         & "    Set Nombre = '" & txtNombre.Text & "', " _
                         & "        NroIdentificacion = '" & txtNroIdentifiacion.Text & "', " _
                         & "        Direccion = '" & txtDireccion.Text & "', " _
                         & "        Telefonos = '" & txtTelefonos.Text & "', " _
                         & "        email = '" & txtCorreo.Text & "', " _
                         & "        Whatsapp = '" & txtWS.Text & "', " _
                         & "        NombreContacto = '" & txtNombreContacto.Text & "'," _
                         & "        TelefonoContacto = '" & txtTlfContacto.Text & "' " _
                         & " where idCliente = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Cliente Actualizado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando cliente, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        If Me.Text = "Agregar" Then
            Try
                consulta = "SELECT count(*) as cant FROM adm_clientes WHERE idTpIdentificacion = '" & cbIdIdentificacion.SelectedValue & "' and NroIdentificacion = '" & txtNroIdentifiacion.Text & "';"
                n = cnAccesoDatos.ValorTabla(consulta)
            Catch ex As Exception
                MessageBox.Show("Error consultando Clientes existentes, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If n = 0 Then
                txtIdIdentificacion.Text = cbIdIdentificacion.SelectedValue
                txtUbigeoDistrito.Text = cbDistrito.SelectedValue
                Try
                    consulta = "insert into adm_clientes (idCliente,Nombre,IdTpIdentificacion,NroIdentificacion,Ubigeo_Distrito,Direccion, " _
                             & "                            Telefonos,email,Whatsapp,NombreContacto,TelefonoContacto, idZona) " _
                             & "                    values('" & txtId.Text & "','" & txtNombre.Text & "','" & txtIdIdentificacion.Text & "','" & txtNroIdentifiacion.Text & "'," _
                             & "                           '" & txtUbigeoDistrito.Text & "','" & txtDireccion.Text & "','" & txtTelefonos.Text & "', " _
                             & "                           '" & txtCorreo.Text & "','" & txtWS.Text & "','" & txtNombreContacto.Text & "'," _
                             & "                           '" & txtTlfContacto.Text & "','" & cbZonas.SelectedValue & "');"
                    cnAccesoDatos.DMLTabla(consulta)
                    MessageBox.Show("Cliente Agregado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error insertando cliente, " + ex.Message, "Clientes - Agregar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("Cliente ya Existe", "Clientes - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Close()
        AbrirFormInPanel(frmclientes)
        frmPrincipal.txtTitulo.Text = "Mantenimiento de Clientes"
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        lv_swcb = "1"
        Try
            cnAccesoDatos.BusquedaClientexId(txtId.Text)
            txtNombre.Text = ceClientes.Nombre
            txtIdIdentificacion.Text = ceClientes.IdTpIdentificacion
            txtDescripcionIdentificacion.Text = ceClientes.TpIdentificacion
            txtNroIdentifiacion.Text = ceClientes.NroIdentificacion
            txtUbigeoDistrito.Text = ceClientes.Ubigeo_Distrito
            txtDireccion.Text = ceClientes.Direccion
            txtDepartamento.Text = ceClientes.Departamento
            txtProvincia.Text = ceClientes.Provincia
            txtDistrito.Text = ceClientes.Distrito
            txtTelefonos.Text = ceClientes.Telefonos
            txtCorreo.Text = ceClientes.email
            txtWS.Text = ceClientes.WhatsApp
            txtNombreContacto.Text = ceClientes.NombreContacto
            txtTlfContacto.Text = ceClientes.TelefonoContacto
            txtZona.Text = ceClientes.Zona
        Catch ex As Exception
            MessageBox.Show("Error consultando adm_clientes, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            consulta = "Select idTpIdentificacion, Descripcion from adm_tipos_identificacion"
            tabla = "adm_tipos_identificacion"
            cbIdIdentificacion.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbIdIdentificacion.DisplayMember = "Descripcion"
            cbIdIdentificacion.ValueMember = "idTpIdentificacion"
        Catch ex As Exception
            MessageBox.Show("Error cargando tipos de identificacion, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            consulta = "Select ubigeo_dpto, departamento from adm_departamentos"
            tabla = "adm_departamentos"
            cbDepartamento.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
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
            cbDistrito.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbDistrito.DisplayMember = "distrito"
            cbDistrito.ValueMember = "ubigeo_distrito"
        Catch ex As Exception
            MessageBox.Show("Error cargando distritos 3, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            consulta = "Select idZona, Descripcion from adm_zonas where idEmpresa = '01'"
            tabla = "adm_zonas"
            cbZonas.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbZonas.DisplayMember = "Descripcion"
            cbZonas.ValueMember = "idZona"
        Catch ex As Exception
            MessageBox.Show("Error cargando tipos de identificacion, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        lv_swcb = "0"
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
                cbDistrito.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
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