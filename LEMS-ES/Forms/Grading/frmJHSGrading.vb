Public Class FrmJHSGrading
    Private Sub FrmJHSGrading_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub LoadGrades()
        Dim _LRN As String = Convert.ToInt32(dgvJHSGrading.SelectedRows(0).Cells(1).Value)
        Query("SELECT  CONCAT(b.Start_Year, '-', b.End_Year) SY, d.EID, c.LRN, 
                CONCAT(c.Lastname, ', ', c.Firstname, ' ', c.MiddleInitial) Fullname, 
                f.SubjectCode, f.SubjectName, f.Units, a.Average, a.Remarks
                FROM enrolled_sched a 
                JOIN schoolyear b ON a.SYID = b.ID
                JOIN student c ON a.LRN = c.LRN
                JOIN enrollment d ON c.LRN = d.LRN
                JOIN schedule e ON a.ScheduleID = e.ID
                JOIN subject f ON e.Subj_ID = f.ID
                WHERE a.LRN = '"& _LRN &"'")
        dgvJHSGrading.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub LoadRecords()
        'Query("SELECT * FROM subject")
        'CmbSubject.DataSource = ds.Tables("QueryTb")
        'CmbSubject.ValueMember = "ID"
        'CmbSubject.DisplayMember = "Department"
    End Sub

    Private Sub DgvJHSGrading_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvJHSGrading.CellFormatting
        For i As Integer = 0 To dgvJHSGrading.Rows.Count - 1
            If dgvJHSGrading.Rows(i).Cells(11).Value = "Failed" Then
                For x As Integer = 0 To 11
                    dgvJHSGrading.Rows(i).Cells(x).Style.BackColor = Color.Pink
                Next
            End If

            If dgvJHSGrading.Rows(i).Cells(11).Value = "Passed" Then
                For x As Integer = 0 To 11
                    dgvJHSGrading.Rows(i).Cells(x).Style.BackColor = Color.Lavender
                Next
            End If

            If dgvJHSGrading.Rows(i).Cells(11).Value = "No Grade" Then
                For x As Integer = 0 To 11
                    dgvJHSGrading.Rows(i).Cells(x).Style.BackColor = Color.LightCyan
                Next
            End If
        Next
    End Sub

    Private Sub DgvJHSGrading_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJHSGrading.CellValueChanged
        'Dim totalScore As Double = 0

        'For i As Integer = 6 To 9
        '    If dgvJHSGrading.Rows(e.RowIndex).Cells(i).Value IsNot Nothing AndAlso IsNumeric(dgvJHSGrading.Rows(e.RowIndex).Cells(i).Value) Then
        '        totalScore += Convert.ToDouble(dgvJHSGrading.Rows(e.RowIndex).Cells(i).Value)
        '    End If
        'Next
        'Dim averageScore As Double = totalScore / 4

        'dgvJHSGrading.Rows(e.RowIndex).Cells(10).Value = averageScore
        'If dgvJHSGrading.Rows(e.RowIndex).Cells(10).Value >= 75 Then
        '    dgvJHSGrading.Rows(e.RowIndex).Cells(11).Value = "Passed"
        'End If
        'If dgvJHSGrading.Rows(e.RowIndex).Cells(10).Value <= 74 Then
        '    dgvJHSGrading.Rows(e.RowIndex).Cells(11).Value = "Failed"
        'End If
    End Sub
End Class