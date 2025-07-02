<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnUpdatePassenger = New System.Windows.Forms.Button()
        Me.btnAddFlight = New System.Windows.Forms.Button()
        Me.btnShowPastFlights = New System.Windows.Forms.Button()
        Me.btnShowFutureFlights = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUpdatePassenger
        '
        Me.btnUpdatePassenger.Location = New System.Drawing.Point(85, 53)
        Me.btnUpdatePassenger.Name = "btnUpdatePassenger"
        Me.btnUpdatePassenger.Size = New System.Drawing.Size(155, 62)
        Me.btnUpdatePassenger.TabIndex = 0
        Me.btnUpdatePassenger.Text = "Update Passenger Profile"
        Me.btnUpdatePassenger.UseVisualStyleBackColor = True
        '
        'btnAddFlight
        '
        Me.btnAddFlight.Location = New System.Drawing.Point(285, 53)
        Me.btnAddFlight.Name = "btnAddFlight"
        Me.btnAddFlight.Size = New System.Drawing.Size(155, 62)
        Me.btnAddFlight.TabIndex = 1
        Me.btnAddFlight.Text = "Add Flight"
        Me.btnAddFlight.UseVisualStyleBackColor = True
        '
        'btnShowPastFlights
        '
        Me.btnShowPastFlights.Location = New System.Drawing.Point(85, 162)
        Me.btnShowPastFlights.Name = "btnShowPastFlights"
        Me.btnShowPastFlights.Size = New System.Drawing.Size(155, 62)
        Me.btnShowPastFlights.TabIndex = 2
        Me.btnShowPastFlights.Text = "Show Past Flights"
        Me.btnShowPastFlights.UseVisualStyleBackColor = True
        '
        'btnShowFutureFlights
        '
        Me.btnShowFutureFlights.Location = New System.Drawing.Point(285, 162)
        Me.btnShowFutureFlights.Name = "btnShowFutureFlights"
        Me.btnShowFutureFlights.Size = New System.Drawing.Size(155, 62)
        Me.btnShowFutureFlights.TabIndex = 3
        Me.btnShowFutureFlights.Text = "Show Future Flights"
        Me.btnShowFutureFlights.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(183, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(155, 62)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCustomerMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 331)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowFutureFlights)
        Me.Controls.Add(Me.btnShowPastFlights)
        Me.Controls.Add(Me.btnAddFlight)
        Me.Controls.Add(Me.btnUpdatePassenger)
        Me.Name = "frmCustomerMainMenu"
        Me.Text = "Customer Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUpdatePassenger As Button
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents btnShowPastFlights As Button
    Friend WithEvents btnShowFutureFlights As Button
    Friend WithEvents btnExit As Button
End Class
