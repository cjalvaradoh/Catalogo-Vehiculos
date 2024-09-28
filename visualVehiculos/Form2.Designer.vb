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
        Button1 = New Button()
        Label4 = New Label()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonShadow
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(135, 386)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 31)
        Button1.TabIndex = 2
        Button1.Text = "Registrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        Label4.Location = New Point(136, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 25)
        Label4.TabIndex = 15
        Label4.Text = "Registrar"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F)
        Label6.Location = New Point(65, 336)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 17)
        Label6.TabIndex = 37
        Label6.Text = "Color"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(184, 330)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(136, 23)
        TextBox5.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F)
        Label5.Location = New Point(65, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 17)
        Label5.TabIndex = 35
        Label5.Text = "Modelo"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(184, 278)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(136, 23)
        TextBox4.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9F)
        Label3.Location = New Point(65, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 17)
        Label3.TabIndex = 33
        Label3.Text = "Línea"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(184, 221)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(136, 23)
        TextBox3.TabIndex = 32
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F)
        Label2.Location = New Point(65, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 17)
        Label2.TabIndex = 31
        Label2.Text = "Marca"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(184, 161)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(136, 23)
        TextBox2.TabIndex = 30
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F)
        Label1.Location = New Point(65, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 17)
        Label1.TabIndex = 29
        Label1.Text = "No. Placa"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(184, 107)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(136, 23)
        TextBox1.TabIndex = 28
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 461)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
