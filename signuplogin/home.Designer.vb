<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Panel1 = New Panel()
        leaderboard = New DataGridView()
        btnleaderboard = New Button()
        btnexit1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        PictureBox4 = New PictureBox()
        Label4 = New Label()
        start_rock = New Button()
        Label3 = New Label()
        car_start = New Button()
        Button1 = New Button()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(leaderboard, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DeepSkyBlue
        Panel1.Controls.Add(leaderboard)
        Panel1.Controls.Add(btnleaderboard)
        Panel1.Controls.Add(btnexit1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(start_rock)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(car_start)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(12, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1326, 766)
        Panel1.TabIndex = 0
        ' 
        ' leaderboard
        ' 
        leaderboard.AllowUserToAddRows = False
        leaderboard.AllowUserToDeleteRows = False
        leaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        leaderboard.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.SteelBlue
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        leaderboard.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        leaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.CornflowerBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        leaderboard.DefaultCellStyle = DataGridViewCellStyle2
        leaderboard.GridColor = Color.Silver
        leaderboard.Location = New Point(72, 467)
        leaderboard.Name = "leaderboard"
        leaderboard.ReadOnly = True
        leaderboard.RowHeadersVisible = False
        leaderboard.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = Color.DeepSkyBlue
        leaderboard.RowsDefaultCellStyle = DataGridViewCellStyle3
        leaderboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        leaderboard.Size = New Size(412, 190)
        leaderboard.TabIndex = 13
        ' 
        ' btnleaderboard
        ' 
        btnleaderboard.BackColor = Color.Navy
        btnleaderboard.Cursor = Cursors.Hand
        btnleaderboard.FlatAppearance.BorderSize = 0
        btnleaderboard.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnleaderboard.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnleaderboard.ForeColor = Color.White
        btnleaderboard.Location = New Point(115, 663)
        btnleaderboard.Name = "btnleaderboard"
        btnleaderboard.Size = New Size(342, 58)
        btnleaderboard.TabIndex = 12
        btnleaderboard.Text = "LeaderBoard"
        btnleaderboard.UseVisualStyleBackColor = False
        ' 
        ' btnexit1
        ' 
        btnexit1.BackColor = Color.Red
        btnexit1.Cursor = Cursors.Hand
        btnexit1.FlatAppearance.BorderSize = 0
        btnexit1.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnexit1.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnexit1.ForeColor = Color.White
        btnexit1.Location = New Point(1075, 705)
        btnexit1.Name = "btnexit1"
        btnexit1.Size = New Size(248, 58)
        btnexit1.TabIndex = 12
        btnexit1.Text = "Exit"
        btnexit1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.IndianRed
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(1052, 367)
        Button2.Name = "Button2"
        Button2.Size = New Size(182, 41)
        Button2.TabIndex = 11
        Button2.Text = "Start"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DeepSkyBlue
        Label5.Location = New Point(1052, 322)
        Label5.Name = "Label5"
        Label5.Size = New Size(184, 33)
        Label5.TabIndex = 10
        Label5.Text = " Pong Game"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(1052, 155)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(174, 164)
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DeepSkyBlue
        Label4.Location = New Point(634, 322)
        Label4.Name = "Label4"
        Label4.Size = New Size(299, 33)
        Label4.TabIndex = 8
        Label4.Text = "Rock-Paper-Scissors"
        ' 
        ' start_rock
        ' 
        start_rock.BackColor = Color.Magenta
        start_rock.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        start_rock.ForeColor = Color.White
        start_rock.Location = New Point(708, 367)
        start_rock.Name = "start_rock"
        start_rock.Size = New Size(182, 41)
        start_rock.TabIndex = 7
        start_rock.Text = "Start"
        start_rock.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DeepSkyBlue
        Label3.Location = New Point(389, 322)
        Label3.Name = "Label3"
        Label3.Size = New Size(174, 33)
        Label3.TabIndex = 6
        Label3.Text = "Car-Racing"
        ' 
        ' car_start
        ' 
        car_start.BackColor = Color.LimeGreen
        car_start.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        car_start.ForeColor = Color.White
        car_start.Location = New Point(381, 367)
        car_start.Name = "car_start"
        car_start.Size = New Size(182, 41)
        car_start.TabIndex = 5
        car_start.Text = "Start"
        car_start.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Orange
        Button1.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(91, 367)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 41)
        Button1.TabIndex = 5
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DeepSkyBlue
        Label2.Location = New Point(91, 322)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 33)
        Label2.TabIndex = 4
        Label2.Text = "Tic-Tac-Toe"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(687, 155)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(203, 164)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(389, 155)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(174, 164)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(101, 155)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 164)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(219, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(646, 54)
        Label1.TabIndex = 0
        Label1.Text = "Choose Your Game And Play"
        ' 
        ' Homepage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1371, 778)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Homepage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Homepage"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(leaderboard, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents car_start As Button
    Friend WithEvents start_rock As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnexit1 As Button
    Friend WithEvents btnleaderboard As Button
    Friend WithEvents leaderboard As DataGridView
End Class
