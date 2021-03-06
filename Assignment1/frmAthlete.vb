﻿Public Class frmAthlete
    Public myAthletesList As New ArrayList()
    Public isUpdate As Boolean = True

    Private Sub frmAthlete_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub frmAthlete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myMethods.loadAthletes(Me)
    End Sub 
    

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        myMethods.searchAthlete(Me, txtMemNo.Text)


    End Sub

    Private Sub lbAthletes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAthletes.SelectedIndexChanged

        setFormControl(True)

        txtMemNo.Text = lbAthletes.Text
        myMethods.selectAthlete(Me)
        'btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
  
        Dim myNewMembNo As String

        If myMethods.hasErrorsAthlete(Me) Then
            Return
        End If


        If isUpdate = False Then
            myNewMembNo = myMethods.genNewMemNo(dtpBrthDate.Value)
            txtMemNo.Text = myNewMembNo
        End If


        myMethods.saveAthleteData(isUpdate, myAthletesList, txtMemNo.Text, txtNameSur.Text, dtpBrthDate.Value, myMethods.getGender(Me), dtpDateJoined.Value, txtFeeOutstanding.Text)
        'myMethods.saveAthletesToFile(myAthletesList)
        myMethods.loadAthletes(Me)
        myMethods.setSelectedAthlete(Me)

        txtMemNo.Visible = True
        btnUpdate.Text = "Update"
        isUpdate = True
        btnNew.Visible = True

    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        setFormControl(True)

        isUpdate = False
        txtMemNo.Visible = False
        txtMemNo.Text = ""
        txtNameSur.Text = ""
        txtFeeOutstanding.Text = ""
        btnNew.Visible = False
        btnUpdate.Enabled = True
        btnUpdate.Text = "Save"

    End Sub

    Public Sub setFormControl(ByRef enable As Boolean)
        If enable Then

            txtNameSur.Enabled = True
            dtpBrthDate.Enabled = True
            rbMale.Enabled = True
            rbFemale.Enabled = True
            dtpDateJoined.Enabled = True
            txtFeeOutstanding.Enabled = True
        Else

            txtNameSur.Enabled = False
            dtpBrthDate.Enabled = False
            rbMale.Enabled = False
            rbFemale.Enabled = False
            dtpDateJoined.Enabled = False
            txtFeeOutstanding.Enabled = False

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If myMethods.getAthResults(txtMemNo.Text) = 0 Then
            'delete athlete

            myMethods.deleteAthlete(txtMemNo.Text)

            myMethods.loadAthletes(Me)

            txtMemNo.Text = ""
            txtFeeOutstanding.Text = ""
            setFormControl(False)
            btnUpdate.Enabled = False

        Else
            'do nothing

            Try
                Throw New System.Exception("You can not delete record as athlete has records")
            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try


        End If
    End Sub
End Class