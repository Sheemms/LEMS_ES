Imports MySql.Data.MySqlClient
Public Class FrmSchedule
    Public idSched As Integer = 0
    Private Sub FrmSchedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadRecords()
        LoadDepartment()
        LoadTeacher()
        LoadRoom()
        LoadSubject()
        LoadTeacherAutoComplete()
        GetSchoolYear(lblSY)
    End Sub
#Region "Loads"
    Public Sub LoadRecords()
        Query($"SELECT sc.ID, sc.SY_Code, dpt.Department, sec.SectionRoom, sc.Room, sub.SubjectCode, sub.SubjectName,
                CONCAT(t.Lastname, ' ', t.Firstname, ' ', t.MiddleInitial) as Adviser, sc.Days, 
                CONCAT(TIME_FORMAT(Time_From, '%H:%i'), '-',TIME_FORMAT(Time_To, '%H:%i')) as Time, CONCAT(tr.Lastname, ' ', tr.Firstname, ' ', tr.MiddleInitial) as Teacher 
               FROM schedule sc
               JOIN section sec ON sc.Sec_ID = sec.ID
               JOIN teacher t ON sc.Adviser_ID = t.ID
               JOIN subject sub ON sc.Subj_ID = sub.ID
               JOIN department dpt ON sc.Department_ID = dpt.ID
               JOIN teacher tr ON sc.Teacher_ID = tr.ID	")
        dgvSchedule.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub LoadDepartment()
        Query("SELECT * FROM department")
        cmbDepartment.DataSource = ds.Tables("QueryTb")
        cmbDepartment.ValueMember = "ID"
        cmbDepartment.DisplayMember = "Department"
    End Sub
    Public Sub LoadTeacher()
        Query("SELECT ID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) as Fullname FROM teacher")
        CmbAdviser.DataSource = ds.Tables("QueryTb")
        CmbAdviser.ValueMember = "ID"
        CmbAdviser.DisplayMember = "Fullname"
        CmbAdviser.SelectedIndex = -1
        txtAdviserID.Clear()
    End Sub
    Public Sub LoadRoom()
        Query("SELECT * FROM room")
        CmbRoom.DataSource = ds.Tables("QueryTb")
        CmbRoom.ValueMember = "ID"
        CmbRoom.DisplayMember = "Room"
        CmbRoom.SelectedIndex = -1
    End Sub
    Public Sub LoadSubject()
        Query("SELECT * FROM subject")
        CmbSubjectCode.DataSource = ds.Tables("QueryTb")
        CmbSubjectCode.ValueMember = "ID"
        CmbSubjectCode.DisplayMember = "SubjectCode"
        CmbSubjectCode.SelectedIndex = -1
        txtSubjName.Clear()
        TxtUnits.Clear()
    End Sub
#End Region

    Private Sub CmbDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartment.SelectedIndexChanged
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

    Private Sub CmbGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGradeLevel.SelectedIndexChanged
        Dim selectedGradeLevelID As Integer
        If cmbGradeLevel.SelectedItem IsNot Nothing AndAlso TypeOf cmbGradeLevel.SelectedItem Is DataRowView Then
            selectedGradeLevelID = Convert.ToInt32(DirectCast(cmbGradeLevel.SelectedItem, DataRowView).Row("ID"))
        Else
            MessageBox.Show("Please select a valid grade level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim qry As String = $"SELECT ID, SectionRoom FROM section WHERE GradeLevel_ID = {selectedGradeLevelID}"
        Query(qry)

        Dim sectionTable As DataTable = ds.Tables("QueryTb")
        If sectionTable.Rows.Count > 0 Then
            cmbSection.DataSource = sectionTable
            cmbSection.ValueMember = "ID"
            cmbSection.DisplayMember = "SectionRoom"
        Else
            cmbSection.DataSource = Nothing
            cmbSection.Items.Clear()
            'txtAdviser.Clear()
        End If
    End Sub
    'Public AdvID = Nothing
    'Private Sub CmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSection.SelectedIndexChanged
    '    Try
    '        If cmbSection.SelectedIndex <> -1 AndAlso cmbSection.DataSource IsNot Nothing Then
    '            Dim selectedRow As DataRowView = TryCast(cmbSection.SelectedItem, DataRowView)

    '            Dim selectedSectionID As Integer = Convert.ToInt32(selectedRow.Row("ID"))

    '            Dim qry As String = $"SELECT s.SectionRoom, t.EmpID, CONCAT(t.Lastname, ' ', t.Firstname, ' ', t.MiddleInitial) as FullName
    '                              FROM section s 
    '                              JOIN teacher t ON s.Adviser_ID = t.ID
    '                              WHERE s.ID = {selectedSectionID}"
    '            Query(qry)

    '            If ds.Tables("QueryTb").Rows.Count > 0 Then
    '                txtAdviserID.Text = ds.Tables("QueryTb").Rows(0)("EmpID").ToString()
    '                txtAdviser.Text = ds.Tables("QueryTb").Rows(0)("FullName").ToString()
    '                AdvID = ds.Tables("QueryTb").Rows(0)("Adviser_ID").ToString()

    '            Else
    '                txtAdviserID.Clear()
    '                txtAdviser.Clear()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    Public idAdv = Nothing
    Private Sub CmbAdviser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAdviser.SelectedIndexChanged
        Try
            If CmbAdviser.SelectedIndex <> -1 AndAlso CmbAdviser.DataSource IsNot Nothing Then
                Dim selectedRow As DataRowView = TryCast(CmbAdviser.SelectedItem, DataRowView)

                Dim selectedSectionID As Integer = Convert.ToInt32(selectedRow.Row("ID"))

                Dim qry As String = $"SELECT a.ID, a.EmpID, CONCAT(a.Lastname, ' ', a.Firstname, ' ',a.MiddleInitial) as Fullname
                                  FROM teacher a 
                                  WHERE a.ID = {selectedSectionID}"
                Query(qry)

                If ds.Tables("QueryTb").Rows.Count > 0 Then
                    txtAdviserID.Text = ds.Tables("QueryTb").Rows(0)("EmpID").ToString()
                    idAdv = ds.Tables("QueryTb").Rows(0)("ID").ToString()
                Else
                    txtAdviserID.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public idSub = Nothing
    Private Sub CmbSubjectCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSubjectCode.SelectedIndexChanged
        Try
            If CmbSubjectCode.SelectedIndex <> -1 AndAlso CmbSubjectCode.DataSource IsNot Nothing Then
                Dim selectedRow As DataRowView = TryCast(CmbSubjectCode.SelectedItem, DataRowView)

                Dim selectedSectionID As Integer = Convert.ToInt32(selectedRow.Row("ID"))

                Dim qry As String = $"SELECT a.ID, b.GradeLevel,  a.SubjectCode, a.SubjectName, a.Units
                                  FROM subject a 
                                  JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                                  WHERE a.ID = {selectedSectionID}"
                Query(qry)

                If ds.Tables("QueryTb").Rows.Count > 0 Then
                    txtSubjName.Text = ds.Tables("QueryTb").Rows(0)("SubjectName").ToString()
                    TxtUnits.Text = ds.Tables("QueryTb").Rows(0)("Units")
                    idSub = ds.Tables("QueryTb").Rows(0)("ID").ToString()
                Else
                    txtSubjName.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Auto Complete/ Populate"
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
    Private Sub TxtTeacherName_TextChanged(sender As Object, e As EventArgs) Handles txtTeacherName.TextChanged
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

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IS_EMPTY(cmbDepartment) Then Return

        ClassSchedule.SchedRef()
        ClearFields(Me, idSched)
    End Sub

    Public Function ChckBox()
        Dim days = ""
        Dim ckbx() = {cbM, cbT, cbW, cbTH, cbF}
        For i = 0 To ckbx.Length - 1
            If ckbx(i).Checked Then
                days &= ckbx(i).Text & " "
            End If
        Next
        Return days
    End Function

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Query($"SELECT sc.ID, sc.SY_Code, dpt.Department, sec.SectionRoom, sc.Room, 
                CONCAT(t.Lastname, ' ', t.Firstname, ' ', t.MiddleInitial) as Adviser, sub.SubjectCode, sc.Days, 
                CONCAT(sc.Time_From, '-', sc.Time_To) as Time, CONCAT(tr.Lastname, ' ', tr.Firstname, ' ', tr.MiddleInitial) as Teacher 
               FROM schedule sc
               JOIN section sec ON sc.Sec_ID = sec.ID
               JOIN teacher t ON sc.Adviser_ID = t.ID
               JOIN subject sub ON sc.Subj_ID = sub.ID
               JOIN department dpt ON sc.Department_ID = dpt.ID
               JOIN teacher tr ON sc.Teacher_ID = tr.ID
               WHERE tr.Lastname LIKE '{TxtSearch.Text}' OR tr.Firstname LIKE '{TxtSearch.Text}' OR tr.MiddleInitial LIKE '{TxtSearch.Text}'")
        dgvSchedule.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim searchText As String = TxtSearch.Text.Trim()

        If searchText <> String.Empty Then
            Dim dataTable As DataTable = CType(dgvSchedule.DataSource, DataTable)
            Dim filteredData As New DataTable()

            filteredData = dataTable.Clone()

            For Each row As DataRow In dataTable.Rows
                For Each col As DataColumn In dataTable.Columns
                    If row(col.ColumnName).ToString().Contains(searchText) Then
                        filteredData.ImportRow(row)
                        Exit For
                    End If
                Next
            Next

            dgvSchedule.DataSource = filteredData
        Else
            LoadRecords()
        End If
    End Sub

End Class
