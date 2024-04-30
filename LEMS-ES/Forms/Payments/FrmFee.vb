Public Class FrmFee
    Public idFees As Integer = 0
    Private Sub FrmFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSchoolYear(LabelSY)
    End Sub
    Private Sub BtnFees_Click(sender As Object, e As EventArgs) Handles BtnFees.Click
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
                    MsgBox("Please pay the exact amount.")
                    TxtCurrentPayment.Clear()
                    TxtCurrentBalance.Text = "00000.00"
                End If
            End If
        End If
    End Sub

End Class