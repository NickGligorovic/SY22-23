Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Age As Integer
        Integer.TryParse(TextBox1.Text, Age)
        Label1.Text = Age
        If Age > 17 Then
            Label1.Text = "you can vote"
            Me.BackColor = Color.Green
        Else
            Label1.Text = "you can't vote"
            Me.BackColor = Color.Red

        End If
        If RadioButton1.Checked Then
            Me.BackColor = Color.Blue
        End If
        If RadioButton2.Checked Then
            Me.BackColor = Color.Purple

        End If
        If RadioButton3.Checked Then
            Me.BackColor = Color.Orange

        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged


        If RadioButton1.Checked Then
            Me.BackColor = Color.Blue
        End If
        If RadioButton2.Checked Then
            Me.BackColor = Color.Purple

        End If
        If RadioButton3.Checked Then
            Me.BackColor = Color.Orange

        End If
    End Sub
End Class
