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

#Region "TextValidation"
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullname.KeyPress
        If Not IsValidInput(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContact.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
#End Region
End Class