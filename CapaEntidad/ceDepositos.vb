Public Class ceDepositos
    Private _idDeposito As String = ""
    Private _Descripcion As String = ""
    Private _idEmpresa As String = ""

    Private Property idDeposito As String
        Get
            Return _idDeposito
        End Get
        Set(value As String)
            _idDeposito = value
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
End Class
