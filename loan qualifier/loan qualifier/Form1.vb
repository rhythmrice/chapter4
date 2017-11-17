Public Class Form1

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonCheck_Click(sender As Object, e As EventArgs) Handles ButtonCheck.Click
        Dim dblSalary As Double
        Dim intYearsOnJob As Integer

        Try
            dblSalary = CDbl(TextBoxsalary.Text)
            intYearsOnJob = CInt(TextBoxyears.Text)

            If dblSalary > 30000 Then
                If intYearsOnJob > 2 Then
                    lblMessage.Text = "The applicant qualifies."
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
