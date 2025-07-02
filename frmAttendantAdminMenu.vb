Public Class frmAttendantAdminMenu
    Private Sub btnAddAttendant_Click(sender As Object, e As EventArgs) Handles btnAddAttendant.Click
        Dim frmAddAttendant As New frmAddAttendant
        frmAddAttendant.ShowDialog()
    End Sub

    Private Sub btnDeleteAttendant_Click(sender As Object, e As EventArgs) Handles btnDeleteAttendant.Click
        Dim frmDeleteAttendant As New frmDeleteAttendant
        frmDeleteAttendant.ShowDialog()
    End Sub

    Private Sub btnAddAttendantsToFlights_Click(sender As Object, e As EventArgs) Handles btnAddAttendantsToFlights.Click
        Dim frmAssignAttendantToFlight As New frmAssignAttendantToFlight
        frmAssignAttendantToFlight.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnUpdateAttendant_Click(sender As Object, e As EventArgs) Handles btnUpdateAttendant.Click
        Dim frmAdminUpdateAttendant As New frmAdminUpdateAttendant
        frmAdminUpdateAttendant.ShowDialog()
    End Sub
End Class