Public Class frmSY
    Public idSY As Integer = 0
    Private Sub frmSY_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM schoolyear ORDER BY ID DESC ")
        dgvSY.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        idSY = 0
    End Sub

    Private Sub dgvSY_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSY.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvSY.Rows(e.RowIndex)
                idSY = row.Cells(0).Value
                txtAddSY.Text = row.Cells(1).Value
            ElseIf e.ColumnIndex >= 0 Then
                clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub


    Private Sub btnSaveSY_Click(sender As Object, e As EventArgs) Handles btnSaveSY.Click
        If IS_EMPTY(txtAddSY) = True Then Return

        ClassSchoolYear.SchoolYearRef()
        clear()
    End Sub

    Function GenerateSchoolYear(startYear As Integer) As String
        Dim endYear As Integer = startYear + 1
        Return $"{startYear}-{endYear}"
    End Function

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        clear()
        Dim currentYear As Integer = DateTime.Now.Year
        Dim schoolYear As String = GenerateSchoolYear(currentYear)

        ' Set the generated school year in the TextBox
        txtAddSY.Text = schoolYear
    End Sub
End Class