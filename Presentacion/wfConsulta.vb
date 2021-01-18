Imports Negocios

Public Class wfConsulta
    Private _consultaBussines As New ConsultaBussines


    Private Sub wfConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarVentas()
    End Sub

    Private Sub ListarVentas()
        dgvConsulta.DataSource = _consultaBussines.listarVentas()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer
        If (dgvConsulta.SelectedRows.Count > 0) Then
            id = dgvConsulta.CurrentRow.Cells("ID").Value
            If (MessageBox.Show("Esta seguro que desea Eliminar la Venta?", "Consulta Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes) Then

                If (_consultaBussines.EliminarVenta(id)) Then
                    MessageBox.Show("La venta se Elimino Correctamente", "Consulta Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ListarVentas()
                Else
                    MessageBox.Show("La venta no pudo ser Eliminada", "Consulta Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End If
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class