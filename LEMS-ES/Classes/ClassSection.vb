Imports MySql.Data.MySqlClient

Public Class ClassSection
#Region "SectionParam"
    Public Shared Function SectionParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", FrmSections.idSection),
                    New MySqlParameter("@GradeLevel_ID", FrmSections.CmbGradeLevel.SelectedValue),
                    New MySqlParameter("@SectionRoom", FrmSections.TxtSectionName.Text),
                    New MySqlParameter("@AdviserID", FrmSections.CmbAdviser.SelectedValue),
                    New MySqlParameter("@Capacity", FrmSections.TxtCapacity.Text)
                }
            Return syParam
        Catch ex As Exception
            MsgBox("Error section parameters: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Sub SectionRef()
        Try
            Dim dynamicParams As MySqlParameter() = SectionParameters()
            If dynamicParams Is Nothing Then
                Info("Error section: parameters could not be created.")
                Return
            End If

            Dim gradeLevelId As Integer
            If Integer.TryParse(FrmSections.CmbGradeLevel.SelectedValue.ToString(), gradeLevelId) Then
                Dim sectionId As Integer = FrmSections.idSection
                If CheckGradeLevelLimit(gradeLevelId, sectionId) Then
                    If sectionId = 0 Then
                        If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                            Command("INSERT INTO section (GradeLevel_ID, SectionRoom, AdviserID, Capacity) VALUES (@GradeLevel_ID, @SectionRoom, @AdviserID, @Capacity)", dynamicParams)
                            Success("Successfully Added!")
                            Dim name As String = FrmSections.CmbGradeLevel.Text & " - " & FrmSections.TxtSectionName.Text & " - " & FrmSections.CmbAdviser.Text
                            LogAction("Added Section | " & name)
                            FrmSections.Clear()
                        End If
                    Else
                        If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                            Command("UPDATE section SET GradeLevel_ID=@GradeLevel_ID, SectionRoom=@SectionRoom, AdviserID=@AdviserID, Capacity=@Capacity WHERE ID=@ID", dynamicParams)
                            Success("Successfully Updated!")
                            Dim name As String = FrmSections.CmbGradeLevel.Text & " - " & FrmSections.TxtSectionName.Text & " - " & FrmSections.CmbAdviser.Text
                            LogAction("Updated Section | " & name)
                            FrmSections.Clear()
                        End If
                    End If
                    FrmSections.Loadrecords()
                Else
                    Info("The maximum number of sections for this grade level has been reached.")
                End If
            Else
                Critical("Invalid Grade Level.")
            End If
        Catch ex As MySqlException
            If ex.Number = 1062 AndAlso ex.Message.Contains("SectionRoom") Then
                Critical("Section already exists.")
                Exit Sub
            ElseIf ex.Number = 1062 AndAlso ex.Message.Contains("GradeLevel and Adviser") Then
                Critical("For Adviser, only one section per grade level.")
                Exit Sub
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Shared Function CheckGradeLevelLimit(gradeLevelId As Integer, Optional excludeSectionId As Integer = 0) As Boolean
        Try
            Dim query As String
            Dim parameters As New List(Of MySqlParameter)()
            If excludeSectionId = 0 Then
                query = "SELECT COUNT(*) FROM section WHERE GradeLevel_ID = @GradeLevel_ID"
            Else
                query = "SELECT COUNT(*) FROM section WHERE GradeLevel_ID = @GradeLevel_ID AND ID <> @ID"
                parameters.Add(New MySqlParameter("@ID", excludeSectionId))
            End If
            parameters.Add(New MySqlParameter("@GradeLevel_ID", gradeLevelId))

            Dim count As Integer = Convert.ToInt32(CmdScalarwithParam(query, parameters.ToArray()))
            Return count < 15
        Catch ex As Exception
            MsgBox("Error checking grade level limit: " & ex.Message)
            Return False
        End Try
    End Function

#End Region
End Class