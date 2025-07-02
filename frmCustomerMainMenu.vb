Public Class frmCustomerMainMenu
    Private Sub btnUpdatePassenger_Click(sender As Object, e As EventArgs) Handles btnUpdatePassenger.Click
        Dim frmUpdatePassenger As New frmUpdatePassenger
        frmUpdatePassenger.ShowDialog()
    End Sub

    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        Dim frmAddFlight As New frmAddFlight
        frmAddFlight.ShowDialog()
    End Sub

    Private Sub btnShowPastFlights_Click(sender As Object, e As EventArgs) Handles btnShowPastFlights.Click
        Dim frmDisplayPastFlights As New frmDisplayPastFlights
        frmDisplayPastFlights.ShowDialog()
    End Sub

    Private Sub btnShowFutureFlights_Click(sender As Object, e As EventArgs) Handles btnShowFutureFlights.Click
        Dim frmDisplayFutureFlights As New frmDisplayFutureFlights
        frmDisplayFutureFlights.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class