Public Class frmPayments
    Public idPayment As Integer = 0
    Private Sub frmPayments_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
    Public Sub LoadData()
        Query("SELECT a.ID, a.SchoolYear, b.LRN, CONCAT(b.Lastname, ' ', b.Firstname, ' ', b.MiddleInitial) Fullname, c.SectionRoom, d.GradeLevel, e.Amount
                FROM enrollment a
                JOIN student b ON a.LRN = b.LRN 
                JOIN section c ON a.SectionID = c.ID
                JOIN gradelevel d ON a.GradeLevel_ID = d.ID
                JOIN tuition e ON d.ID = e.GradeLevel_ID
                WHERE b.LRN = '" & txtLRN.Text & "'")
        DgvTransactionHistory.DataSource = ds.Tables("QueryTb")
        With ds.Tables("QueryTb")
            lblSY.Text = .Rows(0)(1).ToString
            txtLRN.Text = .Rows(0)(2)
            txtStudName.Text = .Rows(0)(3)
            txtSection.Text = .Rows(0)(4)
            txtGradeLvl.Text = .Rows(0)(5)
            txtTuition.Text = .Rows(0)(6)
        End With


        Query("SELECT * FROM miscellaneous")
        DgvTransactionHistory.DataSource = ds.Tables("QueryTb")
        With ds.Tables("QueryTb")
            txtMiscellaneous.Text = .Rows(0)(1)
        End With

        Query("SELECT * FROM otherfee")
        DgvTransactionHistory.DataSource = ds.Tables("QueryTb")
        With ds.Tables("QueryTb")
            cmbOtherFee.Text = .Rows(0)(1)
        End With

        Query("SELECT * FROM otherfee")
        cmbOtherFee.DataSource = ds.Tables("QueryTb")
        cmbOtherFee.ValueMember = "ID"
        cmbOtherFee.DisplayMember = "Description"
        cmbOtherFee.SelectedIndex = -1

        Query("SELECT * FROM mop")
        cmbModeofPayment.DataSource = ds.Tables("QueryTb")
        cmbModeofPayment.ValueMember = "ID"
        cmbModeofPayment.DisplayMember = "Mode"
        cmbModeofPayment.SelectedIndex = -1

    End Sub

    Public Function RbChanges() As String
        If RbAdditional.Checked Then
            Return "Additional"
        ElseIf RbDiscount.Checked Then
            Return "Discount"
        ElseIf RbNoChanges.Checked Then
            Return "No Changes"
        Else
            Return Nothing
        End If
    End Function
    Private Sub TxtChanges_TextChanged(sender As Object, e As EventArgs) Handles TxtChanges.TextChanged
        TxtChanges.Enabled = RbAdditional.Checked Or RbDiscount.Checked
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click

    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        DgvReceipt.Rows.Add("Tuition", Val(txtTuition.Text))
        DgvReceipt.Rows.Add("Miscellaneous", Val(txtMiscellaneous.Text))

        Query("SELECT OF_Amount FROM otherfee WHERE ID ='" & cmbOtherFee.SelectedValue & "'")
        Dim amount As Decimal = ds.Tables("QueryTb").Rows(0)(0)
        DgvReceipt.Rows.Add(cmbOtherFee.Text, amount)
        DgvReceipt.Rows.Add(RbChanges(), Val(TxtChanges.Text))
    End Sub

End Class