﻿Imports CapaEntidad
Imports CapaNegocios

Public Class frmclientes
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

    Private Sub btdAgregar_Click(sender As Object, e As EventArgs) Handles btdAgregar.Click
        btdAgregar.Enabled = False
        btdEditar.Enabled = False
        btdEliminar.Enabled = False
        btdBuscar.Enabled = False
        btdImprimir.Enabled = False
        btdSalir.Enabled = False
        btdOk.Visible = True
        btdCancela.Visible = True
        cbIdIdentificacion.Visible = True
        cbDistrito.Visible = True
        cbProvincia.Visible = True
        cbDepartamento.Visible = True
        cbZonas.Visible = True
        txtNombre.Enabled = True
        txtNroIdentifiacion.Enabled = True
        txtDireccion.Enabled = True
        txtTelefonos.Enabled = True
        txtCorreo.Enabled = True
        txtWS.Enabled = True
        txtNombreContacto.Enabled = True
        txtTlfContacto.Enabled = True
        txtNombre.Text = ""
        txtNroIdentifiacion.Text = ""
        txtDireccion.Text = ""
        txtTelefonos.Text = ""
        txtWS.Text = ""
        txtCorreo.Text = ""
        txtTlfContacto.Text = ""
        txtNombreContacto.Text = ""
        txtUbigeoDistrito.Text = ""
        txtIdIdentificacion.Text = ""

        txtDescripcionIdentificacion.Text = ""
        txtDepartamento.Text = ""
        txtProvincia.Text = ""
        txtDistrito.Text = ""
        txtZona.Text = ""
        lv_swcb = "1"
        Try
            consulta = "SELECT max(idcliente) + 1 as ProxId FROM adm_clientes;"
            txtId.Text = Format(cnAccesoDatos.ValorTabla(consulta), "000000")
        Catch ex As Exception
            MessageBox.Show("Error consultado Proximo Id, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            consulta = "Select idTpIdentificacion, Descripcion from adm_tipos_identificacion"
            tabla = "adm_tipos_identificacion"
            cbIdIdentificacion.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) ' DS.Tables(0)
            cbIdIdentificacion.DisplayMember = "Descripcion"
            cbIdIdentificacion.ValueMember = "idTpIdentificacion"
        Catch ex As Exception
            MessageBox.Show("Error cargando tipos de identificacion, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Try
            consulta = "Select idZona, Descripcion from adm_zonas where idEmpresa = '01'"
            tabla = "adm_zonas"
            cbZonas.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) ' DS.Tables(0)
            cbZonas.DisplayMember = "Descripcion"
            cbZonas.ValueMember = "idZona"
        Catch ex As Exception
            MessageBox.Show("Error cargando tipos de identificacion, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            txtNroIdentifiacion.Enabled = True
            txtDireccion.Enabled = True
            txtTelefonos.Enabled = True
            txtCorreo.Enabled = True
            txtWS.Enabled = True
            txtNombreContacto.Enabled = True
            txtTlfContacto.Enabled = True
            lv_operacion = "Editar"
        Else
            MessageBox.Show("Por favor buscar un Clientes", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
        txtNroIdentifiacion.Enabled = False
        txtDireccion.Enabled = False
        txtTelefonos.Enabled = False
        txtCorreo.Enabled = False
        txtWS.Enabled = False
        txtNombreContacto.Enabled = False
        txtTlfContacto.Enabled = False
        cbIdIdentificacion.Visible = False
        cbDistrito.Visible = False
        cbProvincia.Visible = False
        cbDepartamento.Visible = False
        cbZonas.Visible = False
        If lv_operacion = "Editar" Then
            Try
                consulta = "update adm_clientes " _
                         & "   Set Nombre = '" & txtNombre.Text & "', " _
                         & "       NroIdentificacion = '" & txtNroIdentifiacion.Text & "', " _
                         & "       Direccion = '" & txtDireccion.Text & "', " _
                         & "       Telefonos = '" & txtTelefonos.Text & "', " _
                         & "       email = '" & txtCorreo.Text & "', " _
                         & "       WhatsApp = '" & txtWS.Text & "', " _
                         & "       NombreContacto = '" & txtNombreContacto.Text & "', " _
                         & "       TelefonoContacto = '" & txtTlfContacto.Text & "' " _
                         & " where idCliente = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Cliente Actualizado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando cliente, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf lv_operacion = "Agregar" Then
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
                             & "                             Telefonos,email,WhatsApp,NombreContacto,TelefonoContacto, idZona) " _
                             & "                     values ('" & txtId.Text & "','" & txtNombre.Text & "', '" & txtIdIdentificacion.Text & "','" & txtNroIdentifiacion.Text & "', " _
                             & "                             '" & txtUbigeoDistrito.Text & "','" & txtDireccion.Text & "', '" & txtTelefonos.Text & "',  " _
                             & "                             '" & txtCorreo.Text & "', '" & txtWS.Text & "','" & txtNombreContacto.Text & "', " _
                             & "                             '" & txtTlfContacto.Text & "', '" & cbZonas.SelectedValue & "');"
                    cnAccesoDatos.DMLTabla(consulta)
                    MessageBox.Show("Cliente Agregado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                        MessageBox.Show("Error mostrando cliente, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Error insertando cliente, " + ex.Message, "Clientes - Agregar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("Cliente ya Existe", "Clientes - Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'If Me.Text = "AgregaClientesVentas" Then
        '    frmVentas.txtId.Text = txtId.Text
        '    Close()
        'End If
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
        txtNombre.Enabled = False
        txtNroIdentifiacion.Enabled = False
        txtDireccion.Enabled = False
        txtZona.Enabled = False
        txtTelefonos.Enabled = False
        txtCorreo.Enabled = False
        txtWS.Enabled = False
        txtNombreContacto.Enabled = False
        txtTlfContacto.Enabled = False
        cbIdIdentificacion.Visible = False
        cbDistrito.Visible = False
        cbProvincia.Visible = False
        cbDepartamento.Visible = False
        cbZonas.Visible = False
        If Me.Text = "AgregaClientesVentas" Then
            Close()
        End If
    End Sub

    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        If txtId.Text <> "" Then
            Try
                consulta = "delete from adm_clientes where idCliente = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Cliente Eliminado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtId.Text = ""
                txtNombre.Text = ""
                txtDescripcionIdentificacion.Text = ""
                txtNroIdentifiacion.Text = ""
                txtDireccion.Text = ""
                txtDistrito.Text = ""
                txtProvincia.Text = ""
                txtDepartamento.Text = ""
                txtCorreo.Text = ""
                txtTelefonos.Text = ""
                txtWS.Text = ""
                txtNombreContacto.Text = ""
                txtTlfContacto.Text = ""
                txtZona.Text = ""
            Catch ex As Exception
                MessageBox.Show("Error eliminando cliente, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            MessageBox.Show("Por favor seleccionar un Cliente", "Clientes - btdEliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        frmBusca.txtTitulo.Text = "Busqueda de Cliente"
        frmBusca.Text = "BusquedaClientes"
        frmBusca.Show()
    End Sub

    Private Sub btdSalir_Click(sender As Object, e As EventArgs) Handles btdSalir.Click
        Close()
        AbrirFormInPanel(frmGrupoMaestros)
        frmPrincipal.txtTitulo.Text = "Maestros"
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

    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        Try
            cnAccesoDatos.ExcelClientes()
            MessageBox.Show("Archivo Creado", "Clientes - Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generando archivo, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
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
    End Sub
End Class
