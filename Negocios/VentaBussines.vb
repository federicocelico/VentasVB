
Imports System.Windows.Forms
Imports DAO

Public Class VentaBussines

    Private _DAOVenta As New DAOVenta
    Private _clienteBussines As New ClienteBussines
    Private _productoBussines As New ProductoBussines

    Public Function InsertarVenta(ByVal idCliente As Integer, ByVal fecha As Date, ByVal total As Decimal) As Integer
        Try
            Return _DAOVenta.InsertarVenta(idCliente, fecha, total)

        Catch ex As Exception
            MsgBox("No se pudo guardar la venta")

        End Try

    End Function

    Public Function InsertarVentaItems(ByVal dgv As DataGridView, ByVal idVenta As Integer, ByVal precioTotal As Decimal)
        Try
            _DAOVenta.InsertarVentaItems(dgv, idVenta, precioTotal)

        Catch ex As Exception
            MsgBox("No se pudo guardar la venta")

        End Try
    End Function

    Public Function ValidarVenta(ByVal dgv As DataGridView, ByVal idCliente As Integer) As Boolean
        Dim validoCliente As Integer
        Dim validoProducto As Integer
        Dim grabo As Boolean = True
        Try
            validoCliente = _clienteBussines.BuscarCliente(idCliente)
            If (validoCliente <> 0) Then
                For Each row As DataGridViewRow In dgv.Rows
                    If Not row.IsNewRow Then
                        validoProducto = _productoBussines.ValidarProductos(Convert.ToString(row.Cells("ID").Value))
                        If (validoProducto = 0) Then
                            MessageBox.Show("El ID de Producto no es Valido", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            grabo = False
                        End If
                        If (String.IsNullOrEmpty(row.Cells("Cantidad").Value)) Then
                            MessageBox.Show("El campo Cantidad no puede quedar vacio", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            grabo = False
                        End If
                    Else
                        Exit For
                    End If
                Next
                Return grabo
            Else
                MessageBox.Show("El ID de Cliente no es Valido", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

        Catch ex As Exception

        End Try


    End Function
End Class
