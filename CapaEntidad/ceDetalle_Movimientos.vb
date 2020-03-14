Public Class ceDetalle_Movimientos
    Private _idMovimiento As Integer = ""
    Private _item As Integer = ""
    Private _idArticulo As String = ""
    Private _cant As Double = ""
    Private _subtotal As Double = ""
    Private _impuesto As Double = ""
    Private _total As Double = ""
    Private Property idMovimiento As Integer
        Get
            Return _idMovimiento
        End Get
        Set(value As Integer)
            _idMovimiento = value
        End Set
    End Property
    Private Property item As Integer
        Get
            Return _item
        End Get
        Set(value As Integer)
            _item = value
        End Set
    End Property
    Private Property idArticulo As String
        Get
            Return _idArticulo
        End Get
        Set(value As String)
            _idArticulo = value
        End Set
    End Property
    Private Property cant As Double
        Get
            Return _cant
        End Get
        Set(value As Double)
            _cant = value
        End Set
    End Property
    Private Property subtotal As Double
        Get
            Return _subtotal
        End Get
        Set(value As Double)
            _subtotal = value
        End Set
    End Property
    Private Property impuesto As Double
        Get
            Return _impuesto
        End Get
        Set(value As Double)
            _impuesto = value
        End Set
    End Property
    Private Property total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property
End Class
