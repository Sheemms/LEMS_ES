Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub
    Public Sub Clear()
        txtUsername.Clear()
        txtPassword.Clear()
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

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ValidateInput(txtUsername, "Please enter a username")
        ValidateInput(txtPassword, "Please enter a password")


        Try
            If ErrorProvider1.GetError(txtUsername) = "" AndAlso ErrorProvider1.GetError(txtPassword) = "" Then
                Query("SELECT * FROM user WHERE BINARY Username = '" & txtUsername.Text & "' and BINARY Password = '" & txtPassword.Text & "'")
                If ds.Tables("QueryTb").Rows.Count > 0 Then
                    userID = Convert.ToInt32(ds.Tables("QueryTb").Rows(0)("ID"))
                    Success("Login success!")
                    frmDashboard.Show()
                    Clear()
                    'LogAction("Logged in")
                    Me.Hide()
                    Exit Sub
                Else
                    Clear()
                    Critical("Wrong Username or Password!")
                End If

                'Command("SELECT * FROM user")
                'dr = cmd.ExecuteReader
                'While dr.Read
                '    If txtUsername.Text = dr.Item("Username").ToString And txtPassword.Text = DecryptData(dr.Item("Password").ToString) Then
                '        Success("Login success!")
                '        frmDashboard.Show()
                '        clear()
                '        Me.Hide()
                '        Exit Sub
                '    Else
                '        Critical("Wrong Username or Password!")
                '    End If
                'End While
                'dr.Close()
            Else
                Clear()
                Critical("Error Login cannot be Null or Empty")
            End If
        Catch ex As Exception
            Clear()
            MsgBox("You are not connected to the database, Please connect first!")
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub CbShow_CheckedChanged(sender As Object, e As EventArgs) Handles cbShow.CheckedChanged
        If cbShow.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 48, 57, 56, 55, 54, 53, 52, 51, 50, 49, 48, 65 To 90, 97 To 122
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown, txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        FormDatabase.Show()
    End Sub
End Class