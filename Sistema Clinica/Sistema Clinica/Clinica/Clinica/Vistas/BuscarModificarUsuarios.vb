Public Class BuscarModificarUsuarios

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim frm As Form = New NuevoUsuario()
        frm.MdiParent = main
        frm.Show()
    End Sub

    Private Sub BuscarModificarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add("MARIA AYELEN FERNANDEZ", True)
        DataGridView1.Rows.Add("JOSE MARIA FERRERE", True)
        DataGridView1.Rows.Add("MAXIMILIANO GALFRASCOLI", False)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim frm As Form = New ModificarUsuario()
        frm.MdiParent = main
        frm.Show()
    End Sub
End Class