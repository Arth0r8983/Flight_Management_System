<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteAttendant
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
        Me.btnDeleteAttendant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(262, 129)
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
        Me.Label1.Location = New System.Drawing.Point(28, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Attendant to Delete:"
        '
        'cboAttendantNames
        '
        Me.cboAttendantNames.FormattingEnabled = True
        Me.cboAttendantNames.Location = New System.Drawing.Point(172, 48)
        Me.cboAttendantNames.Margin = New System.Windows.Forms.Padding(1)
        Me.cboAttendantNames.Name = "cboAttendantNames"
        Me.cboAttendantNames.Size = New System.Drawing.Size(312, 24)
        Me.cboAttendantNames.TabIndex = 13
        '
        'btnDeleteAttendant
        '
        Me.btnDeleteAttendant.Location = New System.Drawing.Point(31, 129)
        Me.btnDeleteAttendant.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDeleteAttendant.Name = "btnDeleteAttendant"
        Me.btnDeleteAttendant.Size = New System.Drawing.Size(159, 54)
        Me.btnDeleteAttendant.TabIndex = 12
        Me.btnDeleteAttendant.Text = "Delete Attendant"
        Me.btnDeleteAttendant.UseVisualStyleBackColor = True
        '
        'frmDeleteAttendant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 216)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboAttendantNames)
        Me.Controls.Add(Me.btnDeleteAttendant)
        Me.Name = "frmDeleteAttendant"
        Me.Text = "Delete Attendant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboAttendantNames As ComboBox
    Friend WithEvents btnDeleteAttendant As Button
End Class
