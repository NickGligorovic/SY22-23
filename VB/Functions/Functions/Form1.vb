Public Class Form1
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        clear()
        hightlight(Color.AliceBlue)
    End Sub
    Sub clear()
        LengthTextBox.Clear()
        WidthTextBox.Clear()
        AreaLabel.Text = ""
        PerimeterLabel.Text = ""
    End Sub
    Sub hightlight(C As Color)
        LengthTextBox.BackColor = C
        WidthTextBox.BackColor = C
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim Length As Integer
        Dim Width As Integer
        Integer.TryParse(LengthTextBox.Text, Length)
        Integer.TryParse(WidthTextBox.Text, Width)
        AreaLabel.Text = Area(Length, Width)
        PerimeterLabel.Text = Perimeter(Length, Width)
    End Sub
    Function Area(L As Integer, W As Integer) As Integer
        Return L * W
    End Function
    Function Perimeter(L As Integer, W As Integer) As Integer
        Return 2 * (L + W)
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, Button3.Click, Button2.Click, Button1.Click
        hightlight(sender.Backcolor)
    End Sub
    Public Function trianglearea(base As Integer, height As Integer) As Decimal
        Return base * height / 2



    End Function

    Private Sub TriArea_Click(sender As Object, e As EventArgs) Handles TriArea.Click
        Dim base As Integer
        Dim height As Integer
        Integer.TryParse(LengthTextBox.Text, base)
        Integer.TryParse(WidthTextBox.Text, height)
        AreaLabel.Text = trianglearea(base, height)

    End Sub
End Class
