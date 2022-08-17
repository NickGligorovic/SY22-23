Public Class Form1
    Private Sub TahmKenchButton_Click(sender As Object, e As EventArgs) Handles TahmKenchButton.Click
        displayPictureBox.Image = TahmPictureBox.Image
        NameLabel.Text = "Tahm Kentch"
        LaneLabel.Text = "Top"
        ClassLabel.Text = "Tank"
        RaceLabel.Text = "Demon"
    End Sub

    Private Sub PoppyButton_Click(sender As Object, e As EventArgs) Handles PoppyButton.Click
        displayPictureBox.Image = PoppyPictureBox.Image
        NameLabel.Text = "Poppy"
        LaneLabel.Text = "Top or Jungle"
        ClassLabel.Text = "Bruiser/Tank"
        RaceLabel.Text = "Yordle"
    End Sub

    Private Sub EzrealButton_Click(sender As Object, e As EventArgs) Handles EzrealButton.Click
        displayPictureBox.Image = EzrealPictureBox.Image
        NameLabel.Text = "Ezreal"
        LaneLabel.Text = "Bottom"
        ClassLabel.Text = "Marksman"
        RaceLabel.Text = "Human"

    End Sub

    Private Sub LuxButton_Click(sender As Object, e As EventArgs) Handles LuxButton.Click
        displayPictureBox.Image = LuxPictureBox.Image
        NameLabel.Text = "Lux"
        LaneLabel.Text = "Mid"
        ClassLabel.Text = "Mage"
        RaceLabel.Text = "Human"
    End Sub

    Private Sub AattroxButton_Click(sender As Object, e As EventArgs) Handles AattroxButton.Click
        displayPictureBox.Image = AattroxPictureBox.Image
        NameLabel.Text = "Aattrox"
        LaneLabel.Text = "Top"
        ClassLabel.Text = "Bruiser"
        RaceLabel.Text = "Demon"
    End Sub
End Class
