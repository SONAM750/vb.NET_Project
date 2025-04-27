<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rockpaper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rockpaper))
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        Picomputer = New PictureBox()
        Label1 = New Label()
        lblStatus = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnexit = New Button()
        CType(Picomputer, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn1
        ' 
        btn1.BackgroundImage = CType(resources.GetObject("btn1.BackgroundImage"), Image)
        btn1.BackgroundImageLayout = ImageLayout.Stretch
        btn1.ForeColor = Color.White
        btn1.Location = New Point(116, 336)
        btn1.Name = "btn1"
        btn1.Size = New Size(220, 173)
        btn1.TabIndex = 0
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.BackgroundImage = CType(resources.GetObject("btn2.BackgroundImage"), Image)
        btn2.BackgroundImageLayout = ImageLayout.Stretch
        btn2.ForeColor = Color.White
        btn2.Location = New Point(370, 336)
        btn2.Name = "btn2"
        btn2.Size = New Size(214, 173)
        btn2.TabIndex = 1
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.BackgroundImage = CType(resources.GetObject("btn3.BackgroundImage"), Image)
        btn3.BackgroundImageLayout = ImageLayout.Stretch
        btn3.ForeColor = Color.White
        btn3.Location = New Point(606, 336)
        btn3.Name = "btn3"
        btn3.Size = New Size(232, 173)
        btn3.TabIndex = 2
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' Picomputer
        ' 
        Picomputer.BackgroundImageLayout = ImageLayout.Stretch
        Picomputer.Location = New Point(261, 117)
        Picomputer.Name = "Picomputer"
        Picomputer.Size = New Size(233, 181)
        Picomputer.TabIndex = 3
        Picomputer.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.ForestGreen
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Rockwell", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(520, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 185)
        Label1.TabIndex = 4
        Label1.Text = "SCORE BOARD"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.DeepSkyBlue
        lblStatus.Font = New Font("Rockwell", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.White
        lblStatus.Location = New Point(116, 550)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(523, 71)
        lblStatus.TabIndex = 5
        lblStatus.Text = "PRESS ONE OF THE BUTTON ABOVE"
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(116, 512)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 26)
        Label2.TabIndex = 6
        Label2.Text = "Scissors"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaptionText
        Label3.Font = New Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(370, 512)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 26)
        Label3.TabIndex = 7
        Label3.Text = "Stone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaptionText
        Label4.Font = New Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(606, 512)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 26)
        Label4.TabIndex = 8
        Label4.Text = "Paper"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Black
        Label5.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(251, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(263, 35)
        Label5.TabIndex = 9
        Label5.Text = "Computer Choice"
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.Red
        btnexit.Cursor = Cursors.Hand
        btnexit.FlatAppearance.BorderSize = 0
        btnexit.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnexit.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnexit.ForeColor = Color.White
        btnexit.Location = New Point(656, 550)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(182, 71)
        btnexit.TabIndex = 10
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' rockpaper
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1000, 730)
        Controls.Add(btnexit)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblStatus)
        Controls.Add(Label1)
        Controls.Add(Picomputer)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1000, 730)
        MinimumSize = New Size(1000, 730)
        Name = "rockpaper"
        StartPosition = FormStartPosition.CenterScreen
        Text = "rockpaper"
        CType(Picomputer, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents Picomputer As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnexit As Button
End Class
