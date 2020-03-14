Public Class ceTransacciones
    Private _idTransaccion As String = ""
    Private _Descripcion As String = ""
    Private _AfectaInv As String = ""
    Private Property idTransaccion As String
        Get
            Return _idTransaccion
        End Get
        Set(value As String)
            _idTransaccion = value
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
    Private Property AfectaInv As String
        Get
            Return _AfectaInv
        End Get
        Set(value As String)
            _AfectaInv = value
        End Set
    End Property
End Class
