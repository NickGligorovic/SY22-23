Public Class Form1
    Private Sub TotalTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalTextBox.TextChanged
        Dim Total As Decimal
        Decimal.TryParse(TotalTextBox.Text, Total)
        Dim Tip As Decimal
        Dim Tax As Decimal

        If Tip5.Checked Then
            Tip = Total * 0.05
        End If
        If Tip10.Checked Then
            Tip = Total * 0.1
        End If
        If Tip20.Checked Then
            Tip = Total * 0.2
        End If
        If Tip25.Checked Then
            Tip = Total * 0.25
        End If
        Dim TotalAmount As Decimal
        Tax = Total * 0.0255
        TotalAmount = Total + Tip + Tax
        TipAmount.Text = Tip.ToString("c2")
        TotalAmountText.Text = TotalAmount.ToString("c2")
        TaxLabel.Text = Tax.ToString("c2")

    End Sub

    Private Sub Tip25_CheckedChanged(sender As Object, e As EventArgs) Handles Tip5.CheckedChanged, Tip25.CheckedChanged, Tip20.CheckedChanged, Tip10.CheckedChanged
        Dim Total As Decimal
        Decimal.TryParse(TotalTextBox.Text, Total)
        Dim Tip As Decimal
        Dim Tax As Decimal

        If Tip5.Checked Then
            Tip = Total * 0.05
        End If
        If Tip10.Checked Then
            Tip = Total * 0.1
        End If
        If Tip20.Checked Then
            Tip = Total * 0.2
        End If
        If Tip25.Checked Then
            Tip = Total * 0.25
        End If
        Dim TotalAmount As Decimal
        Tax = Total * 0.0255
        TotalAmount = Total + Tip + Tax
        TipAmount.Text = Tip.ToString("c2")
        TotalAmountText.Text = TotalAmount.ToString("c2")
        TaxLabel.Text = Tax.ToString("c2")
    End Sub
End Class
