Public Class Form1

    'Arnav Marchareddy
    '10/26
    'Change

    Private Sub calculateWhenClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculateChange.Click
        Dim inputChange As Integer

        inputChange = Me.txtInputChange.Text

        Me.lblQuarters.Text = inputChange \ 25
        inputChange = inputChange Mod 25
        Me.lblDimes.Text = inputChange \ 10
        inputChange = inputChange Mod 10
        Me.lblNickels.Text = inputChange \ 5
        inputChange = inputChange Mod 5

        Me.lblPennies.Text = inputChange
    End Sub

    Private Sub clearDisplay(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInputChange.TextChanged
        Me.lblDimes.Text = ""
        Me.lblQuarters.Text = ""
        Me.lblNickels.Text = ""
        Me.lblPennies.Text = ""
    End Sub
End Class
