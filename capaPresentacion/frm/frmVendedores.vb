Imports CapaEntidad
Imports CapaNegocios
Imports System.IO
Public Class frmVendedores
    Dim lv_operacion As String
    Dim drA As System.Data.IDataReader
    Dim drE As System.Data.IDataReader
    Dim lv_sw As String
    Dim lv_swcb As String
    Dim lv_busqueda As String
    Dim consulta As String
    Dim tabla As String
    Dim n As Integer
    Dim lv_id As String
    Dim sql_ins As String
    Dim ld_fecha As String
    Dim ln_cant As Integer
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
    Public Sub MuestraTablas()
        Dim lv_Zonas As String
        Dim lv_Empresa As String
        Dim lv_text As String
        If cbZonas.SelectedValue = "00" Then
            lv_Zonas = "a.idZona = a.idZona"
        Else
            lv_Zonas = "a.idZona = '" & cbZonas.SelectedValue & "'"
        End If
        If cbEmpresa.SelectedValue = "00" Then
            lv_Empresa = "a.idEmpresa = a.idEmpresa"
        Else
            lv_Empresa = "a.idEmpresa = '" & cbEmpresa.SelectedValue & "'"
        End If
        If txtBusca.Text = "" Then
            lv_text = ";"
        Else
            lv_text = " and a.Nombres Like '%" & txtBusca.Text & "%';"
        End If
        Try
            consulta = "SELECT a.idVendedor, a.Nombres, b.Descripcion as TipoIDentificacion, a.NroIdentifiacion, c.Descripcion as Zona, " _
                            & "d.Nombre as Empresa, e.descripcion as Caja " _
                       & "FROM adm_vendedor a " _
                      & "INNER JOIN adm_tipos_identificacion b on a.IdTpIdentificacion = b.IdTpIdentificacion " _
                      & "INNER JOIN adm_zonas c on a.idZona = c.idZona " _
                      & "INNER JOIN adm_empresas d on a.idEmpresa = d.idEmpresa " _
                      & "INNER JOIN adm_cajas e on a.idcaja = e.idcaja " _
                      & "where " + lv_Empresa + " and " + lv_Zonas + lv_text
            tabla = "adm_vendedor"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 90
            dgvResultado.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvResultado.Columns(1).Width = 320
            dgvResultado.Columns(2).Width = 300
            dgvResultado.Columns(3).Width = 120
            dgvResultado.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvResultado.Columns(4).Width = 150
            dgvResultado.Columns(5).Width = 150
            dgvResultado.Columns(6).Width = 150
        Catch ex As Exception
            MessageBox.Show("Error cargando Vendedores, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        If lv_operacion = "imprimir" Then
            Try
                cnAccesoDatos.ExcelDinamicoVendedores(consulta)
                MessageBox.Show("Archivo Creado", "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error generando archivo, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
            lv_operacion = Nothing
        End If
    End Sub
    Private Sub frmVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_swcb = "0"
        Try
            consulta = "select '00' as id, 'Todos' as Nombre union Select idEmpresa As id, Nombre from adm_empresas;"
            tabla = "adm_empresas"
            cbEmpresa.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbEmpresa.DisplayMember = "Nombre"
            cbEmpresa.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando Empresas, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        Try
            consulta = "select '00' as id, 'Todos' as descripcion union select idZona as id, descripcion from adm_zonas;"
            tabla = "adm_zonas"
            cbZonas.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbZonas.DisplayMember = "Descripcion"
            cbZonas.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando Zonas, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        MuestraTablas()
        lv_swcb = "1"
    End Sub
    Private Sub cbEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpresa.SelectedIndexChanged
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub
    Private Sub cbZonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbZonas.SelectedIndexChanged
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub
    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub
    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        If lv_swcb = "1" Then
            lv_operacion = "imprimir"
            MuestraTablas()
        End If
    End Sub

    Private Sub btdSalir_Click(sender As Object, e As EventArgs) Handles btdSalir.Click
        Close()
        AbrirFormInPanel(frmGrupoMaestros)
        frmPrincipal.txtTitulo.Text = "Maestros"
    End Sub

    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        If dgvResultado.Rows(n).Cells(0).Value <> "" Then
            Dim result As DialogResult = MessageBox.Show("Desea Eliminar el Vendedor " + dgvResultado.Rows(n).Cells(1).Value + "?", "Vendedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = "6" Then
                Try
                    consulta = "delete from adm_vendedor where idVendedor = '" & dgvResultado.Rows(n).Cells(0).Value & "';"
                    cnAccesoDatos.DMLTabla(consulta)
                Catch ex As Exception
                    MessageBox.Show("Error eliminando Vendedor, " + ex.Message, "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
                MessageBox.Show("Vendedor Eliminado", "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MuestraTablas()
            End If
        Else
            MessageBox.Show("Debe seleccionar un Vendedor", "Vendedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btdAgregar_Click(sender As Object, e As EventArgs) Handles btdAgregar.Click
        Close()
        AbrirFormInPanel(frmDetalleVendedores)
        frmPrincipal.txtTitulo.Text = "Agregar Vendedor"
        frmDetalleCatalogo.Text = "Agregar"
    End Sub

    Private Sub btdEditar_Click(sender As Object, e As EventArgs) Handles btdEditar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        lv_id = dgvResultado.Rows(n).Cells(0).Value
        Close()
        AbrirFormInPanel(frmDetalleVendedores)
        frmPrincipal.txtTitulo.Text = "Actualizar Vendedor"
        frmDetalleVendedores.Text = "Actualizar"
        frmDetalleVendedores.txtId.Text = lv_id
        frmDetalleVendedores.txtId.Enabled = False
    End Sub
End Class