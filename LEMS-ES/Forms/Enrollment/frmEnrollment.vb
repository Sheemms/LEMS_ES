Public Class frmEnrollment
    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM Enrollment")
        dgvEnrolled.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmEnrollmentRegistration.Show()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText <> String.Empty Then
            Dim dataTable As DataTable = CType(dgvEnrolled.DataSource, DataTable)
            Dim filteredData As New DataTable()

            ' Clone the structure of the original DataTable
            filteredData = dataTable.Clone()

            ' Filter the rows based on the search text
            For Each row As DataRow In dataTable.Rows
                For Each col As DataColumn In dataTable.Columns
                    If row(col.ColumnName).ToString().Contains(searchText) Then
                        filteredData.ImportRow(row)
                        Exit For ' Break out of the inner loop once a match is found
                    End If
                Next
            Next

            dgvEnrolled.DataSource = filteredData
        Else
            ' If search text is empty, reload original data
            loadrecords()
        End If
    End Sub
End Class