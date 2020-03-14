Public Class ceBancos
    Private _IdBanco As String = ""
    Private _Descripcion As String = ""

    Private Property IdBanco As String
        Get
            Return _IdBanco
        End Get
        Set(value As String)
            _IdBanco = value
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
