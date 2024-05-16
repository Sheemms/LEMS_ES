Imports MySql.Data.MySqlClient

Public Class ClassTeacher
#Region "TeacherParameters"
    Public Shared Function TeacherParameters(ByVal userId As Integer) As MySqlParameter()
        Try
            Dim teacherParam() As MySqlParameter = {
                New MySqlParameter("@ID", FrmTeacherMaintenance.idTeacher),
                New MySqlParameter("@EmpID", FrmTeacherMaintenance.txtEmpID.Text),
                New MySqlParameter("@Department_ID", FrmTeacherMaintenance.cmbDept.SelectedValue),
                New MySqlParameter("@Lastname", FrmTeacherMaintenance.txtLastname.Text),
                New MySqlParameter("@Firstname", FrmTeacherMaintenance.txtFirstname.Text),
                New MySqlParameter("@MiddleInitial", FrmTeacherMaintenance.txtMiddleInitial.Text),
                New MySqlParameter("@Contact", FrmTeacherMaintenance.txtContact.Text),
                New MySqlParameter("@Address", FrmTeacherMaintenance.txtAddress.Text),
                New MySqlParameter("@UserID", userId)
            }
            Return teacherParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub TeacherRef()
        Try
            Dim userParams As MySqlParameter() = UserMParameters()

            If FrmTeacherMaintenance.idTeacher = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO user(Username, Password, Fullname, Contact, UserLevel) 
                            VALUES (@Username, @Password, @Fullname, @Contact, 'Instructor')", userParams)

                    Dim lastInsertedId As Integer = Convert.ToInt32(CmdScalar("SELECT LAST_INSERT_ID()"))

                    Dim dynamicParams As MySqlParameter() = TeacherParameters(lastInsertedId)

                    Command("INSERT INTO teacher(EmpID, Department_ID, Lastname, Firstname, MiddleInitial, Contact, Address, UserID) 
                            VALUES (@EmpID, @Department_ID, @Lastname, @Firstname, @MiddleInitial, @Contact, @Address, @UserID)", dynamicParams)

                    Success("Successfully Added!")
                    FrmTeacherMaintenance.Close()
                    FrmTeacherMaintenance.Clear()
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Dim dynamicParams As MySqlParameter() = TeacherParameters(FrmTeacherMaintenance.iduser)
                    Command("UPDATE teacher SET EmpID=@EmpID, Department_ID=@Department_ID, Lastname=@Lastname, Firstname=@Firstname, 
                            MiddleInitial=@MiddleInitial, Contact=@Contact, Address=@Address WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                    FrmTeacherMaintenance.Close()
                    FrmTeacherMaintenance.Clear()
                End If
            End If
            FrmTeachers.Loadrecords()
        Catch ex As MySqlException
            If ex.Number = 1062 AndAlso ex.Message.Contains("EmpID") Then
                Critical("Employee ID already exists.")
                Exit Sub
            ElseIf ex.Number = 1062 AndAlso ex.Message.Contains("Username") Then
                Critical("Username already exists.")
                Exit Sub
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Function UserMParameters() As MySqlParameter()
        Try
            Dim fullname As String = FrmTeacherMaintenance.txtLastname.Text & " " & FrmTeacherMaintenance.txtFirstname.Text
            Dim UserParam() As MySqlParameter = {
                New MySqlParameter("@ID", FrmTeacherMaintenance.iduser),
                New MySqlParameter("@Username", FrmTeacherMaintenance.TxtUsername.Text),
                New MySqlParameter("@Password", FrmTeacherMaintenance.TxtPassword.Text),
                New MySqlParameter("@Fullname", fullname),
                New MySqlParameter("@Contact", FrmTeacherMaintenance.txtContact.Text)
            }
            Return UserParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
End Class
