Public Class cePagosMovimientos
    Private _idMovimiento As Integer = 0
    Private _IdTpPagoDet As String = ""
    Private _idCuenta As String = ""
    Private _nroDep As String = ""
    Private _voucher As String = ""
    Private _voucher_img As Byte = ""
    Private _Referencia As String = ""
    Private Property idMovimiento As Integer
        Get
            Return _idMovimiento
        End Get
        Set(value As Integer)
            _idMovimiento = value
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
    Private Property idCuenta As String
        Get
            Return _idCuenta
        End Get
        Set(value As String)
            _idCuenta = value
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
    Private Property voucher As Byte
        Get
            Return _voucher
        End Get
        Set(value As Byte)
            _voucher = value
        End Set
    End Property
    Private Property voucher_img As String
        Get
            Return _voucher_img
        End Get
        Set(value As String)
            _voucher_img = value
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
End Class
