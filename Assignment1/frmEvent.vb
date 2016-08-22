Public Class frmEvent

    Public myEventsList As New ArrayList()


    Private Sub frmEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEvents()
    End Sub

    Private Sub frmEvent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub btnEditEvent_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If myMethods.hasErrorsEvents(Me, "Update") Then
            Return
        End If


        myMethods.updateEvents(Me, False, txtEventName.Text)
        myMethods.setSelectedEvent(Me)
        btnUpdate.Text = "Update"
        btnNew.Visible = True
        btnUpdateName.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        saveEvents()
    End Sub

    Private Sub cmbEventName_SelectedIndexChanged(sender As Object, e As EventArgs)
        selectEvents()
    End Sub





    '''''''''''''Form'''''''
    'Private Sub updateEvents(ByVal isUpdateName As Boolean, ByVal oldEventName As String)
    'myMethods.saveEventData(myEventsList, isUpdateName, oldEventName, txtEventName.Text, dtEventDate.Value, txtRegFee.Text, txtLocation.Text, txtDistance.Text)
    'myMethods.saveEventsToFile(myEventsList)
    'loadEvents()
    'End Sub

    Private Sub saveEvents()
        btnUpdate.Show()
    End Sub

    Private Sub selectEvents()
        Dim selectedEvent As String
        selectedEvent = lbEvents.Text

        For Each EventItem As myEvent In myEventsList
            If selectedEvent = EventItem.Title Then
                txtEventName.Text = lbEvents.Text
                dtEventDate.Text = EventItem.EveDate
                txtRegFee.Text = EventItem.RegFee
                txtLocation.Text = EventItem.Location
                txtDistance.Text = EventItem.Distance
            End If
        Next
    End Sub

    Private Sub loadEvents()
        lbEvents.Items.Clear()
        myMethods.loadEvents(myEventsList, lbEvents)


    End Sub

    Private Sub lbEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbEvents.SelectedIndexChanged
        selectEvents()
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnUpdateName.Enabled = True
    End Sub

    Private Sub btnUpdateName_Click(sender As Object, e As EventArgs) Handles btnUpdateName.Click
        'updateEvents(True, lbEvents.Text)
        'setSelectedEvent()

        If myMethods.hasErrorsEvents(Me, "Update Title") Then
            Return
        End If

        '' txtEventName.Enabled = False

        myMethods.updateEvents(Me, True, lbEvents.Text)
        ' myMethods.setSelectedEvent(Me)
        btnUpdateName.Text = "Update"
        btnNew.Visible = True
    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        myMethods.deleteEvent(myEventsList, lbEvents.Text)
        loadEvents()
        clearForm()
    End Sub

    Private Sub clearForm()
        txtEventName.Text = ""
        txtRegFee.Text = ""
        txtLocation.Text = ""
        txtDistance.Text = ""
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clearForm()
        btnNew.Visible = False
        btnUpdate.Text = "Save"

    End Sub



End Class