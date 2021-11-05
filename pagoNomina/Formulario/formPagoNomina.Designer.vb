<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPagoNomina
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxHijos = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numNumHijos = New System.Windows.Forms.NumericUpDown()
        Me.numHorasTrabajadas = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numPrecioHora = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInfoSuedoNeto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtInfoPlusTrienios = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtInfoPlusHijos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSueldoBruto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInfoEmpleado = New System.Windows.Forms.TextBox()
        CType(Me.numNumHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHorasTrabajadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrecioHora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIF"
        '
        'txtNif
        '
        Me.txtNif.Location = New System.Drawing.Point(153, 25)
        Me.txtNif.Name = "txtNif"
        Me.txtNif.Size = New System.Drawing.Size(100, 20)
        Me.txtNif.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellidos"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(394, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 22)
        Me.txtNombre.TabIndex = 4
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(394, 52)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(200, 22)
        Me.txtApellidos.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(282, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha Ingreso"
        '
        'cbxHijos
        '
        Me.cbxHijos.AutoSize = True
        Me.cbxHijos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxHijos.Location = New System.Drawing.Point(153, 56)
        Me.cbxHijos.Name = "cbxHijos"
        Me.cbxHijos.Size = New System.Drawing.Size(63, 20)
        Me.cbxHijos.TabIndex = 9
        Me.cbxHijos.Text = "Hijos"
        Me.cbxHijos.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Numero Hijos"
        '
        'numNumHijos
        '
        Me.numNumHijos.Location = New System.Drawing.Point(153, 86)
        Me.numNumHijos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numNumHijos.Name = "numNumHijos"
        Me.numNumHijos.Size = New System.Drawing.Size(36, 20)
        Me.numNumHijos.TabIndex = 11
        Me.numNumHijos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numHorasTrabajadas
        '
        Me.numHorasTrabajadas.Location = New System.Drawing.Point(153, 127)
        Me.numHorasTrabajadas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numHorasTrabajadas.Name = "numHorasTrabajadas"
        Me.numHorasTrabajadas.Size = New System.Drawing.Size(36, 20)
        Me.numHorasTrabajadas.TabIndex = 13
        Me.numHorasTrabajadas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Horas Trabajadas"
        '
        'numPrecioHora
        '
        Me.numPrecioHora.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numPrecioHora.Location = New System.Drawing.Point(394, 121)
        Me.numPrecioHora.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPrecioHora.Name = "numPrecioHora"
        Me.numPrecioHora.Size = New System.Drawing.Size(36, 20)
        Me.numPrecioHora.TabIndex = 15
        Me.numPrecioHora.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(253, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Precio por Hora"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(394, 83)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalir.Location = New System.Drawing.Point(635, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(118, 36)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalcular.Location = New System.Drawing.Point(635, 105)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(118, 36)
        Me.btnCalcular.TabIndex = 18
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox1.Controls.Add(Me.txtInfoSuedoNeto)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtInfoPlusTrienios)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtInfoPlusHijos)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSueldoBruto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtInfoEmpleado)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(738, 201)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NOMINA"
        '
        'txtInfoSuedoNeto
        '
        Me.txtInfoSuedoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoSuedoNeto.Location = New System.Drawing.Point(468, 112)
        Me.txtInfoSuedoNeto.Name = "txtInfoSuedoNeto"
        Me.txtInfoSuedoNeto.ReadOnly = True
        Me.txtInfoSuedoNeto.Size = New System.Drawing.Size(111, 22)
        Me.txtInfoSuedoNeto.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(365, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Sueldo Neto"
        '
        'txtInfoPlusTrienios
        '
        Me.txtInfoPlusTrienios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoPlusTrienios.Location = New System.Drawing.Point(138, 109)
        Me.txtInfoPlusTrienios.Name = "txtInfoPlusTrienios"
        Me.txtInfoPlusTrienios.ReadOnly = True
        Me.txtInfoPlusTrienios.Size = New System.Drawing.Size(111, 22)
        Me.txtInfoPlusTrienios.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Plus Trienios"
        '
        'txtInfoPlusHijos
        '
        Me.txtInfoPlusHijos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoPlusHijos.Location = New System.Drawing.Point(138, 81)
        Me.txtInfoPlusHijos.Name = "txtInfoPlusHijos"
        Me.txtInfoPlusHijos.ReadOnly = True
        Me.txtInfoPlusHijos.Size = New System.Drawing.Size(111, 22)
        Me.txtInfoPlusHijos.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Plus Hijos"
        '
        'txtSueldoBruto
        '
        Me.txtSueldoBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSueldoBruto.Location = New System.Drawing.Point(138, 53)
        Me.txtSueldoBruto.Name = "txtSueldoBruto"
        Me.txtSueldoBruto.ReadOnly = True
        Me.txtSueldoBruto.Size = New System.Drawing.Size(111, 22)
        Me.txtSueldoBruto.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Sueldo Bruto"
        '
        'txtInfoEmpleado
        '
        Me.txtInfoEmpleado.BackColor = System.Drawing.Color.Maroon
        Me.txtInfoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoEmpleado.ForeColor = System.Drawing.Color.White
        Me.txtInfoEmpleado.Location = New System.Drawing.Point(33, 21)
        Me.txtInfoEmpleado.Name = "txtInfoEmpleado"
        Me.txtInfoEmpleado.ReadOnly = True
        Me.txtInfoEmpleado.Size = New System.Drawing.Size(216, 26)
        Me.txtInfoEmpleado.TabIndex = 0
        '
        'formPagoNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(765, 385)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.numPrecioHora)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.numHorasTrabajadas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.numNumHijos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxHijos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNif)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "formPagoNomina"
        Me.Text = "Pago Nomina"
        CType(Me.numNumHijos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHorasTrabajadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrecioHora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNif As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxHijos As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents numNumHijos As NumericUpDown
    Friend WithEvents numHorasTrabajadas As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents numPrecioHora As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtInfoSuedoNeto As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtInfoPlusTrienios As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtInfoPlusHijos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSueldoBruto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtInfoEmpleado As TextBox
End Class
