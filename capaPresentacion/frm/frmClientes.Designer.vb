<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclientes
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmclientes))
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btdCancelar = New System.Windows.Forms.PictureBox()
        Me.btdAceptar = New System.Windows.Forms.Button()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btdCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvResultado
        '
        Me.dgvResultado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvResultado.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvResultado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvResultado.ColumnHeadersHeight = 30
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvResultado.EnableHeadersVisualStyles = False
        Me.dgvResultado.GridColor = System.Drawing.SystemColors.Control
        Me.dgvResultado.Location = New System.Drawing.Point(13, 130)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultado.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvResultado.RowHeadersVisible = False
        Me.dgvResultado.RowHeadersWidth = 50
        Me.dgvResultado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dgvResultado.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvResultado.RowTemplate.Height = 40
        Me.dgvResultado.Size = New System.Drawing.Size(588, 193)
        Me.dgvResultado.TabIndex = 72
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(96, 82)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(505, 20)
        Me.txtBusca.TabIndex = 73
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.capaPresentacion.My.Resources.Resources.menuBuscar
        Me.PictureBox1.Location = New System.Drawing.Point(13, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Buscar :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.capaPresentacion.My.Resources.Resources.menuCliente
        Me.PictureBox2.Location = New System.Drawing.Point(246, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 76
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Seleccionar Cliente"
        '
        'btdCancelar
        '
        Me.btdCancelar.Image = CType(resources.GetObject("btdCancelar.Image"), System.Drawing.Image)
        Me.btdCancelar.Location = New System.Drawing.Point(599, -1)
        Me.btdCancelar.Name = "btdCancelar"
        Me.btdCancelar.Size = New System.Drawing.Size(35, 31)
        Me.btdCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btdCancelar.TabIndex = 78
        Me.btdCancelar.TabStop = False
        '
        'btdAceptar
        '
        Me.btdAceptar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btdAceptar.Location = New System.Drawing.Point(435, 342)
        Me.btdAceptar.Name = "btdAceptar"
        Me.btdAceptar.Size = New System.Drawing.Size(166, 35)
        Me.btdAceptar.TabIndex = 82
        Me.btdAceptar.Text = "Aceptar"
        Me.btdAceptar.UseVisualStyleBackColor = False
        '
        'frmclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(633, 438)
        Me.Controls.Add(Me.btdAceptar)
        Me.Controls.Add(Me.btdCancelar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtBusca)
        Me.Controls.Add(Me.dgvResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmclientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btdCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvResultado As DataGridView
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btdCancelar As PictureBox
    Friend WithEvents btdAceptar As Button
End Class
