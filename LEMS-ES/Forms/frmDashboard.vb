Public Class frmDashboard
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

    End Sub
    Private Sub btnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click
        RemovePanel()
        With frmEnrollment
            .TopLevel = False
            Panel3.Controls.Add(frmEnrollment)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        RemovePanel()
        With frmStudents
            .TopLevel = False
            Panel3.Controls.Add(frmStudents)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        RemovePanel()
        With frmTeachers
            .TopLevel = False
            Panel3.Controls.Add(frmTeachers)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        RemovePanel()
        With frmSections
            .TopLevel = False
            Panel3.Controls.Add(frmSections)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnSubjects_Click(sender As Object, e As EventArgs)
        RemovePanel()
        With frmSubjects
            .TopLevel = False
            Panel3.Controls.Add(frmSubjects)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        RemovePanel()
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        RemovePanel()
        With frmMaintenance
            .TopLevel = False
            Panel3.Controls.Add(frmMaintenance)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Do You Want to Logout?", vbYesNo + vbQuestion) = vbYes Then
            'LogAction("has been logged out", "Logout")
            Application.Exit()
        End If
    End Sub

    Private Sub btnSY_Click(sender As Object, e As EventArgs)
        RemovePanel()
        With frmSY
            .TopLevel = False
            Panel3.Controls.Add(frmSY)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
