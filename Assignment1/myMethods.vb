Friend NotInheritable Class myMethods

    ''Events


    Public Shared Sub loadEvents(ByRef myEventsList As ArrayList, ByRef lb As ListBox)
        ''Dim myFileContents As New ArrayList()
        myEventsList.Clear()

        Dim myDT As New DataTable

        myDT = fileIO.selectDBData("SELECT * FROM Events")

        'Fill the listbox
        lb.Items.Clear()

        Dim row As DataRow

        For Each row In myDT.Rows
            lb.Items.Add(row.Item(4).ToString())
            Dim myRace As New myEvent

            ''result = myFileContents.Item(i)
            myRace.Distance = row.Item(0)
            myRace.EveDate = row.Item(1)
            myRace.Location = row.Item(2)
            myRace.RegFee = row.Item(3)
            myRace.Title = row.Item(4)
            myEventsList.Add(myRace)

        Next




    End Sub

    Public Shared Sub loadEvents(ByRef myEventsList As ArrayList, ByRef cmb As ComboBox)
        ''Dim myFileContents As New ArrayList()
        myEventsList.Clear()

        Dim myDT As New DataTable

        myDT = fileIO.selectDBData("SELECT * FROM Events")

        'Fill the listbox
        cmb.Items.Clear()

        Dim row As DataRow

        For Each row In myDT.Rows
            cmb.Items.Add(row.Item(4).ToString())
            Dim myRace As New myEvent

            ''result = myFileContents.Item(i)

            myRace.Distance = row.Item(0)
            myRace.EveDate = row.Item(1)
            myRace.Location = row.Item(2)
            myRace.RegFee = row.Item(3)
            myRace.Title = row.Item(4)
            myEventsList.Add(myRace)

        Next
    End Sub


    Public Shared Sub saveEventData(ByRef myEventsList As ArrayList, ByVal isUpdateName As Boolean, ByVal oldEventName As String, ByVal eventName As String, eventDate As Date, regFee As Double, ByVal location As String, ByVal distance As Double)
        Dim isUpdate As Boolean = False
        Dim mySQL

        If isUpdateName Then
            For Each EventItem As myEvent In myEventsList

                If EventItem.Title = Trim(oldEventName) Then
                    EventItem.Title = eventName
                    EventItem.EveDate = eventDate
                    EventItem.RegFee = regFee
                    EventItem.Location = location
                    EventItem.Distance = distance
                    isUpdate = True
                End If
            Next


            mySQL = "UPDATE Events " & _
                   "SET EventTitle = '" & eventName & "'" & _
                      ",EventDate = '" & eventDate.ToShortDateString() & "'" & _
                      ",RegistrationFee = '" & regFee & "'" & _
                      ",EventLocation = '" & location & "'" & _
                      ",Distance = '" & distance & "'" & _
                 " WHERE EventTitle = '" & oldEventName & "'"

            fileIO.modifyDBData(mySql)
        End If


        If Not isUpdateName Then
            For Each EventItem As myEvent In myEventsList
                If EventItem.Title = eventName Then
                    EventItem.EveDate = eventDate
                    EventItem.RegFee = regFee
                    EventItem.Location = location
                    EventItem.Distance = distance
                    isUpdate = True
                End If
            Next

            mySQL = "UPDATE Events " & _
          "SET " & _
               "EventDate = '" & eventDate.ToShortDateString() & "'" & _
               ",RegistrationFee = '" & regFee & "'" & _
               ",EventLocation = '" & location & "'" & _
               ",Distance = '" & distance & "'" & _
          " WHERE EventTitle = '" & eventName & "'"

            fileIO.modifyDBData(mySQL)
        End If


        If isUpdate = False And isUpdateName = False Then
            Dim newEvent As New myEvent
            newEvent.Title = eventName
            newEvent.EveDate = eventDate
            newEvent.RegFee = regFee
            newEvent.Location = location
            newEvent.Distance = distance

            myEventsList.Add(newEvent)

            mySQL = "INSERT INTO Events (EventTitle, EventDate,RegistrationFee,EventLocation,Distance) " & _
                   "VALUES ('" & eventName & "','" & eventDate.ToShortDateString() & "','" & regFee & "','" & location & "','" & distance & "')"

            fileIO.modifyDBData(mySQL)
        End If






    End Sub


    Public Shared Sub saveEventsToFile(ByVal eventsList As ArrayList)

        Dim myDelimString As String

        For i As Integer = 0 To eventsList.Count - 1
            Dim myEvent As New myEvent

            myEvent = eventsList.Item(i)

            myDelimString = myEvent.Distance & "," & myEvent.EveDate & "," & myEvent.Location & "," & myEvent.RegFee & "," & myEvent.Title


            If i = 0 Then
                fileIO.writeLine("Events.txt", myDelimString, False)
            Else
                fileIO.writeLine("Events.txt", myDelimString, True)
            End If

        Next

    End Sub


    Public Shared Sub deleteEvent(ByRef eventsList As ArrayList, ByVal eventName As String)


        For i As Integer = 0 To eventsList.Count - 1
            Dim myEvent As New myEvent
            myEvent = eventsList.Item(i)

            If myEvent.Title = eventName Then
                eventsList.RemoveAt(i)
                Exit For
            End If
        Next

        saveEventsToFile(eventsList)

    End Sub

    ''Athletes
    Public Shared Sub loadAthlete(ByRef myAthleteList As ArrayList, ByRef lb As ListBox)
        ' Dim myFileContents As New ArrayList()
        myAthleteList.Clear()

        'myFileContents = fileIO.readFile("Athlete.txt")

        Dim myDT As New DataTable

        myDT = fileIO.selectDBData("SELECT * FROM Athletes")


        Dim row As DataRow

        For Each row In myDT.Rows

            ''Dim result As String()
            Dim myAthlete As New myAthlete

            ''result = myFileContents.Item(i)

            myAthlete.MemberNo = row.Item(0)
            myAthlete.NameSur = row.Item(1)
            myAthlete.BirthDate = row.Item(2)
            myAthlete.Gender = row.Item(3)
            myAthlete.DateJoined = row.Item(4)
            myAthlete.MemFeeOut = row.Item(5)

            myAthleteList.Add(myAthlete)

        Next

        ''Add Athlete to listbox
        For Each record As myAthlete In myAthleteList
            lb.Items.Add(record.MemberNo)
        Next
    End Sub

    Public Shared Sub loadAthlete(ByRef myAthleteList As ArrayList, ByRef cmb As ComboBox)
        'Dim myFileContents As New ArrayList()
        myAthleteList.Clear()

        'myFileContents = fileIO.readFile("Athlete.txt")

        Dim myDT As New DataTable

        myDT = fileIO.selectDBData("SELECT * FROM Athletes")


        Dim row As DataRow

        For Each row In myDT.Rows

            ''Dim result As String()
            Dim myAthlete As New myAthlete

            ''result = myFileContents.Item(i)

            myAthlete.MemberNo = row.Item(0)
            myAthlete.NameSur = row.Item(1)
            myAthlete.BirthDate = row.Item(2)
            myAthlete.Gender = row.Item(3)
            myAthlete.DateJoined = row.Item(4)
            myAthlete.MemFeeOut = row.Item(5)

            myAthleteList.Add(myAthlete)

        Next

        ''Add Athlete to listbox
        For Each record As myAthlete In myAthleteList
            cmb.Items.Add(record.MemberNo)
        Next

    End Sub



    


    Public Shared Sub saveAthleteData(ByVal isUpdate As Boolean, ByRef myAthletesList As ArrayList, ByVal membNo As String, NameSurname As String, birthDate As Date, ByVal gender As String, ByVal dateJoined As Date, ByVal regFeeOutStanding As Double)
        '' Dim isUpdate As Boolean = False
        Dim mySQL As String
        If isUpdate Then
            For Each AthItem As myAthlete In myAthletesList
                If membNo = AthItem.MemberNo Then
                    AthItem.NameSur = NameSurname
                    AthItem.BirthDate = birthDate
                    AthItem.Gender = gender
                    AthItem.DateJoined = dateJoined
                    AthItem.MemFeeOut = regFeeOutStanding
                End If


            Next

            mySQL = "UPDATE Athletes " & _
                 " SET NameSurname = '" & NameSurname & "'" & _
                 ",BirthDate = '" & birthDate.ToShortDateString() & "'" & _
                 ",Gender = '" & gender & "'" & _
                 ",JoinDate = '" & dateJoined.ToShortDateString() & "'" & _
                 ",OutFee = '" & regFeeOutStanding & "'" & _
                 " WHERE memno = '" & membNo & "'"
            fileIO.modifyDBData(mySql)
        Else
            Dim AthItem As New myAthlete
            AthItem.MemberNo = membNo
            AthItem.NameSur = NameSurname
            AthItem.BirthDate = birthDate
            AthItem.Gender = gender
            AthItem.DateJoined = dateJoined
            AthItem.MemFeeOut = regFeeOutStanding

            myAthletesList.Add(AthItem)

            mySQL = "INSERT INTO Athletes (MemNo,NameSurname,BirthDate,Gender,JoinDate,OutFee)" & _
            " VALUES ('" & membNo & "','" & NameSurname & "','" & birthDate.ToShortDateString() & "','" & gender & "','" & dateJoined.ToShortDateString() & "','" & regFeeOutStanding & "')"
            fileIO.modifyDBData(mySQL)
        End If


       

    End Sub


    Public Shared Sub saveAthletesToFile(ByVal athletesList As ArrayList)

        Dim myDelimString As String

        For i As Integer = 0 To athletesList.Count - 1
            Dim myAth As New myAthlete

            myAth = athletesList.Item(i)

            myDelimString = myAth.MemberNo & "," & myAth.NameSur & "," & myAth.BirthDate & "," & myAth.Gender & "," & myAth.DateJoined & "," & myAth.MemFeeOut


            If i = 0 Then
                fileIO.writeLine("Athletes.txt", myDelimString, False)
            Else
                fileIO.writeLine("Athletes.txt", myDelimString, True)
            End If

        Next

    End Sub


    Public Shared Sub deleteAthlete(ByRef athletesList As ArrayList, ByVal membNo As String)


        For i As Integer = 0 To athletesList.Count - 1
            Dim myAth As New myAthlete
            myAth = athletesList.Item(i)

            If myAth.MemberNo = membNo Then
                athletesList.RemoveAt(i)
                Exit For
            End If
        Next

        saveAthletesToFile(athletesList)

    End Sub





    Public Shared Sub loadResults(ByVal membNo As Double, ByRef myResultsList As ArrayList, ByRef lb As ListBox)
        Try


            myResultsList.Clear()
            lb.Items.Clear()

            Dim myRes As myRaceResults = Nothing
            Dim myDT As New DataTable
            Dim mySql

            mySql = "SELECT MemNo,EventName,result FROM RaceResults;"

            myDT = fileIO.selectDBData(mySql)


            Dim row As DataRow

            For Each row In myDT.Rows

                myRes = New myRaceResults

                myRes.MembershipNo = row.Item(0)
                myRes.eventID = row.Item(1)
                myRes.FinishTime = row.Item(2)

                myResultsList.Add(myRes)

                If membNo = row.Item(0) Then
                    lb.Items.Add(myRes.MembershipNo & "," & myRes.eventID & "," & myRes.FinishTime)
                End If

            Next

        Catch ex As Exception
            MessageBox.Show("No data found! (" & ex.Message.ToString() & ")")
        End Try
    End Sub


    Public Shared Sub saveRaceResultsData(ByRef myRaceResultsList As ArrayList, membNo As Double, ByVal eventID As String, ByVal result As String)

        Dim mySQL As String
        Dim newRaceResult As New myRaceResults
        newRaceResult.MembershipNo = membNo
        newRaceResult.eventID = eventID
        newRaceResult.FinishTime = result


        myRaceResultsList.Add(newRaceResult)


        mySQL = "INSERT INTO RaceResults (MemNo,EventName,result) " & _
                "VALUES ('" & membNo & "','" & eventID & "','" & result & "')"

        fileIO.modifyDBData(mySql)

    End Sub


    Public Shared Sub saveRaceResultsToFile(ByVal resultsList As ArrayList)

        Dim myDelimString As String

        For i As Integer = 0 To resultsList.Count - 1
            Dim myResult As New myRaceResults

            myResult = resultsList.Item(i)

            myDelimString = myResult.MembershipNo & "," & myResult.eventID & "," & myResult.FinishTime


            If i = 0 Then
                fileIO.writeLine("RaceResults.txt", myDelimString, False)
            Else
                fileIO.writeLine("RaceResults.txt", myDelimString, True)
            End If

        Next

    End Sub





    Public Shared Function myRandom(ByVal lower As Integer, ByVal upper As Integer) As String


        Dim resultInt As Integer
        Dim resultStr As String

        Randomize()

        'Random number between 1 and 999.

        resultInt = CInt(Int((upper * Rnd()) + lower))

        resultStr = Microsoft.VisualBasic.Right("000" & CStr(resultInt), 3)

        Return resultStr


    End Function


    Public Shared Function genCheckDigit(ByVal number As String) As String

        Dim myCheckDigit As String

        Dim sum As Integer = 0

        Dim myModVal As Integer



        For i As Integer = 1 To number.Length()

            sum = sum + Microsoft.VisualBasic.Val(GetChar(number, i))

        Next


        myModVal = sum Mod 10


        If myModVal = 0 Then

            myCheckDigit = 0

        Else

            myCheckDigit = 10 - myModVal

        End If

        Return myCheckDigit

    End Function


    Public Shared Function genNewMemNo(ByVal birthDate As Date) As String

        Dim myMemNo As String

        Dim currYear As String

        Dim memBirthDate As String

        Dim myRandomNo As String



        currYear = Microsoft.VisualBasic.Right(Year(Now()), 2)

        memBirthDate = Year(birthDate) & Microsoft.VisualBasic.Right("0" & Month(birthDate), 2) & Microsoft.VisualBasic.Right("0" & Microsoft.VisualBasic.DateAndTime.Day(birthDate), 2)

        myRandomNo = myRandom(0, 999)

        myMemNo = currYear & memBirthDate & myRandomNo & genCheckDigit(currYear & memBirthDate & myRandomNo)

        Return myMemNo

    End Function

    Public Shared Function isValidMembNo(ByVal number As String)

        Dim isValid As Boolean = False
        Dim checkDigit As Integer
        Dim myCheckDigit As String
        Dim sum As Integer = 0
        Dim myModVal As Integer

        If number.Length <> 14 Then

            isValid = False

            Return isValid

        Else
            checkDigit = Microsoft.VisualBasic.Right(number, 1)

            For i As Integer = 1 To number.Length() - 1

                sum = sum + Microsoft.VisualBasic.Val(GetChar(number, i))

            Next

            myModVal = sum Mod 10

            If myModVal = 0 Then


                If myModVal = checkDigit Then

                    isValid = True

                End If

            Else

                myCheckDigit = 10 - myModVal

                If myCheckDigit = checkDigit Then

                    isValid = True

                End If

            End If

        End If

        Return isValid

    End Function


    ''Form methods
    Public Shared Sub searchAthlete(ByRef myRRF As frmRaceResults, ByVal membNo As String)
        Dim myIndex As Integer = 0

        For Each myMembNo As String In myRRF.cmbAthlete.Items
            If myMembNo = membNo Then
                myRRF.cmbAthlete.SelectedIndex = myIndex
                Exit For
            Else
                myIndex = myIndex + 1
            End If
        Next
    End Sub


    Public Shared Sub setSelectedAthlete(ByRef myAthFrm As frmAthlete)
        Dim index As Integer = 0

        For Each li As String In myAthFrm.lbAthletes.Items
            If li = myAthFrm.txtMemNo.Text Then
                Exit For
            Else
                index = index + 1
            End If

        Next
        myAthFrm.lbAthletes.SelectedIndex = index
    End Sub

    Public Shared Sub selectAthlete(ByRef myAthFrm As frmAthlete)
        Dim selectedMembNo As String
        selectedMembNo = myAthFrm.txtMemNo.Text

        For Each myAth As myAthlete In myAthFrm.myAthletesList
            If CType(selectedMembNo, Double) = myAth.MemberNo Then
                myAthFrm.txtMemNo.Text = myAth.MemberNo
                myAthFrm.txtNameSur.Text = myAth.NameSur
                myAthFrm.dtpBrthDate.Value = myAth.BirthDate

                If myAth.Gender = "Female" Then
                    myAthFrm.rbFemale.Checked = True
                Else
                    myAthFrm.rbMale.Checked = True
                End If


                myAthFrm.dtpDateJoined.Value = myAth.DateJoined
                myAthFrm.txtFeeOutstanding.Text = myAth.MemFeeOut
            End If
        Next
    End Sub

    Public Shared Sub searchAthlete(ByRef myAthFrm As frmAthlete, ByVal membNo As String)
        Dim myIndex As Integer = 0

        For Each myMembNo As String In myAthFrm.lbAthletes.Items
            If myMembNo = membNo Then
                myAthFrm.lbAthletes.SelectedIndex = myIndex
                Exit For
            Else
                myIndex = myIndex + 1
            End If
        Next
    End Sub

    Public Shared Function getGender(ByRef myAthFrm As frmAthlete) As String
        Dim gender As String
        If myAthFrm.rbFemale.Checked Then
            gender = "Female"
        Else
            gender = "Male"
        End If

        Return gender
    End Function


     Public Shared Sub loadAthletes(ByRef myFrmAth As frmAthlete)
        myFrmAth.lbAthletes.Items.Clear()
        myMethods.loadAthlete(myFrmAth.myAthletesList, myFrmAth.lbAthletes)


    End Sub

    ''events

    Public Shared Sub updateEvents(ByRef myFrmEvents As frmEvent, ByVal isUpdateName As Boolean, ByVal oldEventName As String)
        myMethods.saveEventData(myFrmEvents.myEventsList, isUpdateName, oldEventName, myFrmEvents.txtEventName.Text, myFrmEvents.dtEventDate.Value, myFrmEvents.txtRegFee.Text, myFrmEvents.txtLocation.Text, myFrmEvents.txtDistance.Text)
        myMethods.saveEventsToFile(myFrmEvents.myEventsList)
        myMethods.loadEvents(myFrmEvents)
    End Sub

    Public Shared Sub saveEvents(ByRef myFrmEvents As frmEvent)
        myFrmEvents.btnUpdateName.Show()
    End Sub

    Public Shared Sub selectEvents(ByRef myFrmEvents As frmEvent)
        Dim selectedEvent As String
        selectedEvent = myFrmEvents.lbEvents.Text

        For Each EventItem As myEvent In myFrmEvents.myEventsList
            If selectedEvent = EventItem.Title Then
                myFrmEvents.txtEventName.Text = myFrmEvents.lbEvents.Text
                myFrmEvents.dtEventDate.Text = EventItem.EveDate
                myFrmEvents.txtRegFee.Text = EventItem.RegFee
                myFrmEvents.txtLocation.Text = EventItem.Location
                myFrmEvents.txtDistance.Text = EventItem.Distance
            End If
        Next
    End Sub

    Public Shared Sub loadEvents(ByRef myFrmEvents As frmEvent)
        myFrmEvents.lbEvents.Items.Clear()
        myMethods.loadEvents(myFrmEvents.myEventsList, myFrmEvents.lbEvents)


    End Sub

    Public Shared Sub setSelectedEvent(ByRef myFrmEvents As frmEvent)
        Dim index As Integer = 0

        For Each li As String In myFrmEvents.lbEvents.Items
            If li = myFrmEvents.txtEventName.Text Then
                Exit For
            Else
                index = index + 1
            End If

        Next
        myFrmEvents.lbEvents.SelectedIndex = index
    End Sub

    Public Shared Sub clearForm(ByRef myFrmEvents As frmEvent)
        myFrmEvents.txtEventName.Text = ""
        myFrmEvents.txtRegFee.Text = ""
        myFrmEvents.txtLocation.Text = ""
        myFrmEvents.txtDistance.Text = ""
    End Sub





    ''''''''''''
    ''Error checking

    Public Shared Function hasErrorsAthlete(ByRef myAthFrm As frmAthlete) As Boolean


        If myAthFrm.txtNameSur.Text.Trim() = "" Then
            MessageBox.Show("Please fill in a valid name and surname")
            Return True

        End If

        Dim mytestName As Double

        If Double.TryParse(myAthFrm.txtNameSur.Text, mytestName) Then
            MessageBox.Show("Enter a valid name and surname")
            Return True
        End If

        If myAthFrm.rbMale.Checked = False And myAthFrm.rbFemale.Checked = False Then
            MessageBox.Show("Please select the gender ")
            Return True

        End If

        If myAthFrm.txtFeeOutstanding.Text.Trim() = "" Then

            MessageBox.Show("Please fill in a valid outstanding membership fee")
            Return True
        End If

        Dim myDouble As Double

        If Double.TryParse(myAthFrm.txtFeeOutstanding.Text, myDouble) Then

        Else

            MessageBox.Show("Please fill in a valid outstanding membership fee")
            Return True
        End If

        If CInt(Microsoft.VisualBasic.DateDiff(DateInterval.Day, myAthFrm.dtpBrthDate.Value, myAthFrm.dtpDateJoined.Value)) < 0 Then
            MessageBox.Show("Birth date must be greater than the date joined")
            Return True


        End If

        If DateDiff(DateInterval.Year, myAthFrm.dtpBrthDate.Value, myAthFrm.dtpDateJoined.Value) < 16 Then
            MessageBox.Show("Athlete must be older than 16")
            Return True
        End If


        Return False

    End Function

    ''Error checking
    Public Shared Function hasErrorsRaceResults(ByRef myRRF As frmRaceResults, ByVal type As String) As Boolean

        If type = "Add" Then
            If myRRF.cmbAthlete.Text.Trim() = "" Then
                MessageBox.Show("Please select an athlete")
                Return True
            End If

            If myRRF.cmbRace.Text.Trim() = "" Then
                MessageBox.Show("Please choose an event ")
                Return True
            End If

            If myRRF.txtResults.Text.Trim() = "" Then
                MessageBox.Show("Please fill in results ")
                Return True

            End If

            Dim myDouble As Double

            If Double.TryParse(myRRF.txtResults.Text, myDouble) Then

            Else

                MessageBox.Show("Please fill in a results")
                Return True
            End If
        End If


        If type = "Search" Then

            If myRRF.txtMemNo.Text.Trim() = "" Then
                MessageBox.Show("Please fill in a membership number")
                Return True
            End If

            If myMethods.isValidMembNo(myRRF.txtMemNo.Text) Then

            Else
                MessageBox.Show("Please fill in a valid membership number")
                Return True
            End If

        End If

        Return False
    End Function


    ''Error Checking events
    Public Shared Function hasErrorsEvents(ByRef myEvFrm As frmEvent, ByVal type As String) As Boolean
        If type = "Update" Then

            If myEvFrm.txtEventName.Text.Trim() = "" Then
                MessageBox.Show("Please fill in an Event Name")
                Return True
            End If
            '
            '

            If myEvFrm.txtRegFee.Text.Trim() = "" Then
                MessageBox.Show("Please fill in the Registration Fee")
                Return True
            End If

            Dim myDouble As Double

            If Double.TryParse(myEvFrm.txtRegFee.Text, myDouble) Then
            Else
                MessageBox.Show("Registration Fee is not a valid number")
                Return True
            End If


            If myEvFrm.txtLocation.Text.Trim() = "" Then
                MessageBox.Show("Please fill in Location")
                Return True
            End If
            If myEvFrm.txtDistance.Text.Trim() = "" Then
                MessageBox.Show("Please fill in a valid distance")
                Return True
            End If

        End If

        If type = "Update Title" Then
            'check the title

            If myEvFrm.txtEventName.Text.Trim() = "" Then
                MessageBox.Show("Please fill in a valid event title")
                Return True
            End If
        End If

        If type = "Delete" Then
            'check if there is a selected event
            If myEvFrm.lbEvents.SelectedIndex = -1 Then
                MessageBox.Show("Please select an event to delete")
                Return True
            End If
        End If
        Return False
    End Function

    Public Shared Function getAthResults(ByRef memNo As String) As Integer
        Dim mySql As String

        Dim myCount As Integer
        Dim mydatable As DataTable

        mySql = "SELECT Count (MemNo) as reCount from RaceResults where MemNo = '" & memNo & "'"

        mydatable = fileIO.selectDBData(mySql)

        myCount = CInt(mydatable(0).Item(0))

        Return myCount

    End Function

    Public Shared Sub deleteAthlete(ByRef memNo As String)
        Dim mySql As String

        mySql = "DELETE FROM Athletes where MemNo = '" & memNo & "'"

        fileIO.modifyDBData(mySql)

    End Sub

End Class
