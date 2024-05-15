Imports MySql.Data.MySqlClient

Public Class FrmEnrollmentRegistration
    Public EnrollmentID As Integer = 0
    Public EnrollSubjID As Integer = 0
    Public Ave As String
    Public Rmrks As String
    Public _subjectno, _title, _unit, _pre As String
    Public _id, _sub As String
    Private Sub FrmEnrollmentRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        GetSchoolYear(lblSY)
        LoadDepartment()
        LoadSection()
        LoadStudent()
        Clear()
    End Sub
    Public Sub Clear()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {txtStudLRN}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        CmbStudName.SelectedIndex = -1
        CmbSection.SelectedIndex = -1
        CmbDepartment.SelectedIndex = -1
        CmbGradeLevel.SelectedIndex = -1
        EnrollmentID = 0
        EnrollSubjID = 0
        scheduleID = 0
        idStud = 0
    End Sub
    Public Sub LoadStudentData()
        Query("SELECT ID, LRN, CONCAT(Lastname, ' ', Firstname) Fullname 
                FROM student
                WHERE ID = '" & idStud & "'")

        If ds.Tables("QueryTb").Rows.Count > 0 Then
            With ds.Tables("QueryTb").Rows(0)
                CmbStudName.Text = .Item(2)
                txtStudLRN.Text = .Item(1)
            End With
        Else
            Clear()
        End If
    End Sub
    Public Sub LoadSub()
        Query($"SELECT  a.ID, CONCAT(b.Start_Year, '-',b.End_Year) SY, g.SubjectCode, g.SubjectName, 
		CONCAT(TIME_FORMAT(Time_From, '%H:%i'), '-', TIME_FORMAT(Time_To, '%H:%i')) Time, 
        a.Days, CONCAT(h.Lastname, ' ',h.Firstname) Teacher
                                FROM schedule a
                                JOIN schoolyear b ON a.SYID = b.ID
                                JOIN section c ON a.SectionID = c.ID
                                JOIN gradelevel d ON c.GradeLevel_ID = d.ID
								JOIN department e ON d.Department_ID = e.ID
                                JOIN room f ON a.Room = f.ID
								JOIN subject g ON a.SubjectID = g.ID
								JOIN teacher h ON a.TeacherID = h.ID
								JOIN teacher i on c.AdviserID = i.ID
                                WHERE c.ID = '{CmbSection.SelectedValue}'")
        DgvStudSubject.DataSource = ds.Tables("QueryTb")
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
    Public Sub LoadDepartment()
        Query("SELECT * FROM department")
        CmbDepartment.DataSource = ds.Tables("QueryTb")
        CmbDepartment.ValueMember = "ID"
        CmbDepartment.DisplayMember = "Department"
    End Sub
    Public Sub LoadSection()
        Query("SELECT * FROM section")
        CmbSection.DataSource = ds.Tables("QueryTb")
        CmbSection.ValueMember = "ID"
        CmbSection.DisplayMember = "SectionRoom"
    End Sub
    Public scheduleID As Integer = 0
    Public Sub LoadStudent()
        Query("SELECT *, CONCAT(Lastname, ' ', Firstname) Fullname FROM student")
        CmbStudName.DataSource = ds.Tables("QueryTb")
        CmbStudName.ValueMember = "ID"
        CmbStudName.DisplayMember = "Fullname"
    End Sub

    Private Sub BtnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        If Not IsEmptyField(CmbDepartment.Text.Trim()) Then
            Info("Please select a department.")
            Return
        End If
        If Not IsEmptyField(CmbSection.Text.Trim()) Then
            Info("Please select a section.")
            Return
        End If
        If Not IsEmptyField(CmbGradeLevel.Text.Trim()) Then
            Info("Please select a grade level.")
            Return
        End If
        If Not IsEmptyField(txtStudLRN.Text.Trim()) Then
            Info("Please enter a subject code.")
            Return
        End If
        If Not IsEmptyField(CmbStudName.Text.Trim()) Then
            Info("Please select a subject name.")
            Return
        End If

        ClassEnroll.EnrollmentRef()
    End Sub
    Public idStud As Integer = Nothing
    Private Sub CmbStudName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStudName.SelectedIndexChanged
        Dim selectedStudent As Integer
        If CmbStudName.SelectedItem IsNot Nothing AndAlso TypeOf CmbStudName.SelectedItem Is DataRowView Then
            selectedStudent = Convert.ToInt32(DirectCast(CmbStudName.SelectedItem, DataRowView).Row("ID"))

            Dim qry As String = $"SELECT ID, LRN, CONCAT(Lastname, ' ', Firstname) Fullname FROM student WHERE ID = {selectedStudent}"
            Query(qry)

            If ds.Tables("QueryTb").Rows.Count > 0 Then
                txtStudLRN.Text = ds.Tables("QueryTb").Rows(0)("LRN").ToString()
                CmbStudName.Text = ds.Tables("QueryTb").Rows(0)("Fullname").ToString()
                idStud = ds.Tables("QueryTb").Rows(0)("ID").ToString()
            Else
                txtStudLRN.Clear()
            End If
        End If
    End Sub

    Private Sub CmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDepartment.SelectedIndexChanged
        Dim selectedDepartmentID As Integer
        If CmbDepartment.SelectedItem IsNot Nothing AndAlso TypeOf CmbDepartment.SelectedItem Is DataRowView Then
            selectedDepartmentID = Convert.ToInt32(DirectCast(CmbDepartment.SelectedItem, DataRowView).Row("ID"))

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
    'Private Sub CmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSection.SelectedIndexChanged
    '    Dim selectedSection As Integer
    '    If CmbSection.SelectedItem IsNot Nothing AndAlso TypeOf CmbSection.SelectedItem Is DataRowView Then
    '        selectedSection = Convert.ToInt32(DirectCast(CmbSection.SelectedItem, DataRowView).Row("ID"))
    '    Else
    '        'MessageBox.Show("Please select a valid section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return
    '    End If

    '    Query("SELECT a.ID, b.GradeLevel, c.Department, a.SectionRoom, CONCAT(d.Lastname, ' ', d.Firstname) AS Adviser
    '                FROM section a
    '                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
    '                JOIN department c ON b.Department_ID = c.ID
    '                JOIN teacher d ON a.AdviserID = d.ID
    '                WHERE a.ID =" & selectedSection)

    '    Dim Dtable As DataTable = ds.Tables("QueryTb")
    '    If Dtable.Rows.Count > 0 Then
    '        ' Populate TextBoxes with the retrieved data
    '        'Guna2TextBox2.Text = Dtable.Rows(0)("GradeLevel").ToString()
    '        'Guna2TextBox1.Text = Dtable.Rows(0)("Department").ToString()
    '    Else
    '        Clear()
    '    End If
    'End Sub



#Region "AutoComplete/Populate"

    Private Sub PbSearch_Click(sender As Object, e As EventArgs) Handles PbSearch.Click
        'Dim selectedStudName As String = txtSearch.Text.Trim()

        'If Not String.IsNullOrEmpty(selectedStudName) Then
        '    Query($"SELECT ID, StudType, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName FROM student WHERE LRN = '{selectedStudName}' OR Lastname LIKE '%{selectedStudName}%' OR Firstname LIKE '%{selectedStudName}%'")

        '    If ds.Tables("QueryTb").Rows.Count > 0 Then
        '        Dim row As DataRow = ds.Tables("QueryTb").Rows(0)
        '        txtStudLRN.Text = row("LRN").ToString()
        '        txtStudName.Text = row("FullName").ToString()
        '    Else
        '        Clear()
        '    End If
        'Else
        '    Clear()
        'End If
        SearchStudent.Show()
    End Sub

    Private Sub CmbSection_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbSection.SelectedValueChanged
        LoadSub()
    End Sub
#End Region

#Region "btnwithSelectionofSubject"
    'Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
    '    If DgvSubjectList IsNot Nothing AndAlso DgvSubjectList.SelectedRows.Count > 0 Then
    '        scheduleID = Convert.ToInt32(DgvSubjectList.SelectedRows(0).Cells(0).Value)
    '        ClassEnroll.EnrollSubjRef()
    '    End If
    'End Sub

    'Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
    '    If DgvEnrolledSubjects IsNot Nothing AndAlso DgvEnrolledSubjects.SelectedRows.Count > 0 Then
    '        EnrollSubjID = Convert.ToInt32(DgvEnrolledSubjects.SelectedRows(0).Cells(0).Value)
    '        MsgBox(EnrollSubjID)
    '        ClassEnroll.RemoveSubjRef()
    '    End If
    'End Sub
#End Region
End Class
