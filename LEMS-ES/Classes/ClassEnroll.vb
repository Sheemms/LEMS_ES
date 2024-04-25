Imports MySql.Data.MySqlClient
Public Class ClassEnroll
#Region "EnrollmentParameters"
    Public Shared Function EnrollmentParameters() As MySqlParameter()
        Try
            Dim enrollParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmEnrollmentRegistration.EnrollmentID),
                    New MySqlParameter("@EID", frmEnrollmentRegistration.LabelEID.Text),
                    New MySqlParameter("@SchoolYear", frmEnrollmentRegistration.lblSY.Text),
                    New MySqlParameter("@LRN", frmEnrollmentRegistration.txtStudLRN.Text),
                    New MySqlParameter("@SectionID", frmEnrollmentRegistration.CmbSection.SelectedValue),
                    New MySqlParameter("@GradeLevel_ID", frmEnrollmentRegistration.CmbGradeLevel.SelectedValue)
                }
            Return enrollParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub EnrollmentRef()
        Try
            Dim dynamicParams As MySqlParameter() = EnrollmentParameters()
            If FrmEnrollmentRegistration.EnrollmentID = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO enrollment(EID, SchoolYear, LRN, SectionID, GradeLevel_ID) 
                                VALUES (@EID, @SchoolYear, @LRN, @SectionID, @GradeLevel_ID)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do u want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE enrollment SET EID=@EID, SchoolYear=@SchoolYear, LRN=@LRN, SectionID=@SectionID, GradeLevel_ID=@GradeLevel_ID WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmEnrollment.Loadrecords()
            FrmEnrollmentRegistration.Close()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Student already enrolled.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "EnrollSubject"

    Public Shared Function EnrollSubjParameters() As MySqlParameter()
        Try
            Dim schoolYearID As Integer = GetSchoolYearID()
            Dim scheduleID As Integer = -1

            If FrmEnrollmentRegistration.DgvSubjectList IsNot Nothing AndAlso FrmEnrollmentRegistration.DgvSubjectList.SelectedRows.Count > 0 Then
                scheduleID = Convert.ToInt32(FrmEnrollmentRegistration.DgvSubjectList.SelectedRows(0).Cells(0).Value)
            End If
            If schoolYearID <> -1 Then
                Dim enrollsubjParam() As MySqlParameter = {
                New MySqlParameter("@ID", FrmEnrollmentRegistration.EnrollSubjID),
                New MySqlParameter("@SYID", schoolYearID),
                New MySqlParameter("@EID", FrmEnrollmentRegistration.LabelEID.Text),
                New MySqlParameter("@ScheduleID", scheduleID)
            }
                Return enrollsubjParam
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub EnrollSubjRef()
        Try
            Dim dynamicParams As MySqlParameter() = EnrollSubjParameters()

            ' Check if dynamicParams is not Nothing
            If dynamicParams IsNot Nothing Then
                If FrmEnrollmentRegistration.EnrollSubjID = 0 Then
                    If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                        Command("INSERT INTO enrolled_sched(SYID, EID, ScheduleID) 
                                VALUES (@SYID, @EID, @ScheduleID)", dynamicParams)
                        Success("Successfully Added!")
                    End If
                Else
                    If MsgBox("Do u want to update it?", vbQuestion + vbYesNo) = vbYes Then
                        Command("UPDATE enrolled_sched SET SYID=@SYID, EID=@EID, ScheduleID=@ScheduleID WHERE ID=@ID", dynamicParams)
                        Success("Successfully Updated!")
                    End If
                End If
                FrmEnrollmentRegistration.LoadSubjectEnrolled()
            Else
                MsgBox("Error: dynamicParams is Nothing")
            End If
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Subject already enrolled.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region
End Class
