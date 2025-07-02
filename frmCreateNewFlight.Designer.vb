<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateNewFlight
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFlightNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTimeOfDeparture = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTimeOfLanding = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboFromAirport = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboToAirport = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMilesFlown = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboPlane = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFlightDate = New System.Windows.Forms.TextBox()
        Me.btnAddFlight = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Flight Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Flight Number:"
        '
        'txtFlightNumber
        '
        Me.txtFlightNumber.Location = New System.Drawing.Point(188, 96)
        Me.txtFlightNumber.Name = "txtFlightNumber"
        Me.txtFlightNumber.Size = New System.Drawing.Size(121, 22)
        Me.txtFlightNumber.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Time of Departure:"
        '
        'txtTimeOfDeparture
        '
        Me.txtTimeOfDeparture.Location = New System.Drawing.Point(188, 151)
        Me.txtTimeOfDeparture.Name = "txtTimeOfDeparture"
        Me.txtTimeOfDeparture.Size = New System.Drawing.Size(121, 22)
        Me.txtTimeOfDeparture.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Time of Landing:"
        '
        'txtTimeOfLanding
        '
        Me.txtTimeOfLanding.Location = New System.Drawing.Point(188, 211)
        Me.txtTimeOfLanding.Name = "txtTimeOfLanding"
        Me.txtTimeOfLanding.Size = New System.Drawing.Size(121, 22)
        Me.txtTimeOfLanding.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "From Airport:"
        '
        'cboFromAirport
        '
        Me.cboFromAirport.FormattingEnabled = True
        Me.cboFromAirport.Location = New System.Drawing.Point(188, 269)
        Me.cboFromAirport.Name = "cboFromAirport"
        Me.cboFromAirport.Size = New System.Drawing.Size(121, 24)
        Me.cboFromAirport.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "To Airport:"
        '
        'cboToAirport
        '
        Me.cboToAirport.FormattingEnabled = True
        Me.cboToAirport.Location = New System.Drawing.Point(188, 329)
        Me.cboToAirport.Name = "cboToAirport"
        Me.cboToAirport.Size = New System.Drawing.Size(121, 24)
        Me.cboToAirport.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Miles Flown:"
        '
        'txtMilesFlown
        '
        Me.txtMilesFlown.Location = New System.Drawing.Point(188, 395)
        Me.txtMilesFlown.Name = "txtMilesFlown"
        Me.txtMilesFlown.Size = New System.Drawing.Size(121, 22)
        Me.txtMilesFlown.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 461)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Plane:"
        '
        'cboPlane
        '
        Me.cboPlane.FormattingEnabled = True
        Me.cboPlane.Location = New System.Drawing.Point(188, 458)
        Me.cboPlane.Name = "cboPlane"
        Me.cboPlane.Size = New System.Drawing.Size(121, 24)
        Me.cboPlane.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFlightDate)
        Me.GroupBox1.Controls.Add(Me.txtTimeOfLanding)
        Me.GroupBox1.Controls.Add(Me.cboPlane)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMilesFlown)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtFlightNumber)
        Me.GroupBox1.Controls.Add(Me.cboToAirport)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtTimeOfDeparture)
        Me.GroupBox1.Controls.Add(Me.cboFromAirport)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 522)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flight Info"
        '
        'txtFlightDate
        '
        Me.txtFlightDate.Location = New System.Drawing.Point(188, 39)
        Me.txtFlightDate.Name = "txtFlightDate"
        Me.txtFlightDate.Size = New System.Drawing.Size(121, 22)
        Me.txtFlightDate.TabIndex = 16
        '
        'btnAddFlight
        '
        Me.btnAddFlight.Location = New System.Drawing.Point(167, 584)
        Me.btnAddFlight.Name = "btnAddFlight"
        Me.btnAddFlight.Size = New System.Drawing.Size(177, 57)
        Me.btnAddFlight.TabIndex = 17
        Me.btnAddFlight.Text = "Add Flight"
        Me.btnAddFlight.UseVisualStyleBackColor = True
        '
        'frmCreateNewFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 680)
        Me.Controls.Add(Me.btnAddFlight)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCreateNewFlight"
        Me.Text = "Create New Flight"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFlightNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTimeOfDeparture As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTimeOfLanding As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboFromAirport As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboToAirport As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMilesFlown As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboPlane As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFlightDate As TextBox
    Friend WithEvents btnAddFlight As Button
End Class
