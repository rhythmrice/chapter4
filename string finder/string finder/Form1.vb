Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim intStartIndex As Integer ' Starting index of the search
        Dim intFoundIndex As Integer ' Index of the found substring
        If IsNumeric(txtStartIndex.Text) Then
            If txtToFind.Text.Length > ) Then
                intStartIndex = CInt(txtStartIndex.Text)
            End If
    End Sub
End Class
