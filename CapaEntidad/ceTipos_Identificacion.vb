Public Class ceTipos_Identificacion
    Private _IdTpIdentificacion As String = ""
    Private _Descripcion As String = ""
    Private Property IdTpIdentificacion As String
        Get
            Return _IdTpIdentificacion
        End Get
        Set(value As String)
            _IdTpIdentificacion = value
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
