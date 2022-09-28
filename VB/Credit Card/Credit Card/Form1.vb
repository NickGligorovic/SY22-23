Public Class Form1
    Private Sub CancelLabel_Click(sender As Object, e As EventArgs) Handles CancelLabel.Click
        Me.Close()
    End Sub

    Private Sub BuyLabel_Click(sender As Object, e As EventArgs) Handles BuyLabel.Click
        Dim amount As Decimal
        Decimal.TryParse(AmountTextBox.Text, amount)
        Dim fee As Decimal
        fee = amount * 0.03
        NameTextBox.Clear()
        CCTextBox.Clear()
        ExpDateTextBox.Clear()
        ZipTextBox.Clear()
        AmountTextBox.Clear()
        FeeTextBox.Text = fee.ToString("c2")
    End Sub
End Class
