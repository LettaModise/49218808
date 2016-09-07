<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvent
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
        Me.txtEventName = New System.Windows.Forms.TextBox()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.txtRegFee = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.dtEventDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lbEvents = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdateName = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEventName
        '
        Me.txtEventName.Enabled = False
        Me.txtEventName.Location = New System.Drawing.Point(241, 24)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(134, 20)
        Me.txtEventName.TabIndex = 0
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(241, 178)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(100, 20)
        Me.txtDistance.TabIndex = 1
        '
        'txtRegFee
        '
        Me.txtRegFee.Location = New System.Drawing.Point(241, 99)
        Me.txtRegFee.Name = "txtRegFee"
        Me.txtRegFee.Size = New System.Drawing.Size(100, 20)
        Me.txtRegFee.TabIndex = 2
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(241, 137)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(144, 20)
        Me.txtLocation.TabIndex = 3
        '
        'dtEventDate
        '
        Me.dtEventDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEventDate.Location = New System.Drawing.Point(241, 64)
        Me.dtEventDate.Name = "dtEventDate"
        Me.dtEventDate.Size = New System.Drawing.Size(100, 20)
        Me.dtEventDate.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Event Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Event Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Registration Fee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(161, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Distance"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(241, 224)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(74, 23)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lbEvents
        '
        Me.lbEvents.FormattingEnabled = True
        Me.lbEvents.Location = New System.Drawing.Point(12, 28)
        Me.lbEvents.Name = "lbEvents"
        Me.lbEvents.Size = New System.Drawing.Size(143, 251)
        Me.lbEvents.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Event Name"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(9, 286)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(146, 23)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdateName
        '
        Me.btnUpdateName.Enabled = False
        Me.btnUpdateName.Location = New System.Drawing.Point(381, 12)
        Me.btnUpdateName.Name = "btnUpdateName"
        Me.btnUpdateName.Size = New System.Drawing.Size(76, 40)
        Me.btnUpdateName.TabIndex = 17
        Me.btnUpdateName.Text = "Update Name"
        Me.btnUpdateName.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(330, 224)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 18
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'frmEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 322)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnUpdateName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbEvents)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtEventDate)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtRegFee)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.txtEventName)
        Me.Name = "frmEvent"
        Me.Text = "Event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEventName As System.Windows.Forms.TextBox
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents txtRegFee As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents dtEventDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lbEvents As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdateName As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
