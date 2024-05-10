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
        Me.lblDirectionsLengthID = New System.Windows.Forms.Label()
        Me.lblDirectionsWidthID = New System.Windows.Forms.Label()
        Me.txtInputLength = New System.Windows.Forms.TextBox()
        Me.txtInputWidth = New System.Windows.Forms.TextBox()
        Me.btnCalculateArea = New System.Windows.Forms.Button()
        Me.lblDisplayArea = New System.Windows.Forms.Label()
        Me.lblDisplayPerimeter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDirectionsLengthID
        '
        Me.lblDirectionsLengthID.AutoSize = True
        Me.lblDirectionsLengthID.Location = New System.Drawing.Point(72, 22)
        Me.lblDirectionsLengthID.Name = "lblDirectionsLengthID"
        Me.lblDirectionsLengthID.Size = New System.Drawing.Size(137, 13)
        Me.lblDirectionsLengthID.TabIndex = 0
        Me.lblDirectionsLengthID.Text = "Enter the Rectangle length:"
        '
        'lblDirectionsWidthID
        '
        Me.lblDirectionsWidthID.AutoSize = True
        Me.lblDirectionsWidthID.Location = New System.Drawing.Point(72, 74)
        Me.lblDirectionsWidthID.Name = "lblDirectionsWidthID"
        Me.lblDirectionsWidthID.Size = New System.Drawing.Size(133, 13)
        Me.lblDirectionsWidthID.TabIndex = 1
        Me.lblDirectionsWidthID.Text = "Enter the Rectangle width:"
        '
        'txtInputLength
        '
        Me.txtInputLength.Location = New System.Drawing.Point(290, 19)
        Me.txtInputLength.Name = "txtInputLength"
        Me.txtInputLength.Size = New System.Drawing.Size(100, 20)
        Me.txtInputLength.TabIndex = 2
        '
        'txtInputWidth
        '
        Me.txtInputWidth.Location = New System.Drawing.Point(290, 67)
        Me.txtInputWidth.Name = "txtInputWidth"
        Me.txtInputWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtInputWidth.TabIndex = 3
        '
        'btnCalculateArea
        '
        Me.btnCalculateArea.Location = New System.Drawing.Point(196, 213)
        Me.btnCalculateArea.Name = "btnCalculateArea"
        Me.btnCalculateArea.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculateArea.TabIndex = 4
        Me.btnCalculateArea.Text = "Calculate Area"
        Me.btnCalculateArea.UseVisualStyleBackColor = True
        '
        'lblDisplayArea
        '
        Me.lblDisplayArea.AutoSize = True
        Me.lblDisplayArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayArea.Location = New System.Drawing.Point(70, 120)
        Me.lblDisplayArea.Name = "lblDisplayArea"
        Me.lblDisplayArea.Size = New System.Drawing.Size(36, 25)
        Me.lblDisplayArea.TabIndex = 5
        Me.lblDisplayArea.Text = "---"
        '
        'lblDisplayPerimeter
        '
        Me.lblDisplayPerimeter.AutoSize = True
        Me.lblDisplayPerimeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayPerimeter.Location = New System.Drawing.Point(70, 172)
        Me.lblDisplayPerimeter.Name = "lblDisplayPerimeter"
        Me.lblDisplayPerimeter.Size = New System.Drawing.Size(36, 25)
        Me.lblDisplayPerimeter.TabIndex = 6
        Me.lblDisplayPerimeter.Text = "---"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 248)
        Me.Controls.Add(Me.lblDisplayPerimeter)
        Me.Controls.Add(Me.lblDisplayArea)
        Me.Controls.Add(Me.btnCalculateArea)
        Me.Controls.Add(Me.txtInputWidth)
        Me.Controls.Add(Me.txtInputLength)
        Me.Controls.Add(Me.lblDirectionsWidthID)
        Me.Controls.Add(Me.lblDirectionsLengthID)
        Me.Name = "Form1"
        Me.Text = "Rectangle Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDirectionsLengthID As System.Windows.Forms.Label
    Friend WithEvents lblDirectionsWidthID As System.Windows.Forms.Label
    Friend WithEvents txtInputLength As System.Windows.Forms.TextBox
    Friend WithEvents txtInputWidth As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculateArea As System.Windows.Forms.Button
    Friend WithEvents lblDisplayArea As System.Windows.Forms.Label
    Friend WithEvents lblDisplayPerimeter As System.Windows.Forms.Label

End Class
