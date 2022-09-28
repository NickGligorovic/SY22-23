Public Class Form1
    Dim First As Decimal
    Dim Second As Decimal
    Dim Oper As String

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B2.Click, B1.Click, B0.Click
        DisplayTextBox.Text = sender.text
    End Sub

    Private Sub BClear_Click(sender As Object, e As EventArgs) Handles BClear.Click
        DisplayTextBox.Clear()
    End Sub

    Private Sub BPlus_Click(sender As Object, e As EventArgs) Handles BPlus.Click
        Decimal.TryParse(DisplayTextBox.Text, First)
        Oper = sender.text
        DisplayTextBox.Clear()
    End Sub

    Private Sub BEquals_Click(sender As Object, e As EventArgs) Handles BEquals.Click
        Decimal.TryParse(DisplayTextBox.Text, Second)
        DisplayTextBox.Text = First + Second

    End Sub
End Class
