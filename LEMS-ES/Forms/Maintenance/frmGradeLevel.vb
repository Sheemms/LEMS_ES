Public Class FrmGradeLevel
    Public idGradeLevel As Integer = 0
    Private Sub FrmGradeLevel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
        Clear()
    End Sub
    Public Sub Loadrecords()
        Try
            Query("SELECT gl.ID, d.Department , gl.GradeLevel 
                FROM gradelevel gl
                JOIN department d ON gl.Department_ID = d.ID
                ORDER BY gl.GradeLevel")
            dgvGradeLevel.DataSource = ds.Tables("QueryTb")

            Query("SELECT * FROM department")
            cmbDept.DataSource = ds.Tables("QueryTb")
            cmbDept.ValueMember = "ID"
            cmbDept.DisplayMember = "Department"
        Catch ex As Exception
            Critical(ex.Message)
        End Try
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
        If Not IsEmptyField(cmbDept.Text.Trim()) Then
            Info("Please select a department.")
            Return
        End If

        If Not IsEmptyField(txtAddGradeLevel.Text.Trim()) Then
            Info("Please enter a grade level.")
            Return
        End If

        If Not NoLeadingSpace(txtAddGradeLevel.Text.Trim()) Then
            Info("Grade Level must have no multiple spaces between letters.")
            Return
        End If
        ClassGradeLevel.GradeLevelRef()
    End Sub

    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddGradeLevel.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
End Class