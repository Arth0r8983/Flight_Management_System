Public Class frmPilotAdminMenu
    Private Sub btnAddPilot_Click(sender As Object, e As EventArgs) Handles btnAddPilot.Click
        Dim frmAddPilot As New frmAddPilot
        frmAddPilot.ShowDialog()
    End Sub

    Private Sub btnDeletePilot_Click(sender As Object, e As EventArgs) Handles btnDeletePilot.Click
        Dim frmDeletePilots As New frmDeletePilots
        frmDeletePilots.ShowDialog()
    End Sub

    Private Sub btnAddPilotsToFlights_Click(sender As Object, e As EventArgs) Handles btnAddPilotsToFlights.Click
        Dim frmAssignPilotToFlight As New frmAssignPilotToFlight
        frmAssignPilotToFlight.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnUpdatePilot_Click(sender As Object, e As EventArgs) Handles btnUpdatePilot.Click
        Dim frmAdminUpdatePilot As New frmAdminUpdatePilot
        frmAdminUpdatePilot.ShowDialog()
    End Sub
End Class