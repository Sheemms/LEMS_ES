Imports MySql.Data.MySqlClient
Public Class ClassTeacher
#Region "TeacherParameters"
    Public Shared Function TeacherParameters() As MySqlParameter()
        Try
            Dim teacherParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmTeacherMaintenance.idTeacher),
                    New MySqlParameter("@EmpID", frmTeacherMaintenance.txtEmpID.Text),
                    New MySqlParameter("@Lastname", frmTeacherMaintenance.txtLastname.Text),
                    New MySqlParameter("@Firstname", frmTeacherMaintenance.txtFirstname.Text),
                    New MySqlParameter("@Middlename", frmTeacherMaintenance.txtMiddlename.Text),
                    New MySqlParameter("@Birthday", frmTeacherMaintenance.txtBday.Text),
                    New MySqlParameter("@Contact", frmTeacherMaintenance.txtContact.Text),
                    New MySqlParameter("@Address", frmTeacherMaintenance.txtAddress.Text)
                }
            Return teacherParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub TeacherRef()
        Try
            Dim dynamicParams As MySqlParameter() = TeacherParameters()
            If frmTeacherMaintenance.idTeacher = 0 Then
                If MsgBox("Do u want to Add?", vbQuestion + vbYesNo) Then
                    Command("INSERT INTO teacher(EmpID, Lastname, Firstname, Middlename, Birthday, Contact, Address) 
                            VALUES (@EmpID, @Lastname, @Firstname, @Middlename, @Birthday, @Contact, @Address)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do u want to update?", vbQuestion + vbYesNo) Then
                    Command("UPDATE teacher SET EmpID=@EmpID, Lastname=@Lastname, Firstname=@Firstname, Middlename=@Middlename, Birthday=@Birthday, 
                            Contact=@Contact, Address=@Address WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
                frmTeacherMaintenance.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Employee ID already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
