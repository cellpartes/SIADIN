Public Class ceResumen_Operaciones
    Private _idMovimiento As Integer = 0
    Private _FechaDocumento As Date = ""
    Private _idVendedor As String = ""
    Private _idEmpresa As String = ""
    Private _Referencia As String = ""
    Private _nroDep As String = ""
    Private _Total As Double = 0
    Private _Estado As String = ""
    Private _IdTpPagoDet As String = ""
    Private Property idMovimiento As Integer
        Get
            Return _idMovimiento
        End Get
        Set(value As Integer)
            _idMovimiento = value
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
    Private Property idVendedor As String
        Get
            Return _idVendedor
        End Get
        Set(value As String)
            _idVendedor = value
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
    Private Property Referencia As String
        Get
            Return _Referencia
        End Get
        Set(value As String)
            _Referencia = value
        End Set
    End Property
    Private Property nroDep As String
        Get
            Return _nroDep
        End Get
        Set(value As String)
            _nroDep = value
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
    Private Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
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
End Class
