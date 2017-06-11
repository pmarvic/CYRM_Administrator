<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfazSeguridad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.chkAdministrar = New System.Windows.Forms.CheckBox()
        Me.chkExportar = New System.Windows.Forms.CheckBox()
        Me.chkReportes = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 49)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informacion : Usuario y Contraseña hasta un Maximo de 10 Caracteres"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCerrar)
        Me.Panel2.Controls.Add(Me.btnGrabar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 159)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 52)
        Me.Panel2.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(301, 17)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(219, 17)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 6
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtContraseña)
        Me.Panel3.Controls.Add(Me.txtUsuario)
        Me.Panel3.Controls.Add(Me.chkAdministrar)
        Me.Panel3.Controls.Add(Me.chkExportar)
        Me.Panel3.Controls.Add(Me.chkReportes)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(385, 110)
        Me.Panel3.TabIndex = 2
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(97, 50)
        Me.txtContraseña.MaxLength = 10
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(144, 20)
        Me.txtContraseña.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(97, 21)
        Me.txtUsuario.MaxLength = 10
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(144, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'chkAdministrar
        '
        Me.chkAdministrar.AutoSize = True
        Me.chkAdministrar.Checked = True
        Me.chkAdministrar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAdministrar.Location = New System.Drawing.Point(287, 85)
        Me.chkAdministrar.Name = "chkAdministrar"
        Me.chkAdministrar.Size = New System.Drawing.Size(77, 17)
        Me.chkAdministrar.TabIndex = 5
        Me.chkAdministrar.Text = "Administrar"
        Me.chkAdministrar.UseVisualStyleBackColor = True
        '
        'chkExportar
        '
        Me.chkExportar.AutoSize = True
        Me.chkExportar.Checked = True
        Me.chkExportar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExportar.Location = New System.Drawing.Point(287, 54)
        Me.chkExportar.Name = "chkExportar"
        Me.chkExportar.Size = New System.Drawing.Size(65, 17)
        Me.chkExportar.TabIndex = 4
        Me.chkExportar.Text = "Exportar"
        Me.chkExportar.UseVisualStyleBackColor = True
        '
        'chkReportes
        '
        Me.chkReportes.AutoSize = True
        Me.chkReportes.Checked = True
        Me.chkReportes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReportes.Location = New System.Drawing.Point(287, 23)
        Me.chkReportes.Name = "chkReportes"
        Me.chkReportes.Size = New System.Drawing.Size(69, 17)
        Me.chkReportes.TabIndex = 3
        Me.chkReportes.Text = "Reportes"
        Me.chkReportes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Usuario"
        '
        'InterfazSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "InterfazSeguridad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Usuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents chkAdministrar As CheckBox
    Friend WithEvents chkExportar As CheckBox
    Friend WithEvents chkReportes As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
