Imports MySql.Data.MySqlClient
Public Class ClassPayments
#Region "PaymentsParameters"
    Public Shared Function PaymentsParameters() As MySqlParameter()
        Try
            Dim RequirementsParam() As MySqlParameter = {
                New MySqlParameter("@ID", frmPayments.idPayment),
                New MySqlParameter("@LRN", frmPayments.txtLRN.Text),
                New MySqlParameter("@StudName", frmPayments.txtStudName.Text)
            }
            Return RequirementsParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub PaymentsRef()
        Try
            Dim dynamicParams As MySqlParameter() = PaymentsParameters()
            If frmRequirements.idRequirements = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO requirements(Classification_ID, Requirement) VALUES (@Classification_ID, @Requirement)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE requirements SET Classification_ID=@Classification_ID, Requirement=@Requirement WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmRequirements.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Requirements already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
