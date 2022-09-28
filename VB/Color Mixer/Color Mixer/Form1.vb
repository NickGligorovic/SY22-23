Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim inputRed As Integer
        Dim inputGreen As Integer
        Dim inputBlue As Integer

        Integer.TryParse(RedTextBox.Text, inputRed)
        Integer.TryParse(GreenTextBox.Text, inputGreen)
        Integer.TryParse(BlueTextBox.Text, inputBlue)

        PictureBox1.BackColor =
            Color.FromArgb(inputRed, inputGreen, inputBlue)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Me.Close()

    End Sub
End Class
