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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btdAjustes = New System.Windows.Forms.Button()
        Me.btdTransferencias = New System.Windows.Forms.Button()
        Me.btdOrdenCompra = New System.Windows.Forms.Button()
        Me.btdCompras = New System.Windows.Forms.Button()
        Me.btdPresupuestos = New System.Windows.Forms.Button()
        Me.btdCierreCaja = New System.Windows.Forms.Button()
        Me.btdVentas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.Devoluciones
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(849, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 154)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Devoluciones"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btdAjustes
        '
        Me.btdAjustes.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.AjustesInventario
        Me.btdAjustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdAjustes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdAjustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdAjustes.Location = New System.Drawing.Point(731, 17)
        Me.btdAjustes.Name = "btdAjustes"
        Me.btdAjustes.Size = New System.Drawing.Size(112, 154)
        Me.btdAjustes.TabIndex = 13
        Me.btdAjustes.Text = "Ajustes"
        Me.btdAjustes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdAjustes.UseVisualStyleBackColor = True
        '
        'btdTransferencias
        '
        Me.btdTransferencias.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.TransferenciasAlmacen
        Me.btdTransferencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdTransferencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdTransferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdTransferencias.Location = New System.Drawing.Point(613, 17)
        Me.btdTransferencias.Name = "btdTransferencias"
        Me.btdTransferencias.Size = New System.Drawing.Size(112, 154)
        Me.btdTransferencias.TabIndex = 12
        Me.btdTransferencias.Text = "Transferencias"
        Me.btdTransferencias.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdTransferencias.UseVisualStyleBackColor = True
        '
        'btdOrdenCompra
        '
        Me.btdOrdenCompra.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.OrdenCompra
        Me.btdOrdenCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdOrdenCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdOrdenCompra.Location = New System.Drawing.Point(495, 17)
        Me.btdOrdenCompra.Name = "btdOrdenCompra"
        Me.btdOrdenCompra.Size = New System.Drawing.Size(112, 154)
        Me.btdOrdenCompra.TabIndex = 11
        Me.btdOrdenCompra.Text = "Ordenes/Compra"
        Me.btdOrdenCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdOrdenCompra.UseVisualStyleBackColor = True
        '
        'btdCompras
        '
        Me.btdCompras.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.compra
        Me.btdCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdCompras.Location = New System.Drawing.Point(377, 17)
        Me.btdCompras.Name = "btdCompras"
        Me.btdCompras.Size = New System.Drawing.Size(112, 154)
        Me.btdCompras.TabIndex = 10
        Me.btdCompras.Text = "Compras"
        Me.btdCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdCompras.UseVisualStyleBackColor = True
        '
        'btdPresupuestos
        '
        Me.btdPresupuestos.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.Presupuestos
        Me.btdPresupuestos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdPresupuestos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdPresupuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdPresupuestos.Location = New System.Drawing.Point(259, 17)
        Me.btdPresupuestos.Name = "btdPresupuestos"
        Me.btdPresupuestos.Size = New System.Drawing.Size(112, 154)
        Me.btdPresupuestos.TabIndex = 9
        Me.btdPresupuestos.Text = "Presupuestos"
        Me.btdPresupuestos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdPresupuestos.UseVisualStyleBackColor = True
        '
        'btdCierreCaja
        '
        Me.btdCierreCaja.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.AperturaCaja
        Me.btdCierreCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdCierreCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdCierreCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdCierreCaja.Location = New System.Drawing.Point(141, 17)
        Me.btdCierreCaja.Name = "btdCierreCaja"
        Me.btdCierreCaja.Size = New System.Drawing.Size(112, 154)
        Me.btdCierreCaja.TabIndex = 8
        Me.btdCierreCaja.Text = "Apertura/Cierre de Caja"
        Me.btdCierreCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdCierreCaja.UseVisualStyleBackColor = True
        '
        'btdVentas
        '
        Me.btdVentas.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.Ventas
        Me.btdVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdVentas.Location = New System.Drawing.Point(23, 17)
        Me.btdVentas.Name = "btdVentas"
        Me.btdVentas.Size = New System.Drawing.Size(112, 154)
        Me.btdVentas.TabIndex = 7
        Me.btdVentas.Text = "Ventas"
        Me.btdVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdVentas.UseVisualStyleBackColor = True
        '
        'frmGrupoOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1050, 401)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btdAjustes)
        Me.Controls.Add(Me.btdTransferencias)
        Me.Controls.Add(Me.btdOrdenCompra)
        Me.Controls.Add(Me.btdCompras)
        Me.Controls.Add(Me.btdPresupuestos)
        Me.Controls.Add(Me.btdCierreCaja)
        Me.Controls.Add(Me.btdVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGrupoOperaciones"
        Me.Text = "Devoluciones"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btdAjustes As Button
    Friend WithEvents btdTransferencias As Button
    Friend WithEvents btdOrdenCompra As Button
    Friend WithEvents btdCompras As Button
    Friend WithEvents btdPresupuestos As Button
    Friend WithEvents btdCierreCaja As Button
    Friend WithEvents btdVentas As Button
    Friend WithEvents Button1 As Button
End Class
