Imports MySql.Data.MySqlClient
Public Class ClassSchedule
#Region "ScheduleParameters"
    Public Shared Function SchedParameters() As MySqlParameter()
        Try
            Dim SchedParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmSY.idSY),
                    New MySqlParameter("@End_Year", frmSY.txtEndYear.Text)
                }
            Return SchedParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub SchedRef()
        Try
            Dim dynamicParams As MySqlParameter() = SchedParameters()
            If frmSchedule.idSched = 0 Then
                If MsgBox("Do you want to Add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO schedule(SY_Code, Sec_ID, Room, Adviser_ID, Subj_ID, Days, Time_From, Time_To, Teacher_ID) 
                                VALUES (@SY_Code, @Sec_ID, @Room, @Adviser_ID, @Subj_ID, @Days, @Time_From, @Time_To, @Teacher_ID))", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE schedule SET SY_Code=@SY_Code, Sec_ID=@Sec_ID, Room=@Room, Adviser_ID=@Adviser_ID, 
                            Subj_ID=@Subj_ID, Days=@Days, Time_From=@Time_From, Time_To=@Time_To, Teacher_ID=@Teacher_ID)
                            WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmSchedule.LoadRecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
