Imports MySql.Data.MySqlClient

Public Class FrmEnrollmentRegistration
    Public EnrollmentID As Integer = 0
    Public EnrollSubjID As Integer = 0
    Public scheduleID As Integer = 0
    Public _subjectno, _title, _unit, _pre As String
    Public _id, _sub As String
    Private Sub FrmEnrollmentRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        GetSchoolYear(lblSY)
        LoadStudAutoComplet()
        LoadDeprtment()
        ClearFields(Me, EnrollmentID)
        'LoadSub()
    End Sub
    Public Sub LoadStudentData()
        'Query("SELECT * FROM enrollment WHERE LRN = '" & txtStudLRN.Text & "'")

        'If ds.Tables("QueryTb").Rows.Count > 0 Then
        '    With ds.Tables("QueryTb").Rows(0)
        '        LabelEID.Text = .Item(1)
        '        lblSY.Text = .Item(2)
        '        txtStudLRN.Text = .Item(3)
        '        CmbSection.SelectedValue = .Item(4)
        '        CmbGradeLevel.SelectedValue = .Item(5)
        '    End With
        'Else
        '    ClearFields(Me, EnrollmentID)
        'End If
    End Sub
    Public Sub LoadSub()
        Query($"SELECT  a.ID, d.SubjectCode, d.SubjectName, CONCAT(TIME_FORMAT(Time_From, '%H:%i'), '-', TIME_FORMAT(Time_To, '%H:%i')) Time, a.Days, CONCAT(e.Lastname, ' ',e.Firstname) Teacher
                                FROM schedule a
                                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                                JOIN section c ON a.Sec_ID = c.ID
                                JOIN subject d ON a.Subj_ID = d.ID
                                JOIN teacher e ON a.Teacher_ID = e.ID
                                WHERE a.GradeLevel_ID LIKE '{CmbGradeLevel.SelectedValue}'")
        DgvSubjectList.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub LoadSubjectEnrolled()
        Query("SELECT a.ID, CONCAT(b.Start_Year, '-', b.End_Year)SYID, a.EID, d.SubjectCode ,d.SubjectName, 
                    CONCAT(TIME_FORMAT(c.Time_From, '%H:%i'), '-', TIME_FORMAT(c.Time_To, '%H:%i')) Time, c.Days, 
                    CONCAT(e.Lastname, ', ', e.Firstname, ' ',e.MiddleInitial) Teacher
                    FROM enrolled_sched a
                    JOIN schoolyear b ON a.SYID = b.ID
                    JOIN schedule c ON a.ScheduleID = c.ID
                    JOIN subject d ON c.Subj_ID = d.ID
                    JOIN teacher e ON c.Teacher_ID = e.ID
                    WHERE a.EID =  '" & LabelEID.Text & "'")
        DgvEnrolledSubjects.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub LoadDeprtment()
        Query("SELECT * FROM department")
        CmbDepartment.DataSource = ds.Tables("QueryTb")
        CmbDepartment.ValueMember = "ID"
        CmbDepartment.DisplayMember = "Department"
    End Sub
    Public Sub LoadMode()
        Query("SELECT * FROM mop")
    End Sub
    Private Sub BtnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        ClassEnroll.EnrollmentRef()
        ClearFields(Me, EnrollmentID)
    End Sub

#Region "AutoComplete/Populate"
    Private Sub LoadStudAutoComplet()
        Query("SELECT ID, StudType, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName FROM student")
        Dim autoCompleteCollection As New AutoCompleteStringCollection()

        For Each row As DataRow In ds.Tables("QueryTb").Rows
            autoCompleteCollection.Add(row("LRN").ToString())
            autoCompleteCollection.Add(row("FullName").ToString())
        Next

        txtSearch.AutoCompleteCustomSource = autoCompleteCollection
        txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim selectedStudName As String = txtSearch.Text.Trim()

        Query("SELECT ID, StudType, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName FROM student")
        Dim row As DataRow = ds.Tables("QueryTb").Select($"FullName = '{selectedStudName}'").FirstOrDefault()

        If row IsNot Nothing AndAlso row.Table.Columns.Contains("LRN") Then
            txtStudLRN.Text = row("LRN").ToString()
            txtStudName.Text = row("FullName").ToString()
        Else
            txtStudLRN.Clear()
            txtStudName.Clear()
        End If
    End Sub

    Private Sub CmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDepartment.SelectedIndexChanged
        Dim selectedDepartmentID As Integer
        If CmbDepartment.SelectedItem IsNot Nothing AndAlso TypeOf CmbDepartment.SelectedItem Is DataRowView Then
            selectedDepartmentID = Convert.ToInt32(DirectCast(CmbDepartment.SelectedItem, DataRowView).Row("ID"))
        Else
            MessageBox.Show("Please select a valid department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim qry As String = $"SELECT ID, GradeLevel FROM gradelevel WHERE Department_ID = {selectedDepartmentID}"
        Query(qry)

        Dim gradeLevelTable As DataTable = ds.Tables("QueryTb")
        If gradeLevelTable.Rows.Count > 0 Then
            CmbGradeLevel.DataSource = gradeLevelTable
            CmbGradeLevel.ValueMember = "ID"
            CmbGradeLevel.DisplayMember = "GradeLevel"
        Else
            CmbGradeLevel.DataSource = Nothing
            CmbGradeLevel.Items.Clear()
            CmbGradeLevel.SelectedIndex = -1
        End If
    End Sub
    Private Sub CmbGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGradeLevel.SelectedIndexChanged
        Dim selectedGradeLevelID As Integer
        If CmbGradeLevel.SelectedItem IsNot Nothing AndAlso TypeOf CmbGradeLevel.SelectedItem Is DataRowView Then
            selectedGradeLevelID = Convert.ToInt32(DirectCast(CmbGradeLevel.SelectedItem, DataRowView).Row("ID"))
        Else
            MessageBox.Show("Please select a valid grade level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim qry As String = $"SELECT ID, SectionRoom FROM section WHERE GradeLevel_ID = {selectedGradeLevelID}"
        Query(qry)

        Dim sectionTable As DataTable = ds.Tables("QueryTb")
        If sectionTable.Rows.Count > 0 Then
            CmbSection.DataSource = sectionTable
            CmbSection.ValueMember = "ID"
            CmbSection.DisplayMember = "SectionRoom"
        Else
            CmbSection.DataSource = Nothing
            CmbSection.Items.Clear()
            CmbSection.SelectedIndex = -1
        End If
    End Sub

    Private Sub CmbGradeLevel_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbGradeLevel.SelectedValueChanged
        LoadSub()
    End Sub
#End Region
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If DgvSubjectList IsNot Nothing AndAlso DgvSubjectList.SelectedRows.Count > 0 Then
            scheduleID = Convert.ToInt32(DgvSubjectList.SelectedRows(0).Cells(0).Value)
            ClassEnroll.EnrollSubjRef()
        End If
        ClearFields(Me, scheduleID)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If DgvEnrolledSubjects IsNot Nothing AndAlso DgvEnrolledSubjects.SelectedRows.Count > 0 Then
            EnrollSubjID = Convert.ToInt32(DgvEnrolledSubjects.SelectedRows(0).Cells(0).Value)
            MsgBox(EnrollSubjID)
            ClassEnroll.RemoveSubjRef()
            ClearFields(Me, EnrollSubjID)
        End If
    End Sub
End Class
