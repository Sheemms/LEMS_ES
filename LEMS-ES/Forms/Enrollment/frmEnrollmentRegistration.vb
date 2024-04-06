Imports MySql.Data.MySqlClient

Public Class frmEnrollmentRegistration
    Public EnrollmentID As Integer = 0

    Private Sub frmEnrollmentRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()

        Dim autoCompleteSource As New AutoCompleteStringCollection()
        autoCompleteSource.AddRange(GetNamesFromDatabase())
        txtSearch.AutoCompleteCustomSource = autoCompleteSource
        txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'txtSearch.AutoCompleteSource = autoCompleteSource.CustomSource
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

    'Private Sub PopulateSearch()
    '    If Not String.IsNullOrEmpty(txtSearch.Text) Then
    '        Dim dt As DataTable
    '        dt = Command("SELECT LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS Fullname FROM student WHERE LRN = @LRN")
    '        cmd.Parameters.Add("@LRN", txtSearch.Text)

    '        Try
    '            If dt.Rows.Count > 0 Then
    '                txtStudLRN.Text = dt.Rows(0)("LRN").ToString()
    '                txtStudName.Text = dt.Rows(0)("Fullname").ToString()
    '            Else
    '                ' Handle if no matching record found
    '            End If
    '        Catch ex As Exception
    '            ' Handle exceptions
    '            MsgBox("Error: " & ex.Message)
    '        Finally
    '            cmd.Parameters.Clear()
    '        End Try
    '    Else
    '        ' Clear the text boxes if the search box is empty
    '        txtStudLRN.Text = ""
    '        txtStudName.Text = ""
    '    End If
    'End Sub

    Private Sub PopulateSearch()
        Try
            If String.IsNullOrWhiteSpace(txtSearch.Text) Then
                txtStudLRN.Clear()
                txtStudName.Clear()
                txtSearch.AutoCompleteCustomSource.Clear()
            Else
                Command("SELECT * FROM student WHERE Lastname LIKE @Lastname ORDER BY Lastname ASC")
                cmd.Parameters.AddWithValue("@Lastname", "%" & txtSearch.Text & "%")

                Dim ds As New DataSet
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(ds, "Lastname")

                Dim autoCompleteCollection As New AutoCompleteStringCollection

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    autoCompleteCollection.Add(ds.Tables(0).Rows(i)("Lastname").ToString())
                Next

                'txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest
                'txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource
                'txtSearch.AutoCompleteCustomSource = autoCompleteCollection

                If ds.Tables(0).Rows.Count > 0 Then
                    txtStudLRN.Text = ds.Tables(0).Rows(0)("LRN").ToString()
                    txtStudName.Text = ds.Tables(0).Rows(0)("Lastname").ToString()
                Else
                    txtStudLRN.Clear()
                    txtStudName.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Public con As New MySqlConnection("server=localhost;user id=root;password=;database=lems_es")
    Public userID As Integer


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()
        If Not String.IsNullOrEmpty(searchText) Then
            Dim qry As String = "SELECT * FROM student WHERE Lastname LIKE @Lastname"
            Query(qry)
            adp.SelectCommand.Parameters.AddWithValue("@Lastname", "%" & searchText & "%")

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                txtStudLRN.Text = ds.Tables(0).Rows(0)("LRN").ToString()
                txtStudName.Text = ds.Tables(0).Rows(0)("Lastname").ToString()
            Else
                txtStudLRN.Text = ""
                txtStudName.Text = ""
            End If
        Else
            txtStudLRN.Text = ""
            txtStudName.Text = ""
        End If
    End Sub

    Private Function GetNamesFromDatabase() As String()
        Dim names As New List(Of String)()
        Try
            Dim qry As String = "SELECT Lastname FROM student"
            Query(qry)

            If ds.Tables.Count > 0 Then
                For Each row As DataRow In ds.Tables(0).Rows
                    names.Add(row("Lastname").ToString())
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
            Return names.ToArray()
        End Function

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
