<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBancos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBancos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.btdEditar = New System.Windows.Forms.ToolStripButton()
        Me.btdEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btdOk = New System.Windows.Forms.ToolStripButton()
        Me.btdCancela = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.cbTpCuenta = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNroCuenta = New System.Windows.Forms.TextBox()
        Me.txtTpCuenta = New System.Windows.Forms.TextBox()
        Me.txtCtaInterBancaria = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btdAgregar, Me.btdEditar, Me.btdEliminar, Me.btdBuscar, Me.ToolStripSeparator1, Me.btdImprimir, Me.ToolStripSeparator3, Me.btdSalir, Me.ToolStripSeparator2, Me.btdOk, Me.btdCancela})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(466, 25)
        Me.ToolStrip1.TabIndex = 67
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btdAgregar
        '
        Me.btdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdAgregar.Image = CType(resources.GetObject("btdAgregar.Image"), System.Drawing.Image)
        Me.btdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdAgregar.Name = "btdAgregar"
        Me.btdAgregar.Size = New System.Drawing.Size(23, 22)
        Me.btdAgregar.Text = "Agregar Proveedor"
        '
        'btdEditar
        '
        Me.btdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdEditar.Image = CType(resources.GetObject("btdEditar.Image"), System.Drawing.Image)
        Me.btdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdEditar.Name = "btdEditar"
        Me.btdEditar.Size = New System.Drawing.Size(23, 22)
        Me.btdEditar.Text = "Editar Información del Proveedor"
        '
        'btdEliminar
        '
        Me.btdEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdEliminar.Image = CType(resources.GetObject("btdEliminar.Image"), System.Drawing.Image)
        Me.btdEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdEliminar.Name = "btdEliminar"
        Me.btdEliminar.Size = New System.Drawing.Size(23, 22)
        Me.btdEliminar.Text = "Eliminar Proveedor"
        '
        'btdBuscar
        '
        Me.btdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdBuscar.Image = CType(resources.GetObject("btdBuscar.Image"), System.Drawing.Image)
        Me.btdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdBuscar.Name = "btdBuscar"
        Me.btdBuscar.Size = New System.Drawing.Size(23, 22)
        Me.btdBuscar.Text = "Buscar Proveedor"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btdImprimir
        '
        Me.btdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdImprimir.Image = CType(resources.GetObject("btdImprimir.Image"), System.Drawing.Image)
        Me.btdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdImprimir.Name = "btdImprimir"
        Me.btdImprimir.Size = New System.Drawing.Size(23, 22)
        Me.btdImprimir.Text = "Imprimir Listado de Proveedores"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btdSalir
        '
        Me.btdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdSalir.Image = CType(resources.GetObject("btdSalir.Image"), System.Drawing.Image)
        Me.btdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdSalir.Name = "btdSalir"
        Me.btdSalir.Size = New System.Drawing.Size(23, 22)
        Me.btdSalir.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btdOk
        '
        Me.btdOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdOk.Image = CType(resources.GetObject("btdOk.Image"), System.Drawing.Image)
        Me.btdOk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdOk.Name = "btdOk"
        Me.btdOk.Size = New System.Drawing.Size(23, 22)
        Me.btdOk.Text = "Ok"
        Me.btdOk.Visible = False
        '
        'btdCancela
        '
        Me.btdCancela.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btdCancela.Image = CType(resources.GetObject("btdCancela.Image"), System.Drawing.Image)
        Me.btdCancela.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btdCancela.Name = "btdCancela"
        Me.btdCancela.Size = New System.Drawing.Size(23, 22)
        Me.btdCancela.Text = "Cancelar"
        Me.btdCancela.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 73)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombre Banco"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Id. Banco"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(139, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(268, 22)
        Me.txtNombre.TabIndex = 2
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(139, 15)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(151, 22)
        Me.txtId.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.txtIdCuenta)
        Me.GroupBox2.Controls.Add(Me.cbTpCuenta)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtNroCuenta)
        Me.GroupBox2.Controls.Add(Me.txtTpCuenta)
        Me.GroupBox2.Controls.Add(Me.txtCtaInterBancaria)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(441, 112)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Location = New System.Drawing.Point(348, 21)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(83, 22)
        Me.txtIdCuenta.TabIndex = 60
        Me.txtIdCuenta.Visible = False
        '
        'cbTpCuenta
        '
        Me.cbTpCuenta.FormattingEnabled = True
        Me.cbTpCuenta.Items.AddRange(New Object() {"Ahorro", "Corriente"})
        Me.cbTpCuenta.Location = New System.Drawing.Point(139, 21)
        Me.cbTpCuenta.Name = "cbTpCuenta"
        Me.cbTpCuenta.Size = New System.Drawing.Size(151, 24)
        Me.cbTpCuenta.TabIndex = 6
        Me.cbTpCuenta.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 16)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Nro. de Cuenta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 16)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Cta. InterBancaria"
        '
        'txtNroCuenta
        '
        Me.txtNroCuenta.Enabled = False
        Me.txtNroCuenta.Location = New System.Drawing.Point(137, 51)
        Me.txtNroCuenta.Name = "txtNroCuenta"
        Me.txtNroCuenta.Size = New System.Drawing.Size(173, 22)
        Me.txtNroCuenta.TabIndex = 11
        '
        'txtTpCuenta
        '
        Me.txtTpCuenta.Enabled = False
        Me.txtTpCuenta.Location = New System.Drawing.Point(139, 21)
        Me.txtTpCuenta.Name = "txtTpCuenta"
        Me.txtTpCuenta.Size = New System.Drawing.Size(151, 22)
        Me.txtTpCuenta.TabIndex = 50
        '
        'txtCtaInterBancaria
        '
        Me.txtCtaInterBancaria.Enabled = False
        Me.txtCtaInterBancaria.Location = New System.Drawing.Point(137, 79)
        Me.txtCtaInterBancaria.Name = "txtCtaInterBancaria"
        Me.txtCtaInterBancaria.Size = New System.Drawing.Size(286, 22)
        Me.txtCtaInterBancaria.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Tipo de Cuenta"
        '
        'frmBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(466, 230)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBancos"
        Me.Text = "Bancos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents btdOk As ToolStripButton
    Friend WithEvents btdCancela As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbTpCuenta As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNroCuenta As TextBox
    Friend WithEvents txtTpCuenta As TextBox
    Friend WithEvents txtCtaInterBancaria As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdCuenta As TextBox
End Class
