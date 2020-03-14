Public Class ceTipos_Pago
    Private _IdTpPago As String = ""
    Private _Descripcion As String = ""
    Private Property IdTpPago As String
        Get
            Return _IdTpPago
        End Get
        Set(value As String)
            _IdTpPago = value
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
End Class
