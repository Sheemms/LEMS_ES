Imports MySql.Data.MySqlClient
Public Class ClassUserMaintenance
#Region "UserParam"
    Public Shared Function UserMParameters() As MySqlParameter()
        Try
            Dim UserParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmUserMaintenance.idUserMaintenance),
                    New MySqlParameter("@Username", frmUserMaintenance.txtUsername.Text),
                    New MySqlParameter("@Password", frmUserMaintenance.txtPassword.Text),
                    New MySqlParameter("@Fullname", frmUserMaintenance.txtFullname.Text),
                    New MySqlParameter("@UserLevel", frmUserMaintenance.cmbUserLevel.Text)
                    }
            Return UserParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub UserMRef()
        Try
            Dim dynamicParams As MySqlParameter() = UserMParameters()
            If frmUserMaintenance.idUserMaintenance = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO user(Username, Password, Fullname, UserLevel) 
                            VALUES (@Username, @Password, @Fullname, @UserLevel)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE user SET Username=@Username, Password=@Password, Fullname=@Fullname, UserLevel=@UserLevel", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmUserMaintenance.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Username already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Function UserLevelParameters() As MySqlParameter()
        Try
            Dim UserLevelParam() As MySqlParameter = {
            New MySqlParameter("@userlevel", frmAddUserLevel.txtUserLevel.Text)
        }
            Return UserLevelParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub UserLevelRef()
        Try
            Dim dynamicParams As MySqlParameter() = UserLevelParameters()
            If MsgBox("Do u want to Add?", vbQuestion + vbYesNo) = vbYes Then
                Command("INSERT INTO userlevel(userlevel) 
                            VALUES (@userlevel)", dynamicParams)
                Success("Successfully Added!")
            End If
            frmUserMaintenance.loadrecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Function UserDeactParam() As MySqlParameter()
        Try
            Dim UserParam() As MySqlParameter = {
                New MySqlParameter("@ID", frmUserMaintenance.idUserMaintenance),
                New MySqlParameter("@Username", frmUserMaintenance.txtUsername.Text),
                New MySqlParameter("@Password", frmUserMaintenance.txtPassword.Text),
                New MySqlParameter("@Fullname", frmUserMaintenance.txtFullname.Text),
                New MySqlParameter("@UserLevel", frmUserMaintenance.cmbUserLevel.Text),
                New MySqlParameter("@Status", "Inactive")
            }
            Return UserParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub UserMDeact()
        Dim dynamicParams As MySqlParameter() = UserDeactParam()
        If MsgBox("Do you want to deactivate this account?", vbQuestion + vbYesNo) = vbYes Then
            Command("UPDATE user SET Status = @Status WHERE ID = @ID", dynamicParams)
            Success("Account deactivated successfully.")
            frmUserMaintenance.loadrecords()
        End If
    End Sub
#End Region
End Class
