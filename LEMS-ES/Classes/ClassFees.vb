Imports MySql.Data.MySqlClient
Public Class ClassFees
#Region "FeesParameters"
    Public Shared Function FeesParameters() As MySqlParameter()
        Try
            Dim RequirementsParam() As MySqlParameter = {
                New MySqlParameter("@ID", FrmFee.idFees),
                New MySqlParameter("@EID", FrmFee.LabelEID.Text),
                New MySqlParameter("@Amount", FrmFee.TxtCurrentPayment.Text),
                New MySqlParameter("@Pdate", FrmFee.txtLRN.Text)
            }
            Return RequirementsParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub FeesRef()
        Try
            Dim dynamicParams As MySqlParameter() = FeesParameters()
            If frmPayments.idPayment = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO fees(EID, Amount) 
                    VALUES (@EID, @Amount)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                'If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                '    Command("UPDATE payment SET ORNo=@ORNo, ORDate=@ORDate, EnrollmentID=@EnrollmentID, LRN=@LRN, Mode=@Mode, Tuition=@Tuition, OtherFee=@OtherFee, Miscellaneous=@Miscellaneous, EncodedBy=@EncodedBy WHERE ID=@ID", dynamicParams)
                '    Success("Successfully Updated!")
                'End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
