﻿Public Class FrmTuitionFee
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
        DgvOtherFee.DataSource = ds.Tables("QueryTb")

        'Query("SELECT * FROM mop")
        'dgvMOP.DataSource = ds.Tables("QueryTb")

        'Query("SELECT * FROM top")
        'dgvTOP.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub Clear()
        idTuition = 0
        cmbGradeLevel.Text = ""
        txtAmountTuition.Clear()
        btnSaveTuitionFee.Enabled = True

        idMiscellaneous = 0
        txtAmountMiscellaneous.Clear()

        idOtherFee = 0
        txtOtherFeeDesc.Clear()
        txtAmountOtherFee.Clear()
    End Sub

    Private Sub DgvTuitionFee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTuitionFee.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvTuitionFee.Rows(e.RowIndex)
                idTuition = row.Cells(0).Value
                cmbGradeLevel.Text = row.Cells(1).Value
                txtAmountTuition.Text = row.Cells(2).Value
            ElseIf e.ColumnIndex >= 0 Then
                Clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
        btnSaveTuitionFee.Enabled = False
    End Sub
    Private Sub BtnSaveTuitionFee_Click(sender As Object, e As EventArgs) Handles btnSaveTuitionFee.Click, BtnUpdateTuition.Click
        If IS_EMPTY(cmbGradeLevel) Then Return
        If IS_EMPTY(txtAmountTuition) Then Return

        If Not NoLeadingSpace(txtAmountTuition.Text.Trim()) Then
            MsgBox("Amount must have no leading spaces.")
            Return
        End If
        ClassTuition.TuitionRef()
    End Sub
    Private Sub BtnClearTuitionFee_Click(sender As Object, e As EventArgs) Handles BtnClearTuition.Click, btnClearMiscellaneousFee.Click, btnClearOtherFee.Click
        Clear()
    End Sub

    Private Sub BtnSaveMiscellaneous_Click(sender As Object, e As EventArgs) Handles btnSaveMiscellaneous.Click
        If IS_EMPTY(txtAmountMiscellaneous) Then Return

        If Not NoLeadingSpace(txtAmountMiscellaneous.Text.Trim()) Then
            MsgBox("Amount must have no leading spaces.")
            Return
        End If
        ClassTuition.MiscellaneousRef()
    End Sub

    Private Sub BtnSaveOtherFee_Click(sender As Object, e As EventArgs) Handles btnSaveOtherFee.Click, BtnUpdateOtherFee.Click
        If IS_EMPTY(txtOtherFeeDesc) Then Return
        If IS_EMPTY(txtAmountOtherFee) Then Return

        If Not NoLeadingSpace(txtAmountOtherFee.Text.Trim()) Then
            MsgBox("Amount must have no leading spaces.")
            Return
        ElseIf Not NoLeadingSpace(txtOtherFeeDesc.Text.Trim()) Then
            MsgBox("Description must have no leading space.")
            Return
        End If
        ClassTuition.OtherFeeRef()
    End Sub
    Private Sub DgvOtherFee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvOtherFee.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DgvOtherFee.Rows(e.RowIndex)
                idOtherFee = row.Cells(0).Value
                txtOtherFeeDesc.Text = row.Cells(1).Value
                txtAmountOtherFee.Text = row.Cells(2).Value
            ElseIf e.ColumnIndex >= 0 Then
                Clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub

    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountTuition.KeyPress, txtAmountMiscellaneous.KeyPress, txtAmountOtherFee.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtherFeeDesc.KeyPress
        If Not IsValidInput(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    'Private Sub BtnMOP_Click(sender As Object, e As EventArgs)
    '    If IS_EMPTY(txtMOP) Then Return

    '    ClassTuition.MoPRef()
    '    Clear()
    'End Sub

    'Private Sub BtnTOP_Click(sender As Object, e As EventArgs)
    '    If IS_EMPTY(txtTOP) Then Return

    '    ClassTuition.ToPRef()
    '    Clear()
    'End Sub

End Class