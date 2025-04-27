<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        firstblue = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnexit2 = New Button()
        btnsingup = New Button()
        Label1 = New Label()
        sidepanel = New Panel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        firstblue.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' firstblue
        ' 
        firstblue.BackColor = Color.DodgerBlue
        firstblue.Controls.Add(PictureBox2)
        firstblue.Controls.Add(PictureBox1)
        firstblue.Controls.Add(btnexit2)
        firstblue.Controls.Add(btnsingup)
        firstblue.Controls.Add(Label1)
        firstblue.Controls.Add(sidepanel)
        firstblue.Location = New Point(2, 3)
        firstblue.Name = "firstblue"
        firstblue.Size = New Size(1191, 626)
        firstblue.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(279, 179)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(125, 125)
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(24, 150)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(212, 205)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' btnexit2
        ' 
        btnexit2.BackColor = Color.Red
        btnexit2.Cursor = Cursors.Hand
        btnexit2.FlatAppearance.BorderSize = 0
        btnexit2.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnexit2.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnexit2.ForeColor = Color.White
        btnexit2.Location = New Point(304, 492)
        btnexit2.Name = "btnexit2"
        btnexit2.Size = New Size(178, 58)
        btnexit2.TabIndex = 13
        btnexit2.Text = "Exit"
        btnexit2.UseVisualStyleBackColor = False
        ' 
        ' btnsingup
        ' 
        btnsingup.BackColor = Color.DodgerBlue
        btnsingup.Cursor = Cursors.Hand
        btnsingup.FlatAppearance.BorderSize = 0
        btnsingup.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnsingup.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsingup.ForeColor = Color.White
        btnsingup.Location = New Point(46, 485)
        btnsingup.Name = "btnsingup"
        btnsingup.Size = New Size(209, 72)
        btnsingup.TabIndex = 2
        btnsingup.Text = "Signup"
        btnsingup.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(24, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(458, 38)
        Label1.TabIndex = 1
        Label1.Text = "Welcome To My Application !"
        ' 
        ' sidepanel
        ' 
        sidepanel.BackColor = Color.White
        sidepanel.BorderStyle = BorderStyle.Fixed3D
        sidepanel.Location = New Point(522, 3)
        sidepanel.MaximumSize = New Size(666, 633)
        sidepanel.MinimumSize = New Size(666, 633)
        sidepanel.Name = "sidepanel"
        sidepanel.Size = New Size(666, 633)
        sidepanel.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1190, 634)
        Controls.Add(firstblue)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        firstblue.ResumeLayout(False)
        firstblue.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents firstblue As Panel
    Friend WithEvents btnsingup As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents sidepanel As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnexit2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
