Public Class Form1
    'Arnav Marchareddy
    'Calculations
    '10/18


    Private Sub calculateExpression1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression1.Click
        Me.lblAnswer1.Text = 5 + 2 ^ 3
    End Sub

    Private Sub calculateExpression2(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression2.Click
        Me.lblAnswer2.Text = 4 / 2 + 5
    End Sub

    Private Sub calculateExpression3(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression3.Click
        Me.lblAnswer3.Text = 3 + 4 * 2
    End Sub

    Private Sub calculateExpression4(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression4.Click
        Me.lblAnswer4.Text = 7 - 3 + 2
    End Sub

    Private Sub calculateExpression5(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression5.Click
        Me.lblAnswer5.Text = 13 \ 4 + 1
    End Sub

    Private Sub calculateExpression6(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression6.Click
        Me.lblAnswer6.Text = 13 Mod 4 - 3
    End Sub

    Private Sub calculateExpression7(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression7.Click
        Me.lblAnswer7.Text = Math.PI
    End Sub

    Private Sub calculateExpression8(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression8.Click
        Me.lblAnswer8.Text = Math.Abs(-6)
    End Sub

    Private Sub calculateExpression9(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpression9.Click
        Me.lblAnswer9.Text = Math.Sign(-5)
    End Sub
End Class
