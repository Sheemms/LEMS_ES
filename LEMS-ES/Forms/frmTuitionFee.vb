Public Class frmTuitionFee
    Public idTuition As Integer = 0
    Private Sub frmTuitionFee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM tuition")
        dgvTuitionFee.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        idTuition = 0
        txtAmount.Clear()
        txtClassification.Clear()
    End Sub

    Private Sub dgvTuitionFee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTuitionFee.CellClick
        Try
            For Each row As DataGridViewRow In dgvTuitionFee.SelectedRows
                idTuition = row.Cells(0).Value
                txtAmount.Text = row.Cells(1).Value
                txtClassification.Text = row.Cells(2).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub btnSaveTuitionFee_Click(sender As Object, e As EventArgs) Handles btnSaveTuitionFee.Click
        If IS_EMPTY(txtAmount) Then Return
        If IS_EMPTY(txtClassification) Then Return

        ClassTuition.TuitionRef()
        clear()
    End Sub

    Private Sub btnClearTuitionFee_Click(sender As Object, e As EventArgs) Handles btnClearTuitionFee.Click
        clear()
    End Sub
End Class