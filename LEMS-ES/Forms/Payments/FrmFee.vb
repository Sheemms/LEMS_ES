Public Class FrmFee
    Public idFees As Integer = 0
    Private Sub FrmFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSchoolYear(LabelSY)
    End Sub
    Private Sub BtnPayments_Click(sender As Object, e As EventArgs) Handles BtnFees.Click

    End Sub
    Public Sub LoadData()
        Query("SELECT * FROM payment")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class