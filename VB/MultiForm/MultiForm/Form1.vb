Public Class Form1
    Private Sub Form2Button_Click(sender As Object, e As EventArgs) Handles Form2Button.Click
        Form2.ShowDialog()
        Label1.Text = Pickles

    End Sub

    Private Sub Form3_Click(sender As Object, e As EventArgs) Handles Form3Button.Click
        Form3.ShowDialog()
        Form3Label.Text = Wheel

    End Sub
End Class
