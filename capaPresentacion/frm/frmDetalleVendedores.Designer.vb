<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleVendedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleVendedores))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbIdIdentificacion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNroIdentifiacion = New System.Windows.Forms.TextBox()
        Me.txtDescripcionIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtIdIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtIdZona = New System.Windows.Forms.TextBox()
        Me.cbZonas = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtZona = New System.Windows.Forms.TextBox()
        Me.txtIdCaja = New System.Windows.Forms.TextBox()
        Me.cbCaja = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCaja = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btdOk = New System.Windows.Forms.ToolStripButton()
        Me.btdCancela = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.txtIdCaja)
        Me.GroupBox1.Controls.Add(Me.cbCaja)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCaja)
        Me.GroupBox1.Controls.Add(Me.txtIdZona)
        Me.GroupBox1.Controls.Add(Me.cbZonas)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtZona)
        Me.GroupBox1.Controls.Add(Me.cbIdIdentificacion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNroIdentifiacion)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionIdentificacion)
        Me.GroupBox1.Controls.Add(Me.txtIdIdentificacion)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(964, 126)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificación"
        '
        'cbIdIdentificacion
        '
        Me.cbIdIdentificacion.FormattingEnabled = True
        Me.cbIdIdentificacion.Location = New System.Drawing.Point(621, 20)
        Me.cbIdIdentificacion.Name = "cbIdIdentificacion"
        Me.cbIdIdentificacion.Size = New System.Drawing.Size(258, 24)
        Me.cbIdIdentificacion.TabIndex = 3
        Me.cbIdIdentificacion.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(499, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nro. Identificación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(499, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Tipo Identificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombre Vendedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Id. Vendedor"
        '
        'txtNroIdentifiacion
        '
        Me.txtNroIdentifiacion.Enabled = False
        Me.txtNroIdentifiacion.Location = New System.Drawing.Point(621, 50)
        Me.txtNroIdentifiacion.Name = "txtNroIdentifiacion"
        Me.txtNroIdentifiacion.Size = New System.Drawing.Size(155, 22)
        Me.txtNroIdentifiacion.TabIndex = 4
        '
        'txtDescripcionIdentificacion
        '
        Me.txtDescripcionIdentificacion.Enabled = False
        Me.txtDescripcionIdentificacion.Location = New System.Drawing.Point(621, 20)
        Me.txtDescripcionIdentificacion.Name = "txtDescripcionIdentificacion"
        Me.txtDescripcionIdentificacion.Size = New System.Drawing.Size(310, 22)
        Me.txtDescripcionIdentificacion.TabIndex = 23
        '
        'txtIdIdentificacion
        '
        Me.txtIdIdentificacion.Enabled = False
        Me.txtIdIdentificacion.Location = New System.Drawing.Point(240, 23)
        Me.txtIdIdentificacion.Name = "txtIdIdentificacion"
        Me.txtIdIdentificacion.Size = New System.Drawing.Size(28, 22)
        Me.txtIdIdentificacion.TabIndex = 22
        Me.txtIdIdentificacion.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(139, 51)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(310, 22)
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
        'txtIdZona
        '
        Me.txtIdZona.Enabled = False
        Me.txtIdZona.Location = New System.Drawing.Point(342, 17)
        Me.txtIdZona.Name = "txtIdZona"
        Me.txtIdZona.Size = New System.Drawing.Size(28, 22)
        Me.txtIdZona.TabIndex = 68
        Me.txtIdZona.Visible = False
        '
        'cbZonas
        '
        Me.cbZonas.FormattingEnabled = True
        Me.cbZonas.Location = New System.Drawing.Point(139, 79)
        Me.cbZonas.Name = "cbZonas"
        Me.cbZonas.Size = New System.Drawing.Size(252, 24)
        Me.cbZonas.TabIndex = 67
        Me.cbZonas.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 16)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Zona"
        '
        'txtZona
        '
        Me.txtZona.Enabled = False
        Me.txtZona.Location = New System.Drawing.Point(139, 79)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(270, 22)
        Me.txtZona.TabIndex = 65
        '
        'txtIdCaja
        '
        Me.txtIdCaja.Enabled = False
        Me.txtIdCaja.Location = New System.Drawing.Point(450, 17)
        Me.txtIdCaja.Name = "txtIdCaja"
        Me.txtIdCaja.Size = New System.Drawing.Size(28, 22)
        Me.txtIdCaja.TabIndex = 72
        Me.txtIdCaja.Visible = False
        '
        'cbCaja
        '
        Me.cbCaja.FormattingEnabled = True
        Me.cbCaja.Location = New System.Drawing.Point(621, 82)
        Me.cbCaja.Name = "cbCaja"
        Me.cbCaja.Size = New System.Drawing.Size(252, 24)
        Me.cbCaja.TabIndex = 69
        Me.cbCaja.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(499, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Caja"
        '
        'txtCaja
        '
        Me.txtCaja.Enabled = False
        Me.txtCaja.Location = New System.Drawing.Point(621, 85)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Size = New System.Drawing.Size(270, 22)
        Me.txtCaja.TabIndex = 70
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btdOk, Me.btdCancela})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(984, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(50, 155)
        Me.ToolStrip1.TabIndex = 70
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
        'frmDetalleVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1034, 155)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDetalleVendedores"
        Me.Text = "Vendedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbIdIdentificacion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNroIdentifiacion As TextBox
    Friend WithEvents txtDescripcionIdentificacion As TextBox
    Friend WithEvents txtIdIdentificacion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtIdCaja As TextBox
    Friend WithEvents cbCaja As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCaja As TextBox
    Friend WithEvents txtIdZona As TextBox
    Friend WithEvents cbZonas As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtZona As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btdOk As ToolStripButton
    Friend WithEvents btdCancela As ToolStripButton
End Class
