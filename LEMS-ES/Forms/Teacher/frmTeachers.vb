Public Class frmTeachers
    Private Sub frmTeachers_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        frmTeacherMaintenance.Show()
    End Sub
End Class