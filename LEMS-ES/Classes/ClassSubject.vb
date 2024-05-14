Imports MySql.Data.MySqlClient

Public Class ClassSubject

#Region "SubjectParameters"
    Public Shared Function SubjectParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", FrmSubjects.idSubj),
                    New MySqlParameter("@GradeLevel_ID", FrmSubjects.CmbGradeLevel.SelectedValue),
                    New MySqlParameter("@SubjectCode", FrmSubjects.txtSubjCode.Text),
                    New MySqlParameter("@SubjectName", FrmSubjects.txtSubjName.Text),
                    New MySqlParameter("@Units", FrmSubjects.txtUnit.Text)
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub SubjectRef()
        Try
            Dim dynamicParams As MySqlParameter() = SubjectParameters()
            If dynamicParams Is Nothing Then
                MsgBox("Error: parameters could not be created.")
                Return
            End If

            Dim gradeLevelId As Integer
            If Integer.TryParse(FrmSubjects.CmbGradeLevel.SelectedValue.ToString(), gradeLevelId) Then
                Dim subjectId As Integer = FrmSubjects.idSubj
                If CheckGradeLevelLimit(gradeLevelId, subjectId) Then
                    If subjectId = 0 Then
                        If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                            Command("INSERT INTO subject(GradeLevel_ID, SubjectCode, SubjectName, Units) VALUES (@GradeLevel_ID, @SubjectCode, @SubjectName, @Units)", dynamicParams)
                            Success("Successfully Added!")
                            Dim name As String = FrmSubjects.CmbGradeLevel.Text & ", " & FrmSubjects.txtSubjCode.Text & " - " & FrmSubjects.txtSubjName.Text
                            LogAction("Added Subject | " & name)
                            FrmSubjects.Clear()
                        End If
                    Else
                        If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                            Command("UPDATE subject SET GradeLevel_ID=@GradeLevel_ID, SubjectCode=@SubjectCode, SubjectName=@SubjectName, Units=@Units WHERE ID=@ID", dynamicParams)
                            Success("Successfully Updated!")
                            Dim name As String = FrmSubjects.txtSubjName.Text
                            LogAction("Updated Subject | " & name)
                            FrmSubjects.Clear()
                        End If
                    End If
                    FrmSubjects.LoadRecords()
                Else
                    Info("The maximum number of subjects for this grade level has been reached.")
                End If
            Else
                Critical("Invalid Grade Level.")
            End If
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
            If FrmSubjects.idSubj <> 0 Then
                Dim subjectName As String = FrmSubjects.txtSubjName.Text
                If MsgBox("Do you want to delete it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("DELETE FROM subject WHERE ID=@ID", dynamicParams)
                    Success("Successfully Deleted!")
                    LogAction("Deleted Subject | " & subjectName)
                End If
            Else
                Critical("You have nothing to delete")
            End If
            FrmSubjects.LoadRecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

    Private Shared Function CheckGradeLevelLimit(gradeLevelId As Integer, Optional excludeSubjectId As Integer = 0) As Boolean
        Try
            Dim query As String
            Dim parameters As New List(Of MySqlParameter)()

            If excludeSubjectId = 0 Then
                query = "SELECT COUNT(*) FROM subject WHERE GradeLevel_ID = @GradeLevel_ID"
            Else
                query = "SELECT COUNT(*) FROM subject WHERE GradeLevel_ID = @GradeLevel_ID AND ID <> @ID"
                parameters.Add(New MySqlParameter("@ID", excludeSubjectId))
            End If
            parameters.Add(New MySqlParameter("@GradeLevel_ID", gradeLevelId))

            Dim count As Integer = Convert.ToInt32(CmdScalarwithParam(query, parameters.ToArray()))
            Return count < 10
        Catch ex As Exception
            Critical("Error checking grade level subject limit: " & ex.Message)
            Return False
        End Try
    End Function

End Class
