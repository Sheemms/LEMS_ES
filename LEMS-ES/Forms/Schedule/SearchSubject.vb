Public Class SearchSubject
    Private Sub SearchSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Dim selectedRow As DataRowView = TryCast(FrmSchedule.CmbSection.SelectedItem, DataRowView)

        Dim selectedGradeLevelID As Integer = Convert.ToInt32(selectedRow.Row("GradeLevel_ID"))
        Query($"SELECT a.ID, c.Department, b.GradeLevel as Grade, a.SubjectCode, a.SubjectName, a.Units
                FROM subject a
                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                JOIN department c ON b.Department_ID = c.ID
                WHERE b.GradeLevel = {selectedGradeLevelID}")
        DgvSubject.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub PbSearch_Click(sender As Object, e As EventArgs) Handles PbSearch.Click
        Dim search As String = TxtSearch.Text.Trim()

        Query($"SELECT a.ID, c.Department, b.GradeLevel as Grade, a.SubjectCode, a.SubjectName, a.Units
                FROM subject a
                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                JOIN department c ON b.Department_ID = c.ID
                WHERE c.Department LIKE '%{search}%' OR a.SubjectCode LIKE '%{search}%' 
                OR a.SubjectName LIKE '%{search}%' OR a.Units LIKE '%{search}%' OR b.GradeLevel LIKE '%{search}%'")
        DgvSubject.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub DgvSection_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSubject.CellDoubleClick
        If DgvSubject.SelectedRows.Count > 0 Then
            With DgvSubject.SelectedRows(0)
                FrmSchedule.idSub = .Cells(0).Value
            End With
            FrmSchedule.LoadSubjectData()
            Me.Close()
        End If
    End Sub
End Class