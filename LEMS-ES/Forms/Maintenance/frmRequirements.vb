﻿Public Class frmRequirements
    Public idRequirements As Integer = 0
    Private Sub FrmRequirements_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
        ClearFields(Me, idRequirements)
    End Sub
    Public Sub Loadrecords()
        Query("SELECT  rq.ID, reqclass.Classification, rq.Requirement
                FROM requirements rq
                JOIN req_classification reqclass ON rq.Classification_ID = reqclass.ID")
        dgvRequirements.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM req_classification")
        cmbClassification.DataSource = ds.Tables("QueryTb")
        cmbClassification.ValueMember = "ID"
        cmbClassification.DisplayMember = "Classification"
    End Sub
    Private Sub DgvRequirements_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequirements.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvRequirements.Rows(e.RowIndex)
                idRequirements = row.Cells(0).Value
                cmbClassification.Text = row.Cells(1).Value
                txtRequirements.Text = row.Cells(2).Value
            ElseIf e.ColumnIndex >= 0 Then
                ClearFields(Me, idRequirements)
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IS_EMPTY(cmbClassification) = True Then Return
        If IS_EMPTY(txtRequirements) = True Then Return

        ClassRequirements.RequirementsRef()
        ClearFields(Me, idRequirements)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        ClearFields(Me, idRequirements)
    End Sub
End Class