Public Class frmSections
    Private Sub frmSections_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        SectionDisplay(dgvSection)
    End Sub

    Private Sub btnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click

    End Sub

    Private Sub btnUpdateSubject_Click(sender As Object, e As EventArgs) Handles btnUpdateSubject.Click

    End Sub

    Private Sub btnClearSubject_Click(sender As Object, e As EventArgs) Handles btnClearSubject.Click

    End Sub
End Class