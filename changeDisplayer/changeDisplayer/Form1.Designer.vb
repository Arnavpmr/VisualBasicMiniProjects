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
        Me.lblDirectionsID = New System.Windows.Forms.Label()
        Me.txtInputChange = New System.Windows.Forms.TextBox()
        Me.lblQuartersID = New System.Windows.Forms.Label()
        Me.lblDimesID = New System.Windows.Forms.Label()
        Me.lblNickelsID = New System.Windows.Forms.Label()
        Me.btnCalculateChange = New System.Windows.Forms.Button()
        Me.lblPenniesID = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDirectionsID
        '
        Me.lblDirectionsID.AutoSize = True
        Me.lblDirectionsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirectionsID.Location = New System.Drawing.Point(38, 40)
        Me.lblDirectionsID.Name = "lblDirectionsID"
        Me.lblDirectionsID.Size = New System.Drawing.Size(129, 13)
        Me.lblDirectionsID.TabIndex = 0
        Me.lblDirectionsID.Text = "Enter the change in cents"
        '
        'txtInputChange
        '
        Me.txtInputChange.Location = New System.Drawing.Point(234, 40)
        Me.txtInputChange.Name = "txtInputChange"
        Me.txtInputChange.Size = New System.Drawing.Size(100, 20)
        Me.txtInputChange.TabIndex = 1
        '
        'lblQuartersID
        '
        Me.lblQuartersID.AutoSize = True
        Me.lblQuartersID.Location = New System.Drawing.Point(41, 86)
        Me.lblQuartersID.Name = "lblQuartersID"
        Me.lblQuartersID.Size = New System.Drawing.Size(53, 13)
        Me.lblQuartersID.TabIndex = 2
        Me.lblQuartersID.Text = "Quarters: "
        '
        'lblDimesID
        '
        Me.lblDimesID.AutoSize = True
        Me.lblDimesID.Location = New System.Drawing.Point(41, 124)
        Me.lblDimesID.Name = "lblDimesID"
        Me.lblDimesID.Size = New System.Drawing.Size(42, 13)
        Me.lblDimesID.TabIndex = 3
        Me.lblDimesID.Text = "Dimes: "
        '
        'lblNickelsID
        '
        Me.lblNickelsID.AutoSize = True
        Me.lblNickelsID.Location = New System.Drawing.Point(41, 160)
        Me.lblNickelsID.Name = "lblNickelsID"
        Me.lblNickelsID.Size = New System.Drawing.Size(48, 13)
        Me.lblNickelsID.TabIndex = 4
        Me.lblNickelsID.Text = "Nickels: "
        '
        'btnCalculateChange
        '
        Me.btnCalculateChange.Location = New System.Drawing.Point(243, 188)
        Me.btnCalculateChange.Name = "btnCalculateChange"
        Me.btnCalculateChange.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculateChange.TabIndex = 5
        Me.btnCalculateChange.Text = "Coins"
        Me.btnCalculateChange.UseVisualStyleBackColor = True
        '
        'lblPenniesID
        '
        Me.lblPenniesID.AutoSize = True
        Me.lblPenniesID.Location = New System.Drawing.Point(41, 198)
        Me.lblPenniesID.Name = "lblPenniesID"
        Me.lblPenniesID.Size = New System.Drawing.Size(51, 13)
        Me.lblPenniesID.TabIndex = 6
        Me.lblPenniesID.Text = "Pennies: "
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(101, 86)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(16, 13)
        Me.lblQuarters.TabIndex = 7
        Me.lblQuarters.Text = "---"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(101, 124)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(16, 13)
        Me.lblDimes.TabIndex = 8
        Me.lblDimes.Text = "---"
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Location = New System.Drawing.Point(101, 160)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(16, 13)
        Me.lblNickels.TabIndex = 9
        Me.lblNickels.Text = "---"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(101, 198)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(16, 13)
        Me.lblPennies.TabIndex = 10
        Me.lblPennies.Text = "---"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 261)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblPenniesID)
        Me.Controls.Add(Me.btnCalculateChange)
        Me.Controls.Add(Me.lblNickelsID)
        Me.Controls.Add(Me.lblDimesID)
        Me.Controls.Add(Me.lblQuartersID)
        Me.Controls.Add(Me.txtInputChange)
        Me.Controls.Add(Me.lblDirectionsID)
        Me.Name = "Form1"
        Me.Text = "Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDirectionsID As System.Windows.Forms.Label
    Friend WithEvents txtInputChange As System.Windows.Forms.TextBox
    Friend WithEvents lblQuartersID As System.Windows.Forms.Label
    Friend WithEvents lblDimesID As System.Windows.Forms.Label
    Friend WithEvents lblNickelsID As System.Windows.Forms.Label
    Friend WithEvents btnCalculateChange As System.Windows.Forms.Button
    Friend WithEvents lblPenniesID As System.Windows.Forms.Label
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label

End Class
