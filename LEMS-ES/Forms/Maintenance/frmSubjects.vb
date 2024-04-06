Public Class frmSubjects
    Public idSubj As Integer = 0
    Private Sub frmSubjects_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
        clear()
    End Sub
    Public Sub loadrecords()
        Query("SELECT sub.ID, gl.GradeLevel, sub.SubjectCode, sub.SubjectName 
                FROM subject sub
                JOIN gradelevel gl ON sub.GradeLevel_ID = gl.ID")
        dgvSubject.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM gradelevel")
        cmbGradeLevel.DataSource = ds.Tables("QueryTb")
        cmbGradeLevel.ValueMember = "ID"
        cmbGradeLevel.DisplayMember = "GradeLevel"
    End Sub
    Public Sub clear()
        idSubj = 0
        cmbGradeLevel.Text = ""
        txtSubjCode.Clear()
        txtSubjName.Clear()
        txtUnit.Clear()
    End Sub
    Private Sub dgvSubject_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubject.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvSubject.Rows(e.RowIndex)
                idSubj = row.Cells(0).Value
                cmbGradeLevel.Text = row.Cells(1).Value
                txtSubjCode.Text = row.Cells(2).Value
                txtSubjName.Text = row.Cells(3).Value
                txtUnit.Text = row.Cells(4).Value
            ElseIf e.ColumnIndex >= 0 Then
                clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub btnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click
        If IS_EMPTY(cmbGradeLevel) = True Then Return
        If IS_EMPTY(txtSubjCode) = True Then Return
        If IS_EMPTY(txtSubjName) = True Then Return
        If IS_EMPTY(txtUnit) = True Then Return


        ClassSubject.SubjectRef()
        clear()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ClassSubject.DeleteRef()
        clear()
    End Sub

    Private Sub txtSubjName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubjName.KeyPress
        TextBoxOnlyLetters(txtSubjName)
    End Sub

    Private Sub txtUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnit.KeyPress
        TextBoxDigitsOnly(txtUnit)
    End Sub
End Class