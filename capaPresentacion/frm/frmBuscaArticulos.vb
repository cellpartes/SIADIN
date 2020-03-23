Imports CapaEntidad
Imports CapaNegocios
Public Class frmBuscaArticulos
    Dim lv_operacion As String
    Dim dr As System.Data.IDataReader
    Dim lv_sw As String
    Dim lv_swcb As String
    Dim lv_busqueda As String
    Dim consulta As String
    Dim tabla As String
    Dim n As Integer
    Dim cnAccesoDatos As New cnAccesoDatos()
    Dim lv_unidad As String
    Dim ln_Precio As Double
    Dim ln_Impuesto As Double
    Dim ln_total As Double
    Dim ln_filas As Integer


    Private Sub frmBuscaArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Text = "BusquedaArticulosVentas" Or Me.Text = "BusquedaArticulos" Or Me.Text = "AgregaServicio" Then
            lv_swcb = "0"
            consulta = "select a.idarticulo as id, a.descripcion, b.descripcion as categoria, c.descripcion as subcategoria, d.Descripcion as marca " _
                     & "  from adm_catalogo a " _
                     & "  inner join adm_categorias b on a.idCategoria=b.idCategoria " _
                     & "  inner join adm_subcategorias c on a.idSubCategoria=c.idSubCategoria " _
                     & "  inner join adm_marcas d on a.idMarca = d.idMarca;"
            tabla = "adm_catalogo"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 80
            dgvResultado.Columns(1).Width = 320
            dgvResultado.Columns(2).Width = 120
            dgvResultado.Columns(3).Width = 120
            dgvResultado.Columns(4).Width = 110
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
                consulta = "select '000' as id, 'Todos' as descripcion union select idsubcategoria as id, descripcion from adm_subcategorias where idcategoria = '" & lv_sw & "'"
                tabla = "adm_subcategorias"
                cbSubCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbSubCategoria.DisplayMember = "Descripcion"
                cbSubCategoria.ValueMember = "id"
            Catch ex As Exception
                MessageBox.Show("Error cargando SubCategoria, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Try
                consulta = "select '000' as id, 'Todos' as descripcion union select idmarca as id, descripcion from adm_marcas;"
                tabla = "adm_marcas"
                cbMarca.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbMarca.DisplayMember = "Descripcion"
                cbMarca.ValueMember = "id"
            Catch ex As Exception
                MessageBox.Show("Error cargando Marcas, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            lv_swcb = "1"
        End If
        If Me.Text = "BuscaServicio" Then
            lv_swcb = "0"
            consulta = "select a.idArticulo, b.descripcion, c.descripcion as categoria, d.descripcion as subcategoria, e.Descripcion as marca " _
                     & "  from adm_servicios a " _
                     & " inner join adm_catalogo b on a.idArticulo = b.idArticulo " _
                     & " inner join adm_categorias c on b.idCategoria=c.idCategoria " _
                     & " inner join adm_subcategorias d on b.idSubCategoria=d.idSubCategoria " _
                     & " inner join adm_marcas e on b.idMarca = e.idMarca;"
            tabla = "adm_servicios"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 80
            dgvResultado.Columns(1).Width = 320
            dgvResultado.Columns(2).Width = 120
            dgvResultado.Columns(3).Width = 120
            dgvResultado.Columns(4).Width = 110
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
                consulta = "select '000' as id, 'Todos' as descripcion union select idsubcategoria as id, descripcion from adm_subcategorias where idcategoria = '" & lv_sw & "'"
                tabla = "adm_subcategorias"
                cbSubCategoria.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbSubCategoria.DisplayMember = "Descripcion"
                cbSubCategoria.ValueMember = "id"
            Catch ex As Exception
                MessageBox.Show("Error cargando SubCategoria, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Try
                consulta = "select '000' as id, 'Todos' as descripcion union select idmarca as id, descripcion from adm_marcas;"
                tabla = "adm_marcas"
                cbMarca.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                cbMarca.DisplayMember = "Descripcion"
                cbMarca.ValueMember = "id"
            Catch ex As Exception
                MessageBox.Show("Error cargando Marcas, " + ex.Message, "Catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            lv_swcb = "1"
        End If

    End Sub

    Private Sub btdCancelar_Click(sender As Object, e As EventArgs) Handles btdCancelar.Click
        Close()
    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoria.SelectedIndexChanged
        If Me.Text = "BusquedaArticulosVentas" Or Me.Text = "BusquedaArticulos" Or Me.Text = "AgregaServicio" Then
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
                End Try
                Try
                    If cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue = "000" Then
                        lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%';"
                    ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue = "000" Then
                        lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and a.idSubCategoria = '" & cbSubCategoria.SelectedValue & "';"
                    ElseIf cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue <> "000" Then
                        lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and a.idMarca = '" & cbMarca.SelectedValue & "';"
                    ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue <> "000" Then
                        lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and a.idSubCategoria = '" & cbSubCategoria.SelectedValue & "' and a.idMarca = '" & cbMarca.SelectedValue & "';"
                    End If
                    If txtBusca.Text <> "" Then
                        txtBusca_TextChanged(txtBusca, e)
                    Else
                        consulta = "select a.idarticulo as id, a.descripcion, b.descripcion as categoria, c.descripcion as subcategoria, d.Descripcion as marca " _
                         & "  from adm_catalogo a " _
                         & "  inner join adm_categorias b on a.idCategoria=b.idCategoria " _
                         & "  inner join adm_subcategorias c on a.idSubCategoria=c.idSubCategoria " _
                         & "  inner join adm_marcas d on a.idMarca = d.idMarca" + lv_busqueda
                        tabla = "adm_catalogo"
                        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                    End If
                Catch ex As Exception
                    'MessageBox.Show(ex.Message, "Proveedores - btdAgregar, dpto1", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
        If Me.Text = "BuscaServicio" Then
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
                End Try
                Try
                    If cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue = "000" Then
                        lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%';"
                    ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue = "000" Then
                        lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and b.idSubCategoria = '" & cbSubCategoria.SelectedValue & "';"
                    ElseIf cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue <> "000" Then
                        lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and b.idMarca = '" & cbMarca.SelectedValue & "';"
                    ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue <> "000" Then
                        lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and b.idSubCategoria = '" & cbSubCategoria.SelectedValue & "' and b.idMarca = '" & cbMarca.SelectedValue & "';"
                    End If
                    If txtBusca.Text <> "" Then
                        txtBusca_TextChanged(txtBusca, e)
                    Else
                        consulta = "select a.idArticulo, b.descripcion, c.descripcion as categoria, d.descripcion as subcategoria, e.Descripcion as marca " _
                                 & "  from adm_servicios a " _
                                 & " inner join adm_catalogo b on a.idArticulo = b.idArticulo " _
                                 & " inner join adm_categorias c on b.idCategoria=c.idCategoria " _
                                 & " inner join adm_subcategorias d on b.idSubCategoria=d.idSubCategoria " _
                                 & " inner join adm_marcas e on b.idMarca = e.idMarca" + lv_busqueda
                        tabla = "adm_servicios"
                        dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
                    End If
                Catch ex As Exception
                    'MessageBox.Show(ex.Message, "Proveedores - btdAgregar, dpto1", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If
        End If
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        If Me.Text = "BusquedaArticulosVentas" Or Me.Text = "BusquedaArticulos" Or Me.Text = "AgregaServicio" Then
            If cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue = "000" Then
                lv_busqueda = ";"
            ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue = "000" Then
                lv_busqueda = "and a.idSubCategoria = '" & cbSubCategoria.SelectedValue & "';"
            ElseIf cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue <> "000" Then
                lv_busqueda = "and a.idMarca = '" & cbMarca.SelectedValue & "';"
            ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue <> "000" Then
                lv_busqueda = "and a.idSubCategoria = '" & cbSubCategoria.SelectedValue & "' and a.idMarca = '" & cbMarca.SelectedValue & "';"
            End If
            If rbId.Checked = True Then
                consulta = "select a.idarticulo as id, a.descripcion, b.descripcion as categoria, c.descripcion as subcategoria, d.Descripcion as marca " _
                 & "  from adm_catalogo a " _
                 & "  inner join adm_categorias b on a.idCategoria=b.idCategoria " _
                 & "  inner join adm_subcategorias c on a.idSubCategoria=c.idSubCategoria " _
                 & "  inner join adm_marcas d on a.idMarca = d.idMarca " _
                 & "  where a.idarticulo Like '%" & txtBusca.Text & "%' and b.idCategoria = '" & cbCategoria.SelectedValue & "'" + lv_busqueda
                tabla = "adm_catalogo"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            End If
            If rbNombre.Checked = True Then
                consulta = "select a.idarticulo as id, a.descripcion, b.descripcion as categoria, c.descripcion as subcategoria, d.Descripcion as marca " _
                 & "  from adm_catalogo a " _
                 & "  inner join adm_categorias b on a.idCategoria=b.idCategoria " _
                 & "  inner join adm_subcategorias c on a.idSubCategoria=c.idSubCategoria " _
                 & "  inner join adm_marcas d on a.idMarca = d.idMarca " _
                 & "  where a.descripcion Like '%" & txtBusca.Text & "%' and a.idCategoria = '" & cbCategoria.SelectedValue & "'" + lv_busqueda
                tabla = "adm_catalogo"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            End If
        End If
        If Me.Text = "BuscaServicio" Then
            If cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue = "000" Then
                lv_busqueda = ";"
            ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue = "000" Then
                lv_busqueda = "and b.idSubCategoria = '" & cbSubCategoria.SelectedValue & "';"
            ElseIf cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue <> "000" Then
                lv_busqueda = "and b.idMarca = '" & cbMarca.SelectedValue & "';"
            ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue <> "000" Then
                lv_busqueda = "and b.idSubCategoria = '" & cbSubCategoria.SelectedValue & "' and b.idMarca = '" & cbMarca.SelectedValue & "';"
            End If
            If rbId.Checked = True Then
                consulta = "select a.idArticulo, b.descripcion, c.descripcion as categoria, d.descripcion as subcategoria, e.Descripcion as marca " _
                         & "  from adm_servicios a " _
                         & " inner join adm_catalogo b on a.idArticulo = b.idArticulo " _
                         & " inner join adm_categorias c on b.idCategoria=c.idCategoria " _
                         & " inner join adm_subcategorias d on b.idSubCategoria=d.idSubCategoria " _
                         & " inner join adm_marcas e on b.idMarca = e.idMarca" _
                         & " where a.idarticulo Like '%" & txtBusca.Text & "%' and b.idCategoria = '" & cbCategoria.SelectedValue & "'" + lv_busqueda
                tabla = "adm_servicios"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            End If
            If rbNombre.Checked = True Then
                consulta = "select a.idArticulo, b.descripcion, c.descripcion as categoria, d.descripcion as subcategoria, e.Descripcion as marca " _
                         & "  from adm_servicios a " _
                         & " inner join adm_catalogo b on a.idArticulo = b.idArticulo " _
                         & " inner join adm_categorias c on b.idCategoria=c.idCategoria " _
                         & " inner join adm_subcategorias d on b.idSubCategoria=d.idSubCategoria " _
                         & " inner join adm_marcas e on b.idMarca = e.idMarca" _
                         & " where b.descripcion Like '%" & txtBusca.Text & "%' and b.idCategoria = '" & cbCategoria.SelectedValue & "'" + lv_busqueda
                tabla = "adm_servicios"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            End If
        End If
    End Sub

    Private Sub cbSubCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubCategoria.SelectedIndexChanged
        If Me.Text = "BusquedaArticulosVentas" Or Me.Text = "BusquedaArticulos" Or Me.Text = "AgregaServicio" Then
            Try
                If cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue = "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%';"
                ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue = "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and a.idSubCategoria = '" & cbSubCategoria.SelectedValue & "';"
                ElseIf cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue <> "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and a.idMarca = '" & cbMarca.SelectedValue & "';"
                ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue <> "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and a.idSubCategoria = '" & cbSubCategoria.SelectedValue & "' and a.idMarca = '" & cbMarca.SelectedValue & "';"
                End If
                txtBusca_TextChanged(txtBusca, e)
            Catch ex As Exception
                'MessageBox.Show(ex.Message, "Proveedores - btdAgregar, dpto1", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        If Me.Text = "BuscaServicio" Then
            Try
                If cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue = "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%';"
                ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue = "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and b.idSubCategoria = '" & cbSubCategoria.SelectedValue & "';"
                ElseIf cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue <> "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and b.idMarca = '" & cbMarca.SelectedValue & "';"
                ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue <> "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and b.idSubCategoria = '" & cbSubCategoria.SelectedValue & "' and b.idMarca = '" & cbMarca.SelectedValue & "';"
                End If
                txtBusca_TextChanged(txtBusca, e)
            Catch ex As Exception
                'MessageBox.Show(ex.Message, "Proveedores - btdAgregar, dpto1", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub cbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMarca.SelectedIndexChanged
        If Me.Text = "BusquedaArticulosVentas" Or Me.Text = "BusquedaArticulos" Or Me.Text = "AgregaServicio" Then
            Try
                If cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue = "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%';"
                ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue = "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and a.idSubCategoria = '" & cbSubCategoria.SelectedValue & "';"
                ElseIf cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue <> "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and a.idMarca = '" & cbMarca.SelectedValue & "';"
                ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue <> "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and a.idSubCategoria = '" & cbSubCategoria.SelectedValue & "' and a.idMarca = '" & cbMarca.SelectedValue & "';"
                End If
                txtBusca_TextChanged(txtBusca, e)
            Catch ex As Exception
                'MessageBox.Show(ex.Message, "Proveedores - btdAgregar, dpto1", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        If Me.Text = "BuscaServicio" Then
            Try
                If cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue = "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%';"
                ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue = "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and b.idSubCategoria = '" & cbSubCategoria.SelectedValue & "';"
                ElseIf cbSubCategoria.SelectedValue = "000" And cbMarca.SelectedValue <> "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and b.idMarca = '" & cbMarca.SelectedValue & "';"
                ElseIf cbSubCategoria.SelectedValue <> "000" And cbMarca.SelectedValue <> "000" Then
                    lv_busqueda = "where a.idarticulo Like '%" & txtBusca.Text & "%'and b.idSubCategoria = '" & cbSubCategoria.SelectedValue & "' and b.idMarca = '" & cbMarca.SelectedValue & "';"
                End If
                txtBusca_TextChanged(txtBusca, e)
            Catch ex As Exception
                'MessageBox.Show(ex.Message, "Proveedores - btdAgregar, dpto1", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btdOk_Click(sender As Object, e As EventArgs) Handles btdOk.Click
        If Me.Text = "BusquedaArticulosVentas" Then
            n = dgvResultado.CurrentRow.Index
            'frmVentas.txtItems.Text = frmVentas.txtItems.Text + 1
            'Try
            '    sql.Connection = cnxBD
            '    sql.CommandText = "select b.Descripcion as unidad, a." + frmVentas.cbPrecio.Text + " as precio " _
            '                    & "  from adm_catalogo a " _
            '                    & "  inner join adm_unidades b on a.idUnidad=b.idUnidad " _
            '                    & "  where a.idarticulo = '" & dgvResultado.Rows(n).Cells(0).Value & "';"
            '    sql.CommandType = CommandType.Text
            '    dr = sql.ExecuteReader()
            '    While dr.Read()
            '        lv_unidad = dr("unidad")
            '        ln_Precio = dr("precio")
            '    End While
            '    dr.Close()
            'Catch ex As Exception
            '    MessageBox.Show("Error consultando Nro. Doc., " + ex.Message, "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End Try
            'ln_Impuesto = Val(ln_Precio) * (Val(frmVentas.txtIGV.Text) / 100)
            'ln_total = Val(ln_Impuesto) + Val(ln_Precio)
            'frmVentas.dgvDetalleDoc.Rows.Add(frmVentas.txtItems.Text, dgvResultado.Rows(n).Cells(0).Value, dgvResultado.Rows(n).Cells(1).Value, dgvResultado.Rows(n).Cells(4).Value, lv_unidad, Format(ln_Precio, "0.00"), "1", Format(ln_Precio, "0.00"), Format(ln_Impuesto, "0.00"), Format(ln_total, "0.00"))
            'frmVentas.txtSubTotal.Text = Val(frmVentas.txtSubTotal.Text) + Val(ln_Precio)
            'frmVentas.txtImpuesto.Text = Val(frmVentas.txtImpuesto.Text) + Val(ln_Impuesto)
            'frmVentas.txtTotal.Text = Val(frmVentas.txtTotal.Text) + Val(ln_total)
            'ln_filas = frmVentas.dgvDetalleDoc.Rows.Count
            'ln_filas = ln_filas - 2
            'frmVentas.dgvDetalleDoc.CurrentCell = frmVentas.dgvDetalleDoc.Rows(ln_filas).Cells(6)
            'cnxBD.Close()
            Close()
        ElseIf Me.Text = "BusquedaArticulos" Then
            n = dgvResultado.CurrentRow.Index
            frmDetalleCatalogo.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            Close()
        ElseIf Me.Text = "AgregaServicio" Then
            'n = dgvResultado.CurrentRow.Index
            'frmServicios.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            'frmServicios.txtDescripcion.Text = dgvResultado.Rows(n).Cells(1).Value
            Close()
        ElseIf Me.Text = "BuscaServicio" Then
            'n = dgvResultado.CurrentRow.Index
            'frmServicios.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            'Close()
        End If
    End Sub

    Private Sub dgvResultado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultado.CellContentDoubleClick
        btdOk_Click(btdOk, e)
    End Sub
End Class