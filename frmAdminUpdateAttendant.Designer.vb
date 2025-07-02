<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminUpdateAttendant
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
        Me.cboAttendantNames = New System.Windows.Forms.ComboBox()
        Me.btnUpdateAttendant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(281, 134)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(159, 54)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Attendant to Update:"
        '
        'cboAttendantNames
        '
        Me.cboAttendantNames.FormattingEnabled = True
        Me.cboAttendantNames.Location = New System.Drawing.Point(191, 53)
        Me.cboAttendantNames.Margin = New System.Windows.Forms.Padding(1)
        Me.cboAttendantNames.Name = "cboAttendantNames"
        Me.cboAttendantNames.Size = New System.Drawing.Size(312, 24)
        Me.cboAttendantNames.TabIndex = 17
        '
        'btnUpdateAttendant
        '
        Me.btnUpdateAttendant.Location = New System.Drawing.Point(50, 134)
        Me.btnUpdateAttendant.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUpdateAttendant.Name = "btnUpdateAttendant"
        Me.btnUpdateAttendant.Size = New System.Drawing.Size(159, 54)
        Me.btnUpdateAttendant.TabIndex = 16
        Me.btnUpdateAttendant.Text = "Update Attendant"
        Me.btnUpdateAttendant.UseVisualStyleBackColor = True
        '
        'frmAdminUpdateAttendant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 227)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboAttendantNames)
        Me.Controls.Add(Me.btnUpdateAttendant)
        Me.Name = "frmAdminUpdateAttendant"
        Me.Text = "Admin Update Attendant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboAttendantNames As ComboBox
    Friend WithEvents btnUpdateAttendant As Button
End Class
