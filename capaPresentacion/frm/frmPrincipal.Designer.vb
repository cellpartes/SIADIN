<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btdEstadisticas = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.Label()
        Me.btdConsultas = New System.Windows.Forms.Button()
        Me.btnSlide = New System.Windows.Forms.PictureBox()
        Me.btdOperaciones = New System.Windows.Forms.Button()
        Me.btdMaestros = New System.Windows.Forms.Button()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTitulo = New System.Windows.Forms.Label()
        Me.btdMaximizar = New System.Windows.Forms.PictureBox()
        Me.btdRestaurar = New System.Windows.Forms.PictureBox()
        Me.btdMinimizar = New System.Windows.Forms.PictureBox()
        Me.btdCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.MenuVertical.SuspendLayout()
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btdMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btdRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btdMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btdCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuVertical.Controls.Add(Me.Button1)
        Me.MenuVertical.Controls.Add(Me.btdEstadisticas)
        Me.MenuVertical.Controls.Add(Me.txtUsuario)
        Me.MenuVertical.Controls.Add(Me.txtEmpresa)
        Me.MenuVertical.Controls.Add(Me.btdConsultas)
        Me.MenuVertical.Controls.Add(Me.btnSlide)
        Me.MenuVertical.Controls.Add(Me.btdOperaciones)
        Me.MenuVertical.Controls.Add(Me.btdMaestros)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 0)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(250, 650)
        Me.MenuVertical.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 40)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Configuración"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btdEstadisticas
        '
        Me.btdEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdEstadisticas.FlatAppearance.BorderSize = 0
        Me.btdEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btdEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btdEstadisticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdEstadisticas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btdEstadisticas.Image = CType(resources.GetObject("btdEstadisticas.Image"), System.Drawing.Image)
        Me.btdEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btdEstadisticas.Location = New System.Drawing.Point(0, 294)
        Me.btdEstadisticas.Name = "btdEstadisticas"
        Me.btdEstadisticas.Size = New System.Drawing.Size(250, 40)
        Me.btdEstadisticas.TabIndex = 16
        Me.btdEstadisticas.Text = "Estadísticas"
        Me.btdEstadisticas.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = True
        Me.txtUsuario.Location = New System.Drawing.Point(59, 35)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(0, 13)
        Me.txtUsuario.TabIndex = 15
        '
        'txtEmpresa
        '
        Me.txtEmpresa.AutoSize = True
        Me.txtEmpresa.Location = New System.Drawing.Point(59, 19)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(0, 13)
        Me.txtEmpresa.TabIndex = 14
        '
        'btdConsultas
        '
        Me.btdConsultas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdConsultas.FlatAppearance.BorderSize = 0
        Me.btdConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btdConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btdConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdConsultas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btdConsultas.Image = CType(resources.GetObject("btdConsultas.Image"), System.Drawing.Image)
        Me.btdConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btdConsultas.Location = New System.Drawing.Point(0, 226)
        Me.btdConsultas.Name = "btdConsultas"
        Me.btdConsultas.Size = New System.Drawing.Size(250, 40)
        Me.btdConsultas.TabIndex = 8
        Me.btdConsultas.Text = "Consultas"
        Me.btdConsultas.UseVisualStyleBackColor = True
        '
        'btnSlide
        '
        Me.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSlide.Image = CType(resources.GetObject("btnSlide.Image"), System.Drawing.Image)
        Me.btnSlide.InitialImage = CType(resources.GetObject("btnSlide.InitialImage"), System.Drawing.Image)
        Me.btnSlide.Location = New System.Drawing.Point(3, 12)
        Me.btnSlide.Name = "btnSlide"
        Me.btnSlide.Size = New System.Drawing.Size(40, 40)
        Me.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSlide.TabIndex = 3
        Me.btnSlide.TabStop = False
        '
        'btdOperaciones
        '
        Me.btdOperaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdOperaciones.FlatAppearance.BorderSize = 0
        Me.btdOperaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btdOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btdOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdOperaciones.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btdOperaciones.Image = CType(resources.GetObject("btdOperaciones.Image"), System.Drawing.Image)
        Me.btdOperaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btdOperaciones.Location = New System.Drawing.Point(0, 159)
        Me.btdOperaciones.Name = "btdOperaciones"
        Me.btdOperaciones.Size = New System.Drawing.Size(250, 40)
        Me.btdOperaciones.TabIndex = 2
        Me.btdOperaciones.Text = "Operaciones"
        Me.btdOperaciones.UseVisualStyleBackColor = True
        '
        'btdMaestros
        '
        Me.btdMaestros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdMaestros.FlatAppearance.BorderSize = 0
        Me.btdMaestros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btdMaestros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btdMaestros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdMaestros.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btdMaestros.Image = CType(resources.GetObject("btdMaestros.Image"), System.Drawing.Image)
        Me.btdMaestros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btdMaestros.Location = New System.Drawing.Point(0, 96)
        Me.btdMaestros.Name = "btdMaestros"
        Me.btdMaestros.Size = New System.Drawing.Size(250, 40)
        Me.btdMaestros.TabIndex = 1
        Me.btdMaestros.Text = "Maestros"
        Me.btdMaestros.UseVisualStyleBackColor = True
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BarraTitulo.Controls.Add(Me.PictureBox1)
        Me.BarraTitulo.Controls.Add(Me.txtTitulo)
        Me.BarraTitulo.Controls.Add(Me.btdMaximizar)
        Me.BarraTitulo.Controls.Add(Me.btdRestaurar)
        Me.BarraTitulo.Controls.Add(Me.btdMinimizar)
        Me.BarraTitulo.Controls.Add(Me.btdCerrar)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(250, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(922, 50)
        Me.BarraTitulo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txtTitulo
        '
        Me.txtTitulo.AutoSize = True
        Me.txtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Location = New System.Drawing.Point(217, 12)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(0, 25)
        Me.txtTitulo.TabIndex = 8
        '
        'btdMaximizar
        '
        Me.btdMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btdMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdMaximizar.Image = CType(resources.GetObject("btdMaximizar.Image"), System.Drawing.Image)
        Me.btdMaximizar.Location = New System.Drawing.Point(868, 9)
        Me.btdMaximizar.Name = "btdMaximizar"
        Me.btdMaximizar.Size = New System.Drawing.Size(20, 20)
        Me.btdMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btdMaximizar.TabIndex = 5
        Me.btdMaximizar.TabStop = False
        '
        'btdRestaurar
        '
        Me.btdRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btdRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdRestaurar.Image = CType(resources.GetObject("btdRestaurar.Image"), System.Drawing.Image)
        Me.btdRestaurar.Location = New System.Drawing.Point(868, 9)
        Me.btdRestaurar.Name = "btdRestaurar"
        Me.btdRestaurar.Size = New System.Drawing.Size(20, 20)
        Me.btdRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btdRestaurar.TabIndex = 4
        Me.btdRestaurar.TabStop = False
        Me.btdRestaurar.Visible = False
        '
        'btdMinimizar
        '
        Me.btdMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btdMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdMinimizar.Image = CType(resources.GetObject("btdMinimizar.Image"), System.Drawing.Image)
        Me.btdMinimizar.Location = New System.Drawing.Point(842, 9)
        Me.btdMinimizar.Name = "btdMinimizar"
        Me.btdMinimizar.Size = New System.Drawing.Size(20, 20)
        Me.btdMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btdMinimizar.TabIndex = 3
        Me.btdMinimizar.TabStop = False
        '
        'btdCerrar
        '
        Me.btdCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btdCerrar.Image = CType(resources.GetObject("btdCerrar.Image"), System.Drawing.Image)
        Me.btdCerrar.Location = New System.Drawing.Point(894, 9)
        Me.btdCerrar.Name = "btdCerrar"
        Me.btdCerrar.Size = New System.Drawing.Size(20, 20)
        Me.btdCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btdCerrar.TabIndex = 1
        Me.btdCerrar.TabStop = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(250, 50)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(922, 600)
        Me.PanelContenedor.TabIndex = 2
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1172, 650)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.MenuVertical)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.MenuVertical.ResumeLayout(False)
        Me.MenuVertical.PerformLayout()
        CType(Me.btnSlide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraTitulo.ResumeLayout(False)
        Me.BarraTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btdMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btdRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btdMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btdCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuVertical As Panel
    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btdMaximizar As PictureBox
    Friend WithEvents btdRestaurar As PictureBox
    Friend WithEvents btdMinimizar As PictureBox
    Friend WithEvents btdCerrar As PictureBox
    Friend WithEvents btdMaestros As Button
    Friend WithEvents btdOperaciones As Button
    Friend WithEvents btnSlide As PictureBox
    Friend WithEvents btdConsultas As Button
    Friend WithEvents txtUsuario As Label
    Friend WithEvents txtEmpresa As Label
    Friend WithEvents txtTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btdEstadisticas As Button
End Class
