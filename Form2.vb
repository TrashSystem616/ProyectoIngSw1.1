Public Class Form2

    'Muestra el formulario 3'
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Form3.ShowDialog()

    End Sub

    Private Sub InventarioGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioGeneralToolStripMenuItem.Click
        Form4.ShowDialog()
    End Sub

    Private Sub PlanificacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanificacionToolStripMenuItem.Click
        Form6.ShowDialog()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Form7.ShowDialog()
    End Sub
End Class