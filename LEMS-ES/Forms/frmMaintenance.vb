Public Class frmMaintenance
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
End Class