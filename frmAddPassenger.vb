Public Class frmAddPassenger
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub frmAddPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dtState As DataTable = New DataTable ' this is the table we will load from our reader




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
            strSelect = "SELECT intStateID, strState FROM TStates"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dtState.Load(drSourceTable)

            'load the Cities result set into the combobox.  For VB, we do this by binding the data to the combobox

            cboStates.ValueMember = "intStateID"
            cboStates.DisplayMember = "strState"
            cboStates.DataSource = dtState




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
        'Dim strSelect As String
        'Dim strInsert As String
        'Dim cmdSelect As OleDb.OleDbCommand ' select command object
        'Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        'Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intPKID As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
        Dim cmdAddPassenger As New OleDb.OleDbCommand()


        Dim strFirstName As String
        Dim strLastName As String
        Dim strAddress As String
        Dim strCity As String
        Dim intState As Integer
        Dim strZip As String
        Dim strPhoneNumber As String
        Dim strEmail As String
        Dim strLoginID As String
        Dim strPassword As String
        Dim dtmDateofBirth As Date


        Dim blnValidated As Boolean = True

        Get_And_Validate_Data(strFirstName, strLastName, strAddress, strCity, intState, strZip, strPhoneNumber, strEmail, strLoginID, strPassword, dtmDateofBirth, blnValidated)



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
                cmdAddPassenger.CommandText = "EXECUTE uspAddPassengers '" & intPKID & "','" & strFirstName & "','" & strLastName & "','" & strAddress & "','" & strCity & "','" & intState & "','" & strZip & "','" & strPhoneNumber & "','" & strEmail & "','" & strLoginID & "','" & strPassword & "','" & dtmDateofBirth & "'"
                cmdAddPassenger.CommandType = CommandType.StoredProcedure

                ' Call stored proc which will insert the record 
                cmdAddPassenger = New OleDb.OleDbCommand(cmdAddPassenger.CommandText, m_conAdministrator)

                ' this return is the # of rows affected
                intRowsAffected = cmdAddPassenger.ExecuteNonQuery()

                ' close database connection
                CloseDatabaseConnection()

                ' have to let the user know what happened 
                If intRowsAffected > 0 Then
                    MessageBox.Show("Insert successful Passenger " & strLastName & " has been added.")

                Else
                    MessageBox.Show("Insert failed")

                End If

                Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub Get_And_Validate_Data(ByRef strFirstName As String, ByRef strLastName As String, ByRef strAddress As String, ByRef strCity As String, ByRef intState As Integer, ByRef strZip As String, ByRef strPhoneNumber As String, ByRef strEmail As String, ByRef strLoginID As String, ByRef strPassword As String, ByRef dtmDateofBirth As Date, ByRef blnValidated As Boolean)
        Validate_First_Name(strFirstName, blnValidated)

        If blnValidated = True Then
            Validate_Last_Name(strLastName, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Address(strAddress, blnValidated)
        End If
        If blnValidated = True Then
            Validate_City(strCity, blnValidated)
        End If
        If blnValidated = True Then
            Validate_State(intState, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Zip(strZip, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Phone_Number(strPhoneNumber, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Email(strEmail, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Login_ID(strLoginID, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Password(strPassword, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Date_of_Birth(dtmDateofBirth, blnValidated)
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

    Private Sub Validate_Address(ByRef strAddress As String, ByRef blnValidated As Boolean)
        If txtAddress.Text = "" Then
            MessageBox.Show("Address is Required")
            txtAddress.Focus()
            blnValidated = False
            Exit Sub
        Else
            strAddress = txtAddress.Text
        End If
    End Sub

    Private Sub Validate_City(ByRef strCity As String, ByRef blnValidated As Boolean)
        If txtCity.Text = String.Empty Then
            MessageBox.Show("City is Required")
            txtCity.Focus()
            blnValidated = False
            Exit Sub
        Else
            strCity = txtCity.Text
        End If
    End Sub

    Private Sub Validate_State(ByRef intState As Integer, ByRef blnValidated As Boolean)
        If cboStates.SelectedValue = 0 Then
            MessageBox.Show("State is Required")
            cboStates.Focus()
            blnValidated = False
            Exit Sub
        Else
            intState = cboStates.SelectedValue
        End If
    End Sub

    Private Sub Validate_Zip(ByRef strZip As String, ByRef blnValidated As Boolean)
        If txtZip.Text = String.Empty Then
            MessageBox.Show("Zip code is Required")
            txtZip.Focus()
            blnValidated = False
            Exit Sub
        Else
            strZip = txtZip.Text
            If strZip.Length <> 5 Then
                MessageBox.Show("Zip Code must be 5 digits long")
                txtZip.Focus()
                blnValidated = False
                Exit Sub
            Else
                strZip = txtZip.Text
            End If
        End If
    End Sub

    Private Sub Validate_Phone_Number(ByRef strPhoneNumber As String, ByRef blnValidated As Boolean)
        Dim strString1 As String
        Dim strString2 As String
        Dim strString3 As String
        Dim strString4 As String

        If txtPhoneNumber.Text = String.Empty Then
            MessageBox.Show("Phone Number is Required")
            txtPhoneNumber.Focus()
            blnValidated = False
            Exit Sub
        Else
            strPhoneNumber = txtPhoneNumber.Text
            If strPhoneNumber.Length = 10 Then
                strString1 = txtPhoneNumber.Text


                strString2 = strString1.Insert(0, "(")
                strString3 = strString2.Insert(4, ")")
                strString4 = strString3.Insert(8, "-")

                strPhoneNumber = strString4
            Else
                MessageBox.Show("Phone Number must be 10 Digits Long")
                txtPhoneNumber.Focus()
                blnValidated = False
                Exit Sub
            End If
        End If


    End Sub

    Private Sub Validate_Email(ByRef strEmail As String, ByRef blnValidated As Boolean)
        If txtEmail.Text = String.Empty Then
            MessageBox.Show("Email is Required")
            txtEmail.Focus()
            blnValidated = False
            Exit Sub
        Else
            strEmail = txtEmail.Text
            If strEmail.IndexOf("@") = -1 Then
                MessageBox.Show("Email must include @")
                txtEmail.Focus()
                blnValidated = False
                Exit Sub
            Else
                strEmail = txtEmail.Text
            End If
        End If
    End Sub

    Private Sub Validate_Login_ID(ByRef strLoginID As String, ByRef blnValidated As Boolean)
        If txtLoginID.Text = String.Empty Then
            MessageBox.Show("Login ID is required")
            txtLoginID.Focus()
            blnValidated = False
            Exit Sub
        Else
            strLoginID = txtLoginID.Text
        End If
    End Sub

    Private Sub Validate_Password(ByRef strPassword As String, ByRef blnValidated As Boolean)
        If txtPassengerPassword.Text = String.Empty Then
            MessageBox.Show("Password is required")
            txtPassengerPassword.Focus()
            blnValidated = False
            Exit Sub
        Else
            strPassword = txtPassengerPassword.Text
        End If
    End Sub

    Private Sub Validate_Date_of_Birth(ByRef dtmDateofBirth As Date, ByRef blnValidated As Boolean)
        If Date.TryParse(txtDateofBirth.Text, dtmDateofBirth) Then
            dtmDateofBirth = txtDateofBirth.Text
            If dtmDateofBirth > DateAndTime.Today Then
                MessageBox.Show("Date of birth must be in the past")
                txtDateofBirth.Focus()
                blnValidated = False
                Exit Sub
            End If
        End If
    End Sub

End Class