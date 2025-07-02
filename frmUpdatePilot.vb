Public Class frmUpdatePilot
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub frmUpdatePilot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
        Dim dtPilotRoles As DataTable = New DataTable ' this is the table we will load from our reader for Pilot Roles


        Try
            ' loop through the textboxes and clear them in case they have data in them after a delete

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

            ' Build the select statement using PK from name selected
            strSelect = "SELECT TP.strFirstName, TP.strLastName, TP.strEmployeeID, TP.dtmDateOfHire, TP.dtmDateOfTermination, TP.dtmDateOfLicense, TP.intPilotRoleID, TE.strEmployeeLoginID, TE.strEmployeePassword" &
                        " From TPilots As TP Join TEmployees As TE" &
                        " On TP.intPilotID = TE.intEmployeeForeignKey" &
                        " Where TP.intPilotID = " & intPilot &
                        " and TE.intEmployeeRoleID = 3"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            drSourceTable.Read()


            ' populate the text boxes with the data
            txtFirstName.Text = drSourceTable("strFirstName")
            txtLastName.Text = drSourceTable("strLastName")
            txtEmployeeID.Text = drSourceTable("strEmployeeID")
            txtDateOfHire.Text = drSourceTable("dtmDateofHire")
            txtDateOfTermination.Text = drSourceTable("dtmDateofTermination")
            txtDateOfLicense.Text = drSourceTable("dtmDateofLicense")
            cboPilotRole.SelectedValue = drSourceTable("intPilotRoleID")
            txtPilotLoginID.Text = drSourceTable("strEmployeeLoginID")
            txtPilotPassword.Text = drSourceTable("strEmployeePassword")



            ' Build the select statement
            strSelect = "SELECT intPilotRoleID, strPilotRole FROM TPilotRoles"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtPilotRoles.Load(drSourceTable)


            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox


            cboPilotRole.ValueMember = "intPilotRoleID"
            cboPilotRole.DisplayMember = "strPilotRole"
            cboPilotRole.DataSource = dtPilotRoles

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)
        End Try
    End Sub

    Private Sub btnUpdatePilot_Click(sender As Object, e As EventArgs) Handles btnUpdatePilot.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strEmployeeID As String
        Dim dtmHireDate As Date
        Dim dtmTerminationDate As Date
        Dim dtmLicenseDate As Date
        Dim intPilotRole As Integer
        Dim strPilotLoginID As String
        Dim strPilotPassword As String
        Dim intPKID As Integer

        Dim intRowsAffected As Integer
        Dim cmdUpdatePilot As New OleDb.OleDbCommand

        Dim blnValidated As Boolean = True

        Get_And_Validate_Data(strFirstName, strLastName, strEmployeeID, dtmHireDate, dtmTerminationDate, dtmLicenseDate, intPilotRole, strPilotLoginID, strPilotPassword, blnValidated)



        If blnValidated = True Then
            Try




                ' open database this is in module
                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                            "The application will now close.",
                                            Me.Text + " Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                intPKID = intPilot

                ' text to call stored proc
                cmdUpdatePilot.CommandText = "EXECUTE uspUpdatePilot '" & intPKID & "','" & strFirstName & "','" & strLastName & "','" & strEmployeeID & "','" & dtmHireDate & "','" & dtmTerminationDate & "','" & dtmLicenseDate & "','" & intPilotRole & "','" & strPilotLoginID & "','" & strPilotPassword & "'"
                cmdUpdatePilot.CommandType = CommandType.StoredProcedure

                ' Call stored proc which will insert the record 
                cmdUpdatePilot = New OleDb.OleDbCommand(cmdUpdatePilot.CommandText, m_conAdministrator)

                ' this return is the # of rows affected
                intRowsAffected = cmdUpdatePilot.ExecuteNonQuery()

                ' close database connection
                CloseDatabaseConnection()

                ' have to let the user know what happened 
                If intRowsAffected > 0 Then
                    MessageBox.Show("Update Successful")

                Else
                    MessageBox.Show("Update failed")

                End If

                Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Get_And_Validate_Data(ByRef strFirstName As String, ByRef strLastName As String, ByRef strEmployeeID As String, ByRef dtmHireDate As Date, ByRef dtmTerminationDate As Date, ByRef dtmLicenseDate As Date, ByRef intPilotRole As Integer, ByRef strPilotLoginID As String, ByRef strPilotPassword As String, ByRef blnValidated As Boolean)
        Validate_First_Name(strFirstName, blnValidated)

        If blnValidated = True Then
            Validate_Last_Name(strLastName, blnValidated)
        End If
        If blnValidated = True Then
            Validate_EmployeeID(strEmployeeID, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Hire_Date(dtmHireDate, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Termination_Date(dtmTerminationDate, blnValidated)
        End If
        If blnValidated = True Then
            Validate_License_Date(dtmLicenseDate, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Pilot_Role(intPilotRole, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Pilot_Login_ID(strPilotLoginID, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Pilot_Password(strPilotPassword, blnValidated)
        End If

    End Sub

    Private Sub Validate_First_Name(ByRef strFirstName As String, ByRef blnValdiated As Boolean)
        If txtFirstName.Text = String.Empty Then
            MessageBox.Show("First Name is Required")
            txtFirstName.Focus()
            blnValdiated = False
            Exit Sub
        Else
            strFirstName = txtFirstName.Text
        End If
    End Sub

    Private Sub Validate_Last_Name(ByRef strLastName As String, ByRef blnValidated As Boolean)
        If txtLastName.Text = String.Empty Then
            MessageBox.Show("Last Name is Required")
            txtLastName.Focus()
            blnValidated = False
            Exit Sub
        Else
            strLastName = txtLastName.Text
        End If
    End Sub

    Private Sub Validate_EmployeeID(ByRef strEmployeeID As String, ByRef blnValidated As Boolean)
        If txtEmployeeID.Text = "" Then
            MessageBox.Show("EmployeeID is Required")
            txtEmployeeID.Focus()
            blnValidated = False
            Exit Sub
        Else
            strEmployeeID = txtEmployeeID.Text
        End If
    End Sub

    Private Sub Validate_Hire_Date(ByRef dtmHireDate As Date, ByRef blnValidated As Boolean)
        If Date.TryParse(txtDateOfHire.Text, dtmHireDate) Then
            dtmHireDate = txtDateOfHire.Text
        Else
            MessageBox.Show("Date of Hire is Required")
            txtDateOfHire.Focus()
            blnValidated = False
            Exit Sub
        End If

    End Sub

    Private Sub Validate_Termination_Date(ByRef dtmTerminationDate As Date, ByRef blnValidated As Boolean)
        If Date.TryParse(txtDateOfTermination.Text, dtmTerminationDate) Then
            dtmTerminationDate = txtDateOfTermination.Text
        Else
            MessageBox.Show("Date of Termination is Required")
            txtDateOfTermination.Focus()
            blnValidated = False
            Exit Sub
        End If
    End Sub

    Private Sub Validate_License_Date(ByRef dtmLicenseDate As Date, ByRef blnValidated As Boolean)
        If Date.TryParse(txtDateOfLicense.Text, dtmLicenseDate) Then
            dtmLicenseDate = txtDateOfLicense.Text
        Else
            MessageBox.Show("Date of License is Required")
            txtDateOfLicense.Focus()
            blnValidated = False
            Exit Sub
        End If
    End Sub

    Private Sub Validate_Pilot_Role(ByRef intPilotRole As Integer, ByRef blnValidated As Boolean)
        If cboPilotRole.SelectedValue = 0 Then
            MessageBox.Show("Pilot Role is Required")
            cboPilotRole.Focus()
            blnValidated = False
            Exit Sub
        Else
            intPilotRole = cboPilotRole.SelectedValue
        End If

    End Sub

    Private Sub Validate_Pilot_Login_ID(ByRef strPilotLoginID As String, ByRef blnValidated As Boolean)
        If txtPilotLoginID.Text = String.Empty Then
            MessageBox.Show("Login ID is required")
            txtPilotLoginID.Focus()
            blnValidated = False
            Exit Sub
        Else
            strPilotLoginID = txtPilotLoginID.Text
        End If
    End Sub

    Private Sub Validate_Pilot_Password(ByRef strPilotPassword As String, ByRef blnValidated As Boolean)
        If txtPilotPassword.Text = String.Empty Then
            MessageBox.Show("Password is required")
            txtPilotPassword.Focus()
            blnValidated = False
            Exit Sub
        Else
            strPilotPassword = txtPilotPassword.Text
        End If
    End Sub

End Class
