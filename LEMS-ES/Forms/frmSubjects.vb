Public Class frmSubjects
    Dim id As String = ""
    Public Sub loadrecords()
        Query("SELECT * FROM subject")
        dgvSY.DataSource = ds.Tables("QueryTb")
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

        Command("INSERT INTO subject (SubjectCode, SubjectName, TeacherID, SectionID, Date) VALUES (@SubjectCode, @SubjectName, @TeacherID, @SectionID, @Date)")
        Parameters()
        cmd.ExecuteNonQuery()
        Success("Successfully Added!")
        clear()
    End Sub

    Private Sub frmSubjects_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
End Class