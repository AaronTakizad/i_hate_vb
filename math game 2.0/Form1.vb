Imports System.Drawing.Text
Public Module GlobalVariables
    Public player_name As String
    Public question_count As Integer
End Module

Public Class Form1
    Dim pfc As PrivateFontCollection = New PrivateFontCollection()
    Dim game_group_val As Boolean = False
    Dim level_group_val As Boolean = False
    Dim player_name_val As Boolean = False
    Dim num_of_q_val As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pfc.AddFontFile("fonts/ethnocentric.ttf")
        pfc.AddFontFile("fonts/aroma-light.ttf")
        start_btn.Enabled = False
        Label1.Font = New Font(pfc.Families(1), 24)
        possible_errors.Font = New Font(pfc.Families(0), 20)
    End Sub
    Private Sub player_name_Enter(sender As Object, e As EventArgs) Handles player_name_tb.TextChanged
        If player_name_val = False Then
            ProgressBar1.Value = ProgressBar1.Value + 25
            player_name_val = True
        End If

        If ProgressBar1.Value = 100 Then
            start_btn.Enabled = True
            start_btn.BackColor = Color.Maroon
        End If
    End Sub
    Private Sub level_group_Enter(sender As Object, e As EventArgs) Handles level_group.Enter
        If level_group_val = False Then
            ProgressBar1.Value = ProgressBar1.Value + 25
            level_group_val = True
        End If

        If ProgressBar1.Value = 100 Then
            start_btn.Enabled = True
            start_btn.BackColor = Color.Maroon
        End If
    End Sub
    Private Sub game_type_group_Enter(sender As Object, e As EventArgs) Handles game_type_group.Enter
        If game_group_val = False Then
            ProgressBar1.Value = ProgressBar1.Value + 25
            game_group_val = True
        End If

        If ProgressBar1.Value = 100 Then
            start_btn.Enabled = True
            start_btn.BackColor = Color.Maroon
        End If
    End Sub
    Private Sub num_of_q_TextChanged(sender As Object, e As EventArgs) Handles num_of_q.TextChanged
        If num_of_q_val = False Then
            ProgressBar1.Value = ProgressBar1.Value + 25
            num_of_q_val = True
        End If
        If ProgressBar1.Value = 100 Then
            start_btn.Enabled = True
            start_btn.BackColor = Color.Maroon
        End If
    End Sub
    Private Sub start_btn_Click(sender As Object, e As EventArgs) Handles start_btn.Click
        If player_name_tb.Text = "" Then
            possible_errors.Text = ""
            possible_errors.Text = "Please enter a valid name!"
            player_name_tb.Focus()
        Else
            player_name = player_name_tb.Text
            If Val(num_of_q.Text) = 0 Then
                possible_errors.Text = ""
                possible_errors.Text = "Please enter a valid number!"
                num_of_q.Focus()
            Else
                possible_errors.Text = ""
                question_count = Val(num_of_q.Text)
                If addition_type.Checked Then
                    If easy_level.Checked Then
                        Me.Hide()
                        addition_easy.Show()
                    ElseIf medium_level.Checked Then
                        Me.Hide()
                        addition_medium.Show()
                    ElseIf hard_level.Checked Then
                        Me.Hide()
                        addition_hard.Show()
                    Else
                        possible_errors.Text = ""
                        possible_errors.Text = "Please select a difficulty level!"
                    End If
                ElseIf multiplication_type.Checked Then
                    If easy_level.Checked Then
                        Me.Hide()
                        multiplication_easy.Show()
                    ElseIf medium_level.Checked Then
                        Me.Hide()
                        multiplication_medium.Show()
                    ElseIf hard_level.Checked Then
                        Me.Hide()
                        multiplication_hard.Show()
                    End If
                Else
                    possible_errors.Text = ""
                    possible_errors.Text = "Please select a game type!"
                End If
            End If
        End If
    End Sub

    Private Sub help_btn_Click(sender As Object, e As EventArgs) Handles help_btn.Click
        help.Show()
    End Sub

    Private Sub close_program(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
