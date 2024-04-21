Public Class frmBilling
    Private Sub frmBilling_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadRecords()
    End Sub

    Public Sub LoadRecords()
        Query("SELECT a.ID, b.LRN, CONCAT(b.Lastname, ' ', b.Firstname, ' ', b.MiddleInitial) Fullname, c.SectionRoom, d.GradeLevel, a.SchoolYear, a.Status 
                FROM enrollment a
                JOIN student b ON a.LRN = b.LRN 
                JOIN section c ON a.SectionID = c.ID
                JOIN gradelevel d ON a.GradeLevel_ID = d.ID")
        dgvBilling.AutoGenerateColumns = False
        dgvBilling.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub dgvBilling_DoubleClick(sender As Object, e As EventArgs) Handles dgvBilling.DoubleClick
        If dgvBilling.SelectedRows.Count > 0 Then
            With dgvBilling.SelectedRows(0)
                frmPayments.idPayment = .Cells(0).Value
                frmPayments.txtLRN.Text = .Cells(1).Value
            End With
            frmPayments.Show()
        End If
    End Sub
End Class