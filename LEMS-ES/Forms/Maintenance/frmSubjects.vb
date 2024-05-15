Public Class FrmSubjects
    Public idSubj As Integer = 0
    Private Sub FrmSubjects_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadRecords()
    End Sub
    Public Sub LoadRecords()
        Query("SELECT sub.ID, gl.GradeLevel, sub.SubjectCode, sub.SubjectName, sub.Units
                FROM subject sub
                JOIN gradelevel gl ON sub.GradeLevel_ID = gl.ID
                ORDER BY gl.GradeLevel")
        DgvSubject.DataSource = ds.Tables("QueryTb")
        DgvSubject.AutoGenerateColumns = False

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
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub BtnSaveSubject_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not IsEmptyField(CmbGradeLevel.Text.Trim()) Then
            Info("Please select a grade level.")
            Return
        End If

        If Not IsEmptyField(txtSubjCode.Text.Trim()) Then
            Info("Please enter a subject code.")
            Return
        End If
        If Not IsEmptyField(txtSubjName.Text.Trim()) Then
            Info("Please enter a subject name.")
            Return
        End If
        If Not IsEmptyField(txtUnit.Text.Trim()) Then
            Info("Please enter the unit for the subject.")
            Return
        End If

        If Not NoLeadingSpace(txtSubjName.Text.Trim()) Then
            Info("Subject name must have no multiple spaces between letters.")
            Return
        ElseIf Not NoLeadingSpace(txtSubjCode.Text.Trim()) Then
            Info("Subject code must have no multiple spaces between letters.")
            Return
        End If
        ClassSubject.SubjectRef()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ClassSubject.DeleteRef()
        Clear()
    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubjName.KeyPress
        If Not IsValidInput(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnit.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
End Class