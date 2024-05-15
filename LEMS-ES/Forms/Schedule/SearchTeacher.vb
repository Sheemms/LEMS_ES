Public Class SearchTeacher
    Private Sub SearchTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Try
            Dim selectedRow As DataRowView = TryCast(FrmSchedule.CmbSection.SelectedItem, DataRowView)
            If selectedRow Is Nothing Then
                Info("Invalid selection.")
                Return
            End If

            Dim selectedGradeLevel As Integer
            If Not Integer.TryParse(selectedRow.Row("GradeLevel_ID").ToString(), selectedGradeLevel) OrElse selectedGradeLevel = 0 Then
                Info("Select section first.")
                Return
            End If

            Query($"SELECT a.ID, b.Department, a.EmpID, CONCAT(a.Lastname, ' ', a.Firstname) Fullname
                FROM teacher a
                JOIN department b ON a.Department_ID = b.ID
                JOIN gradelevel c ON c.Department_ID = b.ID
                WHERE c.gradelevel = {selectedGradeLevel}")
            DgvTeacher.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub

    Private Sub PbSearch_Click(sender As Object, e As EventArgs) Handles PbSearch.Click
        Dim search As String = TxtSearch.Text.Trim()

        Query($"SELECT a.ID, b.Department, a.EmpID, CONCAT(a.Lastname, ' ', a.Firstname) Fullname
                FROM teacher a
                JOIN department b ON a.Department_ID = b.ID
                WHERE b.Department LIKE '%{search}%' OR a.Lastname LIKE '%{search}%' 
                OR a.Firstname LIKE '%{search}%' OR a.EmpID LIKE '%{search}%'")
        DgvTeacher.DataSource = ds.Tables("QueryTb")
    End Sub
    Private Sub DgvTeacher_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTeacher.CellDoubleClick
        Try
            If e.RowIndex >= 0 AndAlso DgvTeacher.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DgvTeacher.SelectedRows(0)
                FrmSchedule.teacherid = Convert.ToInt32(selectedRow.Cells("Column1").Value)

                FrmSchedule.LoadTeacherData()
                Me.Close()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
End Class