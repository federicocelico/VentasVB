Imports System.Data.SqlClient

Public Class DAOConsulta
    Private con As New SqlConnection
    Private comand As SqlCommand
    Private da As SqlDataAdapter
    Private constr As New Conexion

    Public Function ListarVentas() As DataTable
        Try
            Dim Str As String
            Str = ("SELECT  v.ID,
		                    v.Fecha,
	                    	c.Cliente,
	                    	vi.IDProducto,
                    		p.Nombre,
                    		vi.PrecioUnitario,
                    		vi.Cantidad,
	                    	vi.PrecioTotal
                    FROM ventas v 
                    LEFT JOIN ventasitems vi On
                    v.ID = vi.IDVenta
                    LEFT JOIN clientes c ON
                    v.IDCliente = c.ID	
                    LEFT JOIN productos p ON
                    vi.IDProducto = p.ID")

            con = constr.conectar()
            con.Open()
            Dim dt As New DataTable
            da = New SqlDataAdapter(Str, con)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Ocurrio un error al cargar los Productos")

        Finally
            con.Close()
            da.Dispose()
        End Try

    End Function

    Public Function EliminarVenta(ByVal ID As Integer) As Boolean
        Try
            Dim Str As String
            Str = ("DELETE FROM ventas WHERE ID = @id DELETE FROM ventasitems WHERE IDVenta = @id")

            con = constr.conectar()
            con.Open()
            comand = New SqlCommand(Str, con)
            comand.Parameters.AddWithValue("@id", ID)
            comand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al Eliminar la Venta")
            Return False
        Finally
            con.Close()

        End Try

    End Function
End Class
