Public Class frmCreateNewFlight
    Private Sub frmCreateNewFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtAirport As DataTable = New DataTable ' this is the table we will load from our reader
        Dim dtAirports As DataTable = New DataTable
        Dim dtPlanes As DataTable = New DataTable




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


            ' Build the select statement to obtain Cities
            strSelect = "SELECT intAirportID, strAirportCode FROM TAirports"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtAirport.Load(drSourceTable)

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboFromAirport.ValueMember = "intAirportID"
            cboFromAirport.DisplayMember = "strAirportCode"
            cboFromAirport.DataSource = dtAirport


            ' Build the select statement to obtain Cities
            strSelect = "SELECT intAirportID, strAirportCode FROM TAirports"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtAirports.Load(drSourceTable)

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboToAirport.ValueMember = "intAirportID"
            cboToAirport.DisplayMember = "strAirportCode"
            cboToAirport.DataSource = dtAirports


            ' Build the select statement to obtain Cities
            strSelect = "SELECT intPlaneID, strPlaneNumber FROM TPlanes"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtPlanes.Load(drSourceTable)

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboPlane.ValueMember = "intPlaneID"
            cboPlane.DisplayMember = "strPlaneNumber"
            cboPlane.DataSource = dtPlanes

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        Dim dtmFlightDate As Date
        Dim strFlightNumber As String
        Dim dtmTimeofDeparture As Date
        Dim dtmTimeofLanding As Date
        Dim intFromAirport As Integer
        Dim intToAirport As Integer
        Dim intMilesFlown As Integer
        Dim intPlane As Integer

        Dim intPKID As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Dim cmdAddFlight As New OleDb.OleDbCommand()

        Dim blnValidated As Boolean = True

        Get_And_Validate_Data(dtmFlightDate, strFlightNumber, dtmTimeofDeparture, dtmTimeofLanding, intFromAirport, intToAirport, intMilesFlown, intPlane, blnValidated)



        If blnValidated = True Then
            Try

                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If
                ' text to call stored proc
                cmdAddFlight.CommandText = "EXECUTE uspAddFutureFlights '" & intPKID & "','" & dtmFlightDate & "','" & strFlightNumber & "','" & dtmTimeofDeparture & "','" & dtmTimeofLanding & "','" & intFromAirport & "','" & intToAirport & "','" & intMilesFlown & "','" & intPlane & "'"
                cmdAddFlight.CommandType = CommandType.StoredProcedure

                ' Call stored proc which will insert the record 
                cmdAddFlight = New OleDb.OleDbCommand(cmdAddFlight.CommandText, m_conAdministrator)

                ' this return is the # of rows affected
                intRowsAffected = cmdAddFlight.ExecuteNonQuery()

                ' close database connection
                CloseDatabaseConnection()

                ' have to let the user know what happened 
                If intRowsAffected > 0 Then
                    MessageBox.Show("Insert successful Flight Number " & strFlightNumber & " has been added.")

                Else
                    MessageBox.Show("Insert failed")

                End If

                Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub


    Private Sub Get_And_Validate_Data(ByRef dtmFlightDate As Date, ByRef strFlightNumber As String, ByRef dtmTimeofDeparture As Date, ByRef dtmTimeofLanding As Date, ByRef intFromAirport As Integer, ByRef intToAirport As Integer, ByRef intMilesFlown As Integer, ByRef intPlane As Integer, ByRef blnValidated As Boolean)
        Validate_Flight_Date(dtmFlightDate, blnValidated)

        If blnValidated = True Then
            Validate_Flight_Number(strFlightNumber, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Time_Of_Departure(dtmTimeofDeparture, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Time_Of_Landing(dtmTimeofLanding, blnValidated)
        End If
        If blnValidated = True Then
            Validate_From_Airport(intFromAirport, blnValidated)
        End If
        If blnValidated = True Then
            Validate_To_Airport(intToAirport, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Miles_Flown(intMilesFlown, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Plane(intPlane, blnValidated)
        End If
    End Sub

    Private Sub Validate_Flight_Date(ByRef dtmFlightDate As Date, ByRef blnValidated As Boolean)
        If Date.TryParse(txtFlightDate.Text, dtmFlightDate) Then
            dtmFlightDate = txtFlightDate.Text
            If dtmFlightDate < DateAndTime.Today Then
                MessageBox.Show("Flight Date must be in the future")
                txtFlightDate.Focus()
                blnValidated = False
                Exit Sub
            End If
        Else
            MessageBox.Show("Flight Date is Required")
            txtFlightDate.Focus()
            blnValidated = False
            Exit Sub
        End If
    End Sub

    Private Sub Validate_Flight_Number(ByRef strFlightNumber As String, ByRef blnValidated As Boolean)
        If txtFlightNumber.Text = String.Empty Then
            MessageBox.Show("Flight Number is Required")
            txtFlightNumber.Focus()
            blnValidated = False
            Exit Sub
        Else
            strFlightNumber = txtFlightNumber.Text
        End If
    End Sub

    Private Sub Validate_Time_Of_Departure(ByRef dtmTimeofDeparture As Date, ByRef blnValidated As Boolean)
        If Date.TryParse(txtTimeOfDeparture.Text, dtmTimeofDeparture) Then
            dtmTimeofDeparture = txtTimeOfDeparture.Text
        Else
            MessageBox.Show("Time of Departure is Required")
            txtTimeOfDeparture.Focus()
            blnValidated = False
            Exit Sub
        End If
    End Sub

    Private Sub Validate_Time_Of_Landing(ByRef dtmTimeofLanding As Date, ByRef blnValidated As Boolean)
        If Date.TryParse(txtTimeOfLanding.Text, dtmTimeofLanding) Then
            dtmTimeofLanding = txtTimeOfLanding.Text
        Else
            MessageBox.Show("Time of Landing is Required")
            txtTimeOfLanding.Focus()
            blnValidated = False
            Exit Sub
        End If
    End Sub

    Private Sub Validate_From_Airport(ByRef intFromAirport As Integer, ByRef blnValidated As Boolean)
        If cboFromAirport.SelectedValue = 0 Then
            MessageBox.Show("From Aiport Field is Required")
            cboFromAirport.Focus()
            blnValidated = False
            Exit Sub
        Else
            intFromAirport = cboFromAirport.SelectedValue
        End If
    End Sub

    Private Sub Validate_To_Airport(ByRef intToAirport As Integer, ByRef blnValidated As Boolean)
        If cboToAirport.SelectedValue = 0 Then
            MessageBox.Show("To Aiport Field is Required")
            cboToAirport.Focus()
            blnValidated = False
            Exit Sub
        Else
            intToAirport = cboToAirport.SelectedValue
        End If
    End Sub

    Private Sub Validate_Miles_Flown(ByRef intMilesFlown As Integer, ByRef blnValidated As Boolean)
        If Integer.TryParse(txtMilesFlown.Text, intMilesFlown) Then
            intMilesFlown = txtMilesFlown.Text
            If intMilesFlown < 0 Then
                MessageBox.Show("Miles flown must be greater than zero")
                txtMilesFlown.Focus()
                blnValidated = False
                Exit Sub
            End If
        Else
            MessageBox.Show("Miles flown is required")
            txtMilesFlown.Focus()
            blnValidated = False
            Exit Sub
        End If



    End Sub

    Private Sub Validate_Plane(ByRef intPlane As Integer, ByRef blnValidated As Boolean)
        If cboPlane.SelectedValue = 0 Then
            MessageBox.Show("Plane is Required")
            cboPlane.Focus()
            blnValidated = False
            Exit Sub
        Else
            intPlane = cboPlane.SelectedValue
        End If
    End Sub
End Class