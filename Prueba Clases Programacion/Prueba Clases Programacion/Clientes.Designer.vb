<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.TxbMaterno = New System.Windows.Forms.TextBox()
        Me.TxbSocial = New System.Windows.Forms.TextBox()
        Me.TxbPaterno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxbResultado = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbSexo
        '
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Items.AddRange(New Object() {"Masculino", "Femenino", "Otro"})
        Me.CmbSexo.Location = New System.Drawing.Point(12, 173)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(121, 21)
        Me.CmbSexo.TabIndex = 21
        '
        'TxbMaterno
        '
        Me.TxbMaterno.Location = New System.Drawing.Point(12, 78)
        Me.TxbMaterno.Name = "TxbMaterno"
        Me.TxbMaterno.Size = New System.Drawing.Size(100, 20)
        Me.TxbMaterno.TabIndex = 20
        '
        'TxbSocial
        '
        Me.TxbSocial.Location = New System.Drawing.Point(12, 124)
        Me.TxbSocial.Name = "TxbSocial"
        Me.TxbSocial.Size = New System.Drawing.Size(100, 20)
        Me.TxbSocial.TabIndex = 19
        '
        'TxbPaterno
        '
        Me.TxbPaterno.Location = New System.Drawing.Point(12, 30)
        Me.TxbPaterno.Name = "TxbPaterno"
        Me.TxbPaterno.Size = New System.Drawing.Size(100, 20)
        Me.TxbPaterno.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Apellido Paterno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Seguro Social"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Apellido Materno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Categoria"
        '
        'CmbCategoria
        '
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Items.AddRange(New Object() {"Electrodomestricos", "Inmobiliaria", "Computo"})
        Me.CmbCategoria.Location = New System.Drawing.Point(12, 228)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.CmbCategoria.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(490, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxbResultado
        '
        Me.TxbResultado.Location = New System.Drawing.Point(10, 281)
        Me.TxbResultado.Name = "TxbResultado"
        Me.TxbResultado.Size = New System.Drawing.Size(565, 20)
        Me.TxbResultado.TabIndex = 27
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 322)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 357)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxbResultado)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbSexo)
        Me.Controls.Add(Me.TxbMaterno)
        Me.Controls.Add(Me.TxbSocial)
        Me.Controls.Add(Me.TxbPaterno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents TxbMaterno As TextBox
    Friend WithEvents TxbSocial As TextBox
    Friend WithEvents TxbPaterno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbCategoria As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxbResultado As TextBox
    Friend WithEvents Button2 As Button
End Class
