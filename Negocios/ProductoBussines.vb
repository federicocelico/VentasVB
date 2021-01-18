Imports System.Windows.Forms
Imports DAO
Imports Entidades

Public Class ProductoBussines
    Private _daoProducto As New DAOProductos

    Public Function ListarProductos() As DataTable
        Dim dt As New DataTable
        Try
            dt = _daoProducto.ListarProductos()
            Return dt
        Catch ex As Exception
            MsgBox("No se pudo cargar los Productos")
        End Try
    End Function

    Public Function AltaProductos(ByVal producto As Producto) As Boolean

        Try
            If (_daoProducto.AltaProducto(producto)) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al crear el Producto")
        End Try
    End Function


    Public Function ModificarProducto(ByVal producto As Producto) As Boolean

        Try
            If (_daoProducto.ModificarProducto(producto)) Then
                Return True
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al Modificar el Producto")
            Return False
        End Try
    End Function

    Public Function EliminarProducto(ByVal ID As Integer) As Boolean

        Try
            If (_daoProducto.EliminarProducto(ID)) Then
                Return True
            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error al Eliminar el Producto")
            Return False
        End Try
    End Function

    Public Function BuscarProducto(ByVal id As Integer) As Producto
        Try
            Dim List As List(Of Producto) = Nothing
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim producto As New Producto


            dt = _daoProducto.BuscarProducto(id)

            If (dt Is Nothing) Then
                MsgBox("No se encontraron Productos")

            Else


                List = New List(Of Producto)

                For Each row In dt.Rows
                    producto.ID = Convert.ToInt32(row("ID").ToString())
                    producto.nombre = row("Nombre").ToString()
                    producto.precio = Convert.ToDecimal(row("Precio").ToString())
                    producto.categoria = row("Categoria").ToString()



                Next

                Return producto
            End If

        Catch ex As Exception
            MsgBox("No se encontraron Productos..")
        End Try

    End Function

    Public Function BusquedaNombre(ByVal nombre As String, ByVal dgv As DataGridView)
        _daoProducto.BusquedaNombre(nombre, dgv)
    End Function

    Public Function BusquedaID(ByVal id As String, ByVal dgv As DataGridView)
        _daoProducto.BusquedaId(id, dgv)
    End Function

    Public Function BusquedaPrecio(ByVal precio As String, ByVal dgv As DataGridView)
        If (precio <> Nothing) Then
            Convert.ToDecimal(precio)
            _daoProducto.BusquedaPrecio(precio, dgv)

        End If
    End Function

    Public Function BusquedaCategoria(ByVal categoria As String, ByVal dgv As DataGridView)
        _daoProducto.BusquedaCategoria(categoria, dgv)
    End Function

    Public Function ValidarProductos(ByVal idProducto As Integer) As Integer
        Return _daoProducto.ValidarProducto(idProducto)
    End Function

End Class
