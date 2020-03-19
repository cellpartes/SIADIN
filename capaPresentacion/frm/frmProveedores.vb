Imports CapaEntidad
Imports CapaNegocios

Public Class frmProveedores
    Dim consulta As String
    Dim tabla As String
    Dim n As Integer
    Dim lv_id As String
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
        Close()
        AbrirFormInPanel(frmDetalleProveedores)
        frmPrincipal.txtTitulo.Text = "Agregar Proveedor"
        frmDetalleProveedores.Text = "Agregar"
        frmDetalleProveedores.cbIdIdentificacion.Visible = True
        frmDetalleProveedores.cbDistrito.Visible = True
        frmDetalleProveedores.cbProvincia.Visible = True
        frmDetalleProveedores.cbDepartamento.Visible = True
        frmDetalleProveedores.cbZonas.Visible = True
        frmDetalleProveedores.txtNombre.Enabled = True
        frmDetalleProveedores.txtNroIdentifiacion.Enabled = True
        frmDetalleProveedores.txtDireccion.Enabled = True
        frmDetalleProveedores.txtTelefonos.Enabled = True
        frmDetalleProveedores.txtCorreo.Enabled = True
        frmDetalleProveedores.txtWS.Enabled = True
        frmDetalleProveedores.txtNombreContacto.Enabled = True
        frmDetalleProveedores.txtTlfContacto.Enabled = True

        Try
            consulta = "SELECT max(idproveedor) + 1 as ProxId FROM adm_proveedores;"
            frmDetalleProveedores.txtId.Text = Format(cnAccesoDatos.ValorTabla(consulta), "000000")
        Catch ex As Exception
            MessageBox.Show("Error buscando proximo Id, " + ex.Message, "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        AbrirFormInPanel(frmDetalleProveedores)
        frmPrincipal.txtTitulo.Text = "Actualizar Proveedor"
        frmDetalleProveedores.Text = "Actualizar"
        frmDetalleProveedores.txtId.Text = lv_id
        frmDetalleProveedores.txtNombre.Enabled = True
        frmDetalleProveedores.txtNroIdentifiacion.Enabled = True
        frmDetalleProveedores.txtDireccion.Enabled = True
        frmDetalleProveedores.txtTelefonos.Enabled = True
        frmDetalleProveedores.txtCorreo.Enabled = True
        frmDetalleProveedores.txtWS.Enabled = True
        frmDetalleProveedores.txtNombreContacto.Enabled = True
        frmDetalleProveedores.txtTlfContacto.Enabled = True
    End Sub
    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        If dgvResultado.Rows(n).Cells(0).Value <> "" Then
            Dim result As DialogResult = MessageBox.Show("Desea Eliminar el Proveedor " + dgvResultado.Rows(n).Cells(0).Value + "?", "Porveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = "6" Then
                Try
                    consulta = "delete from adm_proveedores where idProveedor = '" & dgvResultado.Rows(n).Cells(0).Value & "';"
                    cnAccesoDatos.DMLTabla(consulta)
                    MessageBox.Show("Proveedor Eliminado", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error eliminando proveedor, " + ex.Message, "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                consulta = "select idProveedor as id, nombre, nroidentificacion as identificacion from adm_proveedores;"
                tabla = "adm_proveedores"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                dgvResultado.Columns(0).Width = 60
                dgvResultado.Columns(1).Width = 270
                dgvResultado.Columns(2).Width = 120
            End If
        End If
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        consulta = "select idProveedor as id, nombre, nroidentificacion as identificacion from adm_proveedores where nombre like '%" & txtBusca.Text & "%';"
        tabla = "adm_proveedores"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
    End Sub

    Private Sub btdSalir_Click(sender As Object, e As EventArgs) Handles btdSalir.Click
        Close()
        AbrirFormInPanel(frmGrupoMaestros)
        frmPrincipal.txtTitulo.Text = "Maestros"
    End Sub
    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        Try
            cnAccesoDatos.ExcelProveedores()
            MessageBox.Show("Archivo Creado", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generando archivo, " + ex.Message, "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    'Private Sub cbBuscar_KeyPress(sender As Object, e As KeyPressEventArgs)
    '   If Asc(e.KeyChar) = 13 Then
    '       btdOk_Click(btdOk, e)
    '   End If
    'End Sub
    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta = "select idProveedor as id, nombre, nroidentificacion as identificacion from adm_proveedores;"
        tabla = "adm_proveedores"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
        dgvResultado.Columns(0).Width = 60
        dgvResultado.Columns(1).Width = 270
        dgvResultado.Columns(2).Width = 120
    End Sub
End Class
