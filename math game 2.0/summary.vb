Public Class summary
    Private Sub summary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        over80.Visible = False
        Label3.Text = CInt(correct_counter / answered * 100) & "%"
        Label6.Text = CInt(correct_counter / answered * 100) & "%"
        If correct_counter / answered * 100 >= 80 Then
            over80.Visible = True
        End If
    End Sub
    Private Sub close_program(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class