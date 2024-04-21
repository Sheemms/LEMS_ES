Public Class frmDashboard

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        RemovePanel()
        With frmCharts
            .TopLevel = False
            Panel3.Controls.Add(frmCharts)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub BtnEnrollment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click
        RemovePanel()
        With frmEnrollment
            .TopLevel = False
            Panel3.Controls.Add(frmEnrollment)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub BtnScheduling_Click(sender As Object, e As EventArgs) Handles btnScheduling.Click
        RemovePanel()
        With frmSchedule
            .TopLevel = False
            Panel3.Controls.Add(frmSchedule)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub BtnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        RemovePanel()
        With frmStudents
            .TopLevel = False
            Panel3.Controls.Add(frmStudents)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub BtnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        RemovePanel()
        With frmTeachers
            .TopLevel = False
            Panel3.Controls.Add(frmTeachers)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        RemovePanel()
        With frmBilling
            .TopLevel = False
            Panel3.Controls.Add(frmBilling)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnSubjects_Click(sender As Object, e As EventArgs)
        RemovePanel()
        With frmSubjects
            .TopLevel = False
            Panel3.Controls.Add(frmSubjects)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        RemovePanel()
        With frmReports
            .TopLevel = False
            Panel3.Controls.Add(frmReports)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        RemovePanel()
        With frmMaintenance
            .TopLevel = False
            Panel3.Controls.Add(frmMaintenance)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Are you sure you want to Logout?", vbYesNo + vbQuestion) = vbYes Then
            'LogAction("has been logged out", "Logout")
            RemovePanel()
            MaintenanceRemovePanel()

            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BtnSY_Click(sender As Object, e As EventArgs)
        RemovePanel()
        With frmSY
            .TopLevel = False
            Panel3.Controls.Add(frmSY)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = DateTime.Now.ToString("g")
    End Sub

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        dropdownMenu()
    End Sub
    Private Sub DropdownMenu()
        TransactionPanel.Visible = False
        DataEntryPanel.Visible = False
        GradingPanel.Visible = False
    End Sub
    Private Sub ShowHideTransactionPanel()
        If TransactionPanel.Visible = False Then
            TransactionPanel.Visible = True
        Else
            If TransactionPanel.Visible = True Then
                TransactionPanel.Visible = False
            End If
        End If
    End Sub
    Private Sub ShowHideDataEntryPanel()
        If DataEntryPanel.Visible = False Then
            DataEntryPanel.Visible = True
        Else
            If DataEntryPanel.Visible = True Then
                DataEntryPanel.Visible = False
            End If
        End If
    End Sub
    Private Sub ShowHideGradingPanel()
        If GradingPanel.Visible = False Then
            GradingPanel.Visible = True
        Else
            If GradingPanel.Visible = True Then
                GradingPanel.Visible = False
            End If
        End If
    End Sub
    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        If PanelSidebar.Visible Then
            ' Hide the sidebar
            PanelSidebar.Visible = False
            ' Expand the main content to fill the entire form
            Panel3.Width = Me.ClientRectangle.Width
        Else
            ' Show the sidebar
            PanelSidebar.Visible = True
            ' Shrink the main content to accommodate the sidebar
            Panel3.Width = Me.ClientRectangle.Width - PanelSidebar.Width
        End If
    End Sub

    Private Sub BtnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        ShowHideTransactionPanel()
    End Sub

    Private Sub BtnDataEntry_Click(sender As Object, e As EventArgs) Handles btnDataEntry.Click
        ShowHideDataEntryPanel()
    End Sub

    Private Sub BtnGrading_Click(sender As Object, e As EventArgs) Handles btnGrading.Click
        ShowHideGradingPanel()
    End Sub

    Private Sub BtnElemGrading_Click(sender As Object, e As EventArgs) Handles btnElemGrading.Click
        RemovePanel()
        With frmElementaryGrading
            .TopLevel = False
            Panel3.Controls.Add(frmElementaryGrading)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnJHSGrading_Click(sender As Object, e As EventArgs) Handles btnJHSGrading.Click
        RemovePanel()
        With frmJHSGrading
            .TopLevel = False
            Panel3.Controls.Add(frmJHSGrading)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
