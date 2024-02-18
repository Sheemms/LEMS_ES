Public Class frmSY
    Public idSY As Integer = 0
    Private Sub frmSY_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM schoolyear")
        dgvSY.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        idSY = 0
        txtAddSY.Clear()
    End Sub

    Private Sub dgvSY_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSY.CellClick
        Try
            If dgvSY.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvSY.SelectedRows(0)
                idSY = Convert.ToInt32(selectedRow.Cells(0).Value)
                txtAddSY.Text = selectedRow.Cells(1).Value.ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnSaveSY_Click(sender As Object, e As EventArgs) Handles btnSaveSY.Click
        'Try
        If IS_EMPTY(txtAddSY) = True Then Return

        ClassSchoolYear.SchoolYearRef()
        clear()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub btnCancelSY_Click(sender As Object, e As EventArgs) Handles btnClearSY.Click
        clear()
    End Sub

End Class