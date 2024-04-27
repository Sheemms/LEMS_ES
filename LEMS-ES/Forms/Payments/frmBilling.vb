Public Class FrmBilling
    Private Sub FrmBilling_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadRecords()
    End Sub

    Public Sub LoadRecords()
        Query("SELECT a.ID, b.LRN, CONCAT(b.Lastname, ' ', b.Firstname, ' ', b.MiddleInitial) Fullname, c.SectionRoom, d.GradeLevel, a.SchoolYear, DATE_FORMAT(a.Enrollment_Date, '%Y-%m-%d') Enrollment_Date, a.Status 
                FROM enrollment a
                JOIN student b ON a.LRN = b.LRN 
                JOIN section c ON a.SectionID = c.ID
                JOIN gradelevel d ON a.GradeLevel_ID = d.ID
                WHERE a.Status = 'Enrolled'")
        dgvBilling.AutoGenerateColumns = False
        dgvBilling.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub LoadTransactionHistory()
        Query("SELECT a.ID, a.ORNO, a.ORDate, b.EID, b.LRN, CONCAT(c.Lastname, ' ', c.Firstname, ' ', c.MiddleInitial) Fullname, a.EncodedBy
                FROM payment a
                JOIN enrollment b ON a.EnrollmentID = b.ID
                JOIN student c ON a.LRN = c.LRN")
        DgvTransactHistory.DataSource = ds.Tables("QueryTb")
    End Sub
    Private Sub DgvBilling_DoubleClick(sender As Object, e As EventArgs) Handles dgvBilling.DoubleClick
        If dgvBilling.SelectedRows.Count > 0 Then
            With dgvBilling.SelectedRows(0)
                frmPayments.idPayment = .Cells(0).Value
                frmPayments.txtLRN.Text = .Cells(1).Value
            End With
            frmPayments.LabelORNO.Text = ORNOGenerate()
            frmPayments.Show()
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
End Class