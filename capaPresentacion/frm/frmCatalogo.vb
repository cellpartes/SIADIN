Imports CapaEntidad
Imports CapaNegocios
Imports System.IO
Public Class frmCatalogo
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
        Dim lv_Cat As String
        Dim lv_SubCat As String
        Dim lv_Marca As String
        Dim lv_Activo As String
        Dim lv_Frecuente As String
        Dim lv_Servicio As String
        Dim lv_text As String

        If cbCategoria.SelectedValue = "000" Then
            lv_Cat = "a.idCategoria = a.idCategoria"
        Else
            lv_Cat = "a.idCategoria = '" & cbCategoria.SelectedValue & "'"
        End If
        If cbSubCategoria.SelectedValue = "000" Then
            lv_SubCat = "a.idSubCategoria = a.idSubCategoria"
        Else
            lv_SubCat = "a.idSubCategoria = '" & cbSubCategoria.SelectedValue & "'"
        End If
        If cbMarca.SelectedValue = "000" Then
            lv_Marca = "a.idMarca = a.idMarca"
        Else
            lv_Marca = "a.idMarca = '" & cbMarca.SelectedValue & "'"
        End If
        If txtBusca.Text = "" Then
            lv_text = ";"
        Else
            lv_text = " and a.descripcion Like '%" & txtBusca.Text & "%';"
        End If
        If cbActivo.SelectedValue = "T" Then
            lv_Activo = "a.activo = a.activo"
        Else
            lv_Activo = "a.activo = '" & cbActivo.SelectedValue & "'"
        End If

        If cbFrecuente.SelectedValue = "T" Then
            lv_Frecuente = "a.Frecuente = a.Frecuente"
        Else
            lv_Frecuente = "a.Frecuente = '" & cbFrecuente.SelectedValue & "'"
        End If

        If cbServicio.SelectedValue = "T" Then
            lv_Servicio = "a.servicio = a.servicio"
        Else
            lv_Servicio = "a.servicio = '" & cbServicio.SelectedValue & "'"
        End If

        Try
            consulta = "Select a.idarticulo As Id, a.Descripcion, b.descripcion As Categoria, c.descripcion As SubCategoria, d.Descripcion As Marca, " _
                            & "e.Descripcion As Unidad, a.Localizacion, Case a.activo When 'S' then 'SI' else 'NO' end as Activo,  " _
                            & "case a.Frecuente when 'S' then 'SI' else 'NO' end as Frecuente, case a.servicio when 'S' then 'SI' else 'NO' end as Servicio, " _
                            & "a.factor, a.RutaImagen, a.Imagen " _
                       & "from adm_catalogo a " _
                      & "inner join adm_categorias b on a.idCategoria=b.idCategoria " _
                      & "inner join adm_subcategorias c on a.idSubCategoria=c.idSubCategoria " _
                      & "inner join adm_marcas d on a.idMarca = d.idMarca " _
                      & "inner join adm_unidades e on a.idUnidad = e.idUnidad " _
                      & "where a.idCategoria = '" & cbCategoria.SelectedValue & "' " _
                        & "and " + lv_SubCat + " and " + lv_Marca + " and " + lv_Activo + " and " + lv_Frecuente + " and " + lv_Servicio + lv_text
            tabla = "adm_catalogo"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 80
            dgvResultado.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvResultado.Columns(1).Width = 320
            dgvResultado.Columns(2).Width = 120
            dgvResultado.Columns(3).Width = 120
            dgvResultado.Columns(4).Width = 110
            dgvResultado.Columns(5).Width = 80
            dgvResultado.Columns(6).Width = 100
            dgvResultado.Columns(7).Width = 80
            dgvResultado.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvResultado.Columns(8).Width = 80
            dgvResultado.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvResultado.Columns(9).Width = 80
            dgvResultado.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvResultado.Columns(10).Visible = False
            dgvResultado.Columns(11).Visible = False
            dgvResultado.Columns(12).Visible = False

    
        Catch ex As Exception
            MessageBox.Show("Error cargando Catalogo, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

        If lv_operacion = "imprimir" Then
            Try
                cnAccesoDatos.ExcelCatalogoDinamico(consulta)
                MessageBox.Show("Archivo Creado", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error generando archivo, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            lv_operacion = Nothing
        End If


    End Sub

    Private Sub frmCatalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_swcb = "0"

        Dim dtServicio As DataTable = New DataTable("TablaServicio")
        dtServicio.Columns.Add("id")
        dtServicio.Columns.Add("Descripcion")
        Dim drServicio As DataRow
        drServicio = dtServicio.NewRow()
        drServicio("id") = "T"
        drServicio("Descripcion") = "Todos"
        dtServicio.Rows.Add(drServicio)
        drServicio = dtServicio.NewRow()
        drServicio("id") = "S"
        drServicio("Descripcion") = "SI"
        dtServicio.Rows.Add(drServicio)
        drServicio = dtServicio.NewRow()
        drServicio("id") = "N"
        drServicio("Descripcion") = "NO"
        dtServicio.Rows.Add(drServicio)
        cbServicio.DataSource = dtServicio
        cbServicio.ValueMember = "id"
        cbServicio.DisplayMember = "Descripcion"
        cbServicio.SelectedValue = "T"

        Dim dtFrecuente As DataTable = New DataTable("TablaFrecuente")
        dtFrecuente.Columns.Add("id")
        dtFrecuente.Columns.Add("Descripcion")
        Dim drFrecuente As DataRow
        drFrecuente = dtFrecuente.NewRow()
        drFrecuente("id") = "T"
        drFrecuente("Descripcion") = "Todos"
        dtFrecuente.Rows.Add(drFrecuente)
        drFrecuente = dtFrecuente.NewRow()
        drFrecuente("id") = "S"
        drFrecuente("Descripcion") = "SI"
        dtFrecuente.Rows.Add(drFrecuente)
        drFrecuente = dtFrecuente.NewRow()
        drFrecuente("id") = "N"
        drFrecuente("Descripcion") = "NO"
        dtFrecuente.Rows.Add(drFrecuente)
        cbFrecuente.DataSource = dtFrecuente
        cbFrecuente.ValueMember = "id"
        cbFrecuente.DisplayMember = "Descripcion"
        cbFrecuente.SelectedValue = "T"

        Dim dtActivo As DataTable = New DataTable("TablaActivo")
        dtActivo.Columns.Add("id")
        dtActivo.Columns.Add("Descripcion")
        Dim drActivo As DataRow
        drActivo = dtActivo.NewRow()
        drActivo("id") = "T"
        drActivo("Descripcion") = "Todos"
        dtActivo.Rows.Add(drActivo)
        drActivo = dtActivo.NewRow()
        drActivo("id") = "S"
        drActivo("Descripcion") = "SI"
        dtActivo.Rows.Add(drActivo)
        drActivo = dtActivo.NewRow()
        drActivo("id") = "N"
        drActivo("Descripcion") = "NO"
        dtActivo.Rows.Add(drActivo)
        cbActivo.DataSource = dtActivo
        cbActivo.ValueMember = "id"
        cbActivo.DisplayMember = "Descripcion"
        cbActivo.SelectedValue = "T"

        Try
            consulta = "Select idCategoria As id, Descripcion from adm_categorias;"
            tabla = "adm_categorias"
            cbCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbCategoria.DisplayMember = "Descripcion"
            cbCategoria.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando Categoria, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        Try
            If cbCategoria.SelectedValue.ToString <> "" Then
                lv_sw = cbCategoria.SelectedValue
            Else
                lv_sw = "002"
            End If
            consulta = "Select '000' as id, 'Todos' as descripcion union select idsubcategoria as id, descripcion from adm_subcategorias where idcategoria = '" & lv_sw & "'"
            tabla = "adm_subcategorias"
            cbSubCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbSubCategoria.DisplayMember = "Descripcion"
            cbSubCategoria.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando SubCategoria, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        Try
            consulta = "select '000' as id, 'Todos' as descripcion union select idmarca as id, descripcion from adm_marcas;"
            tabla = "adm_marcas"
            cbMarca.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbMarca.DisplayMember = "Descripcion"
            cbMarca.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando Marcas, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        MuestraTablas()
        lv_swcb = "1"
    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged
        If lv_swcb = "1" Then
            Try
                If cbCategoria.SelectedValue.ToString <> "" Then
                    lv_sw = cbCategoria.SelectedValue
                Else
                    lv_sw = "002"
                End If
                consulta = "select '000' as id, 'Todos' as descripcion union select idsubcategoria as id, descripcion from adm_subcategorias where idcategoria = '" & lv_sw & "'"
                tabla = "adm_subcategorias"
                cbSubCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbSubCategoria.DisplayMember = "Descripcion"
                cbSubCategoria.ValueMember = "id"
            Catch ex As Exception
                MessageBox.Show("Error cargando SubCategoria, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
            MuestraTablas()
        End If
    End Sub

    Private Sub cbSubCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubCategoria.SelectedIndexChanged
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub

    Private Sub cbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMarca.SelectedIndexChanged
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub

    Private Sub cbServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServicio.SelectedIndexChanged
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub

    Private Sub cbFrecuente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFrecuente.SelectedIndexChanged
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub

    Private Sub cbActivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbActivo.SelectedIndexChanged
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub

    Private Sub btdSalir_Click(sender As Object, e As EventArgs) Handles btdSalir.Click
        Close()
        AbrirFormInPanel(frmGrupoMaestros)
        frmPrincipal.txtTitulo.Text = "Maestros"
    End Sub

    Private Sub btdImprimir_Click(sender As Object, e As EventArgs) Handles btdImprimir.Click
        If lv_swcb = "1" Then
            lv_operacion = "imprimir"
            MuestraTablas()

        End If
        'Try
        'cnAccesoDatos.ExcelCatalogo()
        'MessageBox.Show("Archivo Creado", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        'MessageBox.Show("Error generando archivo, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try
    End Sub
    Private Sub btdBuscar_Click(sender As Object, e As EventArgs) Handles btdBuscar.Click
        If lv_swcb = "1" Then
            MuestraTablas()
        End If
    End Sub
    Private Sub btdEliminar_Click(sender As Object, e As EventArgs) Handles btdEliminar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        If dgvResultado.Rows(n).Cells(0).Value <> "" Then
            Dim result As DialogResult = MessageBox.Show("Desea Eliminar el Articulo " + dgvResultado.Rows(n).Cells(0).Value + "?", "Catalogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = "6" Then
                Try
                    consulta = "delete from adm_catalogo where idArticulo = '" & dgvResultado.Rows(n).Cells(0).Value & "';"
                    cnAccesoDatos.DMLTabla(consulta)
                Catch ex As Exception
                    MessageBox.Show("Error eliminando Articulo, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
                MessageBox.Show("Articulo Eliminado", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MuestraTablas()
            End If
        Else
            MessageBox.Show("Debe seleccionar un Articulo", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btdEditar_Click(sender As Object, e As EventArgs) Handles btdEditar.Click
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        lv_id = dgvResultado.Rows(n).Cells(0).Value
        Close()
        AbrirFormInPanel(frmDetalleCatalogo)
        frmPrincipal.txtTitulo.Text = "Actualizar Articulo"
        frmDetalleCatalogo.Text = "Actualizar"
        frmDetalleCatalogo.txtId.Text = lv_id
        frmDetalleCatalogo.txtId.Enabled = False
    End Sub
    Private Sub btdAgregar_Click(sender As Object, e As EventArgs) Handles btdAgregar.Click
        Close()
        AbrirFormInPanel(frmDetalleCatalogo)
        frmPrincipal.txtTitulo.Text = "Agregar Articulo"
        frmDetalleCatalogo.Text = "Agregar"
    End Sub
    Private Sub dgvResultado_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvResultado.CellMouseClick
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        txtLocalizacion.Text = dgvResultado.Rows(n).Cells(6).Value
        txtUnidad.Text = dgvResultado.Rows(n).Cells(5).Value
        txtFactor.Text = dgvResultado.Rows(n).Cells(10).Value
        If dgvResultado.Rows(n).Cells(11).Value <> "" Then
            imgArticulo.Image = dgvResultado.CurrentRow.Cells(12).FormattedValue
        Else
            imgArticulo.Image = Nothing
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class