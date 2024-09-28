<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        ListBox1 = New ListBox()
        Button2 = New Button()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 9F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(374, 88)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 33)
        Button1.TabIndex = 0
        Button1.Text = "Actualizar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.ForeColor = Color.White
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 21
        ListBox1.Location = New Point(37, 129)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(420, 294)
        ListBox1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 9F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(374, 31)
        Button2.Name = "Button2"
        Button2.Size = New Size(83, 51)
        Button2.TabIndex = 2
        Button2.Text = "Agregar Productos"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(5), CByte(29), CByte(101))
        Label4.Location = New Point(195, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 25)
        Label4.TabIndex = 16
        Label4.Text = "VEHICULOS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(37, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(137, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(484, 461)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(ListBox1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Inicio"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
