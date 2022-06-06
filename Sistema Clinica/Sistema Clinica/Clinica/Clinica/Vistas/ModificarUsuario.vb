Public Class ModificarUsuario

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        MsgBox("Registro modificado correctamente", vbInformation, "Atención")
    End Sub
End Class