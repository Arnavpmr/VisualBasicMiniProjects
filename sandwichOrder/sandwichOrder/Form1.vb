Public Class Form1
    'Arnav Marchareddy
    '12/5
    'Sandwich Order


    Private Sub calculateTotal(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlaceOrder.Click
        Dim totalPrice As Single
        Dim userResponse As Integer

        If radSmall.Checked = True Then
            totalPrice += 2.5
        else 
        totalPrice += 4
        End If

        If chkCheese.Checked = True Then
            totalPrice += 0.5
        End If

        If chkLettuce.Checked = True Then
            totalPrice += 0.1
        End If

        If chkOnion.Checked = True Then
            totalPrice += 0.1
        End If

        If chkTomato.Checked = True Then
            totalPrice += 0.25
        End If

        userResponse = MessageBox.Show("Would you like to make your order a combo?", "Combo Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If userResponse = DialogResult.Yes Then
            MessageBox.Show("Great, we will add 1.75 to your total")
            totalPrice += 1.75
        Else
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            userResponse = MessageBox.Show("Please Say Yes", "Begging", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        End If

        Me.lblPriceDisplay.Text = FormatCurrency(totalPrice)

    End Sub

    Private Sub clearDisplay(ByVal sender As Object, ByVal e As System.EventArgs) Handles radSmall.CheckedChanged, radLarge.CheckedChanged, chkCheese.CheckedChanged, chkLettuce.CheckedChanged, chkMayonnaise.CheckedChanged, chkMustard.CheckedChanged, chkOnion.CheckedChanged, chkTomato.CheckedChanged
        Me.lblPriceDisplay.Text = ""
    End Sub
End Class
