Public Class frmAdministrationMainMenu
    Private Sub btnManagePilots_Click(sender As Object, e As EventArgs) Handles btnManagePilots.Click
        Dim frmPilotAdminMenu As New frmPilotAdminMenu
        frmPilotAdminMenu.ShowDialog()
    End Sub

    Private Sub btnManageAttendants_Click(sender As Object, e As EventArgs) Handles btnManageAttendants.Click
        Dim frmAttendantAdminMenu As New frmAttendantAdminMenu
        frmAttendantAdminMenu.ShowDialog()
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Dim frmFlyMe2TheMoonStatistics As New frmFlyMe2TheMoonStatistics
        frmFlyMe2TheMoonStatistics.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnCreateFutureFlights_Click(sender As Object, e As EventArgs) Handles btnCreateFutureFlights.Click
        Dim frmCreateNewFlight As New frmCreateNewFlight
        frmCreateNewFlight.ShowDialog()
    End Sub
End Class