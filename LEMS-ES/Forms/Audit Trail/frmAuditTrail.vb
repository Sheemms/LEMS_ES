Public Class FrmAuditTrail
    Private Sub FrmAuditTrail_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub LoadAudittrail()
        Query("SELECT * FROM audittrail")
        DgvAudittrail.DataSource = ds.Tables("QueryTb")
    End Sub
    Sub Load_usertype()
        ToolStripComboBox1.Items.Clear()
        ToolStripComboBox1.Items.Add("All")
        OtherCommand("SELECT DISTINCT b.UserLevel 
                        FROM audittrail a
                        JOIN user b ON a.UserID = b.ID")
        dr = cmd.ExecuteReader
        While dr.Read
            ToolStripComboBox1.Items.Add(dr.Item("UserLevel").ToString)
        End While
        dr.Close()
    End Sub
    Private Sub Load_records(ByVal sql As String)
        Dim i As Integer
        DgvAudittrail.Rows.Clear()


        OtherCommand("SELECT a.ID, a.UserID, b.UserLevel, b.Fullname, a.Description, a.Time 
                        FROM audittrail a
                        JOIN user b ON a.UserID = b.ID")
        dr = cmd.ExecuteReader

        While dr.Read
            i += 1

            Dim formattedTime As String = DirectCast(dr.Item("Time"), DateTime).ToString("hh:mm tt")

            DgvAudittrail.Rows.Add(i, dr.Item("ID").ToString, dr.Item("UserID").ToString, dr.Item("UserLevel").ToString, dr.Item("Fullname").ToString, dr.Item("Description").ToString, formattedTime)
        End While
        dr.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) 

    End Sub


    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If IS_EMPTY(ToolStripComboBox1) = True Then Return


        load_records("SELECT * FROM audittrail")

        If ToolStripComboBox1.Text = "All" And TxtSearch.Text = String.Empty Then
            load_records("Select * from audittrail")
        ElseIf ToolStripComboBox1.Text = "All" And TxtSearch.Text.Length > 0 Then
            load_records("Select * from audittrail where UserLevel  like '%" & TxtSearch.Text & "%'")
        ElseIf ToolStripComboBox1.Text <> "All" And TxtSearch.Text.Length = 0 Then
            load_records("Select * from audittrail where UserLevel  like '" & ToolStripComboBox1.Text & "'")

        ElseIf ToolStripComboBox1.Text <> "All" And TxtSearch.Text.Length > 0 Then
            load_records("Select * from audittrail where UserLevel like '" & ToolStripComboBox1.Text & "' and Description like '%" & TxtSearch.Text & "%'")
        ElseIf ToolStripComboBox1.Text = "All" And TxtSearch.Text.Length > 0 Then
            load_records("Select * from audittrail where UserLevel like '%" & TxtSearch.Text & "%'")

        ElseIf ToolStripComboBox1.Text <> "All" And TxtSearch.Text.Length = 0 Then
            load_records("Select * from audittrail where UserLevel like '" & ToolStripComboBox1.Text & "'")
        ElseIf ToolStripComboBox1.Text <> "All" And TxtSearch.Text.Length > 0 Then
            load_records("Select * from audittrail where UserLevel like '" & ToolStripComboBox1.Text & "' and Description like '%" & TxtSearch.Text & "%'")
        End If
    End Sub
End Class