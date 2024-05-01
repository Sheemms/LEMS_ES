Imports System.Globalization
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
    Public Sub Clear()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {txtAdviserID, txtSubjName, TxtUnits, txtTeacherID, txtTeacherName}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        TxtSearch.Clear()
        txtstartTime.Clear()
        txtendTime.Clear()
        cmbDepartment.SelectedIndex = -1
        cmbGradeLevel.SelectedIndex = -1
        cmbSection.SelectedIndex = -1
        CmbRoom.SelectedIndex = -1
        CmbAdviser.SelectedIndex = -1
        CmbSubjectCode.SelectedIndex = -1
        cbM.Checked = False
        cbT.Checked = False
        cbW.Checked = False
        cbTH.Checked = False
        cbF.Checked = False
        idAdv = 0
        idSched = 0
        idSub = 0
    End Sub
#Region "Loads"
    Public Sub LoadRecords()
        Query($"SELECT sc.ID, CONCAT(sy.Start_Year, '-',sy.End_Year)SchoolYear, dpt.Department, sec.SectionRoom, sc.Room, sub.SubjectCode, sub.SubjectName,
                CONCAT(t.Lastname, ' ', t.Firstname, ' ', t.MiddleInitial) as Adviser, sc.Days, 
                CONCAT(TIME_FORMAT(Time_From, '%H:%i'), '-',TIME_FORMAT(Time_To, '%H:%i')) as Time, CONCAT(tr.Lastname, ' ', tr.Firstname, ' ', tr.MiddleInitial) as Teacher 
               FROM schedule sc
               JOIN schoolyear sy ON sc.SYID = sy.ID
               JOIN section sec ON sc.Sec_ID = sec.ID
               JOIN teacher t ON sc.Adviser_ID = t.ID
               JOIN subject sub ON sc.Subj_ID = sub.ID
               JOIN department dpt ON sc.Department_ID = dpt.ID
               JOIN teacher tr ON sc.Teacher_ID = tr.ID	")
        DgvSchedule.DataSource = ds.Tables("QueryTb")

        Query("SELECT a.ID, b.Department, a.EmpID, CONCAT(a.Lastname, ', ', a.Firstname) Teacher
                FROM teacher a
                JOIN department b ON a.Department_ID = b.ID")
        DgvTeacher.AutoGenerateColumns = False
        DgvTeacher.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub LoadDepartment()
        Query("SELECT * FROM department")
        cmbDepartment.DataSource = ds.Tables("QueryTb")
        cmbDepartment.ValueMember = "ID"
        cmbDepartment.DisplayMember = "Department"
        cmbDepartment.SelectedIndex = -1
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
            'MessageBox.Show("Please select a valid department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            cmbGradeLevel.SelectedIndex = -1
        End If
    End Sub

    Private Sub CmbGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGradeLevel.SelectedIndexChanged
        Dim selectedGradeLevelID As Integer
        If cmbGradeLevel.SelectedItem IsNot Nothing AndAlso TypeOf cmbGradeLevel.SelectedItem Is DataRowView Then
            selectedGradeLevelID = Convert.ToInt32(DirectCast(cmbGradeLevel.SelectedItem, DataRowView).Row("ID"))
        Else
            'MessageBox.Show("Please select a valid grade level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            cmbSection.SelectedIndex = -1
        End If
    End Sub
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
            MsgBox(ex.Message)
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
            MsgBox(ex.Message)
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
    'Private Sub PbSearch_Click(sender As Object, e As EventArgs) Handles PbSearch.Click
    '    Query($"SELECT ID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName, EmpID FROM teacher WHERE Lastname LIKE '{TxtSearch.Text}' OR Firstname LIKE '{TxtSearch.Text}' OR MiddleInitial LIKE '{TxtSearch.Text}'")
    '    Dim row As DataRow = ds.Tables("QueryTb").Rows.Cast(Of DataRow)().FirstOrDefault() ' Get the first row if exists
    '    If row IsNot Nothing AndAlso row.Table.Columns.Contains("ID") Then
    '        txtTeacherName.Text = row("FullName").ToString()
    '        txtTeacherID.Text = row("EmpID").ToString()
    '        teacherid = row("ID").ToString()
    '    Else
    '        txtTeacherName.Clear()
    '        txtTeacherID.Clear()
    '        teacherid = Nothing
    '    End If
    'End Sub

#End Region

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IS_EMPTY(cmbDepartment) Then Return
        If IS_EMPTY(cmbGradeLevel) Then Return
        If IS_EMPTY(cmbSection) Then Return
        If IS_EMPTY(CmbRoom) Then Return
        If IS_EMPTY(CmbAdviser) Then Return

        ClassSchedule.SchedRef()
        Clear()
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

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Query($"SELECT sc.ID, CONCAT(sy.Start_Year, '-',sy.End_Year)SchoolYear, dpt.Department, sec.SectionRoom, sc.Room, sub.SubjectCode, sub.SubjectName,
                CONCAT(t.Lastname, ' ', t.Firstname, ' ', t.MiddleInitial) as Adviser, sc.Days, 
                CONCAT(TIME_FORMAT(Time_From, '%H:%i'), '-',TIME_FORMAT(Time_To, '%H:%i')) as Time, CONCAT(tr.Lastname, ' ', tr.Firstname, ' ', tr.MiddleInitial) as Teacher 
               FROM schedule sc
               JOIN schoolyear sy ON sc.SYID = sy.ID
               JOIN section sec ON sc.Sec_ID = sec.ID
               JOIN teacher t ON sc.Adviser_ID = t.ID
               JOIN subject sub ON sc.Subj_ID = sub.ID
               JOIN department dpt ON sc.Department_ID = dpt.ID
               JOIN teacher tr ON sc.Teacher_ID = tr.ID
               WHERE tr.Lastname LIKE '{TxtSearch.Text}' OR tr.Firstname LIKE '{TxtSearch.Text}' OR tr.MiddleInitial LIKE '{TxtSearch.Text}'")
        DgvSchedule.DataSource = ds.Tables("QueryTb")
    End Sub

    'Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
    '    Dim searchText As String = TxtSearch.Text.Trim()

    '    If searchText <> String.Empty Then
    '        Dim dataTable As DataTable = CType(dgvSchedule.DataSource, DataTable)
    '        Dim filteredData As New DataTable()

    '        filteredData = dataTable.Clone()

    '        For Each row As DataRow In dataTable.Rows
    '            For Each col As DataColumn In dataTable.Columns
    '                If row(col.ColumnName).ToString().Contains(searchText) Then
    '                    filteredData.ImportRow(row)
    '                    Exit For
    '                End If
    '            Next
    '        Next

    '        dgvSchedule.DataSource = filteredData
    '    Else
    '        LoadRecords()
    '    End If
    'End Sub

    Private Sub DgvTeacher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTeacher.CellContentClick
        Dim column As String = DgvTeacher.Columns(e.ColumnIndex).Name

        If column = "colPrint" AndAlso e.RowIndex >= 0 Then
            Dim teacherID As String = DgvTeacher.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim dt = New DataTable("DS_Schedule")
            Dim adp = New MySqlDataAdapter("SELECT CONCAT(b.Start_Year, '-', b.End_Year) SY, d.GradeLevel as Grade, e.SectionRoom as Section, c.SubjectCode as Code, 
                                            c.SubjectName as Subject, f.Room, a.Days, CONCAT(a.Time_From, '-',a.Time_To) Time, CONCAT(g.Lastname, ', ',g.Firstname) Teacher
                                            FROM schedule a 
                                            JOIN schoolyear b ON a.SYID = b.ID
                                            JOIN subject c ON a.Subj_ID = c.ID
                                            JOIN gradelevel d ON a.GradeLevel_ID = d.ID
                                            JOIN section e ON a.Sec_ID = e.ID
                                            JOIN room f ON a.Room = f.ID
                                            JOIN teacher g ON a.Teacher_ID = g.ID
                                            WHERE a.Teacher_ID = " & teacherID, con)
            adp.Fill(dt)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Schedule")
                Exit Sub
            End If

            Dim crystal As New ScheduleReport
            crystal.SetDataSource(dt)
            FrmScheduleReport.CrystalReportViewer1.ReportSource = crystal
            FrmScheduleReport.CrystalReportViewer1.Refresh()
            FrmScheduleReport.Show()
        End If
    End Sub

End Class
