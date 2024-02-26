Public Class frmEnrollment
    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM Enrollment")
        dgvSY.DataSource = ds.Tables("QueryTb")
    End Sub

End Class