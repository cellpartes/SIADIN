Public Class ceEmpresas
    Private _idEmpresa As String = ""
    Private _Nombre As String = ""
    Private _RUC As String = ""
    Private _Ubigeo_Distrito As String = ""
    Private _Direccion As String = ""
    Private _telefonos As String = ""
    Private _email As String = ""
    Private _TipoPrecio As String = ""
    Private _idDeposito As String = ""
    Private Property idEmpresa As String
        Get
            Return _idEmpresa
        End Get
        Set(value As String)
            _idEmpresa = value
        End Set
    End Property
    Private Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    Private Property RUC As String
        Get
            Return _RUC
        End Get
        Set(value As String)
            _RUC = value
        End Set
    End Property
    Private Property Ubigeo_Distrito As String
        Get
            Return _Ubigeo_Distrito
        End Get
        Set(value As String)
            _Ubigeo_Distrito = value
        End Set
    End Property
    Private Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property
    Private Property telefonos As String
        Get
            Return _telefonos
        End Get
        Set(value As String)
            _telefonos = value
        End Set
    End Property
    Private Property email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
    Private Property TipoPrecio As String
        Get
            Return _TipoPrecio
        End Get
        Set(value As String)
            _TipoPrecio = value
        End Set
    End Property
    Private Property idDeposito As String
        Get
            Return _idDeposito
        End Get
        Set(value As String)
            _idDeposito = value
        End Set
    End Property
End Class
