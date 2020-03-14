<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupoConsultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrupoConsultas))
        Me.btdClientesXUbicacion = New System.Windows.Forms.Button()
        Me.btdProveedoresXUbicacion = New System.Windows.Forms.Button()
        Me.btdRegistroVentas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btdClientesXUbicacion
        '
        Me.btdClientesXUbicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdClientesXUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdClientesXUbicacion.Image = CType(resources.GetObject("btdClientesXUbicacion.Image"), System.Drawing.Image)
        Me.btdClientesXUbicacion.Location = New System.Drawing.Point(131, 12)
        Me.btdClientesXUbicacion.Name = "btdClientesXUbicacion"
        Me.btdClientesXUbicacion.Size = New System.Drawing.Size(113, 161)
        Me.btdClientesXUbicacion.TabIndex = 3
        Me.btdClientesXUbicacion.Text = "Clientes x Ubicacion"
        Me.btdClientesXUbicacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdClientesXUbicacion.UseVisualStyleBackColor = True
        '
        'btdProveedoresXUbicacion
        '
        Me.btdProveedoresXUbicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdProveedoresXUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdProveedoresXUbicacion.Image = CType(resources.GetObject("btdProveedoresXUbicacion.Image"), System.Drawing.Image)
        Me.btdProveedoresXUbicacion.Location = New System.Drawing.Point(13, 12)
        Me.btdProveedoresXUbicacion.Name = "btdProveedoresXUbicacion"
        Me.btdProveedoresXUbicacion.Size = New System.Drawing.Size(112, 161)
        Me.btdProveedoresXUbicacion.TabIndex = 2
        Me.btdProveedoresXUbicacion.Text = "Proveedores x Ubicacion"
        Me.btdProveedoresXUbicacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdProveedoresXUbicacion.UseVisualStyleBackColor = True
        '
        'btdRegistroVentas
        '
        Me.btdRegistroVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdRegistroVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdRegistroVentas.Image = CType(resources.GetObject("btdRegistroVentas.Image"), System.Drawing.Image)
        Me.btdRegistroVentas.Location = New System.Drawing.Point(250, 12)
        Me.btdRegistroVentas.Name = "btdRegistroVentas"
        Me.btdRegistroVentas.Size = New System.Drawing.Size(113, 161)
        Me.btdRegistroVentas.TabIndex = 4
        Me.btdRegistroVentas.Text = "Registro de Ventas"
        Me.btdRegistroVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdRegistroVentas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(369, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 161)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Ventas x Ubicacion"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmGrupoConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(817, 401)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btdRegistroVentas)
        Me.Controls.Add(Me.btdClientesXUbicacion)
        Me.Controls.Add(Me.btdProveedoresXUbicacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGrupoConsultas"
        Me.Text = "Consultas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btdClientesXUbicacion As Button
    Friend WithEvents btdProveedoresXUbicacion As Button
    Friend WithEvents btdRegistroVentas As Button
    Friend WithEvents Button1 As Button
End Class
