Public Class frmPayments
    Public idPayment As Integer = 0
    Private Sub FrmPayments_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
        GetSchoolYear(LabelSY)
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
            txtTuition.Text = Format(CDbl(.Rows(0)(7)))
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

        Query("SELECT * FROM top")
        CmbTerms.DataSource = ds.Tables("QueryTb")
        CmbTerms.ValueMember = "ID"
        CmbTerms.DisplayMember = "Terms"
        CmbTerms.SelectedIndex = -1


        DgvReceipt.Rows.Add("Tuition", Val(txtTuition.Text))
        DgvReceipt.Rows.Add("Miscellaneous", Val(txtMiscellaneous.Text))
    End Sub

    Private Sub CalculateTotalPayment()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DgvReceipt.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso IsNumeric(cell.Value) Then
                    total += cell.Value
                End If
            Next
        Next

        LabelTotalPayment.Text = total
    End Sub
    Public Sub SubtractPayments(currentPayment As Decimal, totalPayment As Decimal) ' Assuming payment amounts are in decimal format
        Dim remainingPayment As Decimal = currentPayment - totalPayment
        MessageBox.Show($"Remaining Payment: {remainingPayment}")
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
        ' Check if cmbOtherFee.SelectedValue is already in DgvReceipt
        Dim isAlreadyAdded As Boolean = False
        For Each row As DataGridViewRow In DgvReceipt.Rows
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = cmbOtherFee.Text Then
                isAlreadyAdded = True
                Exit For
            End If
        Next

        If isAlreadyAdded Then
            MsgBox("This fee has already been added.")
        Else
            ' Retrieve the amount from the database
            Query("SELECT OF_Amount FROM otherfee WHERE ID ='" & cmbOtherFee.SelectedValue & "'")

            ' Check if any rows were returned by the query
            If ds.Tables("QueryTb").Rows.Count > 0 Then
                Dim amount As Decimal = Convert.ToDecimal(ds.Tables("QueryTb").Rows(0)("OF_Amount"))

                ' Add the fee to the DataGridView
                DgvReceipt.Rows.Add(cmbOtherFee.Text, amount)
            Else
                MsgBox("Please select other fee first")
            End If
        End If
    End Sub


    Private Sub BtnPayments_Click(sender As Object, e As EventArgs) Handles BtnPayments.Click

        ClassPayments.PaymentsRef()
        ClearFields(Me, idPayment)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim selectedValue As String = RbChanges()

        If selectedValue IsNot Nothing Then
            ' Add a row to DgvReceipt
            DgvReceipt.Rows.Add(selectedValue, Val(TxtChanges.Text))
        Else
            ' Display a message if no RadioButton is checked
            MsgBox("Please select another fee first")
        End If
    End Sub


    Private Sub RbNoChanges_CheckedChanged(sender As Object, e As EventArgs) Handles RbNoChanges.CheckedChanged
        TxtChanges.Enabled = Not RbNoChanges.Checked
    End Sub

    Private Sub DgvReceipt_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DgvReceipt.RowsAdded
        CalculateTotalPayment()
    End Sub

    Private Sub DgvReceipt_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvReceipt.CellContentClick
        CalculateTotalPayment()

        If e.ColumnIndex = DgvReceipt.Columns("colDelete").Index AndAlso e.RowIndex >= 0 Then
            DgvReceipt.Rows.RemoveAt(e.RowIndex)
            CalculateTotalPayment()
        End If
    End Sub

    Private Sub TxtCurPayment_TextChanged(sender As Object, e As EventArgs) Handles TxtCurPayment.TextChanged
        'SubtractPayments(LabelTotalPayment.Text, TxtCurPayment.Text)
    End Sub
End Class