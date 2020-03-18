<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleClientes))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTlfContacto = New System.Windows.Forms.TextBox()
        Me.txtNombreContacto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbZonas = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtZona = New System.Windows.Forms.TextBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.cbDistrito = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtWS = New System.Windows.Forms.TextBox()
        Me.txtDistrito = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtTelefonos = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUbigeoDistrito = New System.Windows.Forms.TextBox()
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btdOk = New System.Windows.Forms.ToolStripButton()
        Me.btdCancela = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.txtTlfContacto)
        Me.GroupBox3.Controls.Add(Me.txtNombreContacto)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(21, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(815, 60)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información de Contacto"
        '
        'txtTlfContacto
        '
        Me.txtTlfContacto.Enabled = False
        Me.txtTlfContacto.Location = New System.Drawing.Point(507, 24)
        Me.txtTlfContacto.Name = "txtTlfContacto"
        Me.txtTlfContacto.Size = New System.Drawing.Size(293, 22)
        Me.txtTlfContacto.TabIndex = 13
        '
        'txtNombreContacto
        '
        Me.txtNombreContacto.Enabled = False
        Me.txtNombreContacto.Location = New System.Drawing.Point(137, 21)
        Me.txtNombreContacto.Name = "txtNombreContacto"
        Me.txtNombreContacto.Size = New System.Drawing.Size(286, 22)
        Me.txtNombreContacto.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 16)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Nombre"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(429, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 16)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Telefonos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.cbZonas)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtZona)
        Me.GroupBox2.Controls.Add(Me.cbDepartamento)
        Me.GroupBox2.Controls.Add(Me.cbProvincia)
        Me.GroupBox2.Controls.Add(Me.cbDistrito)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtWS)
        Me.GroupBox2.Controls.Add(Me.txtDistrito)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDepartamento)
        Me.GroupBox2.Controls.Add(Me.txtProvincia)
        Me.GroupBox2.Controls.Add(Me.txtTelefonos)
        Me.GroupBox2.Controls.Add(Me.txtCorreo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtUbigeoDistrito)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(817, 158)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubicación"
        '
        'cbZonas
        '
        Me.cbZonas.FormattingEnabled = True
        Me.cbZonas.Location = New System.Drawing.Point(509, 71)
        Me.cbZonas.Name = "cbZonas"
        Me.cbZonas.Size = New System.Drawing.Size(296, 24)
        Me.cbZonas.TabIndex = 63
        Me.cbZonas.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(432, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 16)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Zona"
        '
        'txtZona
        '
        Me.txtZona.Enabled = False
        Me.txtZona.Location = New System.Drawing.Point(509, 71)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(296, 22)
        Me.txtZona.TabIndex = 61
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(139, 45)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(286, 24)
        Me.cbDepartamento.TabIndex = 6
        Me.cbDepartamento.Visible = False
        '
        'cbProvincia
        '
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(509, 45)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(296, 24)
        Me.cbProvincia.TabIndex = 7
        Me.cbProvincia.Visible = False
        '
        'cbDistrito
        '
        Me.cbDistrito.FormattingEnabled = True
        Me.cbDistrito.Location = New System.Drawing.Point(139, 71)
        Me.cbDistrito.Name = "cbDistrito"
        Me.cbDistrito.Size = New System.Drawing.Size(286, 24)
        Me.cbDistrito.TabIndex = 8
        Me.cbDistrito.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(432, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 16)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "WhatsApp"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 16)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Correo Electronico"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 16)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Telefonos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Dirección"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Distrito"
        '
        'txtWS
        '
        Me.txtWS.Enabled = False
        Me.txtWS.Location = New System.Drawing.Point(509, 97)
        Me.txtWS.Name = "txtWS"
        Me.txtWS.Size = New System.Drawing.Size(296, 22)
        Me.txtWS.TabIndex = 11
        '
        'txtDistrito
        '
        Me.txtDistrito.Enabled = False
        Me.txtDistrito.Location = New System.Drawing.Point(139, 71)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(286, 22)
        Me.txtDistrito.TabIndex = 52
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(139, 19)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(666, 22)
        Me.txtDireccion.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(432, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Provincia"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Enabled = False
        Me.txtDepartamento.Location = New System.Drawing.Point(139, 45)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(286, 22)
        Me.txtDepartamento.TabIndex = 50
        '
        'txtProvincia
        '
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Location = New System.Drawing.Point(509, 45)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(296, 22)
        Me.txtProvincia.TabIndex = 51
        '
        'txtTelefonos
        '
        Me.txtTelefonos.Enabled = False
        Me.txtTelefonos.Location = New System.Drawing.Point(139, 97)
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Size = New System.Drawing.Size(286, 22)
        Me.txtTelefonos.TabIndex = 9
        '
        'txtCorreo
        '
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Location = New System.Drawing.Point(139, 125)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(286, 22)
        Me.txtCorreo.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Departamento"
        '
        'txtUbigeoDistrito
        '
        Me.txtUbigeoDistrito.Enabled = False
        Me.txtUbigeoDistrito.Location = New System.Drawing.Point(509, 125)
        Me.txtUbigeoDistrito.Name = "txtUbigeoDistrito"
        Me.txtUbigeoDistrito.Size = New System.Drawing.Size(238, 22)
        Me.txtUbigeoDistrito.TabIndex = 60
        Me.txtUbigeoDistrito.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
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
        Me.GroupBox1.Location = New System.Drawing.Point(21, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(817, 142)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificación"
        '
        'cbIdIdentificacion
        '
        Me.cbIdIdentificacion.FormattingEnabled = True
        Me.cbIdIdentificacion.Location = New System.Drawing.Point(139, 79)
        Me.cbIdIdentificacion.Name = "cbIdIdentificacion"
        Me.cbIdIdentificacion.Size = New System.Drawing.Size(370, 24)
        Me.cbIdIdentificacion.TabIndex = 3
        Me.cbIdIdentificacion.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nro. Identificación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 82)
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
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombre Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Id. Cliente"
        '
        'txtNroIdentifiacion
        '
        Me.txtNroIdentifiacion.Enabled = False
        Me.txtNroIdentifiacion.Location = New System.Drawing.Point(139, 109)
        Me.txtNroIdentifiacion.Name = "txtNroIdentifiacion"
        Me.txtNroIdentifiacion.Size = New System.Drawing.Size(155, 22)
        Me.txtNroIdentifiacion.TabIndex = 4
        '
        'txtDescripcionIdentificacion
        '
        Me.txtDescripcionIdentificacion.Enabled = False
        Me.txtDescripcionIdentificacion.Location = New System.Drawing.Point(139, 79)
        Me.txtDescripcionIdentificacion.Name = "txtDescripcionIdentificacion"
        Me.txtDescripcionIdentificacion.Size = New System.Drawing.Size(370, 22)
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
        Me.txtNombre.Size = New System.Drawing.Size(666, 22)
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
        Me.ToolStrip1.Location = New System.Drawing.Point(882, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(50, 501)
        Me.ToolStrip1.TabIndex = 75
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
        'frmDetalleClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 501)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDetalleClientes"
        Me.Text = "Detalle Clientes"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTlfContacto As TextBox
    Friend WithEvents txtNombreContacto As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbZonas As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtZona As TextBox
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents cbDistrito As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtWS As TextBox
    Friend WithEvents txtDistrito As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtTelefonos As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUbigeoDistrito As TextBox
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
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btdOk As ToolStripButton
    Friend WithEvents btdCancela As ToolStripButton
End Class
