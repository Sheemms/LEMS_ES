Imports MySql.Data.MySqlClient
Public Class ClassTuition
#Region "TuitionParameters"
    Public Shared Function TuitionParameters() As MySqlParameter()
        Try
            Dim tuitionParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmTuitionFee.idTuition),
                    New MySqlParameter("@GradeLevel_ID", frmTuitionFee.cmbGradeLevel.SelectedValue),
                    New MySqlParameter("@Amount", frmTuitionFee.txtAmountTuition.Text),
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
                If MsgBox("Do u want to Add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO tuition(GradeLevel_ID, Amount, Classification) 
                            VALUES (@GradeLevel_ID, @Amount, @Classification)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do u want to update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE tuition SET GradeLevel_ID=@GradeLevel_ID, Amount=@Amount, Classification=@Classification", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmTuitionFee.loadrecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "MiscellaneousParameters"
    Public Shared Function MiscellaneousParameters() As MySqlParameter()
        Try
            Dim miscellaneousParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmTuitionFee.idMiscellaneous),
                    New MySqlParameter("@M_Amount", frmTuitionFee.txtAmountMiscellaneous.Text)
                    }
            Return miscellaneousParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub MiscellaneousRef()
        Try
            Dim dynamicParams As MySqlParameter() = MiscellaneousParameters()
            If frmTuitionFee.idMiscellaneous = 0 Then
                If MsgBox("Do u want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO miscellaneous(M_Amount) 
                            VALUES (@M_Amount)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do u want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE miscellaneous SET M_Amount=@M_Amount", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmTuitionFee.loadrecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "OtherFeeParameters"
    Public Shared Function OtherFeeParameters() As MySqlParameter()
        Try
            Dim OtherFeeParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmTuitionFee.idOtherFee),
                    New MySqlParameter("@OF_Amount", frmTuitionFee.txtAmountOtherFee.Text)
                    }
            Return OtherFeeParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub OtherFeeRef()
        Try
            Dim dynamicParams As MySqlParameter() = OtherFeeParameters()
            If frmTuitionFee.idOtherFee = 0 Then
                If MsgBox("Do u want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO otherfee(OF_Amount) 
                            VALUES (@OF_Amount)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do u want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE otherfee SET OF_Amount=@OF_Amount", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmTuitionFee.loadrecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
