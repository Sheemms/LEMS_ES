﻿Imports MySql.Data.MySqlClient
Public Class ClassTuition
#Region "TuitionParameters"
    Public Shared Function TuitionParameters() As MySqlParameter()
        Try
            Dim tuitionParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmTuitionFee.idTuition),
                    New MySqlParameter("@Amount", frmTuitionFee.txtAmount.Text),
                    New MySqlParameter("@Classification", frmTuitionFee.txtClassification.Text)
                }
            Return tuitionParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub TuitionRef()
        Try
            Dim dynamicParams As MySqlParameter() = TuitionParameters()
            If frmTuitionFee.idTuition = 0 Then
                Command("INSERT INTO tuition(Amount, Classification) 
                            VALUES (@Amount, @Classification)", dynamicParams)
            Else
                Command("UPDATE tuition SET Amount=@Amount, Classification=@Classification", dynamicParams)
            End If
            frmTuitionFee.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Tuition already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
