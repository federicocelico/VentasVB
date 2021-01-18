Public Class Cliente

    Private _ID As Integer

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Private _cliente As String

    Public Property cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property

    Private _telefono As String

    Public Property telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Private _correo As String

    Public Property correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

End Class
