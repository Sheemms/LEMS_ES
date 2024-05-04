Imports System.Globalization
Imports MySql.Data.MySqlClient
Public Class FrmSchedule
    Public idSched As Integer = 0
    Private Sub FrmSchedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadRecords()
        LoadSection()
        LoadRoom()
        LoadSubject()
        LoadTeacherAutoComplete()
        GetSchoolYear(lblSY)
    End Sub
    Public Sub Clear()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {TxtAdviserID, TxtAdviser, TxtSubjName, TxtUnits, txtTeacherID, txtTeacherName, TxtDept, TxtGradeLevel}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        TxtSearch.Clear()
        txtstartTime.Clear()
        txtendTime.Clear()
        CmbSection.SelectedIndex = -1
        CmbRoom.SelectedIndex = -1
        CmbSubjectCode.SelectedIndex = -1
        cbM.Checked = False
        cbT.Checked = False
        cbW.Checked = False
        cbTH.Checked = False
        cbF.Checked = False
        idSection = 0
        idSched = 0
        idSub = 0
    End Sub
#Region "Loads"
    Public Sub LoadRecords()
        Query($"SELECT a.ID, CONCAT(b.Start_Year, '-',b.End_Year) SchoolYear, e.Department, d.GradeLevel, c.SectionRoom, f.Room,
                g.SubjectCode, g.SubjectName,
                CONCAT(i.Lastname, ', ', i.Firstname, ' ', i.MiddleInitial) as Adviser, a.Days, 
                CONCAT(TIME_FORMAT(a.Time_From, '%H:%i'), '-',TIME_FORMAT(a.Time_To, '%H:%i')) as Time, 
                CONCAT(h.Lastname, ', ', h.Firstname, ' ', h.MiddleInitial) as Teacher 
                FROM schedule a
                JOIN schoolyear b ON a.SYID = b.ID
                JOIN section c ON a.SectionID = c.ID
                JOIN gradelevel d ON c.GradeLevel_ID = d.ID
                JOIN department e ON d.Department_ID = e.ID
                JOIN room f ON a.Room = f.ID
                JOIN subject g ON a.SubjectID = g.ID
                JOIN teacher h ON a.TeacherID = h.ID
                JOIN teacher i on c.AdviserID = i.ID")
        DgvSchedule.DataSource = ds.Tables("QueryTb")

        Query("SELECT a.ID, b.Department, a.EmpID, CONCAT(a.Lastname, ', ', a.Firstname) Teacher
                FROM teacher a
                JOIN department b ON a.Department_ID = b.ID")
        DgvTeacher.AutoGenerateColumns = False
        DgvTeacher.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub LoadSection()
        Query("SELECT * FROM section")
        CmbSection.DataSource = ds.Tables("QueryTb")
        CmbSection.ValueMember = "ID"
        CmbSection.DisplayMember = "SectionRoom"
        CmbSection.SelectedIndex = -1
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
        TxtSubjName.Clear()
        TxtUnits.Clear()
    End Sub
#End Region

    Public idSection = Nothing
    Private Sub CmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSection.SelectedIndexChanged
        Try
            If CmbSection.SelectedIndex <> -1 AndAlso CmbSection.DataSource IsNot Nothing Then
                Dim selectedRow As DataRowView = TryCast(CmbSection.SelectedItem, DataRowView)

                Dim selectedSectionID As Integer = Convert.ToInt32(selectedRow.Row("ID"))

                Query($"SELECT a.ID, c.Department, b.GradeLevel, d.EmpID, CONCAT(d.Lastname, ' ', d.Firstname) Adviser
                                    FROM section a
                                    JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                                    JOIN department c ON b.Department_ID = c.ID
                                    JOIN teacher d ON a.AdviserID = d.ID 
                                    WHERE a.ID = {selectedSectionID}")

                If ds.Tables("QueryTb").Rows.Count > 0 Then
                    idSection = ds.Tables("QueryTb").Rows(0)("ID").ToString()
                    TxtDept.Text = ds.Tables("QueryTb").Rows(0)("Department").ToString()
                    TxtGradeLevel.Text = ds.Tables("QueryTb").Rows(0)("GradeLevel").ToString()
                    TxtAdviserID.Text = ds.Tables("QueryTb").Rows(0)("EmpID").ToString()
                    TxtAdviser.Text = ds.Tables("QueryTb").Rows(0)("Adviser").ToString()
                Else
                    idSection = 0
                    TxtDept.Clear()
                    TxtGradeLevel.Clear()
                    TxtAdviserID.Clear()
                    TxtAdviser.Clear()
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
                    TxtSubjName.Text = ds.Tables("QueryTb").Rows(0)("SubjectName").ToString()
                    TxtUnits.Text = ds.Tables("QueryTb").Rows(0)("Units")
                    idSub = ds.Tables("QueryTb").Rows(0)("ID").ToString()
                Else
                    TxtSubjName.Clear()
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
        If IS_EMPTY(CmbSection) Then Return
        If IS_EMPTY(CmbRoom) Then Return
        If IS_EMPTY(CmbSubjectCode) Then Return
        If IS_EMPTY(txtTeacherName) Then Return
        If Not IsValidTime(txtstartTime.Text) Then
            MsgBox("Invalid start time format")
            Exit Sub
        End If
        If Not IsValidTime(txtendTime.Text) Then
            MsgBox("Invalid start time format")
            Exit Sub
        End If
        ClassSchedule.SchedRef()
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
        Query($"SELECT a.ID, CONCAT(b.Start_Year, '-',b.End_Year) SchoolYear, e.Department, d.GradeLevel, c.SectionRoom, f.Room,
                g.SubjectCode, g.SubjectName,
                CONCAT(i.Lastname, ', ', i.Firstname, ' ', i.MiddleInitial) as Adviser, a.Days, 
                CONCAT(TIME_FORMAT(a.Time_From, '%H:%i'), '-',TIME_FORMAT(a.Time_To, '%H:%i')) as Time, 
                CONCAT(h.Lastname, ', ', h.Firstname, ' ', h.MiddleInitial) as Teacher 
                FROM schedule a
                JOIN schoolyear b ON a.SYID = b.ID
                JOIN section c ON a.SectionID = c.ID
                JOIN gradelevel d ON c.GradeLevel_ID = d.ID
                JOIN department e ON d.Department_ID = e.ID
                JOIN room f ON a.Room = f.ID
                JOIN subject g ON a.SubjectID = g.ID
                JOIN teacher h ON a.TeacherID = h.ID
                JOIN teacher i on c.AdviserID = i.ID
               WHERE h.Lastname LIKE '{TxtSearch.Text}' OR h.Firstname LIKE '{TxtSearch.Text}' OR h.MiddleInitial LIKE '{TxtSearch.Text}'")
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
            Dim adp = New MySqlDataAdapter("SELECT CONCAT(b.Start_Year, '-', b.End_Year) SY, e.GradeLevel as Grade, d.SectionRoom as Section, c.SubjectCode as Code, 
                                            c.SubjectName as Subject, f.Room, a.Days, CONCAT(a.Time_From, '-',a.Time_To) Time, 
                                            CONCAT(g.Lastname, ', ',g.Firstname) Teacher
                                            FROM schedule a 
                                            JOIN schoolyear b ON a.SYID = b.ID
                                            JOIN subject c ON a.SubjectID = c.ID
                                            JOIN section d ON a.SectionID = d.ID
                                            JOIN gradelevel e ON d.GradeLevel_ID = e.ID
                                            JOIN room f ON a.Room = f.ID
                                            JOIN teacher g ON a.TeacherID = g.ID
                                            WHERE a.TeacherID = " & teacherID, con)
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
