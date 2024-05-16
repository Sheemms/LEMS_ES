﻿Public Class FrmDepartment
    Public idDept As Integer = 0
    Private Sub FrmDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Try
            Query("SELECT * FROM department")
            dgvDepartment.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub Clear()
        TxtDeptName.Clear()
        idDept = 0
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click, BtnUpdate.Click
        If Not IsEmptyField(TxtDeptName.Text.Trim()) Then
            Info("Please enter a department name.")
            Return
        End If

        If Not NoLeadingSpace(TxtDeptName.Text.Trim()) Then
            Info("Department name must have no multiple spaces between letters.")
            Return
        End If
        ClassDepartment.DepartmentRef()
    End Sub

    Private Sub DgvDepartment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartment.CellClick
        Try
            For Each row As DataGridViewRow In dgvDepartment.SelectedRows
                idDept = row.Cells(0).Value
                TxtDeptName.Text = row.Cells(1).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDeptName.KeyPress
        If Not IsValidInput(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ClassDepartment.DeleteDepartment(idDept)
    End Sub
End Class