Imports MySql.Data.MySqlClient

Public Class frmEnrollmentRegistration
    Public EnrollmentID As Integer = 0

    Private Sub frmEnrollmentRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        GetSchoolYear(lblSY)
        LoadStudAutoComplet()
        loadDeprtment()
        LabelEID.Text = EIDGenerate()
    End Sub

    Public Sub loadrecords()
        Query("SELECT ID, LRN, SchoolYear, SectionID, GradeLevel_ID FROM enrollment")
    End Sub

    Public Sub loadDeprtment()
        Query("SELECT * FROM department")
        cmbDepartment.DataSource = ds.Tables("QueryTb")
        cmbDepartment.ValueMember = "ID"
        CmbDepartment.DisplayMember = "Department"
    End Sub
    Public Sub LoadMode()
        Query("SELECT * FROM mop")

    End Sub
    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
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
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
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

    Private Sub cmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
        Dim selectedDepartmentID As Integer
        If cmbDepartment.SelectedItem IsNot Nothing AndAlso TypeOf cmbDepartment.SelectedItem Is DataRowView Then
            selectedDepartmentID = Convert.ToInt32(DirectCast(cmbDepartment.SelectedItem, DataRowView).Row("ID"))
        Else
            MessageBox.Show("Please select a valid department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim qry As String = $"SELECT ID, GradeLevel FROM gradelevel WHERE Department_ID = {selectedDepartmentID}"
        Query(qry)

        Dim gradeLevelTable As DataTable = ds.Tables("QueryTb")
        If gradeLevelTable.Rows.Count > 0 Then
            cmbGradeLevel.DataSource = gradeLevelTable
            cmbGradeLevel.ValueMember = "ID"
            cmbGradeLevel.DisplayMember = "GradeLevel"
        Else
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

        Dim qry As String = $"SELECT ID, SectionRoom, Adviser_ID FROM section WHERE GradeLevel_ID = {selectedGradeLevelID}"
        Query(qry)

        Dim sectionTable As DataTable = ds.Tables("QueryTb")
        If sectionTable.Rows.Count > 0 Then
            cmbSection.DataSource = sectionTable
            cmbSection.ValueMember = "ID"
            cmbSection.DisplayMember = "SectionRoom"
        Else
            cmbSection.DataSource = Nothing
            cmbSection.Items.Clear()
        End If
    End Sub
#End Region

End Class
