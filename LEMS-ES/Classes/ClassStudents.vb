Imports MySql.Data.MySqlClient
Public Class ClassStudents
#Region "StudentParameters"
    Public Shared Function StudentParameters() As MySqlParameter()
        Try
            Dim studParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmStudentRegistration.idStudent),
                    New MySqlParameter("@LRN", frmStudentRegistration.txtLRN.Text),
                    New MySqlParameter("@Lastname", frmStudentRegistration.txtLastname.Text),
                    New MySqlParameter("@Firstname", frmStudentRegistration.txtFirstname.Text),
                    New MySqlParameter("@Middlename", frmStudentRegistration.txtMiddlename.Text),
                    New MySqlParameter("@Suffix", frmStudentRegistration.txtSuffix.Text),
                    New MySqlParameter("@Gender", frmStudentRegistration.GenderSelection()),
                    New MySqlParameter("@Birthday", frmStudentRegistration.dtpBday.Text),
                    New MySqlParameter("@Address", frmStudentRegistration.txtAddress.Text),
                    New MySqlParameter("@MotherName", frmStudentRegistration.txtMothersName.Text),
                    New MySqlParameter("@Mother_Occupation", frmStudentRegistration.txtMotherOccup.Text),
                    New MySqlParameter("@FatherName", frmStudentRegistration.txtFathersName.Text),
                    New MySqlParameter("@Father_Occupation", frmStudentRegistration.txtFatherOccup.Text),
                    New MySqlParameter("@GuardianName", frmStudentRegistration.txtGuardianName.Text),
                    New MySqlParameter("@GuardianContact", frmStudentRegistration.txtGuardianContact.Text),
                    New MySqlParameter("@Religion", frmStudentRegistration.txtMothersName.Text),
                    New MySqlParameter("@Citizenship", frmStudentRegistration.txtMothersName.Text),
                    New MySqlParameter("@Classification", frmStudentRegistration.txtMothersName.Text)
                }
            Return studParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub StudentRef()
        Try
            Dim dynamicParams As MySqlParameter() = StudentParameters()
            If frmStudentRegistration.idStudent = 0 Then
                Command("INSERT INTO student(LRN, Lastname, Firstname, Middlename, Suffix, Gender, Birthday, Address, MotherName, Mother_Occupation, 
                            FatherName, Father_Occupation, GuardianName, GuardianContact, Religion, Citizenship, Classification) 
                            VALUES (@LRN, @Lastname, @Firstname, @Middlename, @Suffix, @Gender, @Birthday, @Address, @Contact, @MotherName, @Mother_Occupation, 
                            @FatherName, @Father_Occupation, @GuardianName, @GuardianContact, @Religion, @Citizenship, @Classification)", dynamicParams)
            Else
                Command("UPDATE student SET LRN=@LRN, Lastname=@Lastname, Firstname=@Firstname, Middlename=@Middlename, Suffix=@Suffix, Gender=@Gender, 
                            Birthday=@Birthday, Address=@Address, Contact=@Contact, MotherName=@MotherName, Mother_Occupation=@Mother_Occupation, FatherName=@FatherName, Father_Occupation=@Father_Occupation, 
                            GuardianName=@GuardianName, GuardianContact=@GuardianContact, Religion=@Religion, Citizenship=@Citizenship, Classification=@Classification WHERE ID=@ID", dynamicParams)
            End If
        Catch ex As MySqlException When ex.Number = 1062
            Critical("LRN already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
