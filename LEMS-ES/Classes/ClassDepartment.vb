﻿Imports MySql.Data.MySqlClient
Public Class ClassDepartment

#Region "DepartmentParameters"
    Public Shared Function DepartmentParameters() As MySqlParameter()
        Try
            Dim DeptParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmDepartment.idDept),
                    New MySqlParameter("@Department", frmDepartment.TxtDeptName.Text)
                }
            Return DeptParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub DepartmentRef()
        Try
            Dim dynamicParams As MySqlParameter() = DepartmentParameters()
            If frmDepartment.idDept = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO department(Department) VALUES (@Department)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE department SET Department=@Department WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            FrmDepartment.Loadrecords()
            Dim name As String = FrmDepartment.TxtDeptName.Text
            LogAction("Added Department |" & name)
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Department already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
