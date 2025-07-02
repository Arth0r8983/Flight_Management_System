<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerNavigation
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
        Me.cboPassengerNames = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddNewPassenger = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboPassengerNames
        '
        Me.cboPassengerNames.FormattingEnabled = True
        Me.cboPassengerNames.Location = New System.Drawing.Point(213, 45)
        Me.cboPassengerNames.Name = "cboPassengerNames"
        Me.cboPassengerNames.Size = New System.Drawing.Size(172, 24)
        Me.cboPassengerNames.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Passenger Name:"
        '
        'btnAddNewPassenger
        '
        Me.btnAddNewPassenger.Location = New System.Drawing.Point(46, 115)
        Me.btnAddNewPassenger.Name = "btnAddNewPassenger"
        Me.btnAddNewPassenger.Size = New System.Drawing.Size(143, 45)
        Me.btnAddNewPassenger.TabIndex = 2
        Me.btnAddNewPassenger.Text = "Add New Passenger"
        Me.btnAddNewPassenger.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(242, 115)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(143, 45)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(434, 115)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 45)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCustomerNavigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 192)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnAddNewPassenger)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPassengerNames)
        Me.Name = "frmCustomerNavigation"
        Me.Text = "Passenger Navigation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboPassengerNames As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddNewPassenger As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
End Class
