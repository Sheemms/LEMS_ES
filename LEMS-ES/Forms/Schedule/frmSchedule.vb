Public Class frmSchedule
    Public idSched As Integer = 0
    Private Sub frmSchedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadRecords()
        LoadDepartment()
        LoadSubjectAutoComplet()
        LoadTeacher()
        LoadTeacherAutoComplete()
        GetSchoolYear(lblSY)
    End Sub
    Public Sub LoadRecords()
        Query("SELECT sc.ID, sc.SY_Code, sec.ID, sc.Room, t.ID, sub.ID, sc.Days, sc.Time_From, sc.Time_To, t.ID 
               FROM schedule sc
               JOIN section sec ON sc.Sec_ID = sec.ID
               JOIN teacher t ON sc.Adviser_ID = t.ID
               JOIN subject sub ON sc.Subj_ID = sub.ID")
    End Sub
    Public Sub LoadDepartment()
        Query("SELECT * FROM department")
        cmbDepartment.DataSource = ds.Tables("QueryTb")
        cmbDepartment.ValueMember = "ID"
        cmbDepartment.DisplayMember = "Department"
    End Sub
    Public Sub LoadTeacher()
        Query("SELECT ID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName FROM teacher")
        cmbAdviser.DataSource = ds.Tables("QueryTb")
        cmbAdviser.ValueMember = "ID"
        cmbAdviser.DisplayMember = "FullName"
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        Dim selectedDepartmentID As Integer
        If cmbDepartment.SelectedItem IsNot Nothing AndAlso TypeOf cmbDepartment.SelectedItem Is DataRowView Then
            selectedDepartmentID = Convert.ToInt32(DirectCast(cmbDepartment.SelectedItem, DataRowView).Row("ID"))
        Else
            ' Handle the case where the selected item is not valid
            MessageBox.Show("Please select a valid department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Execute the query to retrieve grade levels based on the selected department ID
        Dim qry As String = $"SELECT ID, GradeLevel FROM gradelevel WHERE Department_ID = {selectedDepartmentID}"
        Query(qry)

        ' Populate cmbGradeLevel with the retrieved data
        Dim gradeLevelTable As DataTable = ds.Tables("QueryTb")
        If gradeLevelTable.Rows.Count > 0 Then
            ' If grade levels are found, populate cmbGradeLevel
            cmbGradeLevel.DataSource = gradeLevelTable
            cmbGradeLevel.ValueMember = "ID" ' Assuming "ID" is the column name for the value
            cmbGradeLevel.DisplayMember = "GradeLevel" ' Assuming "GradeLevel" is the column name for the display text
        Else
            ' If no grade levels found, clear cmbGradeLevel
            cmbGradeLevel.DataSource = Nothing
            cmbGradeLevel.Items.Clear()
        End If
    End Sub

    Private Sub cmbGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGradeLevel.SelectedIndexChanged
        Dim selectedGradeLevelID As Integer
        If cmbGradeLevel.SelectedItem IsNot Nothing AndAlso TypeOf cmbGradeLevel.SelectedItem Is DataRowView Then
            selectedGradeLevelID = Convert.ToInt32(DirectCast(cmbGradeLevel.SelectedItem, DataRowView).Row("ID"))
        Else
            MessageBox.Show("Please select a valid grade level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim qry As String = $"SELECT ID, SectionRoom FROM section WHERE GradeLevel_ID = {selectedGradeLevelID}"
        Query(qry)

        Dim sectionTable As DataTable = ds.Tables("QueryTb")
        If sectionTable.Rows.Count > 0 Then
            ' If grade levels are found, populate cmbGradeLevel
            cmbSection.DataSource = sectionTable
            cmbSection.ValueMember = "ID" ' Assuming "ID" is the column name for the value
            cmbSection.DisplayMember = "SectionRoom" ' Assuming "GradeLevel" is the column name for the display text
        Else
            ' If no grade levels found, clear cmbGradeLevel
            cmbSection.DataSource = Nothing
            cmbSection.Items.Clear()
        End If
    End Sub

#Region "Auto Complete/ Populate"
    Private Sub LoadSubjectAutoComplet()
        Query("SELECT ID, GradeLevel_ID, SubjectCode, SubjectName, Units FROM subject")
        Dim autoCompleteCollection As New AutoCompleteStringCollection()

        For Each row As DataRow In ds.Tables("QueryTb").Rows
            autoCompleteCollection.Add(row("SubjectCOde").ToString())
        Next

        txtSubjCode.AutoCompleteCustomSource = autoCompleteCollection
        txtSubjCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtSubjCode.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
    Private Sub txtSubjCode_TextChanged(sender As Object, e As EventArgs) Handles txtSubjCode.TextChanged
        Dim selectedSubjName As String = txtSubjCode.Text.Trim()

        Query("SELECT ID, GradeLevel_ID, SubjectCode, SubjectName, Units FROM subject")
        Dim row As DataRow = ds.Tables("QueryTb").Select($"SubjectCode = '{selectedSubjName}'").FirstOrDefault()

        If row IsNot Nothing AndAlso row.Table.Columns.Contains("SubjectName") Then
            txtSubjName.Text = row("SubjectName").ToString()
        Else
            txtSubjName.Clear()
        End If
    End Sub
    Private Sub LoadTeacherAutoComplete()
        Query("SELECT ID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName, EmpID FROM teacher")
        Dim autoCompleteCollection As New AutoCompleteStringCollection()

        For Each row As DataRow In ds.Tables("QueryTb").Rows
            autoCompleteCollection.Add(row("FullName").ToString())
        Next

        txtTeacherName.AutoCompleteCustomSource = autoCompleteCollection
        txtTeacherName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtTeacherName.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Private Sub txtTeacherName_TextChanged(sender As Object, e As EventArgs) Handles txtTeacherName.TextChanged
        Dim selectedTeacherName As String = txtTeacherName.Text.Trim()

        Query("SELECT ID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName, EmpID FROM teacher")
        Dim row As DataRow = ds.Tables("QueryTb").Select($"FullName = '{selectedTeacherName}'").FirstOrDefault()

        If row IsNot Nothing AndAlso row.Table.Columns.Contains("EmpID") Then
            txtTeacherID.Text = row("EmpID").ToString()
        Else
            txtTeacherID.Clear()
        End If
    End Sub

#End Region

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class
