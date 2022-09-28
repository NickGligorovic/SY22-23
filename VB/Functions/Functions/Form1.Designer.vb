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
        Me.LengthTextBox = New System.Windows.Forms.TextBox()
        Me.WidthTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AreaLabel = New System.Windows.Forms.Label()
        Me.PerimeterLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TriArea = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Location = New System.Drawing.Point(309, 101)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LengthTextBox.TabIndex = 0
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(309, 129)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(100, 22)
        Me.WidthTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Width"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Area"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Perimeter"
        '
        'AreaLabel
        '
        Me.AreaLabel.AutoSize = True
        Me.AreaLabel.Location = New System.Drawing.Point(322, 175)
        Me.AreaLabel.Name = "AreaLabel"
        Me.AreaLabel.Size = New System.Drawing.Size(0, 16)
        Me.AreaLabel.TabIndex = 6
        '
        'PerimeterLabel
        '
        Me.PerimeterLabel.AutoSize = True
        Me.PerimeterLabel.Location = New System.Drawing.Point(322, 203)
        Me.PerimeterLabel.Name = "PerimeterLabel"
        Me.PerimeterLabel.Size = New System.Drawing.Size(0, 16)
        Me.PerimeterLabel.TabIndex = 7
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(216, 244)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(80, 23)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(325, 244)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(84, 23)
        Me.CalculateButton.TabIndex = 9
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.Location = New System.Drawing.Point(554, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 59)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.YellowGreen
        Me.Button2.Location = New System.Drawing.Point(622, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 59)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.Location = New System.Drawing.Point(554, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 59)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Gold
        Me.Button4.Location = New System.Drawing.Point(622, 197)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 59)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TriArea
        '
        Me.TriArea.Location = New System.Drawing.Point(274, 284)
        Me.TriArea.Name = "TriArea"
        Me.TriArea.Size = New System.Drawing.Size(75, 56)
        Me.TriArea.TabIndex = 14
        Me.TriArea.Text = "Triangle Area"
        Me.TriArea.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TriArea)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.PerimeterLabel)
        Me.Controls.Add(Me.AreaLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WidthTextBox)
        Me.Controls.Add(Me.LengthTextBox)
        Me.Name = "Form1"
        Me.Text = "Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LengthTextBox As TextBox
    Friend WithEvents WidthTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AreaLabel As Label
    Friend WithEvents PerimeterLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TriArea As Button
End Class
