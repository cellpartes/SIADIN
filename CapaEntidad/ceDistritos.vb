Public Class ceDistritos
    Private _Ubigeo_Distrito As String = ""
    Private _Ubigeo_Prov As String = ""
    Private _Ubigeo_Dpto As String = ""
    Private _Distrito As String = ""
    Private Property Ubigeo_Distrito As String
        Get
            Return _Ubigeo_Distrito
        End Get
        Set(value As String)
            _Ubigeo_Distrito = value
        End Set
    End Property
    Private Property Ubigeo_Prov As String
        Get
            Return _Ubigeo_Prov
        End Get
        Set(value As String)
            _Ubigeo_Prov = value
        End Set
    End Property
    Private Property Ubigeo_Dpto As String
        Get
            Return _Ubigeo_Dpto
        End Get
        Set(value As String)
            _Ubigeo_Dpto = value
        End Set
    End Property
    Private Property Distrito As String
        Get
            Return _Distrito
        End Get
        Set(value As String)
            _Distrito = value
        End Set
    End Property
End Class
