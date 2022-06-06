<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbmPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbmUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IstadoDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarOperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarIngresopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReporteDeIngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.OperacionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(812, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPacienteToolStripMenuItem, Me.AbmPacienteToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(138, 20)
        Me.ArchivoToolStripMenuItem.Text = "Pacientes de gimnacio"
        '
        'BuscarPacienteToolStripMenuItem
        '
        Me.BuscarPacienteToolStripMenuItem.Name = "BuscarPacienteToolStripMenuItem"
        Me.BuscarPacienteToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.BuscarPacienteToolStripMenuItem.Text = "- Lista de pacientes"
        '
        'AbmPacienteToolStripMenuItem
        '
        Me.AbmPacienteToolStripMenuItem.Name = "AbmPacienteToolStripMenuItem"
        Me.AbmPacienteToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.AbmPacienteToolStripMenuItem.Text = "- Buscar, modificar o eliminar paciente"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbmUsuariosToolStripMenuItem, Me.IstadoDeUsuariosToolStripMenuItem})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'AbmUsuariosToolStripMenuItem
        '
        Me.AbmUsuariosToolStripMenuItem.Name = "AbmUsuariosToolStripMenuItem"
        Me.AbmUsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AbmUsuariosToolStripMenuItem.Text = "- Abm usuarios"
        '
        'IstadoDeUsuariosToolStripMenuItem
        '
        Me.IstadoDeUsuariosToolStripMenuItem.Name = "IstadoDeUsuariosToolStripMenuItem"
        Me.IstadoDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IstadoDeUsuariosToolStripMenuItem.Text = "- Iistado de usuarios"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(812, 43)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "Socios"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarOperacionesToolStripMenuItem, Me.RegistrarIngresopToolStripMenuItem, Me.ToolStripMenuItem1, Me.ReporteDeIngresosToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'GestionarOperacionesToolStripMenuItem
        '
        Me.GestionarOperacionesToolStripMenuItem.Name = "GestionarOperacionesToolStripMenuItem"
        Me.GestionarOperacionesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.GestionarOperacionesToolStripMenuItem.Text = "Gestionar operaciones"
        '
        'RegistrarIngresopToolStripMenuItem
        '
        Me.RegistrarIngresopToolStripMenuItem.Name = "RegistrarIngresopToolStripMenuItem"
        Me.RegistrarIngresopToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.RegistrarIngresopToolStripMenuItem.Text = "Registrar ingreso"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(188, 6)
        '
        'ReporteDeIngresosToolStripMenuItem
        '
        Me.ReporteDeIngresosToolStripMenuItem.Name = "ReporteDeIngresosToolStripMenuItem"
        Me.ReporteDeIngresosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ReporteDeIngresosToolStripMenuItem.Text = "- Reporte de ingresos"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Clinica.My.Resources.Resources.usuario1
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(94, 40)
        Me.ToolStripButton2.Text = "&Nuevo paciente"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Clinica.My.Resources.Resources.nuevo
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(95, 40)
        Me.ToolStripButton1.Text = "&Registar ingreso"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton1.ToolTipText = "Nuevo &usuario"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 561)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de clinica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarPacienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbmPacienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbmUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IstadoDeUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarOperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarIngresopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReporteDeIngresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
