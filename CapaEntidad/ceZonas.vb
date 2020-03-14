Public Class ceZonas
    Private _idZona As String = ""
    Private _idEmpresa As String = ""
    Private _Ubigeo_Distrito As String = ""
    Private _Descripcion As String = ""
    Private Property idZona As String
        Get
            Return _idZona
        End Get
        Set(value As String)
            _idZona = value
        End Set
    End Property
    Private Property idEmpresa As String
        Get
            Return _idEmpresa
        End Get
        Set(value As String)
            _idEmpresa = value
        End Set
    End Property
    Private Property Ubigeo_Distrito As String
        Get
            Return _Ubigeo_Distrito
        End Get
        Set(value As String)
            _Ubigeo_Distrito = value
        End Set
    End Property
    Private Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property
End Class
