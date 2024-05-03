Public Class FrmSections
    Public idSection As Integer = 0
    Private Sub FrmSections_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
        Clear()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT  a.ID, b.GradeLevel, a.SectionRoom, CONCAT(c.Lastname, ', ', c.Firstname, ' ', c.MiddleInitial) as Adviser
                FROM section a
                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                JOIN teacher c ON a.AdviserID = c.ID")
        dgvSection.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM gradelevel")
        CmbGradeLevel.DataSource = ds.Tables("QueryTb")
        CmbGradeLevel.ValueMember = "ID"
        CmbGradeLevel.DisplayMember = "GradeLevel"

        Query("SELECT ID, EmpID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) as Adviser FROM teacher")
        CmbAdviser.DataSource = ds.Tables("QueryTb")
        CmbAdviser.ValueMember = "ID"
        CmbAdviser.DisplayMember = "Adviser"
    End Sub
    Public Sub Clear()
        CmbGradeLevel.SelectedIndex = -1
        TxtSectionName.Clear()
        CmbAdviser.SelectedIndex = -1
        idSection = 0
    End Sub
    Private Sub DgvSection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSection.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvSection.Rows(e.RowIndex)
                idSection = row.Cells(0).Value
                CmbGradeLevel.Text = row.Cells(1).Value
                TxtSectionName.Text = row.Cells(2).Value
            ElseIf e.ColumnIndex >= 0 Then
                Clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub BtnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click, BtnUpdate.Click
        If IS_EMPTY(CmbGradeLevel) = True Then Return
        If IS_EMPTY(TxtSectionName) = True Then Return
        If IS_EMPTY(CmbAdviser) = True Then Return

        ClassSection.SectionRef()
        Clear()
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSectionName.KeyPress
        If Not IsValidInput(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

End Class