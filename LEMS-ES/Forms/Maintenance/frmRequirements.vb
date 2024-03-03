Public Class frmRequirements
    Public idRequirements As Integer = 0
    Private Sub frmRequirements_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()

    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM requirements")
        dgvSY.DataSource = ds.Tables("QueryTb")


    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IS_EMPTY(txtRequirements) = True Then Return

        'ClassRequirements
    End Sub

End Class