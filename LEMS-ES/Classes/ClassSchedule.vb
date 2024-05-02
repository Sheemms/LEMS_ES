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
                    New MySqlParameter("@Department_ID", FrmSchedule.cmbDepartment.SelectedValue),
                    New MySqlParameter("@GradeLevel_ID", FrmSchedule.cmbGradeLevel.SelectedValue),
                    New MySqlParameter("@Sec_ID", FrmSchedule.cmbSection.SelectedValue),
                    New MySqlParameter("@Room", FrmSchedule.CmbRoom.SelectedValue),
                    New MySqlParameter("@Adviser_ID", FrmSchedule.idAdv),
                    New MySqlParameter("@Subj_ID", FrmSchedule.CmbSubjectCode.SelectedValue),
                    New MySqlParameter("@Days", FrmSchedule.ChckBox()),
                    New MySqlParameter("@Time_From", FrmSchedule.txtstartTime.Text),
                    New MySqlParameter("@Time_To", FrmSchedule.txtendTime.Text),
                    New MySqlParameter("@Teacher_ID", FrmSchedule.teacherid)
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
                    Command("INSERT INTO schedule(SYID, Department_ID, GradeLevel_ID, Sec_ID, Room, Adviser_ID, Subj_ID, Days, Time_From, Time_To, Teacher_ID) 
                                VALUES (@SYID, @Department_ID, @GradeLevel_ID, @Sec_ID, @Room, @Adviser_ID, @Subj_ID, @Days, @Time_From, @Time_To, @Teacher_ID)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE schedule SET SYID=@SYID, Department_ID=@Department_ID, GradeLevel_ID=@GradeLevel_ID, Sec_ID=@Sec_ID, Room=@Room, Adviser_ID=@Adviser_ID, 
                            Subj_ID=@Subj_ID, Days=@Days, Time_From=@Time_From, Time_To=@Time_To, Teacher_ID=@Teacher_ID)
                            WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            FrmSchedule.LoadRecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
