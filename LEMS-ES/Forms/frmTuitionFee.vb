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
        txtAmount.Clear()
        txtClassification.Clear()
    End Sub
    Private Sub btnSaveTuitionFee_Click(sender As Object, e As EventArgs) Handles btnSaveTuitionFee.Click
        If IS_EMPTY(txtAmount) Then Return
        If IS_EMPTY(txtClassification) Then Return

        ClassTuition.TuitionRef()
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnClearTuitionFee_Click(sender As Object, e As EventArgs) Handles btnClearTuitionFee.Click

    End Sub
End Class