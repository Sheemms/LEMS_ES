Public Class FrmSections
    Public idSection As Integer = 0
    Private Sub FrmSections_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
        ClearFields(Me, idSection)
    End Sub
    Public Sub Loadrecords()
        Query("SELECT  a.ID, b.GradeLevel, a.SectionRoom
                FROM section a
                JOIN gradelevel b ON a.GradeLevel_ID = b.ID")
        dgvSection.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM gradelevel")
        CmbGradeLevel.DataSource = ds.Tables("QueryTb")
        CmbGradeLevel.ValueMember = "ID"
        CmbGradeLevel.DisplayMember = "GradeLevel"

        'Query("SELECT ID, EmpID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) as Adviser FROM teacher")
        'cmbAdviser.DataSource = ds.Tables("QueryTb")
        'cmbAdviser.ValueMember = "ID"
        'cmbAdviser.DisplayMember = "Adviser"
    End Sub
    Private Sub DgvSection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSection.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvSection.Rows(e.RowIndex)
                idSection = row.Cells(0).Value
                CmbGradeLevel.Text = row.Cells(1).Value
                TxtSectionName.Text = row.Cells(2).Value
            ElseIf e.ColumnIndex >= 0 Then
                ClearFields(Me, idSection)
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub BtnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click
        If IS_EMPTY(CmbGradeLevel) = True Then Return
        If IS_EMPTY(TxtSectionName) = True Then Return

        ClassSection.SectionRef()
        ClearFields(Me, idSection)
    End Sub

    Private Sub TxtSectionName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSectionName.KeyPress
        TextBoxOnlyLetters(TxtSectionName)
    End Sub
End Class