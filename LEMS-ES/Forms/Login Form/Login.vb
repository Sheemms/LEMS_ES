Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
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
        'ValidateInput(txtUsername, "Please enter a username")
        'ValidateInput(txtPassword, "Please enter a password")

        '    Try
        '        If Not String.IsNullOrEmpty(ErrorProvider1.GetError(txtUsername)) OrElse Not String.IsNullOrEmpty(ErrorProvider1.GetError(txtPassword)) Then
        '            Clear()
        '            Critical("Error: Username and password cannot be empty")
        '            Exit Sub
        '        End If

        '        Query("SELECT * FROM user WHERE BINARY Username = @Username AND BINARY Password = @Password")

        '        Dim dt As DataTable = ds.Tables("QueryTb")
        '        If dt.Rows.Count > 0 Then
        '            For Each row As DataRow In dt.Rows
        '                userID = Convert.ToInt32(row("ID"))
        '                str_user = row("Username").ToString
        '                str_password = row("Password").ToString
        '                str_role = row("UserLevel").ToString
        '                str_name = row("Fullname").ToString
        '            Next
        '            With frmDashboard
        '                .btnDashboard.Enabled = True
        '                .btnTransaction.Enabled = (str_role = "Admin" OrElse str_role = "Office Staff")
        '                .btnDataEntry.Enabled = (str_role = "Admin" OrElse str_role = "Office Staff")
        '                .btnGrading.Enabled = True
        '                .btnMaintenance.Enabled = (str_role = "Admin")
        '                .btnReports.Enabled = (str_role = "Admin" OrElse str_role = "Office Staff")
        '                .BtnSystemUtilities.Enabled = (str_role = "Admin")
        '                .Label3.Text = str_name
        '                .Label4.Text = str_role
        '                Clear()
        '                Me.Hide()
        '                .Show()
        '            End With
        '        Else
        '            Clear()
        '            Critical("Wrong Username or Password!")
        '        End If
        '    Catch ex As MySqlException When ex.Number = 1062
        '        Critical("Subject already added to this student.")
        '    Catch ex As Exception
        '        MsgBox("Database error: " & ex.Message)
        '    End Try

        ValidateInput(txtUsername, "Please enter a username")
        ValidateInput(txtPassword, "Please enter a password")
        Try
            If ErrorProvider1.GetError(txtUsername) = "" AndAlso ErrorProvider1.GetError(txtPassword) = "" Then
                Query("SELECT * FROM user WHERE BINARY Username = '" & txtUsername.Text & "' and BINARY Password = '" & txtPassword.Text & "'")
                If ds.Tables("QueryTb").Rows.Count > 0 Then
                    userID = Convert.ToInt32(ds.Tables("QueryTb").Rows(0)("ID"))
                    Success("Login success!")
                    FrmDashboard.Show()
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