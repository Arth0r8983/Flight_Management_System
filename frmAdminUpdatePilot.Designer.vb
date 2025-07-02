<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminUpdatePilot
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPilotNames = New System.Windows.Forms.ComboBox()
        Me.btnUpdatePilot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(272, 123)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(159, 54)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Pilot to Update:"
        '
        'cboPilotNames
        '
        Me.cboPilotNames.FormattingEnabled = True
        Me.cboPilotNames.Location = New System.Drawing.Point(182, 42)
        Me.cboPilotNames.Margin = New System.Windows.Forms.Padding(1)
        Me.cboPilotNames.Name = "cboPilotNames"
        Me.cboPilotNames.Size = New System.Drawing.Size(312, 24)
        Me.cboPilotNames.TabIndex = 13
        '
        'btnUpdatePilot
        '
        Me.btnUpdatePilot.Location = New System.Drawing.Point(41, 123)
        Me.btnUpdatePilot.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUpdatePilot.Name = "btnUpdatePilot"
        Me.btnUpdatePilot.Size = New System.Drawing.Size(159, 54)
        Me.btnUpdatePilot.TabIndex = 12
        Me.btnUpdatePilot.Text = "Update Pilot"
        Me.btnUpdatePilot.UseVisualStyleBackColor = True
        '
        'frmAdminUpdatePilot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 217)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPilotNames)
        Me.Controls.Add(Me.btnUpdatePilot)
        Me.Name = "frmAdminUpdatePilot"
        Me.Text = "Admin Update Pilot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPilotNames As ComboBox
    Friend WithEvents btnUpdatePilot As Button
End Class
