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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cbIdIdentificacion = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNroIdentifiacion = New System.Windows.Forms.TextBox()
        Me.txtIdIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.cbZonas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.cbDistrito = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtWS = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTelefonos = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtUbigeoDistrito = New System.Windows.Forms.TextBox()
        Me.txtTlfContacto = New System.Windows.Forms.TextBox()
        Me.txtNombreContacto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescripcionIdentificacion = New System.Windows.Forms.TextBox()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtDistrito = New System.Windows.Forms.TextBox()
        Me.txtZona = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btdOk = New System.Windows.Forms.ToolStripButton()
        Me.btdCancela = New System.Windows.Forms.ToolStripButton()
        Me.btdAceptar = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'cbIdIdentificacion
        '
        Me.cbIdIdentificacion.FormattingEnabled = True
        Me.cbIdIdentificacion.Location = New System.Drawing.Point(155, 82)
        Me.cbIdIdentificacion.Name = "cbIdIdentificacion"
        Me.cbIdIdentificacion.Size = New System.Drawing.Size(370, 21)
        Me.cbIdIdentificacion.TabIndex = 78
        Me.cbIdIdentificacion.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Nro. Identificación"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Tipo Identificación"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(33, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Nombre Cliente"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(33, 27)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Id. Cliente"
        '
        'txtNroIdentifiacion
        '
        Me.txtNroIdentifiacion.Enabled = False
        Me.txtNroIdentifiacion.Location = New System.Drawing.Point(155, 110)
        Me.txtNroIdentifiacion.Name = "txtNroIdentifiacion"
        Me.txtNroIdentifiacion.Size = New System.Drawing.Size(155, 20)
        Me.txtNroIdentifiacion.TabIndex = 79
        '
        'txtIdIdentificacion
        '
        Me.txtIdIdentificacion.Enabled = False
        Me.txtIdIdentificacion.Location = New System.Drawing.Point(256, 24)
        Me.txtIdIdentificacion.Name = "txtIdIdentificacion"
        Me.txtIdIdentificacion.Size = New System.Drawing.Size(28, 20)
        Me.txtIdIdentificacion.TabIndex = 80
        Me.txtIdIdentificacion.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(155, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(666, 20)
        Me.txtNombre.TabIndex = 77
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(155, 24)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(95, 20)
        Me.txtId.TabIndex = 76
        '
        'cbZonas
        '
        Me.cbZonas.FormattingEnabled = True
        Me.cbZonas.Location = New System.Drawing.Point(528, 219)
        Me.cbZonas.Name = "cbZonas"
        Me.cbZonas.Size = New System.Drawing.Size(296, 21)
        Me.cbZonas.TabIndex = 101
        Me.cbZonas.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(451, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Zona"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(159, 193)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(286, 21)
        Me.cbDepartamento.TabIndex = 86
        Me.cbDepartamento.Visible = False
        '
        'cbProvincia
        '
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(528, 193)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(296, 21)
        Me.cbProvincia.TabIndex = 87
        Me.cbProvincia.Visible = False
        '
        'cbDistrito
        '
        Me.cbDistrito.FormattingEnabled = True
        Me.cbDistrito.Location = New System.Drawing.Point(159, 219)
        Me.cbDistrito.Name = "cbDistrito"
        Me.cbDistrito.Size = New System.Drawing.Size(286, 21)
        Me.cbDistrito.TabIndex = 88
        Me.cbDistrito.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(451, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "WhatsApp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Correo Electronico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Telefonos"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(36, 171)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "Dirección"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(36, 223)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 13)
        Me.Label20.TabIndex = 94
        Me.Label20.Text = "Distrito"
        '
        'txtWS
        '
        Me.txtWS.Enabled = False
        Me.txtWS.Location = New System.Drawing.Point(528, 246)
        Me.txtWS.Name = "txtWS"
        Me.txtWS.Size = New System.Drawing.Size(296, 20)
        Me.txtWS.TabIndex = 91
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(158, 168)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(666, 20)
        Me.txtDireccion.TabIndex = 85
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(451, 197)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 13)
        Me.Label21.TabIndex = 93
        Me.Label21.Text = "Provincia"
        '
        'txtTelefonos
        '
        Me.txtTelefonos.Enabled = False
        Me.txtTelefonos.Location = New System.Drawing.Point(158, 246)
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Size = New System.Drawing.Size(286, 20)
        Me.txtTelefonos.TabIndex = 89
        '
        'txtCorreo
        '
        Me.txtCorreo.Enabled = False
        Me.txtCorreo.Location = New System.Drawing.Point(158, 274)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(286, 20)
        Me.txtCorreo.TabIndex = 90
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(36, 197)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 13)
        Me.Label22.TabIndex = 92
        Me.Label22.Text = "Departamento"
        '
        'txtUbigeoDistrito
        '
        Me.txtUbigeoDistrito.Enabled = False
        Me.txtUbigeoDistrito.Location = New System.Drawing.Point(528, 274)
        Me.txtUbigeoDistrito.Name = "txtUbigeoDistrito"
        Me.txtUbigeoDistrito.Size = New System.Drawing.Size(238, 20)
        Me.txtUbigeoDistrito.TabIndex = 99
        Me.txtUbigeoDistrito.Visible = False
        '
        'txtTlfContacto
        '
        Me.txtTlfContacto.Enabled = False
        Me.txtTlfContacto.Location = New System.Drawing.Point(528, 326)
        Me.txtTlfContacto.Name = "txtTlfContacto"
        Me.txtTlfContacto.Size = New System.Drawing.Size(293, 20)
        Me.txtTlfContacto.TabIndex = 57
        '
        'txtNombreContacto
        '
        Me.txtNombreContacto.Enabled = False
        Me.txtNombreContacto.Location = New System.Drawing.Point(158, 323)
        Me.txtNombreContacto.Name = "txtNombreContacto"
        Me.txtNombreContacto.Size = New System.Drawing.Size(286, 20)
        Me.txtNombreContacto.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Telefonos"
        '
        'txtDescripcionIdentificacion
        '
        Me.txtDescripcionIdentificacion.Enabled = False
        Me.txtDescripcionIdentificacion.Location = New System.Drawing.Point(155, 82)
        Me.txtDescripcionIdentificacion.Name = "txtDescripcionIdentificacion"
        Me.txtDescripcionIdentificacion.Size = New System.Drawing.Size(370, 20)
        Me.txtDescripcionIdentificacion.TabIndex = 102
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Enabled = False
        Me.txtDepartamento.Location = New System.Drawing.Point(159, 194)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(286, 20)
        Me.txtDepartamento.TabIndex = 103
        '
        'txtProvincia
        '
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Location = New System.Drawing.Point(528, 194)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(296, 20)
        Me.txtProvincia.TabIndex = 104
        '
        'txtDistrito
        '
        Me.txtDistrito.Enabled = False
        Me.txtDistrito.Location = New System.Drawing.Point(159, 220)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(286, 20)
        Me.txtDistrito.TabIndex = 105
        '
        'txtZona
        '
        Me.txtZona.Enabled = False
        Me.txtZona.Location = New System.Drawing.Point(528, 219)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(296, 20)
        Me.txtZona.TabIndex = 106
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.menuAgregar
        Me.btnAgregar.Location = New System.Drawing.Point(388, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(43, 34)
        Me.btnAgregar.TabIndex = 109
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.menuEditar2
        Me.btnEditar.Location = New System.Drawing.Point(339, 12)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(43, 34)
        Me.btnEditar.TabIndex = 108
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.menuBuscar
        Me.btnBuscar.Location = New System.Drawing.Point(290, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(43, 34)
        Me.btnBuscar.TabIndex = 107
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        'btdAceptar
        '
        Me.btdAceptar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btdAceptar.Location = New System.Drawing.Point(658, 378)
        Me.btdAceptar.Name = "btdAceptar"
        Me.btdAceptar.Size = New System.Drawing.Size(166, 35)
        Me.btdAceptar.TabIndex = 110
        Me.btdAceptar.Text = "Aceptar"
        Me.btdAceptar.UseVisualStyleBackColor = False
        '
        'frmDetalleClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 501)
        Me.Controls.Add(Me.btdAceptar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtZona)
        Me.Controls.Add(Me.txtDistrito)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.txtDescripcionIdentificacion)
        Me.Controls.Add(Me.txtTlfContacto)
        Me.Controls.Add(Me.cbZonas)
        Me.Controls.Add(Me.txtNombreContacto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.cbProvincia)
        Me.Controls.Add(Me.cbDistrito)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtWS)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtTelefonos)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtUbigeoDistrito)
        Me.Controls.Add(Me.cbIdIdentificacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtNroIdentifiacion)
        Me.Controls.Add(Me.txtIdIdentificacion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDetalleClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Clientes"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btdOk As ToolStripButton
    Friend WithEvents btdCancela As ToolStripButton
    Friend WithEvents cbIdIdentificacion As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtNroIdentifiacion As TextBox
    Friend WithEvents txtIdIdentificacion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents cbZonas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents cbDistrito As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtWS As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtTelefonos As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtUbigeoDistrito As TextBox
    Friend WithEvents txtTlfContacto As TextBox
    Friend WithEvents txtNombreContacto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescripcionIdentificacion As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtDistrito As TextBox
    Friend WithEvents txtZona As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btdAceptar As Button
End Class
