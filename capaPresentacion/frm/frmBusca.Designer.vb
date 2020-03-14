<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBusca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusca))
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbId = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btdCancelar = New System.Windows.Forms.PictureBox()
        Me.btdOk = New System.Windows.Forms.PictureBox()
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btdCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btdOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Location = New System.Drawing.Point(3, 2)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(523, 15)
        Me.txtTitulo.TabIndex = 0
        Me.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.rbNombre)
        Me.GroupBox1.Controls.Add(Me.rbId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBusca)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 57)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio de Busqueda"
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Checked = True
        Me.rbNombre.Location = New System.Drawing.Point(399, 24)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(99, 20)
        Me.rbNombre.TabIndex = 27
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Por Nombre"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'rbId
        '
        Me.rbId.AutoSize = True
        Me.rbId.Location = New System.Drawing.Point(504, 24)
        Me.rbId.Name = "rbId"
        Me.rbId.Size = New System.Drawing.Size(61, 20)
        Me.rbId.TabIndex = 26
        Me.rbId.Text = "Por Id"
        Me.rbId.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Buscar"
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(71, 21)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(310, 22)
        Me.txtBusca.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.btdCancelar)
        Me.GroupBox2.Controls.Add(Me.btdOk)
        Me.GroupBox2.Controls.Add(Me.dgvResultado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 257)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'btdCancelar
        '
        Me.btdCancelar.Image = CType(resources.GetObject("btdCancelar.Image"), System.Drawing.Image)
        Me.btdCancelar.Location = New System.Drawing.Point(504, 88)
        Me.btdCancelar.Name = "btdCancelar"
        Me.btdCancelar.Size = New System.Drawing.Size(66, 61)
        Me.btdCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btdCancelar.TabIndex = 30
        Me.btdCancelar.TabStop = False
        '
        'btdOk
        '
        Me.btdOk.Image = CType(resources.GetObject("btdOk.Image"), System.Drawing.Image)
        Me.btdOk.Location = New System.Drawing.Point(504, 21)
        Me.btdOk.Name = "btdOk"
        Me.btdOk.Size = New System.Drawing.Size(66, 61)
        Me.btdOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btdOk.TabIndex = 29
        Me.btdOk.TabStop = False
        '
        'dgvResultado
        '
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultado.Location = New System.Drawing.Point(6, 21)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.ReadOnly = True
        Me.dgvResultado.Size = New System.Drawing.Size(492, 230)
        Me.dgvResultado.TabIndex = 0
        '
        'frmBusca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(600, 353)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBusca"
        Me.Text = "Busqueda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.btdCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btdOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents rbId As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvResultado As DataGridView
    Friend WithEvents btdCancelar As PictureBox
    Friend WithEvents btdOk As PictureBox
End Class
