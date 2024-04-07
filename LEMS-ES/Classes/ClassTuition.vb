Imports MySql.Data.MySqlClient
Public Class ClassTuition
#Region "TuitionParameters"
    Public Shared Function TuitionParameters() As MySqlParameter()
        Try
            Dim tuitionParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmTuitionFee.idTuition),
                    New MySqlParameter("@GradeLevel_ID", frmTuitionFee.cmbGradeLevel.SelectedValue),
                    New MySqlParameter("@Amount", frmTuitionFee.txtAmountTuition.Text)
                }
            Return tuitionParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub TuitionRef()
        Try
            If frmTuitionFee.idTuition = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO tuition(GradeLevel_ID, Amount) 
                            VALUES (@GradeLevel_ID, @Amount)", TuitionParameters())
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE tuition SET GradeLevel_ID=@GradeLevel_ID, Amount=@Amount", TuitionParameters())
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
            Dim existingCount As Integer = CInt(CmdScalar("SELECT COUNT(*) FROM miscellaneous"))

            If existingCount = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO miscellaneous(M_Amount) VALUES (@M_Amount)", MiscellaneousParameters())
                    Success("Successfully added!")
                End If
            Else
                If MsgBox("Do you want to update the existing entry?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE miscellaneous SET M_Amount=@M_Amount", MiscellaneousParameters())
                    Success("Successfully updated!")
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
            Dim existingCount As Integer = CInt(CmdScalar("SELECT COUNT(*) FROM otherfee"))

            If existingCount = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO otherfee(OF_Amount) VALUES (@OF_Amount)", OtherFeeParameters())
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update the existing entry?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE otherfee SET OF_Amount=@OF_Amount", OtherFeeParameters())
                    Success("Successfully Updated!")
                End If
            End If

            frmTuitionFee.loadrecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ModeofPaymentParameters"
    Public Shared Function MoPParameters() As MySqlParameter()
        Try
            Dim MoPParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmTuitionFee.idMOP),
                    New MySqlParameter("@Mode", frmTuitionFee.txtMOP.Text)
                    }
            Return MoPParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub MoPRef()
        Try
            If frmTuitionFee.idTuition = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO mop(Mode) 
                            VALUES (@Mode)", MoPParameters())
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE mop SET Mode=@Mode", MoPParameters())
                    Success("Successfully Updated!")
                End If
            End If
            frmTuitionFee.loadrecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "TermsofPaymentParameters"
    Public Shared Function ToPParameters() As MySqlParameter()
        Try
            Dim ToPParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmTuitionFee.idTOP),
                    New MySqlParameter("@Terms", frmTuitionFee.txtTOP.Text)
                    }
            Return ToPParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub ToPRef()
        Try
            If frmTuitionFee.idTuition = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO top(Terms) 
                            VALUES (@Terms)", ToPParameters())
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE top SET Terms=@Terms", ToPParameters())
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
