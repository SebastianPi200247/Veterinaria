<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresePersona
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
        Me.tbxRe = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CIPersonaInput = New System.Windows.Forms.TextBox()
        Me.NombrePersonaInput = New System.Windows.Forms.TextBox()
        Me.DireccionPersonaInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxNombrePerson = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbxRe
        '
        Me.tbxRe.AutoSize = True
        Me.tbxRe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.tbxRe.Location = New System.Drawing.Point(188, 331)
        Me.tbxRe.Name = "tbxRe"
        Me.tbxRe.Size = New System.Drawing.Size(84, 20)
        Me.tbxRe.TabIndex = 0
        Me.tbxRe.Text = "Resultado"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button1.Location = New System.Drawing.Point(191, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CIPersonaInput
        '
        Me.CIPersonaInput.Location = New System.Drawing.Point(122, 143)
        Me.CIPersonaInput.Name = "CIPersonaInput"
        Me.CIPersonaInput.Size = New System.Drawing.Size(236, 20)
        Me.CIPersonaInput.TabIndex = 3
        '
        'NombrePersonaInput
        '
        Me.NombrePersonaInput.Location = New System.Drawing.Point(122, 188)
        Me.NombrePersonaInput.Name = "NombrePersonaInput"
        Me.NombrePersonaInput.Size = New System.Drawing.Size(236, 20)
        Me.NombrePersonaInput.TabIndex = 4
        '
        'DireccionPersonaInput
        '
        Me.DireccionPersonaInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DireccionPersonaInput.Location = New System.Drawing.Point(122, 227)
        Me.DireccionPersonaInput.Name = "DireccionPersonaInput"
        Me.DireccionPersonaInput.Size = New System.Drawing.Size(236, 20)
        Me.DireccionPersonaInput.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label2.Location = New System.Drawing.Point(102, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ingrese una persona"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(91, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CI"
        '
        'tbxNombrePerson
        '
        Me.tbxNombrePerson.AutoSize = True
        Me.tbxNombrePerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.tbxNombrePerson.Location = New System.Drawing.Point(48, 186)
        Me.tbxNombrePerson.Name = "tbxNombrePerson"
        Me.tbxNombrePerson.Size = New System.Drawing.Size(68, 20)
        Me.tbxNombrePerson.TabIndex = 8
        Me.tbxNombrePerson.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(35, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Direccion"
        '
        'IngresePersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbxNombrePerson)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DireccionPersonaInput)
        Me.Controls.Add(Me.NombrePersonaInput)
        Me.Controls.Add(Me.CIPersonaInput)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbxRe)
        Me.Name = "IngresePersona"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxRe As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CIPersonaInput As TextBox
    Friend WithEvents NombrePersonaInput As TextBox
    Friend WithEvents DireccionPersonaInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxNombrePerson As Label
    Friend WithEvents Label5 As Label
End Class
