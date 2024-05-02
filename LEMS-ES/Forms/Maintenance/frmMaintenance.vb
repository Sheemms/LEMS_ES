﻿Imports MySql.Data.MySqlClient
Public Class FrmMaintenance
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
    Private Sub ROOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ROOMToolStripMenuItem.Click
        MaintenanceRemovePanel()
        With FrmRoom
            .TopLevel = False
            Panel1.Controls.Add(FrmRoom)
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
    Private Sub TuitionFeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TuitionFeeToolStripMenuItem.Click
        MaintenanceRemovePanel()
        With frmTuitionFee
            .TopLevel = False
            Panel1.Controls.Add(frmTuitionFee)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub AuditTrailToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MaintenanceRemovePanel()
        With FrmAuditTrail
            .TopLevel = False
            Panel1.Controls.Add(FrmAuditTrail)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GradeLevelMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradeLevelMaintenanceToolStripMenuItem.Click
        MaintenanceRemovePanel()
        With frmGradeLevel
            .TopLevel = False
            Panel1.Controls.Add(frmGradeLevel)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        MaintenanceRemovePanel()
        With frmDepartment
            .TopLevel = False
            Panel1.Controls.Add(frmDepartment)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub RequirementsMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequirementsMaintenanceToolStripMenuItem.Click
        MaintenanceRemovePanel()
        With frmRequirements
            .TopLevel = False
            Panel1.Controls.Add(frmRequirements)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

End Class