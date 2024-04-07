Imports MySql.Data.MySqlClient

Public Class frmEnrollmentRegistration
    Public EnrollmentID As Integer = 0

    Private Sub frmEnrollmentRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        GetSchoolYear(lblSY)
        LoadStudentAutoComplete()
    End Sub

    Public Sub loadrecords()

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

    Private Sub LoadStudentAutoComplete()
        ' Load teacher data from the database
        Query("SELECT ID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName FROM student")

        ' Create a new AutoCompleteStringCollection
        Dim autoCompleteCollection As New AutoCompleteStringCollection()

        ' Add teacher names to the AutoCompleteStringCollection
        For Each row As DataRow In ds.Tables("QueryTb").Rows
            autoCompleteCollection.Add(row("FullName").ToString())
        Next

        ' Assign the AutoCompleteStringCollection to the TextBox
        txtSearch.AutoCompleteCustomSource = autoCompleteCollection
        txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
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

End Class
