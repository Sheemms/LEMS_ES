Imports MySql.Data.MySqlClient
Public Class ClassSchedule
#Region "ScheduleParameters"
    Public Shared Function SchedParameters() As MySqlParameter()
        Try
            Dim SchedParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmSchedule.idSched),
                    New MySqlParameter("@SY_Code", frmSchedule.lblSY.Text),
                    New MySqlParameter("@Department_ID", frmSchedule.cmbDepartment.SelectedValue),
                    New MySqlParameter("@Sec_ID", frmSchedule.cmbSection.SelectedValue),
                    New MySqlParameter("@Room", frmSchedule.txtRoom.Text),
                    New MySqlParameter("@Adviser_ID", frmSchedule.advID),
                    New MySqlParameter("@Subj_ID", frmSchedule.subjID),
                    New MySqlParameter("@Days", frmSchedule.chckBox()),
                    New MySqlParameter("@Time_From", frmSchedule.txtstartTime.Text),
                    New MySqlParameter("@Time_To", frmSchedule.txtendTime.Text),
                    New MySqlParameter("@Teacher_ID", frmSchedule.teacherid)
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
                    Command("INSERT INTO schedule(SY_Code, Department_ID, Sec_ID, Room, Adviser_ID, Subj_ID, Days, Time_From, Time_To, Teacher_ID) 
                                VALUES (@SY_Code, @Department_ID, @Sec_ID, @Room, @Adviser_ID, @Subj_ID, @Days, @Time_From, @Time_To, @Teacher_ID)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE schedule SET SY_Code=@SY_Code, Department_ID=@Department_ID, Sec_ID=@Sec_ID, Room=@Room, Adviser_ID=@Adviser_ID, 
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
