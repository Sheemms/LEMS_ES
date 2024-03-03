Imports MySql.Data.MySqlClient
Public Class ClassTeacher
#Region "TeacherParameters"
    Public Shared Function TeacherParameters() As MySqlParameter()
        Try
            Dim teacherParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmTeacherMaintenance.idTeacher),
                    New MySqlParameter("@EmpID", frmTeacherMaintenance.txtEmpID.Text),
                    New MySqlParameter("@Department_ID", frmTeacherMaintenance.cmbDept.SelectedValue),
                    New MySqlParameter("@Lastname", frmTeacherMaintenance.txtLastname.Text),
                    New MySqlParameter("@Firstname", frmTeacherMaintenance.txtFirstname.Text),
                    New MySqlParameter("@MiddleInitial", frmTeacherMaintenance.txtMiddleInitial.Text),
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
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO teacher(EmpID, Department_ID, Lastname, Firstname, MiddleInitial, Birthday, Contact, Address) 
                            VALUES (@EmpID, @Department_ID, @Lastname, @Firstname, @MiddleInitial, @Birthday, @Contact, @Address)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE teacher SET EmpID=@EmpID, Department_ID=@Department_ID, Lastname=@Lastname, Firstname=@Firstname, MiddleInitial=@MiddleInitial,
                            Birthday=@Birthday, Contact=@Contact, Address=@Address WHERE ID=@ID", dynamicParams)
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
