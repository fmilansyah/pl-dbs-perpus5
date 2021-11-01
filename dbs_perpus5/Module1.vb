Module Module1
    Public dbConn As New ADODB.Connection
    Public record As New ADODB.Recordset

    Public Sub openConn()
        dbConn.Open("DSN=dbs_perpus5")
    End Sub

    Public Sub closeConn()
        dbConn.Close()
    End Sub
End Module
