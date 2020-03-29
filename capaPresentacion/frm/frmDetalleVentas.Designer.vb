<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleVentas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleVentas))
        Me.dgvResultado = New System.Windows.Forms.DataGridView()
        Me.btdCancelar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.cbActivo = New System.Windows.Forms.ComboBox()
        Me.cbFrecuente = New System.Windows.Forms.ComboBox()
        Me.cbServicio = New System.Windows.Forms.ComboBox()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.cbSubCategoria = New System.Windows.Forms.ComboBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btdCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvResultado
        '
        Me.dgvResultado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvResultado.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvResultado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvResultado.ColumnHeadersHeight = 30
        Me.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvResultado.EnableHeadersVisualStyles = False
        Me.dgvResultado.GridColor = System.Drawing.SystemColors.Control
        Me.dgvResultado.Location = New System.Drawing.Point(12, 192)
        Me.dgvResultado.Name = "dgvResultado"
        Me.dgvResultado.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResultado.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResultado.RowHeadersVisible = False
        Me.dgvResultado.RowHeadersWidth = 50
        Me.dgvResultado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dgvResultado.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvResultado.RowTemplate.Height = 40
        Me.dgvResultado.Size = New System.Drawing.Size(744, 261)
        Me.dgvResultado.TabIndex = 71
        '
        'btdCancelar
        '
        Me.btdCancelar.Image = CType(resources.GetObject("btdCancelar.Image"), System.Drawing.Image)
        Me.btdCancelar.Location = New System.Drawing.Point(733, 1)
        Me.btdCancelar.Name = "btdCancelar"
        Me.btdCancelar.Size = New System.Drawing.Size(35, 31)
        Me.btdCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btdCancelar.TabIndex = 72
        Me.btdCancelar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(190, 12)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(299, 20)
        Me.txtBusca.TabIndex = 74
        Me.txtBusca.TabStop = False
        '
        'cbActivo
        '
        Me.cbActivo.FormattingEnabled = True
        Me.cbActivo.Location = New System.Drawing.Point(478, 61)
        Me.cbActivo.Name = "cbActivo"
        Me.cbActivo.Size = New System.Drawing.Size(77, 21)
        Me.cbActivo.TabIndex = 80
        '
        'cbFrecuente
        '
        Me.cbFrecuente.FormattingEnabled = True
        Me.cbFrecuente.Location = New System.Drawing.Point(478, 121)
        Me.cbFrecuente.Name = "cbFrecuente"
        Me.cbFrecuente.Size = New System.Drawing.Size(77, 21)
        Me.cbFrecuente.TabIndex = 79
        '
        'cbServicio
        '
        Me.cbServicio.FormattingEnabled = True
        Me.cbServicio.Location = New System.Drawing.Point(478, 91)
        Me.cbServicio.Name = "cbServicio"
        Me.cbServicio.Size = New System.Drawing.Size(77, 21)
        Me.cbServicio.TabIndex = 78
        '
        'cbMarca
        '
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(190, 121)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(152, 21)
        Me.cbMarca.TabIndex = 77
        '
        'cbCategoria
        '
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(190, 61)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(152, 21)
        Me.cbCategoria.TabIndex = 76
        '
        'cbSubCategoria
        '
        Me.cbSubCategoria.FormattingEnabled = True
        Me.cbSubCategoria.Location = New System.Drawing.Point(190, 91)
        Me.cbSubCategoria.Name = "cbSubCategoria"
        Me.cbSubCategoria.Size = New System.Drawing.Size(173, 21)
        Me.cbSubCategoria.TabIndex = 75
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(581, 470)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(166, 35)
        Me.btnAceptar.TabIndex = 81
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(516, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 31)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Buscar Artículo"
        '
        'frmDetalleVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 517)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cbActivo)
        Me.Controls.Add(Me.cbFrecuente)
        Me.Controls.Add(Me.cbServicio)
        Me.Controls.Add(Me.cbMarca)
        Me.Controls.Add(Me.cbCategoria)
        Me.Controls.Add(Me.cbSubCategoria)
        Me.Controls.Add(Me.txtBusca)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btdCancelar)
        Me.Controls.Add(Me.dgvResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDetalleVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleVentas"
        CType(Me.dgvResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btdCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvResultado As DataGridView
    Friend WithEvents btdCancelar As PictureBox
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents cbActivo As ComboBox
    Friend WithEvents cbFrecuente As ComboBox
    Friend WithEvents cbServicio As ComboBox
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents cbSubCategoria As ComboBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Label1 As Label
    Public WithEvents PictureBox1 As PictureBox
End Class
