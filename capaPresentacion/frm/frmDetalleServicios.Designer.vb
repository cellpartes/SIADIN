<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleServicios))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtFechaUltMov = New System.Windows.Forms.TextBox()
        Me.cbActivo = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtActivo = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btdOk = New System.Windows.Forms.ToolStripButton()
        Me.btdCancela = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.cbSubCategoria = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.dgvResultado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(839, 257)
        Me.GroupBox2.TabIndex = 96
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'dgvResultado
        '
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultado.Location = New System.Drawing.Point(6, 21)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.ReadOnly = True
        Me.dgvResultado.Size = New System.Drawing.Size(827, 230)
        Me.dgvResultado.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.txtFechaUltMov)
        Me.GroupBox7.Controls.Add(Me.cbActivo)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.txtActivo)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.txtMonto)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(13, 102)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(722, 51)
        Me.GroupBox7.TabIndex = 94
        Me.GroupBox7.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(424, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(140, 16)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "Fecha Ult. Movimiento"
        '
        'txtFechaUltMov
        '
        Me.txtFechaUltMov.Enabled = False
        Me.txtFechaUltMov.Location = New System.Drawing.Point(570, 15)
        Me.txtFechaUltMov.Name = "txtFechaUltMov"
        Me.txtFechaUltMov.Size = New System.Drawing.Size(130, 22)
        Me.txtFechaUltMov.TabIndex = 45
        '
        'cbActivo
        '
        Me.cbActivo.FormattingEnabled = True
        Me.cbActivo.Items.AddRange(New Object() {"Si", "No"})
        Me.cbActivo.Location = New System.Drawing.Point(312, 15)
        Me.cbActivo.Name = "cbActivo"
        Me.cbActivo.Size = New System.Drawing.Size(93, 24)
        Me.cbActivo.TabIndex = 4
        Me.cbActivo.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(261, 18)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 16)
        Me.Label31.TabIndex = 43
        Me.Label31.Text = "Activo"
        '
        'txtActivo
        '
        Me.txtActivo.Enabled = False
        Me.txtActivo.Location = New System.Drawing.Point(312, 15)
        Me.txtActivo.Name = "txtActivo"
        Me.txtActivo.Size = New System.Drawing.Size(93, 22)
        Me.txtActivo.TabIndex = 42
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 18)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(97, 16)
        Me.Label32.TabIndex = 40
        Me.Label32.Text = "Monto Servicio"
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(104, 15)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(130, 22)
        Me.txtMonto.TabIndex = 39
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.txtDescripcion)
        Me.GroupBox6.Controls.Add(Me.txtId)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(722, 85)
        Me.GroupBox6.TabIndex = 95
        Me.GroupBox6.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Id. Articulo"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(108, 49)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(592, 22)
        Me.txtDescripcion.TabIndex = 2
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(108, 21)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(192, 22)
        Me.txtId.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btdOk, Me.btdCancela})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(905, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(50, 573)
        Me.ToolStrip1.TabIndex = 98
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbMarca)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbCategoria)
        Me.GroupBox1.Controls.Add(Me.cbSubCategoria)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtBusca)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(839, 87)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio de Busqueda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "SubCategoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(530, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Marca"
        '
        'cbMarca
        '
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(582, 49)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(152, 24)
        Me.cbMarca.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Categoria"
        '
        'cbCategoria
        '
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(90, 49)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(152, 24)
        Me.cbCategoria.TabIndex = 30
        '
        'cbSubCategoria
        '
        Me.cbSubCategoria.FormattingEnabled = True
        Me.cbSubCategoria.Location = New System.Drawing.Point(351, 49)
        Me.cbSubCategoria.Name = "cbSubCategoria"
        Me.cbSubCategoria.Size = New System.Drawing.Size(173, 24)
        Me.cbSubCategoria.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Buscar"
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(90, 21)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(644, 22)
        Me.txtBusca.TabIndex = 1
        '
        'frmDetalleServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 573)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDetalleServicios"
        Me.Text = "Detalle Servicios"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvResultado As DataGridView
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtFechaUltMov As TextBox
    Friend WithEvents cbActivo As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtActivo As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btdOk As ToolStripButton
    Friend WithEvents btdCancela As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents cbSubCategoria As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBusca As TextBox
End Class
