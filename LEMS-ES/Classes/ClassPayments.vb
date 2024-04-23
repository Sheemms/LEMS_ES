Imports MySql.Data.MySqlClient
Public Class ClassPayments
#Region "PaymentsParameters"
    Public Shared Function PaymentsParameters() As MySqlParameter()
        Try
            Dim RequirementsParam() As MySqlParameter = {
                New MySqlParameter("@ID", frmPayments.idPayment),
                New MySqlParameter("@ORNo", frmPayments.LabelORNO.Text),
                New MySqlParameter("@EnrollmentID", frmPayments.LabelEID.Text),
                New MySqlParameter("@LRN", frmPayments.txtLRN.Text),
                New MySqlParameter("@Mode", frmPayments.cmbModeofPayment.SelectedValue),
                New MySqlParameter("@Tuition", frmPayments.txtTuition.Text),
                New MySqlParameter("@Miscellaneous", frmPayments.txtMiscellaneous.Text),
                New MySqlParameter("@EncodedBy", frmDashboard.Label3.Text)
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
                    For Each row As DataGridViewRow In frmPayments.DgvReceipt.Rows
                        Dim remarkname As String = row.Cells(0).Value
                        Query("Select * from otherfee where Description = '" & remarkname & "'")
                        If ds.Tables("QueryTb").Rows.Count > 0 Then
                            Dim ofid As Integer = ds.Tables("QueryTb").Rows(0)(0)
                            MsgBox(ofid)
                            OtherCommand("Insert into feeor(ORID,OFID)VALUES('" & frmPayments.LabelORNO.Text & "', '" & ofid & "')")
                        End If
                    Next
                    Command("INSERT INTO payment(ORNo, EnrollmentID, LRN, Mode, Tuition, Miscellaneous, EncodedBy) 
                        VALUES (@ORNo, @EnrollmentID, @LRN, @Mode, @Tuition, @Miscellaneous, @EncodedBy)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                'If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                '    For Each row As DataGridViewRow In frmPayments.DgvReceipt.Rows
                '        Dim remarkname As String = row.Cells(0).Value
                '        Query("Select * from otherfee where Description = '" & remarkname & "'")
                '        If ds.Tables("QueryTb").Rows.Count > 0 Then
                '            Dim ofid As Integer = ds.Tables("QueryTb").Rows(0)(0)
                '            MsgBox(ofid)
                '            OtherCommand("Insert into feeor(ORID,OFID)VALUES('" & frmPayments.LabelORNO.Text & "', '" & ofid & "')")
                '        End If
                '    Next
                '    Command("UPDATE payment SET ORNo=@ORNo, EnrollmentID=@EnrollmentID, LRN=@LRN, Mode=@Mode, Tuition=@Tuition, Miscellaneous=@Miscellaneous, EncodedBy=@EncodedBy WHERE ID=@ID", dynamicParams)
                '    Success("Successfully Updated!")
                'End If
            End If
        Catch ex As MySqlException When ex.Number = 1062
            Critical("ORNumber already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
End Class
