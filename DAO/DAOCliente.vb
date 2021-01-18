Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Entidades

Public Class DAOCliente
    Private con As New SqlConnection
    Private comand As SqlCommand
    Private da As SqlDataAdapter
    Private constr As New Conexion

    Public Function AltaCliente(ByVal cliente As Cliente) As Boolean

        Try
            Dim Str As String
            Str = ("INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@cliente, @telefono, @correo)")

            con = constr.conectar()
            con.Open()
            comand = New SqlCommand(Str, con)
            comand.Parameters.AddWithValue("@cliente", cliente.cliente)
            comand.Parameters.AddWithValue("@telefono", cliente.telefono)
            comand.Parameters.AddWithValue("@correo", cliente.correo)
            comand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al crear el Cliente")
            Return False
        Finally
            con.Close()

        End Try

    End Function

    Public Function ModificarCliente(ByVal cliente As Cliente) As Boolean
        Try
            Dim Str As String
            Str = ("UPDATE clientes SET Cliente = @cliente, Telefono = @telefono, Correo = @correo WHERE ID = @id")

            con = constr.conectar()
            con.Open()
            comand = New SqlCommand(Str, con)
            comand.Parameters.AddWithValue("@id", cliente.ID)
            comand.Parameters.AddWithValue("@cliente", cliente.cliente)
            comand.Parameters.AddWithValue("@telefono", cliente.telefono)
            comand.Parameters.AddWithValue("@correo", cliente.correo)
            comand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al Modificar el Cliente")
            Return False
        Finally
            con.Close()

        End Try

    End Function

    Public Function EliminarCliente(ByVal ID As Integer) As Boolean
        Try
            Dim Str As String
            Str = ("DELETE FROM clientes WHERE ID = @id")

            con = constr.conectar()
            con.Open()
            comand = New SqlCommand(Str, con)
            comand.Parameters.AddWithValue("@id", ID)
            comand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Ocurrio un error al Eliminar el Cliente")
            Return False
        Finally
            con.Close()

        End Try

    End Function

    Public Function ListarClientes() As DataTable
        Try
            Dim Str As String
            Str = ("SELECT * FROM clientes")

            con = constr.conectar()
            con.Open()
            Dim dt As New DataTable
            da = New SqlDataAdapter(Str, con)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("Ocurrio un error al cargar los clientes")

        Finally
            con.Close()
            da.Dispose()
        End Try

    End Function

    Public Function BusquedaNombre(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            Dim Str As String
            Str = ("SELECT * FROM clientes WHERE Cliente LIKE '" & nombre + "%" & "' ")

            con = constr.conectar()
            con.Open()
            da = New SqlDataAdapter(Str, con)
            Dim dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception

        End Try
    End Function

    Public Function BusquedaId(ByVal id As String, ByVal dgv As DataGridView)
        Try
            Dim Str As String
            Str = ("SELECT * FROM clientes WHERE ID LIKE '" & id + "%" & "' ")

            con = constr.conectar()
            con.Open()
            da = New SqlDataAdapter(Str, con)
            Dim dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception

        End Try
    End Function

    Public Function BusquedaTelefono(ByVal telefono As String, ByVal dgv As DataGridView)
        Try
            Dim Str As String
            Str = ("SELECT * FROM clientes WHERE Telefono LIKE '" & telefono + "%" & "' ")

            con = constr.conectar()
            con.Open()
            da = New SqlDataAdapter(Str, con)
            Dim dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception

        End Try
    End Function


    Public Function BusquedaCorreo(ByVal correo As String, ByVal dgv As DataGridView)
        Try
            Dim Str As String
            Str = ("SELECT * FROM clientes WHERE Correo LIKE '" & correo + "%" & "' ")

            con = constr.conectar()
            con.Open()
            da = New SqlDataAdapter(Str, con)
            Dim dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception

        End Try
    End Function

    Public Function BuscarCliente(ByVal ID As Integer) As Integer
        Try
            Dim Str As String
            Dim flag As Integer
            Str = ("SELECT * FROM clientes WHERE ID = @id")

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

    Public Function ConsultaCliente(ByVal ID As Integer) As DataTable
        Try
            Dim Str As String
            Dim flag As Integer
            Str = ("SELECT * FROM clientes WHERE ID = " & ID)

            con = constr.conectar()
            con.Open()
            da = New SqlDataAdapter(Str, con)
            Dim dt = New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception


        Finally
            con.Close()
        End Try

    End Function
End Class
