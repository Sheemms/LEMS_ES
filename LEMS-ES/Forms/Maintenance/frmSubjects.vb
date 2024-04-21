Public Class FrmSubjects
    Public idSubj As Integer = 0
    Private Sub FrmSubjects_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadRecords()
    End Sub
    Public Sub LoadRecords()
        Query("SELECT sub.ID, gl.GradeLevel, sub.SubjectCode, sub.SubjectName, sub.Description, sub.Units
                FROM subject sub
                JOIN gradelevel gl ON sub.GradeLevel_ID = gl.ID
                ORDER BY gl.GradeLevel")
        DgvSubject.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM gradelevel")
        CmbGradeLevel.DataSource = ds.Tables("QueryTb")
        CmbGradeLevel.ValueMember = "ID"
        CmbGradeLevel.DisplayMember = "GradeLevel"
    End Sub
    Public Sub Clear()
        idSubj = 0
        CmbGradeLevel.Text = ""
        txtSubjCode.Clear()
        txtSubjName.Clear()
        txtUnit.Clear()
    End Sub
    Private Sub DgvSubject_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSubject.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DgvSubject.Rows(e.RowIndex)
                idSubj = row.Cells(0).Value
                CmbGradeLevel.Text = row.Cells(1).Value
                txtSubjCode.Text = row.Cells(2).Value
                txtSubjName.Text = row.Cells(3).Value
                txtUnit.Text = row.Cells(4).Value
            ElseIf e.ColumnIndex >= 0 Then
                Clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub BtnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click
        If IS_EMPTY(CmbGradeLevel) = True Then Return
        If IS_EMPTY(txtSubjCode) = True Then Return
        If IS_EMPTY(txtSubjName) = True Then Return
        If IS_EMPTY(txtUnit) = True Then Return


        ClassSubject.SubjectRef()
        Clear()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ClassSubject.DeleteRef()
        Clear()
    End Sub

    Private Sub TxtSubjName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubjName.KeyPress
        TextBoxOnlyLetters(txtSubjName)
    End Sub

    Private Sub TxtUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnit.KeyPress, TxtDesc.KeyPress
        TextBoxDigitsOnly(txtUnit)
    End Sub
End Class