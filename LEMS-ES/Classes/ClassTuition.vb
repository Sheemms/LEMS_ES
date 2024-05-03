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
                    FrmTuitionFee.Clear()
                End If
            Else
                If MsgBox("Do you want to update?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE tuition SET GradeLevel_ID=@GradeLevel_ID, Amount=@Amount", TuitionParameters())
                    Success("Successfully Updated!")
                    FrmTuitionFee.Clear()
                End If
            End If
            FrmTuitionFee.Loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Tuition already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "MiscellaneousParameters"
    Public Shared Function MiscellaneousParameters() As MySqlParameter()
        Try
            Dim miscellaneousParam() As MySqlParameter = {
                    New MySqlParameter("@ID", FrmTuitionFee.idMiscellaneous),
                    New MySqlParameter("@Amount", FrmTuitionFee.txtAmountMiscellaneous.Text)
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
                    Command("INSERT INTO miscellaneous(Amount) VALUES (@Amount)", MiscellaneousParameters())
                    Success("Successfully added!")
                    FrmTuitionFee.Clear()
                End If
            Else
                If MsgBox("Do you want to update the existing entry?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE miscellaneous SET Amount=@Amount", MiscellaneousParameters())
                    Success("Successfully updated!")
                    FrmTuitionFee.Clear()
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
                    New MySqlParameter("@ID", FrmTuitionFee.idOtherFee),
                    New MySqlParameter("@Description", FrmTuitionFee.txtOtherFeeDesc.Text),
                    New MySqlParameter("@Amount", FrmTuitionFee.txtAmountOtherFee.Text)
                    }
            Return OtherFeeParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub OtherFeeRef()
        Try
            'Dim existingCount As Integer = CInt(CmdScalar("SELECT COUNT(*) FROM otherfee"))

            If frmTuitionFee.idOtherFee = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO otherfee(Description, Amount) VALUES (@Description, @Amount)", OtherFeeParameters())
                    Success("Successfully Added!")
                    FrmTuitionFee.Clear()
                End If
            Else
                If MsgBox("Do you want to update the existing entry?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE otherfee SET Description=@Description, Amount=@Amount", OtherFeeParameters())
                    Success("Successfully Updated!")
                    FrmTuitionFee.Clear()
                End If
            End If
            FrmTuitionFee.Loadrecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "ModeofPaymentParameters"
    'Public Shared Function MoPParameters() As MySqlParameter()
    '    Try
    '        Dim MoPParam() As MySqlParameter = {
    '                New MySqlParameter("@ID", frmTuitionFee.idMOP),
    '                New MySqlParameter("@Mode", frmTuitionFee.txtMOP.Text)
    '                }
    '        Return MoPParam
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function
    'Public Shared Sub MoPRef()
    '    Try
    '        If frmTuitionFee.idTuition = 0 Then
    '            If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
    '                Command("INSERT INTO mop(Mode) 
    '                        VALUES (@Mode)", MoPParameters())
    '                Success("Successfully Added!")
    '            End If
    '        Else
    '            If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
    '                Command("UPDATE mop SET Mode=@Mode", MoPParameters())
    '                Success("Successfully Updated!")
    '            End If
    '        End If
    '        frmTuitionFee.loadrecords()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
#End Region
#Region "TermsofPaymentParameters"
    'Public Shared Function ToPParameters() As MySqlParameter()
    '    Try
    '        Dim ToPParam() As MySqlParameter = {
    '                New MySqlParameter("@ID", frmTuitionFee.idTOP),
    '                New MySqlParameter("@Terms", frmTuitionFee.txtTOP.Text)
    '                }
    '        Return ToPParam
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function
    'Public Shared Sub ToPRef()
    '    Try
    '        If frmTuitionFee.idTuition = 0 Then
    '            If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
    '                Command("INSERT INTO top(Terms) 
    '                        VALUES (@Terms)", ToPParameters())
    '                Success("Successfully Added!")
    '            End If
    '        Else
    '            If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
    '                Command("UPDATE top SET Terms=@Terms", ToPParameters())
    '                Success("Successfully Updated!")
    '            End If
    '        End If
    '        frmTuitionFee.loadrecords()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
#End Region
End Class
