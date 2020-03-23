Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports CapaEntidad

Public Class cdConexion
    Dim conexion As MySqlConnection
    Public Function conectar() As MySqlConnection
        'conexion = New MySqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
        conexion = New MySqlConnection
        Dim myConnectionString As String
        'Desa
        'myConnectionString = "server=192.168.0.64;Port=3306;Database=desarrollo;Uid=useradd;Pwd=$Lenovo01;"
        'Prod Localhost
        'myConnectionString = "server=192.168.0.64;Port=3306;Database=imexgonp;Uid=useradd;Pwd=$Lenovo01;"
        'Prod Web
        myConnectionString = "server=167.114.163.236;Port=3306;Database=imexgonp_basedatos;Uid=imexgonp_useradd;Pwd=$Lenovo01;"
        Try
            conexion.ConnectionString = myConnectionString
            'conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return conexion
    End Function
End Class
