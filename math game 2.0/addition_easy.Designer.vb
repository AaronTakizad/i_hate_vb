﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addition_easy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addition_easy))
        Me.answer_box = New System.Windows.Forms.TextBox()
        Me.submit_btn = New System.Windows.Forms.Button()
        Me.answer = New System.Windows.Forms.Label()
        Me.plus = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.Label()
        Me.num1 = New System.Windows.Forms.Label()
        Me.welcome = New System.Windows.Forms.Label()
        Me.Process1 = New System.Diagnostics.Process()
        Me.game_over = New System.Windows.Forms.Label()
        Me.lbl_answered = New System.Windows.Forms.Label()
        Me.lbl_remaining = New System.Windows.Forms.Label()
        Me.lbl_incorrect = New System.Windows.Forms.Label()
        Me.lbl_correct = New System.Windows.Forms.Label()
        Me.highScores = New System.Windows.Forms.ListBox()
        Me.header_highscore = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.planet_img = New System.Windows.Forms.PictureBox()
        Me.spacecraft_img = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.header_game_summary = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.planet_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spacecraft_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'answer_box
        '
        Me.answer_box.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer_box.Location = New System.Drawing.Point(339, 228)
        Me.answer_box.MaxLength = 5
        Me.answer_box.Name = "answer_box"
        Me.answer_box.Size = New System.Drawing.Size(100, 26)
        Me.answer_box.TabIndex = 21
        '
        'submit_btn
        '
        Me.submit_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submit_btn.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_btn.Location = New System.Drawing.Point(458, 228)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.Size = New System.Drawing.Size(82, 26)
        Me.submit_btn.TabIndex = 20
        Me.submit_btn.Text = "Submit"
        Me.submit_btn.UseVisualStyleBackColor = False
        '
        'answer
        '
        Me.answer.AutoSize = True
        Me.answer.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answer.Location = New System.Drawing.Point(192, 144)
        Me.answer.Name = "answer"
        Me.answer.Size = New System.Drawing.Size(0, 27)
        Me.answer.TabIndex = 19
        '
        'plus
        '
        Me.plus.AutoSize = True
        Me.plus.BackColor = System.Drawing.Color.Transparent
        Me.plus.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plus.Location = New System.Drawing.Point(235, 229)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(21, 22)
        Me.plus.TabIndex = 18
        Me.plus.Text = "+"
        Me.plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'num2
        '
        Me.num2.AutoSize = True
        Me.num2.BackColor = System.Drawing.Color.Transparent
        Me.num2.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2.Location = New System.Drawing.Point(265, 229)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(54, 22)
        Me.num2.TabIndex = 17
        Me.num2.Text = "num2"
        Me.num2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.BackColor = System.Drawing.Color.Transparent
        Me.num1.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.Location = New System.Drawing.Point(199, 229)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(54, 22)
        Me.num1.TabIndex = 16
        Me.num1.Text = "num1"
        Me.num1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.BackColor = System.Drawing.Color.Transparent
        Me.welcome.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcome.ForeColor = System.Drawing.Color.Tomato
        Me.welcome.Location = New System.Drawing.Point(10, 9)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(142, 22)
        Me.welcome.TabIndex = 15
        Me.welcome.Text = "Welcome Text"
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'game_over
        '
        Me.game_over.AutoSize = True
        Me.game_over.BackColor = System.Drawing.Color.Transparent
        Me.game_over.ForeColor = System.Drawing.Color.Green
        Me.game_over.Location = New System.Drawing.Point(112, 121)
        Me.game_over.Name = "game_over"
        Me.game_over.Size = New System.Drawing.Size(64, 13)
        Me.game_over.TabIndex = 28
        Me.game_over.Text = "Game Over!"
        '
        'lbl_answered
        '
        Me.lbl_answered.AutoSize = True
        Me.lbl_answered.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_answered.Location = New System.Drawing.Point(18, 149)
        Me.lbl_answered.Name = "lbl_answered"
        Me.lbl_answered.Size = New System.Drawing.Size(128, 16)
        Me.lbl_answered.TabIndex = 25
        Me.lbl_answered.Text = "Total Answered:"
        '
        'lbl_remaining
        '
        Me.lbl_remaining.AutoSize = True
        Me.lbl_remaining.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_remaining.Location = New System.Drawing.Point(18, 185)
        Me.lbl_remaining.Name = "lbl_remaining"
        Me.lbl_remaining.Size = New System.Drawing.Size(88, 16)
        Me.lbl_remaining.TabIndex = 24
        Me.lbl_remaining.Text = "Remaining:"
        '
        'lbl_incorrect
        '
        Me.lbl_incorrect.AutoSize = True
        Me.lbl_incorrect.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_incorrect.Location = New System.Drawing.Point(18, 119)
        Me.lbl_incorrect.Name = "lbl_incorrect"
        Me.lbl_incorrect.Size = New System.Drawing.Size(88, 16)
        Me.lbl_incorrect.TabIndex = 23
        Me.lbl_incorrect.Text = "Incorrect:"
        '
        'lbl_correct
        '
        Me.lbl_correct.AutoSize = True
        Me.lbl_correct.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_correct.Location = New System.Drawing.Point(18, 82)
        Me.lbl_correct.Name = "lbl_correct"
        Me.lbl_correct.Size = New System.Drawing.Size(72, 16)
        Me.lbl_correct.TabIndex = 22
        Me.lbl_correct.Text = "Correct:"
        '
        'highScores
        '
        Me.highScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.highScores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.highScores.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.highScores.ForeColor = System.Drawing.Color.Transparent
        Me.highScores.FormattingEnabled = True
        Me.highScores.ItemHeight = 18
        Me.highScores.Location = New System.Drawing.Point(21, 63)
        Me.highScores.Name = "highScores"
        Me.highScores.Size = New System.Drawing.Size(251, 198)
        Me.highScores.TabIndex = 30
        '
        'header_highscore
        '
        Me.header_highscore.AutoSize = True
        Me.header_highscore.BackColor = System.Drawing.Color.Transparent
        Me.header_highscore.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header_highscore.Location = New System.Drawing.Point(17, 20)
        Me.header_highscore.Name = "header_highscore"
        Me.header_highscore.Size = New System.Drawing.Size(166, 23)
        Me.header_highscore.TabIndex = 30
        Me.header_highscore.Text = "High Scores:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(18, 215)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(48, 16)
        Me.lbl_time.TabIndex = 30
        Me.lbl_time.Text = "timer"
        '
        'planet_img
        '
        Me.planet_img.BackColor = System.Drawing.Color.Transparent
        Me.planet_img.BackgroundImage = CType(resources.GetObject("planet_img.BackgroundImage"), System.Drawing.Image)
        Me.planet_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.planet_img.Location = New System.Drawing.Point(580, 110)
        Me.planet_img.Name = "planet_img"
        Me.planet_img.Size = New System.Drawing.Size(101, 98)
        Me.planet_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.planet_img.TabIndex = 27
        Me.planet_img.TabStop = False
        '
        'spacecraft_img
        '
        Me.spacecraft_img.BackColor = System.Drawing.Color.Transparent
        Me.spacecraft_img.BackgroundImage = CType(resources.GetObject("spacecraft_img.BackgroundImage"), System.Drawing.Image)
        Me.spacecraft_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.spacecraft_img.Location = New System.Drawing.Point(28, 118)
        Me.spacecraft_img.Name = "spacecraft_img"
        Me.spacecraft_img.Size = New System.Drawing.Size(142, 86)
        Me.spacecraft_img.TabIndex = 26
        Me.spacecraft_img.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.math_game_.My.Resources.Resources.mw_hud
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.header_highscore)
        Me.Panel1.Controls.Add(Me.highScores)
        Me.Panel1.Location = New System.Drawing.Point(28, 296)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 280)
        Me.Panel1.TabIndex = 33
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.math_game_.My.Resources.Resources.mw_hud_blue
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.answer)
        Me.Panel3.Controls.Add(Me.header_game_summary)
        Me.Panel3.Controls.Add(Me.lbl_correct)
        Me.Panel3.Controls.Add(Me.lbl_time)
        Me.Panel3.Controls.Add(Me.lbl_incorrect)
        Me.Panel3.Controls.Add(Me.lbl_remaining)
        Me.Panel3.Controls.Add(Me.lbl_answered)
        Me.Panel3.Location = New System.Drawing.Point(327, 296)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(354, 280)
        Me.Panel3.TabIndex = 34
        '
        'header_game_summary
        '
        Me.header_game_summary.AutoSize = True
        Me.header_game_summary.BackColor = System.Drawing.Color.Transparent
        Me.header_game_summary.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header_game_summary.Location = New System.Drawing.Point(17, 20)
        Me.header_game_summary.Name = "header_game_summary"
        Me.header_game_summary.Size = New System.Drawing.Size(179, 23)
        Me.header_game_summary.TabIndex = 30
        Me.header_game_summary.Text = "Game Summary:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 22)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "="
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'addition_easy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(736, 588)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.answer_box)
        Me.Controls.Add(Me.submit_btn)
        Me.Controls.Add(Me.plus)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.welcome)
        Me.Controls.Add(Me.game_over)
        Me.Controls.Add(Me.planet_img)
        Me.Controls.Add(Me.spacecraft_img)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addition_easy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths Game: Easy Addition"
        CType(Me.planet_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spacecraft_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents answer_box As System.Windows.Forms.TextBox
    Friend WithEvents submit_btn As System.Windows.Forms.Button
    Friend WithEvents answer As System.Windows.Forms.Label
    Friend WithEvents plus As System.Windows.Forms.Label
    Friend WithEvents num2 As System.Windows.Forms.Label
    Friend WithEvents num1 As System.Windows.Forms.Label
    Friend WithEvents welcome As System.Windows.Forms.Label
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents game_over As System.Windows.Forms.Label
    Friend WithEvents planet_img As System.Windows.Forms.PictureBox
    Friend WithEvents spacecraft_img As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_answered As System.Windows.Forms.Label
    Friend WithEvents lbl_remaining As System.Windows.Forms.Label
    Friend WithEvents lbl_incorrect As System.Windows.Forms.Label
    Friend WithEvents lbl_correct As System.Windows.Forms.Label
    Friend WithEvents header_highscore As System.Windows.Forms.Label
    Friend WithEvents highScores As System.Windows.Forms.ListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents header_game_summary As Label
    Friend WithEvents Label1 As Label
End Class
