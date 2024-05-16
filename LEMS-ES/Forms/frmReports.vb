Imports MySql.Data.MySqlClient
Public Class FrmReports
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Dim dt As New DataTable("Dt_ClassList")
            Dim sectionName As String = TxtSection.Text.Trim()
            Dim adp = New MySqlDataAdapter("SELECT CONCAT(b.Start_Year, '-', b.End_Year) SY, d.GradeLevel as Grade, c.SectionRoom as Section, CONCAT(e.Lastname, ' ', e.Firstname) Teacher,
                                        f.LRN, f.Lastname, f.Firstname
                                        FROM enrollment a
                                        JOIN schoolyear b ON a.SchoolYear = b.ID
                                        JOIN section c ON a.SectionID = c.ID
                                        JOIN gradelevel d ON c.GradeLevel_ID = d.ID
                                        JOIN teacher e ON c.AdviserID = e.ID
                                        JOIN student f ON a.LRN = f.LRN
                                        WHERE c.SectionRoom = '" & sectionName & "'", con)

            adp.Fill(dt)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Records")
                Exit Sub
            End If

            Dim crystal As New ClassList
            crystal.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = crystal
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            Excla(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Dim dt As New DataTable("Dt_EnrolledStudents")

            Dim adp = New MySqlDataAdapter("SELECT a.ID, a.EID, CONCAT(b.Start_Year, '-', b.End_Year) SchoolYear, a.LRN, CONCAT(c.Lastname, ' ', c.Firstname) Fullname, d.SectionRoom as Section, 
                                        e.GradeLevel as Grade, a.Status, a.Enrollment_Date
                                        FROM enrollment a
                                        JOIN schoolyear b ON a.SchoolYear = b.ID
                                        JOIN student c ON a.LRN = c.LRN
                                        JOIN section d ON a.SectionID = d.ID
                                        JOIN gradelevel e ON d.GradeLevel_ID = e.ID
                                        WHERE a.Status = 'Enrolled'", con)

            adp.Fill(dt)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Records")
                Exit Sub
            End If

            Dim crystal As New Enrolled_Students
            crystal.SetDataSource(dt)
            CrystalReportViewer2.ReportSource = crystal
            CrystalReportViewer2.Refresh()
        Catch ex As Exception
            Excla(ex.Message)
        End Try
    End Sub
End Class