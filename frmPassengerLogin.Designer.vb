<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassengerLogin
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
        Me.txtPassengerLoginID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassengerPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnNewPassenger = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPassengerLoginID
        '
        Me.txtPassengerLoginID.Location = New System.Drawing.Point(156, 57)
        Me.txtPassengerLoginID.Name = "txtPassengerLoginID"
        Me.txtPassengerLoginID.Size = New System.Drawing.Size(144, 22)
        Me.txtPassengerLoginID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'txtPassengerPassword
        '
        Me.txtPassengerPassword.Location = New System.Drawing.Point(156, 111)
        Me.txtPassengerPassword.Name = "txtPassengerPassword"
        Me.txtPassengerPassword.Size = New System.Drawing.Size(144, 22)
        Me.txtPassengerPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(30, 178)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(132, 47)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnNewPassenger
        '
        Me.btnNewPassenger.Location = New System.Drawing.Point(193, 178)
        Me.btnNewPassenger.Name = "btnNewPassenger"
        Me.btnNewPassenger.Size = New System.Drawing.Size(132, 47)
        Me.btnNewPassenger.TabIndex = 5
        Me.btnNewPassenger.Text = "New Passenger"
        Me.btnNewPassenger.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(114, 245)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 47)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPassengerLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 310)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewPassenger)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassengerPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassengerLoginID)
        Me.Name = "frmPassengerLogin"
        Me.Text = "Passenger Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPassengerLoginID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassengerPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnNewPassenger As Button
    Friend WithEvents btnExit As Button
End Class
