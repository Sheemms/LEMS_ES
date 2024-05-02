Public Class RegistrationForm
    Public idUserMaintenance As Integer = 0
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ClassUserMaintenance.UserAdminRef()
        Login.Show()
        Me.Close()
        ClearFields(Me, idUserMaintenance)
    End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class