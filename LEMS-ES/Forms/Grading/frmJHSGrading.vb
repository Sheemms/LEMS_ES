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

    Private Sub DgvJHSGrading_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
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

End Class