<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGrupoOperaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrupoOperaciones))
        Me.btdVentas = New System.Windows.Forms.Button()
        Me.btdCirreCaja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btdVentas
        '
        Me.btdVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdVentas.Image = CType(resources.GetObject("btdVentas.Image"), System.Drawing.Image)
        Me.btdVentas.Location = New System.Drawing.Point(12, 12)
        Me.btdVentas.Name = "btdVentas"
        Me.btdVentas.Size = New System.Drawing.Size(112, 154)
        Me.btdVentas.TabIndex = 0
        Me.btdVentas.Text = "Ventas"
        Me.btdVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdVentas.UseVisualStyleBackColor = True
        '
        'btdCirreCaja
        '
        Me.btdCirreCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdCirreCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdCirreCaja.Image = CType(resources.GetObject("btdCirreCaja.Image"), System.Drawing.Image)
        Me.btdCirreCaja.Location = New System.Drawing.Point(130, 12)
        Me.btdCirreCaja.Name = "btdCirreCaja"
        Me.btdCirreCaja.Size = New System.Drawing.Size(112, 154)
        Me.btdCirreCaja.TabIndex = 1
        Me.btdCirreCaja.Text = "Apertura/Cierre de Caja"
        Me.btdCirreCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdCirreCaja.UseVisualStyleBackColor = True
        '
        'frmGrupoOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(833, 440)
        Me.Controls.Add(Me.btdCirreCaja)
        Me.Controls.Add(Me.btdVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGrupoOperaciones"
        Me.Text = "Operaciones"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btdVentas As Button
    Friend WithEvents btdCirreCaja As Button
End Class
