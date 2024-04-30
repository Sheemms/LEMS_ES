Imports MySql.Data.MySqlClient
Public Class ClassGrading
#Region "Grading"
    Public Shared Function GradingParameters(dgv As DataGridView, rowIndex As Integer) As MySqlParameter()
        Try
            Dim schoolYearID As Integer = GetSchoolYearID()

            If schoolYearID <> -1 Then
                Dim gradingParam() As MySqlParameter = {
                    New MySqlParameter("@ID", dgv.Rows(rowIndex).Cells("ID").Value),
                    New MySqlParameter("@FirstGrd", dgv.Rows(rowIndex).Cells("firstg").Value),
                    New MySqlParameter("@SecondGrd", dgv.Rows(rowIndex).Cells("secondg").Value),
                    New MySqlParameter("@ThirdGrd", dgv.Rows(rowIndex).Cells("thirdg").Value),
                    New MySqlParameter("@FourthGrd", dgv.Rows(rowIndex).Cells("fourthg").Value),
                    New MySqlParameter("@Average", dgv.Rows(rowIndex).Cells("average").Value),
                    New MySqlParameter("@Remarks", dgv.Rows(rowIndex).Cells("remarks").Value)
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
                    If MsgBox("Do you want to add this grades?", vbQuestion + vbYesNo) = vbYes Then
                        Command("UPDATE enrolled_sched SET FirstGrd=@FirstGrd, SecondGrd=@SecondGrd, ThirdGrd=@ThirdGrd, FourthGrd=@FourthGrd, Average=@Average, Remarks=@Remarks WHERE ID=@ID", dynamicParams)
                        Success("Successfully Save!")
                    End If
                End If
            Else
                MsgBox("Error: dynamicParams is Nothing")
            End If
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Grades already added to this student.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
