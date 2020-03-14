Public Class ceUnidades
    Private _idUnidad As String = ""
    Private _Descripcion As String = ""
    Private Property idUnidad As String
        Get
            Return _idUnidad
        End Get
        Set(value As String)
            _idUnidad = value
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
