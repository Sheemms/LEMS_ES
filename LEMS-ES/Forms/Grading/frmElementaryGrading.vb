Imports MySql.Data.MySqlClient
Public Class FrmElementaryGrading
    Private Sub CmbSubjCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSubjCode.SelectedIndexChanged
        Dim selectedValue As String = CmbSubjCode.SelectedIndex.ToString()
        If CmbSubjCode.SelectedIndex <> -1 AndAlso CmbSubjCode.ComboBox.DataSource IsNot Nothing Then
            Dim selectedRow As DataRowView = TryCast(CmbSubjCode.SelectedItem, DataRowView)

            Dim selectedSubjectCodeID As Integer = Convert.ToInt32(selectedRow.Row("ID"))

            Dim qry As String = $"SELECT  a.ID,CONCAT(b.Start_Year, '-', b.End_Year) SY, d.EID, c.LRN, 
                                        CONCAT(c.Lastname, ', ', c.Firstname, ' ', c.MiddleInitial) Fullname, 
                                        f.SubjectCode, f.SubjectName, f.Units, a.FirstGrd, a.SecondGrd, a.ThirdGrd, a.FourthGrd, a.Average, a.Remarks
                                        FROM enrolled_sched a 
                                        JOIN schoolyear b ON a.SYID = b.ID
                                        JOIN student c ON a.LRN = c.LRN
                                        JOIN enrollment d ON c.LRN = d.LRN
                                        JOIN schedule e ON a.ScheduleID = e.ID
                                        JOIN subject f ON e.SubjectID = f.ID
                                        JOIN gradelevel g ON f.GradeLevel_ID = g.ID
                                        JOIN department h ON g.Department_ID = h.ID
                                  WHERE f.ID = {selectedSubjectCodeID}"
            Query(qry)
            DgvElemGrading.DataSource = ds.Tables("QueryTb")

        End If
    End Sub
    Private Sub CmbSubject_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If CmbSubject.SelectedIndex <> -1 AndAlso CmbSubject.ComboBox.DataSource IsNot Nothing Then
        '    Dim selectedRow As DataRowView = TryCast(CmbSubject.SelectedItem, DataRowView)

        '    Dim selectedDeptID As Integer = Convert.ToInt32(selectedRow.Row("ID"))

        '    Dim qry As String = $"SELECT  a.ID,CONCAT(b.Start_Year, '-', b.End_Year) SY, d.EID, c.LRN, 
        '                                CONCAT(c.Lastname, ', ', c.Firstname, ' ', c.MiddleInitial) Fullname, 
        '                                f.SubjectCode, f.SubjectName, f.Units, a.FirstGrd, a.SecondGrd, a.ThirdGrd, a.FourthGrd, a.Average, a.Remarks
        '                                FROM enrolled_sched a 
        '                                JOIN schoolyear b ON a.SYID = b.ID
        '                                JOIN student c ON a.LRN = c.LRN
        '                                JOIN enrollment d ON c.LRN = d.LRN
        '                                JOIN schedule e ON a.ScheduleID = e.ID
        '                                JOIN subject f ON e.Subj_ID = f.ID
        '                                JOIN gradelevel g ON f.GradeLevel_ID = g.ID
        '                                JOIN department h ON g.Department_ID = h.ID
        '                          WHERE h.ID = {selectedDeptID}"
        '    Query(qry)
        '    DgvElemGrading.DataSource = ds.Tables("QueryTb")

        'End If
    End Sub
    Private Sub FrmElementaryGrading_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadData()
        LoadSubjectCode()
        'LoadDepartment()
    End Sub
    Public Sub LoadSubjectCode()
        Query("SELECT a.ID, a.SubjectCode, a.SubjectName, a.Units
                FROM subject a
                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                JOIN department c ON b.Department_ID = c.ID
                WHERE c.Department = 'Elementary'")
        CmbSubjCode.ComboBox.DataSource = ds.Tables("QueryTb")
        CmbSubjCode.ComboBox.ValueMember = "ID"
        CmbSubjCode.ComboBox.DisplayMember = "SubjectCode"
        CmbSubjCode.ComboBox.SelectedIndex = -1
    End Sub
    'Public Sub LoadSubject()
    '    Query("SELECT * FROM subject")
    '    CmbSubject.ComboBox.DataSource = ds.Tables("QueryTb")
    '    CmbSubject.ComboBox.ValueMember = "ID"
    '    CmbSubject.ComboBox.DisplayMember = "SubjectName"
    'End Sub
    'Public Sub LoadDepartment()
    '    Query("SELECT * FROM department")
    '    CmbSubject.ComboBox.DataSource = ds.Tables("QueryTb")
    '    CmbSubject.ComboBox.ValueMember = "ID"
    '    CmbSubject.ComboBox.DisplayMember = "Department"
    'End Sub
    Public Sub LoadData()
        Query($"SELECT  a.ID,CONCAT(b.Start_Year, '-', b.End_Year) SY, d.EID, c.LRN, 
                                        CONCAT(c.Lastname, ', ', c.Firstname, ' ', c.MiddleInitial) Fullname, 
                                        f.SubjectCode, f.SubjectName, f.Units, a.FirstGrd, a.SecondGrd, a.ThirdGrd, a.FourthGrd, a.Average, a.Remarks
                                        FROM enrolled_sched a 
                                        JOIN schoolyear b ON a.SYID = b.ID
                                        JOIN student c ON a.LRN = c.LRN
                                        JOIN enrollment d ON c.LRN = d.LRN
                                        JOIN schedule e ON a.ScheduleID = e.ID
                                        JOIN subject f ON e.SubjectID = f.ID
                                        JOIN gradelevel g ON f.GradeLevel_ID = g.ID
                                        JOIN department h ON g.Department_ID = h.ID
                                  WHERE h.Department = 'Elementary'")
        DgvElemGrading.DataSource = ds.Tables("QueryTb")
        DgvElemGrading.AutoGenerateColumns = False
    End Sub
    'Sub LoadRecords(ByVal sql As String)
    '    Dim i As Integer
    '    DgvElemGrading.Rows.Clear()

    '    'cmd = New mySqlCommand(sql, cn)
    '    dr = cmd.ExecuteReader

    '    While dr.Read
    '        i += 1
    '        'Dim formattedDate As String = DirectCast(dr.Item("Date"), DateTime).ToString("MMM-dd-yyyy")
    '        'Dim formattedTime As String = DirectCast(dr.Item("Time"), DateTime).ToString("hh:mm tt")

    '        'DgvElemGrading.Rows.Add(i, dr.Item("ID").ToString, dr.Item("User_Type").ToString, dr.Item("Username").ToString, dr.Item("Module").ToString, dr.Item("Description").ToString, formattedDate, formattedTime)
    '    End While
    'End Sub
    'Public Sub GetSubject()
    '    Query("SELECT * FROM section")
    '    CmbSubj.DataSource = ds.Tables("QueryTb")
    'End Sub

    'Private Sub BtnLoadSearch_Click(sender As Object, e As EventArgs) Handles BtnLoadSearch.Click
    '    Dim sql As String = "SELECT * FROM AuditTrail WHERE 1=1"

    '    'If CmbSubjCode.Value IsNot Nothing Then
    '    '    sql &= " AND SubjectCode = '" & CmbSubjCode.SelectedItem.ToString() & "'"
    '    'End If

    '    'If cmbModule.SelectedItem IsNot Nothing AndAlso cmbModule.SelectedItem.ToString() <> "All" Then
    '    '    sql &= " AND Module = '" & cmbModule.SelectedItem.ToString() & "'"
    '    'End If

    '    'If cmbUsertype.SelectedItem IsNot Nothing AndAlso cmbUsertype.SelectedItem.ToString() <> "All" Then
    '    '    sql &= " AND User_Type = '" & cmbUsertype.SelectedItem.ToString() & "'"
    '    'End If

    '    'If txtSearch.Text.Trim().Length > 0 Then
    '    '    sql &= " AND Description LIKE '%" & txtSearch.Text.Trim() & "%'"
    '    'End If

    '    LoadRecords(sql)
    'End Sub

    Private Sub DgvElemGrading_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvElemGrading.CellFormatting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 13 Then
            If TypeOf DgvElemGrading.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Is String Then
                Dim grade As String = CType(DgvElemGrading.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, String)

                If grade = "Failed" Then
                    For x As Integer = 0 To 13
                        DgvElemGrading.Rows(e.RowIndex).Cells(x).Style.BackColor = Color.Pink
                    Next
                ElseIf grade = "Passed" Then
                    For x As Integer = 0 To 13
                        DgvElemGrading.Rows(e.RowIndex).Cells(x).Style.BackColor = Color.Lavender
                    Next
                ElseIf grade = "No Grade" Then
                    For x As Integer = 0 To 13
                        DgvElemGrading.Rows(e.RowIndex).Cells(x).Style.BackColor = Color.LightCyan
                    Next
                End If
            End If
        End If
    End Sub
    'Private Sub DgvElemGrading_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvElemGrading.CellValueChanged
    '    If e.RowIndex >= 0 AndAlso e.RowIndex < DgvElemGrading.Rows.Count Then
    '        Dim totalScore As Integer = 0
    '        For Each row As DataGridViewRow In DgvElemGrading.Rows
    '            Dim c8 As Integer = DgvElemGrading.Rows(e.RowIndex).Cells("firstg").Value
    '            Dim c9 As Integer = DgvElemGrading.Rows(e.RowIndex).Cells("secondg").Value
    '            Dim c10 As Integer = DgvElemGrading.Rows(e.RowIndex).Cells("thirdg").Value
    '            Dim c11 As Integer = DgvElemGrading.Rows(e.RowIndex).Cells("fourthg").Value

    '            totalScore = c8 + c8 + c10 + c11
    '        Next
    '        Dim averageScore As Double = totalScore / 4

    '        DgvElemGrading.Rows(e.RowIndex).Cells("average").Value = averageScore '
    '        If averageScore >= 75 Then
    '            DgvElemGrading.Rows(e.RowIndex).Cells("remarks").Value = "Passed"
    '        Else
    '            DgvElemGrading.Rows(e.RowIndex).Cells("remarks").Value = "Failed"
    '        End If
    '    End If
    'End Sub
    'Private Sub DgvElemGrading_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DgvElemGrading.EditingControlShowing
    '    Dim columnIndex As Integer = DgvElemGrading.CurrentCell.ColumnIndex

    '    If columnIndex >= 8 AndAlso columnIndex <= 11 Then
    '        AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_KeyPress
    '    Else
    '        AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_KeyPress1
    '    End If
    'End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 40 To 58
            Case 8
            Case 46
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub TextBox_KeyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        ClassGrading.GradingRef(DgvElemGrading)
        LoadData()
    End Sub

    Private Sub DgvElemGrading_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvElemGrading.CellEndEdit
        Try
            Dim totalScore As Integer = 0
            Dim c8, c9, c10, c11 As Integer
            Integer.TryParse(DgvElemGrading.Rows(e.RowIndex).Cells("firstg").Value.ToString(), c8)
            Integer.TryParse(DgvElemGrading.Rows(e.RowIndex).Cells("secondg").Value.ToString(), c9)
            Integer.TryParse(DgvElemGrading.Rows(e.RowIndex).Cells("thirdg").Value.ToString(), c10)
            Integer.TryParse(DgvElemGrading.Rows(e.RowIndex).Cells("fourthg").Value.ToString(), c11)

            totalScore = c8 + c9 + c10 + c11
            Dim averageScore As Double = totalScore / 4

            DgvElemGrading.Rows(e.RowIndex).Cells("average").Value = averageScore

            If averageScore >= 75 Then
                DgvElemGrading.Rows(e.RowIndex).Cells("remarks").Value = "Passed"
            Else
                DgvElemGrading.Rows(e.RowIndex).Cells("remarks").Value = "Failed"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Query($"SELECT  a.ID,CONCAT(b.Start_Year, '-', b.End_Year) SY, d.EID, c.LRN, 
                                        CONCAT(c.Lastname, ', ', c.Firstname, ' ', c.MiddleInitial) Fullname, 
                                        f.SubjectCode, f.SubjectName, f.Units, a.FirstGrd, a.SecondGrd, a.ThirdGrd, a.FourthGrd, a.Average, a.Remarks
                                        FROM enrolled_sched a 
                                        JOIN schoolyear b ON a.SYID = b.ID
                                        JOIN student c ON a.LRN = c.LRN
                                        JOIN enrollment d ON c.LRN = d.LRN
                                        JOIN schedule e ON a.ScheduleID = e.ID
                                        JOIN subject f ON e.SubjectID = f.ID
                                        JOIN gradelevel g ON f.GradeLevel_ID = g.ID
                                        JOIN department h ON g.Department_ID = h.ID
                                  WHERE h.Department = 'Elementary' AND c.Lastname LIKE '{TxtSearch.Text}' OR c.Firstname LIKE '{TxtSearch.Text}' OR c.MiddleInitial LIKE '{TxtSearch.Text}'")
        DgvElemGrading.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim dt As New DataTable("DS_Grading")

        Dim StudentLRN As String = TxtLRN.Text.Trim()

        Dim adp = New MySqlDataAdapter("SELECT a.ID, CONCAT(b.Start_Year, '-', b.End_Year) SY, a.EID, c.LRN, 
                                        CONCAT(c.Lastname, ', ', c.Firstname) Fullname, e.SubjectCode as Code, 
                                        e.SubjectName as Subject, e.Units, a.FirstGrd as '1', a.SecondGrd as '2', a.ThirdGrd as '3', a.FourthGrd as '4',
                                        a.Average, a.Remarks, g.GradeLevel as Grade, f.SectionRoom as Section, c.Gender, CONCAT(h.Lastname, ', ', h.Firstname) Teacher
                                        FROM enrolled_sched a
                                        JOIN schoolyear b ON a.SYID = b.ID
                                        JOIN student c ON a.LRN = c.LRN
                                        JOIN schedule d ON a.ScheduleID = d.ID
                                        JOIN subject e ON d.SubjectID = e.ID
                                        JOIN section f ON d.SectionID = f.ID
                                        JOIN gradelevel g ON f.GradeLevel_ID = g.ID
                                        JOIN teacher h ON d.TeacherID = h.ID
                                        WHERE c.LRN = '" & StudentLRN & "'", con)

        adp.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim crystal As New ReportCard
            crystal.SetDataSource(dt)
            FrmGradeReport.CrystalReportViewer1.ReportSource = crystal
            FrmGradeReport.CrystalReportViewer1.Refresh()
            FrmGradeReport.Show()
        Else
            MessageBox.Show("No Records")
        End If
    End Sub


End Class