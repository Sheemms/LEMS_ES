Public Class SearchSection
    Private Sub SearchSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadrecords()
    End Sub

    Public Sub Loadrecords()
        Try
            Query("SELECT a.ID, c.Department, b.GradeLevel as Grade, a.SectionRoom as Section,
                d.EmpID, CONCAT(d.Lastname, ' ', d.Firstname) Adviser
                FROM section a
                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                JOIN department c ON b.Department_ID = c.ID
                JOIN teacher d ON a.AdviserID = d.ID")
            DgvSection.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub

    Private Sub PbSearch_Click(sender As Object, e As EventArgs) Handles PbSearch.Click
        Try
            Dim search As String = TxtSearch.Text.Trim()

            Query($"SELECT a.ID, c.Department, b.GradeLevel as Grade, a.SectionRoom as Section,
                d.EmpID, CONCAT(d.Lastname, ' ', d.Firstname) Adviser
                FROM section a
                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                JOIN department c ON b.Department_ID = c.ID
                JOIN teacher d ON a.AdviserID = d.ID
                WHERE d.Lastname LIKE '%{search}%' OR d.Firstname LIKE '%{search}%' OR c.Department LIKE '%{search}%' OR b.EmpID LIKE '%{search}%' 
                OR b.GradeLevel LIKE '%{search}%' OR a.SectionRoom LIKE '%{search}%'")
            DgvSection.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub

    Private Sub DgvSection_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSection.CellDoubleClick
        Try
            If DgvSection.SelectedRows.Count > 0 Then
                With DgvSection.SelectedRows(0)
                    FrmSchedule.idSection = .Cells(0).Value
                End With
                FrmSchedule.LoadSectionData()
                Me.Close()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
End Class