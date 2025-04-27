<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ponggame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ponggame))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewGameToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        Timer1 = New Timer(components)
        paddle = New Panel()
        ball = New PictureBox()
        labelscore = New Label()
        MenuStrip1.SuspendLayout()
        CType(ball, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Red
        MenuStrip1.Font = New Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(793, 41)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewGameToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(83, 37)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewGameToolStripMenuItem
        ' 
        NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        NewGameToolStripMenuItem.Size = New Size(256, 38)
        NewGameToolStripMenuItem.Text = "New Game"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(256, 38)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 20
        ' 
        ' paddle
        ' 
        paddle.BackColor = Color.Yellow
        paddle.BorderStyle = BorderStyle.FixedSingle
        paddle.Location = New Point(289, 400)
        paddle.MaximumSize = New Size(138, 16)
        paddle.MinimumSize = New Size(138, 16)
        paddle.Name = "paddle"
        paddle.Size = New Size(138, 16)
        paddle.TabIndex = 1
        ' 
        ' ball
        ' 
        ball.BackColor = Color.Black
        ball.BackgroundImage = CType(resources.GetObject("ball.BackgroundImage"), Image)
        ball.BackgroundImageLayout = ImageLayout.Stretch
        ball.Location = New Point(339, 370)
        ball.MaximumSize = New Size(28, 28)
        ball.MinimumSize = New Size(28, 28)
        ball.Name = "ball"
        ball.Size = New Size(28, 28)
        ball.TabIndex = 2
        ball.TabStop = False
        ' 
        ' labelscore
        ' 
        labelscore.AutoSize = True
        labelscore.BackColor = Color.White
        labelscore.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelscore.Location = New Point(319, 41)
        labelscore.Name = "labelscore"
        labelscore.Size = New Size(108, 38)
        labelscore.TabIndex = 3
        labelscore.Text = "Score:"
        ' 
        ' ponggame
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(793, 451)
        Controls.Add(labelscore)
        Controls.Add(ball)
        Controls.Add(paddle)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        MaximumSize = New Size(793, 451)
        MinimumSize = New Size(793, 451)
        Name = "ponggame"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ponggame"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(ball, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents paddle As Panel
    Friend WithEvents ball As PictureBox
    Friend WithEvents labelscore As Label
End Class
