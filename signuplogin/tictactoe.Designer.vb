<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tictactoe
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
        Panel1 = New Panel()
        btn9 = New Button()
        btn6 = New Button()
        btn3 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btn2 = New Button()
        btn1 = New Button()
        Panel2 = New Panel()
        restart = New Button()
        player = New Button()
        pcstart = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnexit1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel1.Controls.Add(btn9)
        Panel1.Controls.Add(btn6)
        Panel1.Controls.Add(btn3)
        Panel1.Controls.Add(btn8)
        Panel1.Controls.Add(btn7)
        Panel1.Controls.Add(btn5)
        Panel1.Controls.Add(btn4)
        Panel1.Controls.Add(btn2)
        Panel1.Controls.Add(btn1)
        Panel1.Location = New Point(48, 85)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(462, 371)
        Panel1.TabIndex = 0
        ' 
        ' btn9
        ' 
        btn9.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn9.Location = New Point(316, 255)
        btn9.Name = "btn9"
        btn9.Size = New Size(113, 94)
        btn9.TabIndex = 2
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn6.Location = New Point(316, 140)
        btn6.Name = "btn6"
        btn6.Size = New Size(113, 94)
        btn6.TabIndex = 2
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn3.Location = New Point(316, 19)
        btn3.Name = "btn3"
        btn3.Size = New Size(113, 94)
        btn3.TabIndex = 2
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn8.Location = New Point(170, 255)
        btn8.Name = "btn8"
        btn8.Size = New Size(113, 94)
        btn8.TabIndex = 1
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn7.Location = New Point(20, 255)
        btn7.Name = "btn7"
        btn7.Size = New Size(113, 94)
        btn7.TabIndex = 0
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn5.Location = New Point(170, 140)
        btn5.Name = "btn5"
        btn5.Size = New Size(113, 94)
        btn5.TabIndex = 1
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn4.Location = New Point(20, 140)
        btn4.Name = "btn4"
        btn4.Size = New Size(113, 94)
        btn4.TabIndex = 0
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn2.Location = New Point(170, 19)
        btn2.Name = "btn2"
        btn2.Size = New Size(113, 94)
        btn2.TabIndex = 1
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn1.Location = New Point(20, 19)
        btn1.Name = "btn1"
        btn1.Size = New Size(113, 94)
        btn1.TabIndex = 0
        btn1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(restart)
        Panel2.Controls.Add(player)
        Panel2.Controls.Add(pcstart)
        Panel2.Location = New Point(543, 104)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(235, 253)
        Panel2.TabIndex = 1
        ' 
        ' restart
        ' 
        restart.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        restart.Font = New Font("Rockwell", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        restart.ForeColor = Color.White
        restart.Location = New Point(22, 178)
        restart.Name = "restart"
        restart.Size = New Size(201, 59)
        restart.TabIndex = 0
        restart.Text = "Restart"
        restart.UseVisualStyleBackColor = False
        ' 
        ' player
        ' 
        player.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        player.Font = New Font("Rockwell", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        player.ForeColor = Color.White
        player.Location = New Point(22, 98)
        player.Name = "player"
        player.Size = New Size(201, 59)
        player.TabIndex = 0
        player.Text = "2Player"
        player.UseVisualStyleBackColor = False
        ' 
        ' pcstart
        ' 
        pcstart.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        pcstart.Font = New Font("Rockwell", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pcstart.ForeColor = Color.White
        pcstart.Location = New Point(22, 23)
        pcstart.Name = "pcstart"
        pcstart.Size = New Size(201, 59)
        pcstart.TabIndex = 0
        pcstart.Text = "Computer"
        pcstart.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Font = New Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(209, 509)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 50)
        Label1.TabIndex = 2
        Label1.Text = "Msg"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label2.Font = New Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(209, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 50)
        Label2.TabIndex = 3
        Label2.Text = "Msg"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnexit1
        ' 
        btnexit1.BackColor = Color.Red
        btnexit1.Cursor = Cursors.Hand
        btnexit1.FlatAppearance.BorderSize = 0
        btnexit1.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnexit1.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnexit1.ForeColor = Color.White
        btnexit1.Location = New Point(579, 376)
        btnexit1.Name = "btnexit1"
        btnexit1.Size = New Size(178, 58)
        btnexit1.TabIndex = 11
        btnexit1.Text = "Exit"
        btnexit1.UseVisualStyleBackColor = False
        ' 
        ' tictactoe
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(814, 595)
        Controls.Add(btnexit1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "tictactoe"
        Text = "tictactoe"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn9 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents restart As Button
    Friend WithEvents player As Button
    Friend WithEvents pcstart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnexit1 As Button
End Class
