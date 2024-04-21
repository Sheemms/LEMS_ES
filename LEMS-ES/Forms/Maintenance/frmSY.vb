Public Class frmSY
    Public idSY As Integer = 0
    Private Sub frmSY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        loadrecords()
        txtStartYear.Text = Year(Now)
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM schoolyear ORDER BY ID DESC ")
        DgvSY.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        idSY = 0
        txtStartYear.Clear()
        txtEndYear.Clear()
    End Sub

    Private Sub DgvSY_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSY.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DgvSY.Rows(e.RowIndex)
                idSY = row.Cells(0).Value
                txtStartYear.Text = row.Cells(1).Value
                txtEndYear.Text = row.Cells(2).Value
            ElseIf e.ColumnIndex >= 0 Then
                clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
            Exit Sub
        End Try
    End Sub


    Private Sub btnSaveSY_Click(sender As Object, e As EventArgs) Handles btnSaveSY.Click
        If IS_EMPTY(txtEndYear) = True Then Return

        ClassSchoolYear.SchoolYearRef()
        clear()
    End Sub
End Class