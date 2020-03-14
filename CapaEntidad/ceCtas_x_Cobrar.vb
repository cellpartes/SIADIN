Public Class ceCtas_x_Cobrar
    Private _idMovimiento As Integer = ""
    Private _condiciones As String = ""
    Private _saldo As Double = ""
    Private _FechaUltPago As Date = ""
    Private Property idMovimiento As Integer
        Get
            Return _idMovimiento
        End Get
        Set(value As Integer)
            _idMovimiento = value
        End Set
    End Property
    Private Property condiciones As String
        Get
            Return _condiciones
        End Get
        Set(value As String)
            _condiciones = value
        End Set
    End Property
    Private Property saldo As Double
        Get
            Return _saldo
        End Get
        Set(value As Double)
            _saldo = value
        End Set
    End Property
    Private Property FechaUltPago As Date
        Get
            Return _FechaUltPago
        End Get
        Set(value As Date)
            _FechaUltPago = value
        End Set
    End Property
End Class
