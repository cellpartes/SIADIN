Public Class ceTipos_Documentos
    Private _idDocumento As String = ""
    Private _Descripcion As String = ""
    Private _ProxNroDoc As Integer = 0
    Private _idEmpresa As String = ""
    Private Property idDocumento As String
        Get
            Return _idDocumento
        End Get
        Set(value As String)
            _idDocumento = value
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
    Private Property ProxNroDoc As Integer
        Get
            Return _ProxNroDoc
        End Get
        Set(value As Integer)
            _ProxNroDoc = value
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
End Class
