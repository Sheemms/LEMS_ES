Imports MySql.Data.MySqlClient

Public Class frmEnrollmentRegistration
    Public EnrollmentID As Integer = 0

    Private Sub frmEnrollmentRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        GetSchoolYear(lblSY)
        LoadStudAutoComplet()
        LoadRequirements()
        loadDeprtment()
    End Sub

    Public Sub loadrecords()
        Query("SELECT ID, LRN, SchoolYear, SectionID, GradeLevel_ID FROM enrollment")
    End Sub
    Public Sub LoadRequirements()
        Query("SELECT rq.ID, rqcl.Classification, rq.Requirement 
                FROM requirements rq
                JOIN req_classification rqcl ON rq.Classification_ID = rqcl.ID")
        dgvRequirements.DataSource = ds.Tables("QueryTb")
    End Sub

    Public Sub loadSubject()
        Query("SELECT ID, LRN, SchoolYear, SectionID, GradeLevel_ID 
               FROM enrollment e
               JOIN section s ON e.SectionID = s.ID
               JOIN gradelevel gl ON e.GradeLevel_ID = gl.ID")
        dgvSubjectList.DataSource = ds.Tables("QueryTb")

        Query("SELECT ID, GradeLevel FROM gradelevel")
        cmbGradeLevel.DataSource = ds.Tables("QueryTb")
        cmbGradeLevel.ValueMember = "ID"
        cmbGradeLevel.DisplayMember = "GradeLevel"
    End Sub
    Public Sub loadDeprtment()
        Query("SELECT ID, Department FROM department")
        cmbDepartment.DataSource = ds.Tables("QueryTb")
        cmbDepartment.ValueMember = "ID"
        cmbDepartment.DisplayMember = "Department"
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click

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
#End Region

End Class
