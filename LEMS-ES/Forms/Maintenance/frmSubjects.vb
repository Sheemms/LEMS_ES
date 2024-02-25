Public Class frmSubjects
    Public idSubj As Integer = 0
    Private Sub frmSubjects_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM subject")
        dgvSubject.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        idSubj = 0
        txtSubjCode.Clear()
        txtSubjName.Clear()
    End Sub
    Private Sub dgvSubject_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubject.CellClick
        Try
            For Each row As DataGridViewRow In dgvSubject.SelectedRows
                idSubj = row.Cells(0).Value
                txtSubjCode.Text = row.Cells(1).Value
                txtSubjName.Text = row.Cells(2).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try

    End Sub
    Private Sub btnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click
        If IS_EMPTY(txtSubjCode) = True Then Return
        If IS_EMPTY(txtSubjName) = True Then Return


        ClassSubject.SubjectRef()
        clear()
    End Sub

    Private Sub btnClearSubject_Click(sender As Object, e As EventArgs) Handles btnClearSubject.Click
        clear()
    End Sub
End Class