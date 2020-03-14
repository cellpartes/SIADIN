Public Class ceProvincias
    Private _Ubigeo_Prov As String = ""
    Private _Ubigeo_Dpto As String = ""
    Private _Provincia As String = ""
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
    Private Property Provincia As String
        Get
            Return _Provincia
        End Get
        Set(value As String)
            _Provincia = value
        End Set
    End Property
End Class
