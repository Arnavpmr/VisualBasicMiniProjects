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
        Me.lblNumberOfCopiesID = New System.Windows.Forms.Label()
        Me.lblPricePerCopyID = New System.Windows.Forms.Label()
        Me.lblDisplayPricePerCopy = New System.Windows.Forms.Label()
        Me.lblTotalPriceID = New System.Windows.Forms.Label()
        Me.lblDisplayTotalPrice = New System.Windows.Forms.Label()
        Me.txtCopiesInput = New System.Windows.Forms.TextBox()
        Me.btnCalculatePrices = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumberOfCopiesID
        '
        Me.lblNumberOfCopiesID.AutoSize = True
        Me.lblNumberOfCopiesID.Location = New System.Drawing.Point(51, 79)
        Me.lblNumberOfCopiesID.Name = "lblNumberOfCopiesID"
        Me.lblNumberOfCopiesID.Size = New System.Drawing.Size(140, 13)
        Me.lblNumberOfCopiesID.TabIndex = 0
        Me.lblNumberOfCopiesID.Text = "Enter the number of copies: "
        '
        'lblPricePerCopyID
        '
        Me.lblPricePerCopyID.AutoSize = True
        Me.lblPricePerCopyID.Location = New System.Drawing.Point(51, 190)
        Me.lblPricePerCopyID.Name = "lblPricePerCopyID"
        Me.lblPricePerCopyID.Size = New System.Drawing.Size(97, 13)
        Me.lblPricePerCopyID.TabIndex = 1
        Me.lblPricePerCopyID.Text = "Price per copy is $ "
        '
        'lblDisplayPricePerCopy
        '
        Me.lblDisplayPricePerCopy.AutoSize = True
        Me.lblDisplayPricePerCopy.Location = New System.Drawing.Point(168, 190)
        Me.lblDisplayPricePerCopy.Name = "lblDisplayPricePerCopy"
        Me.lblDisplayPricePerCopy.Size = New System.Drawing.Size(16, 13)
        Me.lblDisplayPricePerCopy.TabIndex = 2
        Me.lblDisplayPricePerCopy.Text = "---"
        '
        'lblTotalPriceID
        '
        Me.lblTotalPriceID.AutoSize = True
        Me.lblTotalPriceID.Location = New System.Drawing.Point(51, 242)
        Me.lblTotalPriceID.Name = "lblTotalPriceID"
        Me.lblTotalPriceID.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalPriceID.TabIndex = 3
        Me.lblTotalPriceID.Text = "     "
        '
        'lblDisplayTotalPrice
        '
        Me.lblDisplayTotalPrice.AutoSize = True
        Me.lblDisplayTotalPrice.Location = New System.Drawing.Point(168, 242)
        Me.lblDisplayTotalPrice.Name = "lblDisplayTotalPrice"
        Me.lblDisplayTotalPrice.Size = New System.Drawing.Size(16, 13)
        Me.lblDisplayTotalPrice.TabIndex = 4
        Me.lblDisplayTotalPrice.Text = "---"
        '
        'txtCopiesInput
        '
        Me.txtCopiesInput.Location = New System.Drawing.Point(219, 79)
        Me.txtCopiesInput.Name = "txtCopiesInput"
        Me.txtCopiesInput.Size = New System.Drawing.Size(100, 20)
        Me.txtCopiesInput.TabIndex = 5
        '
        'btnCalculatePrices
        '
        Me.btnCalculatePrices.Location = New System.Drawing.Point(340, 231)
        Me.btnCalculatePrices.Name = "btnCalculatePrices"
        Me.btnCalculatePrices.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculatePrices.TabIndex = 6
        Me.btnCalculatePrices.Text = "Price"
        Me.btnCalculatePrices.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 286)
        Me.Controls.Add(Me.btnCalculatePrices)
        Me.Controls.Add(Me.txtCopiesInput)
        Me.Controls.Add(Me.lblDisplayTotalPrice)
        Me.Controls.Add(Me.lblTotalPriceID)
        Me.Controls.Add(Me.lblDisplayPricePerCopy)
        Me.Controls.Add(Me.lblPricePerCopyID)
        Me.Controls.Add(Me.lblNumberOfCopiesID)
        Me.Name = "Form1"
        Me.Text = "Printing Prices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumberOfCopiesID As System.Windows.Forms.Label
    Friend WithEvents lblPricePerCopyID As System.Windows.Forms.Label
    Friend WithEvents lblDisplayPricePerCopy As System.Windows.Forms.Label
    Friend WithEvents lblTotalPriceID As System.Windows.Forms.Label
    Friend WithEvents lblDisplayTotalPrice As System.Windows.Forms.Label
    Friend WithEvents txtCopiesInput As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculatePrices As System.Windows.Forms.Button

End Class
