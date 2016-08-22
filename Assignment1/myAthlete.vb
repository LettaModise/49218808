Public Class myAthlete

    'Second class athletes'

    Private myMemberNo As Double
    Private myNameSur As String
    Private myBirthDate As Date
    Private myGender As String
    Private myDateJoined As Date
    Private myMemFeeOut As Double
    Private myRaceResults = New myRaceResults
    Private myRaceResultList = New ArrayList()



    Property MemberNo As Double
        Get
            Return myMemberNo
        End Get

        Set(value As Double)
            myMemberNo = value
        End Set
    End Property

    Property NameSur As String
        Get
            Return myNameSur
        End Get

        Set(value As String)
            myNameSur = value
        End Set
    End Property

    Property BirthDate As Date
        Get
            Return myBirthDate
        End Get

        Set(value As Date)
            myBirthDate = value
        End Set
    End Property

    Property Gender As String
        Get
            Return myGender
        End Get

        Set(value As String)
            myGender = value
        End Set
    End Property

    Property DateJoined As Date
        Get
            Return myDateJoined
        End Get

        Set(value As Date)
            myDateJoined = value
        End Set
    End Property

    Property MemFeeOut As Double
        Get
            Return myMemFeeOut
        End Get

        Set(value As Double)
            myMemFeeOut = value
        End Set
    End Property


    ReadOnly Property raceResultsList As ArrayList
        Get
            Return myRaceResultList
        End Get
    End Property

    Public Sub addRaceResult(ByVal eventID As String, ByVal membNo As Double, ByVal finishTime As Integer)

        Dim myRaceResult As New myRaceResults

        myRaceResults.eventID = eventID
        myRaceResults.MembershipNo = membNo
        myRaceResults.FinishTime = finishTime

        myRaceResultList.Add(myRaceResult)


    End Sub


End Class
