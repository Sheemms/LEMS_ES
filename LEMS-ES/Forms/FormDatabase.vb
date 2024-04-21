Public Class FormDatabase
    Private Sub FormDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            My.Settings.Dbase = txtdatabase.Text
            My.Settings.Server_Name = txtIPAdd.Text
            My.Settings.Username = txtUsername.Text
            My.Settings.Password = txtPassword.Text

            My.Settings.Conn_String = "server=" & txtIPAdd.Text & ";user id=" & txtUsername.Text & ";password=" & txtPassword.Text & ";database=" & txtdatabase.Text & ";port=3306"
            My.Settings.Save()
            con.Close()
            Dim newconstr As String = My.Settings.Conn_String
            con.ConnectionString = newconstr
            If con.State = ConnectionState.Closed Then
                con.Open()
                MsgBox("You are successfully connected")
            End If
        Catch ex As Exception
            MsgBox("Unable to Connect")
        End Try
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Login.Show()
        Me.Close()
    End Sub
End Class