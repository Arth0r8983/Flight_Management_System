Public Class frmFlyMe2TheMoonStatistics
    Private Sub frmFlyMe2TheMoonStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand            ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader     ' this will be where our result set will 
            Dim dt As DataTable = New DataTable            ' this is the table we will load from our reader


            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Build the select statement
            strSelect = "SELECT Count(*) as TotalPassengers " &
                        "FROM TPassengers as TP"

            'MessageBox.Show(strSelect)

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' Read result( highest ID )
            drSourceTable.Read()

            ' Null? (empty table)
            If drSourceTable.IsDBNull(0) = True Then

                ' Yes, start numbering at 1
                lblTotalPassengers.Text = 0

            Else

                ' No, get the next highest ID
                lblTotalPassengers.Text = CInt(drSourceTable("TotalPassengers"))

            End If

            'Build the Select Statement

            strSelect = "SELECT COUNT(TFP.intFlightPassengerID) as TotalFlightsTaken" &
                        " From TPassengers As TP Join TFlightPassengers As TFP" &
                        " On TFP.intPassengerID = TP.intPassengerID"


            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader


            ' Read result( highest ID )
            drSourceTable.Read()

            ' Null? (empty table)
            If drSourceTable.IsDBNull(0) = True Then

                ' Yes, start numbering at 1
                lblTotalFlightsTaken.Text = 0

            Else

                ' No, get the next highest ID
                lblTotalFlightsTaken.Text = CInt(drSourceTable("TotalFlightsTaken"))

            End If

            '-------------------------------------------

            'Build the Select Statement

            strSelect = "SELECT AVG(TF.intMilesFlown) as AverageMilesFlown" &
                        " From TPassengers As TP LEFT Join TFlightPassengers As TFP" &
                        " On TFP.intPassengerID = TP.intPassengerID" &
                         " Left Join TFlights as TF" &
                        " On TFP.intFlightID = TF.intFlightID"


            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader


            ' Read result( highest ID )
            drSourceTable.Read()

            ' Null? (empty table)
            If drSourceTable.IsDBNull(0) = True Then

                ' Yes, start numbering at 1
                lblAverageMilesFlown.Text = 0

            Else

                ' No, get the next highest ID
                lblAverageMilesFlown.Text = CInt(drSourceTable("AverageMilesFlown"))

            End If


            strSelect = "SELECT SUM(TF.intMilesFlown) as TotalMilesFlown,TP.strFirstName, TP.strLastName" &
                        " From TPilots As TP LEFT Join TPilotFlights As TPF" &
                        " On TPF.intPilotID = TP.intPilotID" &
                        " Left Join TFlights as TF" &
                        " On TPF.intFlightID = TF.intFlightID" &
                        " GROUP BY TP.strFirstName, TP.strLastName"


            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            'loop through result set and display in Listbox

            lstPilotData.Items.Add("Total Flight Miles Per Pilot")
            lstPilotData.Items.Add("  ")
            lstPilotData.Items.Add("=======================================")

            While drSourceTable.Read()

                lstPilotData.Items.Add("  ")

                lstPilotData.Items.Add("First Name: " & vbTab & drSourceTable("strFirstName"))
                lstPilotData.Items.Add("Last Name: " & vbTab & drSourceTable("strLastName"))
                lstPilotData.Items.Add("TotalMilesFlown: " & vbTab & drSourceTable("TotalMilesFlown") & " Miles.")


                lstPilotData.Items.Add("  ")
                lstPilotData.Items.Add("=======================================")

            End While



            strSelect = "SELECT SUM(TF.intMilesFlown) as TotalMiles, TA.strFirstName, TA.strLastName" &
                        " From TAttendants As TA LEFT Join TAttendantFlights As TAF" &
                        " On TAF.intAttendantID = TA.intAttendantID" &
                         " Left Join TFlights as TF" &
                        " On TAF.intFlightID = TF.intFlightID" &
                        " GROUP BY TA.strFirstName, TA.strLastName"


            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            'loop through result set and display in Listbox

            lstAttendantData.Items.Add("Total Flight Miles Per Attendant")
            lstAttendantData.Items.Add("  ")
            lstAttendantData.Items.Add("=======================================")

            While drSourceTable.Read()

                lstAttendantData.Items.Add("  ")

                lstAttendantData.Items.Add("First Name: " & vbTab & drSourceTable("strFirstName"))
                lstAttendantData.Items.Add("Last Name: " & vbTab & drSourceTable("strLastName"))
                lstAttendantData.Items.Add("TotalMilesFlown: " & vbTab & drSourceTable("TotalMiles") & " Miles.")


                lstAttendantData.Items.Add("  ")
                lstAttendantData.Items.Add("=======================================")

            End While


            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class