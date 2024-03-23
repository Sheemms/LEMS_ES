﻿Public Class frmDepartment
    Public idDept As Integer = 0
    Private Sub frmDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM department")
        dgvDepartment.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        idDept = 0
        txtDeptName.Clear()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IS_EMPTY(txtDeptName) = True Then Return

        ClassDepartment.DepartmentRef()
        clear()
    End Sub

    Private Sub dgvDepartment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartment.CellClick
        Try
            For Each row As DataGridViewRow In dgvDepartment.SelectedRows
                idDept = row.Cells(0).Value
                txtDeptName.Text = row.Cells(1).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
End Class