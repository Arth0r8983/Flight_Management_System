Public Class frmAddFlight
    Dim blnFirstEntry As Boolean = True
    Dim dblFlightCosts As Double = 250
    Private Sub frmAddFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtFutureFlights As DataTable = New DataTable ' this is the table we will load from our reader for State


        Try


            ' open the DB this is in module
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
            strSelect = "SELECT TF.intFlightID, TF.dtmFlightDate" &
                         " FROM TFlights as TF" &
                         " WHERE TF.dtmFlightDate > GETDATE()"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtFutureFlights.Load(drSourceTable)


            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox


            cboFutureFlights.ValueMember = "intFlightID"
            cboFutureFlights.DisplayMember = "dtmFlightDate"
            cboFutureFlights.DataSource = dtFutureFlights


            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

        cboFutureFlights.Text = ""
        radDesignatedSeat.Visible = False
        radReservedSeat.Visible = False
        lblDesignatedSeatCost.Visible = False
        lblReservedSeatCost.Visible = False
        btnSubmit.Enabled = False


    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        ' variables for new player data and select and insert statements
        Dim strSelect As String
        Dim strInsert As String
        Dim intFlight As Integer

        Dim dtmFlightDate As Date
        Dim strFlightNumber As String
        Dim dtmTimeofDeparture As Date
        Dim dtmTimeofLanding As Date
        Dim intFromAirport As Integer
        Dim intToAirport As Integer
        Dim intMilesFlown As Integer
        Dim intPlane As Integer
        Dim dblCostsOfFlight As Double

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Dim result As DialogResult

        If radDesignatedSeat.Checked = False And radReservedSeat.Checked = False Then
            MessageBox.Show("Must select seating")
            Exit Sub
        End If
        result = MessageBox.Show("Are you sure you want To book this flight On " & cboFutureFlights.Text & "?", "Confirm Flight", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        Select Case result
            Case DialogResult.Cancel
                MessageBox.Show("Action Canceled")
            Case DialogResult.No
                MessageBox.Show("Action Canceled")
            Case DialogResult.Yes
                Try


                    intFlight = cboFutureFlights.SelectedValue



                    If OpenDatabaseConnectionSQLServer() = False Then

                        ' No, warn the user ...
                        MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                        ' and close the form/application
                        Me.Close()

                    End If
                    '==============================================
                    ' Build the select statement using PK from name selected
                    strSelect = "SELECT dtmFlightDate, strFlightNumber, dtmTimeofDeparture, dtmTimeofLanding, intFromAirportID, intToAirportID, intMilesFlown, intPlaneID " &
                        " FROM TFlights WHERE intFlightID = " & intFlight

                    ' Retrieve all the records 
                    cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                    drSourceTable = cmdSelect.ExecuteReader

                    drSourceTable.Read()


                    ' populate the text boxes with the data
                    dtmFlightDate = drSourceTable("dtmFlightDate")
                    strFlightNumber = drSourceTable("strFlightNumber")
                    dtmTimeofDeparture = drSourceTable("dtmTimeofDeparture")
                    dtmTimeofLanding = drSourceTable("dtmTimeofLanding")
                    intFromAirport = drSourceTable("intFromAirportID")
                    intToAirport = drSourceTable("intToAirportID")
                    intMilesFlown = drSourceTable("intMilesFlown")
                    intPlane = drSourceTable("intPlaneID")




                    '==============================================




                    strSelect = "SELECT MAX(intFlightPassengerID) + 1 AS intNextPrimaryKey " &
                        " FROM TFlightPassengers"

                    ' Execute command
                    cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                    drSourceTable = cmdSelect.ExecuteReader

                    ' Read result( highest ID )
                    drSourceTable.Read()

                    ' Null? (empty table)
                    If drSourceTable.IsDBNull(0) = True Then

                        ' Yes, start numbering at 1
                        intNextPrimaryKey = 1

                    Else

                        ' No, get the next highest ID
                        intNextPrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))

                    End If

                    If radReservedSeat.Checked = True Then
                        dblCostsOfFlight = lblReservedSeatCost.Text
                    End If

                    If radDesignatedSeat.Checked = True Then
                        dblCostsOfFlight = lblDesignatedSeatCost.Text
                    End If
                    ' build insert statement (columns must match DB columns in name and the # of columns)

                    strInsert = "INSERT INTO TFlightPassengers (intFlightPassengerID, intFlightID, intPassengerID, strSeat, monFlightCosts)" &
            " VALUES (" & intNextPrimaryKey & "," & intFlight & "," & intPassenger & ", '1B', " & dblCostsOfFlight & ")"

                    '  MessageBox.Show(strInsert)

                    ' use insert command with sql string and connection object
                    cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

                    ' execute query to insert data
                    intRowsAffected = cmdInsert.ExecuteNonQuery()

                    ' If not 0 insert successful
                    If intRowsAffected > 0 Then
                        MessageBox.Show("your flight has been booked")    ' let user know success
                        ' close new player form
                    End If

                    Close()
                    CloseDatabaseConnection()       ' close connection if insert didn't work




                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
        End Select



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub cboFutureFlights_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFutureFlights.SelectedIndexChanged
        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim strSelect As String
        Dim intFlight As Integer


        Dim intMilesFlown As Integer
        Dim intReservedPassengers As Integer
        Dim intPlaneTypeID As Integer
        Dim strAirportCode As String
        Dim shtPassengerAge As Short
        Dim shtPreviousFlights As Short
        If cboFutureFlights.SelectedValue = 0 Then
            Exit Sub
        End If

        intFlight = cboFutureFlights.SelectedValue

        If OpenDatabaseConnectionSQLServer() = False Then

            ' No, warn the user ...
            MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Me.Close()

        End If

        If cboFutureFlights.Text <> "" Then
            radReservedSeat.Visible = True
            radDesignatedSeat.Visible = True
            lblReservedSeatCost.Visible = True
            lblDesignatedSeatCost.Visible = True
            btnSubmit.Enabled = True

            strSelect = "SELECT TF.intMilesFlown" &
                        " From TFlights As TF" &
                        " Where TF.intFlightID = " & intFlight

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            intMilesFlown = drSourceTable("intMilesFlown")

            If intMilesFlown > 750 Then
                dblFlightCosts += 50
            End If

            strSelect = "SELECT COUNT(intFlightID) as TotalSeatsReserved" &
                         " From TFlightPassengers As TFP" &
                         " Where TFP.intFlightID = " & intFlight

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            intReservedPassengers = drSourceTable("TotalSeatsReserved")

            If intReservedPassengers > 8 Then
                dblFlightCosts += 100
            End If

            If intReservedPassengers < 4 Then
                dblFlightCosts -= 50
            End If

            strSelect = "SELECT TPT.intPlaneTypeID" &
                        " From TFlights As TF Join TPlanes As TP" &
                        " On TP.intPlaneID = TF.intPlaneID" &
                        " Join TPlaneTypes as TPT" &
                        " On TP.intPlaneTypeID = TPT.intPlaneTypeID" &
                        " WHERE TF.intFlightID = " & intFlight

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            intPlaneTypeID = drSourceTable("intPlaneTypeID")

            If intPlaneTypeID = 1 Then
                dblFlightCosts += 35
            End If

            If intPlaneTypeID = 2 Then
                dblFlightCosts -= 25
            End If

            strSelect = "SELECT TA.strAirportCode" &
                        " From TFlights As TF Join TAirports As TA" &
                        " On TF.intToAirportID = TA.intAirportID" &
                        " Where TF.intFlightID = " & intFlight

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            strAirportCode = drSourceTable("strAirportCode")

            If strAirportCode = "MIA" Then
                dblFlightCosts += 15
            End If

            strSelect = "SELECT strLastname, dtmPassengerDateofBirth, FLOOR(DATEDIFF(DAY, dtmPassengerDateofBirth, GetDate()) / 365.25) as PassengerAge" &
                         " From TPassengers" &
                         " Where intPassengerID = " & intPassenger

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            shtPassengerAge = drSourceTable("PassengerAge")

            If shtPassengerAge >= 65 Then
                dblFlightCosts -= (dblFlightCosts * 0.2)
            End If

            If shtPassengerAge <= 5 Then
                dblFlightCosts -= (dblFlightCosts * 0.65)
            End If

            strSelect = "SELECT COUNT(TFP.intPassengerID) as PreviousFlights" &
                        " From TFlightPassengers As TFP Join TFlights As TF" &
                        " On TFP.intFlightID = TF.intFlightID" &
                        " Where TF.dtmFlightDate < GETDATE()" &
                         " And TFP.intPassengerID = " & intPassenger

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()

            shtPreviousFlights = drSourceTable("PreviousFlights")

            If shtPreviousFlights > 5 Then
                dblFlightCosts -= (dblFlightCosts * 0.1)
            End If

            If shtPreviousFlights > 10 Then
                dblFlightCosts -= (dblFlightCosts * 0.2)
            End If

            lblDesignatedSeatCost.Text = dblFlightCosts.ToString("c")

            lblReservedSeatCost.Text = (dblFlightCosts + 125).ToString("c")
        End If

        dblFlightCosts = 250

    End Sub
End Class