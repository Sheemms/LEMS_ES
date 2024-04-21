Public Class frmGradeLevel
    Public idGradeLevel As Integer = 0
    Private Sub frmGradeLevel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
        ClearFields(Me, idGradeLevel)
    End Sub
    Public Sub loadrecords()
        Query("SELECT gl.ID, d.Department , gl.GradeLevel 
                FROM gradelevel gl
                JOIN department d ON gl.Department_ID = d.ID
                ORDER BY gl.GradeLevel")
        dgvGradeLevel.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM department")
        cmbDept.DataSource = ds.Tables("QueryTb")
        cmbDept.ValueMember = "ID"
        cmbDept.DisplayMember = "Department"
    End Sub
    Private Sub dgvGradeLevel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGradeLevel.CellClick
        Try
            For Each row As DataGridViewRow In dgvGradeLevel.SelectedRows
                idGradeLevel = row.Cells(0).Value
                cmbDept.Text = row.Cells(1).Value
                txtAddGradeLevel.Text = row.Cells(2).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub btnSaveSY_Click(sender As Object, e As EventArgs) Handles btnSaveSY.Click
        If IS_EMPTY(cmbDept) = True Then Return
        If IS_EMPTY(txtAddGradeLevel) = True Then Return

        ClassGradeLevel.GradeLevelRef()
        ClearFields(Me, idGradeLevel)
    End Sub


    Private Sub txtAddGradeLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddGradeLevel.KeyPress
        If e.KeyChar = "0"c AndAlso txtAddGradeLevel.TextLength = 0 Then
            e.Handled = True
        End If
    End Sub
End Class