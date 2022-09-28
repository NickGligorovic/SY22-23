<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RedTextBox = New System.Windows.Forms.TextBox()
        Me.GreenTextBox = New System.Windows.Forms.TextBox()
        Me.BlueTextBox = New System.Windows.Forms.TextBox()
        Me.RedLabel = New System.Windows.Forms.Label()
        Me.GreenLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RedTextBox
        '
        Me.RedTextBox.Location = New System.Drawing.Point(289, 93)
        Me.RedTextBox.Name = "RedTextBox"
        Me.RedTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RedTextBox.TabIndex = 0
        '
        'GreenTextBox
        '
        Me.GreenTextBox.Location = New System.Drawing.Point(289, 141)
        Me.GreenTextBox.Name = "GreenTextBox"
        Me.GreenTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GreenTextBox.TabIndex = 1
        '
        'BlueTextBox
        '
        Me.BlueTextBox.Location = New System.Drawing.Point(289, 192)
        Me.BlueTextBox.Name = "BlueTextBox"
        Me.BlueTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BlueTextBox.TabIndex = 2
        '
        'RedLabel
        '
        Me.RedLabel.AutoSize = True
        Me.RedLabel.Location = New System.Drawing.Point(147, 98)
        Me.RedLabel.Name = "RedLabel"
        Me.RedLabel.Size = New System.Drawing.Size(86, 16)
        Me.RedLabel.TabIndex = 3
        Me.RedLabel.Text = "&Red(0 to 255)"
        '
        'GreenLabel
        '
        Me.GreenLabel.AutoSize = True
        Me.GreenLabel.Location = New System.Drawing.Point(150, 146)
        Me.GreenLabel.Name = "GreenLabel"
        Me.GreenLabel.Size = New System.Drawing.Size(97, 16)
        Me.GreenLabel.TabIndex = 4
        Me.GreenLabel.Text = "&Green(0 to 255)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&Blue(0 to 255)"
        '
        'ViewButton
        '
        Me.ViewButton.Location = New System.Drawing.Point(136, 299)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(75, 23)
        Me.ViewButton.TabIndex = 6
        Me.ViewButton.Text = "E&xit"
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(289, 298)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "&View"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(481, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 141)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GreenLabel)
        Me.Controls.Add(Me.RedLabel)
        Me.Controls.Add(Me.BlueTextBox)
        Me.Controls.Add(Me.GreenTextBox)
        Me.Controls.Add(Me.RedTextBox)
        Me.Name = "Form1"
        Me.Text = "ColorMixer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RedTextBox As TextBox
    Friend WithEvents GreenTextBox As TextBox
    Friend WithEvents BlueTextBox As TextBox
    Friend WithEvents RedLabel As Label
    Friend WithEvents GreenLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ViewButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
