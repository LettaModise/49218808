Public Class Form1
    Dim myAthleteForm = New frmAthlete()
    Dim myEventForm = New frmEvent()
    Dim myRaceResults = New frmRaceResults()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myAthleteForm.MdiParent = Me
        myEventForm.MdiParent = Me
        myRaceResults.MdiParent = Me


        '''''''''''''''''''''

        'Create instance'
        Dim MyRace1 As New myEvent

        MyRace1.Title = "Durban Race"
        MyRace1.EveDate = "2016/01/01"
        MyRace1.RegFee = 1000.0
        MyRace1.Location = "Durban"
        MyRace1.Distance = 65


        Dim MyRace2 As New myEvent

        MyRace2.Title = "Cape Town Race"
        MyRace2.EveDate = "2016/01/01"
        MyRace2.RegFee = 1000.0
        MyRace2.Location = "Cape Town Race"
        MyRace2.Distance = 65

        
     



       


        '' Dim myFileIO As New fileIO
        '' myFileIO.writeLine("Events.txt", event1.Distance & "," & event1.EveDate)
        '' myFileIO.writeLine("Events.txt", event2.Distance & "," & event2.EveDate)

        ''''''''''''''''''''

    End Sub

   

    Private Sub AthleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AthleteToolStripMenuItem.Click
        myAthleteForm.show()

    End Sub

    Private Sub EventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventsToolStripMenuItem.Click
        myEventForm.show()
    End Sub

    Private Sub RaceResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RaceResultsToolStripMenuItem.Click
        myRaceResults.show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub
End Class
