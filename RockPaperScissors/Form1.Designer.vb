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
        Me.grpChooseThrow = New System.Windows.Forms.GroupBox()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.lblWinsID = New System.Windows.Forms.Label()
        Me.lblWinsDisplay = New System.Windows.Forms.Label()
        Me.lblLossesDisplay = New System.Windows.Forms.Label()
        Me.lblLossesID = New System.Windows.Forms.Label()
        Me.lblDrawsDisplay = New System.Windows.Forms.Label()
        Me.lblDrawsID = New System.Windows.Forms.Label()
        Me.btnThrow = New System.Windows.Forms.Button()
        Me.lblResultDisplay = New System.Windows.Forms.Label()
        Me.picComputerThrow = New System.Windows.Forms.PictureBox()
        Me.picYourThrow = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.grpChooseThrow.SuspendLayout()
        CType(Me.picComputerThrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picYourThrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpChooseThrow
        '
        Me.grpChooseThrow.Controls.Add(Me.radScissors)
        Me.grpChooseThrow.Controls.Add(Me.radPaper)
        Me.grpChooseThrow.Controls.Add(Me.radRock)
        Me.grpChooseThrow.Location = New System.Drawing.Point(170, 34)
        Me.grpChooseThrow.Name = "grpChooseThrow"
        Me.grpChooseThrow.Size = New System.Drawing.Size(391, 109)
        Me.grpChooseThrow.TabIndex = 0
        Me.grpChooseThrow.TabStop = False
        Me.grpChooseThrow.Text = "Choose Your Throw"
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(258, 49)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(64, 17)
        Me.radScissors.TabIndex = 2
        Me.radScissors.TabStop = True
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(132, 49)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(53, 17)
        Me.radPaper.TabIndex = 1
        Me.radPaper.TabStop = True
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(16, 49)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(51, 17)
        Me.radRock.TabIndex = 0
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'lblWinsID
        '
        Me.lblWinsID.AutoSize = True
        Me.lblWinsID.Location = New System.Drawing.Point(158, 280)
        Me.lblWinsID.Name = "lblWinsID"
        Me.lblWinsID.Size = New System.Drawing.Size(89, 13)
        Me.lblWinsID.TabIndex = 1
        Me.lblWinsID.Text = "Number of Wins: "
        '
        'lblWinsDisplay
        '
        Me.lblWinsDisplay.AutoSize = True
        Me.lblWinsDisplay.Location = New System.Drawing.Point(268, 280)
        Me.lblWinsDisplay.Name = "lblWinsDisplay"
        Me.lblWinsDisplay.Size = New System.Drawing.Size(18, 13)
        Me.lblWinsDisplay.TabIndex = 2
        Me.lblWinsDisplay.Text = "W"
        '
        'lblLossesDisplay
        '
        Me.lblLossesDisplay.AutoSize = True
        Me.lblLossesDisplay.Location = New System.Drawing.Point(268, 311)
        Me.lblLossesDisplay.Name = "lblLossesDisplay"
        Me.lblLossesDisplay.Size = New System.Drawing.Size(13, 13)
        Me.lblLossesDisplay.TabIndex = 4
        Me.lblLossesDisplay.Text = "L"
        '
        'lblLossesID
        '
        Me.lblLossesID.AutoSize = True
        Me.lblLossesID.Location = New System.Drawing.Point(158, 311)
        Me.lblLossesID.Name = "lblLossesID"
        Me.lblLossesID.Size = New System.Drawing.Size(98, 13)
        Me.lblLossesID.TabIndex = 3
        Me.lblLossesID.Text = "Number of Losses: "
        '
        'lblDrawsDisplay
        '
        Me.lblDrawsDisplay.AutoSize = True
        Me.lblDrawsDisplay.Location = New System.Drawing.Point(268, 347)
        Me.lblDrawsDisplay.Name = "lblDrawsDisplay"
        Me.lblDrawsDisplay.Size = New System.Drawing.Size(15, 13)
        Me.lblDrawsDisplay.TabIndex = 6
        Me.lblDrawsDisplay.Text = "D"
        '
        'lblDrawsID
        '
        Me.lblDrawsID.AutoSize = True
        Me.lblDrawsID.Location = New System.Drawing.Point(158, 347)
        Me.lblDrawsID.Name = "lblDrawsID"
        Me.lblDrawsID.Size = New System.Drawing.Size(95, 13)
        Me.lblDrawsID.TabIndex = 5
        Me.lblDrawsID.Text = "Number of Draws: "
        '
        'btnThrow
        '
        Me.btnThrow.Location = New System.Drawing.Point(400, 342)
        Me.btnThrow.Name = "btnThrow"
        Me.btnThrow.Size = New System.Drawing.Size(75, 23)
        Me.btnThrow.TabIndex = 7
        Me.btnThrow.Text = "Throw"
        Me.btnThrow.UseVisualStyleBackColor = True
        '
        'lblResultDisplay
        '
        Me.lblResultDisplay.AutoSize = True
        Me.lblResultDisplay.Location = New System.Drawing.Point(412, 280)
        Me.lblResultDisplay.Name = "lblResultDisplay"
        Me.lblResultDisplay.Size = New System.Drawing.Size(16, 13)
        Me.lblResultDisplay.TabIndex = 8
        Me.lblResultDisplay.Text = "---"
        '
        'picComputerThrow
        '
        Me.picComputerThrow.Location = New System.Drawing.Point(21, 34)
        Me.picComputerThrow.Name = "picComputerThrow"
        Me.picComputerThrow.Size = New System.Drawing.Size(132, 114)
        Me.picComputerThrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picComputerThrow.TabIndex = 9
        Me.picComputerThrow.TabStop = False
        '
        'picYourThrow
        '
        Me.picYourThrow.Location = New System.Drawing.Point(577, 34)
        Me.picYourThrow.Name = "picYourThrow"
        Me.picYourThrow.Size = New System.Drawing.Size(120, 120)
        Me.picYourThrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picYourThrow.TabIndex = 10
        Me.picYourThrow.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Computer Throw"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(612, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Your Throw"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 477)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picYourThrow)
        Me.Controls.Add(Me.picComputerThrow)
        Me.Controls.Add(Me.lblResultDisplay)
        Me.Controls.Add(Me.btnThrow)
        Me.Controls.Add(Me.lblDrawsDisplay)
        Me.Controls.Add(Me.lblDrawsID)
        Me.Controls.Add(Me.lblLossesDisplay)
        Me.Controls.Add(Me.lblLossesID)
        Me.Controls.Add(Me.lblWinsDisplay)
        Me.Controls.Add(Me.lblWinsID)
        Me.Controls.Add(Me.grpChooseThrow)
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors With Pictures"
        Me.grpChooseThrow.ResumeLayout(False)
        Me.grpChooseThrow.PerformLayout()
        CType(Me.picComputerThrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picYourThrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpChooseThrow As System.Windows.Forms.GroupBox
    Friend WithEvents radScissors As System.Windows.Forms.RadioButton
    Friend WithEvents radPaper As System.Windows.Forms.RadioButton
    Friend WithEvents radRock As System.Windows.Forms.RadioButton
    Friend WithEvents lblWinsID As System.Windows.Forms.Label
    Friend WithEvents lblWinsDisplay As System.Windows.Forms.Label
    Friend WithEvents lblLossesDisplay As System.Windows.Forms.Label
    Friend WithEvents lblLossesID As System.Windows.Forms.Label
    Friend WithEvents lblDrawsDisplay As System.Windows.Forms.Label
    Friend WithEvents lblDrawsID As System.Windows.Forms.Label
    Friend WithEvents btnThrow As System.Windows.Forms.Button
    Friend WithEvents lblResultDisplay As System.Windows.Forms.Label
    Friend WithEvents picComputerThrow As System.Windows.Forms.PictureBox
    Friend WithEvents picYourThrow As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog

End Class
