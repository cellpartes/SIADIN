Public Class ceMaestroMovimientos
    Private _idMovimiento As Integer = 0
    Private _IdDocumento As String = ""
    Private _NroDocumento As Integer = 0
    Private _idTransaccion As String = ""
    Private _FechaDocumento As Date = ""
    Private _EmpresaEnvio As String = ""
    Private _GuiaEnvio As String = ""
    Private _idCaja As String = ""
    Private _idCliente As String = ""
    Private _idVendedor As String = ""
    Private _IdTpPagoDet As String = ""
    Private _SubTotal As Double = 0
    Private _Impuesto As Double = 0
    Private _Total As Double = 0
    Private _estado As String = ""
    Private _idEmpresa As String = ""
    Private _idDeposito As String = ""
    Private Property idMovimiento As Integer
        Get
            Return _idMovimiento
        End Get
        Set(value As Integer)
            _idMovimiento = value
        End Set
    End Property
    Private Property IdDocumento As String
        Get
            Return _IdDocumento
        End Get
        Set(value As String)
            _IdDocumento = value
        End Set
    End Property
    Private Property NroDocumento As Integer
        Get
            Return _NroDocumento
        End Get
        Set(value As Integer)
            _NroDocumento = value
        End Set
    End Property
    Private Property idTransaccion As String
        Get
            Return _idTransaccion
        End Get
        Set(value As String)
            _idTransaccion = value
        End Set
    End Property
    Private Property FechaDocumento As Date
        Get
            Return _FechaDocumento
        End Get
        Set(value As Date)
            _FechaDocumento = value
        End Set
    End Property
    Private Property EmpresaEnvio As String
        Get
            Return _EmpresaEnvio
        End Get
        Set(value As String)
            _EmpresaEnvio = value
        End Set
    End Property
    Private Property GuiaEnvio As String
        Get
            Return _GuiaEnvio
        End Get
        Set(value As String)
            _GuiaEnvio = value
        End Set
    End Property
    Private Property idCaja As String
        Get
            Return _idCaja
        End Get
        Set(value As String)
            _idCaja = value
        End Set
    End Property
    Private Property idCliente As String
        Get
            Return _idCliente
        End Get
        Set(value As String)
            _idCliente = value
        End Set
    End Property
    Private Property idVendedor As String
        Get
            Return _idVendedor
        End Get
        Set(value As String)
            _idVendedor = value
        End Set
    End Property
    Private Property IdTpPagoDet As String
        Get
            Return _IdTpPagoDet
        End Get
        Set(value As String)
            _IdTpPagoDet = value
        End Set
    End Property
    Private Property SubTotal As Double
        Get
            Return _SubTotal
        End Get
        Set(value As Double)
            _SubTotal = value
        End Set
    End Property
    Private Property Impuesto As Double
        Get
            Return _Impuesto
        End Get
        Set(value As Double)
            _Impuesto = value
        End Set
    End Property
    Private Property Total As Double
        Get
            Return _Total
        End Get
        Set(value As Double)
            _Total = value
        End Set
    End Property
    Private Property estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
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
End Class
