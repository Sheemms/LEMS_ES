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
        Dim dynamicParams As MySqlParameter() = SchoolYearParameters()
        If frmSY.idSY = 0 Then
            Command("INSERT INTO schoolyear(SchoolYear) VALUES (@SchoolYear)", dynamicParams)
        Else
            Command("UPDATE schoolyear SET SchoolYear=@SchoolYear WHERE ID=@ID", dynamicParams)
        End If
    End Sub
#End Region
End Class
