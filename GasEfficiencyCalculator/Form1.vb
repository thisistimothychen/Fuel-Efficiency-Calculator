Public Class GasEfficiencyCalculatorFrame

    Private Sub CalculateEfficiencyButton_Click(sender As Object, e As EventArgs) Handles CalculateEfficiencyButton.Click
        Dim regularPrice As Double = CDbl(RegularGasPriceInput.Text)
        Dim premiumPrice As Double = CDbl(PremiumGasPriceInput.Text)

        'Honda Odyssey
        Dim HondaMileage As Double = 22
        'Acura TL
        Dim AcuraMileage As Double = 24.5

        Dim HondaCostPerMile As Double = regularPrice / HondaMileage
        Dim AcuraCostPerMile As Double = premiumPrice / AcuraMileage
        Dim Difference As Double = Math.Abs(HondaCostPerMile - AcuraCostPerMile)
        Dim DifferenceFor25Miles As Double = Difference * 21.25 * 16

        If HondaCostPerMile < AcuraCostPerMile Then
            AnswerLabel.Text = "Honda is more fuel efficient by $" & DifferenceFor25Miles & "per 25 miles."
        Else
            AnswerLabel.Text = "Acura is more fuel efficient."
        End If
    End Sub
End Class