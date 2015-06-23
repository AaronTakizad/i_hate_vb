<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.start_btn = New System.Windows.Forms.Button()
        Me.easy_level = New System.Windows.Forms.RadioButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.medium_level = New System.Windows.Forms.RadioButton()
        Me.hard_level = New System.Windows.Forms.RadioButton()
        Me.multiplication_type = New System.Windows.Forms.RadioButton()
        Me.addition_type = New System.Windows.Forms.RadioButton()
        Me.help_btn = New System.Windows.Forms.Button()
        Me.player_name_tb = New System.Windows.Forms.TextBox()
        Me.possible_errors = New System.Windows.Forms.Label()
        Me.num_of_q = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.level_group = New System.Windows.Forms.Panel()
        Me.game_type_group = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.level_group.SuspendLayout()
        Me.game_type_group.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Maths  on  Mars"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Difficulty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Game Type:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Full Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'start_btn
        '
        Me.start_btn.BackColor = System.Drawing.Color.Transparent
        Me.start_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.start_btn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.start_btn.FlatAppearance.BorderSize = 4
        Me.start_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.start_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.start_btn.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_btn.ForeColor = System.Drawing.Color.DimGray
        Me.start_btn.Location = New System.Drawing.Point(391, 443)
        Me.start_btn.Name = "start_btn"
        Me.start_btn.Size = New System.Drawing.Size(101, 45)
        Me.start_btn.TabIndex = 4
        Me.start_btn.Text = "Let's Go!"
        Me.start_btn.UseVisualStyleBackColor = False
        '
        'easy_level
        '
        Me.easy_level.AutoSize = True
        Me.easy_level.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.easy_level.Location = New System.Drawing.Point(6, 4)
        Me.easy_level.Name = "easy_level"
        Me.easy_level.Size = New System.Drawing.Size(63, 23)
        Me.easy_level.TabIndex = 1
        Me.easy_level.TabStop = True
        Me.easy_level.Text = "Easy"
        Me.easy_level.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ProgressBar1.Location = New System.Drawing.Point(47, 454)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(322, 23)
        Me.ProgressBar1.TabIndex = 8
        '
        'medium_level
        '
        Me.medium_level.AutoSize = True
        Me.medium_level.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medium_level.ForeColor = System.Drawing.Color.White
        Me.medium_level.Location = New System.Drawing.Point(110, 4)
        Me.medium_level.Name = "medium_level"
        Me.medium_level.Size = New System.Drawing.Size(81, 23)
        Me.medium_level.TabIndex = 3
        Me.medium_level.TabStop = True
        Me.medium_level.Text = "Medium"
        Me.medium_level.UseVisualStyleBackColor = True
        '
        'hard_level
        '
        Me.hard_level.AutoSize = True
        Me.hard_level.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hard_level.ForeColor = System.Drawing.Color.White
        Me.hard_level.Location = New System.Drawing.Point(226, 4)
        Me.hard_level.Name = "hard_level"
        Me.hard_level.Size = New System.Drawing.Size(63, 23)
        Me.hard_level.TabIndex = 4
        Me.hard_level.TabStop = True
        Me.hard_level.Text = "Hard"
        Me.hard_level.UseVisualStyleBackColor = True
        '
        'multiplication_type
        '
        Me.multiplication_type.AutoSize = True
        Me.multiplication_type.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplication_type.ForeColor = System.Drawing.Color.White
        Me.multiplication_type.Location = New System.Drawing.Point(111, 9)
        Me.multiplication_type.Name = "multiplication_type"
        Me.multiplication_type.Size = New System.Drawing.Size(153, 23)
        Me.multiplication_type.TabIndex = 6
        Me.multiplication_type.TabStop = True
        Me.multiplication_type.Text = "Multiplication"
        Me.multiplication_type.UseVisualStyleBackColor = True
        '
        'addition_type
        '
        Me.addition_type.AutoSize = True
        Me.addition_type.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addition_type.ForeColor = System.Drawing.Color.White
        Me.addition_type.Location = New System.Drawing.Point(6, 9)
        Me.addition_type.Name = "addition_type"
        Me.addition_type.Size = New System.Drawing.Size(99, 23)
        Me.addition_type.TabIndex = 2
        Me.addition_type.TabStop = True
        Me.addition_type.Text = "Addition"
        Me.addition_type.UseVisualStyleBackColor = True
        '
        'help_btn
        '
        Me.help_btn.BackColor = System.Drawing.Color.MidnightBlue
        Me.help_btn.Cursor = System.Windows.Forms.Cursors.Help
        Me.help_btn.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell
        Me.help_btn.FlatAppearance.BorderSize = 2
        Me.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.help_btn.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.help_btn.ForeColor = System.Drawing.Color.White
        Me.help_btn.Location = New System.Drawing.Point(439, 11)
        Me.help_btn.Name = "help_btn"
        Me.help_btn.Size = New System.Drawing.Size(83, 30)
        Me.help_btn.TabIndex = 5
        Me.help_btn.Text = "Help"
        Me.help_btn.UseVisualStyleBackColor = False
        '
        'player_name_tb
        '
        Me.player_name_tb.BackColor = System.Drawing.Color.LightGray
        Me.player_name_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.player_name_tb.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.player_name_tb.Location = New System.Drawing.Point(214, 134)
        Me.player_name_tb.Name = "player_name_tb"
        Me.player_name_tb.Size = New System.Drawing.Size(191, 24)
        Me.player_name_tb.TabIndex = 0
        '
        'possible_errors
        '
        Me.possible_errors.AutoSize = True
        Me.possible_errors.BackColor = System.Drawing.Color.Transparent
        Me.possible_errors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.possible_errors.ForeColor = System.Drawing.Color.Crimson
        Me.possible_errors.Location = New System.Drawing.Point(53, 101)
        Me.possible_errors.Name = "possible_errors"
        Me.possible_errors.Size = New System.Drawing.Size(0, 20)
        Me.possible_errors.TabIndex = 19
        Me.possible_errors.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'num_of_q
        '
        Me.num_of_q.BackColor = System.Drawing.Color.LightGray
        Me.num_of_q.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_of_q.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_of_q.Location = New System.Drawing.Point(219, 385)
        Me.num_of_q.Name = "num_of_q"
        Me.num_of_q.Size = New System.Drawing.Size(100, 24)
        Me.num_of_q.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 46)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Number of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Questions:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'level_group
        '
        Me.level_group.BackColor = System.Drawing.Color.Transparent
        Me.level_group.Controls.Add(Me.easy_level)
        Me.level_group.Controls.Add(Me.medium_level)
        Me.level_group.Controls.Add(Me.hard_level)
        Me.level_group.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.level_group.ForeColor = System.Drawing.Color.White
        Me.level_group.Location = New System.Drawing.Point(214, 201)
        Me.level_group.Name = "level_group"
        Me.level_group.Size = New System.Drawing.Size(292, 45)
        Me.level_group.TabIndex = 22
        Me.level_group.TabStop = True
        '
        'game_type_group
        '
        Me.game_type_group.BackColor = System.Drawing.Color.Transparent
        Me.game_type_group.Controls.Add(Me.multiplication_type)
        Me.game_type_group.Controls.Add(Me.addition_type)
        Me.game_type_group.Location = New System.Drawing.Point(214, 288)
        Me.game_type_group.Name = "game_type_group"
        Me.game_type_group.Size = New System.Drawing.Size(292, 50)
        Me.game_type_group.TabIndex = 23
        Me.game_type_group.TabStop = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-10, -11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 560)
        Me.Panel1.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 367)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Maths on Mars"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.math_game_.My.Resources.Resources.planet
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(316, 163)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(169, 160)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.math_game_.My.Resources.Resources.battleship
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(11, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 148)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(536, 514)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.game_type_group)
        Me.Controls.Add(Me.level_group)
        Me.Controls.Add(Me.num_of_q)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.possible_errors)
        Me.Controls.Add(Me.player_name_tb)
        Me.Controls.Add(Me.help_btn)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.start_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths on Mars: Start Screen"
        Me.level_group.ResumeLayout(False)
        Me.level_group.PerformLayout()
        Me.game_type_group.ResumeLayout(False)
        Me.game_type_group.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents start_btn As System.Windows.Forms.Button
    Friend WithEvents easy_level As System.Windows.Forms.RadioButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents medium_level As System.Windows.Forms.RadioButton
    Friend WithEvents hard_level As System.Windows.Forms.RadioButton
    Friend WithEvents multiplication_type As System.Windows.Forms.RadioButton
    Friend WithEvents addition_type As System.Windows.Forms.RadioButton
    Friend WithEvents help_btn As System.Windows.Forms.Button
    Friend WithEvents player_name_tb As System.Windows.Forms.TextBox
    Friend WithEvents possible_errors As System.Windows.Forms.Label
    Friend WithEvents num_of_q As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents level_group As System.Windows.Forms.Panel
    Friend WithEvents game_type_group As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
End Class
