Public Class frmSubjects
    Dim id As String = ""
    Public Sub loadrecords()
        Query("SELECT * FROM subject")
        dgvSubject.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        txtSubjCode.Clear()
        txtSubjName.Clear()
    End Sub
    Public Sub Parameters()
        cmd.Parameters.AddWithValue("SubjectCode", txtSubjCode.Text)
        cmd.Parameters.AddWithValue("SubjectName", txtSubjName.Text)
    End Sub
    Private Sub btnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click
        If IS_EMPTY(txtSubjCode) = True Then Return
        If IS_EMPTY(txtSubjName) = True Then Return


        Query("SELECT * FROM subject WHERE SubjectCode= '" & txtSubjCode.Text & "' and ID <> '" & id & "'")
        If ds.Tables("QueryTb").Rows.Count > 0 Then
            Critical("Subject already exist")
            Exit Sub
        End If

        Command("INSERT INTO subject (SubjectCode, SubjectName) VALUES (@SubjectCode, @SubjectName)")
        Parameters()
        cmd.ExecuteNonQuery()
        Success("Successfully Added!")
        clear()
    End Sub

    Private Sub frmSubjects_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub

    Private Sub btnClearSubject_Click(sender As Object, e As EventArgs) Handles btnClearSubject.Click
        clear()
    End Sub

    Private Sub btnUpdateSubject_Click(sender As Object, e As EventArgs) Handles btnUpdateSubject.Click
        If IS_EMPTY(txtSubjCode) = True Then Return
        If IS_EMPTY(txtSubjName) = True Then Return


        Query("SELECT * FROM subject WHERE SubjectCode= '" & txtSubjCode.Text & "' and ID <> '" & id & "'")
        If ds.Tables("QueryTb").Rows.Count > 0 Then
            Critical("Subject already exist")
            Exit Sub
        End If

        Command("UPDATE subject SET SubjectCode=@SubjectCode, SubjectName=@SubjectName WHERE ID = '" & id & "'")
        Parameters()
        cmd.ExecuteNonQuery()
        Success("Successfully Added!")
        clear()
    End Sub

    Private Sub dgvSubject_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubject.CellClick
        Try
            For Each row As DataGridViewRow In dgvSubject.SelectedRows
                id = row.Cells(0).Value
                txtSubjCode.Text = row.Cells(1).Value
                txtSubjName.Text = row.Cells(2).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try

    End Sub
End Class