<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Panel1 = New Panel()
        btngame = New Button()
        Label3 = New Label()
        Label2 = New Label()
        showpass = New CheckBox()
        btnlogin = New Button()
        txtpassword = New TextBox()
        user_combo = New ComboBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btngame)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(showpass)
        Panel1.Controls.Add(btnlogin)
        Panel1.Controls.Add(txtpassword)
        Panel1.Controls.Add(user_combo)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.MaximumSize = New Size(540, 620)
        Panel1.MinimumSize = New Size(540, 620)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(540, 620)
        Panel1.TabIndex = 0
        ' 
        ' btngame
        ' 
        btngame.BackColor = Color.DodgerBlue
        btngame.Cursor = Cursors.Hand
        btngame.FlatAppearance.BorderSize = 0
        btngame.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btngame.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btngame.ForeColor = Color.White
        btngame.Location = New Point(104, 548)
        btngame.Name = "btngame"
        btngame.Size = New Size(169, 54)
        btngame.TabIndex = 10
        btngame.Text = "Game"
        btngame.UseVisualStyleBackColor = False
        btngame.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(104, 445)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 31)
        Label3.TabIndex = 9
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(104, 351)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 31)
        Label2.TabIndex = 8
        Label2.Text = "Player Name"
        ' 
        ' showpass
        ' 
        showpass.AutoSize = True
        showpass.Location = New Point(449, 499)
        showpass.Name = "showpass"
        showpass.Size = New Size(18, 17)
        showpass.TabIndex = 7
        showpass.UseVisualStyleBackColor = True
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.DodgerBlue
        btnlogin.Cursor = Cursors.Hand
        btnlogin.FlatAppearance.BorderSize = 0
        btnlogin.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnlogin.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.ForeColor = Color.White
        btnlogin.Location = New Point(290, 545)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(188, 57)
        btnlogin.TabIndex = 6
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' txtpassword
        ' 
        txtpassword.BackColor = SystemColors.Menu
        txtpassword.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtpassword.Location = New Point(104, 479)
        txtpassword.Multiline = True
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.Size = New Size(374, 48)
        txtpassword.TabIndex = 5
        ' 
        ' user_combo
        ' 
        user_combo.BackColor = SystemColors.Menu
        user_combo.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        user_combo.ForeColor = Color.Black
        user_combo.FormattingEnabled = True
        user_combo.ItemHeight = 37
        user_combo.Location = New Point(104, 385)
        user_combo.Name = "user_combo"
        user_combo.Size = New Size(363, 45)
        user_combo.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(144, 77)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(265, 236)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Rockwell", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(25, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 46)
        Label1.TabIndex = 2
        Label1.Text = "Login Here !"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 626)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "login"
        Text = "login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents user_combo As ComboBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents showpass As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btngame As Button
End Class
