Imports MySql.Data.MySqlClient
Public Class ClassSubject

#Region "SubjectParameters"
    Public Shared Function SubjectParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmSubjects.idSubj),
                    New MySqlParameter("@SubjectCode", frmSubjects.txtSubjCode.Text),
                    New MySqlParameter("@SubjectName", frmSubjects.txtSubjName.Text)
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub SubjectRef()
        Try
            Dim dynamicParams As MySqlParameter() = SubjectParameters()
            If frmSubjects.idSubj = 0 Then
                Command("INSERT INTO subject(SubjectCode, SubjectName) VALUES (@SubjectCode, @SubjectName)", dynamicParams)
            Else
                Command("UPDATE subject SET SubjectCode=@SubjectCode, SubjectName=@SubjectName WHERE ID=@ID", dynamicParams)
            End If
            frmSubjects.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("School year already exists. Please enter a unique school year.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
