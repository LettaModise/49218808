<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAthlete
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
        Me.txtMemNo = New System.Windows.Forms.TextBox()
        Me.lblMemNo = New System.Windows.Forms.Label()
        Me.lblNamSur = New System.Windows.Forms.Label()
        Me.txtNameSur = New System.Windows.Forms.TextBox()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDateJoined = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpBrthDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateJoined = New System.Windows.Forms.DateTimePicker()
        Me.txtFeeOutstanding = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.lbAthletes = New System.Windows.Forms.ListBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMemNo
        '
        Me.txtMemNo.Location = New System.Drawing.Point(23, 22)
        Me.txtMemNo.Name = "txtMemNo"
        Me.txtMemNo.Size = New System.Drawing.Size(120, 20)
        Me.txtMemNo.TabIndex = 0
        '
        'lblMemNo
        '
        Me.lblMemNo.AutoSize = True
        Me.lblMemNo.Location = New System.Drawing.Point(20, 6)
        Me.lblMemNo.Name = "lblMemNo"
        Me.lblMemNo.Size = New System.Drawing.Size(62, 13)
        Me.lblMemNo.TabIndex = 1
        Me.lblMemNo.Text = "Member No"
        '
        'lblNamSur
        '
        Me.lblNamSur.AutoSize = True
        Me.lblNamSur.Location = New System.Drawing.Point(153, 89)
        Me.lblNamSur.Name = "lblNamSur"
        Me.lblNamSur.Size = New System.Drawing.Size(101, 13)
        Me.lblNamSur.TabIndex = 2
        Me.lblNamSur.Text = "Name and Surname"
        '
        'txtNameSur
        '
        Me.txtNameSur.Location = New System.Drawing.Point(272, 86)
        Me.txtNameSur.Name = "txtNameSur"
        Me.txtNameSur.Size = New System.Drawing.Size(161, 20)
        Me.txtNameSur.TabIndex = 3
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Location = New System.Drawing.Point(153, 137)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(54, 13)
        Me.lblBirthDate.TabIndex = 5
        Me.lblBirthDate.Text = "Birth Date"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(153, 166)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender"
        '
        'lblDateJoined
        '
        Me.lblDateJoined.AutoSize = True
        Me.lblDateJoined.Location = New System.Drawing.Point(153, 199)
        Me.lblDateJoined.Name = "lblDateJoined"
        Me.lblDateJoined.Size = New System.Drawing.Size(64, 13)
        Me.lblDateJoined.TabIndex = 7
        Me.lblDateJoined.Text = "Date Joined"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fee outstanding"
        '
        'dtpBrthDate
        '
        Me.dtpBrthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBrthDate.Location = New System.Drawing.Point(272, 130)
        Me.dtpBrthDate.Name = "dtpBrthDate"
        Me.dtpBrthDate.Size = New System.Drawing.Size(161, 20)
        Me.dtpBrthDate.TabIndex = 10
        '
        'dtpDateJoined
        '
        Me.dtpDateJoined.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateJoined.Location = New System.Drawing.Point(272, 192)
        Me.dtpDateJoined.Name = "dtpDateJoined"
        Me.dtpDateJoined.Size = New System.Drawing.Size(161, 20)
        Me.dtpDateJoined.TabIndex = 11
        '
        'txtFeeOutstanding
        '
        Me.txtFeeOutstanding.Location = New System.Drawing.Point(272, 228)
        Me.txtFeeOutstanding.Name = "txtFeeOutstanding"
        Me.txtFeeOutstanding.Size = New System.Drawing.Size(161, 20)
        Me.txtFeeOutstanding.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Athletes List"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(156, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(272, 161)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(48, 17)
        Me.rbMale.TabIndex = 16
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(374, 161)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbFemale.TabIndex = 17
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'lbAthletes
        '
        Me.lbAthletes.FormattingEnabled = True
        Me.lbAthletes.Location = New System.Drawing.Point(23, 89)
        Me.lbAthletes.Name = "lbAthletes"
        Me.lbAthletes.Size = New System.Drawing.Size(120, 238)
        Me.lbAthletes.TabIndex = 18
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(272, 269)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(354, 269)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 20
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'frmAthlete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 337)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lbAthletes)
        Me.Controls.Add(Me.rbFemale)
        Me.Controls.Add(Me.rbMale)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFeeOutstanding)
        Me.Controls.Add(Me.dtpDateJoined)
        Me.Controls.Add(Me.dtpBrthDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDateJoined)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblBirthDate)
        Me.Controls.Add(Me.txtNameSur)
        Me.Controls.Add(Me.lblNamSur)
        Me.Controls.Add(Me.lblMemNo)
        Me.Controls.Add(Me.txtMemNo)
        Me.Name = "frmAthlete"
        Me.Text = "Athlete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMemNo As System.Windows.Forms.TextBox
    Friend WithEvents lblMemNo As System.Windows.Forms.Label
    Friend WithEvents lblNamSur As System.Windows.Forms.Label
    Friend WithEvents txtNameSur As System.Windows.Forms.TextBox
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblDateJoined As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpBrthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateJoined As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFeeOutstanding As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents lbAthletes As System.Windows.Forms.ListBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
