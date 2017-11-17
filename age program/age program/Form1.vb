Public Class Form1

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonInsult_Click(sender As Object, e As EventArgs) Handles ButtonInsult.Click
        Dim intAge As Double

        Try
            intAge = UserAgeInput.Text

            If intAge < 10 Then
                lblResult.Text = "Can you even read?"
            ElseIf intAge >= 10 And intAge < 14 Then
                lblResult.Text = "There are no words to express how naive you are."
            ElseIf intAge <= 14 And inAge < 18 Then
                lblResult.Text = "You have no clue how the real world works."
            ElseIf intAge >= 18 And intAge < 24 Then
                lblResult.Text = "your dumb."
            ElseIf intAge <= 24 And inAge < 30 Then
                lblResult.Text = "Your stupid"
            ElseIf intAge >= 30 And intAge < 40 Then
                lblResult.Text = "youre not smart"
            ElseIf intAge <= 40 And inAge < 60 Then
                lblResult.Text = "your really dumb"
            ElseIf intAge >= 60 And intAge < 200 Then
                lblResult.Text = "your not funny"
          
            End If
        Catch ex As Exception
            lblMessage.Text = "Enter a numeric value"
        End Try
    End Sub
End Class
