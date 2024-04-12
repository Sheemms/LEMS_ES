Imports MySql.Data.MySqlClient

Public Class frmEnrollmentRegistration
    Public EnrollmentID As Integer = 0

    Private Sub frmEnrollmentRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        GetSchoolYear(lblSY)
        LoadStudAutoComplet()
        LoadRequirements()
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

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click

    End Sub

#Region "ESD"
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        'PopulateSearch()
        'Command("SELECT * FROM student ORDER BY Lastname")
        'Dim ds As New DataSet
        'Dim da As MySqlDataAdapter
        'da = New MySqlDataAdapter(cmd)
        'da.Fill(ds, "Lastname")
        'Dim autoCompleteCollection As New AutoCompleteStringCollection
        'Dim i As Integer
        'For i = 0 To ds.Tables(0).Rows.Count - 1
        '    autoCompleteCollection.Add(ds.Tables(0).Rows(i)("Lastname")).ToString()
        'Next
        'txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest
        'txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtSearch.AutoCompleteCustomSource = autoCompleteCollection
    End Sub
#End Region
#Region "AutoComplete/Populate"
    Private Sub LoadStudAutoComplet()
        Query("SELECT ID, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName FROM student")
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

        Query("SELECT ID, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName FROM student")
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
