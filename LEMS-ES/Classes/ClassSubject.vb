Imports MySql.Data.MySqlClient
Public Class ClassSubject

#Region "SubjectParameters"
    Public Shared Function SubjectParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmSubjects.idSubj),
                    New MySqlParameter("@GradeLevel_ID", frmSubjects.CmbGradeLevel.SelectedValue),
                    New MySqlParameter("@SubjectCode", frmSubjects.txtSubjCode.Text),
                    New MySqlParameter("@SubjectName", frmSubjects.txtSubjName.Text),
                    New MySqlParameter("@Description", frmSubjects.TxtDesc.Text),
                    New MySqlParameter("@Units", frmSubjects.txtUnit.Text)
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
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO subject(GradeLevel_ID, SubjectCode, SubjectName, Description, Units) VALUES (@GradeLevel_ID, @SubjectCode, @SubjectName, @Description, @Units)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE subject SET GradeLevel_ID=@GradeLevel_ID, SubjectCode=@SubjectCode, SubjectName=@SubjectName, Description=@Description, Units=@Units WHERE ID=@ID", dynamicParams)
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

    Public Shared Sub DeleteRef()
        Try
            Dim dynamicParams As MySqlParameter() = SubjectParameters()
            If frmSubjects.idSubj <> 0 Then
                If MsgBox("Do you want to delete it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("DELETE FROM subject WHERE ID=@ID", dynamicParams)
                    Success("Successfully Deleted!")
                End If
            Else
                MsgBox("You have nothing to delete")
            End If
            frmSubjects.loadrecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
