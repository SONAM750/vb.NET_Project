<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carrace
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(carrace))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        race2 = New PictureBox()
        race1 = New PictureBox()
        race3 = New PictureBox()
        car = New PictureBox()
        roadmover = New Timer(components)
        RightSide = New Timer(components)
        LeftSide = New Timer(components)
        RaceMover1 = New Timer(components)
        RaceMover2 = New Timer(components)
        RaceMover3 = New Timer(components)
        Label3 = New Label()
        replay = New Button()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox11 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox12 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(race2, ComponentModel.ISupportInitialize).BeginInit()
        CType(race1, ComponentModel.ISupportInitialize).BeginInit()
        CType(race3, ComponentModel.ISupportInitialize).BeginInit()
        CType(car, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.Location = New Point(82, -82)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(14, 157)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ButtonHighlight
        PictureBox2.Location = New Point(197, -82)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(14, 157)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Agency FB", 15F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(-3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 31)
        Label1.TabIndex = 1
        Label1.Text = "SPEED 0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Agency FB", 15F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(233, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 31)
        Label2.TabIndex = 1
        Label2.Text = "SCORE 0"
        ' 
        ' race2
        ' 
        race2.BackgroundImage = CType(resources.GetObject("race2.BackgroundImage"), Image)
        race2.BackgroundImageLayout = ImageLayout.Zoom
        race2.Location = New Point(12, 98)
        race2.Name = "race2"
        race2.Size = New Size(36, 68)
        race2.TabIndex = 2
        race2.TabStop = False
        ' 
        ' race1
        ' 
        race1.BackgroundImage = CType(resources.GetObject("race1.BackgroundImage"), Image)
        race1.BackgroundImageLayout = ImageLayout.Zoom
        race1.Location = New Point(114, 36)
        race1.Name = "race1"
        race1.Size = New Size(52, 67)
        race1.TabIndex = 2
        race1.TabStop = False
        ' 
        ' race3
        ' 
        race3.BackgroundImage = CType(resources.GetObject("race3.BackgroundImage"), Image)
        race3.BackgroundImageLayout = ImageLayout.Zoom
        race3.Location = New Point(233, 113)
        race3.Name = "race3"
        race3.Size = New Size(54, 70)
        race3.TabIndex = 2
        race3.TabStop = False
        ' 
        ' car
        ' 
        car.BackgroundImage = CType(resources.GetObject("car.BackgroundImage"), Image)
        car.BackgroundImageLayout = ImageLayout.Zoom
        car.Location = New Point(124, 401)
        car.Name = "car"
        car.Size = New Size(42, 69)
        car.TabIndex = 2
        car.TabStop = False
        ' 
        ' roadmover
        ' 
        roadmover.Enabled = True
        ' 
        ' RightSide
        ' 
        RightSide.Interval = 10
        ' 
        ' LeftSide
        ' 
        LeftSide.Interval = 10
        ' 
        ' RaceMover1
        ' 
        RaceMover1.Enabled = True
        RaceMover1.Interval = 10
        ' 
        ' RaceMover2
        ' 
        RaceMover2.Enabled = True
        RaceMover2.Interval = 10
        ' 
        ' RaceMover3
        ' 
        RaceMover3.Enabled = True
        RaceMover3.Interval = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonHighlight
        Label3.Font = New Font("Agency FB", 34F, FontStyle.Bold)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(37, 239)
        Label3.Name = "Label3"
        Label3.Size = New Size(257, 68)
        Label3.TabIndex = 3
        Label3.Text = "GAME OVER"
        Label3.Visible = False
        ' 
        ' replay
        ' 
        replay.BackColor = Color.MistyRose
        replay.Font = New Font("Agency FB", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        replay.Location = New Point(82, 323)
        replay.Name = "replay"
        replay.Size = New Size(152, 52)
        replay.TabIndex = 4
        replay.Text = "REPLAY"
        replay.UseVisualStyleBackColor = False
        replay.Visible = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ButtonHighlight
        PictureBox3.Location = New Point(82, 98)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(14, 157)
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.ButtonHighlight
        PictureBox4.Location = New Point(197, 271)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(14, 157)
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = SystemColors.ButtonHighlight
        PictureBox7.Location = New Point(82, 271)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(14, 157)
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = SystemColors.ButtonHighlight
        PictureBox11.Location = New Point(197, 98)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(14, 157)
        PictureBox11.TabIndex = 0
        PictureBox11.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.ButtonHighlight
        PictureBox5.Location = New Point(82, 447)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(14, 157)
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackColor = SystemColors.ButtonHighlight
        PictureBox12.Location = New Point(197, 447)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(14, 157)
        PictureBox12.TabIndex = 0
        PictureBox12.TabStop = False
        ' 
        ' carrace
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(332, 503)
        Controls.Add(replay)
        Controls.Add(Label3)
        Controls.Add(car)
        Controls.Add(race3)
        Controls.Add(race1)
        Controls.Add(race2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox11)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox12)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        MaximumSize = New Size(350, 550)
        MinimumSize = New Size(350, 550)
        Name = "carrace"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "carrace"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(race2, ComponentModel.ISupportInitialize).EndInit()
        CType(race1, ComponentModel.ISupportInitialize).EndInit()
        CType(race3, ComponentModel.ISupportInitialize).EndInit()
        CType(car, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents race2 As PictureBox
    Friend WithEvents race1 As PictureBox
    Friend WithEvents race3 As PictureBox
    Friend WithEvents car As PictureBox
    Friend WithEvents roadmover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents RaceMover1 As Timer
    Friend WithEvents RaceMover2 As Timer
    Friend WithEvents RaceMover3 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents replay As Button
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox


End Class
