Imports CapaEntidad
Imports CapaNegocios

Public Class frmclientes
    Dim consulta As String
    Dim tabla As String
    Dim n As Integer
    Dim lv_id As String
    Dim lv_operacion As String
    Dim lv_swcb As String
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
    Public Sub ExcelDinamico()
        If lv_operacion = "imprimir" Then
            Try
                cnAccesoDatos.ExcelDinamicoClientes(consulta)
                MessageBox.Show("Archivo Creado", "Clientes - Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error generando archivo, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            lv_operacion = Nothing
        End If
    End Sub

    Private Sub btdAgregar_Click(sender As Object, e As EventArgs) Handles btdAgregar.Click
        Close()
        AbrirFormInPanel(frmDetalleClientes)
        frmPrincipal.txtTitulo.Text = "Agregar Cliente"
        frmDetalleClientes.Text = "Agregar"
        frmDetalleClientes.cbIdIdentificacion.Visible = True
        frmDetalleClientes.cbDistrito.Visible = True
        frmDetalleClientes.cbProvincia.Visible = True
        frmDetalleClientes.cbDepartamento.Visible = True
        frmDetalleClientes.cbZonas.Visible = True
        frmDetalleClientes.txtNombre.Enabled = True
        frmDetalleClientes.txtNroIdentifiacion.Enabled = True
        frmDetalleClientes.txtDireccion.Enabled = True
        frmDetalleClientes.txtTelefonos.Enabled = True
        frmDetalleClientes.txtCorreo.Enabled = True
        frmDetalleClientes.txtWS.Enabled = True
        frmDetalleClientes.txtNombreContacto.Enabled = True
        frmDetalleClientes.txtTlfContacto.Enabled = True
        Try
            consulta = "SELECT max(idcliente) + 1 as ProxId FROM adm_clientes;"
            frmDetalleClientes.txtId.Text = Format(cnAccesoDatos.ValorTabla(consulta), "000000")
        Catch ex As Exception
            MessageBox.Show("Error consultado Proximo Id, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btdEditar_Click(sender As Object, e As EventArgs) Handles btdEditar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        lv_id = dgvResultado.Rows(n).Cells(0).Value
        Close()
        AbrirFormInPanel(frmDetalleClientes)
        frmPrincipal.txtTitulo.Text = "Actualizar Cliente"
        frmDetalleClientes.Text = "Actualizar"
        frmDetalleClientes.txtId.Text = lv_id
        frmDetalleClientes.txtNombre.Enabled = True
        frmDetalleClientes.txtNroIdentifiacion.Enabled = True
        frmDetalleClientes.txtDireccion.Enabled = True
        frmDetalleClientes.txtTelefonos.Enabled = True
        frmDetalleClientes.txtCorreo.Enabled = True
        frmDetalleClientes.txtWS.Enabled = True
        frmDetalleClientes.txtNombreContacto.Enabled = True
        frmDetalleClientes.txtTlfContacto.Enabled = True
    End Sub

    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        If dgvResultado.Rows(n).Cells(0).Value <> "" Then
            Dim result As DialogResult = MessageBox.Show("Desea Eliminar el Cliente " + dgvResultado.Rows(n).Cells(0).Value + "?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = "6" Then
                Try
                    consulta = "delete from adm_clientes where idCliente = '" & dgvResultado.Rows(n).Cells(0).Value & "';"
                    cnAccesoDatos.DMLTabla(consulta)
                Catch ex As Exception
                    MessageBox.Show("Error eliminando cliente, " + ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
                consulta = "select idcliente as id, nombre, nroidentificacion as identificacion from adm_clientes"
                tabla = "adm_clientes"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                dgvResultado.Columns(0).Width = 60
                dgvResultado.Columns(1).Width = 270
                dgvResultado.Columns(2).Width = 120
            End If
        End If
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        consulta = "select idcliente as id, nombre, nroidentificacion as identificacion from adm_clientes where nombre like '%" & txtBusca.Text & "%';"
        tabla = "adm_clientes"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
    End Sub

    Private Sub btdSalir_Click(sender As Object, e As EventArgs) Handles btdSalir.Click
        Close()
        AbrirFormInPanel(frmGrupoMaestros)
        frmPrincipal.txtTitulo.Text = "Maestros"
    End Sub

    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        If lv_swcb = "1" Then
            lv_operacion = "imprimir"
            ExcelDinamico()
        End If
    End Sub

    Private Sub frmclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_swcb = "0"
        consulta = "select idcliente as id, nombre, nroidentificacion as identificacion from adm_clientes"
        tabla = "adm_clientes"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
        dgvResultado.Columns(0).Width = 60
        dgvResultado.Columns(1).Width = 270
        dgvResultado.Columns(2).Width = 120
        ExcelDinamico()
        lv_swcb = "1"
    End Sub
End Class
