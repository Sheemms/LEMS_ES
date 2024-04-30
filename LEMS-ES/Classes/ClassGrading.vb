Imports MySql.Data.MySqlClient
Public Class ClassGrading
#Region "Grading"
    Public Shared Function GradingParameters(dgv As DataGridView, rowIndex As Integer) As MySqlParameter()
        Try
            Dim schoolYearID As Integer = GetSchoolYearID()

            If schoolYearID <> -1 Then
                Dim gradingParam() As MySqlParameter = {
                    New MySqlParameter("@Average", dgv.Rows(rowIndex).Cells(12).Value),
                    New MySqlParameter("@Remarks", dgv.Rows(rowIndex).Cells(13).Value)
                }
                Return gradingParam
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub GradingRef(dgv As DataGridView, rowIndex As Integer)
        Try
            Dim dynamicParams As MySqlParameter() = GradingParameters(dgv, rowIndex)

            If dynamicParams IsNot Nothing Then
                If FrmEnrollmentRegistration.EnrollSubjID = 0 Then
                    If MsgBox("Do you want to add this subject?", vbQuestion + vbYesNo) = vbYes Then
                        Command("UPDATE enrolled_sched SET Average=@Average", dynamicParams)
                        Success("Successfully Save!")
                    End If
                End If
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
#End Region
End Class
