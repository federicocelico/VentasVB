<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfABMClientes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wfABMClientes))
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBusquedaID = New System.Windows.Forms.TextBox()
        Me.txtBusquedaNombre = New System.Windows.Forms.TextBox()
        Me.txtBusquedaTelefono = New System.Windows.Forms.TextBox()
        Me.txtBusquedaCorreo = New System.Windows.Forms.TextBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvClientes.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvClientes.Location = New System.Drawing.Point(343, 45)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(545, 354)
        Me.dgvClientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre y Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Correo"
        '
        'txtNombre
        '
        Me.txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtNombre.Location = New System.Drawing.Point(111, 71)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(214, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(111, 123)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(214, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(111, 174)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(214, 20)
        Me.txtCorreo.TabIndex = 6
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(773, 419)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(115, 28)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(634, 419)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(115, 28)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(486, 419)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(115, 28)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(111, 213)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 186)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(111, 21)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(214, 20)
        Me.txtID.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ID"
        '
        'txtBusquedaID
        '
        Me.txtBusquedaID.Location = New System.Drawing.Point(385, 19)
        Me.txtBusquedaID.Name = "txtBusquedaID"
        Me.txtBusquedaID.Size = New System.Drawing.Size(126, 20)
        Me.txtBusquedaID.TabIndex = 24
        '
        'txtBusquedaNombre
        '
        Me.txtBusquedaNombre.Location = New System.Drawing.Point(517, 19)
        Me.txtBusquedaNombre.Name = "txtBusquedaNombre"
        Me.txtBusquedaNombre.Size = New System.Drawing.Size(117, 20)
        Me.txtBusquedaNombre.TabIndex = 25
        '
        'txtBusquedaTelefono
        '
        Me.txtBusquedaTelefono.Location = New System.Drawing.Point(640, 19)
        Me.txtBusquedaTelefono.Name = "txtBusquedaTelefono"
        Me.txtBusquedaTelefono.Size = New System.Drawing.Size(127, 20)
        Me.txtBusquedaTelefono.TabIndex = 26
        '
        'txtBusquedaCorreo
        '
        Me.txtBusquedaCorreo.Location = New System.Drawing.Point(773, 19)
        Me.txtBusquedaCorreo.Name = "txtBusquedaCorreo"
        Me.txtBusquedaCorreo.Size = New System.Drawing.Size(115, 20)
        Me.txtBusquedaCorreo.TabIndex = 27
        '
        'wfABMClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 468)
        Me.Controls.Add(Me.txtBusquedaCorreo)
        Me.Controls.Add(Me.txtBusquedaTelefono)
        Me.Controls.Add(Me.txtBusquedaNombre)
        Me.Controls.Add(Me.txtBusquedaID)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "wfABMClientes"
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBusquedaID As TextBox
    Friend WithEvents txtBusquedaNombre As TextBox
    Friend WithEvents txtBusquedaTelefono As TextBox
    Friend WithEvents txtBusquedaCorreo As TextBox
End Class
