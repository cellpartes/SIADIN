Public Class ceParametros
    Private _impuesto As Double = 0
    Private _nroFactura As Integer = 0
    Private _NroBoleta As Integer = 0
    Private _NroOrdenCompra As Integer = 0
    Private _NroPresupuesto As Integer = 0
    Private _NroAjuste As Integer = 0
    Private Property impuesto As Double
        Get
            Return _impuesto
        End Get
        Set(value As Double)
            _impuesto = value
        End Set
    End Property
    Private Property nroFactura As Integer
        Get
            Return _nroFactura
        End Get
        Set(value As Integer)
            _nroFactura = value
        End Set
    End Property
    Private Property NroBoleta As Integer
        Get
            Return _NroBoleta
        End Get
        Set(value As Integer)
            _NroBoleta = value
        End Set
    End Property
    Private Property NroOrdenCompra As Integer
        Get
            Return _NroOrdenCompra
        End Get
        Set(value As Integer)
            _NroOrdenCompra = value
        End Set
    End Property
    Private Property NroPresupuesto As Integer
        Get
            Return _NroPresupuesto
        End Get
        Set(value As Integer)
            _NroPresupuesto = value
        End Set
    End Property
    Private Property NroAjuste As Integer
        Get
            Return _NroAjuste
        End Get
        Set(value As Integer)
            _NroAjuste = value
        End Set
    End Property
End Class
