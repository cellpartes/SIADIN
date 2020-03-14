Imports CapaEntidad
Imports CapaNegocios
Public Class frmMarcas
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

    Private Sub btdSalir_Click(sender As Object, e As EventArgs) Handles btdSalir.Click
        Me.Close()
        AbrirFormInPanel(frmGrupoMaestros)
        frmPrincipal.txtTitulo.Text = "Maestros"
    End Sub

    Private Sub btdAgregar_Click(sender As Object, e As EventArgs) Handles btdAgregar.Click
        Close()
        Try
            consulta = "SELECT max(idMarca) + 1 as ProxId FROM adm_marcas;"
            AbrirFormInPanel(frmDetalleMarcas)
            frmPrincipal.txtTitulo.Text = "Agregar Marca"
            frmDetalleMarcas.Text = "Agregar"
            frmDetalleMarcas.txtId.Text = Format(cnAccesoDatos.ValorTabla(consulta), "000")

        Catch ex As Exception
            MessageBox.Show("Error consultado Proximo Id, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        AbrirFormInPanel(frmDetalleMarcas)
        frmPrincipal.txtTitulo.Text = "Actualizar Marcas"
        frmDetalleMarcas.Text = "Actualizar"
        frmDetalleMarcas.txtId.Text = lv_id
        frmDetalleMarcas.txtId.Enabled = False
        'If txtId.Text <> "" Then
        'btdAgregar.Enabled = False
        'btdEditar.Enabled = False
        'btdEliminar.Enabled = False
        'btdBuscar.Enabled = False
        'btdImprimir.Enabled = False
        'btdSalir.Enabled = False
        'btdOk.Visible = True
        'btdCancela.Visible = True
        'txtNombre.Enabled = True
        'lv_operacion = "Editar"
        'Else
        'MessageBox.Show("Por favor seleccionar una Marca", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
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
                    consulta = "delete from adm_marcas where idMarca = '" & dgvResultado.Rows(n).Cells(0).Value & "';"
                    cnAccesoDatos.DMLTabla(consulta)
                Catch ex As Exception
                    MessageBox.Show("Error eliminando Marca, " + ex.Message, "Marca", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
                MessageBox.Show("Marca Eliminado", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Information)
                consulta = "select idMarca as id, Descripcion from adm_marcas;"
                tabla = "adm_marcas"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                dgvResultado.Columns(0).Width = 100
                dgvResultado.Columns(1).Width = 330
            End If
        End If
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        consulta = "SELECT idMarca as id, Descripcion from adm_marcas where Descripcion like '%" & txtBusca.Text & "%';"
        tabla = "adm_marcas"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
    End Sub

    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        Try
            cnAccesoDatos.ExcelMarcas()
            MessageBox.Show("Archivo Creado", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generando archivo, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frmMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consulta = "select idMarca as id, Descripcion from adm_marcas;"
        tabla = "adm_marcas"
        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
        dgvResultado.Columns(0).Width = 100
        dgvResultado.Columns(1).Width = 330
    End Sub
End Class