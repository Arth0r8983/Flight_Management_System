<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantAdminMenu
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
        Me.btnAddAttendantsToFlights = New System.Windows.Forms.Button()
        Me.btnDeleteAttendant = New System.Windows.Forms.Button()
        Me.btnAddAttendant = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdateAttendant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddAttendantsToFlights
        '
        Me.btnAddAttendantsToFlights.Location = New System.Drawing.Point(573, 57)
        Me.btnAddAttendantsToFlights.Name = "btnAddAttendantsToFlights"
        Me.btnAddAttendantsToFlights.Size = New System.Drawing.Size(145, 54)
        Me.btnAddAttendantsToFlights.TabIndex = 5
        Me.btnAddAttendantsToFlights.Text = "Add Attendants to Future Flights"
        Me.btnAddAttendantsToFlights.UseVisualStyleBackColor = True
        '
        'btnDeleteAttendant
        '
        Me.btnDeleteAttendant.Location = New System.Drawing.Point(227, 57)
        Me.btnDeleteAttendant.Name = "btnDeleteAttendant"
        Me.btnDeleteAttendant.Size = New System.Drawing.Size(145, 54)
        Me.btnDeleteAttendant.TabIndex = 4
        Me.btnDeleteAttendant.Text = "Delete Attendant"
        Me.btnDeleteAttendant.UseVisualStyleBackColor = True
        '
        'btnAddAttendant
        '
        Me.btnAddAttendant.Location = New System.Drawing.Point(53, 57)
        Me.btnAddAttendant.Name = "btnAddAttendant"
        Me.btnAddAttendant.Size = New System.Drawing.Size(145, 54)
        Me.btnAddAttendant.TabIndex = 3
        Me.btnAddAttendant.Text = "Add Attendant"
        Me.btnAddAttendant.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(748, 57)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 54)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUpdateAttendant
        '
        Me.btnUpdateAttendant.Location = New System.Drawing.Point(401, 57)
        Me.btnUpdateAttendant.Name = "btnUpdateAttendant"
        Me.btnUpdateAttendant.Size = New System.Drawing.Size(145, 54)
        Me.btnUpdateAttendant.TabIndex = 7
        Me.btnUpdateAttendant.Text = "Update Attendant"
        Me.btnUpdateAttendant.UseVisualStyleBackColor = True
        '
        'frmAttendantAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 142)
        Me.Controls.Add(Me.btnUpdateAttendant)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddAttendantsToFlights)
        Me.Controls.Add(Me.btnDeleteAttendant)
        Me.Controls.Add(Me.btnAddAttendant)
        Me.Name = "frmAttendantAdminMenu"
        Me.Text = "Attendant Admin Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddAttendantsToFlights As Button
    Friend WithEvents btnDeleteAttendant As Button
    Friend WithEvents btnAddAttendant As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdateAttendant As Button
End Class
