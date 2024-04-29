Public Class FrmFee
    Public idFees As Integer = 0
    Private Sub FrmFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSchoolYear(LabelSY)
        LoadData()
    End Sub
    Public Sub LoadData()
        If DgvTransactionHistory.CurrentRow IsNot Nothing Then
            Dim StudEID As String = DgvTransactionHistory.CurrentRow.Cells(2).Value.ToString()
            Query("SELECT  a.ID, a.ORNo, a.EID, b.LRN, 
                CONCAT(b.Lastname, ', ', b.Firstname, ' ', b.MiddleInitial) Fullname,
                d.GradeLevel as Grade, e.SectionRoom as Section,
                a.Amount, a.ORDate as Date
                FROM payment a
                JOIN student b ON a.LRN = b.LRN
                JOIN enrollment c ON b.LRN = c.LRN
                JOIN gradelevel d ON c.GradeLevel_ID = d.ID
                JOIN section e ON c.SectionID = e.ID
                WHERE a.EID =" & StudEID)
            DgvTransactionHistory.DataSource = ds.Tables("QueryTb")
        End If
    End Sub

    Private Sub BtnFees_Click(sender As Object, e As EventArgs) Handles BtnFees.Click

    End Sub

End Class