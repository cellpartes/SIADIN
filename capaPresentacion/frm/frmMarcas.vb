Imports CapaEntidad
Imports CapaNegocios
Public Class frmMarcas
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
        txtNombre.Enabled = True
        txtNombre.Text = ""
        Try
            consulta = "SELECT max(idMarca) + 1 as ProxId FROM adm_marcas;"
            txtId.Text = Format(cnAccesoDatos.ValorTabla(consulta), "000")
        Catch ex As Exception
            MessageBox.Show("Error consultado Proximo Id, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
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
            lv_operacion = "Editar"
        Else
            MessageBox.Show("Por favor seleccionar una Marca", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        If txtId.Text <> "" Then
            Try
                consulta = "delete from adm_marcas where idMarca = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Marca Eliminada", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtId.Text = ""
                txtNombre.Text = ""
            Catch ex As Exception
                MessageBox.Show("Error eliminando Marca, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            MessageBox.Show("Por favor seleccionar una Marca", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        frmBusca.txtTitulo.Text = "Busqueda de Marcas"
        frmBusca.Text = "BusquedaMarcas"
        frmBusca.Show()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Try
            cnAccesoDatos.BusquedaMarcaxId(txtId.Text)
            txtNombre.Text = ceMarcas.Descripcion
        Catch ex As Exception
            MessageBox.Show("Error consultando adm_marcas, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        Try
            cnAccesoDatos.ExcelMarcas()
            MessageBox.Show("Archivo Creado", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generando archivo, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
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
        txtNombre.Text = ""
        txtNombre.Enabled = False
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
        If lv_operacion = "Editar" Then
            Try
                consulta = "update adm_marcas set Descripcion = '" & txtNombre.Text & "' where idMarca = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
                MessageBox.Show("Marca Actualizada", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error actualizando Marca, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf lv_operacion = "Agregar" Then
            Try
                consulta = "SELECT count(*) as cant FROM adm_marcas WHERE Descripcion = '" & txtNombre.Text & "';"
                n = cnAccesoDatos.ValorTabla(consulta)
            Catch ex As Exception
                MessageBox.Show("Error consultando Marcas existentes, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            If n = 0 Then
                Try
                    consulta = "insert into adm_marcas (idMarca,Descripcion) values ('" & txtId.Text & "','" & txtNombre.Text & "');"
                    cnAccesoDatos.DMLTabla(consulta)
                    MessageBox.Show("Marca Agregada", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Try
                        cnAccesoDatos.BusquedaMarcaxId(txtId.Text)
                        txtNombre.Text = ceMarcas.Descripcion
                    Catch ex As Exception
                        MessageBox.Show("Error consultando adm_marcas, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Error insertando Marca, " + ex.Message, "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("Marca ya Existe", "Marcas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class