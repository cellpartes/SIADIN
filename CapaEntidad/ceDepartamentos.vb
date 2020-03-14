Public Class ceDepartamentos
    Private _Ubigeo_Dpto As String = ""
    Private _Departamento As String = ""
    Private _Capital As String = ""
    Private _Abreviado As String = ""
    Private Property Ubigeo_Dpto As String
        Get
            Return _Ubigeo_Dpto
        End Get
        Set(value As String)
            _Ubigeo_Dpto = value
        End Set
    End Property
    Private Property Departamento As String
        Get
            Return _Departamento
        End Get
        Set(value As String)
            _Departamento = value
        End Set
    End Property
    Private Property Capital As String
        Get
            Return _Capital
        End Get
        Set(value As String)
            _Capital = value
        End Set
    End Property
    Private Property Abreviado As String
        Get
            Return _Abreviado
        End Get
        Set(value As String)
            _Abreviado = value
        End Set
    End Property
End Class
