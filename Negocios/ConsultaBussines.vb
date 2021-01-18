Imports DAO

Public Class ConsultaBussines

    Private _daoConsulta As New DAOConsulta

    Public Function listarVentas() As DataTable
        Dim dt As New DataTable
        Try
            dt = _daoConsulta.ListarVentas()
            Return dt
        Catch ex As Exception
            MsgBox("no se pudo cargar las ventas")
        End Try
    End Function

    Public Function EliminarVenta(ByVal ID As Integer) As Boolean

        Try
            If (_daoConsulta.EliminarVenta(ID)) Then
                Return True
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al Eliminar la Venta")
            Return False
        End Try
    End Function
End Class
