<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.radPassenger = New System.Windows.Forms.RadioButton()
        Me.radPilot = New System.Windows.Forms.RadioButton()
        Me.radAttendant = New System.Windows.Forms.RadioButton()
        Me.radAdministration = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radPassenger
        '
        Me.radPassenger.AutoSize = True
        Me.radPassenger.Location = New System.Drawing.Point(31, 38)
        Me.radPassenger.Name = "radPassenger"
        Me.radPassenger.Size = New System.Drawing.Size(97, 21)
        Me.radPassenger.TabIndex = 1
        Me.radPassenger.TabStop = True
        Me.radPassenger.Text = "Passenger"
        Me.radPassenger.UseVisualStyleBackColor = True
        '
        'radPilot
        '
        Me.radPilot.AutoSize = True
        Me.radPilot.Location = New System.Drawing.Point(31, 88)
        Me.radPilot.Name = "radPilot"
        Me.radPilot.Size = New System.Drawing.Size(56, 21)
        Me.radPilot.TabIndex = 2
        Me.radPilot.TabStop = True
        Me.radPilot.Text = "Pilot"
        Me.radPilot.UseVisualStyleBackColor = True
        '
        'radAttendant
        '
        Me.radAttendant.AutoSize = True
        Me.radAttendant.Location = New System.Drawing.Point(31, 139)
        Me.radAttendant.Name = "radAttendant"
        Me.radAttendant.Size = New System.Drawing.Size(90, 21)
        Me.radAttendant.TabIndex = 3
        Me.radAttendant.TabStop = True
        Me.radAttendant.Text = "Attendant"
        Me.radAttendant.UseVisualStyleBackColor = True
        '
        'radAdministration
        '
        Me.radAdministration.AutoSize = True
        Me.radAdministration.Location = New System.Drawing.Point(31, 189)
        Me.radAdministration.Name = "radAdministration"
        Me.radAdministration.Size = New System.Drawing.Size(118, 21)
        Me.radAdministration.TabIndex = 4
        Me.radAdministration.TabStop = True
        Me.radAdministration.Text = "Administration"
        Me.radAdministration.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radPassenger)
        Me.GroupBox1.Controls.Add(Me.radAdministration)
        Me.GroupBox1.Controls.Add(Me.radAttendant)
        Me.GroupBox1.Controls.Add(Me.radPilot)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 238)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "What type of user are you?"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(98, 294)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(143, 52)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 376)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUser"
        Me.Text = "User Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radPassenger As RadioButton
    Friend WithEvents radPilot As RadioButton
    Friend WithEvents radAttendant As RadioButton
    Friend WithEvents radAdministration As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSubmit As Button
End Class
