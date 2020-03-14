Public Class ceCajas
    Private _idCaja As String = ""
    Private _Descripcion As String = ""
    Private _idEmpresa As String = ""
    Private _Estado As String = ""

    Private Property idCaja As String
        Get
            Return _idCaja
        End Get
        Set(value As String)
            _idCaja = value
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
    Private Property idEmpresa As String
        Get
            Return _idEmpresa
        End Get
        Set(value As String)
            _idEmpresa = value
        End Set
    End Property
    Private Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property

End Class
