Public Class FrmDepartment
    Public idDept As Integer = 0
    Private Sub FrmDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT * FROM department")
        dgvDepartment.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub Clear()
        TxtDeptName.Clear()
        idDept = 0
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If IS_EMPTY(TxtDeptName) = True Then Return

        ClassDepartment.DepartmentRef()
        Clear()
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

    Private Sub TxtDeptName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDeptName.KeyPress
        TextBoxOnlyLetters(TxtDeptName)
    End Sub
End Class