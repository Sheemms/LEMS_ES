Imports MySql.Data.MySqlClient
Public Class ClassEnroll
#Region "EnrollmentParameters"
    Public Shared Function EnrollmentParameters() As MySqlParameter()
        Try
            Dim schoolYearID As Integer = GetSchoolYearID()

            If schoolYearID <> -1 Then
                Dim enrollParam() As MySqlParameter = {
                    New MySqlParameter("@ID", FrmEnrollmentRegistration.EnrollmentID),
                    New MySqlParameter("@EID", FrmEnrollmentRegistration.LabelEID.Text),
                    New MySqlParameter("@SchoolYear", schoolYearID),
                    New MySqlParameter("@LRN", FrmEnrollmentRegistration.txtStudLRN.Text),
                    New MySqlParameter("@SectionID", FrmEnrollmentRegistration.CmbSection.SelectedValue),
                    New MySqlParameter("@GradeLevel_ID", FrmEnrollmentRegistration.CmbGradeLevel.SelectedValue)
                }
                Return enrollParam
            Else
                Return Nothing
            End If
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
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
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

            If schoolYearID <> -1 Then
                Dim enrollsubjParam() As MySqlParameter = {
                New MySqlParameter("@ID", FrmEnrollmentRegistration.EnrollSubjID),
                New MySqlParameter("@SYID", schoolYearID),
                New MySqlParameter("@EID", FrmEnrollmentRegistration.LabelEID.Text),
                New MySqlParameter("@LRN", FrmEnrollmentRegistration.txtStudLRN.Text),
                New MySqlParameter("@ScheduleID", FrmEnrollmentRegistration.scheduleID)
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

            If dynamicParams IsNot Nothing Then
                If FrmEnrollmentRegistration.EnrollSubjID = 0 Then
                    If MsgBox("Do you want to add this subject?", vbQuestion + vbYesNo) = vbYes Then
                        Command("INSERT INTO enrolled_sched(SYID, EID, LRN, ScheduleID) 
                                VALUES (@SYID, @EID, @LRN, @ScheduleID)", dynamicParams)
                        Success("Successfully Added!")
                    End If
                End If
                FrmEnrollmentRegistration.LoadSubjectEnrolled()
                FrmEnrollmentRegistration.DgvEnrolledSubjects.ClearSelection()
            Else
                MsgBox("Error: dynamicParams is Nothing")
            End If
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Subject already added to this student.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub RemoveSubjRef()
        Try
            Dim dynamicParams As MySqlParameter() = EnrollSubjParameters()

            If dynamicParams IsNot Nothing Then
                If FrmEnrollmentRegistration.EnrollSubjID <> 0 Then
                    If MsgBox("Do you want to remove this subject?", vbQuestion + vbYesNo) = vbYes Then
                        Command("DELETE FROM enrolled_sched WHERE ID=@ID", dynamicParams)
                        Success("Successfully Removed!")
                    Else
                        MsgBox("You have nothing to remove.")
                    End If
                End If
                FrmEnrollmentRegistration.LoadSubjectEnrolled()
                FrmEnrollmentRegistration.DgvEnrolledSubjects.ClearSelection()
            Else
                MsgBox("Error: dynamicParams is Nothing")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
