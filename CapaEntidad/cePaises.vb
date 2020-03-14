Public Class cePaises
    Private _IdPais As String = ""
    Private _Descripcion As String = ""
    Private Property IdPais As String
        Get
            Return _IdPais
        End Get
        Set(value As String)
            _IdPais = value
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
