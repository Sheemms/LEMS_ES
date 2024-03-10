Public Class frmTuitionFee
    Public idTuition As Integer = 0
    Public idMiscellaneous As Integer = 0
    Public idOtherFee As Integer = 0
    Private Sub frmTuitionFee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
        clear()
    End Sub
    Public Sub loadrecords()
        Query("SELECT tf.ID, gl.GradeLevel, tf.Amount, tf.Classification
                FROM tuition tf
                JOIN gradelevel gl ON tf.GradeLevel_ID = gl.ID")
        dgvTuitionFee.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM gradelevel")
        cmbGradeLevel.DataSource = ds.Tables("QueryTb")
        cmbGradeLevel.ValueMember = "ID"
        cmbGradeLevel.DisplayMember = "GradeLevel"

        Query("SELECT * FROM miscellaneous")
        dgvMiscellaneous.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM otherfee")
        dgvOtherFee.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        idTuition = 0
        cmbGradeLevel.Text = ""
        txtAmountTuition.Clear()
        txtClassification.Clear()

        idMiscellaneous = 0
        txtAmountMiscellaneous.Clear()

        idOtherFee = 0
        txtAmountOtherFee.Clear()
    End Sub

    Private Sub dgvTuitionFee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTuitionFee.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvTuitionFee.Rows(e.RowIndex)
                idTuition = row.Cells(0).Value
                cmbGradeLevel.Text = row.Cells(1).Value
                txtAmountTuition.Text = row.Cells(2).Value
                txtClassification.Text = row.Cells(3).Value
            ElseIf e.ColumnIndex >= 0 Then
                clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub btnSaveTuitionFee_Click(sender As Object, e As EventArgs) Handles btnSaveTuitionFee.Click
        If IS_EMPTY(cmbGradeLevel) Then Return
        If IS_EMPTY(txtAmountTuition) Then Return
        If IS_EMPTY(txtClassification) Then Return

        ClassTuition.TuitionRef()
        clear()
    End Sub

    Private Sub btnClearTuitionFee_Click(sender As Object, e As EventArgs) Handles btnClearTuitionFee.Click, btnClearMiscellaneousFee.Click, btnClearOtherFee.Click
        clear()
    End Sub

    Private Sub btnSaveMiscellaneous_Click(sender As Object, e As EventArgs) Handles btnSaveMiscellaneous.Click
        If IS_EMPTY(txtAmountMiscellaneous) Then Return

        ClassTuition.MiscellaneousRef()
        clear()
    End Sub

    Private Sub btnSaveOtherFee_Click(sender As Object, e As EventArgs) Handles btnSaveOtherFee.Click
        If IS_EMPTY(txtAmountOtherFee) Then Return

        ClassTuition.OtherFeeRef()
        clear()
    End Sub
End Class