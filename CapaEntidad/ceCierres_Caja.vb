Public Class ceCierres_Caja
    Private _idCierre As Integer = 0
    Private _idEmpresa As String = ""
    Private _idCaja As String = ""
    Private _idVendedor As String = ""
    Private _FechaCierre As Date = ""
    Private _idMovimiento As Integer = 0
    Private _TipoDoc As String = ""
    Private _NroDocumento As Integer = 0
    Private _FechaDocumento As Date = ""
    Private _TipoVenta As String = ""
    Private _FormaPago As String = ""
    Private _SubTotal As Double = 0
    Private _Impuesto As Double = 0
    Private _Total As Double = 0
    Private Property idCierre As Integer
        Get
            Return _idCierre
        End Get
        Set(value As Integer)
            _idCierre = value
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
    Private Property idCaja As String
        Get
            Return _idCaja
        End Get
        Set(value As String)
            _idCaja = value
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
    Private Property FechaCierre As Date
        Get
            Return _FechaCierre
        End Get
        Set(value As Date)
            _FechaCierre = value
        End Set
    End Property
    Private Property idMovimiento As Integer
        Get
            Return _idMovimiento
        End Get
        Set(value As Integer)
            _idMovimiento = value
        End Set
    End Property
    Private Property TipoDoc As String
        Get
            Return _TipoDoc
        End Get
        Set(value As String)
            _TipoDoc = value
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
    Private Property FechaDocumento As Date
        Get
            Return _FechaDocumento
        End Get
        Set(value As Date)
            _FechaDocumento = value
        End Set
    End Property
    Private Property TipoVenta As String
        Get
            Return _TipoVenta
        End Get
        Set(value As String)
            _TipoVenta = value
        End Set
    End Property
    Private Property FormaPago As String
        Get
            Return _FormaPago
        End Get
        Set(value As String)
            _FormaPago = value
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
End Class
