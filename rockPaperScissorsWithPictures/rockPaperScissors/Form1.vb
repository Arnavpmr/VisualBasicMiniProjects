Public Class Form1

    'Arnav Marchareddy
    'Rock Paper Scissors With Pictures
    '1/8/19

    Private numofWins, numofLosses, numofDraws As Integer

    Private Sub setRandomNumber(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Randomize()

    End Sub

    Private Sub clickForOutcome(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThrow.Click

        Dim computerThrow As Integer = Int(3 * Rnd() + 1)

        Const ROCK As Integer = 1
        Const PAPER As Integer = 2
        Const SCISSORS As Integer = 3

        If computerThrow = ROCK Then

            Me.picComputerThrow.Image = My.Resources.rock

            If Me.radPaper.Checked = True Then

                Me.lblResultDisplay.Text = "You win, the computer threw rock"
                numofLosses = numofLosses + 1

            ElseIf Me.radScissors.Checked = True Then

                Me.lblResultDisplay.Text = "You lose, the computer threw rock"
                numofWins = numofWins + 1

            Else

                Me.lblResultDisplay.Text = "Its a draw, the computer also threw rock"
                numofDraws = numofDraws + 1

            End If
        ElseIf computerThrow = PAPER Then

            Me.picComputerThrow.Image = My.Resources.paper

            If Me.radScissors.Checked = True Then

                Me.lblResultDisplay.Text = "You win, the computer threw paper"
                numofLosses = numofLosses + 1

            ElseIf Me.radRock.Checked = True Then

                Me.lblResultDisplay.Text = "You lose, the computer threw paper"
                numofWins = numofWins + 1

            Else

                Me.lblResultDisplay.Text = "Its a draw, the computer also threw paper"
                numofDraws = numofDraws + 1

            End If
        ElseIf computerThrow = SCISSORS Then

            Me.picComputerThrow.Image = My.Resources.scissors

            If Me.radRock.Checked = True Then

                Me.lblResultDisplay.Text = "You win, the computer threw scissors"
                numofLosses = numofLosses + 1

            ElseIf Me.radPaper.Checked = True Then

                Me.lblResultDisplay.Text = "You lose, the computer threw scissors"
                numofWins = numofWins + 1

            Else

                Me.lblResultDisplay.Text = "Its a draw, the computer also threw scissors"
                numofDraws = numofDraws + 1

            End If
        End If

        Me.lblWinsDisplay.Text = numofWins
        Me.lblLossesDisplay.Text = numofLosses
        Me.lblDrawsDisplay.Text = numofDraws

        Me.picComputerThrow.Visible = True

    End Sub

    Private Sub clearLabelAndPictures(ByVal sender As Object, ByVal e As System.EventArgs) Handles radPaper.CheckedChanged, radRock.CheckedChanged, radScissors.CheckedChanged

        If radRock.Checked = True Then
            Me.picYourThrow.Image = My.Resources.rock
        ElseIf radPaper.Checked = True Then
            Me.picYourThrow.Image = My.Resources.paper
        ElseIf radScissors.Checked = True Then
            Me.picYourThrow.Image = My.Resources.scissors
        End If

        Me.picYourThrow.Visible = True

        Me.picComputerThrow.Visible = False

        Me.lblResultDisplay.Text = Nothing

    End Sub

End Class
