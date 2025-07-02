<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrationMainMenu
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
        Me.btnManagePilots = New System.Windows.Forms.Button()
        Me.btnManageAttendants = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCreateFutureFlights = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnManagePilots
        '
        Me.btnManagePilots.Location = New System.Drawing.Point(32, 52)
        Me.btnManagePilots.Name = "btnManagePilots"
        Me.btnManagePilots.Size = New System.Drawing.Size(146, 67)
        Me.btnManagePilots.TabIndex = 0
        Me.btnManagePilots.Text = "Manage Pilots"
        Me.btnManagePilots.UseVisualStyleBackColor = True
        '
        'btnManageAttendants
        '
        Me.btnManageAttendants.Location = New System.Drawing.Point(212, 52)
        Me.btnManageAttendants.Name = "btnManageAttendants"
        Me.btnManageAttendants.Size = New System.Drawing.Size(146, 67)
        Me.btnManageAttendants.TabIndex = 1
        Me.btnManageAttendants.Text = "Manage Attendants"
        Me.btnManageAttendants.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.Location = New System.Drawing.Point(394, 52)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(146, 67)
        Me.btnStatistics.TabIndex = 2
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(757, 52)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 67)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCreateFutureFlights
        '
        Me.btnCreateFutureFlights.Location = New System.Drawing.Point(574, 52)
        Me.btnCreateFutureFlights.Name = "btnCreateFutureFlights"
        Me.btnCreateFutureFlights.Size = New System.Drawing.Size(146, 67)
        Me.btnCreateFutureFlights.TabIndex = 4
        Me.btnCreateFutureFlights.Text = "Create Future Flights"
        Me.btnCreateFutureFlights.UseVisualStyleBackColor = True
        '
        'frmAdministrationMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 173)
        Me.Controls.Add(Me.btnCreateFutureFlights)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnManageAttendants)
        Me.Controls.Add(Me.btnManagePilots)
        Me.Name = "frmAdministrationMainMenu"
        Me.Text = "Administration Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnManagePilots As Button
    Friend WithEvents btnManageAttendants As Button
    Friend WithEvents btnStatistics As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCreateFutureFlights As Button
End Class
