Imports System.Globalization
Imports MySql.Data.MySqlClient
Public Class FrmSchedule
    Public idSched As Integer = 0
    Private Sub FrmSchedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Clear()
        LoadRecords()
        LoadSection()
        LoadRoom()
        LoadSubject()
        LoadTeacher()
        'LoadTeacherAutoComplete()
        GetSchoolYear(lblSY)
    End Sub
    Public Sub Clear()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {TxtAdviserID, TxtAdviser, TxtSubjName, TxtUnits, txtTeacherID, TxtDept, TxtGradeLevel}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        TxtSearch.Clear()
        txtstartTime.Clear()
        txtendTime.Clear()
        CmbSection.SelectedIndex = -1
        CmbRoom.SelectedIndex = -1
        CmbSubjectCode.SelectedIndex = -1
        CmbTeacherName.SelectedIndex = -1
        cbM.Checked = False
        cbT.Checked = False
        cbW.Checked = False
        cbTH.Checked = False
        cbF.Checked = False
        idSection = 0
        idSched = 0
        idSub = 0
        teacherid = 0
    End Sub
#Region "Loads"
    Public Sub LoadRecords()
        Try
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
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub LoadSection()
        Try
            Query("SELECT * FROM section")
            CmbSection.DataSource = ds.Tables("QueryTb")
            CmbSection.ValueMember = "ID"
            CmbSection.DisplayMember = "SectionRoom"
            CmbSection.SelectedIndex = -1
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub LoadRoom()
        Try
            Query("SELECT * FROM room")
            CmbRoom.DataSource = ds.Tables("QueryTb")
            CmbRoom.ValueMember = "ID"
            CmbRoom.DisplayMember = "Room"
            CmbRoom.SelectedIndex = -1
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub LoadSubject()
        Try
            Query("SELECT * FROM subject")
            CmbSubjectCode.DataSource = ds.Tables("QueryTb")
            CmbSubjectCode.ValueMember = "ID"
            CmbSubjectCode.DisplayMember = "SubjectCode"
            CmbSubjectCode.SelectedIndex = -1
            TxtSubjName.Clear()
            TxtUnits.Clear()
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub LoadTeacher()
        Try
            Query("SELECT ID, EmpID, CONCAT(Lastname, ' ', Firstname) Fullname FROM teacher")
            CmbTeacherName.DataSource = ds.Tables("QueryTb")
            CmbTeacherName.ValueMember = "ID"
            CmbTeacherName.DisplayMember = "Fullname"
            CmbTeacherName.SelectedIndex = -1
            txtTeacherID.Clear()
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub

    Public Sub LoadSectionData()
        Try
            Query("SELECT a.ID, c.Department, b.GradeLevel as Grade, a.SectionRoom as Section,
                d.EmpID, CONCAT(d.Lastname, ' ', d.Firstname) Adviser
                FROM section a
                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                JOIN department c ON b.Department_ID = c.ID
                JOIN teacher d ON a.AdviserID = d.ID
                WHERE a.ID = '" & idSection & "'")

            If ds.Tables("QueryTb").Rows.Count > 0 Then
                With ds.Tables("QueryTb").Rows(0)
                    TxtDept.Text = .Item(1)
                    TxtGradeLevel.Text = .Item(2)
                    CmbSection.Text = .Item(3)
                    TxtAdviserID.Text = .Item(4)
                    TxtAdviser.Text = .Item(5)
                End With
            Else
                Clear()
            End If
            CmbSubjectCode.SelectedIndex = -1
            TxtSubjName.Clear()
            TxtUnits.Clear()
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub LoadSubjectData()
        Try
            Query("SELECT a.ID, a.SubjectCode, a.SubjectName, a.Units
                FROM subject a
                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                JOIN department c ON b.Department_ID = c.ID
                WHERE a.ID = '" & idSub & "'")

            If ds.Tables("QueryTb").Rows.Count > 0 Then
                With ds.Tables("QueryTb").Rows(0)
                    CmbSubjectCode.Text = .Item(1)
                    TxtSubjName.Text = .Item(2)
                    TxtUnits.Text = .Item(3)
                End With
            Else
                Clear()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub LoadTeacherData()
        Try
            Query("SELECT a.ID, b.Department, a.EmpID, CONCAT(a.Lastname, ' ', a.Firstname) Fullname
                FROM teacher a
                JOIN department b ON a.Department_ID = b.ID
                JOIN gradelevel c ON c.Department_ID = b.ID
                WHERE a.ID = '" & teacherid & "'")

            If ds.Tables("QueryTb").Rows.Count > 0 Then
                With ds.Tables("QueryTb").Rows(0)
                    CmbTeacherName.Text = .Item(3)
                    txtTeacherID.Text = .Item(2)
                End With
            Else
                Clear()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
#End Region

    Public idSection = Nothing
    Private Sub CmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSection.SelectedIndexChanged
        Try
            If CmbSection.SelectedIndex <> -1 AndAlso CmbSection.DataSource IsNot Nothing Then
                Dim selectedRow As DataRowView = TryCast(CmbSection.SelectedItem, DataRowView)

                Dim selectedSectionID As Integer = selectedRow.Row("ID")
                Dim selectedGradeLevelID As Integer = selectedRow.Row("GradeLevel_ID") ' Assuming GradeLevel_ID is a column in the section table

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

                Query($"SELECT ID, SubjectCode FROM subject WHERE GradeLevel_ID = {selectedGradeLevelID}")

                If ds.Tables("QueryTb").Rows.Count > 0 Then
                    CmbSubjectCode.DataSource = ds.Tables("QueryTb")
                    CmbSubjectCode.DisplayMember = "SubjectCode"
                    CmbSubjectCode.ValueMember = "ID"
                Else
                    CmbSubjectCode.DataSource = Nothing
                    CmbSubjectCode.Items.Clear()
                    TxtSubjName.Clear()
                    TxtUnits.Clear()
                End If

                Query($"SELECT a.ID, b.Department, a.EmpID, CONCAT(a.Lastname, ' ', a.Firstname) Fullname
                FROM teacher a
                JOIN department b ON a.Department_ID = b.ID
                JOIN gradelevel c ON c.Department_ID = b.ID
                WHERE c.ID = {selectedGradeLevelID}")

                If ds.Tables("QueryTb").Rows.Count > 0 Then
                    CmbTeacherName.DataSource = ds.Tables("QueryTb")
                    CmbTeacherName.DisplayMember = "Fullname"
                    CmbTeacherName.ValueMember = "ID"
                Else
                    CmbTeacherName.DataSource = Nothing
                    CmbTeacherName.Items.Clear()
                    txtTeacherID.Clear()
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
                    TxtUnits.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public teacherid = Nothing
    Private Sub CmbTeacherName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTeacherName.SelectedIndexChanged
        'If CmbTeacherName.SelectedItem IsNot Nothing Then
        '    LoadTeacherData()
        'End If

        Try
            If CmbTeacherName.SelectedItem IsNot Nothing AndAlso TypeOf CmbTeacherName.SelectedItem Is DataRowView Then
                Dim selectedTeacher As Integer = Convert.ToInt32(DirectCast(CmbTeacherName.SelectedItem, DataRowView).Row("ID"))

                Dim qry As String = $"SELECT a.ID, b.Department, a.EmpID, CONCAT(a.Lastname, ' ', a.Firstname) Fullname
                FROM teacher a
                JOIN department b ON a.Department_ID = b.ID
                JOIN gradelevel c ON c.Department_ID = b.ID
                WHERE a.ID = {selectedTeacher}"
                Query(qry)

                If ds.Tables("QueryTb").Rows.Count > 0 Then
                    txtTeacherID.Text = ds.Tables("QueryTb").Rows(0)("EmpID").ToString()
                    CmbTeacherName.Text = ds.Tables("QueryTb").Rows(0)("Fullname").ToString()
                    teacherid = ds.Tables("QueryTb").Rows(0)("ID").ToString()
                Else
                    txtTeacherID.Clear()
                End If
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
#Region "Auto Complete/ Populate"
    'Private Sub LoadTeacherAutoComplete()
    '    Query("SELECT ID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName, EmpID FROM teacher")
    '    Dim autoCompleteCollection As New AutoCompleteStringCollection()

    '    For Each row As DataRow In ds.Tables("QueryTb").Rows
    '        autoCompleteCollection.Add(row("FullName").ToString())
    '    Next

    '    txtTeacherName.AutoCompleteCustomSource = autoCompleteCollection
    '    txtTeacherName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '    txtTeacherName.AutoCompleteSource = AutoCompleteSource.CustomSource
    'End Sub
    'Public teacherid = Nothing
    'Private Sub TxtTeacherName_TextChanged(sender As Object, e As EventArgs) Handles txtTeacherName.TextChanged
    '    Dim selectedTeacherName As String = txtTeacherName.Text.Trim()

    '    Query("SELECT ID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName, EmpID FROM teacher")
    '    Dim row As DataRow = ds.Tables("QueryTb").Select($"FullName = '{selectedTeacherName}'").FirstOrDefault()

    '    If row IsNot Nothing AndAlso row.Table.Columns.Contains("EmpID") Then
    '        txtTeacherID.Text = row("EmpID").ToString()
    '        teacherid = row("ID").ToString()
    '    Else
    '        txtTeacherID.Clear()
    '    End If
    'End Sub
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
#Region "IsEmptyField"
        If Not IsEmptyField(CmbSection.Text.Trim()) Then
            Info("Please select a section.")
            Return
        End If
        If Not IsEmptyField(CmbRoom.Text.Trim()) Then
            Info("Please select a room.")
            Return
        End If
        If Not IsEmptyField(CmbSubjectCode.Text.Trim()) Then
            Info("Please select a subject code.")
            Return
        End If
        If Not IsEmptyField(txtTeacherID.Text.Trim()) Then
            Info("Please enter a teacher id.")
            Return
        End If
        If Not IsEmptyField(CmbTeacherName.Text.Trim()) Then
            Info("Please select a teacher name.")
            Return
        End If
#End Region
        If Not IsValidTime(txtstartTime.Text) Then
            Info("Invalid start time format")
            Exit Sub
        End If
        If Not IsValidTime(txtendTime.Text) Then
            Info("Invalid start time format")
            Exit Sub
        End If
        ClassSchedule.SchedRef()
    End Sub

    Public Function ChckBox()
        Try
            Dim days = ""
            Dim ckbx() = {cbM, cbT, cbW, cbTH, cbF}
            For i = 0 To ckbx.Length - 1
                If ckbx(i).Checked Then
                    days &= ckbx(i).Text & " "
                End If
            Next
            Return days
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Function

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            Dim search As String = TxtSearch.Text.Trim()

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
               WHERE h.Lastname LIKE '%{search}%' OR h.Firstname LIKE '%{search}%' OR h.MiddleInitial LIKE '%{search}%' OR e.Department LIKE '%{search}%'")
            DgvSchedule.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
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
        Try
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
                    Info("No Schedule")
                    Exit Sub
                End If

                Dim crystal As New ScheduleReport
                crystal.SetDataSource(dt)
                FrmScheduleReport.CrystalReportViewer1.ReportSource = crystal
                FrmScheduleReport.CrystalReportViewer1.Refresh()
                FrmScheduleReport.Show()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub PbSearch_Click(sender As Object, e As EventArgs) Handles PbSearch.Click
        'Dim selectTeacherName As String = TxtTeacherName.Text.Trim()

        'If Not String.IsNullOrEmpty(selectTeacherName) Then
        '    Query($"SELECT ID, EmpID, Department_ID, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS FullName FROM teacher WHERE EmpID LIKE '%{selectTeacherName}%' OR Lastname LIKE '%{selectTeacherName}%' OR Firstname LIKE '%{selectTeacherName}%'")

        '    If ds.Tables("QueryTb").Rows.Count > 0 Then
        '        Dim row As DataRow = ds.Tables("QueryTb").Rows(0)
        '        teacherid = Convert.ToInt32(row("ID"))
        '        txtTeacherID.Text = row("EmpID").ToString()
        '        TxtTeacherName.Text = row("FullName").ToString()
        '    Else
        '        txtTeacherID.Clear()
        '        TxtTeacherName.Clear()
        '    End If
        'Else
        '    txtTeacherID.Clear()
        '    TxtTeacherName.Clear()
        'End If
        Try
            If CmbSection.SelectedItem Is Nothing Then
                Info("Select section first.")
                Return
            Else
                SearchTeacher.Show()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub

    Private Sub SearchTchr_Click(sender As Object, e As EventArgs) Handles SearchTchr.Click
        Try
            Dim selectTeacherName As String = ToolStripTextBox1.Text.Trim()
            Query($"SELECT a.ID, b.Department, a.EmpID, CONCAT(a.Lastname, ', ', a.Firstname) Teacher
                FROM teacher a
                JOIN department b ON a.Department_ID = b.ID 
                WHERE a.Lastname LIKE '%{selectTeacherName}%' OR a.Firstname LIKE '%{selectTeacherName}%' 
                OR a.MiddleInitial LIKE '%{selectTeacherName}%' OR a.EmpID LIKE '%{selectTeacherName}%'
                OR b.Department LIKE '%{selectTeacherName}%'")
            DgvTeacher.AutoGenerateColumns = False
            DgvTeacher.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        SearchSection.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        SearchSubject.Show()
    End Sub

End Class
