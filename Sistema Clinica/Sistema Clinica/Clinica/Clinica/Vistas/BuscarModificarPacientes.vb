Public Class BuscarModificarPacientes

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim frm As Form = New NuevoPaciente()
        frm.MdiParent = main
        frm.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub BuscarModificarPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add("1", "FRANCIS BRAIAN SIMEONI", "35889602")
        DataGridView1.Rows.Add("2", "DANIEL ALEJANDRO MASIN", "22685002")
        DataGridView1.Rows.Add("3", "ANDREA BELEN MUCHUT", "35487525")
        DataGridView1.Rows.Add("4", "RAUL DIONISIO ESPINO", "10511106")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim frm As New ModificarPaciente
        frm.MdiParent = main
        frm.Show()

    End Sub
End Class