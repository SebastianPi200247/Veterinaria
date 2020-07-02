<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.tbxCI = New System.Windows.Forms.TextBox()
        Me.tbxNom1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbxRe1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxCI1 = New System.Windows.Forms.Label()
        Me.tbxNom = New System.Windows.Forms.Label()
        Me.tbxAño = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbxCI
        '
        Me.tbxCI.Location = New System.Drawing.Point(156, 241)
        Me.tbxCI.Name = "tbxCI"
        Me.tbxCI.Size = New System.Drawing.Size(100, 20)
        Me.tbxCI.TabIndex = 4
        '
        'tbxNom1
        '
        Me.tbxNom1.Location = New System.Drawing.Point(156, 198)
        Me.tbxNom1.Name = "tbxNom1"
        Me.tbxNom1.Size = New System.Drawing.Size(100, 20)
        Me.tbxNom1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(156, 149)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button1.Location = New System.Drawing.Point(213, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbxRe1
        '
        Me.tbxRe1.AutoSize = True
        Me.tbxRe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.tbxRe1.Location = New System.Drawing.Point(209, 333)
        Me.tbxRe1.Name = "tbxRe1"
        Me.tbxRe1.Size = New System.Drawing.Size(84, 20)
        Me.tbxRe1.TabIndex = 8
        Me.tbxRe1.Text = "Resultado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label2.Location = New System.Drawing.Point(104, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Ingrese una mascota"
        '
        'tbxCI1
        '
        Me.tbxCI1.AutoSize = True
        Me.tbxCI1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.tbxCI1.Location = New System.Drawing.Point(126, 149)
        Me.tbxCI1.Name = "tbxCI1"
        Me.tbxCI1.Size = New System.Drawing.Size(25, 20)
        Me.tbxCI1.TabIndex = 10
        Me.tbxCI1.Text = "CI"
        '
        'tbxNom
        '
        Me.tbxNom.AutoSize = True
        Me.tbxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.tbxNom.Location = New System.Drawing.Point(84, 198)
        Me.tbxNom.Name = "tbxNom"
        Me.tbxNom.Size = New System.Drawing.Size(68, 20)
        Me.tbxNom.TabIndex = 11
        Me.tbxNom.Text = "Nombre"
        '
        'tbxAño
        '
        Me.tbxAño.AutoSize = True
        Me.tbxAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.tbxAño.Location = New System.Drawing.Point(33, 241)
        Me.tbxAño.Name = "tbxAño"
        Me.tbxAño.Size = New System.Drawing.Size(119, 20)
        Me.tbxAño.TabIndex = 12
        Me.tbxAño.Text = "Añonacimiento"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 450)
        Me.Controls.Add(Me.tbxAño)
        Me.Controls.Add(Me.tbxNom)
        Me.Controls.Add(Me.tbxCI1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxRe1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.tbxNom1)
        Me.Controls.Add(Me.tbxCI)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxCI As TextBox
    Friend WithEvents tbxNom1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tbxRe1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxCI1 As Label
    Friend WithEvents tbxNom As Label
    Friend WithEvents tbxAño As Label
End Class
