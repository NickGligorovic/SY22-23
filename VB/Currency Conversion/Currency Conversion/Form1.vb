Public Class Form1
    Private Sub USDTextBox_TextChanged(sender As Object, e As EventArgs) Handles USDTextBox.TextChanged
        Dim amount As Decimal
        Decimal.TryParse(USDTextBox.Text, amount)
        Dim Yen As Decimal
        Yen = amount * 136.4
        YenTextBox.Text = Yen.ToString("c2")
        Dim Ruble As Decimal
        Ruble = amount * 60.15
        Rubletextbox.Text = Ruble.ToString("c2")
        Dim Peso As Decimal
        Peso = amount * 19.92
        PesoTextBox.Text = Peso.ToString("c2")
        Dim Euro As Decimal
        Euro = amount * 1
        EuroTextBox.Text = Euro.ToString("c2")
        Dim Pound As Decimal
        Pound = amount * 0.84
        PoundTextBox.Text = Pound.ToString("c2")






    End Sub
End Class

