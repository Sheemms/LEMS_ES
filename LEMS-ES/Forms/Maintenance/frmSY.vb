Public Class FrmSY
    Public idSY As Integer = 0
    Private Sub FrmSY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT * FROM schoolyear ORDER BY ID DESC ")
        DgvSY.DataSource = ds.Tables("QueryTb")
        txtStartYear.Text = Year(Now)
    End Sub
    Private Sub DgvSY_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSY.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DgvSY.Rows(e.RowIndex)
                idSY = row.Cells(0).Value
                txtStartYear.Text = row.Cells(1).Value
                txtEndYear.Text = row.Cells(2).Value
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

        ClassSchoolYear.SchoolYearRef()
        ClearFields(Me, idSY)
    End Sub
End Class