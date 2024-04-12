Public Class frmSections
    Public idSection As Integer = 0
    Private Sub frmSections_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
        clear()
    End Sub
    Public Sub loadrecords()
        Query("SELECT  sec.ID, gl.GradeLevel, sec.SectionRoom, sec.Capacity, CONCAT(t.Lastname, ' ', t.Firstname, ' ', MiddleInitial) as Adviser
                FROM section sec
                JOIN gradelevel gl ON sec.GradeLevel_ID = gl.ID
                JOIN teacher t ON sec.Adviser_ID = t.ID")
        dgvSection.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM gradelevel")
        cmbGradeLevel.DataSource = ds.Tables("QueryTb")
        cmbGradeLevel.ValueMember = "ID"
        cmbGradeLevel.DisplayMember = "GradeLevel"

        Query("SELECT ID, EmpID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) as Adviser FROM teacher")
        cmbAdviser.DataSource = ds.Tables("QueryTb")
        cmbAdviser.ValueMember = "ID"
        cmbAdviser.DisplayMember = "Adviser"
    End Sub
    Public Sub clear()
        idSection = 0
        cmbGradeLevel.Text = ""
        txtSectionName.Clear()
        txtSectionCapacity.Clear()
        cmbAdviser.Text = ""
    End Sub
    Private Sub dgvSection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSection.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvSection.Rows(e.RowIndex)
                idSection = row.Cells(0).Value
                cmbGradeLevel.Text = row.Cells(1).Value
                txtSectionName.Text = row.Cells(2).Value
                txtSectionCapacity.Text = row.Cells(3).Value
                cmbAdviser.Text = row.Cells(4).Value
            ElseIf e.ColumnIndex >= 0 Then
                clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub btnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click
        If IS_EMPTY(cmbGradeLevel) = True Then Return
        If IS_EMPTY(txtSectionName) = True Then Return
        If IS_EMPTY(txtSectionCapacity) = True Then Return

        ClassSection.SectionRef()
        clear()
    End Sub

    Private Sub txtSectionCapacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSectionCapacity.KeyPress
        TextBoxDigitsOnly(txtSectionCapacity)
    End Sub

    Private Sub txtSectionName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSectionName.KeyPress
        TextBoxOnlyLetters(txtSectionName)
    End Sub
End Class