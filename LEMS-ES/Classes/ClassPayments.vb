Imports MySql.Data.MySqlClient
Public Class ClassPayments
#Region "PaymentsParameters"
    Public Shared Function PaymentsParameters() As MySqlParameter()
        Try
            Dim RequirementsParam() As MySqlParameter = {
                New MySqlParameter("@ID", frmPayments.idPayment),
                New MySqlParameter("@ORNo", frmPayments.LabelORNO),
                New MySqlParameter("@EnrollmentID", frmPayments.LabelEID.Text),
                New MySqlParameter("@LRN", frmPayments.txtLRN.Text),
                New MySqlParameter("@Mode", frmPayments.cmbModeofPayment.SelectedItem),
                New MySqlParameter("@Tuition", frmPayments.txtTuition.Text),
                New MySqlParameter("@OtherFee", frmPayments.cmbOtherFee.Text),
                New MySqlParameter("@Miscellaneous", frmPayments.txtMiscellaneous.Text)
            }
            Return RequirementsParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub PaymentsRef()
        Try
            Dim dynamicParams As MySqlParameter() = PaymentsParameters()
            If frmPayments.idPayment = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO payment(ORNo, ORDate, EnrollmentID, LRN, Mode, Tuition, OtherFee, Miscellaneous, EncodedBy) 
                    VALUES (@ORNo, @ORDate, @EnrollmentID, @LRN, @Mode, @Tuition, @OtherFee, @Miscellaneous, @EncodedBy)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                'If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                '    Command("UPDATE payment SET ORNo=@ORNo, ORDate=@ORDate, EnrollmentID=@EnrollmentID, LRN=@LRN, Mode=@Mode, Tuition=@Tuition, OtherFee=@OtherFee, Miscellaneous=@Miscellaneous, EncodedBy=@EncodedBy WHERE ID=@ID", dynamicParams)
                '    Success("Successfully Updated!")
                'End If
            End If

        Catch ex As MySqlException When ex.Number = 1062
            Critical("ORNO already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
