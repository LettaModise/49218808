Public Class myEvent
    Private myTitle As String
    Private myDate As Date
    Private myRegFee As Double
    Private myLoc As String
    Private myDis As Double


    Property Title As String
        Get
            Return myTitle
        End Get

        Set(value As String)
            myTitle = value
        End Set
    End Property

    Property EveDate As Date
        Get
            Return myDate
        End Get

        Set(value As Date)
            myDate = value
        End Set
    End Property

    Property RegFee As Double
        Get
            Return myRegFee
        End Get

        Set(value As Double)
            myRegFee = value
        End Set
    End Property

    Property Location As String
        Get
            Return myLoc
        End Get

        Set(value As String)
            myLoc = value
        End Set
    End Property

    Property Distance As Double
        Get
            Return myDis
        End Get

        Set(value As Double)
            myDis = value
        End Set
    End Property

    Public Function getValue(ByVal x As Integer) As Integer
        Return x * 2
    End Function

    






End Class
