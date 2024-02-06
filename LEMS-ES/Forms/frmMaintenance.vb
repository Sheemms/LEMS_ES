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
        MaintenanceRemovePanel()
        With frmSY
            .TopLevel = False
            Panel1.Controls.Add(frmSY)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SectionMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionMaintenanceToolStripMenuItem.Click
        MaintenanceRemovePanel()
        With frmSections
            .TopLevel = False
            Panel1.Controls.Add(frmSections)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SubjectMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectMaintenanceToolStripMenuItem.Click
        MaintenanceRemovePanel()
        With frmSubjects
            .TopLevel = False
            Panel1.Controls.Add(frmSubjects)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub UserMaintenanceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UserMaintenanceToolStripMenuItem1.Click
        MaintenanceRemovePanel()
        With frmUserMaintenance
            .TopLevel = False
            Panel1.Controls.Add(frmUserMaintenance)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub OtherFeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherFeeToolStripMenuItem.Click
        MaintenanceRemovePanel()
    End Sub

    Private Sub TuitionFeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TuitionFeeToolStripMenuItem.Click
        MaintenanceRemovePanel()
    End Sub
    Private Sub AuditTrailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuditTrailToolStripMenuItem.Click
        MaintenanceRemovePanel()
        With frmAuditTrail
            .TopLevel = False
            Panel1.Controls.Add(frmAuditTrail)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
End Class