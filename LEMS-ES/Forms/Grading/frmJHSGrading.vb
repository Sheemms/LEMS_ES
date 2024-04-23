Public Class frmJHSGrading
    Private Sub FrmJHSGrading_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub LoadRecords()
        Query("SELECT * FROM subject")
        CmbSubjCode.DataSource = ds.Tables("QueryTb")
        CmbSubj.ValueMember = "ID"
        CmbSubj.DisplayMember = "Department"
    End Sub

    Private Sub DgvJHSGrading_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvJHSGrading.CellFormatting
        For i As Integer = 0 To dgvJHSGrading.Rows.Count - 1
            If dgvJHSGrading.Rows(i).Cells(11).Value = "Failed" Then
                For x As Integer = 0 To 6
                    dgvJHSGrading.Rows(i).Cells(x).Style.BackColor = Color.Pink
                Next
            End If

            If dgvJHSGrading.Rows(i).Cells(11).Value = "Passed" Then
                For x As Integer = 0 To 6
                    dgvJHSGrading.Rows(i).Cells(x).Style.BackColor = Color.Lavender
                Next
            End If

            If dgvJHSGrading.Rows(i).Cells(11).Value = "No Grade" Then
                For x As Integer = 0 To 6
                    dgvJHSGrading.Rows(i).Cells(x).Style.BackColor = Color.LightCyan
                Next
            End If
        Next
    End Sub

    Private Sub DgvJHSGrading_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJHSGrading.CellValueChanged
        On Error Resume Next
        Dim totalScore As Double = 0

        ' Sum up the values from cells (9) to (6)
        For i As Integer = 6 To 9 ' Assuming cell indices are from 6 to 9
            If dgvJHSGrading.Rows(e.RowIndex).Cells(i).Value IsNot Nothing AndAlso IsNumeric(dgvJHSGrading.Rows(e.RowIndex).Cells(i).Value) Then
                totalScore += Convert.ToDouble(dgvJHSGrading.Rows(e.RowIndex).Cells(i).Value)
            End If
        Next
        Dim averageScore As Double = totalScore / 4

        dgvJHSGrading.Rows(e.RowIndex).Cells(10).Value = averageScore
        If dgvJHSGrading.Rows(e.RowIndex).Cells(10).Value >= 75 Then
            dgvJHSGrading.Rows(e.RowIndex).Cells(11).Value = "Passed"
        End If
        If dgvJHSGrading.Rows(e.RowIndex).Cells(10).Value <= 74 Then
            dgvJHSGrading.Rows(e.RowIndex).Cells(11).Value = "Failed"
        End If
    End Sub
End Class