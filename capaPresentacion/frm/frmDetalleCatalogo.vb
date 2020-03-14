Imports CapaEntidad
Imports CapaNegocios
Imports System.IO
Imports CapaDatos
Imports MySql.Data.MySqlClient
Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class frmDetalleCatalogo
    Dim lv_operacion As String
    Dim drA As System.Data.IDataReader
    Dim drE As System.Data.IDataReader
    Dim lv_sw As String
    Dim lv_swcb As String
    Dim consulta As String
    Dim tabla As String
    Dim n As Integer
    Dim lv_id As String
    Dim sql_ins As String
    Dim ld_fecha As String
    Dim ln_cant As Integer
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
    Private Sub btdCancela_Click(sender As Object, e As EventArgs) Handles btdCancela.Click
        Close()
        AbrirFormInPanel(frmCatalogo)
        frmPrincipal.txtTitulo.Text = "Mantenimiento del Catalogo"
    End Sub
    Private Sub btdOk_Click(sender As Object, e As EventArgs) Handles btdOk.Click
        If Me.Text = "Agregar" Then
            If opfBuscaImagen.FileName = Nothing Then
                imgArticulo.Image = Nothing
            End If
            Try
                consulta = "insert into adm_catalogo (idArticulo,Descripcion,idCategoria,idSubCategoria,idMarca,idUnidad,localizacion, " _
                             & "                          StockMin,StockMax,factor,precioCompra,preCompraProm,margen1,margen2,margen3,margen4, " _
                             & "                          margen5,precio1,precio2,precio3,precio4,precio5,mayoreo1,mayoreo2,mayoreo3,Mayoreo4, " _
                             & "                          Mayoreo5,Activo,Frecuente,FechaUltMov,Servicio,RutaImagen) " _
                             & "                  values ('" & txtId.Text & "','" & txtDescripcion.Text & "','" & cbCategoria.SelectedValue & "', " _
                             & "                          '" & cbSubCategoria.SelectedValue & "', '" & cbMarca.SelectedValue & "', '" & cbUnidad.SelectedValue & "', " _
                             & "                          '" & txtLocalizacion.Text & "','" & txtStockMin.Text & "','" & txtStockMax.Text & "', " _
                             & "                          '" & txtFactor.Text & "', '" & txtPrecioCompra.Text & "', '" & txtPreCompraProm.Text & "', " _
                             & "                          '" & txtMargen1.Text & "', '" & txtMargen2.Text & "', '" & txtMargen3.Text & "', '" & txtMargen4.Text & "', " _
                             & "                          '" & txtMargen5.Text & "', '" & txtPrecio1.Text & "', '" & txtPrecio2.Text & "', '" & txtPrecio3.Text & "', " _
                             & "                          '" & txtPrecio4.Text & "', '" & txtPrecio5.Text & "', '" & txtMayoreo1.Text & "', '" & txtMayoreo2.Text & "', " _
                             & "                          '" & txtMayoreo3.Text & "', '" & txtMayoreo4.Text & "', '" & txtMayoreo5.Text & "', '" & cbActivo.SelectedValue & "', " _
                             & "                          '" & cbFrecuente.SelectedValue & "', '" & DateTime.Now.ToString("yyyy/MM/dd") & "', '" & cbServicio.SelectedValue & "', '" & txtRutaImagen.Text & "');"
                cnAccesoDatos.DMLTabla(consulta)
            Catch ex As Exception
                MessageBox.Show("Error insertando Articulo (img), " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
            If txtRutaImagen.Text <> "" Then
                Try
                    sql_ins = "update adm_catalogo set Imagen = @imagen where idArticulo = '" & txtId.Text & "';"
                    DML_IMG(sql_ins, imgArticulo, imgBack)
                Catch ex As Exception
                    MessageBox.Show("Error insertando Imagen, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
            End If
            MessageBox.Show("Articulo Registrado", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If Me.Text = "Actualizar" Then
            Try
                consulta = "update adm_catalogo set Descripcion = '" & txtDescripcion.Text & "', idCategoria = '" & cbCategoria.SelectedValue & "', " _
                         & "                        idSubCategoria = '" & cbSubCategoria.SelectedValue & "', idMarca = '" & cbMarca.SelectedValue & "', " _
                         & "                        idUnidad = '" & cbUnidad.SelectedValue & "', localizacion = '" & txtLocalizacion.Text & "', " _
                         & "                        StockMin = '" & txtStockMin.Text & "', StockMax = '" & txtStockMax.Text & "', factor = '" & txtFactor.Text & "', " _
                         & "                        precioCompra = '" & txtPrecioCompra.Text & "', preCompraProm = '" & txtPreCompraProm.Text & "',  " _
                         & "                        margen1 = '" & txtMargen1.Text & "', margen2 = '" & txtMargen2.Text & "', margen3 = '" & txtMargen3.Text & "', " _
                         & "                        margen4 = '" & txtMargen4.Text & "', margen5 = '" & txtMargen5.Text & "', precio1 = '" & txtPrecio1.Text & "', " _
                         & "                        precio2 = '" & txtPrecio2.Text & "', precio3 = '" & txtPrecio3.Text & "', precio4 = '" & txtPrecio4.Text & "', " _
                         & "                        precio5 = '" & txtPrecio5.Text & "', mayoreo1 = '" & txtMayoreo1.Text & "',mayoreo2 = '" & txtMayoreo2.Text & "', " _
                         & "                        mayoreo3 = '" & txtMayoreo3.Text & "',Mayoreo4 = '" & txtMayoreo4.Text & "', Mayoreo5 = '" & txtMayoreo5.Text & "', " _
                         & "                        Activo = '" & cbActivo.SelectedValue & "', Frecuente = '" & cbFrecuente.SelectedValue & "', " _
                         & "                        Servicio = '" & cbServicio.SelectedValue & "' " _
                         & "                  where idArticulo = '" & txtId.Text & "';"
                cnAccesoDatos.DMLTabla(consulta)
            Catch ex As Exception
                MessageBox.Show("Error Actualizando Articulo, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
            If txtRutaImagen.Text <> "" Then
                Try
                    sql_ins = "update adm_catalogo set Imagen = @imagen, RutaImagen = '" & txtRutaImagen.Text & "' where idArticulo = '" & txtId.Text & "';"
                    DML_IMG(sql_ins, imgArticulo, imgBack)
                Catch ex As Exception
                    MessageBox.Show("Error Actualizando Articulo (img), " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
            End If
            MessageBox.Show("Articulo Actualizado", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Close()
        AbrirFormInPanel(frmCatalogo)
        frmPrincipal.txtTitulo.Text = "Mantenimiento del Catalogo"
    End Sub
    Private Sub btdBuscarImagen_Click(sender As Object, e As EventArgs) Handles btdBuscarImagen.Click
        opfBuscaImagen.Filter = "Archivo JPG|*.jpg"
        If opfBuscaImagen.ShowDialog() = DialogResult.OK Then
            imgArticulo.Image = Image.FromFile(opfBuscaImagen.FileName)
            txtRutaImagen.Text = opfBuscaImagen.FileName
        End If
    End Sub
    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged
        If lv_swcb = "0" Then
            Try
                If cbCategoria.SelectedValue.ToString <> "" Then
                    lv_sw = cbCategoria.SelectedValue
                Else
                    lv_sw = "002"
                End If
                consulta = "Select idSubCategoria as id, Descripcion from adm_subcategorias where idCategoria = '" & lv_sw & "'"
                tabla = "adm_subcategorias"
                cbSubCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbSubCategoria.DisplayMember = "Descripcion"
                cbSubCategoria.ValueMember = "id"
            Catch ex As Exception
                MessageBox.Show("Error cargando SubCategoria, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Try
            cnAccesoDatos.BusquedaCatalogoxId(txtId.Text)
            txtDescripcion.Text = ceCatalogo.Descripcion
            cbCategoria.SelectedValue = ceCatalogo.idCategoria
            cbSubCategoria.SelectedValue = ceCatalogo.idSubCategoria
            cbMarca.SelectedValue = ceCatalogo.idMarca
            cbUnidad.SelectedValue = ceCatalogo.idUnidad
            cbActivo.SelectedValue = Mid(ceCatalogo.Activo, 1, 1)
            cbFrecuente.SelectedValue = Mid(ceCatalogo.Frecuente, 1, 1)
            cbServicio.SelectedValue = Mid(ceCatalogo.Servicio, 1, 1)
            txtLocalizacion.Text = ceCatalogo.localizacion
            txtFactor.Text = ceCatalogo.factor
            txtStockMin.Text = ceCatalogo.StockMin
            txtStockMax.Text = ceCatalogo.StockMax
            txtPrecioCompra.Text = ceCatalogo.precioCompra
            txtPreCompraProm.Text = ceCatalogo.preCompraProm
            txtMargen1.Text = ceCatalogo.margen1
            txtMargen2.Text = ceCatalogo.margen2
            txtMargen3.Text = ceCatalogo.margen3
            txtMargen4.Text = ceCatalogo.margen4
            txtMargen5.Text = ceCatalogo.margen5
            txtPrecio1.Text = ceCatalogo.precio1
            txtPrecio2.Text = ceCatalogo.precio2
            txtPrecio3.Text = ceCatalogo.precio3
            txtPrecio4.Text = ceCatalogo.precio4
            txtPrecio5.Text = ceCatalogo.precio5
            txtMayoreo1.Text = ceCatalogo.mayoreo1
            txtMayoreo2.Text = ceCatalogo.mayoreo2
            txtMayoreo3.Text = ceCatalogo.mayoreo3
            txtMayoreo4.Text = ceCatalogo.Mayoreo4
            txtMayoreo5.Text = ceCatalogo.Mayoreo5
            txtRutaImagen.Text = ceCatalogo.RutaImagen
            If txtRutaImagen.Text <> "" Then
                Try
                    Dim ri As DataTable
                    Dim li_cant As Integer
                    consulta = "select Imagen from adm_catalogo where idArticulo = '" & txtId.Text & "';"
                    tabla = "adm_catalogo"
                    ri = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                    li_cant = ri.Rows.Count
                    If li_cant > 0 Then
                        Dim bits As Byte() = CType(ri.Rows(0).Item(0), Byte())
                        Dim memorybits As New System.IO.MemoryStream(bits)
                        Dim bitmap As New Bitmap(memorybits)
                        imgArticulo.Image = bitmap
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error Cargando Imagen, " + ex.Message, "Clientes VIP", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Error consultando adm_clientes, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub txtPrecioCompra_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioCompra.TextChanged
        txtPreCompraProm.Text = txtPrecioCompra.Text
    End Sub

    Private Sub txtMargen1_TextChanged(sender As Object, e As EventArgs) Handles txtMargen1.TextChanged
        If lv_swcb <> "1" Then
            If txtPrecioCompra.Text = "" Or txtPrecioCompra.Text = "0.00" Then
                MessageBox.Show("Debe ingresar un precio de compra...", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioCompra.Select()
            Else
                txtPrecio1.Text = (Val(txtPrecioCompra.Text) * (Val(txtMargen1.Text) / 100)) + Val(txtPrecioCompra.Text)
            End If
        End If
    End Sub

    Private Sub txtMargen2_TextChanged(sender As Object, e As EventArgs) Handles txtMargen2.TextChanged
        If lv_swcb <> "1" Then
            If txtPrecioCompra.Text = "" Or txtPrecioCompra.Text = "0.00" Then
                MessageBox.Show("Debe ingresar un precio de compra...", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioCompra.Select()
            Else
                txtPrecio2.Text = (Val(txtPrecioCompra.Text) * (Val(txtMargen2.Text) / 100)) + Val(txtPrecioCompra.Text)
            End If
        End If
    End Sub

    Private Sub txtMargen3_TextChanged(sender As Object, e As EventArgs) Handles txtMargen3.TextChanged
        If lv_swcb <> "1" Then
            If txtPrecioCompra.Text = "" Or txtPrecioCompra.Text = "0.00" Then
                MessageBox.Show("Debe ingresar un precio de compra...", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioCompra.Select()
            Else
                txtPrecio3.Text = (Val(txtPrecioCompra.Text) * (Val(txtMargen3.Text) / 100)) + Val(txtPrecioCompra.Text)
            End If
        End If
    End Sub

    Private Sub txtMargen4_TextChanged(sender As Object, e As EventArgs) Handles txtMargen4.TextChanged
        If lv_swcb <> "1" Then
            If txtPrecioCompra.Text = "" Or txtPrecioCompra.Text = "0.00" Then
                MessageBox.Show("Debe ingresar un precio de compra...", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioCompra.Select()
            Else
                txtPrecio4.Text = (Val(txtPrecioCompra.Text) * (Val(txtMargen4.Text) / 100)) + Val(txtPrecioCompra.Text)
            End If
        End If
    End Sub

    Private Sub txtMargen5_TextChanged(sender As Object, e As EventArgs) Handles txtMargen5.TextChanged
        If lv_swcb <> "1" Then
            If txtPrecioCompra.Text = "" Or txtPrecioCompra.Text = "0.00" Then
                MessageBox.Show("Debe ingresar un precio de compra...", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioCompra.Select()
            Else
                txtPrecio5.Text = (Val(txtPrecioCompra.Text) * (Val(txtMargen5.Text) / 100)) + Val(txtPrecioCompra.Text)
            End If
        End If
    End Sub

    Private Sub chkUtilidad_CheckedChanged(sender As Object, e As EventArgs) Handles chkUtilidad.CheckedChanged
        If chkUtilidad.Checked = True Then
            txtMargen1.Enabled = True
            txtMargen2.Enabled = True
            txtMargen3.Enabled = True
            txtMargen4.Enabled = True
            txtMargen5.Enabled = True
            chkPrecios.Checked = False
            txtPrecio1.Enabled = False
            txtPrecio2.Enabled = False
            txtPrecio3.Enabled = False
            txtPrecio4.Enabled = False
            txtPrecio5.Enabled = False
        Else
            txtMargen1.Enabled = False
            txtMargen2.Enabled = False
            txtMargen3.Enabled = False
            txtMargen4.Enabled = False
            txtMargen5.Enabled = False
            chkPrecios.Checked = True
            txtPrecio1.Enabled = True
            txtPrecio2.Enabled = True
            txtPrecio3.Enabled = True
            txtPrecio4.Enabled = True
            txtPrecio5.Enabled = True
        End If
    End Sub

    Private Sub chkPrecios_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrecios.CheckedChanged
        If chkPrecios.Checked = True Then
            txtMargen1.Enabled = False
            txtMargen2.Enabled = False
            txtMargen3.Enabled = False
            txtMargen4.Enabled = False
            txtMargen5.Enabled = False
            chkUtilidad.Checked = False
            txtPrecio1.Enabled = True
            txtPrecio2.Enabled = True
            txtPrecio3.Enabled = True
            txtPrecio4.Enabled = True
            txtPrecio5.Enabled = True
        Else
            txtMargen1.Enabled = True
            txtMargen2.Enabled = True
            txtMargen3.Enabled = True
            txtMargen4.Enabled = True
            txtMargen5.Enabled = True
            chkUtilidad.Checked = True
            txtPrecio1.Enabled = False
            txtPrecio2.Enabled = False
            txtPrecio3.Enabled = False
            txtPrecio4.Enabled = False
            txtPrecio5.Enabled = False
        End If
    End Sub

    Private Sub txtPrecio1_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio1.TextChanged
        If lv_swcb <> "1" Then
            If txtPrecioCompra.Text = "" Or txtPrecioCompra.Text = "0.00" Then
                MessageBox.Show("Debe ingresar un precio de compra...", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioCompra.Select()
            Else
                txtMargen1.Text = ((Val(txtPrecio1.Text) * 100) / Val(txtPrecioCompra.Text)) - 100
            End If
        End If
    End Sub

    Private Sub txtPrecio2_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio2.TextChanged
        If lv_swcb <> "1" Then
            If txtPrecioCompra.Text = "" Or txtPrecioCompra.Text = "0.00" Then
                MessageBox.Show("Debe ingresar un precio de compra...", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioCompra.Select()
            Else
                txtMargen2.Text = ((Val(txtPrecio2.Text) * 100) / Val(txtPrecioCompra.Text)) - 100
            End If
        End If
    End Sub

    Private Sub txtPrecio3_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio3.TextChanged
        If lv_swcb <> "1" Then
            If txtPrecioCompra.Text = "" Or txtPrecioCompra.Text = "0.00" Then
                MessageBox.Show("Debe ingresar un precio de compra...", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioCompra.Select()
            Else
                txtMargen3.Text = ((Val(txtPrecio3.Text) * 100) / Val(txtPrecioCompra.Text)) - 100
            End If
        End If
    End Sub

    Private Sub txtPrecio4_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio4.TextChanged
        If lv_swcb <> "1" Then
            If txtPrecioCompra.Text = "" Or txtPrecioCompra.Text = "0.00" Then
                MessageBox.Show("Debe ingresar un precio de compra...", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioCompra.Select()
            Else
                txtMargen4.Text = ((Val(txtPrecio4.Text) * 100) / Val(txtPrecioCompra.Text)) - 100
            End If
        End If
    End Sub

    Private Sub txtPrecio5_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio5.TextChanged
        If lv_swcb <> "1" Then
            If txtPrecioCompra.Text = "" Or txtPrecioCompra.Text = "0.00" Then
                MessageBox.Show("Debe ingresar un precio de compra...", "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPrecioCompra.Select()
            Else
                txtMargen5.Text = ((Val(txtPrecio5.Text) * 100) / Val(txtPrecioCompra.Text)) - 100
            End If
        End If
    End Sub

    Private Sub frmDetalleCatalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ln_cant = 1
        Dim dtServicio As DataTable = New DataTable("TablaServicio")
        dtServicio.Columns.Add("id")
        dtServicio.Columns.Add("Descripcion")
        Dim drServicio As DataRow
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
        cbServicio.SelectedValue = ""

        Dim dtFrecuente As DataTable = New DataTable("TablaFrecuente")
        dtFrecuente.Columns.Add("id")
        dtFrecuente.Columns.Add("Descripcion")
        Dim drFrecuente As DataRow
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
        cbFrecuente.SelectedValue = ""

        Dim dtActivo As DataTable = New DataTable("TablaActivo")
        dtActivo.Columns.Add("id")
        dtActivo.Columns.Add("Descripcion")
        Dim drActivo As DataRow
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
        cbActivo.SelectedValue = ""
        'Try
        '    consulta = "SELECT max(idArticulo)+1 as ProxId FROM adm_catalogo;"
        '    txtId.Text = Format(cnAccesoDatos.ValorTabla(consulta), "000000000")
        'Catch ex As Exception
        '    MessageBox.Show("Error consultado Proximo Id, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try
        Try
            consulta = "Select idCategoria as id, Descripcion from adm_categorias;"
            tabla = "adm_categorias"
            cbCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbCategoria.DisplayMember = "Descripcion"
            cbCategoria.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando Categoria, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            If cbCategoria.SelectedValue.ToString <> "" Then
                lv_sw = cbCategoria.SelectedValue
            Else
                lv_sw = "002"
            End If
            consulta = "Select idSubCategoria as id, Descripcion from adm_subcategorias where idCategoria = '" & lv_sw & "'"
            tabla = "adm_subcategorias"
            cbSubCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbSubCategoria.DisplayMember = "Descripcion"
            cbSubCategoria.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando SubCategoria, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            consulta = "Select idmarca as id, Descripcion from adm_marcas;"
            tabla = "adm_marcas"
            cbMarca.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbMarca.DisplayMember = "Descripcion"
            cbMarca.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando Marcas, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Try
            consulta = "Select idunidad as id, Descripcion from adm_unidades;"
            tabla = "adm_unidades"
            cbUnidad.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            cbUnidad.DisplayMember = "Descripcion"
            cbUnidad.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show("Error cargando Unidades, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        lv_swcb = "0"
    End Sub
    Sub DML_IMG(ByVal sql As String, ByVal imagen As PictureBox, ByVal img As PictureBox)
        Using cn = objConexion.conectar
            cn.Open()
            Using cmd As New MySqlCommand
                Dim MS As New MemoryStream
                Try
                    imagen.Image.Save(MS, imagen.Image.RawFormat)
                Catch ex As Exception
                    img.Image.Save(MS, img.Image.RawFormat)
                End Try
                Dim Imagenes() As Byte = MS.GetBuffer
                cmd.Connection = cn
                cmd.CommandText = sql
                cmd.Parameters.AddWithValue("@imagen", Imagenes)
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error al registrar Imagen, " + ex.Message, "Registrar Entrada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try
            End Using
        End Using
    End Sub
End Class