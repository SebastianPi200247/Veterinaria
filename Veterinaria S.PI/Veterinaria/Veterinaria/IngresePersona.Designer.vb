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
        Me.tbxCI = New System.Windows.Forms.TextBox()
        Me.tbxNom = New System.Windows.Forms.TextBox()
        Me.tbxDire = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxNom1 = New System.Windows.Forms.Label()
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
        'tbxCI
        '
        Me.tbxCI.Location = New System.Drawing.Point(122, 143)
        Me.tbxCI.Name = "tbxCI"
        Me.tbxCI.Size = New System.Drawing.Size(236, 20)
        Me.tbxCI.TabIndex = 3
        '
        'tbxNom
        '
        Me.tbxNom.Location = New System.Drawing.Point(122, 188)
        Me.tbxNom.Name = "tbxNom"
        Me.tbxNom.Size = New System.Drawing.Size(236, 20)
        Me.tbxNom.TabIndex = 4
        '
        'tbxDire
        '
        Me.tbxDire.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbxDire.Location = New System.Drawing.Point(122, 225)
        Me.tbxDire.Name = "tbxDire"
        Me.tbxDire.Size = New System.Drawing.Size(236, 20)
        Me.tbxDire.TabIndex = 5
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
        'tbxNom1
        '
        Me.tbxNom1.AutoSize = True
        Me.tbxNom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.tbxNom1.Location = New System.Drawing.Point(48, 186)
        Me.tbxNom1.Name = "tbxNom1"
        Me.tbxNom1.Size = New System.Drawing.Size(68, 20)
        Me.tbxNom1.TabIndex = 8
        Me.tbxNom1.Text = "Nombre"
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
        Me.Controls.Add(Me.tbxNom1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxDire)
        Me.Controls.Add(Me.tbxNom)
        Me.Controls.Add(Me.tbxCI)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbxRe)
        Me.Name = "IngresePersona"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxRe As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tbxCI As TextBox
    Friend WithEvents tbxNom As TextBox
    Friend WithEvents tbxDire As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxNom1 As Label
    Friend WithEvents Label5 As Label
End Class
