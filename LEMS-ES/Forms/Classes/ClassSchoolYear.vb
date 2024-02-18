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
            Dim dynamicParams As MySqlParameter() = SchoolYearParameters()
            If frmSY.idSY = 0 Then
                Command("INSERT INTO schoolyear(SchoolYear) VALUES (@SchoolYear)", dynamicParams)
                Success("Successfully Added!")
            Else
                If MsgBox("Do u want to update?", vbQuestion + vbYesNo) Then
                    Command("UPDATE schoolyear SET SchoolYear=@SchoolYear WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
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
