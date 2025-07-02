Public Class frmAddAttendant
    Private Sub btnAddAttendant_Click(sender As Object, e As EventArgs) Handles btnAddAttendant.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strEmployeeID As String
        Dim dtmHireDate As Date
        Dim dtmTerminationDate As Date
        Dim strAttendantLoginID As String
        Dim strAttendantPassword As String

        Dim intPKID As Integer ' holds next highest PK value
        Dim intPKID2 As Integer ' holds next highest PK value
        Dim intPKID3 As Integer ' holds next highest PK value
        Dim cmdAddAttendant As New OleDb.OleDbCommand()

        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed

        Dim blnValidated As Boolean = True

        Get_And_Validate_Data(strFirstName, strLastName, strEmployeeID, dtmHireDate, dtmTerminationDate, strAttendantLoginID, strAttendantPassword, blnValidated)

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
                cmdAddAttendant.CommandText = "EXECUTE uspAddAttendants '" & intPKID & "','" & intPKID2 & "','" & strFirstName & "','" & strLastName & "','" & strEmployeeID & "','" & dtmHireDate & "','" & dtmTerminationDate & "','" & strAttendantLoginID & "','" & strAttendantPassword & "','" & intPKID3 & "'"
                cmdAddAttendant.CommandType = CommandType.StoredProcedure

                ' Call stored proc which will insert the record 
                cmdAddAttendant = New OleDb.OleDbCommand(cmdAddAttendant.CommandText, m_conAdministrator)

                ' this return is the # of rows affected
                intRowsAffected = cmdAddAttendant.ExecuteNonQuery()

                ' close database connection
                CloseDatabaseConnection()

                ' have to let the user know what happened 
                If intRowsAffected > 0 Then
                    MessageBox.Show("Insert successful Attendant " & strLastName & " has been added.")

                Else
                    MessageBox.Show("Insert failed")

                End If

                Close()



            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub Get_And_Validate_Data(ByRef strFirstName As String, ByRef strLastName As String, ByRef strEmployeeID As String, ByRef dtmHireDate As Date, ByRef dtmTerminationDate As Date, ByRef strAttendantLoginID As String, ByRef strAttendantPassword As String, ByRef blnValidated As Boolean)
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
            Validate_Attendant_Login_ID(strAttendantLoginID, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Attendant_Password(strAttendantPassword, blnValidated)
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

    Private Sub Validate_Attendant_Login_ID(ByRef strAttendantLoginID As String, ByRef blnValidated As Boolean)
        If txtAttendantLoginID.Text = String.Empty Then
            MessageBox.Show("Login ID is required")
            txtAttendantLoginID.Focus()
            blnValidated = False
            Exit Sub
        Else
            strAttendantLoginID = txtAttendantLoginID.Text
        End If
    End Sub

    Private Sub Validate_Attendant_Password(ByRef strAttendantPassword As String, ByRef blnValidated As Boolean)
        If txtAttendantPassword.Text = String.Empty Then
            MessageBox.Show("Password is required")
            txtAttendantPassword.Focus()
            blnValidated = False
            Exit Sub
        Else
            strAttendantPassword = txtAttendantPassword.Text
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
