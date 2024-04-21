Imports MySql.Data.MySqlClient

Public Class FrmEnrollmentRegistration
    Public EnrollmentID As Integer = 0

    Private Sub FrmEnrollmentRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        GetSchoolYear(lblSY)
        LoadStudAutoComplet()
        LoadDeprtment()
        LabelEID.Text = EIDGenerate()
        LoadSub()
    End Sub

    Public Sub Loadrecords()
        Query("SELECT ID, LRN, SchoolYear, SectionID, GradeLevel_ID FROM enrollment")
    End Sub

    Public Sub LoadSub()
        Query("SELECT  a.ID, d.SubjectCode, d.SubjectName, CONCAT(TIME_FORMAT(Time_From, '%H:%i'), '-', TIME_FORMAT(Time_To, '%H:%i')) Time, a.Days, CONCAT(e.Lastname, ' ',e.Firstname) Teacher
                                FROM schedule a
                                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                                JOIN section c ON a.Sec_ID = c.ID
                                JOIN subject d ON a.Subj_ID = d.ID
                                JOIN teacher e ON a.Teacher_ID = e.ID
                                WHERE a.GradeLevel_ID LIKE '" & CmbGradeLevel.SelectedValue & "'")
        dgvSubjectList.DataSource = ds.Tables("QueryTb")
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
    Private Sub PopulateSubjectsByGradeLevel(ByVal gradeLevel As String)
        Try
            Dim sql As String = "SELECT * FROM schedule WHERE GradeLevel_ID = @GradeLevel_ID"

            dgvSubjectList.Rows.Clear()

            Command(sql)
            cmd.Parameters.AddWithValue("@GradeLevel", gradeLevel)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read()
                    dgvSubjectList.Rows.Add(dr("ID"), dr("SubjectCode"), dr("SubjectName"), dr("Description"), dr("Units"))
                End While
            Else
                MessageBox.Show("No subjects found for the selected grade level.")
            End If

            dr.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        ClassEnroll.EnrollmentRef()
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

        Dim qry As String = $"SELECT ID, SectionRoom, Adviser_ID FROM section WHERE GradeLevel_ID = {selectedGradeLevelID}"
        Query(qry)

        Dim sectionTable As DataTable = ds.Tables("QueryTb")
        If sectionTable.Rows.Count > 0 Then
            CmbSection.DataSource = sectionTable
            CmbSection.ValueMember = "ID"
            CmbSection.DisplayMember = "SectionRoom"
        Else
            CmbSection.DataSource = Nothing
            CmbSection.Items.Clear()
        End If

    End Sub
#End Region

End Class
