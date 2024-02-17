﻿Imports MySql.Data.MySqlClient
Public Class ClassGradeLevel
#Region "GradeLevelParameters"
    Public Shared Function GradeLevelParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmGradeLevel.idGradeLevel),
                    New MySqlParameter("@GradeLevel", frmGradeLevel.txtAddGradeLevel.Text)
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub GradeLevelRef()
        Dim dynamicParams As MySqlParameter() = GradeLevelParameters()
        If frmGradeLevel.idGradeLevel = 0 Then
            Command("INSERT INTO gradelevel(GradeLevel) VALUES (@GradeLevel)", dynamicParams)
        Else
            Command("UPDATE gradelevel SET GradeLevel=@GradeLevel WHERE ID=@ID", dynamicParams)
        End If
    End Sub
#End Region
End Class