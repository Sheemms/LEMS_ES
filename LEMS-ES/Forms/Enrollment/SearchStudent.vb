Public Class SearchStudent
    Private Sub SearchStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Try
            Query("SELECT ID, LRN, CONCAT(Lastname, ', ', Firstname, ' ', MiddleInitial, ' ', Suffix) Fullname FROM student")
            DgvStudent.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub

    Private Sub PbSearch_Click(sender As Object, e As EventArgs) Handles PbSearch.Click
        Dim search As String = TxtSearch.Text.Trim()

        Query($"SELECT ID, LRN, CONCAT(Lastname, ', ', Firstname, ' ', MiddleInitial, ' ', Suffix) Fullname FROM student
                WHERE Lastname LIKE '%{search}%' OR Firstname LIKE '%{search}%' OR MiddleInitial LIKE '%{search}%' OR LRN LIKE '%{search}%'")
        DgvStudent.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub DgvStudent_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvStudent.CellDoubleClick
        Try
            If e.RowIndex >= 0 AndAlso DgvStudent.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DgvStudent.SelectedRows(0)
                FrmEnrollmentRegistration.idStud = selectedRow.Cells(0).Value
                FrmEnrollmentRegistration.LoadStudentData()
                Me.Close()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
End Class