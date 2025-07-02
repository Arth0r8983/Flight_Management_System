Public Class frmAttendantFutureFlights
    Private Sub frmAttendantFutureFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
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

            ' Build the select statement using PK from name selected
            strSelect = "SELECT TF.strFlightNumber, TF.dtmFlightDate, TF.dtmTimeofDeparture, TF.dtmTimeOfLanding, TF.intFromAirportID, TF.intToAirportID, TF.intMilesFlown, TPT.strPlaneType" &
                        " From TFlights As TF Join TAttendantFlights As TAF" &
                        " On TAF.intFlightID = TF.intFlightID" &
                        " Join TPlanes as TP" &
                        " On TF.intPlaneID = TP.intPlaneID" &
                        " Join TPlaneTypes as TPT" &
                        " On TP.intPlaneTypeID = TPT.intPlaneTypeID" &
                        " WHERE TAF.intAttendantID = " & intAttendant &
                        " And TF.dtmFlightDate > GETDATE()"




            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader





            lstFutureFlights.Items.Add("List of All Future Flights of Attendant")
            lstFutureFlights.Items.Add("  ")
            lstFutureFlights.Items.Add("========================")



            While drSourceTable.Read()

                lstFutureFlights.Items.Add("  ")

                lstFutureFlights.Items.Add("Flight Date: " & vbTab & vbTab & drSourceTable("dtmFlightDate"))
                lstFutureFlights.Items.Add("Flight Number: " & vbTab & vbTab & drSourceTable("strFlightNumber"))
                lstFutureFlights.Items.Add("Time of Departure: " & vbTab & vbTab & drSourceTable("dtmTimeofDeparture"))
                lstFutureFlights.Items.Add("Time of Landing: " & vbTab & vbTab & drSourceTable("dtmTimeOfLanding"))
                lstFutureFlights.Items.Add("From Airport: " & vbTab & vbTab & drSourceTable("intFromAirportID"))
                lstFutureFlights.Items.Add("To Airport: " & vbTab & vbTab & drSourceTable("intToAirportID"))
                lstFutureFlights.Items.Add("Miles Flown: " & vbTab & vbTab & drSourceTable("intMilesFlown"))
                lstFutureFlights.Items.Add("Plane Type: " & vbTab & vbTab & drSourceTable("strPlaneType"))


                lstFutureFlights.Items.Add("  ")
                lstFutureFlights.Items.Add("=============================")

            End While

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