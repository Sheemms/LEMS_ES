Imports MySql.Data.MySqlClient
Public Class ClassSchedule
#Region "ScheduleParameters"
    Public Shared Function SchedParameters() As MySqlParameter()
        Try
            Dim schoolYearID As Integer = GetSchoolYearID()
            
            If schoolYearID <> -1 Then
                Dim SchedParam() As MySqlParameter = {
                    New MySqlParameter("@ID", FrmSchedule.idSched),
                    New MySqlParameter("@SYID", schoolYearID),
                    New MySqlParameter("@SectionID", FrmSchedule.CmbSection.SelectedValue),
                    New MySqlParameter("@Room", FrmSchedule.CmbRoom.SelectedValue),
                    New MySqlParameter("@SubjectID", FrmSchedule.CmbSubjectCode.SelectedValue),
                    New MySqlParameter("@Days", FrmSchedule.ChckBox()),
                    New MySqlParameter("@Time_From", FrmSchedule.txtstartTime.Text),
                    New MySqlParameter("@Time_To", FrmSchedule.txtendTime.Text),
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
                    Command("INSERT INTO schedule(SYID, SectionID, Room, SubjectID, Days, Time_From, Time_To, TeacherID) 
                                VALUES (@SYID, @SectionID, @Room, @SubjectID, @Days, @Time_From, @Time_To, @TeacherID)", dynamicParams)
                    Success("Successfully Added!")
                    FrmSchedule.Clear()
                End If
            Else
                If MsgBox("Do you want to update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE schedule SET SYID=@SYID, SectionID=@SectionID, Room=@Room, SubjectID=@SubjectID, Days=@Days, Time_From=@Time_From, Time_To=@Time_To, TeacherID=@TeacherID)
                            WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                    FrmSchedule.Clear()
                End If
            End If
            FrmSchedule.LoadRecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
