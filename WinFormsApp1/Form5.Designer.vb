<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ProgressBar1 = New ProgressBar()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(64, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(139, 122)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label1.Location = New Point(70, 189)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 20)
        Label1.TabIndex = 1
        Label1.Text = "Food is on the way"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(64, 154)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(139, 23)
        ProgressBar1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label2.Location = New Point(98, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 21)
        Label2.TabIndex = 3
        Label2.Text = "Invoice"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label3.Location = New Point(14, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 4
        Label3.Text = "1x Whole Chicken"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label4.Location = New Point(155, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 5
        Label4.Text = "...₱299"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label5.Location = New Point(155, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 15)
        Label5.TabIndex = 7
        Label5.Text = "...₱30"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label6.Location = New Point(14, 47)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 15)
        Label6.TabIndex = 6
        Label6.Text = "Delivery Fee"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label7.Location = New Point(155, 78)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 9
        Label7.Text = "...₱329"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label8.Location = New Point(14, 78)
        Label8.Name = "Label8"
        Label8.Size = New Size(32, 15)
        Label8.TabIndex = 8
        Label8.Text = "Total"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.FromArgb(CByte(188), CByte(199), CByte(196))
        Label9.Location = New Point(70, 411)
        Label9.Name = "Label9"
        Label9.Size = New Size(120, 15)
        Label9.TabIndex = 10
        Label9.Text = "Thanks for your order"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(51))
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(27, 274)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(214, 117)
        Panel1.TabIndex = 11
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(84), CByte(86), CByte(91))
        ClientSize = New Size(262, 450)
        Controls.Add(Panel1)
        Controls.Add(Label9)
        Controls.Add(Label2)
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form5"
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
End Class
