Public Class FrmFee
    Public idFees As Integer = 0
    Private Sub FrmFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSchoolYear(LabelSY)
    End Sub
    Private Sub BtnFees_Click(sender As Object, e As EventArgs) Handles BtnFees.Click
        If Not IsEmptyField(TxtCurrentPayment.Text.Trim()) Then
            Info("Please enter the pay amount.")
            Return
        End If

        If Not NoLeadingSpace(TxtCurrentPayment.Text.Trim()) Then
            Info("Current payment must have no multiple spaces between letters.")
            Return
        End If
        ClassFees.FeesRef()
    End Sub
    Public Sub SubtractPayments(currentPayment As Decimal, totalPayment As Decimal)
        Dim remainingPayment As Decimal = currentPayment - totalPayment
        TxtCurrentBalance.Text = Format(CDec(remainingPayment))
    End Sub

    Private Sub TxtCurrentPayment_TextChanged(sender As Object, e As EventArgs) Handles TxtCurrentPayment.TextChanged
        Dim totalPayment As Decimal
        Dim currentPayment As Decimal

        If Decimal.TryParse(TxtTotalBalance.Text, totalPayment) Then
            If Decimal.TryParse(TxtCurrentPayment.Text, currentPayment) Then
                SubtractPayments(totalPayment, currentPayment)
                If currentPayment > totalPayment Then
                    Info("Please pay the exact amount.")
                    TxtCurrentPayment.Clear()
                    TxtCurrentBalance.Text = "00000.00"
                End If
            End If
        End If
    End Sub
    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCurrentPayment.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
End Class