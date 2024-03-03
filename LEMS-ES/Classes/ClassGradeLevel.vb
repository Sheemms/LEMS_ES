Imports MySql.Data.MySqlClient
Public Class ClassGradeLevel
#Region "GradeLevelParameters"
    Public Shared Function GradeLevelParameters() As MySqlParameter()
        Try
            Dim GradeLevelParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmGradeLevel.idGradeLevel),
                    New MySqlParameter("@Department_ID", frmGradeLevel.cmbDept.SelectedValue),
                    New MySqlParameter("@GradeLevel", frmGradeLevel.txtAddGradeLevel.Text)
                }
            Return GradeLevelParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub GradeLevelRef()
        Try
            Dim dynamicParams As MySqlParameter() = GradeLevelParameters()
            If frmGradeLevel.idGradeLevel = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO gradelevel(Department_ID, GradeLevel) VALUES (@Department_ID, @GradeLevel)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE gradelevel SET Department_ID=@Department_ID, GradeLevel=@GradeLevel WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmGradeLevel.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Grade Level already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
