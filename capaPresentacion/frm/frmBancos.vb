Imports CapaEntidad
Imports CapaNegocios
Public Class frmBancos
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
        txtIdCuenta.Text = ""
        txtNombre.Text = ""
        txtTpCuenta.Text = ""
        txtNroCuenta.Text = ""
        txtCtaInterBancaria.Text = ""
        txtId.Enabled = False
        txtNombre.Enabled = False
        txtNroCuenta.Enabled = False
        txtCtaInterBancaria.Enabled = False
        txtTpCuenta.Visible = True
        cbTpCuenta.Visible = False
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
        txtId.Enabled = False
        txtNombre.Enabled = False
        txtNroCuenta.Enabled = False
        txtCtaInterBancaria.Enabled = False
        txtTpCuenta.Visible = True
        cbTpCuenta.Visible = False
        If lv_operacion = "Agregar" Then
            Try
                consulta = "SELECT count(*) as cant FROM adm_cuentas_banco WHERE idBanco = '" & txtId.Text & "' and NroCuenta = '" & txtNroCuenta.Text & "';"
                n = cnAccesoDatos.ValorTabla(consulta)
            Catch ex As Exception
                MessageBox.Show("Error consultando Cuentas existentes, " + ex.Message, "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If n = 0 Then
                Try
                    consulta = "insert into adm_cuentas_banco (idCuenta,idBanco,TipoCuenta,NroCuenta,  " _
                             & "                               CuentaInterbancaria) " _
                             & "                       values ('" & txtIdCuenta.Text & "','" & txtId.Text & "', " _
                             & "                               '" & cbTpCuenta.Text & "','" & txtNroCuenta.Text & "', " _
                             & "                               '" & txtCtaInterBancaria.Text & "');"
                    cnAccesoDatos.DMLTabla(consulta)
                    MessageBox.Show("Cuenta Agregada", "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        cnAccesoDatos.BusquedaCtaBancoxId(txtIdCuenta.Text)
                        txtId.Text = ceCuentas_Banco.idBanco
                        txtNombre.Text = ceCuentas_Banco.Banco
                        txtTpCuenta.Text = ceCuentas_Banco.TipoCuenta
                        txtNroCuenta.Text = ceCuentas_Banco.NroCuenta
                        txtCtaInterBancaria.Text = ceCuentas_Banco.CuentaInterbancaria
                    Catch ex As Exception
                        MessageBox.Show("Error consultando adm_cuentas_banco, " + ex.Message, "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Error insertando Cuenta, " + ex.Message, "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("Cuenta ya Existe", "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf lv_operacion = "Editar" Then
            Try
                consulta = "update adm_cuentas_banco " _
                         & "   Set NroCuenta = '" & txtNroCuenta.Text & "', " _
                         & "       CuentaInterbancaria = '" & txtCtaInterBancaria.Text & "' " _
                         & " where idCuenta = '" & txtIdCuenta.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Cuenta Actualizada", "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando Cuenta, " + ex.Message, "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
    Private Sub btdSalir_Click(sender As Object, e As EventArgs) Handles btdSalir.Click
        Me.Close()
        AbrirFormInPanel(frmGrupoMaestros)
        frmPrincipal.txtTitulo.Text = "Maestros"
    End Sub
    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        Try
            cnAccesoDatos.ExcelCtasBancos()
            MessageBox.Show("Archivo Creado", "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generando archivo, " + ex.Message, "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        frmBusca.txtTitulo.Text = "Busqueda de Categoria"
        frmBusca.Text = "BuscaCtasBancos"
        frmBusca.Show()
    End Sub

    Private Sub txtIdCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtIdCuenta.TextChanged
        Try
            cnAccesoDatos.BusquedaCtaBancoxId(txtIdCuenta.Text)
            txtId.Text = ceCuentas_Banco.idBanco
            txtNombre.Text = ceCuentas_Banco.Banco
            txtTpCuenta.Text = ceCuentas_Banco.TipoCuenta
            txtNroCuenta.Text = ceCuentas_Banco.NroCuenta
            txtCtaInterBancaria.Text = ceCuentas_Banco.CuentaInterbancaria
        Catch ex As Exception
            MessageBox.Show("Error consultando adm_cuentas_banco, " + ex.Message, "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        If txtId.Text <> "" Then
            Try
                consulta = "delete from adm_cuentas_banco where idcuenta = '" & txtIdCuenta.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Cuenta Eliminada", "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtId.Text = ""
                txtNombre.Text = ""
                txtIdCuenta.Text = ""
                txtTpCuenta.Text = ""
                txtNroCuenta.Text = ""
                txtCtaInterBancaria.Text = ""
            Catch ex As Exception
                MessageBox.Show("Error eliminando Cuenta, " + ex.Message, "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            MessageBox.Show("Por favor seleccionar una Cuenta", "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
            txtNroCuenta.Enabled = True
            txtCtaInterBancaria.Enabled = True
            lv_operacion = "Editar"
        Else
            MessageBox.Show("Por favor seleccionar una Cuenta", "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
        txtNroCuenta.Enabled = True
        txtCtaInterBancaria.Enabled = True
        txtId.Text = ""
        txtNombre.Text = ""
        txtIdCuenta.Text = ""
        txtNroCuenta.Text = ""
        txtCtaInterBancaria.Text = ""
        Try
            consulta = "SELECT max(idcuenta) + 1 as ProxId FROM adm_cuentas_banco;"
            txtIdCuenta.Text = Format(cnAccesoDatos.ValorTabla(consulta), "00")
        Catch ex As Exception
            MessageBox.Show("Error consultado Proximo Id, " + ex.Message, "Cuentas Bancarias", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        txtTpCuenta.Visible = False
        cbTpCuenta.Visible = True
        frmBusca.Text = "AgregaCtasBancos"
        frmBusca.Show()
        lv_operacion = "Agregar"
    End Sub
End Class