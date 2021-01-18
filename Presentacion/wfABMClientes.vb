Imports Entidades
Imports Negocios

Public Class wfABMClientes

    Private _clienteBussines As New ClienteBussines
    Private _cliente As New Cliente
    Private _wfVentas As wfVentas

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        _cliente.cliente = txtNombre.Text
        _cliente.telefono = txtTelefono.Text
        _cliente.correo = txtCorreo.Text
        Try
            _clienteBussines.AltaCliente(_cliente)
            MessageBox.Show("El cliente fue dado de alta con exito", "Alta de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            ListarClientes()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al dar de alta el cliente", "Alta de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        End Try

    End Sub



    Private Sub AltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarClientes()
    End Sub

    Private Function ListarClientes()
        dgvClientes.DataSource = _clienteBussines.ListarClientes()
    End Function

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ok As Boolean = False
        If (dgvClientes.SelectedRows.Count > 0) Then
            _cliente.ID = Convert.ToInt32(txtID.Text)
            _cliente.cliente = txtNombre.Text
            _cliente.telefono = txtTelefono.Text
            _cliente.correo = txtCorreo.Text

            If (MessageBox.Show("Esta seguro que desea Modificar el Cliente?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes) Then
                ok = _clienteBussines.ModificarCliente(_cliente)
                If (ok) Then
                    MessageBox.Show("El Cliente se Modifico con Exito", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ListarClientes()
                    LimpiarCampos()
                End If
            Else
                MessageBox.Show("La Modificacion fue Cancelada", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
            End If



        Else
            MessageBox.Show("Debe seleccionar un cliente para Editarlo", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        Dim nombre As String
        Dim clienteId As String
        If (Me.Text.Equals("Consulta Cliente")) Then
            Me.Owner = wfVentas
            wfVentas.txtIdCliente.Text = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells(0).Value.ToString()
            wfVentas.txtCliente.Text = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells(1).Value.ToString()
            Me.Close()



        Else
            txtID.Text = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells(0).Value.ToString()
            txtNombre.Text = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells(1).Value.ToString()
            txtTelefono.Text = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells(2).Value.ToString()
            txtCorreo.Text = dgvClientes.Rows(dgvClientes.CurrentRow.Index).Cells(3).Value.ToString()

        End If

        btnGuardar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim ok As Boolean = False
        If (dgvClientes.SelectedRows.Count > 0) Then
            If (txtID.Text <> "") Then
                _cliente.ID = Convert.ToInt32(txtID.Text)
                _cliente.cliente = txtNombre.Text
                _cliente.telefono = txtTelefono.Text
                _cliente.correo = txtCorreo.Text

                If (MessageBox.Show("Esta seguro que desea Eliminar el Cliente?", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes) Then
                    ok = _clienteBussines.EliminarCliente(_cliente.ID)
                    If (ok) Then
                        MessageBox.Show("El Cliente se Elimino con Exito", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ListarClientes()
                        LimpiarCampos()
                    End If
                Else
                    MessageBox.Show("La Eliminacion fue Cancelada", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarCampos()
                End If

            Else
                MessageBox.Show("Seleccione una Fila que contenga Datos", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If

        Else
            MessageBox.Show("Debe seleccionar un cliente para Editarlo", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub txtBusquedaNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaNombre.TextChanged
        _clienteBussines.BusquedaNombre(txtBusquedaNombre.Text, dgvClientes)
    End Sub

    Private Sub txtBusquedaID_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaID.TextChanged
        _clienteBussines.BusquedaID(txtBusquedaID.Text, dgvClientes)

    End Sub

    Private Sub txtBusquedaTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaTelefono.TextChanged
        _clienteBussines.BusquedaTelefono(txtBusquedaTelefono.Text, dgvClientes)
    End Sub

    Private Sub txtBusquedaCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaCorreo.TextChanged
        _clienteBussines.BusquedaCorreo(txtBusquedaCorreo.Text, dgvClientes)

    End Sub
End Class