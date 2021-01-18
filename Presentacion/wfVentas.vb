Imports Entidades
Imports Negocios

Public Class wfVentas
    Private _productoBussines As New ProductoBussines
    Private _producto As New Producto
    Private _ventaBussines As New VentaBussines
    Private _venta As New Venta
    Private _cliente As New ClienteBussines

    Private ConsultawfABMProductos As New wfABMProductos
    Private ConsultawfABMClientes As New wfABMClientes
    Private total As Decimal = 0




    Public Sub InsertarItem(ByVal celda As String)
        Try
            Dim producto As New Producto
            If (celda.Equals("??")) Then


                ConsultawfABMProductos.Owner = Me
                ConsultawfABMProductos.Text = "Consulta Producto"
                ConsultawfABMProductos.ShowDialog()

            Else
                producto.ID = Convert.ToInt32(celda)
                producto = _productoBussines.BuscarProducto(producto.ID)
                If (producto.ID <> 0) Then
                    dgvItems.CurrentRow.SetValues(producto.ID, producto.nombre, producto.precio, producto.categoria)


                Else
                    MessageBox.Show("Debe igresar un ID de Producto Valido. Si no conoce el ID ingrese ""??""", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dgvItems.Rows.RemoveAt(dgvItems.CurrentRow.Index)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error inesperado", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub

    Private Sub wfVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvItems.AutoGenerateColumns = False
        txtCliente.Enabled = False
    End Sub



    Private Sub dgvItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellEndEdit
        Dim celda As String

        Dim columna As String

        Try
            columna = dgvItems.Columns(e.ColumnIndex).HeaderText
            celda = dgvItems.CurrentRow.Cells(0).Value.ToString()
            If columna.Equals("ID") Then
                InsertarItem(celda)
            End If

            If (columna.Equals("Cantidad")) Then
                total = 0
                For Each fila As DataGridViewRow In dgvItems.Rows

                    total += fila.Cells("Precio").Value * fila.Cells("Cantidad").Value

                Next
                txtTotal.Text = total
            End If


        Catch ex As Exception
            MessageBox.Show("Debe ingresar un Id de Producto", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click

        ConsultawfABMClientes.Owner = Me
        ConsultawfABMClientes.Text = "Consulta Cliente"
        ConsultawfABMClientes.ShowDialog()
    End Sub



    Private Sub wfVentas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtIdCliente.Clear()
        txtCliente.Clear()
        dgvItems.Rows.Clear()
        txtTotal.Clear()
        total = 0
    End Sub

    Private Sub dgvItems_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvItems.RowsRemoved
        total = 0
        For Each fila As DataGridViewRow In dgvItems.Rows

            total += fila.Cells("Precio").Value * fila.Cells("Cantidad").Value
        Next
        txtTotal.Text = total

    End Sub

    Private Sub LimpiarCampos()
        txtIdCliente.Clear()
        txtCliente.Clear()
        dgvItems.Rows.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            _venta.IDCliente = 0
            _venta.IDCliente = Convert.ToInt32(txtIdCliente.Text)
            _venta.fecha = Convert.ToDateTime(dtpFecha.Text)
            _venta.total = Convert.ToDecimal(txtTotal.Text)


            If (_ventaBussines.ValidarVenta(dgvItems, _venta.IDCliente)) Then
                _venta.ID = _ventaBussines.InsertarVenta(_venta.IDCliente, _venta.fecha, _venta.total)
                _ventaBussines.InsertarVentaItems(dgvItems, _venta.ID, Convert.ToDecimal(txtTotal.Text))

                MessageBox.Show("La Venta se Registro con Exito", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()

            End If
        Catch ex As Exception
            MessageBox.Show("No pueden quedar campos vacios", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub



    Private Sub txtIdCliente_Leave(sender As Object, e As EventArgs) Handles txtIdCliente.Leave
        Dim dt As DataTable
        If (txtIdCliente.Text <> String.Empty) Then
            _venta.ID = Convert.ToInt32(txtIdCliente.Text)
            dt = _cliente.ConsultaCliente(_venta.ID)
            If (dt.Rows.Count = 0) Then
                ConsultawfABMClientes.Owner = Me
                ConsultawfABMClientes.Text = "Consulta Cliente"
                ConsultawfABMClientes.ShowDialog()
            Else
                For Each row In dt.Rows
                    txtIdCliente.Text = row("ID").ToString()
                    txtCliente.Text = row("Cliente").ToString()
                Next


            End If
        End If

    End Sub
End Class