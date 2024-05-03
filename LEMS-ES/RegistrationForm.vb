Public Class RegistrationForm
    Public idUserMaintenance As Integer = 0
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ClassUserMaintenance.UserAdminRef()
        Login.Show()
        Me.Close()
        Clear()
    End Sub
    Public Sub Clear()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {txtUsername, txtPassword, txtRePassword, txtFullname}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        idUserMaintenance = 0
    End Sub
    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Clear()
    End Sub
End Class