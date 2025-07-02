Public Class frmEmployeeLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strEmployeeLogin As String
        Dim strEmployeePassword As String

        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim objParam As OleDb.OleDbParameter
        Dim objParameter As OleDb.OleDbParameter
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

        Dim blnValidated As Boolean = True

        Get_And_Validate_Input(strEmployeeLogin, strEmployeePassword, blnValidated)

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
                cmdSelect = New OleDb.OleDbCommand("uspPilotEmployeesLogin", m_conAdministrator)
                cmdSelect.CommandType = CommandType.StoredProcedure

                objParam = cmdSelect.Parameters.Add("@EmployeeLoginID", OleDb.OleDbType.VarChar)
                objParam.Direction = ParameterDirection.Input
                objParam.Value = strEmployeeLogin


                objParameter = cmdSelect.Parameters.Add("@EmployeePassword", OleDb.OleDbType.VarChar)
                objParameter.Direction = ParameterDirection.Input
                objParameter.Value = strEmployeePassword

                drSourceTable = cmdSelect.ExecuteReader

                ' Read result( highest ID )
                drSourceTable.Read()

                ' Null? (empty table)

                If drSourceTable.HasRows Then
                    MessageBox.Show("Login Successful")
                    intPilot = drSourceTable("intPilotID")
                    Dim frmPilotMainMenu As New frmPilotMainMenu
                    frmPilotMainMenu.ShowDialog()
                Else
                    cmdSelect = New OleDb.OleDbCommand("uspAttendantEmployeesLogin", m_conAdministrator)
                    cmdSelect.CommandType = CommandType.StoredProcedure

                    objParam = cmdSelect.Parameters.Add("@EmployeeLoginID", OleDb.OleDbType.VarChar)
                    objParam.Direction = ParameterDirection.Input
                    objParam.Value = strEmployeeLogin


                    objParameter = cmdSelect.Parameters.Add("@EmployeePassword", OleDb.OleDbType.VarChar)
                    objParameter.Direction = ParameterDirection.Input
                    objParameter.Value = strEmployeePassword

                    drSourceTable = cmdSelect.ExecuteReader

                    ' Read result( highest ID )
                    drSourceTable.Read()

                    If drSourceTable.HasRows Then
                        MessageBox.Show("Login Successful")
                        intAttendant = drSourceTable("intAttendantID")
                        Dim frmAttentantMainMenu As New frmAttendantMainMenu
                        frmAttendantMainMenu.ShowDialog()
                    Else
                        cmdSelect = New OleDb.OleDbCommand("uspAdminEmployeeLogin", m_conAdministrator)
                        cmdSelect.CommandType = CommandType.StoredProcedure

                        objParam = cmdSelect.Parameters.Add("@EmployeeLoginID", OleDb.OleDbType.VarChar)
                        objParam.Direction = ParameterDirection.Input
                        objParam.Value = strEmployeeLogin


                        objParameter = cmdSelect.Parameters.Add("@EmployeePassword", OleDb.OleDbType.VarChar)
                        objParameter.Direction = ParameterDirection.Input
                        objParameter.Value = strEmployeePassword

                        drSourceTable = cmdSelect.ExecuteReader

                        ' Read result( highest ID )
                        drSourceTable.Read()

                        If drSourceTable.HasRows Then
                            MessageBox.Show("Login Successful")
                            Dim frmAdmininstrationMainMenu As New frmAdministrationMainMenu
                            frmAdmininstrationMainMenu.ShowDialog()
                        Else

                            MessageBox.Show("Username or Password is Incorrect")
                            Exit Sub
                        End If
                    End If
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


    Private Sub Get_And_Validate_Input(ByRef strEmployeeLogin As String, ByRef strEmployeePassword As String, ByRef blnValidated As Boolean)
        Validate_Employee_Login(strEmployeeLogin, blnValidated)

        If blnValidated = True Then
            Validate_Employee_Password(strEmployeePassword, blnValidated)
        End If
    End Sub

    Private Sub Validate_Employee_Login(ByRef strEmployeeLogin As String, ByRef blnValidated As Boolean)
        If txtEmployeeLoginID.Text = String.Empty Then
            MessageBox.Show("Employee Login ID is required")
            txtEmployeeLoginID.Focus()
            blnValidated = False
            Exit Sub
        Else
            strEmployeeLogin = txtEmployeeLoginID.Text
        End If

    End Sub

    Private Sub Validate_Employee_Password(ByRef strEmployeePassword As String, ByRef blnValidated As Boolean)
        If txtEmployeePassword.Text = String.Empty Then
            MessageBox.Show("Employee Password is required")
            txtEmployeePassword.Focus()
            blnValidated = False
            Exit Sub
        Else
            strEmployeePassword = txtEmployeePassword.Text
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class