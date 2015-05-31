Imports System.Drawing.Text
Imports System.IO
Public Class addition_medium
    Dim pfc As PrivateFontCollection = New PrivateFontCollection()
    Dim correct_counter As Integer = 0
    Dim incorrect_counter As Integer = 0
    Dim answered As Integer = 0
    Dim total_travel_distance As Integer = 409
    Dim dynamic_travel_distance As Integer
    Dim time_passed As Integer = 0
    Dim dataTableScoreDetail As New DataTable

    Private Sub addition_medium_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        pfc.AddFontFile("fonts/ethnocentric.ttf")
        pfc.AddFontFile("fonts/aroma-light.ttf")

        welcome.Text = "Welcome to the maths game, " & GlobalVariables.player_name & "! You selected Medium Addition."
        Randomize()
        num1.Text = CInt(Int((25 * Rnd()) + 1))
        Randomize()
        num2.Text = CInt(Int((25 * Rnd()) + 1))

        lbl_correct.Text = "Correct: " & correct_counter
        lbl_incorrect.Text = "Incorrect: " & incorrect_counter
        lbl_answered.Text = "Answered: " & answered
        lbl_remaining.Text = "Remaining: " & GlobalVariables.question_count

        game_over.Font = New Font(pfc.Families(1), 40)
        game_over.Visible = False


        '''''''''''''Setting up Highscores'''''''''''''''''


        dataTableScoreDetail.Columns.Add("Id", Type.GetType("System.Int32"))
        dataTableScoreDetail.Columns.Add("player_name", Type.GetType("System.String"))
        dataTableScoreDetail.Columns.Add("correct_counter", Type.GetType("System.Int32"))
        dataTableScoreDetail.Columns.Add("Time_Elapsed", Type.GetType("System.Int32"))

        'Try --------Try Catch for testing purposes
        dataTableScoreDetail.TableName = "easy_a"
        dataTableScoreDetail.ReadXml("highscores/easy_a.xml")
        'Catch ex As Exception

        'End Try



        Dim view As New DataView(dataTableScoreDetail)

        view.Sort = "correct_counter desc,Time_Elapsed ASC,player_name" ' Sort items first by high score (descending), then by time elapsed (ascending), then by player name (ascending)
        For Each row As DataRowView In view 'For every row in the XML table
            If highScores.Items.Count < 3 Then ' If there are less than 3 items in the HighScores listbox, add items. (items sorted already in `view.Sort`)
                highScores.Items.Add(row.Item("player_name") & "  " & row.Item("correct_counter") & "  " & row.Item("Time_Elapsed") & " sec")
            End If
        Next


        '''''''''''''''''''''''''''''''''


    End Sub

    Private Sub submit_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles submit_btn.Click
        If Val(answer_box.Text) = Val(num1.Text) + Val(num2.Text) Then
            answer.ForeColor = Color.Green
            answer.Text = "Great job!"
            correct_counter += 1
            dynamic_travel_distance = total_travel_distance / GlobalVariables.question_count
            spacecraft_img.Left += dynamic_travel_distance
            total_travel_distance -= dynamic_travel_distance
        Else
            answer.ForeColor = Color.Red
            answer.Text = "The answer was " & Val(num1.Text) + Val(num2.Text)
            incorrect_counter += 1
        End If
        answer_box.Text = ""

        GlobalVariables.question_count -= 1
        answered += 1
        lbl_correct.Text = "Correct: " & correct_counter
        lbl_incorrect.Text = "Incorrect: " & incorrect_counter
        lbl_answered.Text = "Answered: " & answered
        lbl_remaining.Text = "Remaining: " & GlobalVariables.question_count

        If GlobalVariables.question_count > 0 Then
            Randomize()
            num1.Text = CInt(Int((25 * Rnd()) + 1))
            Randomize()
            num2.Text = CInt(Int((25 * Rnd()) + 1))
        Else
            Me.Refresh()
            Threading.Thread.Sleep(1000)
            spacecraft_img.Visible = False
            planet_img.Visible = False
            For i As Integer = 0 To 2
                Me.Refresh()
                Threading.Thread.Sleep(500)
                game_over.Visible = False
                Me.Refresh()
                Threading.Thread.Sleep(500)
                game_over.Visible = True
                Me.Refresh()
            Next
            Threading.Thread.Sleep(1500)

            Dim dr As DataRow = dataTableScoreDetail.NewRow()
            dr.Item("Id") = dataTableScoreDetail.Rows.Count
            dr.Item("player_name") = GlobalVariables.player_name
            dr.Item("correct_counter") = correct_counter
            dr.Item("time_elapsed") = time_passed
            dataTableScoreDetail.Rows.Add(dr)
            Me.Hide()

            'Try [FOR TESTING]
            dataTableScoreDetail.TableName = "medium_a"
            dataTableScoreDetail.WriteXml("highscores/medium_a.xml")
            'Catch ex As Exception

            'End Try

            summary.Show()
        End If
    End Sub
    Private Sub close_program(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub answer_box_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles answer_box.KeyDown
        If e.KeyCode = Keys.Enter Then
            submit_btn.PerformClick()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        time_passed += 1
        lbl_time.Text = "Time Elapsed: " & time_passed
    End Sub
End Class