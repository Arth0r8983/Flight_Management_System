<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPilotAdminMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAddPilot = New System.Windows.Forms.Button()
        Me.btnDeletePilot = New System.Windows.Forms.Button()
        Me.btnAddPilotsToFlights = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdatePilot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddPilot
        '
        Me.btnAddPilot.Location = New System.Drawing.Point(54, 53)
        Me.btnAddPilot.Name = "btnAddPilot"
        Me.btnAddPilot.Size = New System.Drawing.Size(145, 54)
        Me.btnAddPilot.TabIndex = 0
        Me.btnAddPilot.Text = "Add Pilot"
        Me.btnAddPilot.UseVisualStyleBackColor = True
        '
        'btnDeletePilot
        '
        Me.btnDeletePilot.Location = New System.Drawing.Point(228, 53)
        Me.btnDeletePilot.Name = "btnDeletePilot"
        Me.btnDeletePilot.Size = New System.Drawing.Size(145, 54)
        Me.btnDeletePilot.TabIndex = 1
        Me.btnDeletePilot.Text = "Delete Pilot"
        Me.btnDeletePilot.UseVisualStyleBackColor = True
        '
        'btnAddPilotsToFlights
        '
        Me.btnAddPilotsToFlights.Location = New System.Drawing.Point(564, 53)
        Me.btnAddPilotsToFlights.Name = "btnAddPilotsToFlights"
        Me.btnAddPilotsToFlights.Size = New System.Drawing.Size(145, 54)
        Me.btnAddPilotsToFlights.TabIndex = 2
        Me.btnAddPilotsToFlights.Text = "Add Pilots to Future Flights"
        Me.btnAddPilotsToFlights.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(725, 53)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 54)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUpdatePilot
        '
        Me.btnUpdatePilot.Location = New System.Drawing.Point(396, 53)
        Me.btnUpdatePilot.Name = "btnUpdatePilot"
        Me.btnUpdatePilot.Size = New System.Drawing.Size(145, 54)
        Me.btnUpdatePilot.TabIndex = 4
        Me.btnUpdatePilot.Text = "Update Pilot"
        Me.btnUpdatePilot.UseVisualStyleBackColor = True
        '
        'frmPilotAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 150)
        Me.Controls.Add(Me.btnUpdatePilot)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddPilotsToFlights)
        Me.Controls.Add(Me.btnDeletePilot)
        Me.Controls.Add(Me.btnAddPilot)
        Me.Name = "frmPilotAdminMenu"
        Me.Text = "Pilot Admin Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddPilot As Button
    Friend WithEvents btnDeletePilot As Button
    Friend WithEvents btnAddPilotsToFlights As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdatePilot As Button
End Class
