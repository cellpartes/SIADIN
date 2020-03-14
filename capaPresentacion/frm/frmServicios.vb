Imports CapaEntidad
Imports CapaNegocios
Public Class frmServicios
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
        txtDescripcion.Text = ""
        txtDescripcion.Enabled = False
        txtMonto.Text = ""
        txtMonto.Enabled = False
        txtFechaUltMov.Text = ""
        txtFechaUltMov.Enabled = False
        txtActivo.Visible = True
        txtActivo.Text = ""
        cbActivo.Visible = False
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
        txtDescripcion.Enabled = False
        txtMonto.Enabled = False
        txtFechaUltMov.Enabled = False
        txtActivo.Visible = True
        cbActivo.Visible = False
        If lv_operacion = "Agregar" Then
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
                             & "                   values ('" & txtId.Text & "','" & ceUsuarioActivo.idEmpresa & "', " _
                             & "                           '" & txtMonto.Text & "','" & Mid(cbActivo.Text, 1, 1) & "', " _
                             & "                           '" & txtFechaUltMov.Text & "');"
                    cnAccesoDatos.DMLTabla(consulta)
                    MessageBox.Show("Servicio Agregado", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        cnAccesoDatos.BusquedaServicioxId(txtId.Text)
                        txtDescripcion.Text = ceServicios.Descripcion
                        txtMonto.Text = ceServicios.Monto
                        txtActivo.Text = ceServicios.Activo
                        txtFechaUltMov.Text = ceServicios.FechaUltMov
                    Catch ex As Exception
                        MessageBox.Show("Error consultando adm_servicios, " + ex.Message, "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Error insertando Servicio, " + ex.Message, "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("Servicio ya Existe", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf lv_operacion = "Editar" Then
            Try
                consulta = "update adm_servicios " _
                         & "   Set monto = '" & txtMonto.Text & "', " _
                         & "       Activo = '" & Mid(cbActivo.Text, 1, 1) & "' " _
                         & " where idArticulo = '" & txtId.Text & "' and idEmpresa = '" & ceUsuarioActivo.idEmpresa & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Servicio Actualizado", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando Servicio, " + ex.Message, "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
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
        txtId.Text = ""
        txtDescripcion.Text = ""
        txtDescripcion.Enabled = True
        txtMonto.Text = ""
        txtMonto.Enabled = True
        txtFechaUltMov.Text = ""
        txtActivo.Visible = False
        txtActivo.Text = ""
        cbActivo.Visible = True
        cbActivo.SelectedValue = 1
        lv_operacion = "Agregar"
        frmBuscaArticulos.Text = "AgregaServicio"
        frmBuscaArticulos.Show()
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
            txtDescripcion.Enabled = True
            txtMonto.Enabled = True
            txtActivo.Visible = False
            cbActivo.Visible = True
            lv_operacion = "Editar"
        Else
            MessageBox.Show("Por favor seleccionar un Servicio", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        If txtId.Text <> "" Then
            Try
                consulta = "delete from adm_servicios where idArticulo = '" & txtId.Text & "' and idEmpresa = '" & ceUsuarioActivo.idEmpresa & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Servicio Eliminado", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtId.Text = ""
                txtDescripcion.Text = ""
                txtMonto.Text = ""
                txtActivo.Text = ""
                txtFechaUltMov.Text = ""
            Catch ex As Exception
                MessageBox.Show("Error eliminando Servicio, " + ex.Message, "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            MessageBox.Show("Por favor seleccionar un Servicio", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        Try
            cnAccesoDatos.ExcelServicios()
            MessageBox.Show("Archivo Creado", "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generando archivo, " + ex.Message, "Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        frmBuscaArticulos.Text = "BuscaServicio"
        frmBuscaArticulos.Show()
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