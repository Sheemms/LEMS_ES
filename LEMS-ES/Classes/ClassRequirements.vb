Imports MySql.Data.MySqlClient
Public Class ClassRequirements
#Region "RequirementsParameters"
    Public Shared Function RequirementsParameters() As MySqlParameter()
        Try
            Dim RequirementsParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmRequirements.idRequirements),
                    New MySqlParameter("@GradeLevel", frmGradeLevel.txtAddGradeLevel.Text)
                }
            Return RequirementsParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub RequirementsRef()
        Try
            Dim dynamicParams As MySqlParameter() = RequirementsParameters()
            If frmRequirements.idRequirements = 0 Then
                If MsgBox("Do you want to Add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO requirements( ) VALUES (@ )", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE requirements SET =@ WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmGradeLevel.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Requirements already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
