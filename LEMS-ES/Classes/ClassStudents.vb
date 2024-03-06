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
                    New MySqlParameter("@Suffix", frmStudentRegistration.cmbSuffix.Text),
                    New MySqlParameter("@Gender", frmStudentRegistration.GenderSelection()),
                    New MySqlParameter("@Birthday", frmStudentRegistration.dtpBday.Value),
                    New MySqlParameter("@Address", frmStudentRegistration.txtAddress.Text)
                    }
            'New MySqlParameter("@MotherName", frmStudentRegistration.txtMothersName.Text),
            'New MySqlParameter("@Mother_Occupation", frmStudentRegistration.txtMotherOccup.Text),
            'New MySqlParameter("@FatherName", frmStudentRegistration.txtFathersName.Text),
            'New MySqlParameter("@Father_Occupation", frmStudentRegistration.txtFatherOccup.Text),
            'New MySqlParameter("@GuardianName", frmStudentRegistration.txtGuardianName.Text),
            'New MySqlParameter("@GuardianContact", frmStudentRegistration.txtGuardianContact.Text)

            Return studParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub StudentRef()
        Try
            Dim dynamicParams As MySqlParameter() = StudentParameters()
            If frmStudentRegistration.idStudent = 0 Then
                If MsgBox("Do you want to Add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO student(LRN, Lastname, Firstname, Middlename, Suffix, Gender, Age, Birthday, Address, MotherName, Mother_Occupation, 
                            FatherName, Father_Occupation, GuardianName, GuardianContact, Religion, Citizenship) 
                            VALUES (@LRN, @Lastname, @Firstname, @Middlename, @Suffix, @Gender, @Age, @Birthday, @Address, @MotherName, @Mother_Occupation, 
                            @FatherName, @Father_Occupation, @GuardianName, @GuardianContact, @Religion, @Citizenship)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to Update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE student SET LRN=@LRN, Lastname=@Lastname, Firstname=@Firstname, Middlename=@Middlename, Suffix=@Suffix, Gender=@Gender, Age=@Age
                            Birthday=@Birthday, Address=@Address, MotherName=@MotherName, Mother_Occupation=@Mother_Occupation, FatherName=@FatherName, Father_Occupation=@Father_Occupation, 
                            GuardianName=@GuardianName, GuardianContact=@GuardianContact, Religion=@Religion, Citizenship=@Citizenship WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated")
                End If
            End If
                frmStudents.loadrecords()
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                Critical("LRN already exists.")
            End If
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
