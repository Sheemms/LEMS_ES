Public Class frmGradeLevel
    Dim id As String = ""
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
    Private Sub btnSaveSY_Click(sender As Object, e As EventArgs) Handles btnSaveSY.Click
        If IS_EMPTY(txtAddGradeLevel) = True Then Return

        Query("SELECT * FROM schoolyear WHERE SchoolYear= '" & txtAddGradeLevel.Text & "' and ID <> '" & id & "'")
        If ds.Tables("QueryTb").Rows.Count > 0 Then
            Critical("School Year already exist")
            Exit Sub
        End If


        Success("Successfully Added!")
        clear()
        loadrecords()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnCancelSY_Click(sender As Object, e As EventArgs) Handles btnCancelSY.Click
        clear()
    End Sub

    Private Sub dgvGradeLevel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGradeLevel.CellClick
        Try
            For Each row As DataGridViewRow In dgvGradeLevel.SelectedRows
                id = row.Cells(0).Value
                dgvGradeLevel.Text = row.Cells(1).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
End Class