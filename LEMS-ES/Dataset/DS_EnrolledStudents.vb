Partial Class DS_EnrolledStudents
    Partial Public Class Dt_EnrolledStudentsDataTable
        Private Sub Dt_EnrolledStudentsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.LRNColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
