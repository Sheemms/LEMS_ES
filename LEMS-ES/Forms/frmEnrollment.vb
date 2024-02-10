Public Class frmEnrollment
    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
    End Sub
    Public Sub Clear()
        txtStudNo.Clear()
        txtAge.Clear()
        dtpBday.Value = ""
        txtStudentContact.Clear()
    End Sub

    Private Sub btnSaveEnrollment_Click(sender As Object, e As EventArgs) Handles btnSaveEnrollment.Click

    End Sub

    Private Sub btnClearSY_Click(sender As Object, e As EventArgs) Handles btnClearSY.Click

    End Sub

End Class