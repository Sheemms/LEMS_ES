Imports MySql.Data.MySqlClient
Public Class ClassEnroll
#Region "EnrollmentParameters"
    Public Shared Function EnrollmentParameters() As MySqlParameter()
        Try
            Dim enrollParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmEnrollmentRegistration.EnrollmentID),
                    New MySqlParameter("@SchoolYear", frmEnrollmentRegistration.lblSY.Text),
                    New MySqlParameter("@LRN", frmEnrollmentRegistration.txtStudLRN.Text),
                    New MySqlParameter("@SectionID", frmEnrollmentRegistration.cmbSection.SelectedValue),
                    New MySqlParameter("@GradeLevel_ID", frmEnrollmentRegistration.cmbGradeLevel.SelectedValue)
                }
            Return enrollParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub EnrollmentRef()
        Try
            Dim dynamicParams As MySqlParameter() = EnrollmentParameters()
            If frmDepartment.idDept = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO enrollment(SchoolYear, LRN, SectionID, GradeLevel_ID) 
                                VALUES (@SchoolYear, @LRN, @SectionID, @GradeLevel_ID)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do u want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE enrollment SET SchoolYear=@SchoolYear, LRN=@LRN, SectionID=@SectionID, GradeLevel_ID=@GradeLevel_ID WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmDepartment.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Student already enrolled.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
