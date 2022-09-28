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
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CCTextBox = New System.Windows.Forms.TextBox()
        Me.ExpDateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.CCLabel = New System.Windows.Forms.Label()
        Me.ExpDateLabel = New System.Windows.Forms.Label()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FeeTextBox = New System.Windows.Forms.TextBox()
        Me.FeeLabel = New System.Windows.Forms.Label()
        Me.BuyLabel = New System.Windows.Forms.Button()
        Me.CancelLabel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(132, 29)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NameTextBox.TabIndex = 0
        '
        'CCTextBox
        '
        Me.CCTextBox.Location = New System.Drawing.Point(132, 73)
        Me.CCTextBox.Name = "CCTextBox"
        Me.CCTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CCTextBox.TabIndex = 1
        '
        'ExpDateTextBox
        '
        Me.ExpDateTextBox.Location = New System.Drawing.Point(132, 117)
        Me.ExpDateTextBox.Name = "ExpDateTextBox"
        Me.ExpDateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ExpDateTextBox.TabIndex = 2
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(132, 161)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ZipTextBox.TabIndex = 3
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(132, 201)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AmountTextBox.TabIndex = 4
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(63, 35)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(44, 16)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name"
        '
        'CCLabel
        '
        Me.CCLabel.AutoSize = True
        Me.CCLabel.Location = New System.Drawing.Point(63, 79)
        Me.CCLabel.Name = "CCLabel"
        Me.CCLabel.Size = New System.Drawing.Size(32, 16)
        Me.CCLabel.TabIndex = 6
        Me.CCLabel.Text = "CC#"
        '
        'ExpDateLabel
        '
        Me.ExpDateLabel.AutoSize = True
        Me.ExpDateLabel.Location = New System.Drawing.Point(63, 123)
        Me.ExpDateLabel.Name = "ExpDateLabel"
        Me.ExpDateLabel.Size = New System.Drawing.Size(62, 16)
        Me.ExpDateLabel.TabIndex = 7
        Me.ExpDateLabel.Text = "Exp Date"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(63, 167)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(26, 16)
        Me.ZipLabel.TabIndex = 8
        Me.ZipLabel.Text = "Zip"
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(63, 207)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(52, 16)
        Me.AmountLabel.TabIndex = 9
        Me.AmountLabel.Text = "Amount"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Credit_Card.My.Resources.Resources.visa
        Me.PictureBox1.Location = New System.Drawing.Point(279, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'FeeTextBox
        '
        Me.FeeTextBox.Location = New System.Drawing.Point(398, 201)
        Me.FeeTextBox.Name = "FeeTextBox"
        Me.FeeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FeeTextBox.TabIndex = 11
        '
        'FeeLabel
        '
        Me.FeeLabel.AutoSize = True
        Me.FeeLabel.Location = New System.Drawing.Point(312, 204)
        Me.FeeLabel.Name = "FeeLabel"
        Me.FeeLabel.Size = New System.Drawing.Size(31, 16)
        Me.FeeLabel.TabIndex = 12
        Me.FeeLabel.Text = "Fee"
        '
        'BuyLabel
        '
        Me.BuyLabel.Location = New System.Drawing.Point(40, 274)
        Me.BuyLabel.Name = "BuyLabel"
        Me.BuyLabel.Size = New System.Drawing.Size(75, 23)
        Me.BuyLabel.TabIndex = 13
        Me.BuyLabel.Text = "Buy"
        Me.BuyLabel.UseVisualStyleBackColor = True
        '
        'CancelLabel
        '
        Me.CancelLabel.Location = New System.Drawing.Point(132, 274)
        Me.CancelLabel.Name = "CancelLabel"
        Me.CancelLabel.Size = New System.Drawing.Size(75, 23)
        Me.CancelLabel.TabIndex = 14
        Me.CancelLabel.Text = "Cancel"
        Me.CancelLabel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CancelLabel)
        Me.Controls.Add(Me.BuyLabel)
        Me.Controls.Add(Me.FeeLabel)
        Me.Controls.Add(Me.FeeTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.ZipLabel)
        Me.Controls.Add(Me.ExpDateLabel)
        Me.Controls.Add(Me.CCLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.ExpDateTextBox)
        Me.Controls.Add(Me.CCTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents CCTextBox As TextBox
    Friend WithEvents ExpDateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents CCLabel As Label
    Friend WithEvents ExpDateLabel As Label
    Friend WithEvents ZipLabel As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FeeTextBox As TextBox
    Friend WithEvents FeeLabel As Label
    Friend WithEvents BuyLabel As Button
    Friend WithEvents CancelLabel As Button
End Class
