Public Class frmSections
    Private Sub frmSections_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        SectionDisplay(dgvSection)
    End Sub
End Class