Public Class frmStudents
    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        '
        loadrecords()
    End Sub
    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        frmStudentRegistration.Show()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM student")
        dgvStudents.DataSource = ds.Tables("QueryTb")
    End Sub

End Class