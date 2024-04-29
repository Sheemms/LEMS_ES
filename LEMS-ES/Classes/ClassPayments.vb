﻿Imports MySql.Data.MySqlClient
Public Class ClassPayments
#Region "PaymentsParameters"
    Public Shared Function PaymentsParameters() As MySqlParameter()
        Try
            Dim RequirementsParam() As MySqlParameter = {
                New MySqlParameter("@ID", frmPayments.idPayment),
                New MySqlParameter("@ORID", frmPayments.LabelORNO.Text),
                New MySqlParameter("@EID", frmPayments.LabelEID.Text),
                New MySqlParameter("@LRN", frmPayments.txtLRN.Text),
                New MySqlParameter("@Tuition", frmPayments.txtTuition.Text),
                New MySqlParameter("@Miscellaneous", frmPayments.txtMiscellaneous.Text),
                New MySqlParameter("@Mode", frmPayments.cmbModeofPayment.SelectedItem),
                New MySqlParameter("@Terms", frmPayments.Guna2NumericUpDown1.Text),
                New MySqlParameter("@Amount", frmPayments.TxtCurPayment.Text),
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
                    Command("INSERT INTO payment(ORID, EID, LRN, Tuition, Miscellaneous, Mode, Terms, Amount, EncodedBy) 
                        VALUES (@ORID, @EID, @LRN, @Tuition, @Miscellaneous, @Mode, @Terms, @Amount, @EncodedBy)", dynamicParams)
                    Success("Successfully Added!")

                    For Each row As DataGridViewRow In frmPayments.DgvReceipt.Rows
                        Try
                            Dim remarkname As String = row.Cells(0).Value
                            Query("Select * from otherfee where Description = '" & remarkname & "'")
                            If ds.Tables("QueryTb").Rows.Count > 0 Then
                                Dim ofid As Integer = ds.Tables("QueryTb").Rows(0)(0)
                                OtherCommand("Insert into feeor(ORID,OFID)VALUES('" & frmPayments.LabelORNO.Text & "', '" & ofid & "')")
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Next

                    For Each row As DataGridViewRow In frmPayments.DgvReceipt.Rows
                        Dim selectedValue As String = row.Cells("Column8").Value.ToString()
                        Dim amount As Decimal

                        If selectedValue = "Additional" OrElse selectedValue = "Discount" OrElse selectedValue = "No Changes" Then
                            If Decimal.TryParse(row.Cells("Column9").Value.ToString(), amount) Then
                                Try
                                    Dim parameters As New List(Of MySqlParameter)()
                                    parameters.Add(New MySqlParameter("@ORID", frmPayments.LabelORNO.Text))
                                    parameters.Add(New MySqlParameter("@Description", selectedValue))
                                    parameters.Add(New MySqlParameter("@Amount", amount))

                                    Command("INSERT INTO fee_changes (ORID, Description, Amount) VALUES (@ORID, @Description, @Amount)", parameters.ToArray())
                                Catch ex As Exception
                                    MsgBox("Error inserting change into database: " & ex.Message)
                                End Try
                            Else
                                MsgBox("Invalid amount for " & selectedValue & ". Please enter a valid amount.")
                            End If
                        End If
                    Next

                    Command("UPDATE enrollment SET Status = 'Enrolled' WHERE ID = @ID", New MySqlParameter("@ID", frmPayments.idRegisteredStudents))
                    FrmBilling.LoadRecords()
                    frmPayments.Close()
                End If
            Else

            End If
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Student bills already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
