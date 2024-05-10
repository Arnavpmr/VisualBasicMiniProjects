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
        Me.grpSelectSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpToppingsSelect = New System.Windows.Forms.GroupBox()
        Me.chkMayonnaise = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkOnion = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.lblTotalPriceID = New System.Windows.Forms.Label()
        Me.lblPriceDisplay = New System.Windows.Forms.Label()
        Me.grpSelectSize.SuspendLayout()
        Me.grpToppingsSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSelectSize
        '
        Me.grpSelectSize.Controls.Add(Me.radLarge)
        Me.grpSelectSize.Controls.Add(Me.radSmall)
        Me.grpSelectSize.Location = New System.Drawing.Point(54, 48)
        Me.grpSelectSize.Name = "grpSelectSize"
        Me.grpSelectSize.Size = New System.Drawing.Size(226, 87)
        Me.grpSelectSize.TabIndex = 0
        Me.grpSelectSize.TabStop = False
        Me.grpSelectSize.Text = "Select a Size: "
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(121, 48)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(52, 17)
        Me.radLarge.TabIndex = 1
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(7, 48)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(50, 17)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpToppingsSelect
        '
        Me.grpToppingsSelect.Controls.Add(Me.chkMayonnaise)
        Me.grpToppingsSelect.Controls.Add(Me.chkCheese)
        Me.grpToppingsSelect.Controls.Add(Me.chkOnion)
        Me.grpToppingsSelect.Controls.Add(Me.chkMustard)
        Me.grpToppingsSelect.Controls.Add(Me.chkTomato)
        Me.grpToppingsSelect.Controls.Add(Me.chkLettuce)
        Me.grpToppingsSelect.Location = New System.Drawing.Point(54, 229)
        Me.grpToppingsSelect.Name = "grpToppingsSelect"
        Me.grpToppingsSelect.Size = New System.Drawing.Size(306, 124)
        Me.grpToppingsSelect.TabIndex = 1
        Me.grpToppingsSelect.TabStop = False
        Me.grpToppingsSelect.Text = "Toppings"
        '
        'chkMayonnaise
        '
        Me.chkMayonnaise.AutoSize = True
        Me.chkMayonnaise.Location = New System.Drawing.Point(212, 85)
        Me.chkMayonnaise.Name = "chkMayonnaise"
        Me.chkMayonnaise.Size = New System.Drawing.Size(83, 17)
        Me.chkMayonnaise.TabIndex = 5
        Me.chkMayonnaise.Text = "Mayonnaise"
        Me.chkMayonnaise.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(111, 85)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 4
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkOnion
        '
        Me.chkOnion.AutoSize = True
        Me.chkOnion.Location = New System.Drawing.Point(24, 85)
        Me.chkOnion.Name = "chkOnion"
        Me.chkOnion.Size = New System.Drawing.Size(54, 17)
        Me.chkOnion.TabIndex = 3
        Me.chkOnion.Text = "Onion"
        Me.chkOnion.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(212, 33)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(64, 17)
        Me.chkMustard.TabIndex = 2
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(111, 33)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 1
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(24, 33)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 0
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(41, 410)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(127, 59)
        Me.btnPlaceOrder.TabIndex = 2
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'lblTotalPriceID
        '
        Me.lblTotalPriceID.AutoSize = True
        Me.lblTotalPriceID.Location = New System.Drawing.Point(207, 433)
        Me.lblTotalPriceID.Name = "lblTotalPriceID"
        Me.lblTotalPriceID.Size = New System.Drawing.Size(64, 13)
        Me.lblTotalPriceID.TabIndex = 3
        Me.lblTotalPriceID.Text = "Total Price: "
        '
        'lblPriceDisplay
        '
        Me.lblPriceDisplay.AutoSize = True
        Me.lblPriceDisplay.Location = New System.Drawing.Point(264, 433)
        Me.lblPriceDisplay.Name = "lblPriceDisplay"
        Me.lblPriceDisplay.Size = New System.Drawing.Size(16, 13)
        Me.lblPriceDisplay.TabIndex = 4
        Me.lblPriceDisplay.Text = "---"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 499)
        Me.Controls.Add(Me.lblPriceDisplay)
        Me.Controls.Add(Me.lblTotalPriceID)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.grpToppingsSelect)
        Me.Controls.Add(Me.grpSelectSize)
        Me.Name = "Form1"
        Me.Text = "Sandwich Order"
        Me.grpSelectSize.ResumeLayout(False)
        Me.grpSelectSize.PerformLayout()
        Me.grpToppingsSelect.ResumeLayout(False)
        Me.grpToppingsSelect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSelectSize As System.Windows.Forms.GroupBox
    Friend WithEvents radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents radSmall As System.Windows.Forms.RadioButton
    Friend WithEvents grpToppingsSelect As System.Windows.Forms.GroupBox
    Friend WithEvents chkMayonnaise As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnion As System.Windows.Forms.CheckBox
    Friend WithEvents chkMustard As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents btnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents lblTotalPriceID As System.Windows.Forms.Label
    Friend WithEvents lblPriceDisplay As System.Windows.Forms.Label

End Class
