Public Class FrmSY
    Public idSY As Integer = 0
    Private Sub FrmSY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT ID, CONCAT(Start_Year, '-', End_Year) SchoolYear, Status FROM schoolyear ORDER BY ID DESC ")
        DgvSY.DataSource = ds.Tables("QueryTb")
        txtStartYear.Text = Year(Now)
    End Sub
    Private Sub DgvSY_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSY.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DgvSY.Rows(e.RowIndex)
                idSY = row.Cells(0).Value
                Dim schoolYear As String = row.Cells(1).Value.ToString()
                Dim years() As String = schoolYear.Split("-"c)
                txtStartYear.Text = years(0)
                txtEndYear.Text = years(1)
            ElseIf e.ColumnIndex >= 0 Then
                ClearFields(Me, idSY)
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
            Exit Sub
        End Try
    End Sub



    Private Sub BtnSaveSY_Click(sender As Object, e As EventArgs) Handles btnSaveSY.Click
        If IS_EMPTY(txtEndYear) = True Then Return
        Dim endYear As Integer
        If Not Integer.TryParse(txtEndYear.Text, endYear) Then
            MessageBox.Show("Invalid end year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim currentYear As Integer = Year(Now)
        If endYear < currentYear OrElse endYear > currentYear + 1 Then
            MessageBox.Show("End year should be between " & currentYear & " and " & (currentYear + 1) & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ClassSchoolYear.SchoolYearRef()
        ClearFields(Me, idSY)
    End Sub
End Class