Public Class Form1
    'Arnav
    '10/12
    'BandInformationDisplay

    Private Sub displayBeatlesInfo(ByVal sender As Object, ByVal e As System.EventArgs) Handles radBeatles.Click
        Me.lblBandMember1.Text = "John Lennon- Guitar and Vocals"
        Me.lblBandMember2.Text = "Ringo Starr – Drums and Vocals"
        Me.lblBandMember3.Text = "Paul McCartney – Bass and Vocals"
        Me.lblBandMember4.Text = "George Harrison – Lead Guitar and Vocals"
        Me.lblBandMember5.Text = ""
    End Sub

    Private Sub displayRedHotChilliPeppersInfo(ByVal sender As Object, ByVal e As System.EventArgs) Handles radRedHotChilliPeppers.Click
        Me.lblBandMember1.Text = "Anthony Kiedas – Vocals"
        Me.lblBandMember2.Text = "Flea – Bass"
        Me.lblBandMember3.Text = "Josh Klinghoffer – Lead Guitar"
        Me.lblBandMember4.Text = "Chad Smith – Drums"
        Me.lblBandMember5.Text = ""
    End Sub

    Private Sub displayFooFightersInfo(ByVal sender As Object, ByVal e As System.EventArgs) Handles radFooFighters.Click
        Me.lblBandMember1.Text = "Dave Grohl – Guitar and Vocals"
        Me.lblBandMember2.Text = "Taylor Hawkins – Drums"
        Me.lblBandMember3.Text = "Pat Smear – Guitar"
        Me.lblBandMember4.Text = "Nate Mendel – Bass"
        Me.lblBandMember5.Text = "Chris Shiflett – Lead Guitar and Backing Vocals"
    End Sub
    Private Sub displayOneDirectionInfo(ByVal sender As Object, ByVal e As System.EventArgs) Handles radOneDirection.Click
        Me.lblBandMember1.Text = "Harry Styles - Vocals"
        Me.lblBandMember2.Text = "Zayn Malik - Vocals"
        Me.lblBandMember3.Text = "Loius Tomlinson - Vocals"
        Me.lblBandMember4.Text = "Niall Horan - Vocals"
        Me.lblBandMember5.Text = "Liam Payne - Vocals"
    End Sub

    Private Sub displayNirvanaInfo(ByVal sender As Object, ByVal e As System.EventArgs) Handles radNirvana.Click
        Me.lblBandMember1.Text = "Kurt Cobain – Guitar and Vocals"
        Me.lblBandMember2.Text = "Dave Grohl – Drums"
        Me.lblBandMember3.Text = "Krist Novoselic – Bass"
        Me.lblBandMember4.Text = ""
        Me.lblBandMember5.Text = ""
    End Sub
End Class
