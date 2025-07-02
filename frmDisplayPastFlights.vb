Public Class frmDisplayPastFlights
    Private Sub frmDisplayPastFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim objParam As OleDb.OleDbParameter
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader


        Try


            ' open the database this is in module
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' ---------------------
            ' Stored Procedure Enhancement
            ' ---------------------
            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand("uspListPassengerPastFlights", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure

            objParam = cmdSelect.Parameters.Add("@Passenger_ID", OleDb.OleDbType.Integer)
            objParam.Direction = ParameterDirection.Input
            objParam.Value = intPassenger

            drSourceTable = cmdSelect.ExecuteReader



            lstPastFlights.Items.Add("List of All Past Flights of Passenger")
            lstPastFlights.Items.Add("  ")
            lstPastFlights.Items.Add("========================")



            While drSourceTable.Read()

                lstPastFlights.Items.Add("  ")

                lstPastFlights.Items.Add("Flight Date: " & vbTab & vbTab & drSourceTable("dtmFlightDate"))
                lstPastFlights.Items.Add("Flight Number: " & vbTab & vbTab & drSourceTable("strFlightNumber"))
                lstPastFlights.Items.Add("Time of Departure: " & vbTab & vbTab & drSourceTable("dtmTimeofDeparture"))
                lstPastFlights.Items.Add("Time of Landing: " & vbTab & vbTab & drSourceTable("dtmTimeOfLanding"))
                lstPastFlights.Items.Add("From Airport: " & vbTab & vbTab & drSourceTable("intFromAirportID"))
                lstPastFlights.Items.Add("To Airport: " & vbTab & vbTab & drSourceTable("intToAirportID"))
                lstPastFlights.Items.Add("Miles Flown: " & vbTab & vbTab & drSourceTable("intMilesFlown"))
                lstPastFlights.Items.Add("Plane Type: " & vbTab & vbTab & drSourceTable("strPlaneType"))


                lstPastFlights.Items.Add("  ")
                lstPastFlights.Items.Add("=============================")

            End While

            ' ---------------------
            ' Stored Procedure Enhancement
            ' ---------------------
            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand("uspPassengerMilesFlown", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure

            objParam = cmdSelect.Parameters.Add("@Passenger_ID", OleDb.OleDbType.Integer)
            objParam.Direction = ParameterDirection.Input
            objParam.Value = intPassenger

            drSourceTable = cmdSelect.ExecuteReader

            ' Read result( highest ID )
            drSourceTable.Read()

            ' Null? (empty table)
            If drSourceTable.IsDBNull(0) = True Then

                ' Yes, start numbering at 1
                lblTotalMilesFlown.Text = 0

            Else

                ' No, get the next highest ID
                lblTotalMilesFlown.Text = CInt(drSourceTable("TotalMilesFlown"))

            End If

            'Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class