<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupoMaestros
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
        Me.btdMarcas = New System.Windows.Forms.Button()
        Me.btdBancos = New System.Windows.Forms.Button()
        Me.btdServicios = New System.Windows.Forms.Button()
        Me.btdVendedores = New System.Windows.Forms.Button()
        Me.btdSubCategorias = New System.Windows.Forms.Button()
        Me.btdCategorias = New System.Windows.Forms.Button()
        Me.btdCatalogo = New System.Windows.Forms.Button()
        Me.btdEmpresasEnvio = New System.Windows.Forms.Button()
        Me.btdClientes = New System.Windows.Forms.Button()
        Me.btdProveedores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btdMarcas
        '
        Me.btdMarcas.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.marcas
        Me.btdMarcas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdMarcas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdMarcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdMarcas.Location = New System.Drawing.Point(603, 12)
        Me.btdMarcas.Name = "btdMarcas"
        Me.btdMarcas.Size = New System.Drawing.Size(112, 133)
        Me.btdMarcas.TabIndex = 8
        Me.btdMarcas.Text = "Marcas"
        Me.btdMarcas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdMarcas.UseVisualStyleBackColor = True
        '
        'btdBancos
        '
        Me.btdBancos.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.ctasBancarias
        Me.btdBancos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdBancos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdBancos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdBancos.Location = New System.Drawing.Point(721, 12)
        Me.btdBancos.Name = "btdBancos"
        Me.btdBancos.Size = New System.Drawing.Size(112, 133)
        Me.btdBancos.TabIndex = 11
        Me.btdBancos.Text = "Ctas. Bancarias"
        Me.btdBancos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdBancos.UseVisualStyleBackColor = True
        '
        'btdServicios
        '
        Me.btdServicios.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.Servicios
        Me.btdServicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdServicios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdServicios.Location = New System.Drawing.Point(249, 12)
        Me.btdServicios.Name = "btdServicios"
        Me.btdServicios.Size = New System.Drawing.Size(112, 133)
        Me.btdServicios.TabIndex = 10
        Me.btdServicios.Text = "Servicios"
        Me.btdServicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdServicios.UseVisualStyleBackColor = True
        '
        'btdVendedores
        '
        Me.btdVendedores.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.Vendedores
        Me.btdVendedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdVendedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdVendedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdVendedores.Location = New System.Drawing.Point(131, 12)
        Me.btdVendedores.Name = "btdVendedores"
        Me.btdVendedores.Size = New System.Drawing.Size(112, 133)
        Me.btdVendedores.TabIndex = 9
        Me.btdVendedores.Text = "Vendedores"
        Me.btdVendedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdVendedores.UseVisualStyleBackColor = True
        '
        'btdSubCategorias
        '
        Me.btdSubCategorias.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.Registro_de_Ventas
        Me.btdSubCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdSubCategorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdSubCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdSubCategorias.Location = New System.Drawing.Point(485, 12)
        Me.btdSubCategorias.Name = "btdSubCategorias"
        Me.btdSubCategorias.Size = New System.Drawing.Size(112, 133)
        Me.btdSubCategorias.TabIndex = 7
        Me.btdSubCategorias.Text = "SubCategorías"
        Me.btdSubCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdSubCategorias.UseVisualStyleBackColor = True
        '
        'btdCategorias
        '
        Me.btdCategorias.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.categorias
        Me.btdCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdCategorias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdCategorias.Location = New System.Drawing.Point(367, 12)
        Me.btdCategorias.Name = "btdCategorias"
        Me.btdCategorias.Size = New System.Drawing.Size(112, 133)
        Me.btdCategorias.TabIndex = 6
        Me.btdCategorias.Text = "Categorías"
        Me.btdCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdCategorias.UseVisualStyleBackColor = True
        '
        'btdCatalogo
        '
        Me.btdCatalogo.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.Catalogo
        Me.btdCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdCatalogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdCatalogo.Location = New System.Drawing.Point(12, 12)
        Me.btdCatalogo.Name = "btdCatalogo"
        Me.btdCatalogo.Size = New System.Drawing.Size(112, 133)
        Me.btdCatalogo.TabIndex = 5
        Me.btdCatalogo.Text = "Catalogo"
        Me.btdCatalogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdCatalogo.UseVisualStyleBackColor = True
        '
        'btdEmpresasEnvio
        '
        Me.btdEmpresasEnvio.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.EmpresasEnvio
        Me.btdEmpresasEnvio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdEmpresasEnvio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdEmpresasEnvio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdEmpresasEnvio.Location = New System.Drawing.Point(839, 12)
        Me.btdEmpresasEnvio.Name = "btdEmpresasEnvio"
        Me.btdEmpresasEnvio.Size = New System.Drawing.Size(112, 133)
        Me.btdEmpresasEnvio.TabIndex = 4
        Me.btdEmpresasEnvio.Text = "Courier"
        Me.btdEmpresasEnvio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdEmpresasEnvio.UseVisualStyleBackColor = True
        '
        'btdClientes
        '
        Me.btdClientes.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.Clientes
        Me.btdClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdClientes.Location = New System.Drawing.Point(12, 151)
        Me.btdClientes.Name = "btdClientes"
        Me.btdClientes.Size = New System.Drawing.Size(113, 133)
        Me.btdClientes.TabIndex = 3
        Me.btdClientes.Text = "Clientes"
        Me.btdClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdClientes.UseVisualStyleBackColor = True
        '
        'btdProveedores
        '
        Me.btdProveedores.BackgroundImage = Global.capaPresentacion.My.Resources.Resources.Proveedores
        Me.btdProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btdProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdProveedores.Location = New System.Drawing.Point(131, 151)
        Me.btdProveedores.Name = "btdProveedores"
        Me.btdProveedores.Size = New System.Drawing.Size(112, 133)
        Me.btdProveedores.TabIndex = 2
        Me.btdProveedores.Text = "Proveedores"
        Me.btdProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btdProveedores.UseVisualStyleBackColor = True
        '
        'frmGrupoMaestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1050, 401)
        Me.Controls.Add(Me.btdBancos)
        Me.Controls.Add(Me.btdServicios)
        Me.Controls.Add(Me.btdVendedores)
        Me.Controls.Add(Me.btdMarcas)
        Me.Controls.Add(Me.btdSubCategorias)
        Me.Controls.Add(Me.btdCategorias)
        Me.Controls.Add(Me.btdCatalogo)
        Me.Controls.Add(Me.btdEmpresasEnvio)
        Me.Controls.Add(Me.btdClientes)
        Me.Controls.Add(Me.btdProveedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGrupoMaestros"
        Me.Text = "Maestros"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btdClientes As Button
    Friend WithEvents btdProveedores As Button
    Friend WithEvents btdEmpresasEnvio As Button
    Friend WithEvents btdCatalogo As Button
    Friend WithEvents btdCategorias As Button
    Friend WithEvents btdSubCategorias As Button
    Friend WithEvents btdVendedores As Button
    Friend WithEvents btdMarcas As Button
    Friend WithEvents btdBancos As Button
    Friend WithEvents btdServicios As Button
End Class
