Public Class ceInventario
    Private _idArticulo As String = ""
    Private _idEmpresa As String = ""
    Private _idDeposito As String = ""
    Private _existencia As Integer = 0
    Private _FechaUltMov As Date = ""
    Private _Alerta As String = ""
    Private Property idArticulo As String
        Get
            Return _idArticulo
        End Get
        Set(value As String)
            _idArticulo = value
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
    Private Property idDeposito As String
        Get
            Return _idDeposito
        End Get
        Set(value As String)
            _idDeposito = value
        End Set
    End Property
    Private Property existencia As Integer
        Get
            Return _existencia
        End Get
        Set(value As Integer)
            _existencia = value
        End Set
    End Property
    Private Property FechaUltMov As Date
        Get
            Return _FechaUltMov
        End Get
        Set(value As Date)
            _FechaUltMov = value
        End Set
    End Property
    Private Property Alerta As String
        Get
            Return _Alerta
        End Get
        Set(value As String)
            _Alerta = value
        End Set
    End Property
End Class
