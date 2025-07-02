Public Class frmAttendantMainMenu
    Private Sub btnUpdateAttendant_Click(sender As Object, e As EventArgs) Handles btnUpdateAttendant.Click
        Dim frmUpdateAttendant As New frmUpdateAttendant
        frmUpdateAttendant.ShowDialog()
    End Sub

    Private Sub btnShowPastFlights_Click(sender As Object, e As EventArgs) Handles btnShowPastFlights.Click
        Dim frmAttendantPastFlights As New frmAttendantPastFlights
        frmAttendantPastFlights.ShowDialog()
    End Sub

    Private Sub btnShowFutureFlights_Click(sender As Object, e As EventArgs) Handles btnShowFutureFlights.Click
        Dim frmAttendantFutureFlights As New frmAttendantFutureFlights
        frmAttendantFutureFlights.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class