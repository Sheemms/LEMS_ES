Public Class frmGradeLevel
    Public idGradeLevel As Integer = 0
    Private Sub frmGradeLevel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM gradelevel")
        dgvGradeLevel.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        txtAddGradeLevel.Clear()
    End Sub
    Private Sub dgvGradeLevel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGradeLevel.CellClick
        Try
            For Each row As DataGridViewRow In dgvGradeLevel.SelectedRows
                idGradeLevel = row.Cells(0).Value
                txtAddGradeLevel.Text = row.Cells(1).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub btnSaveSY_Click(sender As Object, e As EventArgs) Handles btnSaveSY.Click
        MsgBox(idGradeLevel)
        If IS_EMPTY(txtAddGradeLevel) = True Then Return

        Query("SELECT * FROM gradelevel WHERE GradeLevel= '" & txtAddGradeLevel.Text & "' and ID <> '" & idGradeLevel & "'")
        If ds.Tables("QueryTb").Rows.Count > 0 Then
            Critical("Grade Level already exist")
            Exit Sub
        End If

        ClassGradeLevel.GradeLevelRef()
        Success("Successfully Added!")
        clear()
        loadrecords()
    End Sub

    Private Sub btnCancelSY_Click(sender As Object, e As EventArgs) Handles btnCancelSY.Click
        clear()
    End Sub
End Class