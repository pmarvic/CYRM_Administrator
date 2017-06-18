<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AsistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.MantenimientoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.ToolStripSeparator2, Me.CargosToolStripMenuItem, Me.DepartamentoToolStripMenuItem, Me.HorariosToolStripMenuItem})
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.RegistrarToolStripMenuItem.Text = "Registrar"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'CargosToolStripMenuItem
        '
        Me.CargosToolStripMenuItem.Name = "CargosToolStripMenuItem"
        Me.CargosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CargosToolStripMenuItem.Text = "Cargos"
        '
        'DepartamentoToolStripMenuItem
        '
        Me.DepartamentoToolStripMenuItem.Name = "DepartamentoToolStripMenuItem"
        Me.DepartamentoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DepartamentoToolStripMenuItem.Text = "Area de Trabajo"
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcajesToolStripMenuItem, Me.ToolStripSeparator1, Me.AsistenciasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'MarcajesToolStripMenuItem
        '
        Me.MarcajesToolStripMenuItem.Name = "MarcajesToolStripMenuItem"
        Me.MarcajesToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.MarcajesToolStripMenuItem.Text = "Marcajes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(129, 6)
        '
        'AsistenciasToolStripMenuItem
        '
        Me.AsistenciasToolStripMenuItem.Name = "AsistenciasToolStripMenuItem"
        Me.AsistenciasToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AsistenciasToolStripMenuItem.Text = "Asistencias"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeguridadToolStripMenuItem, Me.RegistrosToolStripMenuItem, Me.NovedadesToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarToolStripMenuItem, Me.ExportarToolStripMenuItem})
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'ImportarToolStripMenuItem
        '
        Me.ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
        Me.ImportarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportarToolStripMenuItem.Text = "Importar"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'NovedadesToolStripMenuItem
        '
        Me.NovedadesToolStripMenuItem.Name = "NovedadesToolStripMenuItem"
        Me.NovedadesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NovedadesToolStripMenuItem.Text = "Novedades"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.CYRM_Administrator.My.Resources.Resources.AdministratorFondo_edited
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Control y Registro de Marcajes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarcajesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AsistenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovedadesToolStripMenuItem As ToolStripMenuItem
End Class
