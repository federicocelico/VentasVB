Imports System.Windows.Forms
Imports DAO
Imports Entidades

Public Class ClienteBussines
    Private _daoCliente As New DAOCliente

    Public Function ListarClientes() As DataTable
        Dim dt As New DataTable
        Try
            dt = _daoCliente.ListarClientes()
            Return dt
        Catch ex As Exception
            MsgBox("No se pudo cargar los clientes")
        End Try
    End Function

    Public Function AltaCliente(ByVal cliente As Cliente)

        Try
            _daoCliente.AltaCliente(cliente)

        Catch ex As Exception
            MsgBox("Ocurrio un error al crear el Cliente")
        End Try
    End Function


    Public Function ModificarCliente(ByVal cliente As Cliente) As Boolean

        Try
            If (_daoCliente.ModificarCliente(cliente)) Then
                Return True
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al Modificar el Cliente")
            Return False
        End Try
    End Function

    Public Function EliminarCliente(ByVal ID As Integer) As Boolean

        Try
            If (_daoCliente.EliminarCliente(ID)) Then
                Return True
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al Eliminar el Cliente")
            Return False
        End Try
    End Function

    Public Function BusquedaNombre(ByVal nombre As String, ByVal dgv As DataGridView)
        _daoCliente.BusquedaNombre(nombre, dgv)
    End Function

    Public Function BusquedaID(ByVal id As String, ByVal dgv As DataGridView)
        _daoCliente.BusquedaId(id, dgv)
    End Function

    Public Function BusquedaTelefono(ByVal telefono As String, ByVal dgv As DataGridView)
        _daoCliente.BusquedaTelefono(telefono, dgv)
    End Function

    Public Function BusquedaCorreo(ByVal correo As String, ByVal dgv As DataGridView)
        _daoCliente.BusquedaCorreo(correo, dgv)
    End Function

    Public Function BuscarCliente(ByVal idCliente As Integer) As Integer
        Return _daoCliente.BuscarCliente(idCliente)
    End Function

    Public Function ConsultaCliente(ByVal idCliente As Integer) As DataTable
        Return _daoCliente.ConsultaCliente(idCliente)
    End Function
End Class
