Imports CapaEntidad
Imports CapaNegocios
Imports CapaDatos
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmDetalleVentas
    Dim lv_sw As String
    Dim lv_swcb As String
    Dim consulta As String
    Dim tabla As String
    Dim n As Integer
    Dim lv_id As String
    Dim imagen As Bitmap
    'Dim dr As System.Data.IDataReader
    Dim cnAccesoDatos As New cnAccesoDatos()
    Dim objConexion As New cdConexion
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
        ColorTabla(dgvResultado)
    End Sub
    Public Sub ColorTabla(ByVal dgv As DataGridView)
        Try
            With dgv
                .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub RecuperarImagen(consulta As String)
        Using cn = objConexion.conectar
            Dim dr As MySqlDataReader
            cn.Open()
            Using cmd As New MySqlCommand
                Dim Imag As Byte()
                cmd.Connection = cn
                cmd.CommandText = consulta
                dr = cmd.ExecuteReader()
                While dr.Read
                    Imag = dr("Imagen")
                    PictureBox1.Image = Bytes_Imagen(Imag)
                End While
            End Using
        End Using
    End Sub
    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            If Not Imagen Is Nothing Then
                Dim Bin As New MemoryStream(Imagen)
                Dim Resultado As Image = Image.FromStream(Bin)
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Sub btdCancelar_Click(sender As Object, e As EventArgs) Handles btdCancelar.Click
        Close()
    End Sub

    Private Sub frmDetalleVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim descripcion As String
        Dim existe As Boolean = False
        Dim total As Integer

        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try

        lv_id = dgvResultado.Rows(n).Cells(0).Value
        descripcion = dgvResultado.Rows(n).Cells(1).Value
        Close()
        AbrirFormInPanel(frmVentas)
        frmVentas.TextBox1.Text = lv_id
        'frmVentas.PictureBox1.Image = PictureBox1.Image

        For Each itm As DataGridViewRow In frmVentas.dgvResultado.Rows
            If itm.Cells(1).Value = lv_id Then
                total = itm.Cells(0).Value
                itm.Cells(0).Value = total + 1
                existe = True
            End If
        Next
        If frmVentas.dgvResultado.Rows.Count > 0 AndAlso existe = True Then
            'MsgBox("Ya existe")
        Else
            frmVentas.dgvResultado.Rows.Add(1, lv_id, descripcion, 5, 0, 100, 15, imagen)
        End If
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged

    End Sub

    Private Sub txtBusca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusca.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If lv_swcb = "1" Then
                MuestraTablas()
            End If
        End If
    End Sub

    Private Sub dgvResultado_SelectionChanged(sender As Object, e As EventArgs) Handles dgvResultado.SelectionChanged
        Try
            n = dgvResultado.CurrentRow.Index
        Catch ex As Exception
            n = 0
        End Try
        lv_id = dgvResultado.Rows(n).Cells(0).Value
        If dgvResultado.Rows(n).Cells(11).Value <> "" Then
            PictureBox1.Image = dgvResultado.CurrentRow.Cells(12).FormattedValue
            imagen = dgvResultado.CurrentRow.Cells(12).FormattedValue
        Else
            PictureBox1.Image = Nothing
            imagen = Nothing
        End If
        'RecuperarImagen("Select Imagen from adm_catalogo where idArticulo = '" & lv_id & "';")
    End Sub
End Class