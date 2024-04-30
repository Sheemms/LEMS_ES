﻿Imports MySql.Data.MySqlClient
Public Class FrmElementaryGrading
    Private Sub CmbSubjCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSubjCode.SelectedIndexChanged
        'Dim selectedSubjectCode As String = CmbSubjCode.SelectedItem.ToString()

        'Query("SELECT * FROM subject WHERE SubjectCode = '" & selectedSubjectCode & "'")
        'DgvElemGrading.DataSource = ds.Tables("QueryTb")
        'CmbSubjCode.ComboBox.ValueMember = "ID"
        'CmbSubjCode.ComboBox.DisplayMember = "SubjectCode"
    End Sub

    Private Sub FrmElementaryGrading_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadData()
    End Sub
    Public Sub LoadSubject()
        Query("SELECT * FROM subject")
        DgvElemGrading.DataSource = ds.Tables("QueryTb")
        CmbSubjCode.ComboBox.ValueMember = "ID"
        CmbSubjCode.ComboBox.DisplayMember = "SubjectCode"
    End Sub
    Public Sub LoadData()
        Query("SELECT  a.ID,CONCAT(b.Start_Year, '-', b.End_Year) SY, d.EID, c.LRN, 
                CONCAT(c.Lastname, ', ', c.Firstname, ' ', c.MiddleInitial) Fullname, 
                f.SubjectCode, f.SubjectName, f.Units, a.FirstGrd, a.SecondGrd, a.ThirdGrd, a.FourthGrd, a.Average, a.Remarks
                FROM enrolled_sched a 
                JOIN schoolyear b ON a.SYID = b.ID
                JOIN student c ON a.LRN = c.LRN
                JOIN enrollment d ON c.LRN = d.LRN
                JOIN schedule e ON a.ScheduleID = e.ID
                JOIN subject f ON e.Subj_ID = f.ID")
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
            Dim c8 As Integer = If(String.IsNullOrWhiteSpace(DgvElemGrading.Rows(e.RowIndex).Cells("firstg").Value), "0", DgvElemGrading.Rows(e.RowIndex).Cells("firstg").Value)
            Dim c9 As Integer = If(String.IsNullOrWhiteSpace(DgvElemGrading.Rows(e.RowIndex).Cells("secondg").Value), "0", DgvElemGrading.Rows(e.RowIndex).Cells("secondg").Value)
            Dim c10 As Integer = If(String.IsNullOrWhiteSpace(DgvElemGrading.Rows(e.RowIndex).Cells("thirdg").Value), "0", DgvElemGrading.Rows(e.RowIndex).Cells("thirdg").Value)
            Dim c11 As Integer = If(String.IsNullOrWhiteSpace(DgvElemGrading.Rows(e.RowIndex).Cells("fourthg").Value), "0", DgvElemGrading.Rows(e.RowIndex).Cells("fourthg").Value)
            totalScore = c8 + c9 + c10 + c11
            Dim averageScore As Double = totalScore / 4

            DgvElemGrading.Rows(e.RowIndex).Cells("average").Value = averageScore '
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
                JOIN subject f ON e.Subj_ID = f.ID
               WHERE c.Lastname LIKE '{TxtSearch.Text}' OR c.Firstname LIKE '{TxtSearch.Text}' OR c.MiddleInitial LIKE '{TxtSearch.Text}'")
        DgvElemGrading.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim dt As New DataTable("DS_Grading")

        For Each row As DataGridViewRow In DgvElemGrading.Rows
            Dim StudentLRN As String = row.Cells("colLRN").Value
            Dim adp = New MySqlDataAdapter("SELECT a.ID, CONCAT(b.Start_Year, '-', b.End_Year) SY, a.EID, c.LRN, 
                                            CONCAT(c.Lastname, ', ', c.Firstname) Fullname, e.SubjectCode as Code, 
                                            e.SubjectName as Subject, e.Units, a.FirstGrd as '1', a.SecondGrd as '2', a.ThirdGrd as '3', a.FourthGrd as '4',
                                            a.Average, a.Remarks, f.GradeLevel as Grade, g.SectionRoom as Section, c.Gender, CONCAT(h.Lastname, ', ', h.Firstname) Teacher
                                            FROM enrolled_sched a
                                            JOIN schoolyear b ON a.SYID = b.ID
                                            JOIN student c ON a.LRN = c.LRN
                                            JOIN schedule d ON a.ScheduleID = d.ID
                                            JOIN subject e ON d.Subj_ID = e.ID
                                            JOIN gradelevel f ON d.GradeLevel_ID = f.ID
                                            JOIN section g ON d.Sec_ID = g.ID
                                            JOIN teacher h ON d.Teacher_ID = h.ID
                                            WHERE c.LRN = " & StudentLRN, con)

            adp.Fill(dt)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Records")
                Exit Sub
            End If
        Next
        Dim crystal As New ReportCard
        crystal.SetDataSource(dt)
        FrmGradeReport.CrystalReportViewer1.ReportSource = crystal
        FrmGradeReport.CrystalReportViewer1.Refresh()
        FrmGradeReport.Show()
    End Sub
End Class