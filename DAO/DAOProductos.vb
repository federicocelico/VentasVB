Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Entidades

Public Class DAOProductos
    Private con As New SqlConnection
    Private comand As SqlCommand
    Private da As SqlDataAdapter
    Private constr As New Conexion


    Public Function AltaProducto(ByVal producto As Producto) As Boolean

        Try
            Dim Str As String
            Str = ("INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@nombre, @precio, @categoria)")

            con = constr.conectar()
            con.Open()
            comand = New SqlCommand(Str, con)
            comand.Parameters.AddWithValue("@nombre", producto.nombre)
            comand.Parameters.AddWithValue("@precio", producto.precio)
            comand.Parameters.AddWithValue("@categoria", producto.categoria)
            comand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al crear el Producto")
            Return False
        Finally
            con.Close()

        End Try

    End Function

    Public Function ModificarProducto(ByVal producto As Producto) As Boolean
        Try
            Dim Str As String
            Str = ("UPDATE productos SET Nombre = @nombre, Precio = @precio, Categoria = @categoria WHERE ID = @id")

            con = constr.conectar()
            con.Open()
            comand = New SqlCommand(Str, con)
            comand.Parameters.AddWithValue("@id", producto.ID)
            comand.Parameters.AddWithValue("@nombre", producto.nombre)
            comand.Parameters.AddWithValue("@precio", producto.precio)
            comand.Parameters.AddWithValue("@categoria", producto.categoria)
            comand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al Modificar el Producto")
            Return False
        Finally
            con.Close()

        End Try

    End Function

    Public Function EliminarProducto(ByVal ID As Integer) As Boolean
        Try
            Dim Str As String
            Str = ("DELETE FROM productos WHERE ID = @id")

            con = constr.conectar()
            con.Open()
            comand = New SqlCommand(Str, con)
            comand.Parameters.AddWithValue("@id", ID)
            comand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al Eliminar el Producto")
            Return False
        Finally
            con.Close()

        End Try

    End Function

    Public Function ListarProductos() As DataTable
        Try
            Dim Str As String
            Str = ("SELECT * FROM productos")

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

    Public Function BuscarProducto(ByVal id As Integer) As DataTable
        Try
            Dim Str As String
            Str = ("SELECT * FROM productos WHERE ID = " & id)

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


    Public Function BusquedaNombre(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            Dim Str As String
            Str = ("SELECT * FROM productos WHERE Nombre LIKE '" & nombre + "%" & "' ")

            con = constr.conectar()
            con.Open()
            da = New SqlDataAdapter(Str, con)
            Dim dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Function

    Public Function BusquedaId(ByVal id As String, ByVal dgv As DataGridView)
        Try
            Dim Str As String
            Str = ("SELECT * FROM productos WHERE ID LIKE '" & id + "%" & "' ")

            con = constr.conectar()
            con.Open()
            da = New SqlDataAdapter(Str, con)
            Dim dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Function

    Public Function BusquedaPrecio(ByVal precio As Decimal, ByVal dgv As DataGridView)
        Try
            Dim Str As String
            Str = ("SELECT * FROM productos WHERE Precio LIKE " & "'%" & precio & "%'")

            con = constr.conectar()
            con.Open()
            da = New SqlDataAdapter(Str, con)
            Dim dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Function


    Public Function BusquedaCategoria(ByVal categoria As String, ByVal dgv As DataGridView)
        Try
            Dim Str As String
            Str = ("SELECT * FROM productos WHERE Categoria LIKE '" & categoria + "%" & "' ")

            con = constr.conectar()
            con.Open()
            da = New SqlDataAdapter(Str, con)
            Dim dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Function

    Public Function ValidarProducto(ByVal ID As Integer) As Integer
        Try
            Dim Str As String
            Dim flag As Integer
            Str = ("SELECT * FROM productos WHERE ID = @id")

            con = constr.conectar()
            con.Open()
            comand = New SqlCommand(Str, con)
            comand.Parameters.AddWithValue("@id", ID)
            flag = comand.ExecuteScalar()
            Return flag
        Catch ex As Exception


        Finally
            con.Close()
        End Try

    End Function
End Class
