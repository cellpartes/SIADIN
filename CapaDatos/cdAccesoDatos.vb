Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports CapaEntidad
Imports System.IO
Imports Microsoft.Office.Interop.Excel

Public Class cdAccesoDatos
    Dim objConexion As New cdConexion
    Dim da As MySqlDataAdapter
    Dim dr As System.Data.IDataReader

    Public Function VerificarLogin(usuario As String, passw As String) As Boolean
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = "Select a.idUsuario, a.Login, a.Passwd, a.idNivel, c.descripcion As nivel, a.idEmpresa, b.nombre As empresa, a.Nombre " _
                                    & "  from adm_usuarios a " _
                                    & " inner join adm_empresas b On a.idEmpresa = b.idEmpresa " _
                                    & " inner join adm_nivel_usuarios c On a.idNivel = c.idNivel " _
                                    & " where Login = '" & usuario & "' and passwd = '" & passw & "';"
                command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ceUsuarioActivo.idUsuario = reader.GetString(0)
                        ceUsuarioActivo.Login = reader.GetString(1)
                        ceUsuarioActivo.passwd = reader.GetString(2)
                        ceUsuarioActivo.idNivel = reader.GetString(3)
                        ceUsuarioActivo.Nivel = reader.GetString(4)
                        ceUsuarioActivo.idEmpresa = reader.GetString(5)
                        ceUsuarioActivo.Empresa = reader.GetString(6)
                        ceUsuarioActivo.Nombre = reader.GetString(7)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    ceUsuarioActivo.idUsuario = ""
                    ceUsuarioActivo.Login = ""
                    ceUsuarioActivo.passwd = ""
                    ceUsuarioActivo.idNivel = ""
                    ceUsuarioActivo.Nivel = ""
                    ceUsuarioActivo.idEmpresa = ""
                    ceUsuarioActivo.Empresa = ""
                    ceUsuarioActivo.Nombre = ""
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function BusquedaCiurierxId(id As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = "SELECT a.idEmpresaEnvio, a.Nombre, a.Ubigeo_Distrito, d.Departamento, e.Provincia, c.Distrito " _
                                    & "     FROM adm_empresas_envio a " _
                                    & "    INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito " _
                                    & "    INNER Join adm_departamentos d ON c.Ubigeo_Dpto = d.Ubigeo_Dpto " _
                                    & "    INNER JOIN adm_provincias e ON c.Ubigeo_Prov = e.Ubigeo_Prov " _
                                    & "    WHERE a.idEmpresaEnvio = '" & id & "';"
                command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ceEmpresas_Envio.Nombre = reader.GetString(1)
                        ceEmpresas_Envio.Ubigeo_Distrito = reader.GetString(2)
                        ceEmpresas_Envio.Departamento = reader.GetString(3)
                        ceEmpresas_Envio.Provincia = reader.GetString(4)
                        ceEmpresas_Envio.Distrito = reader.GetString(5)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    ceEmpresas_Envio.Nombre = ""
                    ceEmpresas_Envio.Ubigeo_Distrito = ""
                    ceEmpresas_Envio.Departamento = ""
                    ceEmpresas_Envio.Provincia = ""
                    ceEmpresas_Envio.Distrito = ""
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function ExcelCourier()
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                Dim n As Integer = 0
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.Range("A1").Value = "Id"
                oSheet.Range("B1").Value = "Nombre"
                oSheet.Range("C1").Value = "Departamento"
                oSheet.Range("D1").Value = "Provincia"
                oSheet.Range("E1").Value = "Distrito"
                oSheet.Range("A1:E1").Font.Bold = True
                command.Connection = cn
                command.CommandText = "SELECT a.idEmpresaEnvio, a.Nombre, d.Departamento, e.Provincia, c.Distrito " _
                                    & "  FROM adm_empresas_envio a " _
                                    & " INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito " _
                                    & " INNER Join adm_departamentos d ON c.Ubigeo_Dpto = d.Ubigeo_Dpto " _
                                    & " INNER JOIN adm_provincias e ON c.Ubigeo_Prov = e.Ubigeo_Prov;"
                command.CommandType = CommandType.Text
                dr = command.ExecuteReader()
                n = 2
                While dr.Read()
                    oSheet.Range("A" + CStr(n)).value = "'" + dr("idEmpresaEnvio")
                    oSheet.Range("B" + CStr(n)).value = dr("nombre")
                    oSheet.Range("C" + CStr(n)).value = dr("Departamento")
                    oSheet.Range("D" + CStr(n)).value = dr("Provincia")
                    oSheet.Range("E" + CStr(n)).value = dr("Distrito")
                    n = n + 1
                End While
                oSheet.Range("A1:E" + CStr(n)).Columns.AutoFit()
                n = 0
                oExcel.ActiveWorkbook.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ListadoCourier.xlsx")
                oExcel.Quit
                Return True
            End Using
        End Using
    End Function
    Public Function LlenaComboBox(sql As String, tabla As String) As DataSet
        Using cn = objConexion.conectar
            cn.Open()
            Dim ds As New DataSet
            da = New MySqlDataAdapter(sql, cn)
            da.Fill(ds, tabla)
            Return ds
        End Using
    End Function
    Public Function ValorTabla(sql As String) As Integer
        Using cn = objConexion.conectar
            cn.Open()
            Dim r As Integer
            da = New MySqlDataAdapter(sql, cn)
            r = da.SelectCommand.ExecuteScalar
            Return r
        End Using
    End Function
    Public Function DMLTabla(sql As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = sql
                command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function
    Public Function BusquedaClientexId(id As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = "SELECT a.Nombre, a.IdTpIdentificacion, b.Descripcion, a.NroIdentificacion, a.Ubigeo_Distrito, " _
                                    & "       d.Departamento, e.Provincia, c.Distrito, a.Direccion, a.Telefonos, a.email, a.WhatsApp, a.NombreContacto, " _
                                    & "       a.TelefonoContacto, a.idZona, f.Descripcion as Zona " _
                                    & "  FROM adm_clientes a " _
                                    & " INNER JOIN adm_tipos_identificacion b ON a.IdTpIdentificacion = b.IdTpIdentificacion " _
                                    & " INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito " _
                                    & " INNER Join adm_departamentos d ON c.Ubigeo_Dpto = d.Ubigeo_Dpto " _
                                    & " INNER JOIN adm_provincias e ON c.Ubigeo_Prov = e.Ubigeo_Prov " _
                                    & " INNER JOIN adm_zonas f ON a.idZona = f.idZona " _
                                    & " WHERE a.idCliente = '" & id & "';"
                command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ceClientes.Nombre = reader.GetString(0)
                        ceClientes.IdTpIdentificacion = reader.GetString(1)
                        ceClientes.TpIdentificacion = reader.GetString(2)
                        ceClientes.NroIdentificacion = reader.GetString(3)
                        ceClientes.Ubigeo_Distrito = reader.GetString(4)
                        ceClientes.Departamento = reader.GetString(5)
                        ceClientes.Provincia = reader.GetString(6)
                        ceClientes.Distrito = reader.GetString(7)
                        ceClientes.Direccion = reader.GetString(8)
                        ceClientes.Telefonos = reader.GetString(9)
                        ceClientes.email = reader.GetString(10)
                        ceClientes.WhatsApp = reader.GetString(11)
                        ceClientes.NombreContacto = reader.GetString(12)
                        ceClientes.TelefonoContacto = reader.GetString(13)
                        ceClientes.idZona = reader.GetString(14)
                        ceClientes.Zona = reader.GetString(15)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    ceClientes.Nombre = ""
                    ceClientes.IdTpIdentificacion = ""
                    ceClientes.TpIdentificacion = ""
                    ceClientes.NroIdentificacion = ""
                    ceClientes.Ubigeo_Distrito = ""
                    ceClientes.Departamento = ""
                    ceClientes.Provincia = ""
                    ceClientes.Distrito = ""
                    ceClientes.Direccion = ""
                    ceClientes.Telefonos = ""
                    ceClientes.email = ""
                    ceClientes.WhatsApp = ""
                    ceClientes.NombreContacto = ""
                    ceClientes.TelefonoContacto = ""
                    ceClientes.idZona = ""
                    ceClientes.Zona = ""
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function ExcelClientes()
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                Dim n As Integer = 0
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.Range("A1").Value = "Id"
                oSheet.Range("B1").Value = "Nombre"
                oSheet.Range("C1").Value = "Tipo Indentificacion"
                oSheet.Range("D1").Value = "Nro. Identificacion"
                oSheet.Range("E1").Value = "Departamento"
                oSheet.Range("F1").Value = "Provincia"
                oSheet.Range("G1").Value = "Distrito"
                oSheet.Range("H1").Value = "Direccion"
                oSheet.Range("I1").Value = "Telefonos"
                oSheet.Range("J1").Value = "email"
                oSheet.Range("K1").Value = "WhatsApp"
                oSheet.Range("L1").Value = "Nombre Contacto"
                oSheet.Range("M1").Value = "Telefono Contacto"
                oSheet.Range("N1").Value = "Zona"
                oSheet.Range("A1:N1").Font.Bold = True
                command.Connection = cn
                command.CommandText = "SELECT a.idCliente, a.Nombre, b.Descripcion as tpIdentificacion, a.NroIdentificacion, d.Departamento, e.Provincia, " _
                                    & "       c.Distrito, a.Direccion, a.Telefonos, a.email, a.WhatsApp, a.NombreContacto, a.TelefonoContacto, f.Descripcion as Zona" _
                                    & "  FROM adm_clientes a " _
                                    & " INNER JOIN adm_tipos_identificacion b ON a.IdTpIdentificacion = b.IdTpIdentificacion " _
                                    & " INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito " _
                                    & " INNER Join adm_departamentos d ON c.Ubigeo_Dpto = d.Ubigeo_Dpto " _
                                    & " INNER JOIN adm_provincias e ON c.Ubigeo_Prov = e.Ubigeo_Prov " _
                                    & " INNER JOIN adm_zonas f ON a.idZona = f.idZona;"
                command.CommandType = CommandType.Text
                dr = command.ExecuteReader()
                n = 2
                While dr.Read()
                    oSheet.Range("A" + CStr(n)).value = "'" + dr("idCliente")
                    oSheet.Range("B" + CStr(n)).value = dr("nombre")
                    oSheet.Range("C" + CStr(n)).value = dr("tpIdentificacion")
                    oSheet.Range("D" + CStr(n)).value = dr("NroIdentificacion")
                    oSheet.Range("E" + CStr(n)).value = dr("Departamento")
                    oSheet.Range("F" + CStr(n)).value = dr("Provincia")
                    oSheet.Range("G" + CStr(n)).value = dr("Distrito")
                    oSheet.Range("H" + CStr(n)).value = dr("Direccion")
                    oSheet.Range("I" + CStr(n)).value = dr("Telefonos")
                    oSheet.Range("J" + CStr(n)).value = dr("email")
                    oSheet.Range("K" + CStr(n)).value = dr("WhatsApp")
                    oSheet.Range("L" + CStr(n)).value = dr("NombreContacto")
                    oSheet.Range("M" + CStr(n)).value = dr("TelefonoContacto")
                    oSheet.Range("N" + CStr(n)).value = dr("Zona")
                    n = n + 1
                End While
                oSheet.Range("A1:N" + CStr(n)).Columns.AutoFit()
                n = 0
                oExcel.ActiveWorkbook.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ListadoClientes.xlsx")
                oExcel.Quit
                Return True
            End Using
        End Using
    End Function
    Public Function BusquedaProveedorxId(id As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = "SELECT a.Nombre, a.IdTpIdentificacion, b.Descripcion, a.NroIdentificacion, a.Ubigeo_Distrito, " _
                                    & "       d.Departamento, e.Provincia, c.Distrito, a.Direccion, a.Telefonos, a.email, a.WhatsApp, a.NombreContacto, " _
                                    & "       a.TelefonoContacto, a.idZona, f.Descripcion as Zona " _
                                    & "  FROM adm_proveedores a " _
                                    & " INNER JOIN adm_tipos_identificacion b ON a.IdTpIdentificacion = b.IdTpIdentificacion " _
                                    & " INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito " _
                                    & " INNER Join adm_departamentos d ON c.Ubigeo_Dpto = d.Ubigeo_Dpto " _
                                    & " INNER JOIN adm_provincias e ON c.Ubigeo_Prov = e.Ubigeo_Prov " _
                                    & " INNER JOIN adm_zonas f ON a.idZona = f.idZona " _
                                    & " WHERE a.idProveedor = '" & id & "';"
                command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ceProveedores.Nombre = reader.GetString(0)
                        ceProveedores.IdTpIdentificacion = reader.GetString(1)
                        ceProveedores.TpIdentificacion = reader.GetString(2)
                        ceProveedores.NroIdentificacion = reader.GetString(3)
                        ceProveedores.Ubigeo_Distrito = reader.GetString(4)
                        ceProveedores.Departamento = reader.GetString(5)
                        ceProveedores.Provincia = reader.GetString(6)
                        ceProveedores.Distrito = reader.GetString(7)
                        ceProveedores.Direccion = reader.GetString(8)
                        ceProveedores.Telefonos = reader.GetString(9)
                        ceProveedores.email = reader.GetString(10)
                        ceProveedores.WhatsApp = reader.GetString(11)
                        ceProveedores.NombreContacto = reader.GetString(12)
                        ceProveedores.TelefonoContacto = reader.GetString(13)
                        ceProveedores.idZona = reader.GetString(14)
                        ceProveedores.Zona = reader.GetString(15)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    ceProveedores.Nombre = ""
                    ceProveedores.IdTpIdentificacion = ""
                    ceProveedores.TpIdentificacion = ""
                    ceProveedores.NroIdentificacion = ""
                    ceProveedores.Ubigeo_Distrito = ""
                    ceProveedores.Departamento = ""
                    ceProveedores.Provincia = ""
                    ceProveedores.Distrito = ""
                    ceProveedores.Direccion = ""
                    ceProveedores.Telefonos = ""
                    ceProveedores.email = ""
                    ceProveedores.WhatsApp = ""
                    ceProveedores.NombreContacto = ""
                    ceProveedores.TelefonoContacto = ""
                    ceProveedores.idZona = ""
                    ceProveedores.Zona = ""
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function ExcelProveedores()
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                Dim n As Integer = 0
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.Range("A1").Value = "Id"
                oSheet.Range("B1").Value = "Nombre"
                oSheet.Range("C1").Value = "Tipo Indentificacion"
                oSheet.Range("D1").Value = "Nro. Identificacion"
                oSheet.Range("E1").Value = "Departamento"
                oSheet.Range("F1").Value = "Provincia"
                oSheet.Range("G1").Value = "Distrito"
                oSheet.Range("H1").Value = "Direccion"
                oSheet.Range("I1").Value = "Telefonos"
                oSheet.Range("J1").Value = "email"
                oSheet.Range("K1").Value = "WhatsApp"
                oSheet.Range("L1").Value = "Nombre Contacto"
                oSheet.Range("M1").Value = "Telefono Contacto"
                oSheet.Range("N1").Value = "Zona"
                oSheet.Range("A1:N1").Font.Bold = True
                command.Connection = cn
                command.CommandText = "SELECT a.idProveedor, a.Nombre, b.Descripcion as tpIdentificacion, a.NroIdentificacion, d.Departamento, e.Provincia, " _
                                    & "       c.Distrito, a.Direccion, a.Telefonos, a.email, a.WhatsApp, a.NombreContacto, a.TelefonoContacto, f.Descripcion as Zona" _
                                    & "  FROM adm_proveedores a " _
                                    & " INNER JOIN adm_tipos_identificacion b ON a.IdTpIdentificacion = b.IdTpIdentificacion " _
                                    & " INNER JOIN adm_distritos c ON a.Ubigeo_Distrito = c.Ubigeo_Distrito " _
                                    & " INNER Join adm_departamentos d ON c.Ubigeo_Dpto = d.Ubigeo_Dpto " _
                                    & " INNER JOIN adm_provincias e ON c.Ubigeo_Prov = e.Ubigeo_Prov " _
                                    & " INNER JOIN adm_zonas f ON a.idZona = f.idZona;"
                command.CommandType = CommandType.Text
                dr = command.ExecuteReader()
                n = 2
                While dr.Read()
                    oSheet.Range("A" + CStr(n)).value = "'" + dr("idProveedor")
                    oSheet.Range("B" + CStr(n)).value = dr("nombre")
                    oSheet.Range("C" + CStr(n)).value = dr("tpIdentificacion")
                    oSheet.Range("D" + CStr(n)).value = dr("NroIdentificacion")
                    oSheet.Range("E" + CStr(n)).value = dr("Departamento")
                    oSheet.Range("F" + CStr(n)).value = dr("Provincia")
                    oSheet.Range("G" + CStr(n)).value = dr("Distrito")
                    oSheet.Range("H" + CStr(n)).value = dr("Direccion")
                    oSheet.Range("I" + CStr(n)).value = dr("Telefonos")
                    oSheet.Range("J" + CStr(n)).value = dr("email")
                    oSheet.Range("K" + CStr(n)).value = dr("WhatsApp")
                    oSheet.Range("L" + CStr(n)).value = dr("NombreContacto")
                    oSheet.Range("M" + CStr(n)).value = dr("TelefonoContacto")
                    oSheet.Range("N" + CStr(n)).value = dr("Zona")
                    n = n + 1
                End While
                oSheet.Range("A1:N" + CStr(n)).Columns.AutoFit()
                n = 0
                oExcel.ActiveWorkbook.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ListadoProveedores.xlsx")
                oExcel.Quit
                Return True
            End Using
        End Using
    End Function
    Public Function OperacionesImg(ByVal sql As String, ByVal imagen As Object, ByVal imagenBck As Object)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim MS As New MemoryStream
                Dim Imagenes() As Byte = MS.GetBuffer
                Dim cmd As New MySqlCommand(sql, cn)
                command.Connection = cn
                command.CommandText = sql
                Try
                    imagen.Image.Save(MS, imagen.Image.RawFormat)
                Catch ex As Exception
                    imagenBck.Image.Save(MS, imagenBck.Image.RawFormat)
                End Try
                command.Parameters.AddWithValue("@imagen", Imagenes)
                command.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function
    Public Function BusquedaCatalogoxId(id As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = "select a.Descripcion, a.idCategoria, b.Descripcion as Categoria, a.idSubCategoria, c.descripcion as SubCategoria, a.idMarca,  " _
                                & "       d.descripcion as Marca, a.idUnidad, e.descripcion as unidad, a.localizacion, a.StockMin, a.StockMax, a.factor, a.precioCompra, " _
                                & "       a.preCompraProm, a.margen1, a.margen2, a.margen3, a.margen4, a.margen5, a.precio1, a.precio2, a.precio3, a.precio4, a.precio5,  " _
                                & "       a.mayoreo1, a.mayoreo2, a.mayoreo3, a.Mayoreo4, a.Mayoreo5, case a.Activo when 'S' then 'Si' else 'No' end as Activo, " _
                                & "       case a.Frecuente when 'S' then 'Si' else 'No' end as Frecuente, case a.Servicio when 'S' then 'Si' else 'No' end as Servicio,  " _
                                & "       ifnull(a.rutaimagen,'') as rutaimagen, a.FechaUltMov " _
                                & "  from adm_catalogo a " _
                                & " inner join adm_categorias b on a.idCategoria = b.idCategoria " _
                                & " inner join adm_subcategorias c on a.idCategoria = c.idCategoria and a.idSubCategoria = c.idSubCategoria " _
                                & " inner join adm_marcas d on a.idMarca = d.idMarca " _
                                & " inner join adm_unidades e on a.idUnidad = e.idUnidad " _
                                & " where a.idArticulo = '" & id & "';"
                command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ceCatalogo.Descripcion = reader.GetString(0)
                        ceCatalogo.idCategoria = reader.GetString(1)
                        ceCatalogo.Categoria = reader.GetString(2)
                        ceCatalogo.idSubCategoria = reader.GetString(3)
                        ceCatalogo.SubCategoria = reader.GetString(4)
                        ceCatalogo.idMarca = reader.GetString(5)
                        ceCatalogo.Marca = reader.GetString(6)
                        ceCatalogo.idUnidad = reader.GetString(7)
                        ceCatalogo.Unidad = reader.GetString(8)
                        ceCatalogo.localizacion = reader.GetString(9)
                        ceCatalogo.StockMin = reader.GetInt64(10)
                        ceCatalogo.StockMax = reader.GetInt64(11)
                        ceCatalogo.factor = reader.GetDouble(12)
                        ceCatalogo.precioCompra = reader.GetDouble(13)
                        ceCatalogo.preCompraProm = reader.GetDouble(14)
                        ceCatalogo.margen1 = reader.GetDouble(15)
                        ceCatalogo.margen2 = reader.GetDouble(16)
                        ceCatalogo.margen3 = reader.GetDouble(17)
                        ceCatalogo.margen4 = reader.GetDouble(18)
                        ceCatalogo.margen5 = reader.GetDouble(19)
                        ceCatalogo.precio1 = reader.GetDouble(20)
                        ceCatalogo.precio2 = reader.GetDouble(21)
                        ceCatalogo.precio3 = reader.GetDouble(22)
                        ceCatalogo.precio4 = reader.GetDouble(23)
                        ceCatalogo.precio5 = reader.GetDouble(24)
                        ceCatalogo.mayoreo1 = reader.GetDouble(25)
                        ceCatalogo.mayoreo2 = reader.GetDouble(26)
                        ceCatalogo.mayoreo3 = reader.GetDouble(27)
                        ceCatalogo.Mayoreo4 = reader.GetDouble(28)
                        ceCatalogo.Mayoreo5 = reader.GetDouble(29)
                        ceCatalogo.Activo = reader.GetString(30)
                        ceCatalogo.Frecuente = reader.GetString(31)
                        ceCatalogo.Servicio = reader.GetString(32)
                        ceCatalogo.RutaImagen = reader.GetString(33)
                        ceCatalogo.FechaUltMov = reader.GetDateTime(34)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    ceCatalogo.Descripcion = ""
                    ceCatalogo.idCategoria = ""
                    ceCatalogo.Categoria = ""
                    ceCatalogo.idSubCategoria = ""
                    ceCatalogo.SubCategoria = ""
                    ceCatalogo.idMarca = ""
                    ceCatalogo.Marca = ""
                    ceCatalogo.idUnidad = ""
                    ceCatalogo.Unidad = ""
                    ceCatalogo.localizacion = ""
                    ceCatalogo.StockMin = ""
                    ceCatalogo.StockMax = ""
                    ceCatalogo.factor = ""
                    ceCatalogo.precioCompra = ""
                    ceCatalogo.preCompraProm = ""
                    ceCatalogo.margen1 = ""
                    ceCatalogo.margen2 = ""
                    ceCatalogo.margen3 = ""
                    ceCatalogo.margen4 = ""
                    ceCatalogo.margen5 = ""
                    ceCatalogo.precio1 = ""
                    ceCatalogo.precio2 = ""
                    ceCatalogo.precio3 = ""
                    ceCatalogo.precio4 = ""
                    ceCatalogo.precio5 = ""
                    ceCatalogo.mayoreo1 = ""
                    ceCatalogo.mayoreo2 = ""
                    ceCatalogo.mayoreo3 = ""
                    ceCatalogo.Mayoreo4 = ""
                    ceCatalogo.Mayoreo5 = ""
                    ceCatalogo.Activo = ""
                    ceCatalogo.Frecuente = ""
                    ceCatalogo.Servicio = ""
                    ceCatalogo.RutaImagen = ""
                    ceCatalogo.FechaUltMov = ""
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function ExcelCatalogoDinamico(consulta As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                Dim n As Integer = 0
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.Range("A1").Value = "Id"
                oSheet.Range("B1").Value = "Descripcion"
                oSheet.Range("C1").Value = "Categoria"
                oSheet.Range("D1").Value = "SubCategoria"
                oSheet.Range("E1").Value = "Marca"
                oSheet.Range("F1").Value = "Unidad"
                oSheet.Range("G1").Value = "Localizacion"
                oSheet.Range("H1").Value = "Activo"
                oSheet.Range("I1").Value = "Frecuente"
                oSheet.Range("J1").Value = "Servicio"
                oSheet.Range("A1:J1").Font.Bold = True
                command.Connection = cn
                command.CommandText = consulta
                command.CommandType = CommandType.Text
                dr = command.ExecuteReader()
                n = 2
                While dr.Read()
                    oSheet.Range("A" + CStr(n)).Value = "'" + dr("Id")
                    oSheet.Range("B" + CStr(n)).Value = dr("Descripcion")
                    oSheet.Range("C" + CStr(n)).Value = dr("Categoria")
                    oSheet.Range("D" + CStr(n)).Value = dr("SubCategoria")
                    oSheet.Range("E" + CStr(n)).Value = dr("Marca")
                    oSheet.Range("F" + CStr(n)).Value = dr("Unidad")
                    oSheet.Range("G" + CStr(n)).Value = dr("Localizacion")
                    oSheet.Range("H" + CStr(n)).Value = dr("Activo")
                    oSheet.Range("I" + CStr(n)).Value = dr("Frecuente")
                    oSheet.Range("J" + CStr(n)).Value = dr("Servicio")
                    n = n + 1
                End While
                dr.Close()
                oSheet.Range("A1:J1" + CStr(n)).Columns.AutoFit()
                n = 0
                oExcel.ActiveWorkbook.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ListadoCatalogo.xlsx")
                oExcel.Quit
                Return True
            End Using
        End Using
    End Function
    Public Function ExcelCatalogo()
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                Dim n As Integer = 0
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.Range("A1").Value = "Id"
                oSheet.Range("B1").Value = "Descripcion"
                oSheet.Range("C1").Value = "Categoria"
                oSheet.Range("D1").Value = "SubCategoria"
                oSheet.Range("E1").Value = "Marca"
                oSheet.Range("F1").Value = "Unidad"
                oSheet.Range("G1").Value = "Localizacion"
                oSheet.Range("H1").Value = "Stock Minimo"
                oSheet.Range("I1").Value = "Stock Maximo"
                oSheet.Range("J1").Value = "Factor"
                oSheet.Range("K1").Value = "Precio Compra"
                oSheet.Range("L1").Value = "Precio Compra Promedio"
                oSheet.Range("M1").Value = "Margen 1"
                oSheet.Range("N1").Value = "Margen 2"
                oSheet.Range("O1").Value = "Margen 3"
                oSheet.Range("P1").Value = "Margen 4"
                oSheet.Range("Q1").Value = "Margen 5"
                oSheet.Range("R1").Value = "Precio 1"
                oSheet.Range("S1").Value = "Precio 2"
                oSheet.Range("T1").Value = "Precio 3"
                oSheet.Range("U1").Value = "Precio 4"
                oSheet.Range("V1").Value = "Precio 5"
                oSheet.Range("W1").Value = "Mayoreo 1"
                oSheet.Range("X1").Value = "Mayoreo 2"
                oSheet.Range("Y1").Value = "Mayoreo 3"
                oSheet.Range("Z1").Value = "Mayoreo 4"
                oSheet.Range("AA1").Value = "Mayoreo 5"
                oSheet.Range("AB1").Value = "Activo"
                oSheet.Range("AC1").Value = "Frecuente"
                oSheet.Range("AD1").Value = "Fecha Ultimo Movimiento"
                oSheet.Range("AE1").Value = "Servicio"
                oSheet.Range("A1: N1").Font.Bold = True
                command.Connection = cn
                command.CommandText = "SELECT a.idArticulo, a.Descripcion, a.idCategoria, b.Descripcion as Categoria, a.idSubCategoria, c.descripcion as SubCategoria, a.idMarca,  " _
                                & "       d.descripcion as Marca, a.idUnidad, e.descripcion as unidad, a.localizacion, a.StockMin, a.StockMax, a.factor, a.precioCompra, " _
                                & "       a.preCompraProm, a.margen1, a.margen2, a.margen3, a.margen4, a.margen5, a.precio1, a.precio2, a.precio3, a.precio4, a.precio5,  " _
                                & "       a.mayoreo1, a.mayoreo2, a.mayoreo3, a.Mayoreo4, a.Mayoreo5, case a.Activo when 'S' then 'Si' else 'No' end as Activo, " _
                                & "       case a.Frecuente when 'S' then 'Si' else 'No' end as Frecuente, case a.Servicio when 'S' then 'Si' else 'No' end as Servicio, " _
                                & "       ifnull(a.FechaUltMov,'') as FechaUltMov  " _
                                & "  FROM adm_catalogo a " _
                                & " inner join adm_categorias b on a.idCategoria = b.idCategoria " _
                                & " inner join adm_subcategorias c on a.idCategoria = c.idCategoria and a.idSubCategoria = c.idSubCategoria " _
                                & " inner join adm_marcas d on a.idMarca = d.idMarca " _
                                & " inner join adm_unidades e on a.idUnidad = e.idUnidad;"
                command.CommandType = CommandType.Text
                dr = command.ExecuteReader()
                n = 2
                While dr.Read()
                    oSheet.Range("A" + CStr(n)).value = "'" + dr("idArticulo")
                    oSheet.Range("B" + CStr(n)).value = dr("Descripcion")
                    oSheet.Range("C" + CStr(n)).value = dr("Categoria")
                    oSheet.Range("D" + CStr(n)).value = dr("SubCategoria")
                    oSheet.Range("E" + CStr(n)).value = dr("Marca")
                    oSheet.Range("F" + CStr(n)).value = dr("unidad")
                    oSheet.Range("G" + CStr(n)).value = dr("localizacion")
                    oSheet.Range("H" + CStr(n)).value = dr("StockMin")
                    oSheet.Range("I" + CStr(n)).value = dr("StockMax")
                    oSheet.Range("J" + CStr(n)).value = dr("factor")
                    oSheet.Range("K" + CStr(n)).value = dr("precioCompra")
                    oSheet.Range("L" + CStr(n)).value = dr("preCompraProm")
                    oSheet.Range("M" + CStr(n)).value = dr("margen1")
                    oSheet.Range("N" + CStr(n)).value = dr("margen2")
                    oSheet.Range("O" + CStr(n)).Value = dr("margen3")
                    oSheet.Range("P" + CStr(n)).Value = dr("margen4")
                    oSheet.Range("Q" + CStr(n)).Value = dr("margen5")
                    oSheet.Range("R" + CStr(n)).Value = dr("precio1")
                    oSheet.Range("S" + CStr(n)).Value = dr("precio2")
                    oSheet.Range("T" + CStr(n)).Value = dr("precio3")
                    oSheet.Range("U" + CStr(n)).Value = dr("precio4")
                    oSheet.Range("V" + CStr(n)).Value = dr("precio5")
                    oSheet.Range("W" + CStr(n)).Value = dr("mayoreo1")
                    oSheet.Range("X" + CStr(n)).Value = dr("mayoreo2")
                    oSheet.Range("Y" + CStr(n)).Value = dr("mayoreo3")
                    oSheet.Range("Z" + CStr(n)).Value = dr("Mayoreo4")
                    oSheet.Range("AA" + CStr(n)).Value = dr("Mayoreo5")
                    oSheet.Range("AB" + CStr(n)).Value = dr("Activo")
                    oSheet.Range("AC" + CStr(n)).Value = dr("Frecuente")
                    oSheet.Range("AD" + CStr(n)).Value = dr("FechaUltMov")
                    oSheet.Range("AE" + CStr(n)).Value = dr("Servicio")
                    n = n + 1
                End While
                dr.Close()
                oSheet.Range("A1:N" + CStr(n)).Columns.AutoFit()
                n = 0
                oExcel.ActiveWorkbook.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ListadoCatalogo.xlsx")
                oExcel.Quit
                Return True
            End Using
        End Using
    End Function
    Public Function BusquedaCategoriaxId(id As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = "SELECT idCategoria, Descripcion FROM adm_categorias WHERE idCategoria = '" & id & "';"
                command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ceCategorias.idCategoria = reader.GetString(0)
                        ceCategorias.Descripcion = reader.GetString(1)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    ceCategorias.idCategoria = ""
                    ceCategorias.Descripcion = ""
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function ExcelDinamicoCategoria(consulta As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                Dim n As Integer = 0
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.Range("A1").Value = "Id"
                oSheet.Range("B1").Value = "Descripcion"
                oSheet.Range("A1:B1").Font.Bold = True
                command.Connection = cn
                command.CommandText = consulta
                'command.CommandText = "SELECT idCategoria, Descripcion FROM adm_categorias;"
                command.CommandType = CommandType.Text
                dr = command.ExecuteReader()
                n = 2
                While dr.Read()
                    oSheet.Range("A" + CStr(n)).value = "'" + dr("id")
                    oSheet.Range("B" + CStr(n)).value = dr("Descripcion")
                    n = n + 1
                End While
                oSheet.Range("A1:B" + CStr(n)).Columns.AutoFit()
                n = 0
                oExcel.ActiveWorkbook.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ListadoCategorias.xlsx")
                oExcel.Quit
                Return True
            End Using
        End Using
    End Function
    Public Function BusquedaMarcaxId(id As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = "SELECT idMarca, Descripcion FROM adm_marcas WHERE idMarca = '" & id & "';"
                command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ceMarcas.idMarca = reader.GetString(0)
                        ceMarcas.Descripcion = reader.GetString(1)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    ceMarcas.idMarca = ""
                    ceMarcas.Descripcion = ""
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function ExcelMarcas()
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                Dim n As Integer = 0
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.Range("A1").Value = "Id"
                oSheet.Range("B1").Value = "Descripcion"
                oSheet.Range("A1:B1").Font.Bold = True
                command.Connection = cn
                command.CommandText = "SELECT idMarca, Descripcion FROM adm_marcas;"
                command.CommandType = CommandType.Text
                dr = command.ExecuteReader()
                n = 2
                While dr.Read()
                    oSheet.Range("A" + CStr(n)).value = "'" + dr("idMarca")
                    oSheet.Range("B" + CStr(n)).value = dr("Descripcion")
                    n = n + 1
                End While
                oSheet.Range("A1:B" + CStr(n)).Columns.AutoFit()
                n = 0
                oExcel.ActiveWorkbook.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ListadoMarcas.xlsx")
                oExcel.Quit
                Return True
            End Using
        End Using
    End Function
    Public Function BusquedaSubCategoriaxId(id As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = "select a.idSubCategoria as id, a.Descripcion, a.idCategoria, b.descripcion as Categoria " _
                                    & "  from adm_subcategorias a  " _
                                    & " inner join adm_categorias b on a.idCategoria = b.idCategoria " _
                                    & " where a.idSubCategoria = '" & id & "';"
                command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ceSubCategorias.idSubCategoria = reader.GetString(0)
                        ceSubCategorias.Descripcion = reader.GetString(1)
                        ceSubCategorias.idCategoria = reader.GetString(2)
                        ceSubCategorias.Categoria = reader.GetString(3)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    ceSubCategorias.idSubCategoria = ""
                    ceSubCategorias.Descripcion = ""
                    ceSubCategorias.idCategoria = ""
                    ceSubCategorias.Categoria = ""
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function ExcelDinamicoSubCategoria(consulta As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                Dim n As Integer = 0
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.Range("A1").Value = "Id"
                oSheet.Range("B1").Value = "Descripcion"
                oSheet.Range("C1").Value = "Categoria"
                oSheet.Range("A1:C1").Font.Bold = True
                command.Connection = cn
                command.CommandText = consulta
                command.CommandType = CommandType.Text
                dr = command.ExecuteReader()
                n = 2
                While dr.Read()
                    oSheet.Range("A" + CStr(n)).value = "'" + dr("id")
                    oSheet.Range("B" + CStr(n)).value = dr("Descripcion")
                    oSheet.Range("C" + CStr(n)).value = "'" + dr("Categoria")
                    n = n + 1
                End While
                oSheet.Range("A1:C" + CStr(n)).Columns.AutoFit()
                n = 0
                oExcel.ActiveWorkbook.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ListadoSubCategorias.xlsx")
                oExcel.Quit
                Return True
            End Using
        End Using
    End Function
    Public Function BusquedaVendedorxId(id As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = "select a.idVendedor, a.Nombres, a.idTpIdentificacion, " _
                                    & "       b.descripcion as TpIdentificacion, a.NroIdentifiacion, " _
                                    & "       a.idZona, c.Descripcion As Zona, a.idEmpresa, a.idUsuario, " _
                                    & "       a.idCaja, d.Descripcion As Caja " _
                                    & " from adm_vendedor a " _
                                    & " inner join adm_tipos_identificacion b on a.idTpIdentificacion = b.idTpIdentificacion " _
                                    & " inner join adm_zonas c on a.idZona = c.idZona " _
                                    & " inner join adm_cajas d on a.idCaja = d.idCaja " _
                                    & " where a.idVendedor = '" & id & "';"
                command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ceVendedor.idVendedor = reader.GetString(0)
                        ceVendedor.Nombres = reader.GetString(1)
                        ceVendedor.idTpIdentificacion = reader.GetString(2)
                        ceVendedor.TpIdentificacion = reader.GetString(3)
                        ceVendedor.NroIdentifiacion = reader.GetString(4)
                        ceVendedor.idZona = reader.GetString(5)
                        ceVendedor.Zona = reader.GetString(6)
                        ceVendedor.idEmpresa = reader.GetString(7)
                        ceVendedor.idUsuario = reader.GetString(8)
                        ceVendedor.idCaja = reader.GetString(9)
                        ceVendedor.Caja = reader.GetString(10)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    ceVendedor.idVendedor = ""
                    ceVendedor.Nombres = ""
                    ceVendedor.idTpIdentificacion = ""
                    ceVendedor.TpIdentificacion = ""
                    ceVendedor.NroIdentifiacion = ""
                    ceVendedor.idZona = ""
                    ceVendedor.Zona = ""
                    ceVendedor.idEmpresa = ""
                    ceVendedor.idUsuario = ""
                    ceVendedor.idCaja = ""
                    ceVendedor.Caja = ""
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function ExcelDinamicoVendedores(consulta As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                Dim n As Integer = 0
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.Range("A1").Value = "Id"
                oSheet.Range("B1").Value = "Nombres"
                oSheet.Range("C1").Value = "Tipo Identificación"
                oSheet.Range("D1").Value = "Nro. Identificación"
                oSheet.Range("E1").Value = "Zona"
                oSheet.Range("F1").Value = "idEmpresa"
                oSheet.Range("G1").Value = "Caja"
                oSheet.Range("A1:G1").Font.Bold = True
                command.Connection = cn
                command.CommandText = consulta
                command.CommandType = CommandType.Text
                dr = command.ExecuteReader()
                n = 2
                While dr.Read()
                    oSheet.Range("A" + CStr(n)).value = "'" + dr("idVendedor")
                    oSheet.Range("B" + CStr(n)).value = dr("Nombres")
                    oSheet.Range("C" + CStr(n)).value = dr("TipoIdentificacion")
                    oSheet.Range("D" + CStr(n)).value = "'" + dr("NroIdentifiacion")
                    oSheet.Range("E" + CStr(n)).value = dr("Zona")
                    oSheet.Range("F" + CStr(n)).value = "'" + dr("Empresa")
                    oSheet.Range("G" + CStr(n)).value = dr("Caja")

                    n = n + 1
                End While
                oSheet.Range("A1:H" + CStr(n)).Columns.AutoFit()
                n = 0
                oExcel.ActiveWorkbook.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ListadoVendedores.xlsx")
                oExcel.Quit
                Return True
            End Using
        End Using
    End Function
    Public Function ExcelDinamicoServicios(consulta As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                Dim n As Integer = 0
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.Range("A1").Value = "Id"
                oSheet.Range("B1").Value = "Descripcion"
                oSheet.Range("C1").Value = "Categoria"
                oSheet.Range("D1").Value = "SubCategoria"
                oSheet.Range("E1").Value = "Marca"
                oSheet.Range("A1:E1").Font.Bold = True
                command.Connection = cn
                command.CommandText = consulta
                command.CommandType = CommandType.Text
                dr = command.ExecuteReader()
                n = 2
                While dr.Read()
                    oSheet.Range("A" + CStr(n)).value = "'" + dr("idArticulo")
                    oSheet.Range("B" + CStr(n)).value = dr("descripcion")
                    oSheet.Range("C" + CStr(n)).value = dr("categoria")
                    oSheet.Range("D" + CStr(n)).value = dr("subcategoria")
                    oSheet.Range("E" + CStr(n)).value = dr("marca")
                    n = n + 1
                End While
                oSheet.Range("A1:I" + CStr(n)).Columns.AutoFit()
                n = 0
                oExcel.ActiveWorkbook.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ListadoServicios.xlsx")
                oExcel.Quit
                Return True
            End Using
        End Using
    End Function
    Public Function BusquedaServicioxId(id As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = "Select a.idArticulo, b.descripcion, a.monto, a.idEmpresa, " _
                                    & "       case a.Activo when 'S' then 'Si' else 'No' end activo, " _
                                    & "       a.FechaUltMov " _
                                    & "  from adm_servicios a " _
                                    & " inner join adm_catalogo b On a.idArticulo = b.idArticulo " _
                                    & " where a.idArticulo = '" & id & "';"
                command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ceServicios.idArticulo = reader.GetString(0)
                        ceServicios.Descripcion = reader.GetString(1)
                        ceServicios.Monto = reader.GetDouble(2)
                        ceServicios.idEmpresa = reader.GetString(3)
                        ceServicios.Activo = reader.GetString(4)
                        ceServicios.FechaUltMov = reader.GetDateTime(5)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    ceServicios.idArticulo = ""
                    ceServicios.Descripcion = ""
                    ceServicios.Monto = ""
                    ceServicios.idEmpresa = ""
                    ceServicios.Activo = ""
                    ceServicios.FechaUltMov = ""
                    Return False
                End If
            End Using
        End Using
    End Function
    Public Function ExcelCtasBancos()
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                Dim oExcel As Object
                Dim oBook As Object
                Dim oSheet As Object
                Dim n As Integer = 0
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)
                oSheet.Range("A1").Value = "Banco"
                oSheet.Range("B1").Value = "Tipo de Cuenta"
                oSheet.Range("C1").Value = "Nro. Cuenta"
                oSheet.Range("D1").Value = "Cuenta InterBancaria"
                oSheet.Range("A1:D1").Font.Bold = True
                command.Connection = cn
                command.CommandText = "Select b.Descripcion as Banco, a.tipoCuenta, a.NroCuenta, " _
                                    & "       a.CuentaInterbancaria " _
                                    & "  from adm_cuentas_banco a " _
                                    & " inner join adm_bancos b on a.IdBanco = b.IdBanco;"
                command.CommandType = CommandType.Text
                dr = command.ExecuteReader()
                n = 2
                While dr.Read()
                    oSheet.Range("A" + CStr(n)).value = dr("Banco")
                    oSheet.Range("B" + CStr(n)).value = dr("tipoCuenta")
                    oSheet.Range("C" + CStr(n)).value = dr("NroCuenta")
                    oSheet.Range("D" + CStr(n)).value = "'" + dr("CuentaInterbancaria")
                    n = n + 1
                End While
                oSheet.Range("A1:D" + CStr(n)).Columns.AutoFit()
                n = 0
                oExcel.ActiveWorkbook.SaveAs(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ListadoCuentasBancarias.xlsx")
                oExcel.Quit
                Return True
            End Using
        End Using
    End Function
    Public Function BusquedaCtaBancoxId(id As String)
        Using cn = objConexion.conectar
            cn.Open()
            Using command As New MySqlCommand
                command.Connection = cn
                command.CommandText = "Select a.idcuenta, a.idbanco, b.Descripcion as Banco, " _
                                    & "       a.tipoCuenta, a.NroCuenta, a.CuentaInterbancaria  " _
                                    & "  from adm_cuentas_banco a " _
                                    & " inner join adm_bancos b on a.IdBanco = b.IdBanco " _
                                    & " where a.idcuenta = '" & id & "';"
                command.CommandType = CommandType.Text
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ceCuentas_Banco.idCuenta = reader.GetString(0)
                        ceCuentas_Banco.idBanco = reader.GetString(1)
                        ceCuentas_Banco.Banco = reader.GetString(2)
                        ceCuentas_Banco.TipoCuenta = reader.GetString(3)
                        ceCuentas_Banco.NroCuenta = reader.GetString(4)
                        ceCuentas_Banco.CuentaInterbancaria = reader.GetString(5)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    ceCuentas_Banco.idCuenta = ""
                    ceCuentas_Banco.idBanco = ""
                    ceCuentas_Banco.Banco = ""
                    ceCuentas_Banco.TipoCuenta = ""
                    ceCuentas_Banco.NroCuenta = ""
                    ceCuentas_Banco.CuentaInterbancaria = ""
                    Return False
                End If
            End Using
        End Using
    End Function
End Class
