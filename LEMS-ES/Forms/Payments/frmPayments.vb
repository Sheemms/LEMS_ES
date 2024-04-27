﻿Public Class frmPayments
    Public idPayment As Integer = 0
    Public idRegisteredStudents As Integer = 0
    Private Sub FrmPayments_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
        GetSchoolYear(LabelSY)
        txtTuition.Clear()
        txtMiscellaneous.Clear()
    End Sub
    Public Sub LoadData()
        'Query("SELECT a.ID, a.EID, a.SchoolYear, b.LRN, CONCAT(b.Lastname, ' ', b.Firstname, ' ', b.MiddleInitial) Fullname, 
        '                c.SectionRoom, d.GradeLevel, e.Amount
        '        FROM enrollment a
        '        JOIN student b ON a.LRN = b.LRN 
        '        JOIN section c ON a.SectionID = c.ID
        '        JOIN gradelevel d ON a.GradeLevel_ID = d.ID
        '        JOIN tuition e ON d.ID = e.GradeLevel_ID
        '        WHERE b.LRN = '" & txtLRN.Text & "'")
        'DgvTransactionHistory.DataSource = ds.Tables("QueryTb")
        'With ds.Tables("QueryTb")
        '    LabelEID.Text = .Rows(0)(1)
        '    LabelSY.Text = .Rows(0)(2).ToString
        '    txtLRN.Text = .Rows(0)(3)
        '    txtStudName.Text = .Rows(0)(4)
        '    txtSection.Text = .Rows(0)(5)
        '    txtGradeLvl.Text = .Rows(0)(6)
        '    txtTuition.Text = Format(CDbl(.Rows(0)(7)))
        'End With

        'this query is for DgvRegisteredStudents
        Query("SELECT a.ID, a.SchoolYear, a.EID, b.LRN, CONCAT(b.Lastname, ' ', b.Firstname, ' ', b.MiddleInitial) Fullname, 
                c.SectionRoom, d.GradeLevel, DATE_FORMAT(a.Enrollment_Date, '%Y-%m-%d') Enrollment_Date, a.Status 
                FROM enrollment a
                JOIN student b ON a.LRN = b.LRN 
                JOIN section c ON a.SectionID = c.ID
                JOIN gradelevel d ON a.GradeLevel_ID = d.ID")
        DgvRegisteredStudents.DataSource = ds.Tables("QueryTb")


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
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
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
            Query("SELECT OF_Amount FROM otherfee WHERE ID ='" & cmbOtherFee.SelectedValue & "'")

            If ds.Tables("QueryTb").Rows.Count > 0 Then
                Dim amount As Decimal = Convert.ToDecimal(ds.Tables("QueryTb").Rows(0)("OF_Amount"))

                DgvReceipt.Rows.Add(cmbOtherFee.Text, Format(CDec(amount)))
            Else
                MsgBox("Please select other fee first")
            End If
        End If
    End Sub
    Private Sub BtnPayments_Click(sender As Object, e As EventArgs) Handles BtnPayments.Click
#Region "IS_EMPTY"
        If IS_EMPTY(txtLRN) Then Return
        If IS_EMPTY(txtStudName) Then Return
        If IS_EMPTY(txtGradeLvl) Then Return
        If IS_EMPTY(txtSection) Then Return
        If IS_EMPTY(txtTuition) Then Return
        If IS_EMPTY(txtMiscellaneous) Then Return
        If IS_EMPTY(cmbOtherFee) Then Return
        If IS_EMPTY(cmbModeofPayment) Then Return
        If IS_EMPTY(TxtChanges) Then Return
#End Region
        ClassPayments.PaymentsRef()
        ClearFields(Me, idPayment)
    End Sub
    Private Sub CalculateTotalPayment()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DgvReceipt.Rows
            If row.Cells(1).Value IsNot Nothing AndAlso IsNumeric(row.Cells(1).Value) Then
                Dim paymentAmount As Decimal = CDec(row.Cells(1).Value)

                If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = "Discount" Then
                    total -= paymentAmount
                Else
                    total += paymentAmount
                End If
            End If
        Next

        LabelTotalPayment.Text = Format(CDec(total))
    End Sub
    Public Sub SubtractPayments(currentPayment As Decimal, totalPayment As Decimal) ' Assuming payment amounts are in decimal format
        Dim remainingPayment As Decimal = currentPayment - totalPayment
        LabelCurrentBalance.Text = Format(CDec(remainingPayment))
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
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim selectedValue As String = RbChanges()

        If selectedValue IsNot Nothing Then
            Dim alreadyExists As Boolean = False
            For Each row As DataGridViewRow In DgvReceipt.Rows
                If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = selectedValue Then
                    alreadyExists = True
                    Exit For
                End If
            Next

            If Not alreadyExists Then
                DgvReceipt.Rows.Add(selectedValue, Format(CDec(Val(TxtChanges.Text))))
                TxtChanges.Clear()
            Else
                MsgBox("Selected value already exists in the receipt.")
            End If
        Else
            MsgBox("Please select changes first.")
        End If
    End Sub
    Private Sub RbNoChanges_CheckedChanged(sender As Object, e As EventArgs) Handles RbNoChanges.CheckedChanged
        TxtChanges.Text = 0
        TxtChanges.Enabled = Not RbNoChanges.Checked
    End Sub
    Private Sub RbAdditional_CheckedChanged(sender As Object, e As EventArgs) Handles RbAdditional.CheckedChanged
        TxtChanges.Clear()
        TxtChanges.Enabled = RbAdditional.Checked
    End Sub
    Private Sub RbDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles RbDiscount.CheckedChanged
        TxtChanges.Clear()
        TxtChanges.Enabled = RbDiscount.Checked
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
    Private Sub TxtCurPayment_TextChanged(sender As Object, e As EventArgs) Handles TxtCurPayment.TextChanged, LabelTotalPayment.TextChanged
        Dim totalPayment As Decimal
        Dim currentPayment As Decimal

        If Decimal.TryParse(LabelTotalPayment.Text, totalPayment) Then
            If Decimal.TryParse(TxtCurPayment.Text, currentPayment) Then
                SubtractPayments(totalPayment, currentPayment)
                If currentPayment > totalPayment Then
                    MsgBox("Please pay the exact amount.")
                    TxtCurPayment.Clear()
                    LabelCurrentBalance.Text = "00000.00"
                End If
            End If
        End If
    End Sub
    Private Sub DgvRegisteredStudents_DoubleClick(sender As Object, e As EventArgs) Handles DgvRegisteredStudents.DoubleClick
        If DgvRegisteredStudents.SelectedRows.Count > 0 Then
            With DgvRegisteredStudents.SelectedRows(0)
                idRegisteredStudents = .Cells(0).Value
                LabelSY.Text = .Cells(1).Value
                LabelEID.Text = .Cells(2).Value
                txtLRN.Text = .Cells(3).Value
                txtStudName.Text = .Cells(4).Value
                txtSection.Text = .Cells(5).Value
                txtGradeLvl.Text = .Cells(6).Value
            End With
            LabelORNO.Text = ORNOGenerate()
        End If

        Query("SELECT * FROM tuition")
        DgvTransactionHistory.DataSource = ds.Tables("QueryTb")
        With ds.Tables("QueryTb")
            txtTuition.Text = Format(CDec(.Rows(0)(2)))
        End With

        Query("SELECT * FROM miscellaneous")
        DgvTransactionHistory.DataSource = ds.Tables("QueryTb")
        With ds.Tables("QueryTb")
            txtMiscellaneous.Text = .Rows(0)(1)
        End With

        DgvReceipt.Rows.Add("Tuition", Decimal.Parse(txtTuition.Text))
        DgvReceipt.Rows.Add("Miscellaneous", Decimal.Parse(txtMiscellaneous.Text))
    End Sub
    Private Sub cmbModeofPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModeofPayment.SelectedIndexChanged
        If cmbModeofPayment.SelectedIndex = 0 Then
            Guna2NumericUpDown1.Value = 0
            Guna2NumericUpDown1.Enabled = False
        Else
            Guna2NumericUpDown1.Enabled = True
        End If
    End Sub

End Class