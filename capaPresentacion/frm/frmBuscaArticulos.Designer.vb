<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscaArticulos))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btdCancelar = New System.Windows.Forms.PictureBox()
        Me.btdOk = New System.Windows.Forms.PictureBox()
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.cbSubCategoria = New System.Windows.Forms.ComboBox()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbId = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btdCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btdOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.btdCancelar)
        Me.GroupBox2.Controls.Add(Me.btdOk)
        Me.GroupBox2.Controls.Add(Me.dgvResultado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(894, 257)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado"
        '
        'btdCancelar
        '
        Me.btdCancelar.Image = CType(resources.GetObject("btdCancelar.Image"), System.Drawing.Image)
        Me.btdCancelar.Location = New System.Drawing.Point(822, 88)
        Me.btdCancelar.Name = "btdCancelar"
        Me.btdCancelar.Size = New System.Drawing.Size(66, 61)
        Me.btdCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btdCancelar.TabIndex = 30
        Me.btdCancelar.TabStop = False
        '
        'btdOk
        '
        Me.btdOk.Image = CType(resources.GetObject("btdOk.Image"), System.Drawing.Image)
        Me.btdOk.Location = New System.Drawing.Point(822, 21)
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
        Me.dgvResultado.Size = New System.Drawing.Size(810, 230)
        Me.dgvResultado.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbMarca)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbCategoria)
        Me.GroupBox1.Controls.Add(Me.cbSubCategoria)
        Me.GroupBox1.Controls.Add(Me.rbNombre)
        Me.GroupBox1.Controls.Add(Me.rbId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBusca)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(894, 87)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio de Busqueda"
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
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Checked = True
        Me.rbNombre.Location = New System.Drawing.Point(773, 22)
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
        Me.rbId.Location = New System.Drawing.Point(773, 48)
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
        Me.txtBusca.Location = New System.Drawing.Point(90, 21)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(644, 22)
        Me.txtBusca.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Categoria"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "SubCategoria"
        '
        'frmBuscaArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(918, 385)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscaArticulos"
        Me.Text = "frmBuscaArticulos"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.btdCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btdOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btdCancelar As PictureBox
    Friend WithEvents btdOk As PictureBox
    Friend WithEvents dgvResultado As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents rbId As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents cbSubCategoria As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
