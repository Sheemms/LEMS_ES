Public Class frmEnrollment
    Private Sub FrmEnrollment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT e.ID, e.SchoolYear, e.EID, e.LRN, CONCAT(st.Lastname, ' ',st.Firstname, ' ',st.MiddleInitial) as Fullname, s.SectionRoom as Section, gl.GradeLevel, e.Enrollment_Date, e.Status 
                FROM enrollment e 
                JOIN student st ON e.LRN = st.LRN
                JOIN section s ON e.SectionID = s.ID
                JOIN gradelevel gl ON e.GradeLevel_ID = gl.ID")
        dgvEnrolled.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmEnrollmentRegistration.Show()
        FrmEnrollmentRegistration.LabelEID.Text = EIDGenerate()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText <> String.Empty Then
            Dim dataTable As DataTable = CType(dgvEnrolled.DataSource, DataTable)
            Dim filteredData As New DataTable()

            filteredData = dataTable.Clone()

            For Each row As DataRow In dataTable.Rows
                For Each col As DataColumn In dataTable.Columns
                    If row(col.ColumnName).ToString().Contains(searchText) Then
                        filteredData.ImportRow(row)
                        Exit For 
                    End If
                Next
            Next

            dgvEnrolled.DataSource = filteredData
        Else
            loadrecords()
        End If
    End Sub

    Private Sub DgvEnrolled_DoubleClick(sender As Object, e As EventArgs) Handles dgvEnrolled.DoubleClick
        If dgvEnrolled.SelectedRows.Count > 0 Then
            With dgvEnrolled.SelectedRows(0)
                FrmEnrollmentRegistration.EnrollmentID = .Cells(0).Value
                FrmEnrollmentRegistration.lblSY.Text = .Cells(1).Value
                FrmEnrollmentRegistration.LabelEID.Text = .Cells(2).Value
                FrmEnrollmentRegistration.txtStudLRN.Text = .Cells(3).Value
                FrmEnrollmentRegistration.txtStudName.Text = .Cells(4).Value
                FrmEnrollmentRegistration.CmbGradeLevel.SelectedValue = .Cells(5).Value
                FrmEnrollmentRegistration.CmbSection.SelectedValue = .Cells(6).Value
            End With
            FrmEnrollmentRegistration.LoadSubjectEnrolled()
            FrmEnrollmentRegistration.Show()
        End If
        'If dgvEnrolled.SelectedRows.Count > 0 Then
        '    Dim selectedRow As DataGridViewRow = dgvEnrolled.SelectedRows(0)
        '    Dim enrollID As Integer = Convert.ToInt32(selectedRow.Cells("colID").Value)
        '    Dim EID As String = selectedRow.Cells("Column1").Value.ToString

        '    Dim studLRN As String = selectedRow.Cells("colLRN").Value.ToString()
        '    Dim studFullname As String = selectedRow.Cells("colFullname").Value.ToString()
        '    'Dim nameParts() As String = studFullname.Split(" "c)

        '    'If nameParts.Length >= 1 Then
        '    '    frmStudentsView.txtStudLname.Text = nameParts(0) ' Lastname
        '    'End If
        '    'If nameParts.Length >= 2 Then
        '    '    frmStudentsView.txtStudFname.Text = nameParts(1) ' Firstname
        '    'End If
        '    'If nameParts.Length >= 3 Then
        '    '    frmStudentsView.txtStudMname.Text = nameParts(2) ' Middle Initial
        '    'End If

        '    Dim studSection As String = selectedRow.Cells("colSection").Value.ToString()
        '    Dim studGradelevel As String = selectedRow.Cells("colGradeLevel").Value.ToString()

        '    FrmEnrollmentRegistration.EnrollmentID = enrollID
        '    FrmEnrollmentRegistration.LabelEID.Text = EID
        '    FrmEnrollmentRegistration.txtStudLRN.Text = studLRN
        '    FrmEnrollmentRegistration.txtStudName.Text = studFullname
        '    FrmEnrollmentRegistration.CmbSection.ValueMember = studSection
        '    FrmEnrollmentRegistration.CmbGradeLevel.ValueMember = studGradelevel

        '    FrmEnrollmentRegistration.Show()
        'End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Query($"SELECT e.ID, e.SchoolYear, e.LRN, CONCAT(st.Lastname, ' ',st.Firstname, ' ',st.MiddleInitial) as Fullname, s.SectionRoom as Section, gl.GradeLevel, e.Enrollment_Date, e.Status 
                FROM enrollment e 
                JOIN student st ON e.LRN = st.LRN
                JOIN section s ON e.SectionID = s.ID
                JOIN gradelevel gl ON e.GradeLevel_ID = gl.ID
                WHERE st.LRN LIKE '{txtSearch.Text}' OR st.Lastname LIKE '{txtSearch.Text}' OR st.Firstname LIKE '{txtSearch.Text}' ")
        dgvEnrolled.DataSource = ds.Tables("QueryTb")
    End Sub

End Class