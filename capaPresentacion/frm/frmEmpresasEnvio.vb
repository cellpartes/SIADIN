Imports CapaEntidad
Imports CapaNegocios
Imports Microsoft.Office.Interop.Excel
Public Class frmEmpresasEnvio
    Dim consulta As String
    Dim tabla As String
    Dim n As Integer
    Dim lv_id As String
    Dim lv_swcb As String
    Dim lv_operacion As String
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
                cnAccesoDatos.ExcelDinamicoCourier(consulta)
                MessageBox.Show("Archivo Creado", "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error generando archivo, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            lv_operacion = Nothing
        End If
    End Sub
    Private Sub btdSalir_Click(sender As Object, e As EventArgs) Handles btdSalir.Click
        Me.Close()
        AbrirFormInPanel(frmGrupoMaestros)
        frmPrincipal.txtTitulo.Text = "Maestros"
    End Sub

    Private Sub btdAgregar_Click(sender As Object, e As EventArgs) Handles btdAgregar.Click
        Close()
        AbrirFormInPanel(frmDetalleEmpresasEnvio)
        frmPrincipal.txtTitulo.Text = "Agregar Courier"

        frmDetalleEmpresasEnvio.cbDistrito.Visible = True
        frmDetalleEmpresasEnvio.cbProvincia.Visible = True
        frmDetalleEmpresasEnvio.cbDepartamento.Visible = True
        frmDetalleEmpresasEnvio.txtNombre.Enabled = True
        frmDetalleEmpresasEnvio.Text = "Agregar"
        Try
            consulta = "SELECT max(idEmpresaEnvio) + 1 as ProxId FROM adm_empresas_envio;"
            frmDetalleEmpresasEnvio.txtId.Text = Format(cnAccesoDatos.ValorTabla(consulta), "00")
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
        AbrirFormInPanel(frmDetalleEmpresasEnvio)
        frmPrincipal.txtTitulo.Text = "Actualizar Courier"
        frmDetalleEmpresasEnvio.Text = "Actualizar"
        frmDetalleEmpresasEnvio.txtId.Text = lv_id
        frmDetalleEmpresasEnvio.txtId.Enabled = False
        frmDetalleEmpresasEnvio.txtNombre.Enabled = True
        frmDetalleEmpresasEnvio.cbDistrito.Visible = True
        frmDetalleEmpresasEnvio.cbProvincia.Visible = True
        frmDetalleEmpresasEnvio.cbDepartamento.Visible = True
    End Sub

    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        If dgvResultado.Rows(n).Cells(0).Value <> "" Then
            Dim result As DialogResult = MessageBox.Show("Desea Eliminar la Marca " + dgvResultado.Rows(n).Cells(0).Value + "?", "Marcas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = "6" Then
                Try
                    consulta = "delete from adm_empresas_envio where idEmpresaEnvio = '" & dgvResultado.Rows(n).Cells(0).Value & "';"
                    cnAccesoDatos.DMLTabla(consulta)
                Catch ex As Exception
                    MessageBox.Show("Error eliminando Courier, " + ex.Message, "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
                MessageBox.Show("Courier Eliminado", "Courier", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consulta = "SELECT a.idEmpresaEnvio as ID, a.Nombre, c.Distrito as Ubicacion FROM adm_empresas_envio a INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito;"
                tabla = "adm_empresas_envio"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                dgvResultado.Columns(0).Width = 70
                dgvResultado.Columns(1).Width = 160
                dgvResultado.Columns(2).Width = 220
            End If
        End If
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        consulta = "SELECT a.idEmpresaEnvio as ID, a.Nombre, c.Distrito as Ubicacion FROM adm_empresas_envio a INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito where a.nombre like '%" & txtBusca.Text & "%';"
        tabla = "adm_empresas_envio"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
    End Sub

    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        If lv_swcb = "1" Then
            lv_operacion = "imprimir"
            ExcelDinamico()
        End If
    End Sub

    Private Sub frmEmpresasEnvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_swcb = "0"
        consulta = "SELECT a.idEmpresaEnvio as ID, a.Nombre, c.Distrito as Ubicacion FROM adm_empresas_envio a INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito;"
        tabla = "adm_empresas_envio"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
        dgvResultado.Columns(0).Width = 70
        dgvResultado.Columns(1).Width = 160
        dgvResultado.Columns(2).Width = 220
        ExcelDinamico()
        lv_swcb = "1"
    End Sub
End Class