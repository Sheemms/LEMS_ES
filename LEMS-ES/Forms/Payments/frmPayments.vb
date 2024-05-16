Public Class FrmPayments
    Public idPayment As Integer = 0
    Public idRegisteredStudents As Integer = 0
    Private Sub FrmPayments_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
        GetSchoolYear(LabelSY)
        txtTuition.Clear()
        txtMiscellaneous.Clear()
    End Sub
    Public Sub Clear()
        idPayment = 0
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox =
            {txtLRN, txtStudName, txtGradeLvl, txtSection, txtTuition, txtMiscellaneous, TxtCurPayment}
        cmbOtherFee.SelectedIndex = -1
        cmbModeofPayment.SelectedIndex = -1
        Guna2NumericUpDown1.Value = 0
        RbAdditional.Checked = False
        RbDiscount.Checked = False
        RbNoChanges.Checked = False
    End Sub
    Public Sub LoadData()
        Try
            Query("SELECT a.ID, CONCAT(e.Start_Year, '-', e.End_Year) SchoolYear, a.EID, b.LRN, CONCAT(b.Lastname, ' ', b.Firstname, ' ', b.MiddleInitial) Fullname, 
                c.SectionRoom, d.GradeLevel, DATE_FORMAT(a.Enrollment_Date, '%Y-%m-%d') Enrollment_Date, a.Status 
                FROM enrollment a
                JOIN student b ON a.LRN = b.LRN 
                JOIN section c ON a.SectionID = c.ID
                JOIN gradelevel d ON c.GradeLevel_ID = d.ID
                JOIN schoolyear e ON a.SchoolYear = e.ID")
            DgvRegisteredStudents.DataSource = ds.Tables("QueryTb")


            Query("SELECT * FROM otherfee")
            DgvTransactionHistory.DataSource = ds.Tables("QueryTb")

            ' Populate cmbOtherFee
            cmbOtherFee.DataSource = ds.Tables("QueryTb")
            cmbOtherFee.ValueMember = "ID"
            cmbOtherFee.DisplayMember = "Description"
            cmbOtherFee.SelectedIndex = -1

            ' Check if there are rows in the table before accessing them
            If ds.Tables("QueryTb").Rows.Count > 0 Then
                cmbOtherFee.Text = ds.Tables("QueryTb").Rows(0)("Description").ToString()
            Else
                ' Handle case where there are no rows in the table
                cmbOtherFee.Text = "" ' or any default value you want to set
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        Try
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
                Query("SELECT Amount FROM otherfee WHERE ID ='" & cmbOtherFee.SelectedValue & "'")

                If ds.Tables("QueryTb").Rows.Count > 0 Then
                    Dim amount As Decimal = Convert.ToDecimal(ds.Tables("QueryTb").Rows(0)("Amount"))

                    DgvReceipt.Rows.Add(cmbOtherFee.Text, Format(CDec(amount)))
                Else
                    MsgBox("Please select other fee first")
                End If
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub BtnPayments_Click(sender As Object, e As EventArgs) Handles BtnPayments.Click
#Region "IsEmptyField"
        If Not IsEmptyField(txtLRN.Text.Trim()) Then
            Info("Please enter a student LRN.")
            Return
        End If
        If Not IsEmptyField(txtStudName.Text.Trim()) Then
            Info("Please enter a student name.")
            Return
        End If
        If Not IsEmptyField(txtGradeLvl.Text.Trim()) Then
            Info("Please enter a grade level.")
            Return
        End If
        If Not IsEmptyField(txtSection.Text.Trim()) Then
            Info("Please enter a section.")
            Return
        End If
        If Not IsEmptyField(txtTuition.Text.Trim()) Then
            Info("Please enter a Tuition.")
            Return
        End If
        If Not IsEmptyField(txtMiscellaneous.Text.Trim()) Then
            Info("Please enter a miscellaneous.")
            Return
        End If
        If Not IsEmptyField(cmbOtherFee.Text.Trim()) Then
            Info("Please select a other fee.")
            Return
        End If
        If Not IsEmptyField(cmbModeofPayment.Text.Trim()) Then
            Info("Please select a mode of payment.")
            Return
        End If
#End Region
        If Not NoLeadingSpace(TxtCurPayment.Text.Trim()) Then
            Info("Current payment must have no multiple spaces between numbers.")
            Return
        End If
        ClassPayments.PaymentsRef()
    End Sub
    Private Sub CalculateTotalPayment()
        Try
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
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Public Sub SubtractPayments(currentPayment As Decimal, totalPayment As Decimal)
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
        Try
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
        Catch ex As Exception
            Critical(ex.Message)
        End Try
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
        Try
            CalculateTotalPayment()

            If e.ColumnIndex = DgvReceipt.Columns("colDelete").Index AndAlso e.RowIndex >= 0 Then
                DgvReceipt.Rows.RemoveAt(e.RowIndex)
                CalculateTotalPayment()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub TxtCurPayment_TextChanged(sender As Object, e As EventArgs) Handles TxtCurPayment.TextChanged, LabelTotalPayment.TextChanged
        Try
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
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub DgvRegisteredStudents_DoubleClick(sender As Object, e As EventArgs) Handles DgvRegisteredStudents.DoubleClick
        Try
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
            DgvReceipt.Rows.Clear()

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
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub CmbModeofPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModeofPayment.SelectedIndexChanged
        Try
            If cmbModeofPayment.SelectedIndex = 0 Then
                Guna2NumericUpDown1.Value = 0
                Guna2NumericUpDown1.Enabled = False
            Else
                Guna2NumericUpDown1.Enabled = True
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCurPayment.KeyPress, TxtChanges.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
End Class