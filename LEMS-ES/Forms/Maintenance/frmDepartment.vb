Public Class frmDepartment
    Public idDept As Integer = 0
    Private Sub FrmDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT * FROM department")
        dgvDepartment.DataSource = ds.Tables("QueryTb")
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IS_EMPTY(txtDeptName) = True Then Return

        ClassDepartment.DepartmentRef()
        ClearFields(Me, idDept)
    End Sub

    Private Sub DgvDepartment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartment.CellClick
        Try
            For Each row As DataGridViewRow In dgvDepartment.SelectedRows
                idDept = row.Cells(0).Value
                txtDeptName.Text = row.Cells(1).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub

    Private Sub txtDeptName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeptName.KeyPress
        TextBoxOnlyLetters(txtDeptName)
    End Sub
End Class