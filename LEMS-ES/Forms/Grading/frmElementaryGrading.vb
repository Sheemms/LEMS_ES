Public Class FrmElementaryGrading
    'Private Sub FrmElementaryGrading_Load(sender As Object, e As EventArgs) Handles Me.Load

    'End Sub
    'Public Sub LoadData()
    '    Query("SELECT * FROM enrollment")
    'End Sub
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

    'Private Sub DgvElemGrading_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvElemGrading.CellFormatting
    '    For i As Integer = 0 To DgvElemGrading.Rows.Count - 1
    '        If DgvElemGrading.Rows(i).Cells(11).Value = "Failed" Then
    '            For x As Integer = 0 To 6
    '                DgvElemGrading.Rows(i).Cells(x).Style.BackColor = Color.Pink
    '            Next
    '        End If

    '        If DgvElemGrading.Rows(i).Cells(11).Value = "Passed" Then
    '            For x As Integer = 0 To 6
    '                DgvElemGrading.Rows(i).Cells(x).Style.BackColor = Color.Lavender
    '            Next
    '        End If

    '        If DgvElemGrading.Rows(i).Cells(11).Value = "No Grade" Then
    '            For x As Integer = 0 To 6
    '                DgvElemGrading.Rows(i).Cells(x).Style.BackColor = Color.LightCyan
    '            Next
    '        End If
    '    Next
    'End Sub

    'Private Sub DgvElemGrading_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvElemGrading.CellValueChanged
    '    On Error Resume Next
    '    If DgvElemGrading.Rows(e.RowIndex).Cells(10).Value <= 3 Then
    '        DgvElemGrading.Rows(e.RowIndex).Cells(11).Value = "Passed"
    '    End If
    '    If DgvElemGrading.Rows(e.RowIndex).Cells(10).Value = 5 Then
    '        DgvElemGrading.Rows(e.RowIndex).Cells(11).Value = "Failed"
    '    End If
    'End Sub
End Class