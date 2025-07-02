Public Class frmUser
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If radPassenger.Checked = True Then
            Dim frmCustomerNavigation As New frmCustomerNavigation
            frmCustomerNavigation.ShowDialog()
        End If

        If radPilot.Checked = True Then
            Dim frmPilotNavigation As New frmPilotNavigation
            frmPilotNavigation.ShowDialog()
        End If

        If radAttendant.Checked = True Then
            Dim frmAttendantNavigation As New frmAttendantNavigation
            frmAttendantNavigation.ShowDialog()
        End If

        If radAdministration.Checked Then
            Dim frmAdministrationMainMenu As New frmAdministrationMainMenu
            frmAdministrationMainMenu.ShowDialog()
        End If
    End Sub


End Class
