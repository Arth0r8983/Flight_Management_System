<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddFlight
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
        Me.cboFutureFlights = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radReservedSeat = New System.Windows.Forms.RadioButton()
        Me.radDesignatedSeat = New System.Windows.Forms.RadioButton()
        Me.lblReservedSeatCost = New System.Windows.Forms.Label()
        Me.lblDesignatedSeatCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboFutureFlights
        '
        Me.cboFutureFlights.FormattingEnabled = True
        Me.cboFutureFlights.Location = New System.Drawing.Point(163, 53)
        Me.cboFutureFlights.Name = "cboFutureFlights"
        Me.cboFutureFlights.Size = New System.Drawing.Size(178, 24)
        Me.cboFutureFlights.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Flight Dates:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(49, 120)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(124, 48)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(217, 120)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 48)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radReservedSeat
        '
        Me.radReservedSeat.AutoSize = True
        Me.radReservedSeat.Location = New System.Drawing.Point(391, 55)
        Me.radReservedSeat.Name = "radReservedSeat"
        Me.radReservedSeat.Size = New System.Drawing.Size(123, 21)
        Me.radReservedSeat.TabIndex = 4
        Me.radReservedSeat.TabStop = True
        Me.radReservedSeat.Text = "Reserved Seat"
        Me.radReservedSeat.UseVisualStyleBackColor = True
        Me.radReservedSeat.Visible = False
        '
        'radDesignatedSeat
        '
        Me.radDesignatedSeat.AutoSize = True
        Me.radDesignatedSeat.Location = New System.Drawing.Point(391, 120)
        Me.radDesignatedSeat.Name = "radDesignatedSeat"
        Me.radDesignatedSeat.Size = New System.Drawing.Size(208, 21)
        Me.radDesignatedSeat.TabIndex = 5
        Me.radDesignatedSeat.TabStop = True
        Me.radDesignatedSeat.Text = "Designated Seat at Check in"
        Me.radDesignatedSeat.UseVisualStyleBackColor = True
        Me.radDesignatedSeat.Visible = False
        '
        'lblReservedSeatCost
        '
        Me.lblReservedSeatCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReservedSeatCost.Location = New System.Drawing.Point(615, 51)
        Me.lblReservedSeatCost.Name = "lblReservedSeatCost"
        Me.lblReservedSeatCost.Size = New System.Drawing.Size(110, 26)
        Me.lblReservedSeatCost.TabIndex = 6
        Me.lblReservedSeatCost.Visible = False
        '
        'lblDesignatedSeatCost
        '
        Me.lblDesignatedSeatCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDesignatedSeatCost.Location = New System.Drawing.Point(615, 115)
        Me.lblDesignatedSeatCost.Name = "lblDesignatedSeatCost"
        Me.lblDesignatedSeatCost.Size = New System.Drawing.Size(110, 26)
        Me.lblDesignatedSeatCost.TabIndex = 7
        Me.lblDesignatedSeatCost.Visible = False
        '
        'frmAddFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 195)
        Me.Controls.Add(Me.lblDesignatedSeatCost)
        Me.Controls.Add(Me.lblReservedSeatCost)
        Me.Controls.Add(Me.radDesignatedSeat)
        Me.Controls.Add(Me.radReservedSeat)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboFutureFlights)
        Me.Name = "frmAddFlight"
        Me.Text = "Book Flight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboFutureFlights As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radReservedSeat As RadioButton
    Friend WithEvents radDesignatedSeat As RadioButton
    Friend WithEvents lblReservedSeatCost As Label
    Friend WithEvents lblDesignatedSeatCost As Label
End Class
