Imports MySql.Data.MySqlClient
Public Class ClassSchoolYear
    Public Shared Function SchoolYearParam() As MySqlParameter()
        Try
            Dim SYparam() As MySqlParameter = {
                   New MySqlParameter("@SchoolYear", frmSY.txtAddSY.Text)
        }
            Return SYparam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Function SchoolYearParameters(row As DataGridViewRow) As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", If(row.Cells(0).Value Is Nothing Or IsDBNull(row.Cells(0).Value), "", row.Cells(0).Value)),
                    New MySqlParameter("@SchoolYear", If(row.Cells(1).Value Is Nothing Or IsDBNull(row.Cells(1).Value), "", row.Cells(1).Value))
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub SchoolYearRef()
        For Each row As DataGridViewRow In frmSY.dgvSY.Rows
            If Not row.IsNewRow Then
                Dim dynamicParams As MySqlParameter() = SchoolYearParam()
                If row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
                    Command("UPDATE schoolyear SET SchoolYear = @SchoolYear WHERE ID = @ID", dynamicParams)
                ElseIf row.Cells(0).Value Is Nothing Or IsDBNull(row.Cells(0).Value) Then
                    Command("INSERT INTO schoolyear (SchoolYear) VALUES (@SchoolYear)", dynamicParams)
                End If
            End If
        Next
    End Sub
End Class
