Public Class FrmElementaryGrading
    Private Sub CmbSubjCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSubjCode.SelectedIndexChanged
        'Dim selectedSubjectCode As String = CmbSubjCode.SelectedItem.ToString()

        'Query("SELECT * FROM subject WHERE SubjectCode = '" & selectedSubjectCode & "'")
        'DgvElemGrading.DataSource = ds.Tables("QueryTb")
        'CmbSubjCode.ComboBox.ValueMember = "ID"
        'CmbSubjCode.ComboBox.DisplayMember = "SubjectCode"
    End Sub

    Private Sub FrmElementaryGrading_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
    Public Sub LoadSubject()
        Query("SELECT * FROM subject")
        DgvElemGrading.DataSource = ds.Tables("QueryTb")
        CmbSubjCode.ComboBox.ValueMember = "ID"
        CmbSubjCode.ComboBox.DisplayMember = "SubjectCode"
    End Sub
    Public Sub LoadData()
        Query("SELECT  CONCAT(b.Start_Year, '-', b.End_Year) SY, d.EID, c.LRN, 
                CONCAT(c.Lastname, ', ', c.Firstname, ' ', c.MiddleInitial) Fullname, 
                f.SubjectCode, f.SubjectName, f.Units, a.Average, a.Remarks
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
    Private Sub DgvElemGrading_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvElemGrading.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.RowIndex < DgvElemGrading.Rows.Count Then
            Dim totalScore As Double = 0
            For i As Integer = 8 To 11
                If DgvElemGrading.Rows(e.RowIndex).Cells(i).Value IsNot Nothing AndAlso IsNumeric(DgvElemGrading.Rows(e.RowIndex).Cells(i).Value) Then
                    totalScore += Convert.ToDouble(DgvElemGrading.Rows(e.RowIndex).Cells(i).Value)
                End If
            Next
            Dim averageScore As Double = totalScore / 4

            DgvElemGrading.Rows(e.RowIndex).Cells(12).Value = averageScore '
            If averageScore >= 75 Then
                DgvElemGrading.Rows(e.RowIndex).Cells(13).Value = "Passed"
            Else
                DgvElemGrading.Rows(e.RowIndex).Cells(13).Value = "Failed"
            End If
        End If
    End Sub
    Private Sub DgvElemGrading_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DgvElemGrading.EditingControlShowing
        'Dim columnIndex As Integer = DgvElemGrading.CurrentCell.ColumnIndex

        'If columnIndex = 11 Then
        '    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_KeyPress
        'Else
        '    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_KeyPress1
        'End If
    End Sub

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
        Dim rowIndex As Integer = DgvElemGrading.CurrentRow.Index

        ClassGrading.GradingRef(DgvElemGrading, rowIndex)
        LoadData()
    End Sub
End Class