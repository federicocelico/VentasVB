Imports Entidades
Imports Negocios

Public Class wfABMProductos

    Private _productoBussines As New ProductoBussines
    Private _producto As New Producto


    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtPrecio.Clear()
        txtCategoria.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        _producto.nombre = txtNombre.Text
        _producto.precio = Convert.ToDecimal(txtPrecio.Text)
        _producto.categoria = txtCategoria.Text
        Try
            If (_productoBussines.AltaProductos(_producto)) Then
                MessageBox.Show("El Producto fue dado de alta con exito", "Alta de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
                ListarProductos()

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al dar de alta el Producto", "Alta de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        End Try

    End Sub

    Private Sub wfABMProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListarProductos()
    End Sub

    Private Function ListarProductos()
        dgvProductos.DataSource = _productoBussines.ListarProductos()
    End Function

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim ok As Boolean = False
        If (dgvProductos.SelectedRows.Count > 0) Then
            If (txtID.Text <> "") Then
                _producto.ID = Convert.ToInt32(txtID.Text)
                _producto.nombre = txtNombre.Text
                _producto.precio = Convert.ToDecimal(txtPrecio.Text)
                _producto.categoria = txtCategoria.Text


                If (MessageBox.Show("Esta seguro que desea Modificar el Producto?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes) Then
                    ok = _productoBussines.ModificarProducto(_producto)
                    If (ok) Then
                        MessageBox.Show("El Producto se Modifico con Exito", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ListarProductos()
                        LimpiarCampos()
                    End If
                Else
                    MessageBox.Show("La Modificacion fue Cancelada", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarCampos()
                End If
            Else
                MessageBox.Show("Seleccione una Fila que contenga Datos", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If


        Else
            MessageBox.Show("Debe seleccionar un Producto para Editarlo", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        Dim celda As String
        Me.Owner = wfVentas
        If (Me.Text.Equals("Consulta Producto")) Then
            celda = dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(0).Value.ToString()


            wfVentas.InsertarItem(celda)
            Me.Close()


        Else

            txtID.Text = dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(0).Value.ToString()
            txtNombre.Text = dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(1).Value.ToString()
            txtPrecio.Text = dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(2).Value.ToString()
            txtCategoria.Text = dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(3).Value.ToString()
            btnGuardar.Enabled = False

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim ok As Boolean = False
            If (dgvProductos.SelectedRows.Count > 0) Then
                _producto.ID = Convert.ToInt32(txtID.Text)
                _producto.nombre = txtNombre.Text
                _producto.precio = Convert.ToDecimal(txtPrecio.Text)
                _producto.categoria = txtCategoria.Text

                If (MessageBox.Show("Esta seguro que desea Eliminar el Producto?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes) Then
                    ok = _productoBussines.EliminarProducto(_producto.ID)
                    If (ok) Then
                        MessageBox.Show("El Producto se Elimino con Exito", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ListarProductos()
                        LimpiarCampos()
                    End If
                Else
                    MessageBox.Show("La Eliminacion fue Cancelada", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarCampos()
                End If



            Else
                MessageBox.Show("Debe seleccionar un Producto para Eliminarlo", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar un Producto para Eliminarlo", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try

    End Sub


    Private Sub txtBusquedaNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaNombre.TextChanged
        _productoBussines.BusquedaNombre(txtBusquedaNombre.Text, dgvProductos)
    End Sub

    Private Sub txtBusquedaID_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaID.TextChanged
        _productoBussines.BusquedaID(txtBusquedaID.Text, dgvProductos)

    End Sub

    Private Sub txtBusquedaPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaPrecio.TextChanged
        If (txtBusquedaPrecio.Text <> "") Then
            _productoBussines.BusquedaPrecio(txtBusquedaPrecio.Text, dgvProductos)
        Else
            ListarProductos()
        End If

    End Sub

    Private Sub txtBusquedaCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaCategoria.TextChanged

        _productoBussines.BusquedaCategoria(txtBusquedaCategoria.Text, dgvProductos)

    End Sub
End Class