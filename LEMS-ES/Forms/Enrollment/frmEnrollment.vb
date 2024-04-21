Public Class frmEnrollment
    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT e.ID, e.SchoolYear, e.LRN, CONCAT(st.Lastname, ' ',st.Firstname, ' ',st.MiddleInitial) as Fullname, s.SectionRoom as Section, gl.GradeLevel, e.Enrollment_Date, e.Status 
                FROM enrollment e 
                JOIN student st ON e.LRN = st.LRN
                JOIN section s ON e.SectionID = s.ID
                JOIN gradelevel gl ON e.GradeLevel_ID = gl.ID
                ")
        dgvEnrolled.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmEnrollmentRegistration.Show()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText <> String.Empty Then
            Dim dataTable As DataTable = CType(dgvEnrolled.DataSource, DataTable)
            Dim filteredData As New DataTable()

            ' Clone the structure of the original DataTable
            filteredData = dataTable.Clone()

            ' Filter the rows based on the search text
            For Each row As DataRow In dataTable.Rows
                For Each col As DataColumn In dataTable.Columns
                    If row(col.ColumnName).ToString().Contains(searchText) Then
                        filteredData.ImportRow(row)
                        Exit For ' Break out of the inner loop once a match is found
                    End If
                Next
            Next

            dgvEnrolled.DataSource = filteredData
        Else
            ' If search text is empty, reload original data
            loadrecords()
        End If
    End Sub

    Private Sub DgvEnrolled_DoubleClick(sender As Object, e As EventArgs) Handles dgvEnrolled.DoubleClick
        If dgvEnrolled.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvEnrolled.SelectedRows(0)
            Dim enrollID As Integer = Convert.ToInt32(selectedRow.Cells("colID").Value)

            Dim studLRN As String = selectedRow.Cells("colLRN").Value.ToString()
            Dim studFullname As String = selectedRow.Cells("colFullname").Value.ToString()
            'Dim nameParts() As String = studFullname.Split(" "c)

            'If nameParts.Length >= 1 Then
            '    frmStudentsView.txtStudLname.Text = nameParts(0) ' Lastname
            'End If
            'If nameParts.Length >= 2 Then
            '    frmStudentsView.txtStudFname.Text = nameParts(1) ' Firstname
            'End If
            'If nameParts.Length >= 3 Then
            '    frmStudentsView.txtStudMname.Text = nameParts(2) ' Middle Initial
            'End If

            Dim studSection As String = selectedRow.Cells("colSection").Value.ToString()
            Dim studGradelevel As String = selectedRow.Cells("colGradeLevel").Value.ToString()

            frmEnrollmentRegistration.EnrollmentID = enrollID
            frmEnrollmentRegistration.txtStudLRN.Text = studLRN
            frmEnrollmentRegistration.txtStudName.Text = studFullname
            frmEnrollmentRegistration.cmbSection.ValueMember = studSection
            frmEnrollmentRegistration.cmbGradeLevel.ValueMember = studGradelevel

            frmEnrollmentRegistration.Show()
        End If
    End Sub
End Class