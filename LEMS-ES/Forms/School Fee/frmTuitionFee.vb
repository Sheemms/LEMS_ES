Public Class frmTuitionFee
    Public idTuition As Integer = 0
    Public idMiscellaneous As Integer = 0
    Public idOtherFee As Integer = 0
    Public idMOP As Integer = 0
    Public idTOP As Integer = 0
    Private Sub FrmTuitionFee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
        Clear()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT tf.ID, gl.GradeLevel, tf.Amount
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

        Query("SELECT * FROM mop")
        dgvMOP.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM top")
        dgvTOP.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub Clear()
        idTuition = 0
        cmbGradeLevel.Text = ""
        txtAmountTuition.Clear()

        idMiscellaneous = 0
        txtAmountMiscellaneous.Clear()

        idOtherFee = 0
        txtOtherFeeDesc.Clear()

        idMOP = 0
        txtMOP.Clear()
    End Sub

    Private Sub DgvTuitionFee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTuitionFee.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvTuitionFee.Rows(e.RowIndex)
                idTuition = row.Cells(0).Value
                cmbGradeLevel.Text = row.Cells(1).Value
                txtAmountTuition.Text = row.Cells(2).Value
            ElseIf e.ColumnIndex >= 0 Then
                clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub BtnSaveTuitionFee_Click(sender As Object, e As EventArgs) Handles btnSaveTuitionFee.Click
        If IS_EMPTY(cmbGradeLevel) Then Return
        If IS_EMPTY(txtAmountTuition) Then Return

        ClassTuition.TuitionRef()
        ClearFields(Me, idTuition)
    End Sub

    Private Sub BtnClearTuitionFee_Click(sender As Object, e As EventArgs) Handles btnClearMiscellaneousFee.Click, btnClearOtherFee.Click, btnMOPClear.Click, btnTOPClear.Click
        clear()
    End Sub

    Private Sub BtnSaveMiscellaneous_Click(sender As Object, e As EventArgs) Handles btnSaveMiscellaneous.Click
        If IS_EMPTY(txtAmountMiscellaneous) Then Return

        ClassTuition.MiscellaneousRef()
        ClearFields(Me, idMiscellaneous)
    End Sub

    Private Sub BtnSaveOtherFee_Click(sender As Object, e As EventArgs) Handles btnSaveOtherFee.Click
        If IS_EMPTY(txtOtherFeeDesc) Then Return
        If IS_EMPTY(txtAmountOtherFee) Then Return

        ClassTuition.OtherFeeRef()
        ClearFields(Me, idOtherFee)
    End Sub

    Private Sub BtnMOP_Click(sender As Object, e As EventArgs) Handles btnMOP.Click
        If IS_EMPTY(txtMOP) Then Return

        ClassTuition.MoPRef()
        ClearFields(Me, idMOP)
    End Sub

    Private Sub BtnTOP_Click(sender As Object, e As EventArgs) Handles btnTOP.Click
        If IS_EMPTY(txtTOP) Then Return

        ClassTuition.ToPRef()
        clear()
    End Sub

End Class