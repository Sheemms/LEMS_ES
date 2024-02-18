Imports MySql.Data.MySqlClient
Public Class ClassUserMaintenance
#Region "UserParam"
    Public Shared Function UserMParameters() As MySqlParameter()
        Try
            Dim UserParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmUserMaintenance.idUserMaintenance),
                    New MySqlParameter("@Username", frmUserMaintenance.txtUsername),
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
                If MsgBox("Do u want to Add?", vbQuestion + vbYesNo) Then
                    Command("INSERT INTO user(Username, Password, Fullname, UserLevel) 
                            VALUES (@Username, @Password, @Fullname, @UserLevel)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do u want to update?", vbQuestion + vbYesNo) Then
                    Command("UPDATE user SET Username=@Username, Password=@Password, Fullname=@Fullname, UserLevel=@UserLevel", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmTuitionFee.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Username already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
