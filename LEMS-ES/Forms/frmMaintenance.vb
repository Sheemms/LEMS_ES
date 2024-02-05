Imports MySql.Data.MySqlClient
Public Class frmMaintenance
    Public Shared Function SectionParameter() As MySqlParameter()
        Try
            Dim SectionParam() As MySqlParameter = {
                New MySqlParameter("SectionRoom", frmSections.txtSectionName.Text),
                New MySqlParameter("Capacity", frmSections.txtSectionCapacity.Text)
                }
            Return SectionParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Private Sub SchoolYearMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchoolYearMaintenanceToolStripMenuItem.Click
        RemovePanel()
        With frmSY
            .TopLevel = False
            Panel1.Controls.Add(frmSY)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SectionMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionMaintenanceToolStripMenuItem.Click
        RemovePanel()
        With frmSections
            .TopLevel = False
            Panel1.Controls.Add(frmSections)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SubjectMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectMaintenanceToolStripMenuItem.Click
        RemovePanel()
        With frmSubjects
            .TopLevel = False
            Panel1.Controls.Add(frmSubjects)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub UserMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserMaintenanceToolStripMenuItem.Click
        RemovePanel()
        With frmUserMaintenance
            .TopLevel = False
            Panel1.Controls.Add(frmUserMaintenance)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
End Class