﻿Imports MySql.Data.MySqlClient
Public Class FrmJHSGrading
    Private Sub FrmJHSGrading_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadData()
        LoadSubjectCode()
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
                                        JOIN subject f ON e.SubjectID = f.ID
                                        JOIN gradelevel g ON f.GradeLevel_ID = g.ID
                                        JOIN department h ON g.Department_ID = h.ID
                                  WHERE h.Department = 'Junior Highschool'")
        DgvJHSGrading.DataSource = ds.Tables("QueryTb")
        DgvJHSGrading.AutoGenerateColumns = False
    End Sub
    Public Sub LoadSubjectCode()
        Query("SELECT a.ID, a.SubjectCode, a.SubjectName, a.Units
                FROM subject a
                JOIN gradelevel b ON a.GradeLevel_ID = b.ID
                JOIN department c ON b.Department_ID = c.ID
                WHERE c.Department = 'Junior High School'")
        CmbSubjCode.ComboBox.DataSource = ds.Tables("QueryTb")
        CmbSubjCode.ComboBox.ValueMember = "ID"
        CmbSubjCode.ComboBox.DisplayMember = "SubjectCode"
        CmbSubjCode.ComboBox.SelectedIndex = -1
    End Sub
    Public Sub LoadRecords()
        'Query("SELECT * FROM subject")
        'CmbSubject.DataSource = ds.Tables("QueryTb")
        'CmbSubject.ValueMember = "ID"
        'CmbSubject.DisplayMember = "Department"
    End Sub

    Private Sub DgvJHSGrading_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 13 Then
            If TypeOf DgvJHSGrading.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Is String Then
                Dim grade As String = CType(DgvJHSGrading.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, String)

                If grade = "Failed" Then
                    For x As Integer = 0 To 13
                        DgvJHSGrading.Rows(e.RowIndex).Cells(x).Style.BackColor = Color.Pink
                    Next
                ElseIf grade = "Passed" Then
                    For x As Integer = 0 To 13
                        DgvJHSGrading.Rows(e.RowIndex).Cells(x).Style.BackColor = Color.Lavender
                    Next
                ElseIf grade = "No Grade" Then
                    For x As Integer = 0 To 13
                        DgvJHSGrading.Rows(e.RowIndex).Cells(x).Style.BackColor = Color.LightCyan
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub DgvJHSGrading_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvJHSGrading.CellEndEdit
        Try

            Dim totalScore As Integer = 0
            Dim c8 As Integer = If(String.IsNullOrWhiteSpace(DgvJHSGrading.Rows(e.RowIndex).Cells("firstg").Value), "0", DgvJHSGrading.Rows(e.RowIndex).Cells("firstg").Value)
            Dim c9 As Integer = If(String.IsNullOrWhiteSpace(DgvJHSGrading.Rows(e.RowIndex).Cells("secondg").Value), "0", DgvJHSGrading.Rows(e.RowIndex).Cells("secondg").Value)
            Dim c10 As Integer = If(String.IsNullOrWhiteSpace(DgvJHSGrading.Rows(e.RowIndex).Cells("thirdg").Value), "0", DgvJHSGrading.Rows(e.RowIndex).Cells("thirdg").Value)
            Dim c11 As Integer = If(String.IsNullOrWhiteSpace(DgvJHSGrading.Rows(e.RowIndex).Cells("fourthg").Value), "0", DgvJHSGrading.Rows(e.RowIndex).Cells("fourthg").Value)
            totalScore = c8 + c9 + c10 + c11
            Dim averageScore As Double = totalScore / 4

            DgvJHSGrading.Rows(e.RowIndex).Cells("average").Value = averageScore '
            If averageScore >= 75 Then
                DgvJHSGrading.Rows(e.RowIndex).Cells("remarks").Value = "Passed"
            Else
                DgvJHSGrading.Rows(e.RowIndex).Cells("remarks").Value = "Failed"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            DgvJHSGrading.DataSource = ds.Tables("QueryTb")

        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ClassGrading.GradingRef(DgvJHSGrading)
        LoadData()
    End Sub
End Class