Imports MySql.Data.MySqlClient
Public Class frmReports
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim dt As New DataTable("DS_ClassList")

        Dim adp = New MySqlDataAdapter(" ", con)

        adp.Fill(dt)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No Records")
            Exit Sub
        End If

        Dim crystal As New ClassList
        crystal.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = crystal
        CrystalReportViewer1.Refresh()
    End Sub
End Class