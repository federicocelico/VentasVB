Public Class Venta

    Private _ID As Integer
    Public IDCliente As Integer
    Private _fecha As Date
    Private _total As Decimal


    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property



    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property


    Public Property total As Decimal
        Get
            Return _total
        End Get
        Set(value As Decimal)
            _total = value
        End Set
    End Property


End Class
