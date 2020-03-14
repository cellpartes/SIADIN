Public Class ceCondiciones_Credito
    Private _condiciones As String = ""
    Private Property condiciones As String
        Get
            Return _condiciones
        End Get
        Set(value As String)
            _condiciones = value
        End Set
    End Property
End Class
