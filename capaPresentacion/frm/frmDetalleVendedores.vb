Imports CapaEntidad
Imports CapaNegocios
Public Class frmDetalleVendedores
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

    Private Sub btdCancela_Click(sender As Object, e As EventArgs)
        btdOk.Visible = False
        btdCancela.Visible = False
        txtId.Text = ""
        txtNombre.Text = ""
        txtNombre.Enabled = False

        txtDescripcionIdentificacion.Visible = True
        txtDescripcionIdentificacion.Text = ""
        cbIdIdentificacion.Visible = False
        txtNroIdentifiacion.Enabled = False
        txtNroIdentifiacion.Text = ""
        txtZona.Visible = True
        txtZona.Text = ""
        cbZonas.Visible = False
        txtCaja.Visible = True
        txtCaja.Text = ""
        cbCaja.Visible = False
    End Sub

    Private Sub btdOk_Click(sender As Object, e As EventArgs)
        btdOk.Visible = False
        btdCancela.Visible = False
        txtNombre.Enabled = False

        txtDescripcionIdentificacion.Visible = True
        cbIdIdentificacion.Visible = False
        txtNroIdentifiacion.Enabled = False
        txtZona.Visible = True
        cbZonas.Visible = False
        txtCaja.Visible = True
        cbCaja.Visible = False
        If lv_operacion = "Agregar" Then
            Try
                consulta = "SELECT count(*) as cant FROM adm_vendedor WHERE idVendedor = '" & txtId.Text & "';"
                n = cnAccesoDatos.ValorTabla(consulta)
            Catch ex As Exception
                MessageBox.Show("Error consultando Vendedores existentes, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If n = 0 Then
                Try
                    consulta = "insert into adm_vendedor (idVendedor, Nombres, idTpIdentificacion,  " _
                             & "                          NroIdentifiacion, idZona,idEmpresa, idUsuario, idCaja) " _
                             & "                  values ('" & txtId.Text & "','" & txtNombre.Text & "',  " _
                             & "                          '" & cbIdIdentificacion.SelectedValue & "','" & txtNroIdentifiacion.Text & "', " _
                             & "                          '" & cbZonas.SelectedValue & "','" & ceUsuarioActivo.idEmpresa & "', " _
                             & "                          '" & txtId.Text & "','" & cbCaja.SelectedValue & "');"
                    cnAccesoDatos.DMLTabla(consulta)
                    MessageBox.Show("Vendedor Agregado", "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        cnAccesoDatos.BusquedaVendedorxId(txtId.Text)
                        txtNombre.Text = ceVendedor.Nombres
                        txtIdIdentificacion.Text = ceVendedor.idTpIdentificacion
                        txtDescripcionIdentificacion.Text = ceVendedor.TpIdentificacion
                        txtNroIdentifiacion.Text = ceVendedor.NroIdentifiacion
                        txtIdZona.Text = ceVendedor.idZona
                        txtZona.Text = ceVendedor.Zona
                        txtIdCaja.Text = ceVendedor.idCaja
                        txtCaja.Text = ceVendedor.Caja
                    Catch ex As Exception
                        MessageBox.Show("Error consultando adm_vendedor, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Error insertando Vendedor, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("Vendedor ya Existe", "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf lv_operacion = "Editar" Then
            Try
                consulta = "update adm_vendedor " _
                         & "   Set Nombres = '" & txtNombre.Text & "', " _
                         & "       idTpIdentificacion = '" & cbIdIdentificacion.SelectedValue & "', " _
                         & "       NroIdentifiacion = '" & txtNroIdentifiacion.Text & "', " _
                         & "       idZona = '" & cbZonas.SelectedValue & "', " _
                         & "       idUsuario = '" & txtId.Text & "', " _
                         & "       idCaja = '" & cbCaja.SelectedValue & "' " _
                         & " where idVendedor = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Vendedor Actualizada", "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando Vendedor, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
    Private Sub btdSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
        AbrirFormInPanel(frmGrupoMaestros)
        frmPrincipal.txtTitulo.Text = "Maestros"
    End Sub
    Private Sub btdAgregar_Click(sender As Object, e As EventArgs)
        btdOk.Visible = True
        btdCancela.Visible = True
        txtNombre.Enabled = True
        txtNombre.Text = ""
        txtDescripcionIdentificacion.Visible = False
        cbIdIdentificacion.Visible = True
        txtNroIdentifiacion.Enabled = True
        txtNroIdentifiacion.Text = ""
        txtZona.Visible = False
        cbZonas.Visible = True
        txtCaja.Visible = False
        cbCaja.Visible = True
        Try
            consulta = "Select idTpIdentificacion, Descripcion from adm_tipos_identificacion"
            tabla = "adm_tipos_identificacion"
            cbIdIdentificacion.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) ' DS.Tables(0)
            cbIdIdentificacion.DisplayMember = "Descripcion"
            cbIdIdentificacion.ValueMember = "idTpIdentificacion"
        Catch ex As Exception
            MessageBox.Show("Error cargando tipos de identificacion, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            consulta = "Select idZona, Descripcion from adm_zonas where idEmpresa = '01'"
            tabla = "adm_zonas"
            cbZonas.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) ' DS.Tables(0)
            cbZonas.DisplayMember = "Descripcion"
            cbZonas.ValueMember = "idZona"
        Catch ex As Exception
            MessageBox.Show("Error cargando Zonas, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            consulta = "Select idCaja, Descripcion from adm_cajas where idEmpresa = '" & ceUsuarioActivo.idEmpresa & "';"
            tabla = "adm_cajas"
            cbCaja.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) ' DS.Tables(0)
            cbCaja.DisplayMember = "Descripcion"
            cbCaja.ValueMember = "idCaja"
        Catch ex As Exception
            MessageBox.Show("Error cargando Cajas, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        lv_operacion = "Agregar"
        frmBusca.txtTitulo.Text = "Busqueda de Vendedores"
        frmBusca.Text = "AgregaVendedor"
        frmBusca.Show()
    End Sub

    Private Sub btdEditar_Click(sender As Object, e As EventArgs)
        If txtId.Text <> "" Then
            btdOk.Visible = True
            btdCancela.Visible = True
            txtNombre.Enabled = True
            txtDescripcionIdentificacion.Visible = False
            cbIdIdentificacion.Visible = True
            txtNroIdentifiacion.Enabled = True
            txtZona.Visible = False
            cbZonas.Visible = True
            txtCaja.Visible = False
            cbCaja.Visible = True
            Try
                consulta = "Select idTpIdentificacion, Descripcion from adm_tipos_identificacion"
                tabla = "adm_tipos_identificacion"
                cbIdIdentificacion.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) ' DS.Tables(0)
                cbIdIdentificacion.DisplayMember = "Descripcion"
                cbIdIdentificacion.ValueMember = "idTpIdentificacion"
            Catch ex As Exception
                MessageBox.Show("Error cargando tipos de identificacion, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            cbIdIdentificacion.SelectedValue = txtIdIdentificacion.Text
            Try
                consulta = "Select idZona, Descripcion from adm_zonas where idEmpresa = '01'"
                tabla = "adm_zonas"
                cbZonas.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) ' DS.Tables(0)
                cbZonas.DisplayMember = "Descripcion"
                cbZonas.ValueMember = "idZona"
            Catch ex As Exception
                MessageBox.Show("Error cargando Zonas, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            cbZonas.SelectedValue = txtIdZona.Text
            Try
                consulta = "Select idCaja, Descripcion from adm_cajas where idEmpresa = '" & ceUsuarioActivo.idEmpresa & "';"
                tabla = "adm_cajas"
                cbCaja.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) ' DS.Tables(0)
                cbCaja.DisplayMember = "Descripcion"
                cbCaja.ValueMember = "idCaja"
            Catch ex As Exception
                MessageBox.Show("Error cargando Cajas, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            cbCaja.SelectedValue = txtIdCaja.Text
            lv_operacion = "Editar"
        Else
            MessageBox.Show("Por favor seleccionar un Vendedor", "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Try
            cnAccesoDatos.BusquedaVendedorxId(txtId.Text)
            txtNombre.Text = ceVendedor.Nombres
            txtIdIdentificacion.Text = ceVendedor.idTpIdentificacion
            txtDescripcionIdentificacion.Text = ceVendedor.TpIdentificacion
            txtNroIdentifiacion.Text = ceVendedor.NroIdentifiacion
            txtIdZona.Text = ceVendedor.idZona
            txtZona.Text = ceVendedor.Zona
            txtIdCaja.Text = ceVendedor.idCaja
            txtCaja.Text = ceVendedor.Caja
        Catch ex As Exception
            MessageBox.Show("Error consultando adm_vendedor, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class