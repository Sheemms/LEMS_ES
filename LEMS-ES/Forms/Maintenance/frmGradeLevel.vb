Public Class frmGradeLevel
    Public idGradeLevel As Integer = 0
    Private Sub frmGradeLevel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
        clear()
    End Sub
    Public Sub loadrecords()
        Query("SELECT gl.ID, d.Department , gl.GradeLevel 
                FROM gradelevel gl
                JOIN department d ON gl.Department_ID = d.ID")
        dgvGradeLevel.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM department")
        cmbDept.DataSource = ds.Tables("QueryTb")
        cmbDept.ValueMember = "ID"
        cmbDept.DisplayMember = "Department"
    End Sub
    Public Sub clear()
        idGradeLevel = 0
        cmbDept.Text = ""
        txtAddGradeLevel.Clear()
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
        clear()
    End Sub

    Private Sub btnCancelSY_Click(sender As Object, e As EventArgs) Handles btnCancelSY.Click
        clear()
    End Sub

End Class