Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Connection()
            Query("SELECT * FROM user")
            If ds.Tables("QueryTb").Rows.Count = 0 Then
                MsgBox("No Admin Registered Yet.")
                RegistrationForm.Show()
                Me.Close()
            End If
        Catch ex As MySqlException

        End Try
    End Sub
    Public Sub Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
    Public Sub ValidateInput(ByVal control As Control, ByVal errorMessage As String)
        Try
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
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub

    Private Sub TextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsername.Validating, txtPassword.Validating
        ValidateInput(CType(sender, Control), "Please enter a value")
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ValidateInput(txtUsername, "Please enter a username")
        ValidateInput(txtPassword, "Please enter a password")

        Try
            If Not String.IsNullOrEmpty(ErrorProvider1.GetError(txtUsername)) OrElse Not String.IsNullOrEmpty(ErrorProvider1.GetError(txtPassword)) Then
                Critical("Error: Username and password cannot be empty")
                Exit Sub
            End If

            Query("SELECT * FROM user WHERE BINARY Username = '" & txtUsername.Text.Trim & "' AND BINARY Password = '" & txtPassword.Text.Trim & "'")

            If ds.Tables("QueryTb").Rows.Count > 0 Then
                userID = ds.Tables("QueryTB").Rows(0)("ID")
                str_user = ds.Tables("QueryTB").Rows(0)("Username")
                str_password = ds.Tables("QueryTB").Rows(0)("Password")
                str_role = ds.Tables("QueryTB").Rows(0)("UserLevel")
                str_name = ds.Tables("QueryTB").Rows(0)("Fullname")



                With FrmDashboard
                    If str_role = "Administrator" Then
                        .btnDashboard.Enabled = True
                        .btnTransaction.Enabled = True
                        .btnDataEntry.Enabled = True
                        .btnGrading.Enabled = True
                        .btnMaintenance.Enabled = True
                        .btnReports.Enabled = True
                        .BtnSystemUtilities.Enabled = True
                    ElseIf str_role = "Office Staff" Then
                        .btnDashboard.Enabled = True
                        .btnTransaction.Enabled = False
                        .btnDataEntry.Enabled = True
                        .btnGrading.Enabled = True
                        .btnMaintenance.Enabled = False
                        .btnReports.Enabled = True
                        .BtnSystemUtilities.Enabled = False
                    Else
                        .btnDashboard.Enabled = False
                        .btnTransaction.Enabled = False
                        .btnDataEntry.Enabled = False
                        .btnGrading.Enabled = True
                        .btnMaintenance.Enabled = False
                        .btnReports.Enabled = False
                        .BtnSystemUtilities.Enabled = False
                    End If
                    .IDuser = userID
                    .Label3.Text = str_name
                    .Label4.Text = str_role
                    txtUsername.Clear()
                    txtPassword.Clear()
                    Me.Hide()
                    .Show()
                End With

                LogAction("Logged in")
            Else
                MsgBox("Wrong Credentials, Invalid Username or Password", vbExclamation)
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
        Try
            If cbShow.Checked Then
                txtPassword.PasswordChar = ""
            Else
                txtPassword.PasswordChar = "*"
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
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
            BtnLogin_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        FormDatabase.Show()
    End Sub
End Class