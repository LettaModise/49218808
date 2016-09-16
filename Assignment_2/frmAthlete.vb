Public Class frmAthlete
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
        MessageBox.Show("Select or enter athlete member number")
        Return
    End Sub

    Private Sub lbAthletes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAthletes.SelectedIndexChanged
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
        myMethods.saveAthletesToFile(myAthletesList)
        myMethods.loadAthletes(Me)
        myMethods.setSelectedAthlete(Me)

        txtMemNo.Visible = True
        btnUpdate.Text = "Update"
        isUpdate = True
        btnNew.Visible = True

    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        isUpdate = False
        txtMemNo.Visible = False
        txtMemNo.Text = ""
        txtNameSur.Text = ""
        txtFeeOutstanding.Text = ""
        btnNew.Visible = False
        btnUpdate.Enabled = True
        btnUpdate.Text = "Save"

    End Sub

   
End Class