Imports MySql.Data.MySqlClient
Public Class ClassGrading
#Region "Grading"
    Public Shared Function GradingParameters(row As DataGridViewRow) As MySqlParameter()
        Try
            Dim gradingParam() As MySqlParameter = {
                New MySqlParameter("@ID", If(String.IsNullOrWhiteSpace(row.Cells("ID").Value), DBNull.Value, row.Cells("ID").Value)),
                New MySqlParameter("@FirstGrd", If(String.IsNullOrWhiteSpace(row.Cells("firstg").Value), DBNull.Value, row.Cells("firstg").Value)),
                New MySqlParameter("@SecondGrd", If(String.IsNullOrWhiteSpace(row.Cells("secondg").Value), DBNull.Value, row.Cells("secondg").Value)),
                New MySqlParameter("@ThirdGrd", If(String.IsNullOrWhiteSpace(row.Cells("thirdg").Value), DBNull.Value, row.Cells("thirdg").Value)),
                New MySqlParameter("@FourthGrd", If(String.IsNullOrWhiteSpace(row.Cells("fourthg").Value), DBNull.Value, row.Cells("fourthg").Value)),
                New MySqlParameter("@Average", If(String.IsNullOrWhiteSpace(row.Cells("average").Value), DBNull.Value, row.Cells("average").Value)),
                New MySqlParameter("@Remarks", If(String.IsNullOrWhiteSpace(row.Cells("remarks").Value), DBNull.Value, row.Cells("remarks").Value))
            }
            Return gradingParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub GradingRef(dgv As DataGridView)
        Try
            If MsgBox("Do you want to add this grades?", vbQuestion + vbYesNo) = vbYes Then
                For Each row As DataGridViewRow In dgv.Rows
                    Dim dynamicParams As MySqlParameter() = GradingParameters(row)
                    If dynamicParams IsNot Nothing Then
                        If dynamicParams(0).Value IsNot DBNull.Value Then
                            Command("UPDATE enrolled_sched SET FirstGrd=@FirstGrd, SecondGrd=@SecondGrd, ThirdGrd=@ThirdGrd, FourthGrd=@FourthGrd, Average=@Average, Remarks=@Remarks WHERE ID=@ID", dynamicParams)
                        End If
                    End If
                Next
                Success("Successfully Save!")
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
            'Catch ex As MySqlException When ex.Number = 1062
            '    Critical("Grades already added to this student.")
            '    Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
