Public Class ceMonedas
    Private _idMoneda As String = ""
    Private _Descripcion As String = ""
    Private _ValorTasa As Double = 0
    Private Property idMoneda As String
        Get
            Return _idMoneda
        End Get
        Set(value As String)
            _idMoneda = value
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
    Private Property ValorTasa As Double
        Get
            Return _ValorTasa
        End Get
        Set(value As Double)
            _ValorTasa = value
        End Set
    End Property
End Class
