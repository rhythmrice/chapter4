Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxcolor.SelectedIndexChanged
        Dim strInput As String ' Hold selected from list boxes


        strInput = listColor.SelectedIten.ToString() & " Dragon is the " &
            listEst.SelectedItem.ToString() & " Dragon of all. It has " & listNumber.SelectedItem.ToString() &
            " " & listBodyPart.SelectedItem.ToString() & ", and a " &
            listAnimal.SelectedItem.ToString() & " shaped like a "

        MessageBox.Show("The " & strInput & ", although it will feast on nearly anything.")
    End Sub
End Class
