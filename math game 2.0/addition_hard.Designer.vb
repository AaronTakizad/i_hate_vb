<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addition_hard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addition_hard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.highScores = New System.Windows.Forms.ListBox()
        Me.header_highscore = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.answer_box = New System.Windows.Forms.TextBox()
        Me.submit_btn = New System.Windows.Forms.Button()
        Me.answer = New System.Windows.Forms.Label()
        Me.plus = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.Label()
        Me.num1 = New System.Windows.Forms.Label()
        Me.welcome = New System.Windows.Forms.Label()
        Me.game_over = New System.Windows.Forms.Label()
        Me.planet_img = New System.Windows.Forms.PictureBox()
        Me.lbl_answered = New System.Windows.Forms.Label()
        Me.Process1 = New System.Diagnostics.Process()
        Me.spacecraft_img = New System.Windows.Forms.PictureBox()
        Me.lbl_remaining = New System.Windows.Forms.Label()
        Me.lbl_incorrect = New System.Windows.Forms.Label()
        Me.lbl_correct = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.planet_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spacecraft_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.highScores)
        Me.Panel1.Controls.Add(Me.header_highscore)
        Me.Panel1.Location = New System.Drawing.Point(28, 233)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(171, 234)
        Me.Panel1.TabIndex = 45
        '
        'highScores
        '
        Me.highScores.FormattingEnabled = True
        Me.highScores.Location = New System.Drawing.Point(17, 37)
        Me.highScores.Name = "highScores"
        Me.highScores.Size = New System.Drawing.Size(142, 173)
        Me.highScores.TabIndex = 30
        '
        'header_highscore
        '
        Me.header_highscore.AutoSize = True
        Me.header_highscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header_highscore.Location = New System.Drawing.Point(13, 11)
        Me.header_highscore.Name = "header_highscore"
        Me.header_highscore.Size = New System.Drawing.Size(112, 20)
        Me.header_highscore.TabIndex = 30
        Me.header_highscore.Text = "High Scores:"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Location = New System.Drawing.Point(230, 418)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(29, 13)
        Me.lbl_time.TabIndex = 46
        Me.lbl_time.Text = "timer"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'answer_box
        '
        Me.answer_box.Location = New System.Drawing.Point(361, 260)
        Me.answer_box.Name = "answer_box"
        Me.answer_box.Size = New System.Drawing.Size(100, 20)
        Me.answer_box.TabIndex = 37
        '
        'submit_btn
        '
        Me.submit_btn.Location = New System.Drawing.Point(513, 257)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.Size = New System.Drawing.Size(75, 23)
        Me.submit_btn.TabIndex = 36
        Me.submit_btn.Text = "Submit"
        Me.submit_btn.UseVisualStyleBackColor = True
        '
        'answer
        '
        Me.answer.AutoSize = True
        Me.answer.Location = New System.Drawing.Point(230, 352)
        Me.answer.Name = "answer"
        Me.answer.Size = New System.Drawing.Size(41, 13)
        Me.answer.TabIndex = 35
        Me.answer.Text = "answer"
        '
        'plus
        '
        Me.plus.AutoSize = True
        Me.plus.Location = New System.Drawing.Point(269, 263)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(13, 13)
        Me.plus.TabIndex = 34
        Me.plus.Text = "+"
        '
        'num2
        '
        Me.num2.AutoSize = True
        Me.num2.Location = New System.Drawing.Point(299, 263)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(33, 13)
        Me.num2.TabIndex = 33
        Me.num2.Text = "num2"
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.Location = New System.Drawing.Point(230, 263)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(33, 13)
        Me.num1.TabIndex = 32
        Me.num1.Text = "num1"
        '
        'welcome
        '
        Me.welcome.AutoSize = True
        Me.welcome.Location = New System.Drawing.Point(59, 55)
        Me.welcome.Name = "welcome"
        Me.welcome.Size = New System.Drawing.Size(76, 13)
        Me.welcome.TabIndex = 31
        Me.welcome.Text = "Welcome Text"
        '
        'game_over
        '
        Me.game_over.AutoSize = True
        Me.game_over.ForeColor = System.Drawing.Color.Green
        Me.game_over.Location = New System.Drawing.Point(96, 121)
        Me.game_over.Name = "game_over"
        Me.game_over.Size = New System.Drawing.Size(64, 13)
        Me.game_over.TabIndex = 44
        Me.game_over.Text = "Game Over!"
        '
        'planet_img
        '
        Me.planet_img.BackgroundImage = CType(resources.GetObject("planet_img.BackgroundImage"), System.Drawing.Image)
        Me.planet_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.planet_img.Location = New System.Drawing.Point(580, 110)
        Me.planet_img.Name = "planet_img"
        Me.planet_img.Size = New System.Drawing.Size(101, 98)
        Me.planet_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.planet_img.TabIndex = 43
        Me.planet_img.TabStop = False
        '
        'lbl_answered
        '
        Me.lbl_answered.AutoSize = True
        Me.lbl_answered.Location = New System.Drawing.Point(535, 382)
        Me.lbl_answered.Name = "lbl_answered"
        Me.lbl_answered.Size = New System.Drawing.Size(84, 13)
        Me.lbl_answered.TabIndex = 41
        Me.lbl_answered.Text = "Total Answered:"
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
        'spacecraft_img
        '
        Me.spacecraft_img.BackColor = System.Drawing.Color.Transparent
        Me.spacecraft_img.BackgroundImage = CType(resources.GetObject("spacecraft_img.BackgroundImage"), System.Drawing.Image)
        Me.spacecraft_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.spacecraft_img.Location = New System.Drawing.Point(28, 118)
        Me.spacecraft_img.Name = "spacecraft_img"
        Me.spacecraft_img.Size = New System.Drawing.Size(142, 86)
        Me.spacecraft_img.TabIndex = 42
        Me.spacecraft_img.TabStop = False
        '
        'lbl_remaining
        '
        Me.lbl_remaining.AutoSize = True
        Me.lbl_remaining.Location = New System.Drawing.Point(535, 418)
        Me.lbl_remaining.Name = "lbl_remaining"
        Me.lbl_remaining.Size = New System.Drawing.Size(60, 13)
        Me.lbl_remaining.TabIndex = 40
        Me.lbl_remaining.Text = "Remaining:"
        '
        'lbl_incorrect
        '
        Me.lbl_incorrect.AutoSize = True
        Me.lbl_incorrect.Location = New System.Drawing.Point(535, 352)
        Me.lbl_incorrect.Name = "lbl_incorrect"
        Me.lbl_incorrect.Size = New System.Drawing.Size(52, 13)
        Me.lbl_incorrect.TabIndex = 39
        Me.lbl_incorrect.Text = "Incorrect:"
        '
        'lbl_correct
        '
        Me.lbl_correct.AutoSize = True
        Me.lbl_correct.Location = New System.Drawing.Point(535, 315)
        Me.lbl_correct.Name = "lbl_correct"
        Me.lbl_correct.Size = New System.Drawing.Size(44, 13)
        Me.lbl_correct.TabIndex = 38
        Me.lbl_correct.Text = "Correct:"
        '
        'addition_hard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.answer_box)
        Me.Controls.Add(Me.submit_btn)
        Me.Controls.Add(Me.answer)
        Me.Controls.Add(Me.plus)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.welcome)
        Me.Controls.Add(Me.game_over)
        Me.Controls.Add(Me.planet_img)
        Me.Controls.Add(Me.lbl_answered)
        Me.Controls.Add(Me.spacecraft_img)
        Me.Controls.Add(Me.lbl_remaining)
        Me.Controls.Add(Me.lbl_incorrect)
        Me.Controls.Add(Me.lbl_correct)
        Me.Name = "addition_hard"
        Me.Text = "Maths Game: Hard Addition"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.planet_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spacecraft_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents highScores As System.Windows.Forms.ListBox
    Friend WithEvents header_highscore As System.Windows.Forms.Label
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents answer_box As System.Windows.Forms.TextBox
    Friend WithEvents submit_btn As System.Windows.Forms.Button
    Friend WithEvents answer As System.Windows.Forms.Label
    Friend WithEvents plus As System.Windows.Forms.Label
    Friend WithEvents num2 As System.Windows.Forms.Label
    Friend WithEvents num1 As System.Windows.Forms.Label
    Friend WithEvents welcome As System.Windows.Forms.Label
    Friend WithEvents game_over As System.Windows.Forms.Label
    Friend WithEvents planet_img As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_answered As System.Windows.Forms.Label
    Friend WithEvents Process1 As System.Diagnostics.Process
    Friend WithEvents spacecraft_img As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_remaining As System.Windows.Forms.Label
    Friend WithEvents lbl_incorrect As System.Windows.Forms.Label
    Friend WithEvents lbl_correct As System.Windows.Forms.Label
End Class
