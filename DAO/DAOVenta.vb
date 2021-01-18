Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class DAOVenta

    Private con As New SqlConnection
    Private comand As New SqlCommand
    Private da As SqlDataAdapter
    Private constr As New Conexion

    Public Function InsertarVenta(ByVal idCliente As Integer, ByVal fecha As Date, ByVal total As Decimal) As Integer

        Try
            Dim Str As String
            Dim idFactura As Integer

            Str = "INSERT INTO ventas (IDCliente, Fecha, Total) OUTPUT INSERTED.ID VALUES (@idCliente, @fecha, @total)"

            con = constr.conectar()
            con.Open()
            comand = New SqlCommand(Str, con)
            comand.Parameters.AddWithValue("@idCliente", idCliente)
            comand.Parameters.AddWithValue("@fecha", fecha)
            comand.Parameters.AddWithValue("@total", total)

            idFactura = (comand.ExecuteScalar())
            Return idFactura
        Catch ex As Exception
        Finally
            con.Close()

        End Try

    End Function

    Public Function InsertarVentaItems(ByVal dgv As DataGridView, ByVal idVenta As Integer, ByVal precioTotal As Decimal)

        Try
            Dim Str As String


            Str = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@idventa, @idProducto, @precioUnitario, @cantidad, @precioTotal)"

            con = constr.conectar()
            con.Open()
            comand = New SqlCommand(Str, con)

            For Each row As DataGridViewRow In dgv.Rows
                comand.Parameters.Clear()
                If (Not row.IsNewRow) Then
                    comand.Parameters.AddWithValue("@idVenta", idVenta)
                    comand.Parameters.AddWithValue("@idProducto", Convert.ToInt32(row.Cells("ID").Value))
                    comand.Parameters.AddWithValue("@precioUnitario", Convert.ToDecimal(row.Cells("Precio").Value))
                    comand.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells("Cantidad").Value))
                    comand.Parameters.AddWithValue("@PrecioTotal", precioTotal)

                    comand.ExecuteNonQuery()
                Else

                    Exit For
                End If
            Next

        Catch ex As Exception
            MsgBox("No se pudo grabar la venta")
        Finally
            con.Close()
        End Try

    End Function
End Class
