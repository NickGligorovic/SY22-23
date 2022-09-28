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
        Me.Form2Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Form3Button = New System.Windows.Forms.Button()
        Me.Form3Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Form2Button
        '
        Me.Form2Button.Location = New System.Drawing.Point(246, 204)
        Me.Form2Button.Name = "Form2Button"
        Me.Form2Button.Size = New System.Drawing.Size(75, 23)
        Me.Form2Button.TabIndex = 0
        Me.Form2Button.Text = "Form2"
        Me.Form2Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Form3Button
        '
        Me.Form3Button.Location = New System.Drawing.Point(514, 199)
        Me.Form3Button.Name = "Form3Button"
        Me.Form3Button.Size = New System.Drawing.Size(75, 23)
        Me.Form3Button.TabIndex = 2
        Me.Form3Button.Text = "Form3"
        Me.Form3Button.UseVisualStyleBackColor = True
        '
        'Form3Label
        '
        Me.Form3Label.AutoSize = True
        Me.Form3Label.Location = New System.Drawing.Point(542, 317)
        Me.Form3Label.Name = "Form3Label"
        Me.Form3Label.Size = New System.Drawing.Size(48, 16)
        Me.Form3Label.TabIndex = 3
        Me.Form3Label.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Form3Label)
        Me.Controls.Add(Me.Form3Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Form2Button)
        Me.Name = "Form1"
        Me.Text = "MultiForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Form2Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Form3Button As Button
    Friend WithEvents Form3Label As Label
End Class
