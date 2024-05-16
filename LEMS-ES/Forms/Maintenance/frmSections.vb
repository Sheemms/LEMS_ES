Public Class FrmSections
    Public idSection As Integer = 0
    Private Sub FrmSections_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
        Clear()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT  a.ID, b.GradeLevel, a.SectionRoom, CONCAT(c.Lastname, ' ', c.Firstname, ' ', c.MiddleInitial) as Adviser, a.Capacity, a.CurCapacity
            FROM section a
            JOIN gradelevel b ON a.GradeLevel_ID = b.ID
            JOIN teacher c ON a.AdviserID = c.ID")
        dgvSection.DataSource = ds.Tables("QueryTb")
        dgvSection.AutoGenerateColumns = False

        For Each row As DataGridViewRow In dgvSection.Rows
            Dim sectionID As Integer = Convert.ToInt32(row.Cells("Column1").Value)
            Dim currentCapacity As Integer = GetCurrentCapacity(sectionID)
            Debug.WriteLine($"SectionID: {sectionID}, Current Capacity: {currentCapacity}")
            row.Cells(5).Value = currentCapacity
        Next

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
        TxtCapacity.Clear()
        CmbAdviser.SelectedIndex = -1
        idSection = 0
    End Sub
    Private Sub DgvSection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSection.CellClick
        Try
            If e.RowIndex >= 0 AndAlso dgvSection.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvSection.SelectedRows(0)
                idSection = selectedRow.Cells(0).Value
                CmbGradeLevel.Text = selectedRow.Cells(1).Value
                TxtSectionName.Text = selectedRow.Cells(2).Value
                CmbAdviser.Text = selectedRow.Cells(3).Value
                TxtCapacity.Text = selectedRow.Cells(4).Value
            ElseIf e.ColumnIndex >= 0 Then
                Clear()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub BtnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click
        If Not IsEmptyField(CmbGradeLevel.Text.Trim()) Then
            Info("Please select a grade level.")
            Return
        End If

        If Not IsEmptyField(TxtSectionName.Text.Trim()) Then
            Info("Please enter a section name.")
            Return
        End If
        If Not IsEmptyField(CmbAdviser.Text.Trim()) Then
            Info("Please select a adviser name.")
            Return
        End If
        If Not IsEmptyField(TxtCapacity.Text.Trim()) Then
            Info("Please enter a capacity.")
            Return
        End If

        If Not NoLeadingSpace(TxtSectionName.Text.Trim()) Then
            Info("Section must have no multiple spaces between letters.")
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
    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCapacity.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
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