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
        Me.Tip5 = New System.Windows.Forms.RadioButton()
        Me.Tip10 = New System.Windows.Forms.RadioButton()
        Me.Tip20 = New System.Windows.Forms.RadioButton()
        Me.Tip25 = New System.Windows.Forms.RadioButton()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TipAmount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalAmountText = New System.Windows.Forms.Label()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Tip5
        '
        Me.Tip5.AutoSize = True
        Me.Tip5.Location = New System.Drawing.Point(13, 13)
        Me.Tip5.Name = "Tip5"
        Me.Tip5.Size = New System.Drawing.Size(47, 20)
        Me.Tip5.TabIndex = 0
        Me.Tip5.TabStop = True
        Me.Tip5.Text = "5%"
        Me.Tip5.UseVisualStyleBackColor = True
        '
        'Tip10
        '
        Me.Tip10.AutoSize = True
        Me.Tip10.Location = New System.Drawing.Point(13, 40)
        Me.Tip10.Name = "Tip10"
        Me.Tip10.Size = New System.Drawing.Size(54, 20)
        Me.Tip10.TabIndex = 1
        Me.Tip10.TabStop = True
        Me.Tip10.Text = "10%"
        Me.Tip10.UseVisualStyleBackColor = True
        '
        'Tip20
        '
        Me.Tip20.AutoSize = True
        Me.Tip20.Location = New System.Drawing.Point(13, 67)
        Me.Tip20.Name = "Tip20"
        Me.Tip20.Size = New System.Drawing.Size(54, 20)
        Me.Tip20.TabIndex = 2
        Me.Tip20.TabStop = True
        Me.Tip20.Text = "20%"
        Me.Tip20.UseVisualStyleBackColor = True
        '
        'Tip25
        '
        Me.Tip25.AutoSize = True
        Me.Tip25.Location = New System.Drawing.Point(14, 94)
        Me.Tip25.Name = "Tip25"
        Me.Tip25.Size = New System.Drawing.Size(54, 20)
        Me.Tip25.TabIndex = 3
        Me.Tip25.TabStop = True
        Me.Tip25.Text = "25%"
        Me.Tip25.UseVisualStyleBackColor = True
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(14, 121)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TotalTextBox.TabIndex = 4
        Me.TotalTextBox.Text = "200"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tip "
        '
        'TipAmount
        '
        Me.TipAmount.AutoSize = True
        Me.TipAmount.Location = New System.Drawing.Point(92, 169)
        Me.TipAmount.Name = "TipAmount"
        Me.TipAmount.Size = New System.Drawing.Size(0, 16)
        Me.TipAmount.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total"
        '
        'TotalAmountText
        '
        Me.TotalAmountText.AutoSize = True
        Me.TotalAmountText.Location = New System.Drawing.Point(92, 201)
        Me.TotalAmountText.Name = "TotalAmountText"
        Me.TotalAmountText.Size = New System.Drawing.Size(0, 16)
        Me.TotalAmountText.TabIndex = 8
        '
        'TaxLabel
        '
        Me.TaxLabel.AutoSize = True
        Me.TaxLabel.Location = New System.Drawing.Point(92, 185)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(0, 16)
        Me.TaxLabel.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tax"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TaxLabel)
        Me.Controls.Add(Me.TotalAmountText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TipAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.Tip25)
        Me.Controls.Add(Me.Tip20)
        Me.Controls.Add(Me.Tip10)
        Me.Controls.Add(Me.Tip5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tip5 As RadioButton
    Friend WithEvents Tip10 As RadioButton
    Friend WithEvents Tip20 As RadioButton
    Friend WithEvents Tip25 As RadioButton
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TipAmount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalAmountText As Label
    Friend WithEvents TaxLabel As Label
    Friend WithEvents Label4 As Label
End Class
