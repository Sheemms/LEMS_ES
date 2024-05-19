Imports MySql.Data.MySqlClient

Public Class FrmEnrollmentRegistration
    Public EnrollmentID As Integer = 0
    Public EnrollSubjID As Integer = 0
    Public Ave As String
    Public Rmrks As String
    Public _subjectno, _title, _unit, _pre As String
    Public _id, _sub As String
    Private Sub FrmEnrollmentRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Connection()
        GetSchoolYear(lblSY)
        LoadDepartment()
        LoadSection()
        LoadStudent()
        LoadEnrolledStudent()
        'Clear()
        'CmbStudName.SelectedValue = 2
        'MsgBox(enrolledStudent)
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
        Try
            Query("SELECT ID, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) Fullname 
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
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public enrolledStudent As Integer = 0
    Public Sub LoadEnrolledStudent()
        Try
            Query("SELECT e.ID,CONCAT(sy.Start_Year, '-', sy.End_Year) SchoolYear, e.EID, e.LRN, 
                CONCAT(st.Lastname, ' ',st.Firstname, ' ', st.MiddleInitial) as Fullname, 
                gl.GradeLevel, s.SectionRoom as Section, d.Department, e.Enrollment_Date, e.Status 
                FROM enrollment e 
                JOIN schoolyear sy ON e.SchoolYear = sy.ID
                JOIN student st ON e.LRN = st.LRN
                JOIN section s ON e.SectionID = s.ID
                JOIN gradelevel gl ON s.GradeLevel_ID = gl.ID
                JOIN department d ON gl.Department_ID = d.ID
                WHERE e.ID = '" & enrolledStudent & "'")

            If ds.Tables("QueryTb").Rows.Count > 0 Then
                With ds.Tables("QueryTb").Rows(0)
                    lblSY.Text = .Item(1)
                    LabelEID.Text = .Item(2)
                    txtStudLRN.Text = .Item(3)
                    CmbStudName.Text = .Item(4)
                    CmbGradeLevel.Text = .Item(5)
                    CmbSection.Text = .Item(6)
                    CmbDepartment.Text = .Item(7)
                End With
            Else
                Clear()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub LoadSub()
        Try
            Query($"SELECT  a.ID, CONCAT(b.Start_Year, '-',b.End_Year) SY, g.SubjectCode, g.SubjectName, 
		                        CONCAT(TIME_FORMAT(Time_From, '%H:%i'), '-', TIME_FORMAT(Time_To, '%H:%i')) Time, 
                                GROUP_CONCAT(
                                    CASE j.ID 
                                        WHEN SUBSTRING_INDEX(SUBSTRING_INDEX(a.Days, ',', n.n), ',', -1) THEN j.Days
                                    END
                                    ORDER BY n.n
                                    SEPARATOR ', '
                                ) AS Days, 
                                CONCAT(h.Lastname, ' ',h.Firstname) Teacher
                                FROM schedule a
                                JOIN schoolyear b ON a.SYID = b.ID
                                JOIN section c ON a.SectionID = c.ID
                                JOIN gradelevel d ON c.GradeLevel_ID = d.ID
								JOIN department e ON d.Department_ID = e.ID
                                JOIN room f ON a.Room = f.ID
								JOIN subject g ON a.SubjectID = g.ID
								JOIN teacher h ON a.TeacherID = h.ID
								JOIN teacher i on c.AdviserID = i.ID
                                JOIN days j ON FIND_IN_SET(j.ID, a.Days)
                                CROSS JOIN 
									(SELECT 1 AS n UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 UNION ALL SELECT 5) AS n
								WHERE c.ID = '{CmbSection.SelectedValue}'
                                GROUP BY a.ID")
            DgvStudSubject.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub LoadSubjectEnrolled()
        Try
            Query("SELECT a.ID, CONCAT(b.Start_Year, '-', b.End_Year)SYID, a.EID, d.SubjectCode ,d.SubjectName, 
                    CONCAT(TIME_FORMAT(c.Time_From, '%H:%i'), '-', TIME_FORMAT(c.Time_To, '%H:%i')) Time,
                    GROUP_CONCAT(
                        CASE f.ID 
                        WHEN SUBSTRING_INDEX(SUBSTRING_INDEX(c.Days, ',', n.n), ',', -1) THEN f.Days
                        END
                        ORDER BY n.n
                        SEPARATOR ', ') AS Days, 
                    CONCAT(e.Lastname, ', ', e.Firstname, ' ',e.MiddleInitial) Teacher
                    FROM enrolled_sched a
                    JOIN schoolyear b ON a.SYID = b.ID
                    JOIN schedule c ON a.ScheduleID = c.ID
                    JOIN subject d ON c.Subj_ID = d.ID
                    JOIN teacher e ON c.Teacher_ID = e.ID
                    JOIN days f ON FIND_IN_SET(f.ID, c.Days)
                    CROSS JOIN 
                        (SELECT 1 AS n UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 UNION ALL SELECT 5) AS n
					WHERE a.EID = '" & LabelEID.Text & "'
                    GROUP BY a.ID")
            DgvEnrolledSubjects.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub LoadDepartment()
        Try
            Query("SELECT * FROM department")
            CmbDepartment.DataSource = ds.Tables("QueryTb")
            CmbDepartment.ValueMember = "ID"
            CmbDepartment.DisplayMember = "Department"
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub LoadSection()
        Try
            Query("SELECT * FROM section")
            CmbSection.DataSource = ds.Tables("QueryTb")
            CmbSection.ValueMember = "ID"
            CmbSection.DisplayMember = "SectionRoom"
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public scheduleID As Integer = 0
    Public Sub LoadStudent()
        Try
            Query("SELECT ID, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) Fullname FROM student")
            CmbStudName.DataSource = ds.Tables("QueryTb")
            CmbStudName.ValueMember = "ID"
            CmbStudName.DisplayMember = "Fullname"
        Catch ex As Exception
            Critical(ex.Message)
        End Try
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
            Info("Please enter a LRN.")
            Return
        End If
        If Not IsEmptyField(CmbStudName.Text.Trim()) Then
            Info("Please select a student name.")
            Return
        End If

        ClassEnroll.EnrollmentRef()
    End Sub
    Public idStud As Integer = Nothing

    Private Sub CmbStudName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStudName.SelectedIndexChanged
        Try
            If CmbStudName.SelectedItem IsNot Nothing AndAlso TypeOf CmbStudName.SelectedItem Is DataRowView Then
                Dim selectedStudent As Integer = Convert.ToInt32(DirectCast(CmbStudName.SelectedItem, DataRowView).Row("ID"))

                Dim qry As String = $"SELECT ID, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) Fullname FROM student WHERE ID = {selectedStudent}"
                Query(qry)

                If ds.Tables("QueryTb").Rows.Count > 0 Then
                    txtStudLRN.Text = ds.Tables("QueryTb").Rows(0)("LRN").ToString()
                    CmbStudName.Text = ds.Tables("QueryTb").Rows(0)("Fullname").ToString()
                    idStud = ds.Tables("QueryTb").Rows(0)("ID").ToString()
                Else
                    txtStudLRN.Clear()
                End If
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
        'If CmbStudName.SelectedIndex <> -1 Then
        '    Dim selectedStudent = Convert.ToInt32(DirectCast(CmbStudName.SelectedItem, DataRowView).Row("ID"))

        '    Dim qry As String = $"SELECT ID, LRN, CONCAT(Lastname, ' ', Firstname) Fullname FROM student WHERE ID = {selectedStudent}"
        '    Query(qry)

        '    If ds.Tables("QueryTb").Rows.Count > 0 Then
        '        txtStudLRN.Text = ds.Tables("QueryTb").Rows(0)("LRN").ToString()
        '        CmbStudName.Text = ds.Tables("QueryTb").Rows(0)("Fullname").ToString()
        '        idStud = ds.Tables("QueryTb").Rows(0)("ID").ToString()
        '    Else
        '        txtStudLRN.Clear()
        '    End If
        'End If
    End Sub

    Private Sub CmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDepartment.SelectedIndexChanged
        Try
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
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub CmbGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbGradeLevel.SelectedIndexChanged
        Try
            Dim selectedGradeLevelID As Integer
            If CmbGradeLevel.SelectedItem IsNot Nothing AndAlso TypeOf CmbGradeLevel.SelectedItem Is DataRowView Then
                selectedGradeLevelID = Convert.ToInt32(DirectCast(CmbGradeLevel.SelectedItem, DataRowView).Row("ID"))
            Else
                'MessageBox.Show("Please Select a valid grade level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim qry As String = $"Select ID, SectionRoom FROM section WHERE GradeLevel_ID = {selectedGradeLevelID}"
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
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    'Private Sub CmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSection.SelectedIndexChanged
    '    Dim selectedSection As Integer
    '    If CmbSection.SelectedItem IsNot Nothing AndAlso TypeOf CmbSection.SelectedItem Is DataRowView Then
    '        selectedSection = Convert.ToInt32(DirectCast(CmbSection.SelectedItem, DataRowView).Row("ID"))
    '    Else
    '        'MessageBox.Show("Please Select a valid section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return
    '    End If

    '    Query("Select a.ID, b.GradeLevel, c.Department, a.SectionRoom, CONCAT(d.Lastname, ' ', d.Firstname) AS Adviser
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
