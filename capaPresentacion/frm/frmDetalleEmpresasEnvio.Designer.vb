<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleEmpresasEnvio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleEmpresasEnvio))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.cbDistrito = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDistrito = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUbigeoDistrito = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btdOk = New System.Windows.Forms.ToolStripButton()
        Me.btdCancela = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.cbDepartamento)
        Me.GroupBox2.Controls.Add(Me.cbProvincia)
        Me.GroupBox2.Controls.Add(Me.cbDistrito)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDistrito)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDepartamento)
        Me.GroupBox2.Controls.Add(Me.txtProvincia)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 117)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubicación"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(139, 21)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(382, 24)
        Me.cbDepartamento.TabIndex = 6
        Me.cbDepartamento.Visible = False
        '
        'cbProvincia
        '
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(139, 51)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(382, 24)
        Me.cbProvincia.TabIndex = 7
        Me.cbProvincia.Visible = False
        '
        'cbDistrito
        '
        Me.cbDistrito.FormattingEnabled = True
        Me.cbDistrito.Location = New System.Drawing.Point(139, 81)
        Me.cbDistrito.Name = "cbDistrito"
        Me.cbDistrito.Size = New System.Drawing.Size(382, 24)
        Me.cbDistrito.TabIndex = 8
        Me.cbDistrito.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Distrito"
        '
        'txtDistrito
        '
        Me.txtDistrito.Enabled = False
        Me.txtDistrito.Location = New System.Drawing.Point(139, 81)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(382, 22)
        Me.txtDistrito.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Provincia"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Enabled = False
        Me.txtDepartamento.Location = New System.Drawing.Point(139, 21)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(382, 22)
        Me.txtDepartamento.TabIndex = 50
        '
        'txtProvincia
        '
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Location = New System.Drawing.Point(139, 52)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(382, 22)
        Me.txtProvincia.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Departamento"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.txtUbigeoDistrito)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 89)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificación"
        '
        'txtUbigeoDistrito
        '
        Me.txtUbigeoDistrito.Enabled = False
        Me.txtUbigeoDistrito.Location = New System.Drawing.Point(283, 20)
        Me.txtUbigeoDistrito.Name = "txtUbigeoDistrito"
        Me.txtUbigeoDistrito.Size = New System.Drawing.Size(238, 22)
        Me.txtUbigeoDistrito.TabIndex = 61
        Me.txtUbigeoDistrito.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombre Empresa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Id. Empresa"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(139, 51)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(382, 22)
        Me.txtNombre.TabIndex = 2
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(139, 23)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(95, 22)
        Me.txtId.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btdOk, Me.btdCancela})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(567, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(50, 433)
        Me.ToolStrip1.TabIndex = 74
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btdOk
        '
        Me.btdOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdOk.Image = CType(resources.GetObject("btdOk.Image"), System.Drawing.Image)
        Me.btdOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdOk.Name = "btdOk"
        Me.btdOk.Size = New System.Drawing.Size(47, 49)
        Me.btdOk.Text = "Ok"
        '
        'btdCancela
        '
        Me.btdCancela.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdCancela.Image = CType(resources.GetObject("btdCancela.Image"), System.Drawing.Image)
        Me.btdCancela.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdCancela.Name = "btdCancela"
        Me.btdCancela.Size = New System.Drawing.Size(47, 49)
        Me.btdCancela.Text = "Cancelar"
        '
        'frmDetalleEmpresasEnvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 433)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDetalleEmpresasEnvio"
        Me.Text = "Empresas Envio"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents cbDistrito As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDistrito As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtUbigeoDistrito As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btdOk As ToolStripButton
    Friend WithEvents btdCancela As ToolStripButton
End Class
