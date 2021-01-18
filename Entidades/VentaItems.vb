Public Class VentaItems

    Private _ID As Integer

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public IDVenta As Venta

    Public IDProducto As New List(Of Producto)

    Private _precioUnitario As Decimal

    Public Property precioUnitario As Decimal
        Get
            Return _precioUnitario
        End Get
        Set(value As Decimal)
            _precioUnitario = value
        End Set
    End Property

    Private _precioTotal As Decimal

    Public Property precioTotal As Decimal
        Get
            Return _precioTotal
        End Get
        Set(value As Decimal)
            _precioTotal = value
        End Set
    End Property

End Class
