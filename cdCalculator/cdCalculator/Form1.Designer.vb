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
        Me.lblInitialInvestmentID = New System.Windows.Forms.Label()
        Me.lblEndingValueID = New System.Windows.Forms.Label()
        Me.lblAnnualnterestID = New System.Windows.Forms.Label()
        Me.lblAnswerDisplay = New System.Windows.Forms.Label()
        Me.btnCalculateYears = New System.Windows.Forms.Button()
        Me.txtInitialInvestment = New System.Windows.Forms.TextBox()
        Me.txtAnnualInterest = New System.Windows.Forms.TextBox()
        Me.txtEndingValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblInitialInvestmentID
        '
        Me.lblInitialInvestmentID.AutoSize = True
        Me.lblInitialInvestmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitialInvestmentID.Location = New System.Drawing.Point(43, 49)
        Me.lblInitialInvestmentID.Name = "lblInitialInvestmentID"
        Me.lblInitialInvestmentID.Size = New System.Drawing.Size(166, 18)
        Me.lblInitialInvestmentID.TabIndex = 0
        Me.lblInitialInvestmentID.Text = "The initial investment ($)"
        '
        'lblEndingValueID
        '
        Me.lblEndingValueID.AutoSize = True
        Me.lblEndingValueID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndingValueID.Location = New System.Drawing.Point(43, 115)
        Me.lblEndingValueID.Name = "lblEndingValueID"
        Me.lblEndingValueID.Size = New System.Drawing.Size(150, 18)
        Me.lblEndingValueID.TabIndex = 1
        Me.lblEndingValueID.Text = "Enter ending value ($)"
        '
        'lblAnnualnterestID
        '
        Me.lblAnnualnterestID.AutoSize = True
        Me.lblAnnualnterestID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualnterestID.Location = New System.Drawing.Point(43, 85)
        Me.lblAnnualnterestID.Name = "lblAnnualnterestID"
        Me.lblAnnualnterestID.Size = New System.Drawing.Size(198, 18)
        Me.lblAnnualnterestID.TabIndex = 2
        Me.lblAnnualnterestID.Text = "Enter annual interest rate (%)"
        '
        'lblAnswerDisplay
        '
        Me.lblAnswerDisplay.AutoSize = True
        Me.lblAnswerDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerDisplay.Location = New System.Drawing.Point(95, 191)
        Me.lblAnswerDisplay.Name = "lblAnswerDisplay"
        Me.lblAnswerDisplay.Size = New System.Drawing.Size(23, 18)
        Me.lblAnswerDisplay.TabIndex = 3
        Me.lblAnswerDisplay.Text = "---"
        '
        'btnCalculateYears
        '
        Me.btnCalculateYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateYears.Location = New System.Drawing.Point(161, 239)
        Me.btnCalculateYears.Name = "btnCalculateYears"
        Me.btnCalculateYears.Size = New System.Drawing.Size(112, 54)
        Me.btnCalculateYears.TabIndex = 4
        Me.btnCalculateYears.Text = "Calculate Years"
        Me.btnCalculateYears.UseVisualStyleBackColor = True
        '
        'txtInitialInvestment
        '
        Me.txtInitialInvestment.Location = New System.Drawing.Point(293, 49)
        Me.txtInitialInvestment.Name = "txtInitialInvestment"
        Me.txtInitialInvestment.Size = New System.Drawing.Size(100, 20)
        Me.txtInitialInvestment.TabIndex = 5
        '
        'txtAnnualInterest
        '
        Me.txtAnnualInterest.Location = New System.Drawing.Point(294, 78)
        Me.txtAnnualInterest.Name = "txtAnnualInterest"
        Me.txtAnnualInterest.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnualInterest.TabIndex = 6
        '
        'txtEndingValue
        '
        Me.txtEndingValue.Location = New System.Drawing.Point(294, 112)
        Me.txtEndingValue.Name = "txtEndingValue"
        Me.txtEndingValue.Size = New System.Drawing.Size(100, 20)
        Me.txtEndingValue.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 345)
        Me.Controls.Add(Me.txtEndingValue)
        Me.Controls.Add(Me.txtAnnualInterest)
        Me.Controls.Add(Me.txtInitialInvestment)
        Me.Controls.Add(Me.btnCalculateYears)
        Me.Controls.Add(Me.lblAnswerDisplay)
        Me.Controls.Add(Me.lblAnnualnterestID)
        Me.Controls.Add(Me.lblEndingValueID)
        Me.Controls.Add(Me.lblInitialInvestmentID)
        Me.Name = "Form1"
        Me.Text = "CD Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInitialInvestmentID As System.Windows.Forms.Label
    Friend WithEvents lblEndingValueID As System.Windows.Forms.Label
    Friend WithEvents lblAnnualnterestID As System.Windows.Forms.Label
    Friend WithEvents lblAnswerDisplay As System.Windows.Forms.Label
    Friend WithEvents btnCalculateYears As System.Windows.Forms.Button
    Friend WithEvents txtInitialInvestment As System.Windows.Forms.TextBox
    Friend WithEvents txtAnnualInterest As System.Windows.Forms.TextBox
    Friend WithEvents txtEndingValue As System.Windows.Forms.TextBox

End Class
