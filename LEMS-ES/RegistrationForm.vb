Public Class RegistrationForm
    Public idUserMaintenance As Integer = 0
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
#Region "IsEmptyField"
        If Not IsEmptyField(txtUsername.Text.Trim()) Then
            MsgBox("Please enter a username.")
            Return
        End If
        If Not IsEmptyField(txtPassword.Text.Trim()) Then
            MsgBox("Please enter a password.")
            Return
        End If
        If Not IsEmptyField(txtFullname.Text.Trim()) Then
            MsgBox("Please enter a fullname.")
            Return
        End If
        If Not IsEmptyField(TxtContact.Text.Trim()) Then
            MsgBox("Please enter a contact.")
            Return
        End If

        If txtPassword.Text <> txtRePassword.Text Then
            Critical("Password not match.")
            Return
        End If
#End Region
        If Not NoLeadingSpace(txtUsername.Text.Trim()) Then
            MsgBox("Username must have no leading spaces.")
            Return
        ElseIf Not NoLeadingSpace(txtFullname.Text.Trim()) Then
            MsgBox("Fullname must have no leading spaces.")
            Return
        End If

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