Public Class frmRaceResults

    Public myAthletesList As New ArrayList()
    Public myResultsList As New ArrayList()
    Public myEventsList As New ArrayList()

    Private Sub frmRaceResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myMethods.loadAthlete(myAthletesList, cmbAthlete)
        myMethods.loadEvents(myEventsList, cmbRace)
    End Sub

    Private Sub frmRaceResults_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If myMethods.hasErrorsRaceResults(Me, "Search") Then
            Return
        End If

        myMethods.searchAthlete(Me, txtMemNo.Text)

    End Sub

    Private Sub cmbAthlete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAthlete.SelectedIndexChanged
        myMethods.loadResults(cmbAthlete.Text, myResultsList, lbRaceResults)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If myMethods.hasErrorsRaceResults(Me, "Add") Then
            Return
        End If
        myMethods.saveRaceResultsData(myResultsList, cmbAthlete.Text, cmbRace.Text, txtResults.Text)
        myMethods.saveRaceResultsToFile(myResultsList)
        myMethods.loadResults(cmbAthlete.Text, myResultsList, lbRaceResults)
    End Sub

End Class