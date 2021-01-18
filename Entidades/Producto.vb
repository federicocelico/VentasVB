Public Class Producto

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Private _precio As Decimal
    Public Property precio() As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property


    Private _categoria As String
    Public Property categoria() As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property
End Class
