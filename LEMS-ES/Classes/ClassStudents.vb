Imports MySql.Data.MySqlClient

Public Class ClassStudents

    Public Shared Function StudentParameters(frm As frmStudentRegistration) As MySqlParameter()
        Try
            Dim studParam() As MySqlParameter = {
                New MySqlParameter("@ID", frm.idStudent),
                New MySqlParameter("@LRN", frm.txtLRN.Text),
                New MySqlParameter("@Lastname", frm.txtLastname.Text),
                New MySqlParameter("@Firstname", frm.txtFirstname.Text),
                New MySqlParameter("@MiddleInitial", frm.txtMiddlename.Text),
                New MySqlParameter("@Suffix", frm.cmbSuffix.Text),
                New MySqlParameter("@Gender", frm.GenderSelection()),
                New MySqlParameter("@Birthday", frm.dtpBday.Value),
                New MySqlParameter("@Address", frm.txtAddress.Text)
            }
            Return studParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub StudentRef(frm As frmStudentRegistration)
        Try
            Dim dynamicParams As MySqlParameter() = StudentParameters(frm)

            If frm.idStudent = 0 Then
                If MsgBox("Do you want to Add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO student(LRN, Lastname, Firstname, MiddleInitial, Suffix, Gender, Birthday, Address) 
                            VALUES (@LRN, @Lastname, @Firstname, @MiddleInitial, @Suffix, @Gender, @Birthday, @Address)", dynamicParams)

                    Dim lastInsertedId As Integer = Convert.ToInt32(CmdScalar("SELECT LAST_INSERT_ID()"))

                    For Each row As DataGridViewRow In frm.dgvRequirements.Rows
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

End Class