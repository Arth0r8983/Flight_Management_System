Public Class frmPassengerLogin
    Private Sub btnNewPassenger_Click(sender As Object, e As EventArgs) Handles btnNewPassenger.Click
        Dim frmAddPassenger As New frmAddPassenger
        frmAddPassenger.ShowDialog()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strPassengerLogin As String
        Dim strPassengerPassword As String


        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim objParam As OleDb.OleDbParameter
        Dim objParameter As OleDb.OleDbParameter
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

        Dim blnValidated As Boolean = True

        Get_And_Validate_Input(strPassengerLogin, strPassengerPassword, blnValidated)

        If blnValidated = True Then
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
                cmdSelect = New OleDb.OleDbCommand("uspPassengerLogins", m_conAdministrator)
                cmdSelect.CommandType = CommandType.StoredProcedure

                objParam = cmdSelect.Parameters.Add("@PassengerLoginID", OleDb.OleDbType.VarChar)
                objParam.Direction = ParameterDirection.Input
                objParam.Value = strPassengerLogin


                objParameter = cmdSelect.Parameters.Add("@PassengerPassword", OleDb.OleDbType.VarChar)
                objParameter.Direction = ParameterDirection.Input
                objParameter.Value = strPassengerPassword

                drSourceTable = cmdSelect.ExecuteReader

                ' Read result( highest ID )
                drSourceTable.Read()

                ' Null? (empty table)

                If drSourceTable.HasRows Then
                    MessageBox.Show("Login Successful")
                    intPassenger = drSourceTable("intPassengerID")
                    Dim frmCustomerMainMenu As New frmCustomerMainMenu
                    frmCustomerMainMenu.ShowDialog()
                Else

                    MessageBox.Show("Username or Password is Incorrect")
                    Exit Sub
                End If

                'Clean up
                drSourceTable.Close()

                ' close the database connection
                CloseDatabaseConnection()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Get_And_Validate_Input(ByRef strPassengerLogin As String, ByRef strPassengerPassword As String, ByRef blnValidated As Boolean)
        Validate_Passenger_Login(strPassengerLogin, blnValidated)

        If blnValidated = True Then
            Validate_Passenger_Password(strPassengerPassword, blnValidated)
        End If
    End Sub

    Private Sub Validate_Passenger_Login(ByRef strPassengerLogin As String, ByRef blnValidated As Boolean)
        If txtPassengerLoginID.Text = String.Empty Then
            MessageBox.Show("Passenger Login ID is required")
            txtPassengerLoginID.Focus()
            blnValidated = False
            Exit Sub
        Else
            strPassengerLogin = txtPassengerLoginID.Text
        End If

    End Sub

    Private Sub Validate_Passenger_Password(ByRef strPassengerPassword As String, ByRef blnValidated As Boolean)
        If txtPassengerPassword.Text = String.Empty Then
            MessageBox.Show("Passenger Password is required")
            txtPassengerPassword.Focus()
            blnValidated = False
            Exit Sub
        Else
            strPassengerPassword = txtPassengerPassword.Text
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class