<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wfMenuPrincipal))
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVentas
        '
        Me.btnVentas.BackgroundImage = CType(resources.GetObject("btnVentas.BackgroundImage"), System.Drawing.Image)
        Me.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVentas.Location = New System.Drawing.Point(26, 48)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(83, 75)
        Me.btnVentas.TabIndex = 0
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.BackgroundImage = CType(resources.GetObject("btnProductos.BackgroundImage"), System.Drawing.Image)
        Me.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProductos.Location = New System.Drawing.Point(26, 166)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(83, 75)
        Me.btnProductos.TabIndex = 1
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.BackgroundImage = CType(resources.GetObject("btnClientes.BackgroundImage"), System.Drawing.Image)
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClientes.Location = New System.Drawing.Point(238, 48)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(83, 75)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnReportes
        '
        Me.btnReportes.BackgroundImage = CType(resources.GetObject("btnReportes.BackgroundImage"), System.Drawing.Image)
        Me.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReportes.FlatAppearance.BorderSize = 3
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnReportes.Location = New System.Drawing.Point(238, 166)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(83, 75)
        Me.btnReportes.TabIndex = 3
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ventas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Productos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(346, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Clientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(340, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 48)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Consulta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Ventas"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(463, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'wfMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 410)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "wfMenuPrincipal"
        Me.Text = "wfMenuPrincipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVentas As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
