Public Class frmSchedule
    Public idSched As Integer = 0
    Private Sub frmSchedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadRecords()
        LoadDepartment()
        LoadSubjectAutoComplet()
        LoadTeacherAutoComplete()
        GetSchoolYear(lblSY)
    End Sub
#Region "Loads"
    Public Sub LoadRecords()
        Query("SELECT sc.ID, sc.SY_Code, dpt.Department, sec.SectionRoom, sc.Room, 
                CONCAT(t.Lastname, ' ', t.Firstname, ' ', t.MiddleInitial) as Adviser, sub.SubjectCode, sc.Days, 
                CONCAT(TIME_FORMAT(Time_From, '%H:%i'), '-',TIME_FORMAT(Time_To, '%H:%i')) as Time, CONCAT(tr.Lastname, ' ', tr.Firstname, ' ', tr.MiddleInitial) as Teacher 
               FROM schedule sc
               JOIN section sec ON sc.Sec_ID = sec.ID
               JOIN teacher t ON sc.Adviser_ID = t.ID
               JOIN subject sub ON sc.Subj_ID = sub.ID
               JOIN department dpt ON sc.Department_ID = dpt.ID
               JOIN teacher tr ON sc.Teacher_ID = tr.ID")
        dgvSchedule.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub LoadDepartment()
        Query("SELECT * FROM department")
        cmbDepartment.DataSource = ds.Tables("QueryTb")
        cmbDepartment.ValueMember = "ID"
        cmbDepartment.DisplayMember = "Department"
    End Sub
#End Region

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
            txtAdviser.Clear()
        End If
    End Sub
    Public AdvID = Nothing
    Private Sub cmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSection.SelectedIndexChanged
        Try
            If cmbSection.SelectedIndex <> -1 AndAlso cmbSection.DataSource IsNot Nothing Then
                Dim selectedRow As DataRowView = TryCast(cmbSection.SelectedItem, DataRowView)

                Dim selectedSectionID As Integer = Convert.ToInt32(selectedRow.Row("ID"))

                Dim qry As String = $"SELECT s.SectionRoom, t.EmpID, s.Adviser_ID, CONCAT(t.Lastname, ' ', t.Firstname, ' ', t.MiddleInitial) as FullName
                                  FROM section s 
                                  JOIN teacher t ON s.Adviser_ID = t.ID
                                  WHERE s.ID = {selectedSectionID}"
                Query(qry)

                If ds.Tables("QueryTb").Rows.Count > 0 Then
                    txtAdviserID.Text = ds.Tables("QueryTb").Rows(0)("EmpID").ToString()
                    txtAdviser.Text = ds.Tables("QueryTb").Rows(0)("FullName").ToString()
                    AdvID = ds.Tables("QueryTb").Rows(0)("Adviser_ID").ToString()

                Else
                    txtAdviserID.Clear()
                    txtAdviser.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#Region "Auto Complete/ Populate"
    Private Sub LoadSubjectAutoComplet()
        Query("SELECT ID, GradeLevel_ID, SubjectCode, SubjectName, Units FROM subject")
        Dim autoCompleteCollection As New AutoCompleteStringCollection()

        For Each row As DataRow In ds.Tables("QueryTb").Rows
            autoCompleteCollection.Add(row("SubjectCode").ToString())
        Next

        txtSubjCode.AutoCompleteCustomSource = autoCompleteCollection
        txtSubjCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtSubjCode.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
    Public subjID = Nothing
    Private Sub txtSubjCode_TextChanged(sender As Object, e As EventArgs) Handles txtSubjCode.TextChanged
        Dim selectedSubjName As String = txtSubjCode.Text.Trim()

        Query("SELECT ID, GradeLevel_ID, SubjectCode, SubjectName, Units FROM subject")
        Dim row As DataRow = ds.Tables("QueryTb").Select($"SubjectCode = '{selectedSubjName}'").FirstOrDefault()

        If row IsNot Nothing AndAlso row.Table.Columns.Contains("SubjectName") Then
            txtSubjName.Text = row("SubjectName").ToString()
            TxtUnits.Text = row("Units").ToString()
            subjID = row("ID").ToString()
        Else
            txtSubjName.Clear()
        End If
    End Sub
    Private Sub LoadTeacherAutoComplete()
        Query("SELECT ID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName, EmpID FROM teacher")
        Dim autoCompleteCollection As New AutoCompleteStringCollection()

        For Each row As DataRow In ds.Tables("QueryTb").Rows
            autoCompleteCollection.Add(row("FullName").ToString())
        Next

        txtTeacherName.AutoCompleteCustomSource = autoCompleteCollection
        txtTeacherName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtTeacherName.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub
    Public teacherid = Nothing
    Private Sub txtTeacherName_TextChanged(sender As Object, e As EventArgs) Handles txtTeacherName.TextChanged
        Dim selectedTeacherName As String = txtTeacherName.Text.Trim()

        Query("SELECT ID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName, EmpID FROM teacher")
        Dim row As DataRow = ds.Tables("QueryTb").Select($"FullName = '{selectedTeacherName}'").FirstOrDefault()

        If row IsNot Nothing AndAlso row.Table.Columns.Contains("EmpID") Then
            txtTeacherID.Text = row("EmpID").ToString()
            teacherid = row("ID").ToString()
        Else
            txtTeacherID.Clear()
        End If
    End Sub

#End Region

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IS_EMPTY(cmbDepartment) Then Return

        ClassSchedule.SchedRef()
        ClearFields(Me, idSched)
    End Sub

    Public Function chckBox()
        Dim days = ""
        Dim ckbx() = {cbM, cbT, cbW, cbTH, cbF}
        For i = 0 To ckbx.Length - 1
            If ckbx(i).Checked Then
                days &= ckbx(i).Text & " "
            End If
        Next
        Return days
    End Function

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Query($"SELECT sc.ID, sc.SY_Code, dpt.Department, sec.SectionRoom, sc.Room, 
                CONCAT(t.Lastname, ' ', t.Firstname, ' ', t.MiddleInitial) as Adviser, sub.SubjectCode, sc.Days, 
                CONCAT(sc.Time_From, '-', sc.Time_To) as Time, CONCAT(tr.Lastname, ' ', tr.Firstname, ' ', tr.MiddleInitial) as Teacher 
               FROM schedule sc
               JOIN section sec ON sc.Sec_ID = sec.ID
               JOIN teacher t ON sc.Adviser_ID = t.ID
               JOIN subject sub ON sc.Subj_ID = sub.ID
               JOIN department dpt ON sc.Department_ID = dpt.ID
               JOIN teacher tr ON sc.Teacher_ID = tr.ID
               WHERE CONCAT(tr.Lastname, ' ', tr.Firstname, ' ', tr.MiddleInitial) LIKE '{TxtSearch.Text}'")
        dgvSchedule.DataSource = ds.Tables("QueryTb")
    End Sub
End Class
