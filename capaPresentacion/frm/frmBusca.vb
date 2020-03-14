Imports CapaEntidad
Imports CapaNegocios
Public Class frmBusca
    Dim lv_operacion As String
    Dim dr As System.Data.IDataReader
    Dim lv_sw As String
    Dim consulta As String
    Dim tabla As String
    Dim n As Integer
    Dim cnAccesoDatos As New cnAccesoDatos()
    Private Sub frmBusca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Me.Text = "BusquedaClientesVentas" Then
            consulta = "select idcliente as id, nombre, nroidentificacion as identificacion from adm_clientes;"
            tabla = "adm_clientes"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 60
            dgvResultado.Columns(1).Width = 270
            dgvResultado.Columns(2).Width = 120
        End If
        If Me.Text = "BusquedaClientes" Then
            consulta = "select idcliente as id, nombre, nroidentificacion as identificacion from adm_clientes;"
            tabla = "adm_clientes"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            dgvResultado.Columns(0).Width = 60
            dgvResultado.Columns(1).Width = 270
            dgvResultado.Columns(2).Width = 120
        End If
        If Me.Text = "BusquedaProveedores" Then
            consulta = "select idProveedor as id, nombre, nroidentificacion as identificacion from adm_proveedores;"
            tabla = "adm_proveedores"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 60
            dgvResultado.Columns(1).Width = 270
            dgvResultado.Columns(2).Width = 120
        End If
        If Me.Text = "BusquedaCourier" Then
            consulta = "SELECT a.idEmpresaEnvio as ID, a.Nombre, c.Distrito as Ubicacion FROM adm_empresas_envio a INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito;"
            tabla = "adm_empresas_envio"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            dgvResultado.Columns(0).Width = 70
            dgvResultado.Columns(1).Width = 160
            dgvResultado.Columns(2).Width = 220
        End If
        If Me.Text = "BusquedaCategoria" Then
            consulta = "select idCategoria as id, Descripcion from adm_categorias;"
            tabla = "adm_categorias"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 150
            dgvResultado.Columns(1).Width = 300
        End If
        If Me.Text = "BusquedaMarcas" Then
            consulta = "select idMarca as id, Descripcion from adm_marcas;"
            tabla = "adm_marcas"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 150
            dgvResultado.Columns(1).Width = 300
        End If
        If Me.Text = "BusquedaSubCategorias" Then
            consulta = "select a.idSubCategoria as id, a.Descripcion, b.descripcion as Categoria " _
                     & "  from adm_subcategorias a  " _
                     & "  inner join adm_categorias b on a.idCategoria = b.idCategoria;"
            tabla = "adm_subcategorias"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 100
            dgvResultado.Columns(1).Width = 175
            dgvResultado.Columns(2).Width = 175
        End If
        If Me.Text = "BuscaVendedor" Then
            consulta = "select idVendedor as ID, Nombres " _
                     & "  from adm_vendedor " _
                     & "  where idEmpresa = '" & ceUsuarioActivo.idEmpresa & "';"
            tabla = "adm_vendedor"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 150
            dgvResultado.Columns(1).Width = 300
        End If
        If Me.Text = "AgregaVendedor" Then
            consulta = "select idUsuario as ID, Login as Usuario, Nombre as Nombres " _
                     & "  from adm_usuarios " _
                     & "  where idEmpresa = '" & ceUsuarioActivo.idEmpresa & "';"
            tabla = "adm_usuarios"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 80
            dgvResultado.Columns(1).Width = 120
            dgvResultado.Columns(2).Width = 250
        End If
        If Me.Text = "BuscaCtasBancos" Then
            consulta = "select a.idCuenta, b.Descripcion as Banco, a.tipoCuenta, a.NroCuenta " _
                     & "  from adm_cuentas_banco a " _
                     & " inner join adm_bancos b on a.IdBanco = b.IdBanco;"
            tabla = "adm_cuentas_banco"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Visible = False
            dgvResultado.Columns(1).Width = 250
            dgvResultado.Columns(2).Width = 100
            dgvResultado.Columns(3).Width = 100
            rbId.Visible = False
            rbNombre.Visible = False
        End If
        If Me.Text = "AgregaCtasBancos" Then
            consulta = "select IdBanco as id, Descripcion from adm_bancos;"
            tabla = "adm_bancos"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            dgvResultado.Columns(0).Width = 150
            dgvResultado.Columns(1).Width = 300
            rbId.Visible = False
            rbNombre.Visible = False
        End If
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        If Me.Text = "BusquedaClientesVentas" Then
            If rbId.Checked = True Then
                consulta = "select idcliente as id, nombre, nroidentificacion as identificacion from adm_clientes where idcliente like '%" & txtBusca.Text & "%';"
                tabla = "adm_clientes"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            End If
            If rbNombre.Checked = True Then
                consulta = "select idcliente as id, nombre, nroidentificacion as identificacion from adm_clientes where nombre like '%" & txtBusca.Text & "%';"
                tabla = "adm_clientes"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            End If
        End If
        If Me.Text = "BusquedaClientes" Then
            If rbId.Checked = True Then
                consulta = "select idcliente as id, nombre, nroidentificacion as identificacion from adm_clientes where idcliente like '%" & txtBusca.Text & "%';"
                tabla = "adm_clientes"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
            If rbNombre.Checked = True Then
                consulta = "select idcliente as id, nombre, nroidentificacion as identificacion from adm_clientes where nombre like '%" & txtBusca.Text & "%';"
                tabla = "adm_clientes"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
        End If
        If Me.Text = "BusquedaProveedores" Then
            If rbId.Checked = True Then
                consulta = "select idProveedor as id, nombre, nroidentificacion as identificacion from adm_proveedores where idProveedor like '%" & txtBusca.Text & "%';"
                tabla = "adm_proveedores"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            End If
            If rbNombre.Checked = True Then
                consulta = "select idProveedor as id, nombre, nroidentificacion as identificacion from adm_proveedores where nombre like '%" & txtBusca.Text & "%';"
                tabla = "adm_proveedores"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
            End If
        End If
        If Me.Text = "BusquedaCourier" Then
            If rbId.Checked = True Then
                consulta = "SELECT a.idEmpresaEnvio as ID, a.Nombre, c.Distrito as Ubicacion FROM adm_empresas_envio a INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito where a.idEmpresaEnvio like '%" & txtBusca.Text & "%';"
                tabla = "adm_empresas_envio"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
            If rbNombre.Checked = True Then
                consulta = "SELECT a.idEmpresaEnvio as ID, a.Nombre, c.Distrito as Ubicacion FROM adm_empresas_envio a INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito where a.nombre like '%" & txtBusca.Text & "%';"
                tabla = "adm_empresas_envio"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
        End If
        If Me.Text = "BusquedaCategoria" Then
            If rbId.Checked = True Then
                consulta = "SELECT idCategoria as id, Descripcion from adm_categorias where idCategoria like '%" & txtBusca.Text & "%';"
                tabla = "adm_categorias"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
            If rbNombre.Checked = True Then
                consulta = "SELECT idCategoria as id, Descripcion from adm_categorias where Descripcion like '%" & txtBusca.Text & "%';"
                tabla = "adm_categorias"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
        End If
        If Me.Text = "BusquedaMarcas" Then
            If rbId.Checked = True Then
                consulta = "SELECT idMarca as id, Descripcion from adm_marcas where idMarca like '%" & txtBusca.Text & "%';"
                tabla = "adm_marcas"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
            If rbNombre.Checked = True Then
                consulta = "SELECT idMarca as id, Descripcion from adm_marcas where Descripcion like '%" & txtBusca.Text & "%';"
                tabla = "adm_marcas"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
        End If
        If Me.Text = "BusquedaSubCategorias" Then
            If rbId.Checked = True Then
                consulta = "select a.idSubCategoria as id, a.Descripcion, b.descripcion as Categoria " _
                         & "  from adm_subcategorias a  " _
                         & " inner join adm_categorias b on a.idCategoria = b.idCategoria " _
                         & " where a.idSubCategoria like '%" & txtBusca.Text & "%';"
                tabla = "adm_subcategorias"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
            If rbNombre.Checked = True Then
                consulta = "select a.idSubCategoria as id, a.Descripcion, b.descripcion as Categoria " _
                         & "  from adm_subcategorias a  " _
                         & " inner join adm_categorias b on a.idCategoria = b.idCategoria " _
                         & " where a.Descripcion like '%" & txtBusca.Text & "%';"
                tabla = "adm_subcategorias"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
        End If
        If Me.Text = "AgregaVendedor" Then
            If rbId.Checked = True Then
                consulta = "select idUsuario as ID, Login as Usuario, Nombre as Nombres " _
                     & "  from adm_usuarios " _
                     & "  where idEmpresa = '" & ceUsuarioActivo.idEmpresa & "' " _
                     & "    and Login Like '%" & txtBusca.Text & "%';"
                tabla = "adm_usuarios"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
            If rbNombre.Checked = True Then
                consulta = "select idUsuario as ID, Login as Usuario, Nombre as Nombres " _
                     & "  from adm_usuarios " _
                     & "  where idEmpresa = '" & ceUsuarioActivo.idEmpresa & "' " _
                     & "    and Nombre Like '%" & txtBusca.Text & "%';"
                tabla = "adm_usuarios"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
        End If
        If Me.Text = "BuscaVendedor" Then
            If rbId.Checked = True Then
                consulta = "select idVendedor as ID, Nombres " _
                         & "  from adm_vendedor " _
                         & " where idEmpresa = '" & ceUsuarioActivo.idEmpresa & "' " _
                         & "   and idVendedor Like '%" & txtBusca.Text & "%';"
                tabla = "adm_vendedor"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
            If rbNombre.Checked = True Then
                consulta = "select idVendedor as ID, Nombres " _
                     & "  from adm_vendedor " _
                     & "  where idEmpresa = '" & ceUsuarioActivo.idEmpresa & "' " _
                     & "    and Nombres Like '%" & txtBusca.Text & "%';"
                tabla = "adm_vendedor"
                dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0) 'DS.Tables(0)
            End If
        End If
        If Me.Text = "BuscaCtasBancos" Then
            consulta = "select b.Descripcion as Banco, a.tipoCuenta, a.NroCuenta " _
                     & "  from adm_cuentas_banco a " _
                     & " inner join adm_bancos b on a.IdBanco = b.IdBanco " _
                     & " where b.Descripcion Like '%" & txtBusca.Text & "%';"
            tabla = "adm_cuentas_banco"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
        End If
        If Me.Text = "AgregaCtasBancos" Then
            consulta = "select IdBanco as id, Descripcion from adm_bancos " _
                     & " where Descripcion Like '%" & txtBusca.Text & "%';"
            tabla = "adm_bancos"
            dgvResultado.DataSource = cnAccesoDatos.LlenaComboBox(consulta, tabla).Tables(0)
        End If
    End Sub


    Private Sub dgvResultado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResultado.CellContentDoubleClick
        btdOk_Click(btdOk, e)
    End Sub

    Private Sub btdOk_Click(sender As Object, e As EventArgs) Handles btdOk.Click
        'If Me.Text = "BusquedaClientesVentas" Then
        '    n = dgvResultado.CurrentRow.Index
        '    frmVentas.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
        '    cnxBD.Close()
        '    Close()
        'End If
        If Me.Text = "BusquedaClientes" Then
            n = dgvResultado.CurrentRow.Index
            frmclientes.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            Close()
        End If
        If Me.Text = "BusquedaProveedores" Then
            n = dgvResultado.CurrentRow.Index
            frmProveedores.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            Close()
        End If
        If Me.Text = "BusquedaCourier" Then
            n = dgvResultado.CurrentRow.Index
            frmEmpresasEnvio.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            Close()
        End If
        If Me.Text = "BusquedaCategoria" Then
            'n = dgvResultado.CurrentRow.Index
            'frmCategorias.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            Close()
        End If
        If Me.Text = "BusquedaMarcas" Then
            n = dgvResultado.CurrentRow.Index
            frmMarcas.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            Close()
        End If
        If Me.Text = "BusquedaSubCategorias" Then
            'n = dgvResultado.CurrentRow.Index
            'frmSubCategoria.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            Close()
        End If
        If Me.Text = "AgregaVendedor" Then
            n = dgvResultado.CurrentRow.Index
            frmDetalleVendedores.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            frmDetalleVendedores.txtNombre.Text = dgvResultado.Rows(n).Cells(2).Value
            frmDetalleVendedores.cbIdIdentificacion.SelectedValue = 1
            frmDetalleVendedores.txtNroIdentifiacion.Select()
            Close()
        End If
        If Me.Text = "BuscaVendedor" Then
            n = dgvResultado.CurrentRow.Index
            frmDetalleVendedores.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            Close()
        End If
        If Me.Text = "BuscaCtasBancos" Then
            n = dgvResultado.CurrentRow.Index
            frmBancos.txtIdCuenta.Text = dgvResultado.Rows(n).Cells(0).Value
            Close()
        End If
        If Me.Text = "AgregaCtasBancos" Then
            n = dgvResultado.CurrentRow.Index
            frmBancos.txtId.Text = dgvResultado.Rows(n).Cells(0).Value
            frmBancos.txtNombre.Text = dgvResultado.Rows(n).Cells(1).Value
            Close()
        End If
    End Sub

    Private Sub btdCancelar_Click(sender As Object, e As EventArgs) Handles btdCancelar.Click
        Close()
    End Sub
End Class