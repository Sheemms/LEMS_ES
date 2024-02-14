Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
    End Sub
    Public Sub ValidateInput(ByVal control As Control, ByVal errorMessage As String)
        If control Is Nothing Then
            Throw New ArgumentNullException("control", "Control cannot be null.")
        End If

        If String.IsNullOrWhiteSpace(errorMessage) Then
            Throw New ArgumentException("Error message cannot be null or empty.", "errorMessage")
        End If

        If String.IsNullOrWhiteSpace(control.Text) Then
            ErrorProvider1.SetError(control, errorMessage)
        Else
            ErrorProvider1.SetError(control, "")
        End If
    End Sub

    Private Sub TextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsername.Validating, txtPassword.Validating
        ValidateInput(CType(sender, Control), "Please enter a value")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ValidateInput(txtUsername, "Please enter a username")
        ValidateInput(txtPassword, "Please enter a password")

        If ValidateChildren() Then
            Query("SELECT * FROM user WHERE Username = '" & txtUsername.Text & "' and Password = '" & txtPassword.Text & "'")
            If ds.Tables("QueryTb").Rows.Count > 0 Then
                Success("Login success!")
                frmDashboard.Show()
                Me.Close()
                Exit Sub
            End If
        Else
            Critical("Enter the correct Username or Password!")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        Application.Exit()
    End Sub
End Class