Public Class wfMenuPrincipal

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        wfVentas.ShowDialog()

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click

        wfABMProductos.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        wfABMClientes.ShowDialog()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        wfConsulta.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class