<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfABMProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wfABMProductos))
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.txtBusquedaCategoria = New System.Windows.Forms.TextBox()
        Me.txtBusquedaPrecio = New System.Windows.Forms.TextBox()
        Me.txtBusquedaNombre = New System.Windows.Forms.TextBox()
        Me.txtBusquedaID = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(110, 23)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(214, 20)
        Me.txtID.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(110, 215)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 186)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(485, 421)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(115, 28)
        Me.btnEliminar.TabIndex = 32
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(633, 421)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(115, 28)
        Me.btnModificar.TabIndex = 31
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(772, 421)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(115, 28)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(110, 176)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(214, 20)
        Me.txtCategoria.TabIndex = 24
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(110, 125)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(214, 20)
        Me.txtPrecio.TabIndex = 23
        '
        'txtNombre
        '
        Me.txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtNombre.Location = New System.Drawing.Point(110, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(214, 20)
        Me.txtNombre.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nombre"
        '
        'dgvProductos
        '
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(342, 47)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(545, 354)
        Me.dgvProductos.TabIndex = 18
        '
        'txtBusquedaCategoria
        '
        Me.txtBusquedaCategoria.Location = New System.Drawing.Point(771, 23)
        Me.txtBusquedaCategoria.Name = "txtBusquedaCategoria"
        Me.txtBusquedaCategoria.Size = New System.Drawing.Size(115, 20)
        Me.txtBusquedaCategoria.TabIndex = 39
        '
        'txtBusquedaPrecio
        '
        Me.txtBusquedaPrecio.Location = New System.Drawing.Point(638, 23)
        Me.txtBusquedaPrecio.Name = "txtBusquedaPrecio"
        Me.txtBusquedaPrecio.Size = New System.Drawing.Size(127, 20)
        Me.txtBusquedaPrecio.TabIndex = 38
        '
        'txtBusquedaNombre
        '
        Me.txtBusquedaNombre.Location = New System.Drawing.Point(515, 23)
        Me.txtBusquedaNombre.Name = "txtBusquedaNombre"
        Me.txtBusquedaNombre.Size = New System.Drawing.Size(117, 20)
        Me.txtBusquedaNombre.TabIndex = 37
        '
        'txtBusquedaID
        '
        Me.txtBusquedaID.Location = New System.Drawing.Point(383, 23)
        Me.txtBusquedaID.Name = "txtBusquedaID"
        Me.txtBusquedaID.Size = New System.Drawing.Size(126, 20)
        Me.txtBusquedaID.TabIndex = 36
        '
        'wfABMProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 468)
        Me.Controls.Add(Me.txtBusquedaCategoria)
        Me.Controls.Add(Me.txtBusquedaPrecio)
        Me.Controls.Add(Me.txtBusquedaNombre)
        Me.Controls.Add(Me.txtBusquedaID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProductos)
        Me.Name = "wfABMProductos"
        Me.Text = "Productos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents txtBusquedaCategoria As TextBox
    Friend WithEvents txtBusquedaPrecio As TextBox
    Friend WithEvents txtBusquedaNombre As TextBox
    Friend WithEvents txtBusquedaID As TextBox
End Class
