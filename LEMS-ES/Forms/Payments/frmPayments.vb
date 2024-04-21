Public Class frmPayments
    Public idPayment As Integer = 0
    Private Sub FrmPayments_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
        GetSchoolYear(LabelSY)
        LabelORNO.Text = ORNOGenerate()
    End Sub
    Public Sub LoadData()
        Query("SELECT a.ID, a.EID, a.SchoolYear, b.LRN, CONCAT(b.Lastname, ' ', b.Firstname, ' ', b.MiddleInitial) Fullname, 
                        c.SectionRoom, d.GradeLevel, e.Amount
                FROM enrollment a
                JOIN student b ON a.LRN = b.LRN 
                JOIN section c ON a.SectionID = c.ID
                JOIN gradelevel d ON a.GradeLevel_ID = d.ID
                JOIN tuition e ON d.ID = e.GradeLevel_ID
                WHERE b.LRN = '" & txtLRN.Text & "'")
        DgvTransactionHistory.DataSource = ds.Tables("QueryTb")
        With ds.Tables("QueryTb")
            LabelEID.Text = .Rows(0)(1)
            LabelSY.Text = .Rows(0)(2).ToString
            txtLRN.Text = .Rows(0)(3)
            txtStudName.Text = .Rows(0)(4)
            txtSection.Text = .Rows(0)(5)
            txtGradeLvl.Text = .Rows(0)(6)
            txtTuition.Text = .Rows(0)(7)
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


        DgvReceipt.Rows.Add("Tuition", Val(txtTuition.Text))
        DgvReceipt.Rows.Add("Miscellaneous", Val(txtMiscellaneous.Text))

        Dim total As Double = 0

        For Each row As DataGridViewRow In DgvReceipt.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso IsNumeric(cell.Value) Then
                    total += CDbl(cell.Value)
                End If
            Next
        Next

        LabelTotalPayment.Text = total
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
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Query("SELECT OF_Amount FROM otherfee WHERE ID ='" & cmbOtherFee.SelectedValue & "'")
        Dim amount As Decimal = ds.Tables("QueryTb").Rows(0)(0)
        DgvReceipt.Rows.Add(cmbOtherFee.Text, amount)
    End Sub

    Private Sub BtnPayments_Click(sender As Object, e As EventArgs) Handles BtnPayments.Click
        ClassPayments.PaymentsRef()
        ClearFields(Me, idPayment)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        DgvReceipt.Rows.Add(RbChanges(), Val(TxtChanges.Text))
    End Sub

    Private Sub RbNoChanges_CheckedChanged(sender As Object, e As EventArgs) Handles RbNoChanges.CheckedChanged
        TxtChanges.Enabled = Not RbNoChanges.Checked
    End Sub
End Class