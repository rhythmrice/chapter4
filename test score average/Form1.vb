Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblScore1, dblScore2, dblscore3, dblAverage As Double

        Const NUM_SCORES As Integer = 3
        Const DblHIGH_SCORE As Double = 95.0

        Try
            dblScore1 = CDbl(txtScore1.Text)
            dblScore2 = CDbl(txtScore2.Text)
            dblscore3 = CDbl(txtScore3.Text)
            dblAverage = (dblScore1 + dblScore2 + dblscore3) / NUM_SCORES

            lblAverage.Text = dblAverage.ToString("n2")

            If dblAverage > DblHIGH_SCORE Then
                lblMessage.Text = "Congratulations! Great Job!"
            Else
                lblMessage.Text = "Keep Trying"
            End If
            If dblAverage < 60 Then
                lblGrade.Text = "F"
            ElseIf dblAverage < 70 Then
                lblGrade.Text = "D"
            ElseIf dblAverage < 80 Then
                lblGrade.Text = "C"
            ElseIf dblAverage < 90 Then
                lblGrade.Text = "B"
            ElseIf dblAverage < 100 Then
                lblGrade.Text = "A"
            Else
                lblGrade.Text = "Invalid Score"
            End If

        Catch ex As Exception
            lblMessage.Text = "Scores must be numeric"
        End Try
    End Sub

#If dblAverage > dblHIGH_SCORE Then
    lblMessage.Text = "Congratulations! Great Job!"
#End If

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        lblAverage.Text = ""
        lblMessage.Text = ""
        lblGrade.Text = ""
    End Sub
End Class
