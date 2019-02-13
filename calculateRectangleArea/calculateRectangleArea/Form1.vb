Public Class Form1
    'Arnav Marchareddy
    'CalculateRectangleArea
    '10/24

    Private Sub clearDisplayWhenInputLengthChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInputLength.TextChanged
        Me.lblDisplayArea.Text = ""
        Me.lblDisplayPerimeter.Text = ""
    End Sub

    Private Sub clearDisplayWhenInputWidthChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInputWidth.TextChanged
        Me.lblDisplayArea.Text = ""
        Me.lblDisplayPerimeter.Text = ""
    End Sub

    Private Sub calculateArea(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculateArea.Click
        Dim area, length, width, perimeter As Double

        length = Val(Me.txtInputLength.Text)
        width = Val(Me.txtInputWidth.Text)
        area = length * width
        perimeter = (2 * length) + (2 * width)

        Me.lblDisplayArea.Text = "Area = " + area.ToString()
        Me.lblDisplayPerimeter.Text = "Perimeter = " + perimeter.ToString()
    End Sub
End Class
