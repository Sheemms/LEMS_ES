Public Class frmSY
    Public idSY As Integer = 0
    Private Sub frmSY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM schoolyear ORDER BY ID DESC ")
        dgvSY.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        idSY = 0
        txtStartYear.Clear()
        txtEndYear.Clear()
    End Sub

    Private Sub dgvSY_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvSY.Rows(e.RowIndex)
                idSY = row.Cells(0).Value
                txtStartYear.Text = row.Cells(1).Value
                txtEndYear.Text = row.Cells(2).Value
            ElseIf e.ColumnIndex >= 0 Then
                clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub


    Private Sub btnSaveSY_Click(sender As Object, e As EventArgs) Handles btnSaveSY.Click
        'If IS_EMPTY(txtStartYear) = True Then Return
        If IS_EMPTY(txtEndYear) = True Then Return

        ClassSchoolYear.SchoolYearRef()
        clear()
    End Sub

    Function GenerateSchoolYear(startYear As Integer) As String
        Dim endYear As Integer = startYear + txtEndYear.Text
        Return $"{startYear}-{endYear}"
    End Function

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs)
        clear()
        Dim currentYear As Integer = DateTime.Now.Year
        Dim schoolYear As String = GenerateSchoolYear(currentYear)

        ' Set the generated school year in the TextBox
        txtStartYear.Text = schoolYear
    End Sub

    Private Sub dgvSY_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSY.CellContentClick

    End Sub

End Class