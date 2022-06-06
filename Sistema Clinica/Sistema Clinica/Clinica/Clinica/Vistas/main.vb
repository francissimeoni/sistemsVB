Public Class main

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim frm As Form = New Login()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim frm As Form = New RegistrarIngresos()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AbmPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbmPacienteToolStripMenuItem.Click
        Dim frm As Form = New BuscarModificarPacientes
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub AbmUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbmUsuariosToolStripMenuItem.Click
        Dim frm As Form = BuscarModificarUsuarios
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim frm As Form = New NuevoPaciente()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub IstadoDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IstadoDeUsuariosToolStripMenuItem.Click
        Dim frm As Form = New BuscarModificarUsuarios()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub GestionarOperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarOperacionesToolStripMenuItem.Click
        Dim frm As Form = New Operaciones()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ReporteDeIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeIngresosToolStripMenuItem.Click

        Dim ds As New dsP
  
        ds.Operaciones.Rows.Add("18/02/22", "12365478", "VALERIA ALARCON", "0.50")
        ds.Operaciones.Rows.Add("26/02/22", "25896147", "JONAS MARTINEZ", "0.50")
        ds.Operaciones.Rows.Add("26/02/22", "321501", "CARMEN BARBARROSA", "0.50")


        Dim rptdoc = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New reporteDeIngresos
        rptdoc.Database.Tables(0).SetDataSource(ds.Tables("operaciones"))


        Dim frm As New reporteIngresosPorFecha

        frm.CrystalReportViewer1.ReportSource = rptdoc
        frm.MdiParent = Me
        frm.Show()
        ds.Dispose()
    End Sub

    Private Sub BuscarPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarPacienteToolStripMenuItem.Click
        Dim ds As New dsP

        ds.Clientes.Rows.Add("35889602", "FRANCIS BRAIAN SIMEONI", "BV ESPAÑA 510", "(03482)-1535489", "22/02/2022")
        ds.Clientes.Rows.Add("22685002", "DANIEL ALEJANDRO MASIN", "LA MADRID 764", "(03482)-1535489", "22/02/2022")
        ds.Clientes.Rows.Add("35487525", "ANDREA BELEN MUCHUT", "9 DE JULIO 2050", "(03482)-1535489", "22/02/2022")
        ds.Clientes.Rows.Add("1051110", "RAUL DIONISIO ESPINO", "SAN MARTIN 1025", "(03482)-1535489", "22/02/2022")

        Dim rptdoc = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New reportedeClientes
        rptdoc.Database.Tables(0).SetDataSource(ds.Tables("clientes"))


        Dim frm As New reporteclientes

        frm.CrystalReportViewer1.ReportSource = rptdoc
        frm.MdiParent = Me
        frm.Show()
        ds.Dispose()
    End Sub

    Private Sub RegistrarIngresopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarIngresopToolStripMenuItem.Click
        Dim frm As Form = New RegistrarIngresos()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
