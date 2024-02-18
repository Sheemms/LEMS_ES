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
                If MsgBox("Do u want to Add?", vbQuestion + vbYesNo) Then
                    Command("INSERT INTO subject(SubjectCode, SubjectName) VALUES (@SubjectCode, @SubjectName)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do u want to update?", vbQuestion + vbYesNo) Then
                    Command("UPDATE subject SET SubjectCode=@SubjectCode, SubjectName=@SubjectName WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
                frmSubjects.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Subject already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
