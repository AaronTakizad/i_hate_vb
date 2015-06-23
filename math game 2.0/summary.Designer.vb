<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class summary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(summary))
        Me.over80 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.over80.SuspendLayout()
        Me.SuspendLayout()
        '
        'over80
        '
        Me.over80.BackColor = System.Drawing.Color.Transparent
        Me.over80.Controls.Add(Me.Label7)
        Me.over80.Controls.Add(Me.Label3)
        Me.over80.Controls.Add(Me.Label1)
        Me.over80.Controls.Add(Me.Label2)
        Me.over80.Location = New System.Drawing.Point(-21, -33)
        Me.over80.Name = "over80"
        Me.over80.Size = New System.Drawing.Size(517, 468)
        Me.over80.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(320, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 24)
        Me.Label3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(91, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "You achieved over 80% correct." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your final percentage was: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(99, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Congradulations!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(40, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(389, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Better luck next time!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(77, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(313, 48)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "You achieved less than 80% correct." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your final percentage was: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(316, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 24)
        Me.Label6.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(91, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(265, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "You are eligible for a certificate!"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(77, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(265, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "You are not eligible for a certificate..."
        '
        'summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.math_game_.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(451, 359)
        Me.Controls.Add(Me.over80)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "summary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths on Mars: Game Summary"
        Me.over80.ResumeLayout(False)
        Me.over80.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents over80 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
