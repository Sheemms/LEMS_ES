Public Class FrmGradeLevel
    Public idGradeLevel As Integer = 0
    Private Sub FrmGradeLevel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
        Clear()
    End Sub
    Public Sub Loadrecords()
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
    Public Sub Clear()
        txtAddGradeLevel.Clear()
        idGradeLevel = 0
    End Sub
    Private Sub DgvGradeLevel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGradeLevel.CellClick
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
    Private Sub BtnSaveSY_Click(sender As Object, e As EventArgs) Handles btnSaveSY.Click
        If IS_EMPTY(cmbDept) = True Then Return
        If IS_EMPTY(txtAddGradeLevel) = True Then Return

        ClassGradeLevel.GradeLevelRef()
        Clear()
    End Sub


    Private Sub TxtAddGradeLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddGradeLevel.KeyPress
        TextBoxDigitsOnly(txtAddGradeLevel)
    End Sub
End Class