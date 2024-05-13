Public Class RegistrationForm
    Public idUserMaintenance As Integer = 0
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IS_EMPTY(txtUsername) = True Then Return
        If IS_EMPTY(txtPassword) = True Then Return
        If IS_EMPTY(txtFullname) = True Then Return
        If IS_EMPTY(TxtContact) = True Then Return

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