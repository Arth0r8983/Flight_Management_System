<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlyMe2TheMoonStatistics
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAverageMilesFlown = New System.Windows.Forms.Label()
        Me.lblTotalFlightsTaken = New System.Windows.Forms.Label()
        Me.lblTotalPassengers = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstPilotData = New System.Windows.Forms.ListBox()
        Me.lstAttendantData = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Number of Passengers:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Flights Taken by all Passengers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Average Miles Flown for all Passengers:"
        '
        'lblAverageMilesFlown
        '
        Me.lblAverageMilesFlown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageMilesFlown.Location = New System.Drawing.Point(327, 130)
        Me.lblAverageMilesFlown.Name = "lblAverageMilesFlown"
        Me.lblAverageMilesFlown.Size = New System.Drawing.Size(131, 31)
        Me.lblAverageMilesFlown.TabIndex = 3
        '
        'lblTotalFlightsTaken
        '
        Me.lblTotalFlightsTaken.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFlightsTaken.Location = New System.Drawing.Point(327, 78)
        Me.lblTotalFlightsTaken.Name = "lblTotalFlightsTaken"
        Me.lblTotalFlightsTaken.Size = New System.Drawing.Size(131, 31)
        Me.lblTotalFlightsTaken.TabIndex = 4
        '
        'lblTotalPassengers
        '
        Me.lblTotalPassengers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPassengers.Location = New System.Drawing.Point(327, 25)
        Me.lblTotalPassengers.Name = "lblTotalPassengers"
        Me.lblTotalPassengers.Size = New System.Drawing.Size(131, 31)
        Me.lblTotalPassengers.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblTotalPassengers)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblTotalFlightsTaken)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblAverageMilesFlown)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 213)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Passenger Data"
        '
        'lstPilotData
        '
        Me.lstPilotData.FormattingEnabled = True
        Me.lstPilotData.ItemHeight = 16
        Me.lstPilotData.Location = New System.Drawing.Point(50, 37)
        Me.lstPilotData.Name = "lstPilotData"
        Me.lstPilotData.Size = New System.Drawing.Size(255, 212)
        Me.lstPilotData.TabIndex = 7
        '
        'lstAttendantData
        '
        Me.lstAttendantData.FormattingEnabled = True
        Me.lstAttendantData.ItemHeight = 16
        Me.lstAttendantData.Location = New System.Drawing.Point(356, 37)
        Me.lstAttendantData.Name = "lstAttendantData"
        Me.lstAttendantData.Size = New System.Drawing.Size(255, 212)
        Me.lstAttendantData.TabIndex = 8
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(265, 516)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 40)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmFlyMe2TheMoonStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 578)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstAttendantData)
        Me.Controls.Add(Me.lstPilotData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFlyMe2TheMoonStatistics"
        Me.Text = "FlyMe2TheMoon Statistics"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAverageMilesFlown As Label
    Friend WithEvents lblTotalFlightsTaken As Label
    Friend WithEvents lblTotalPassengers As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstPilotData As ListBox
    Friend WithEvents lstAttendantData As ListBox
    Friend WithEvents btnExit As Button
End Class
