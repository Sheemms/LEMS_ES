Imports MySql.Data.MySqlClient
Public Class ClassSchoolYear
#Region "SYparam"
    Public Shared Function SchoolYearParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmSY.idSY),
                    New MySqlParameter("@SchoolYear", frmSY.txtAddSY.Text)
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub SchoolYearRef()
        Try
            Dim closeParams() As MySqlParameter = {New MySqlParameter()}
            Command("UPDATE schoolyear SET Status= 'Closed' WHERE ID = (SELECT MAX(ID) FROM schoolyear)", closeParams)
            If frmSY.idSY = 0 Then
                If MsgBox("Do you want to Add?", vbQuestion + vbYesNo) Then
                    Dim dynamicParams() As MySqlParameter = SchoolYearParameters()
                    Command("INSERT INTO schoolyear(SchoolYear) VALUES (@SchoolYear)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                MsgBox("School Year is Closed.")
                Exit Sub
            End If

            frmSY.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("School year already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
