Public Class Form1
    'Arnav Marchareddy
    '11/27/2018
    'Printing Prices

    Private Sub clickToCalculatePrices(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculatePrices.Click
        Dim pricePerCopy, totalPrice As Single
        Dim numberOfCopies As Single = Val(Me.txtCopiesInput.Text)

        If numberOfCopies >= 1000 Then
            pricePerCopy = 0.25
        ElseIf numberOfCopies >= 750 Then
            pricePerCopy = 0.27
        ElseIf numberOfCopies >= 500 Then
            pricePerCopy = 0.28
        ElseIf numberOfCopies > 0 Then
            pricePerCopy = 0.3
        Else
            pricePerCopy = 0
        End If

        totalPrice = pricePerCopy * numberOfCopies

        Me.lblDisplayPricePerCopy.Text = FormatCurrency(pricePerCopy)
        Me.lblDisplayTotalPrice.Text = FormatCurrency(totalPrice)
    End Sub

    Private Sub clearLabelWhenInputChanges(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCopiesInput.TextChanged
        Me.lblDisplayTotalPrice.Text = ""
        Me.lblDisplayPricePerCopy.Text = ""
    End Sub
End Class
