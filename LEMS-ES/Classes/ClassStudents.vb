Imports MySql.Data.MySqlClient

Public Class ClassStudents

    Public Shared Function StudentParameters() As MySqlParameter()
        Try
            Dim studParam() As MySqlParameter = {
                New MySqlParameter("@ID", frmStudentRegistration.idStudent),
                New MySqlParameter("@LRN", frmStudentRegistration.txtLRN.Text),
                New MySqlParameter("@Lastname", frmStudentRegistration.txtLastname.Text),
                New MySqlParameter("@Firstname", frmStudentRegistration.txtFirstname.Text),
                New MySqlParameter("@MiddleInitial", frmStudentRegistration.txtMiddlename.Text),
                New MySqlParameter("@Suffix", frmStudentRegistration.cmbSuffix.Text),
                New MySqlParameter("@Gender", frmStudentRegistration.GenderSelection()),
                New MySqlParameter("@Birthday", frmStudentRegistration.dtpBday.Value),
                New MySqlParameter("@Address", frmStudentRegistration.txtAddress.Text)
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
                If MsgBox("Do you want to Add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO student(LRN, Lastname, Firstname, MiddleInitial, Suffix, Gender, Birthday, Address) 
                            VALUES (@LRN, @Lastname, @Firstname, @MiddleInitial, @Suffix, @Gender, @Birthday, @Address)", dynamicParams)

                    Dim lastInsertedId As Integer = Convert.ToInt32(CmdScalar("SELECT LAST_INSERT_ID()"))

                    For Each row As DataGridViewRow In frmStudentRegistration.dgvRequirements.Rows
                        Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCheckBoxReq").Value)

                        If isChecked Then
                            Dim requirementID As Integer = Convert.ToInt32(row.Cells("colID").Value)
                            Dim reqParam As MySqlParameter() = {
                                New MySqlParameter("@StudentID", lastInsertedId),
                                New MySqlParameter("@RequirementID", requirementID)
                            }
                            Command("INSERT INTO submitted_requirements (StudentID, RequirementID) VALUES (@StudentID, @RequirementID)", reqParam)
                        End If
                    Next

                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to Update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE student SET LRN=@LRN, Lastname=@Lastname, Firstname=@Firstname, MiddleInitial=@MiddleInitial, Suffix=@Suffix, Gender=@Gender, Birthday=@Birthday, Address=@Address WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated")
                End If
            End If

            frmStudents.loadrecords()
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                Critical("LRN already exists.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#Region "PART 2 TEST"
    Public Shared Function StudParameters() As MySqlParameter()
        Try
            Dim studParam() As MySqlParameter = {
                New MySqlParameter("@ID", frmStudentsView.idStud),
                New MySqlParameter("@LRN", frmStudentsView.txtStudNum.Text),
                New MySqlParameter("@Lastname", frmStudentsView.txtStudLname.Text),
                New MySqlParameter("@Firstname", frmStudentsView.txtStudFname.Text),
                New MySqlParameter("@MiddleInitial", frmStudentsView.txtStudMname.Text),
                New MySqlParameter("@Suffix", frmStudentsView.cmbStudSuffix.Text),
                New MySqlParameter("@Gender", frmStudentsView.GenderSelection()),
                New MySqlParameter("@Age", frmStudentsView.txtStudAge.Text),
                New MySqlParameter("@Birthday", frmStudentsView.dtpBday.Value),
                New MySqlParameter("@Address", frmStudentsView.txtGuardianAddress.Text),
                New MySqlParameter("@MotherName", frmStudentsView.txtMother.Text),
                New MySqlParameter("@Mother_Occupation", frmStudentsView.txtMotherOccupation.Text),
                New MySqlParameter("@MothersMaiden", frmStudentsView.txtMotherMaidenName.Text),
                New MySqlParameter("@FatherName", frmStudentsView.txtFatherName.Text),
                New MySqlParameter("@Father_Occupation", frmStudentsView.txtFatherOccupation.Text),
                New MySqlParameter("@GuardianName", frmStudentsView.txtGuardianName.Text),
                New MySqlParameter("@GuardianContact", frmStudentsView.txtGuardianContact.Text),
                New MySqlParameter("@Citizenship", frmStudentsView.txtCitizenship.Text)
            }
            Return studParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub StudRef()
        Try
            Dim dynamicParams As MySqlParameter() = StudParameters()

            If frmStudentsView.idStud = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO student(LRN, Lastname, Firstname, MiddleInitial, Suffix, Gender, Age, Birthday, Address, 
                            MotherName, MothersMaiden, Mother_Occupation, FatherName, Father_Occupation, GuardianName, GuardianContact, Citizenship) 
                            VALUES (@LRN, @Lastname, @Firstname, @MiddleInitial, @Suffix, @Gender, @Birthday, @Address, 
                            @MotherName, @Mother_Occupation, @FatherName, @Father_Occupation, @GuardianName, @GuardianContact, @Citizenship)", dynamicParams)

                    'Dim lastInsertedId As Integer = Convert.ToInt32(CmdScalar("SELECT LAST_INSERT_ID()"))

                    'For Each row As DataGridViewRow In frmStudentRegistration.dgvRequirements.Rows
                    '    Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCheckBoxReq").Value)

                    '    If isChecked Then
                    '        Dim requirementID As Integer = Convert.ToInt32(row.Cells("colID").Value)
                    '        Dim reqParam As MySqlParameter() = {
                    '            New MySqlParameter("@StudentID", lastInsertedId),
                    '            New MySqlParameter("@RequirementID", requirementID)
                    '        }
                    '        Command("INSERT INTO submitted_requirements (StudentID, RequirementID) VALUES (@StudentID, @RequirementID)", reqParam)
                    '    End If
                    'Next

                    Success("Successfully added!")
                    frmStudentsView.Close()
                End If
            Else
                If MsgBox("Do you want to update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE student SET LRN=@LRN, Lastname=@Lastname, Firstname=@Firstname, MiddleInitial=@MiddleInitial, Suffix=@Suffix, Gender=@Gender, Age=@Age, Birthday=@Birthday, Address=@Address, 
                            MotherName=@MotherName, MothersMaiden=@MothersMaiden, Mother_Occupation=@Mother_Occupation, FatherName=@FatherName, Father_Occupation=@Father_Occupation, GuardianName=@GuardianName, GuardianContact=@GuardianContact, 
                            Citizenship=@Citizenship WHERE ID=@ID", dynamicParams)
                    Success("Successfully updated!")
                    frmStudentsView.Close()
                End If
            End If

            frmStudents.loadrecords()
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                Critical("LRN already exists.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Sub StudUpdate()
        Try
            Dim dynamicParams As MySqlParameter() = StudParameters()


            If MsgBox("Do you want to update?", vbQuestion + vbYesNo) = vbYes Then
                Command("UPDATE student SET LRN=@LRN, Lastname=@Lastname, Firstname=@Firstname, MiddleInitial=@MiddleInitial, Suffix=@Suffix, Gender=@Gender, Age=@Age, Birthday=@Birthday, Address=@Address,
                        MotherName=@MotherName, MothersMaiden=@MothersMaiden, Mother_Occupation=@Mother_Occupation, FatherName=@FatherName, Father_Occupation=@Father_Occupation, GuardianName=@GuardianName, GuardianContact=@GuardianContact, 
                        Citizenship=@Citizenship WHERE ID=@ID", dynamicParams)
                Success("Successfully updated!")
            Else

            End If
            frmStudents.loadrecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class