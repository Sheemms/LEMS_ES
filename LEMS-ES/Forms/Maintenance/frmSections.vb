﻿Public Class frmSections
    Public idSection As Integer = 0
    Private Sub frmSections_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM section")
        dgvSection.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        idSection = 0
        txtSectionName.Clear()
        txtSectionCapacity.Clear()
    End Sub
    Private Sub dgvSection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSection.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvSection.Rows(e.RowIndex)
                idSection = row.Cells(0).Value
                txtSectionName.Text = row.Cells(1).Value
                txtSectionCapacity.Text = row.Cells(2).Value
            ElseIf e.ColumnIndex >= 0 Then
                clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub btnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click
        If IS_EMPTY(txtSectionName) = True Then Return
        If IS_EMPTY(txtSectionCapacity) = True Then Return

        ClassSection.SectionRef()
        clear()
    End Sub

    Private Sub btnClearSubject_Click(sender As Object, e As EventArgs) Handles btnClearSubject.Click
        clear()
    End Sub


End Class