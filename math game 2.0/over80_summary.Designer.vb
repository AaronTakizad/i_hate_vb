<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class over80_summary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(over80_summary))
        Me.over80 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.over80.SuspendLayout()
        Me.SuspendLayout()
        '
        'over80
        '
        Me.over80.BackColor = System.Drawing.Color.Transparent
        Me.over80.Controls.Add(Me.Label7)
        Me.over80.Controls.Add(Me.Label1)
        Me.over80.Controls.Add(Me.Label2)
        Me.over80.Location = New System.Drawing.Point(-23, -40)
        Me.over80.Name = "over80"
        Me.over80.Size = New System.Drawing.Size(517, 468)
        Me.over80.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(101, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(265, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "You are eligible for a certificate!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(101, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "You achieved over 80% correct."
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
        'over80_summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.math_game_.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(451, 359)
        Me.Controls.Add(Me.over80)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "over80_summary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths on Mars: Game Summary"
        Me.over80.ResumeLayout(False)
        Me.over80.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents over80 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
