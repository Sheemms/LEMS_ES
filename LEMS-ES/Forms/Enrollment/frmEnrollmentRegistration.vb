Imports MySql.Data.MySqlClient

Public Class FrmEnrollmentRegistration
    Public EnrollmentID As Integer = 0
    Public EnrollSubjID As Integer = 0
    Public Ave As String
    Public Rmrks As String
    Public scheduleID As Integer = 0
    Public _subjectno, _title, _unit, _pre As String
    Public _id, _sub As String
    Private Sub FrmEnrollmentRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        GetSchoolYear(lblSY)
        'LoadStudAutoComplet()
        LoadDepartment()
        LoadSection()
        Clear()
        'LoadSub()
    End Sub
    Public Sub Clear()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {txtStudLRN, txtStudName, Guna2TextBox1, Guna2TextBox2}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        txtSearch.Clear()
        CmbSection.SelectedIndex = -1
        EnrollmentID = 0
        EnrollSubjID = 0
        scheduleID = 0
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
    Private Sub BtnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
#Region "IS_EMPTY"
        If IS_EMPTY(txtStudLRN) Then Return
        If IS_EMPTY(txtStudName) Then Return
        If IS_EMPTY(CmbDepartment) Then Return
        If IS_EMPTY(CmbSection) Then Return
        If IS_EMPTY(CmbGradeLevel) Then Return
#End Region
        ClassEnroll.EnrollmentRef()
    End Sub

    Private Sub CmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSection.SelectedIndexChanged
        Dim selectedSection As Integer
        If CmbSection.SelectedItem IsNot Nothing AndAlso TypeOf CmbSection.SelectedItem Is DataRowView Then
            selectedSection = Convert.ToInt32(DirectCast(CmbSection.SelectedItem, DataRowView).Row("ID"))
        Else
            'MessageBox.Show("Please select a valid section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Query("SELECT a.ID, b.GradeLevel, c.Department, a.SectionRoom, CONCAT(d.Lastname, ' ', d.Firstname) AS Adviser
                    FROM section a
                    JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                    JOIN department c ON b.Department_ID = c.ID
                    JOIN teacher d ON a.AdviserID = d.ID
                    WHERE a.ID =" & selectedSection)

        Dim Dtable As DataTable = ds.Tables("QueryTb")
        If Dtable.Rows.Count > 0 Then
            ' Populate TextBoxes with the retrieved data
            'Guna2TextBox2.Text = Dtable.Rows(0)("GradeLevel").ToString()
            'Guna2TextBox1.Text = Dtable.Rows(0)("Department").ToString()
        Else
            ' Clear TextBoxes if no data is found
            Clear()
        End If
    End Sub



#Region "AutoComplete/Populate"

    Private Sub PbSearch_Click(sender As Object, e As EventArgs) Handles PbSearch.Click
        Dim selectedStudName As String = txtSearch.Text.Trim()

        If Not String.IsNullOrEmpty(selectedStudName) Then
            Query($"SELECT ID, StudType, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName FROM student WHERE LRN = '{selectedStudName}' OR Lastname LIKE '%{selectedStudName}%' OR Firstname LIKE '%{selectedStudName}%'")

            If ds.Tables("QueryTb").Rows.Count > 0 Then
                Dim row As DataRow = ds.Tables("QueryTb").Rows(0)
                txtStudLRN.Text = row("LRN").ToString()
                txtStudName.Text = row("FullName").ToString()
            Else
                Clear()
            End If
        Else
            Clear()
        End If
    End Sub

    Private Sub CmbSection_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbSection.SelectedValueChanged
        LoadSub()
    End Sub
#End Region
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If DgvSubjectList IsNot Nothing AndAlso DgvSubjectList.SelectedRows.Count > 0 Then
            scheduleID = Convert.ToInt32(DgvSubjectList.SelectedRows(0).Cells(0).Value)
            ClassEnroll.EnrollSubjRef()
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If DgvEnrolledSubjects IsNot Nothing AndAlso DgvEnrolledSubjects.SelectedRows.Count > 0 Then
            EnrollSubjID = Convert.ToInt32(DgvEnrolledSubjects.SelectedRows(0).Cells(0).Value)
            MsgBox(EnrollSubjID)
            ClassEnroll.RemoveSubjRef()
        End If
    End Sub
End Class
