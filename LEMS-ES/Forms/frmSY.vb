﻿Imports MySql.Data.MySqlClient
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

    Private Sub dgvSY_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSY.CellClick
        Try
            For Each row As DataGridViewRow In dgvSY.SelectedRows
                idSY = row.Cells(0).Value
                txtAddSY.Text = row.Cells(1).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub

    Private Sub btnSaveSY_Click(sender As Object, e As EventArgs) Handles btnSaveSY.Click
        If IS_EMPTY(txtAddSY) = True Then Return

        Query("SELECT * FROM schoolyear WHERE SchoolYear= '" & txtAddSY.Text & "' and ID <> '" & idSY & "'")
        If ds.Tables("QueryTb").Rows.Count > 0 Then
            Critical("School Year already exist")
            Exit Sub
        End If

        ClassSchoolYear.SchoolYearRef()
        Success("Successfully Added!")
        loadrecords()
        txtAddSY.Clear()
    End Sub

    Private Sub btnCancelSY_Click(sender As Object, e As EventArgs) Handles btnClearSY.Click
        txtAddSY.Clear()
    End Sub

End Class