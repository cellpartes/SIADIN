Imports CapaDatos
Imports CapaEntidad
Public Class cnAccesoDatos
    Dim objCapaDatos As New CapaDatos.cdAccesoDatos
    Public Function VerificarLogin(ByVal usuario As String, ByVal passw As String) As Boolean
        Return objCapaDatos.VerificarLogin(usuario, passw)
    End Function
    Public Function BusquedaCiurierxId(id As String)
        Return objCapaDatos.BusquedaCiurierxId(id)
    End Function
    Public Function ExcelCourier()
        Return objCapaDatos.ExcelCourier
    End Function
    Public Function LlenaComboBox(sql As String, tabla As String) As DataSet
        Return objCapaDatos.LlenaComboBox(sql, tabla)
    End Function
    Public Function DMLTabla(sql As String)
        Return objCapaDatos.DMLTabla(sql)
    End Function
    Public Function BusquedaClientexId(id As String)
        Return objCapaDatos.BusquedaClientexId(id)
    End Function
    Public Function ValorTabla(sql As String) As Integer
        Return objCapaDatos.ValorTabla(sql)
    End Function
    Public Function ExcelClientes()
        Return objCapaDatos.ExcelClientes
    End Function
    Public Function BusquedaProveedorxId(id As String)
        Return objCapaDatos.BusquedaProveedorxId(id)
    End Function
    Public Function ExcelProveedores()
        Return objCapaDatos.ExcelProveedores
    End Function
    Public Function OperacionesImg(ByVal sql As String, ByVal imagen As Object, ByVal imagenBck As Object)
        Return objCapaDatos.OperacionesImg(sql, imagen, imagenBck)
    End Function
    Public Function ExcelCatalogoDinamico(consulta As String)
        Return objCapaDatos.ExcelCatalogoDinamico(consulta)
    End Function
    Public Function ExcelCatalogo()
        Return objCapaDatos.ExcelCatalogo
    End Function
    Public Function BusquedaCatalogoxId(id As String)
        Return objCapaDatos.BusquedaCatalogoxId(id)
    End Function
    Public Function BusquedaCategoriaxId(id As String)
        Return objCapaDatos.BusquedaCategoriaxId(id)
    End Function
    Public Function ExcelDinamicoCategoria(consulta As String)
        Return objCapaDatos.ExcelDinamicoCategoria(consulta)
    End Function
    Public Function BusquedaMarcaxId(id As String)
        Return objCapaDatos.BusquedaMarcaxId(id)
    End Function
    Public Function ExcelMarcas()
        Return objCapaDatos.ExcelMarcas
    End Function
    Public Function BusquedaSubCategoriaxId(id As String)
        Return objCapaDatos.BusquedaSubCategoriaxId(id)
    End Function
    Public Function ExcelDinamicoSubCategoria(consulta As String)
        Return objCapaDatos.ExcelDinamicoSubCategoria(consulta)
    End Function
    Public Function BusquedaVendedorxId(id As String)
        Return objCapaDatos.BusquedaVendedorxId(id)
    End Function
    Public Function ExcelDinamicoVendedores(consulta As String)
        Return objCapaDatos.ExcelDinamicoVendedores(consulta)
    End Function
    Public Function ExcelDinamicoServicios(consulta As String)
        Return objCapaDatos.ExcelDinamicoServicios(consulta)
    End Function
    Public Function BusquedaServicioxId(id As String)
        Return objCapaDatos.BusquedaServicioxId(id)
    End Function
    Public Function ExcelCtasBancos()
        Return objCapaDatos.ExcelCtasBancos
    End Function
    Public Function BusquedaCtaBancoxId(id As String)
        Return objCapaDatos.BusquedaCtaBancoxId(id)
    End Function
End Class
