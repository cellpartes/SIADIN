<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalogo))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbActivo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbFrecuente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbServicio = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.cbSubCategoria = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtBusca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFactor = New System.Windows.Forms.TextBox()
        Me.txtLocalizacion = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.imgArticulo = New System.Windows.Forms.PictureBox()
        Me.btdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.btdEditar = New System.Windows.Forms.ToolStripButton()
        Me.btdEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btdSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.imgArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.dgvResultado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1010, 359)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'dgvResultado
        '
        Me.dgvResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultado.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgvResultado.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultado.Location = New System.Drawing.Point(6, 21)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.ReadOnly = True
        Me.dgvResultado.Size = New System.Drawing.Size(998, 332)
        Me.dgvResultado.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbActivo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbFrecuente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbServicio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbMarca)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbCategoria)
        Me.GroupBox1.Controls.Add(Me.cbSubCategoria)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 120)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio de Busqueda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Activo"
        '
        'cbActivo
        '
        Me.cbActivo.FormattingEnabled = True
        Me.cbActivo.Location = New System.Drawing.Point(398, 25)
        Me.cbActivo.Name = "cbActivo"
        Me.cbActivo.Size = New System.Drawing.Size(77, 24)
        Me.cbActivo.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(326, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Frecuente"
        '
        'cbFrecuente
        '
        Me.cbFrecuente.FormattingEnabled = True
        Me.cbFrecuente.Location = New System.Drawing.Point(398, 85)
        Me.cbFrecuente.Name = "cbFrecuente"
        Me.cbFrecuente.Size = New System.Drawing.Size(77, 24)
        Me.cbFrecuente.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Servicio"
        '
        'cbServicio
        '
        Me.cbServicio.FormattingEnabled = True
        Me.cbServicio.Location = New System.Drawing.Point(398, 55)
        Me.cbServicio.Name = "cbServicio"
        Me.cbServicio.Size = New System.Drawing.Size(77, 24)
        Me.cbServicio.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "SubCategoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Marca"
        '
        'cbMarca
        '
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(110, 85)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(152, 24)
        Me.cbMarca.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Categoria"
        '
        'cbCategoria
        '
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(110, 25)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(152, 24)
        Me.cbCategoria.TabIndex = 30
        '
        'cbSubCategoria
        '
        Me.cbSubCategoria.FormattingEnabled = True
        Me.cbSubCategoria.Location = New System.Drawing.Point(110, 55)
        Me.cbSubCategoria.Name = "cbSubCategoria"
        Me.cbSubCategoria.Size = New System.Drawing.Size(173, 24)
        Me.cbSubCategoria.TabIndex = 29
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btdAgregar, Me.btdEditar, Me.btdEliminar, Me.ToolStripSeparator1, Me.btdImprimir, Me.ToolStripSeparator3, Me.txtBusca, Me.btdBuscar, Me.ToolStripSeparator2, Me.btdSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1034, 52)
        Me.ToolStrip1.TabIndex = 74
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 52)
        '
        'txtBusca
        '
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(400, 52)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.txtFactor)
        Me.GroupBox3.Controls.Add(Me.txtLocalizacion)
        Me.GroupBox3.Controls.Add(Me.txtUnidad)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.imgArticulo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(517, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 120)
        Me.GroupBox3.TabIndex = 75
        Me.GroupBox3.TabStop = False
        '
        'txtFactor
        '
        Me.txtFactor.Enabled = False
        Me.txtFactor.Location = New System.Drawing.Point(132, 85)
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.Size = New System.Drawing.Size(155, 22)
        Me.txtFactor.TabIndex = 87
        '
        'txtLocalizacion
        '
        Me.txtLocalizacion.Enabled = False
        Me.txtLocalizacion.Location = New System.Drawing.Point(132, 55)
        Me.txtLocalizacion.Name = "txtLocalizacion"
        Me.txtLocalizacion.Size = New System.Drawing.Size(155, 22)
        Me.txtLocalizacion.TabIndex = 86
        '
        'txtUnidad
        '
        Me.txtUnidad.Enabled = False
        Me.txtUnidad.Location = New System.Drawing.Point(132, 25)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(155, 22)
        Me.txtUnidad.TabIndex = 85
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(28, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 16)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "Factor"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(28, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 16)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "Localización"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(28, 28)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(52, 16)
        Me.Label29.TabIndex = 82
        Me.Label29.Text = "Unidad"
        '
        'imgArticulo
        '
        Me.imgArticulo.Image = Global.capaPresentacion.My.Resources.Resources.caja_vacia
        Me.imgArticulo.Location = New System.Drawing.Point(328, 6)
        Me.imgArticulo.Name = "imgArticulo"
        Me.imgArticulo.Size = New System.Drawing.Size(144, 114)
        Me.imgArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgArticulo.TabIndex = 81
        Me.imgArticulo.TabStop = False
        '
        'btdAgregar
        '
        Me.btdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdAgregar.Image = CType(resources.GetObject("btdAgregar.Image"), System.Drawing.Image)
        Me.btdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdAgregar.Name = "btdAgregar"
        Me.btdAgregar.Size = New System.Drawing.Size(49, 49)
        Me.btdAgregar.Text = "Agregar Articulo"
        '
        'btdEditar
        '
        Me.btdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdEditar.Image = CType(resources.GetObject("btdEditar.Image"), System.Drawing.Image)
        Me.btdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdEditar.Name = "btdEditar"
        Me.btdEditar.Size = New System.Drawing.Size(49, 49)
        Me.btdEditar.Text = "Editar Información del Articulo"
        '
        'btdEliminar
        '
        Me.btdEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdEliminar.Image = CType(resources.GetObject("btdEliminar.Image"), System.Drawing.Image)
        Me.btdEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdEliminar.Name = "btdEliminar"
        Me.btdEliminar.Size = New System.Drawing.Size(49, 49)
        Me.btdEliminar.Text = "Eliminar Articulo"
        '
        'btdImprimir
        '
        Me.btdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdImprimir.Image = CType(resources.GetObject("btdImprimir.Image"), System.Drawing.Image)
        Me.btdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdImprimir.Name = "btdImprimir"
        Me.btdImprimir.Size = New System.Drawing.Size(49, 49)
        Me.btdImprimir.Text = "Imprimir Listado de Articulos"
        '
        'btdBuscar
        '
        Me.btdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdBuscar.Image = CType(resources.GetObject("btdBuscar.Image"), System.Drawing.Image)
        Me.btdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdBuscar.Name = "btdBuscar"
        Me.btdBuscar.Size = New System.Drawing.Size(49, 49)
        Me.btdBuscar.Text = "Buscar Articulo"
        '
        'btdSalir
        '
        Me.btdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdSalir.Image = CType(resources.GetObject("btdSalir.Image"), System.Drawing.Image)
        Me.btdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdSalir.Name = "btdSalir"
        Me.btdSalir.Size = New System.Drawing.Size(49, 49)
        Me.btdSalir.Text = "Salir"
        '
        'frmCatalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1034, 561)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCatalogo"
        Me.Text = "frmCatalogo"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.imgArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvResultado As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents cbSubCategoria As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btdAgregar As ToolStripButton
    Friend WithEvents btdEditar As ToolStripButton
    Friend WithEvents btdEliminar As ToolStripButton
    Friend WithEvents btdBuscar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btdImprimir As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btdSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents cbServicio As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbActivo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbFrecuente As ComboBox
    Friend WithEvents txtBusca As ToolStripTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents imgArticulo As PictureBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtFactor As TextBox
    Friend WithEvents txtLocalizacion As TextBox
    Friend WithEvents txtUnidad As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
End Class
