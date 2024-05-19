Imports MySql.Data.MySqlClient
Public Class ClassSchedule
#Region "ScheduleParameters"
    Public Shared Function GetDayIDs() As List(Of Integer)
        Dim dayIDs As New List(Of Integer)
        Dim ckbx() As CheckBox = {FrmSchedule.cbM, FrmSchedule.cbT, FrmSchedule.cbW, FrmSchedule.cbTH, FrmSchedule.cbF}
        Dim daysMap As New Dictionary(Of String, Integer) From {
            {"Monday", 1},
            {"Tuesday", 2},
            {"Wednesday", 3},
            {"Thursday", 4},
            {"Friday", 5}
        }

        For Each cb In ckbx
            If cb.Checked AndAlso daysMap.ContainsKey(cb.Text) Then
                dayIDs.Add(daysMap(cb.Text))
            End If
        Next

        Return dayIDs
    End Function

    Public Shared Function SchedParameters() As MySqlParameter()
        Try
            Dim schoolYearID As Integer = GetSchoolYearID()

            If schoolYearID <> -1 Then
                Dim dayIDs As List(Of Integer) = GetDayIDs()

                Dim SchedParam() As MySqlParameter = {
                    New MySqlParameter("@ID", FrmSchedule.idSched),
                    New MySqlParameter("@SYID", schoolYearID),
                    New MySqlParameter("@SectionID", FrmSchedule.CmbSection.SelectedValue),
                    New MySqlParameter("@Room", FrmSchedule.CmbRoom.SelectedValue),
                    New MySqlParameter("@SubjectID", FrmSchedule.CmbSubjectCode.SelectedValue),
                    New MySqlParameter("@Days", String.Join(",", dayIDs)),
                    New MySqlParameter("@Time_From", TimeSpan.Parse(FrmSchedule.txtstartTime.Text)),
                    New MySqlParameter("@Time_To", TimeSpan.Parse(FrmSchedule.txtendTime.Text)),
                    New MySqlParameter("@TeacherID", FrmSchedule.teacherid)
                }
                Return SchedParam
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub SchedRef()
        Try
            Dim dynamicParams As MySqlParameter() = SchedParameters()

            If FrmSchedule.idSched = 0 Then
                If MsgBox("Do you want to Add?", vbQuestion + vbYesNo) = vbYes Then
                    Dim existingSchedules As DataTable = QueryWithParams("SELECT Days FROM schedule WHERE TeacherID = @TeacherID AND (Time_From <= @Time_To) AND (Time_To >= @Time_From)", dynamicParams)

                    Dim existingDayIDs As New List(Of Integer)
                    For Each row As DataRow In existingSchedules.Rows
                        existingDayIDs.AddRange(row("Days").ToString().Split(","c).Select(Function(x) Integer.Parse(x.Trim())))
                    Next

                    Dim newDayIDs As List(Of Integer) = GetDayIDs()
                    For Each newDayID As Integer In newDayIDs
                        If existingDayIDs.Contains(newDayID) Then
                            Critical("The selected days overlap with an existing schedule for the same teacher.")
                            Exit Sub
                        End If
                    Next

                    Command("INSERT INTO schedule(SYID, SectionID, Room, SubjectID, Days, Time_From, Time_To, TeacherID) 
                        VALUES (@SYID, @SectionID, @Room, @SubjectID, @Days, @Time_From, @Time_To, @TeacherID)", dynamicParams)
                    Success("Successfully Added!")
                    FrmSchedule.Clear()
                End If
            Else
                If MsgBox("Do you want to update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE schedule SET SYID=@SYID, SectionID=@SectionID, Room=@Room, SubjectID=@SubjectID, Days=@Days, Time_From=@Time_From, Time_To=@Time_To, TeacherID=@TeacherID WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                    FrmSchedule.Clear()
                End If
            End If
            FrmSchedule.LoadRecords()
        Catch ex As MySqlException
            If ex.Number = 1062 AndAlso ex.Message.Contains("Days and Time") Then
                Critical("Teacher has the same days and time added.")
            ElseIf ex.Number = 1062 AndAlso ex.Message.Contains("Section, Subject and Days") Then
                Critical("Section can't have the duplicate subject and days")
            ElseIf ex.Number = 1062 AndAlso ex.Message.Contains("Section, Room, Days and Time") Then
                Critical("Section can't have the same room, days and time")
            ElseIf ex.Number = 1062 AndAlso ex.Message.Contains("Room, Days and Time") Then
                Critical("Room can't have the same schedule days and time.")
            ElseIf ex.Number = 1644 Then
                Critical("Time slot overlaps with an existing schedule.")
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
