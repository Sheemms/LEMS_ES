Public Class frmElementaryGrading
    Private Sub frmElementaryGrading_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub GetSubject()
        Query("SELECT * FROM section")

    End Sub
End Class