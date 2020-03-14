Public Class ceNivel_Usuarios
    Private _idNivel As String = ""
    Private _Descripcion As String = ""
    Private Property idNivel As String
        Get
            Return _idNivel
        End Get
        Set(value As String)
            _idNivel = value
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
