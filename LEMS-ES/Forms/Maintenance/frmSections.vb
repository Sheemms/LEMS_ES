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
        If Not IsEmptyField(CmbGradeLevel.Text.Trim()) Then
            MsgBox("Please select a grade level.")
            Return
        End If

        If Not IsEmptyField(TxtSectionName.Text.Trim()) Then
            MsgBox("Please enter a section name.")
            Return
        End If
        If Not IsEmptyField(CmbAdviser.Text.Trim()) Then
            MsgBox("Please select a Adviser name.")
            Return
        End If

        If Not NoLeadingSpace(TxtSectionName.Text.Trim()) Then
            MsgBox("Section must have no leading spaces.")
            Return
        End If
        ClassSection.SectionRef()
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSectionName.KeyPress
        If Not IsValidInput(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub CmbGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGradeLevel.SelectedIndexChanged
        Dim selectedGradeLevelID As Integer
        If CmbGradeLevel.SelectedItem IsNot Nothing AndAlso TypeOf CmbGradeLevel.SelectedItem Is DataRowView Then
            selectedGradeLevelID = Convert.ToInt32(DirectCast(CmbGradeLevel.SelectedItem, DataRowView).Row("ID"))
        Else
            'MessageBox.Show("Please select a valid grade level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim qry As String = $"SELECT a.ID, a.EmpID, CONCAT(a.Lastname, ' ', a.Firstname, ' ', a.MiddleInitial) AS Adviser 
        FROM teacher a
        JOIN department b ON a.Department_ID = b.ID
        JOIN gradelevel c ON b.ID = c.Department_ID
        WHERE c.ID = {selectedGradeLevelID}"
        Query(qry)

        Dim adviserTable As DataTable = ds.Tables("QueryTb")
        If adviserTable.Rows.Count > 0 Then
            CmbAdviser.DataSource = adviserTable
            CmbAdviser.ValueMember = "ID"
            CmbAdviser.DisplayMember = "Adviser"
        Else
            CmbAdviser.DataSource = Nothing
            CmbAdviser.Items.Clear()
            CmbAdviser.SelectedIndex = -1
        End If
    End Sub
End Class