<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicios))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtBusca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.cbSubCategoria = New System.Windows.Forms.ComboBox()
        Me.btdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.btdEditar = New System.Windows.Forms.ToolStripButton()
        Me.btdEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.btdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(45, 45)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btdAgregar, Me.btdEditar, Me.btdEliminar, Me.ToolStripSeparator1, Me.btdImprimir, Me.ToolStripSeparator3, Me.txtBusca, Me.btdBuscar, Me.ToolStripSeparator2, Me.btdSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(890, 52)
        Me.ToolStrip1.TabIndex = 68
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
        Me.txtBusca.Size = New System.Drawing.Size(150, 52)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.dgvResultado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(839, 257)
        Me.GroupBox2.TabIndex = 92
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cbMarca)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbCategoria)
        Me.GroupBox3.Controls.Add(Me.cbSubCategoria)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(15, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(839, 65)
        Me.GroupBox3.TabIndex = 93
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Criterio de Busqueda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "SubCategoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(530, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Marca"
        '
        'cbMarca
        '
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(582, 27)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(152, 24)
        Me.cbMarca.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Categoria"
        '
        'cbCategoria
        '
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(90, 27)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(152, 24)
        Me.cbCategoria.TabIndex = 30
        '
        'cbSubCategoria
        '
        Me.cbSubCategoria.FormattingEnabled = True
        Me.cbSubCategoria.Location = New System.Drawing.Point(351, 27)
        Me.cbSubCategoria.Name = "cbSubCategoria"
        Me.cbSubCategoria.Size = New System.Drawing.Size(173, 24)
        Me.cbSubCategoria.TabIndex = 29
        '
        'btdAgregar
        '
        Me.btdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdAgregar.Image = CType(resources.GetObject("btdAgregar.Image"), System.Drawing.Image)
        Me.btdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdAgregar.Name = "btdAgregar"
        Me.btdAgregar.Size = New System.Drawing.Size(49, 49)
        Me.btdAgregar.Text = "Agregar Servicio"
        '
        'btdEditar
        '
        Me.btdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdEditar.Image = CType(resources.GetObject("btdEditar.Image"), System.Drawing.Image)
        Me.btdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdEditar.Name = "btdEditar"
        Me.btdEditar.Size = New System.Drawing.Size(49, 49)
        Me.btdEditar.Text = "Editar Información del Servicio"
        '
        'btdEliminar
        '
        Me.btdEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdEliminar.Image = CType(resources.GetObject("btdEliminar.Image"), System.Drawing.Image)
        Me.btdEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdEliminar.Name = "btdEliminar"
        Me.btdEliminar.Size = New System.Drawing.Size(49, 49)
        Me.btdEliminar.Text = "Eliminar Servicio"
        '
        'btdImprimir
        '
        Me.btdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdImprimir.Image = CType(resources.GetObject("btdImprimir.Image"), System.Drawing.Image)
        Me.btdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdImprimir.Name = "btdImprimir"
        Me.btdImprimir.Size = New System.Drawing.Size(49, 49)
        Me.btdImprimir.Text = "Imprimir Listado de Servicios"
        '
        'btdBuscar
        '
        Me.btdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdBuscar.Image = CType(resources.GetObject("btdBuscar.Image"), System.Drawing.Image)
        Me.btdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdBuscar.Name = "btdBuscar"
        Me.btdBuscar.Size = New System.Drawing.Size(49, 49)
        Me.btdBuscar.Text = "Buscar Servicio"
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
        'frmServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(890, 460)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmServicios"
        Me.Text = "Servicios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents txtBusca As ToolStripTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvResultado As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents cbSubCategoria As ComboBox
End Class
