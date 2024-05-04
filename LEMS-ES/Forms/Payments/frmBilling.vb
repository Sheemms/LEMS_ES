Public Class FrmBilling
    Private Sub FrmBilling_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadRecords()
        'LoadEnrolledStudents()
        LoadTransactionHistory()
    End Sub

    Public Sub LoadRecords()
        Query("SELECT a.ID, a.EID, b.LRN, CONCAT(b.Lastname, ' ', b.Firstname, ' ', b.MiddleInitial) Fullname, c.SectionRoom, d.GradeLevel, 
                CONCAT(e.Start_Year, '-', e.End_Year) SchoolYear, 
                DATE_FORMAT(a.Enrollment_Date, '%Y-%m-%d') Enrollment_Date, a.Status
                FROM enrollment a
                JOIN student b ON a.LRN = b.LRN 
                JOIN section c ON a.SectionID = c.ID
                JOIN gradelevel d ON c.GradeLevel_ID = d.ID
                JOIN schoolyear e ON a.SchoolYear = e.ID
                JOIN payment f ON b.LRN = f.LRN
                WHERE a.Status = 'Enrolled'")
        dgvBilling.AutoGenerateColumns = False
        dgvBilling.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub LoadTransactionHistory()
        Query("SELECT  a.ID, a.ORID, a.EID, b.LRN, 
                CONCAT(b.Lastname, ', ', b.Firstname, ' ', b.MiddleInitial) Fullname,
                e.GradeLevel as Grade, d.SectionRoom as Section,
                a.Amount, a.ORDate as Date, c.Enrollment_Date, a.Terms
                FROM payment a
                JOIN student b ON a.LRN = b.LRN
                JOIN enrollment c ON b.LRN = c.LRN
                JOIN section d ON c.SectionID = d.ID
                JOIN gradelevel e ON d.GradeLevel_ID = e.ID")
        DgvEnrolledStudent.AutoGenerateColumns = False
        DgvEnrolledStudent.DataSource = ds.Tables("QueryTb")
    End Sub
    Private Sub DgvBilling_DoubleClick(sender As Object, e As EventArgs) Handles dgvBilling.DoubleClick
        If dgvBilling.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvBilling.SelectedRows(0)
            Dim StudEID As String = selectedRow.Cells("EIDcolumn").Value.ToString()
            DgvBillingAssesment.Rows.Clear()

            _totalbill = Convert.ToDouble(CmdScalar("SELECT IFNULL(SUM(Tuition + Miscellaneous), 0) AS totalbill 
                                        FROM payment
                                        WHERE EID = '" & StudEID & "'"))

            _totalOtherFee = Convert.ToDouble(CmdScalar("SELECT IFNULL(SUM(b.Amount), 0)
                                             FROM feeor a
                                             JOIN otherfee b ON a.OFID = b.ID
                                             JOIN payment c ON a.ORID = c.ORID
                                             WHERE c.EID = '" & StudEID & "'"))

            _totalChanges = Convert.ToDouble(CmdScalar("SELECT IFNULL(SUM(a.Amount), 0)
                                             FROM fee_changes a
                                             JOIN payment b ON a.ORID = b.ORID
                                             WHERE b.EID = '" & StudEID & "'"))

            _totalPayment = Convert.ToDouble(CmdScalar("SELECT SUM(TotalAmount) AS TotalPayment FROM (
                                                                    SELECT SUM(Amount) AS TotalAmount FROM payment
                                                                    WHERE EID = '" & StudEID & "'
                                                                    UNION ALL
                                                                    SELECT SUM(Amount) AS TotalAmount FROM fees
                                                                    WHERE EID = '" & StudEID & "') AS CombinedAmounts"))

            Dim totalAmount As Double = _totalbill + _totalOtherFee + _totalChanges

            FrmFee.idFees = selectedRow.Cells(0).Value
            FrmFee.LabelEID.Text = selectedRow.Cells(1).Value
            FrmFee.txtLRN.Text = selectedRow.Cells(2).Value
            FrmFee.txtStudName.Text = selectedRow.Cells(3).Value
            FrmFee.txtGradeLvl.Text = selectedRow.Cells(4).Value
            FrmFee.txtSection.Text = selectedRow.Cells(5).Value
            FrmFee.LabelSY.Text = selectedRow.Cells(6).Value
            FrmFee.TxtTotalTuition.Text = totalAmount.ToString("N2")
            FrmFee.TxtTotalPayment.Text = _totalPayment.ToString("N2")
            FrmFee.TxtTotalBalance.Text = (totalAmount - _totalPayment).ToString("N2")
            Dim currentPaymentText As String = FrmFee.TxtCurrentPayment.Text
            Dim currentPaymentValue As Double

            If Double.TryParse(currentPaymentText, currentPaymentValue) Then
                FrmFee.TxtCurrentBalance.Text = (totalAmount - currentPaymentValue).ToString("N2")
            Else
                FrmFee.TxtCurrentBalance.Text = ""
            End If
            FrmFee.LabelORNO.Text = ORNOGenerate()
            FrmFee.Show()
        End If
    End Sub
    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText <> String.Empty Then
            Dim dataTable As DataTable = CType(dgvBilling.DataSource, DataTable)
            Dim filteredData As New DataTable()

            filteredData = dataTable.Clone()

            For Each row As DataRow In dataTable.Rows
                For Each col As DataColumn In dataTable.Columns
                    If row(col.ColumnName).ToString().Contains(searchText) Then
                        filteredData.ImportRow(row)
                        Exit For
                    End If
                Next
            Next

            dgvBilling.DataSource = filteredData
        Else
            'LoadRecords()
        End If
    End Sub

    Private Sub ToolStripTextBox2_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox2.Click
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText <> String.Empty Then
            Dim dataTable As DataTable = CType(dgvBilling.DataSource, DataTable)
            Dim filteredData As New DataTable()

            filteredData = dataTable.Clone()

            For Each row As DataRow In dataTable.Rows
                For Each col As DataColumn In dataTable.Columns
                    If row(col.ColumnName).ToString().Contains(searchText) Then
                        filteredData.ImportRow(row)
                        Exit For
                    End If
                Next
            Next

            dgvBilling.DataSource = filteredData
        Else
            'LoadRecords()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frmPayments.Show()
    End Sub

#Region "Tabpage2"
    Dim _eid, _lrn, _name As String
    Dim _totalbill As Double
    Dim _totalPayment As Double
    Dim _totalOtherFee As Double
    Dim _totalChanges As Double
    Private Sub DgvEnrolledStudent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEnrolledStudent.CellContentClick
        Dim column As String = DgvEnrolledStudent.Columns(e.ColumnIndex).Name
        Dim StudEID As String = DgvEnrolledStudent.Rows(e.RowIndex).Cells("colEID").Value.ToString()
        DgvBillingAssesment.Rows.Clear()
        _totalbill = Convert.ToDouble(CmdScalar("SELECT IFNULL(SUM(Tuition + Miscellaneous), 0) AS totalbill 
                                        FROM payment
                                        WHERE EID = '" & StudEID & "'"))

        _totalOtherFee = Convert.ToDouble(CmdScalar("SELECT IFNULL(SUM(b.Amount), 0)
                                             FROM feeor a
                                             JOIN otherfee b ON a.OFID = b.ID
                                             JOIN payment c ON a.ORID = c.ORID
                                             WHERE c.EID = '" & StudEID & "'"))

        _totalChanges = Convert.ToDouble(CmdScalar("SELECT IFNULL(SUM(
                                    CASE WHEN a.Description = 'Discount' THEN -a.Amount ELSE a.Amount END), 0)
                                FROM fee_changes a
                                JOIN payment b ON a.ORID = b.ORID
                                WHERE b.EID = '" & StudEID & "'"))

        _totalPayment = Convert.ToDouble(CmdScalar("SELECT SUM(TotalAmount) AS TotalPayment FROM (
                                                                    SELECT SUM(Amount) AS TotalAmount FROM payment
                                                                    WHERE EID = '" & StudEID & "'
                                                                    UNION ALL
                                                                    SELECT SUM(Amount) AS TotalAmount FROM fees
                                                                    WHERE EID = '" & StudEID & "') AS CombinedAmounts"))

        Dim totalAmount As Double = _totalbill + _totalOtherFee + _totalChanges

        If column = "colView" AndAlso e.RowIndex >= 0 Then
            _lrn = DgvEnrolledStudent.Rows(e.RowIndex).Cells(4).Value.ToString()
            _name = DgvEnrolledStudent.Rows(e.RowIndex).Cells(5).Value.ToString()
            LabelStudLRN.Text = $"{_lrn} | {_name}"

            Label1.Text = totalAmount.ToString("N2")
            Label4.Text = _totalPayment.ToString("N2")
            Label6.Text = (totalAmount - _totalPayment).ToString("N2")

            Dim enrollmentDate As DateTime = DateTime.Parse(DgvEnrolledStudent.Rows(e.RowIndex).Cells("Enrollment_Date").Value.ToString())
            Dim enrollmentTerms As Integer = Convert.ToInt32(DgvEnrolledStudent.Rows(e.RowIndex).Cells("Terms").Value)

            Dim startYear As Integer = enrollmentDate.Year
            Dim x As Integer = enrollmentDate.Month
            Dim startDay As Integer = enrollmentDate.Day

            Dim termAmount As Double = _totalbill / enrollmentTerms

            For i As Integer = 0 To enrollmentTerms - 1
                x += 1
                If x >= 7 AndAlso x < 12 Then
                    DgvBillingAssesment.Rows.Add($"{x}-{startDay}-{startYear}", termAmount.ToString("N2"))
                ElseIf x = 12 Then
                    DgvBillingAssesment.Rows.Add($"{x}-{startDay}-{startYear}", termAmount.ToString("N2"))
                    x = 0
                    startYear += 1
                Else
                    DgvBillingAssesment.Rows.Add($"{x}-{startDay}-{startYear}", termAmount.ToString("N2"))
                End If
            Next

            Query("SELECT 'Tuition' AS Description, Tuition as Amount
                    FROM payment
                    WHERE EID = '" & StudEID & "'
                    UNION ALL
                    SELECT 'Miscellaneous' as Description, Miscellaneous as Amount
                    FROM payment
                    WHERE EID = '" & StudEID & "'
                    UNION ALL
                    SELECT b.Description, b.Amount FROM feeor a 
                    JOIN otherfee b ON a.OFID = b.ID 
                    JOIN payment c ON a.ORID = c.ORID
                    WHERE c.EID = '" & StudEID & "'
                    UNION ALL 
                    SELECT a.Description, a.Amount FROM fee_changes a
                    JOIN payment b ON a.ORID = b.ORID
                    WHERE b.EID = '" & StudEID & "'")
            DgvBillingRecords.DataSource = ds.Tables("QueryTb")


            Query("SELECT DATE_FORMAT(ORDate, '%m-%d-%Y') ORDate, Amount FROM payment WHERE EID ='" & StudEID & "'
                    UNION ALL
                    SELECT DATE_FORMAT(ORDate, '%m-%d-%Y') ORDate, Amount From fees WHERE EID ='" & StudEID & "'")
            DgvTransactionHistory.DataSource = ds.Tables("QueryTb")
        End If
    End Sub
#End Region
End Class