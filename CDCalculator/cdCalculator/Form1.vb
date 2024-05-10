Public Class Form1
    'Arnav Marchareddy
    'CD Calculator
    '2/6/19

    Private Sub clickToCalculateYears(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculateYears.Click
        Dim initialInvestment, endingValue, interest As Single
        Dim years As Integer

        initialInvestment = Val(Me.txtInitialInvestment.Text)
        endingValue = Val(Me.txtEndingValue.Text)
        interest = Val(Me.txtAnnualInterest.Text) / 100

        If endingValue < initialInvestment Then
            MessageBox.Show("Error", "You made an Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Do Until initialInvestment >= endingValue
                initialInvestment = initialInvestment + (initialInvestment * interest)
                years += 1
            Loop
            Me.lblAnswerDisplay.Text = "The number of years is " & years
        End If

    End Sub

    Private Sub clearDisplay(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInitialInvestment.TextChanged, txtAnnualInterest.TextChanged, txtEndingValue.TextChanged
        Me.lblAnswerDisplay.Text = Nothing
    End Sub

End Class
