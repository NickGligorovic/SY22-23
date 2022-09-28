<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ShoppingCartLabel = New System.Windows.Forms.Label()
        Me.BlueShoppingCartLabel = New System.Windows.Forms.Label()
        Me.RedShoppingCartLabel = New System.Windows.Forms.Label()
        Me.PinkShoppingCartLabel = New System.Windows.Forms.Label()
        Me.PurplesShoppingCartLabel = New System.Windows.Forms.Label()
        Me.OrangeShoppingCartLabel = New System.Windows.Forms.Label()
        Me.ProceedToCheckoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShoppingCartLabel
        '
        Me.ShoppingCartLabel.AutoSize = True
        Me.ShoppingCartLabel.Font = New System.Drawing.Font("Papyrus", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShoppingCartLabel.Location = New System.Drawing.Point(267, 54)
        Me.ShoppingCartLabel.Name = "ShoppingCartLabel"
        Me.ShoppingCartLabel.Size = New System.Drawing.Size(221, 44)
        Me.ShoppingCartLabel.TabIndex = 0
        Me.ShoppingCartLabel.Text = "Shopping Cart"
        '
        'BlueShoppingCartLabel
        '
        Me.BlueShoppingCartLabel.AutoSize = True
        Me.BlueShoppingCartLabel.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueShoppingCartLabel.Location = New System.Drawing.Point(101, 123)
        Me.BlueShoppingCartLabel.Name = "BlueShoppingCartLabel"
        Me.BlueShoppingCartLabel.Size = New System.Drawing.Size(67, 31)
        Me.BlueShoppingCartLabel.TabIndex = 1
        Me.BlueShoppingCartLabel.Text = "Blue "
        '
        'RedShoppingCartLabel
        '
        Me.RedShoppingCartLabel.AutoSize = True
        Me.RedShoppingCartLabel.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedShoppingCartLabel.Location = New System.Drawing.Point(101, 174)
        Me.RedShoppingCartLabel.Name = "RedShoppingCartLabel"
        Me.RedShoppingCartLabel.Size = New System.Drawing.Size(54, 31)
        Me.RedShoppingCartLabel.TabIndex = 2
        Me.RedShoppingCartLabel.Text = "Red"
        '
        'PinkShoppingCartLabel
        '
        Me.PinkShoppingCartLabel.AutoSize = True
        Me.PinkShoppingCartLabel.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PinkShoppingCartLabel.Location = New System.Drawing.Point(101, 223)
        Me.PinkShoppingCartLabel.Name = "PinkShoppingCartLabel"
        Me.PinkShoppingCartLabel.Size = New System.Drawing.Size(56, 31)
        Me.PinkShoppingCartLabel.TabIndex = 3
        Me.PinkShoppingCartLabel.Text = "Pink"
        '
        'PurplesShoppingCartLabel
        '
        Me.PurplesShoppingCartLabel.AutoSize = True
        Me.PurplesShoppingCartLabel.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurplesShoppingCartLabel.Location = New System.Drawing.Point(101, 278)
        Me.PurplesShoppingCartLabel.Name = "PurplesShoppingCartLabel"
        Me.PurplesShoppingCartLabel.Size = New System.Drawing.Size(75, 31)
        Me.PurplesShoppingCartLabel.TabIndex = 4
        Me.PurplesShoppingCartLabel.Text = "Purple"
        '
        'OrangeShoppingCartLabel
        '
        Me.OrangeShoppingCartLabel.AutoSize = True
        Me.OrangeShoppingCartLabel.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrangeShoppingCartLabel.Location = New System.Drawing.Point(101, 330)
        Me.OrangeShoppingCartLabel.Name = "OrangeShoppingCartLabel"
        Me.OrangeShoppingCartLabel.Size = New System.Drawing.Size(91, 31)
        Me.OrangeShoppingCartLabel.TabIndex = 5
        Me.OrangeShoppingCartLabel.Text = "Orange"
        '
        'ProceedToCheckoutButton
        '
        Me.ProceedToCheckoutButton.Location = New System.Drawing.Point(638, 282)
        Me.ProceedToCheckoutButton.Name = "ProceedToCheckoutButton"
        Me.ProceedToCheckoutButton.Size = New System.Drawing.Size(139, 128)
        Me.ProceedToCheckoutButton.TabIndex = 6
        Me.ProceedToCheckoutButton.Text = "Checkout"
        Me.ProceedToCheckoutButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProceedToCheckoutButton)
        Me.Controls.Add(Me.OrangeShoppingCartLabel)
        Me.Controls.Add(Me.PurplesShoppingCartLabel)
        Me.Controls.Add(Me.PinkShoppingCartLabel)
        Me.Controls.Add(Me.RedShoppingCartLabel)
        Me.Controls.Add(Me.BlueShoppingCartLabel)
        Me.Controls.Add(Me.ShoppingCartLabel)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShoppingCartLabel As Label
    Friend WithEvents BlueShoppingCartLabel As Label
    Friend WithEvents RedShoppingCartLabel As Label
    Friend WithEvents PinkShoppingCartLabel As Label
    Friend WithEvents PurplesShoppingCartLabel As Label
    Friend WithEvents OrangeShoppingCartLabel As Label
    Friend WithEvents ProceedToCheckoutButton As Button
End Class
