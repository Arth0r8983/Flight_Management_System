Public Class frmAssignPilotToFlight
    Private Sub frmAssignPilotToFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
        Dim dtFutureFlights As DataTable = New DataTable


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
            strSelect = "SELECT intPilotID, strFirstName + ' ' + strLastName as PilotName FROM TPilots"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboPilotNames.ValueMember = "intPilotID"
            cboPilotNames.DisplayMember = "PilotName"
            cboPilotNames.DataSource = dt

            ' Select the first item in the list by default
            If cboPilotNames.Items.Count > 0 Then cboPilotNames.SelectedIndex = 0

            ' Build the select statement
            strSelect = "SELECT TF.intFlightID, TF.dtmFlightDate" &
                         " FROM TFlights as TF" &
                         " WHERE TF.dtmFlightDate > GETDATE()"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtFutureFlights.Load(drSourceTable)


            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox


            cboFlights.ValueMember = "intFlightID"
            cboFlights.DisplayMember = "dtmFlightDate"
            cboFlights.DataSource = dtFutureFlights




            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' variables for new player data and select and insert statements
        Dim strSelect As String
        Dim strInsert As String
        Dim intFlight As Integer


        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you want To assign this flight On " & cboFlights.Text & " For Pilot " & cboPilotNames.Text & "?", "Confirm Flight", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        Select Case result
            Case DialogResult.Cancel
                MessageBox.Show("Action Canceled")
            Case DialogResult.No
                MessageBox.Show("Action Canceled")
            Case DialogResult.Yes
                Try


                    ' validate data is entered


                    ' put values into strings

                    intFlight = cboFlights.SelectedValue



                    If OpenDatabaseConnectionSQLServer() = False Then

                        ' No, warn the user ...
                        MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                        ' and close the form/application
                        Me.Close()

                    End If

                    strSelect = "SELECT MAX(intPilotFlightID) + 1 AS intNextPrimaryKey " &
                        " FROM TPilotFlights"

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
                    ' build insert statement (columns must match DB columns in name and the # of columns)

                    strInsert = "INSERT INTO TPilotFlights (intPilotFlightID, intPilotID, intFlightID)" &
            " VALUES (" & intNextPrimaryKey & "," & cboPilotNames.SelectedValue & "," & intFlight & ")"

                   ' MessageBox.Show(strInsert)

                    ' use insert command with sql string and connection object
                    cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

                    ' execute query to insert data
                    intRowsAffected = cmdInsert.ExecuteNonQuery()

                    ' If not 0 insert successful
                    If intRowsAffected > 0 Then
                        MessageBox.Show("flight has been assigned to Pilot")    ' let user know success
                        ' close new player form
                    End If


                    CloseDatabaseConnection()       ' close connection if insert didn't work




                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class