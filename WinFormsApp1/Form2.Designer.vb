<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Panel2 = New Panel()
        Button1 = New Button()
        NumericUpDown1 = New NumericUpDown()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(54, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(157, 128)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label1.Location = New Point(42, 183)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 21)
        Label1.TabIndex = 1
        Label1.Text = "Whole Chicken"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label2.Location = New Point(173, 188)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 2
        Label2.Text = "₱ 299"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Location = New Point(27, 236)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(212, 104)
        Panel1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label3.Location = New Point(27, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 15)
        Label3.TabIndex = 4
        Label3.Text = "Choice of Flavor"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        RadioButton2.Location = New Point(30, 72)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(53, 19)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Spicy"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        RadioButton1.Location = New Point(30, 47)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(67, 19)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Original"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(99), CByte(101), CByte(106))
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(NumericUpDown1)
        Panel2.Location = New Point(12, 392)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 48)
        Panel2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(146, 13)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 23)
        Button1.TabIndex = 1
        Button1.Text = "Add to Cart"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(15, 13)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 0
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(86), CByte(91))
        ClientSize = New Size(272, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
