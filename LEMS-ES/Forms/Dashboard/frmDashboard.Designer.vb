<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashboard))
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.Guna2CirclePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSidebar = New System.Windows.Forms.Panel()
        Me.BtnSystemUtilities = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMaintenance = New Guna.UI2.WinForms.Guna2Button()
        Me.GradingPanel = New System.Windows.Forms.Panel()
        Me.btnJHSGrading = New Guna.UI2.WinForms.Guna2Button()
        Me.btnElemGrading = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGrading = New Guna.UI2.WinForms.Guna2Button()
        Me.DataEntryPanel = New System.Windows.Forms.Panel()
        Me.btnTeachers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStudents = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDataEntry = New Guna.UI2.WinForms.Guna2Button()
        Me.TransactionPanel = New System.Windows.Forms.Panel()
        Me.btnPayment = New Guna.UI2.WinForms.Guna2Button()
        Me.btnScheduling = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnEnrollment = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTransaction = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TopPanel.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSidebar.SuspendLayout()
        Me.GradingPanel.SuspendLayout()
        Me.DataEntryPanel.SuspendLayout()
        Me.TransactionPanel.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.Guna2CirclePictureBox1)
        resources.ApplyResources(Me.TopPanel, "TopPanel")
        Me.TopPanel.Name = "TopPanel"
        '
        'Guna2CirclePictureBox1
        '
        resources.ApplyResources(Me.Guna2CirclePictureBox1, "Guna2CirclePictureBox1")
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'PanelSidebar
        '
        resources.ApplyResources(Me.PanelSidebar, "PanelSidebar")
        Me.PanelSidebar.BackColor = System.Drawing.Color.White
        Me.PanelSidebar.Controls.Add(Me.BtnSystemUtilities)
        Me.PanelSidebar.Controls.Add(Me.btnLogout)
        Me.PanelSidebar.Controls.Add(Me.btnReports)
        Me.PanelSidebar.Controls.Add(Me.btnMaintenance)
        Me.PanelSidebar.Controls.Add(Me.GradingPanel)
        Me.PanelSidebar.Controls.Add(Me.btnGrading)
        Me.PanelSidebar.Controls.Add(Me.DataEntryPanel)
        Me.PanelSidebar.Controls.Add(Me.btnDataEntry)
        Me.PanelSidebar.Controls.Add(Me.TransactionPanel)
        Me.PanelSidebar.Controls.Add(Me.btnTransaction)
        Me.PanelSidebar.Controls.Add(Me.btnDashboard)
        Me.PanelSidebar.Controls.Add(Me.PanelLogo)
        Me.PanelSidebar.Name = "PanelSidebar"
        '
        'BtnSystemUtilities
        '
        Me.BtnSystemUtilities.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSystemUtilities.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSystemUtilities.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSystemUtilities.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.BtnSystemUtilities, "BtnSystemUtilities")
        Me.BtnSystemUtilities.FillColor = System.Drawing.Color.White
        Me.BtnSystemUtilities.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BtnSystemUtilities.Image = Global.LEMS_ES.My.Resources.Resources.maintenance
        Me.BtnSystemUtilities.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnSystemUtilities.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnSystemUtilities.Name = "BtnSystemUtilities"
        '
        'btnLogout
        '
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnLogout, "btnLogout")
        Me.btnLogout.FillColor = System.Drawing.Color.White
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnLogout.Image = Global.LEMS_ES.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnLogout.Name = "btnLogout"
        '
        'btnReports
        '
        Me.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnReports, "btnReports")
        Me.btnReports.FillColor = System.Drawing.Color.White
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnReports.Image = Global.LEMS_ES.My.Resources.Resources.file_report
        Me.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReports.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnReports.Name = "btnReports"
        '
        'btnMaintenance
        '
        Me.btnMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnMaintenance, "btnMaintenance")
        Me.btnMaintenance.FillColor = System.Drawing.Color.White
        Me.btnMaintenance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnMaintenance.Image = Global.LEMS_ES.My.Resources.Resources.maintenance
        Me.btnMaintenance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMaintenance.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnMaintenance.Name = "btnMaintenance"
        '
        'GradingPanel
        '
        Me.GradingPanel.BackColor = System.Drawing.Color.Silver
        Me.GradingPanel.Controls.Add(Me.btnJHSGrading)
        Me.GradingPanel.Controls.Add(Me.btnElemGrading)
        resources.ApplyResources(Me.GradingPanel, "GradingPanel")
        Me.GradingPanel.Name = "GradingPanel"
        '
        'btnJHSGrading
        '
        Me.btnJHSGrading.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnJHSGrading.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnJHSGrading.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnJHSGrading.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnJHSGrading, "btnJHSGrading")
        Me.btnJHSGrading.FillColor = System.Drawing.Color.Transparent
        Me.btnJHSGrading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnJHSGrading.Image = Global.LEMS_ES.My.Resources.Resources.pupil
        Me.btnJHSGrading.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnJHSGrading.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnJHSGrading.Name = "btnJHSGrading"
        '
        'btnElemGrading
        '
        Me.btnElemGrading.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnElemGrading.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnElemGrading.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnElemGrading.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnElemGrading, "btnElemGrading")
        Me.btnElemGrading.FillColor = System.Drawing.Color.Transparent
        Me.btnElemGrading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnElemGrading.Image = Global.LEMS_ES.My.Resources.Resources.pupil
        Me.btnElemGrading.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnElemGrading.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnElemGrading.Name = "btnElemGrading"
        '
        'btnGrading
        '
        Me.btnGrading.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGrading.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGrading.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGrading.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnGrading, "btnGrading")
        Me.btnGrading.FillColor = System.Drawing.Color.White
        Me.btnGrading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnGrading.Image = Global.LEMS_ES.My.Resources.Resources.grading
        Me.btnGrading.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnGrading.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnGrading.Name = "btnGrading"
        '
        'DataEntryPanel
        '
        Me.DataEntryPanel.BackColor = System.Drawing.Color.Silver
        Me.DataEntryPanel.Controls.Add(Me.btnTeachers)
        Me.DataEntryPanel.Controls.Add(Me.btnStudents)
        resources.ApplyResources(Me.DataEntryPanel, "DataEntryPanel")
        Me.DataEntryPanel.Name = "DataEntryPanel"
        '
        'btnTeachers
        '
        Me.btnTeachers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTeachers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTeachers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTeachers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnTeachers, "btnTeachers")
        Me.btnTeachers.FillColor = System.Drawing.Color.Transparent
        Me.btnTeachers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnTeachers.Image = Global.LEMS_ES.My.Resources.Resources.teacher
        Me.btnTeachers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTeachers.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnTeachers.Name = "btnTeachers"
        '
        'btnStudents
        '
        Me.btnStudents.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudents.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnStudents, "btnStudents")
        Me.btnStudents.FillColor = System.Drawing.Color.Transparent
        Me.btnStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnStudents.Image = Global.LEMS_ES.My.Resources.Resources.student_profile
        Me.btnStudents.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudents.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnStudents.Name = "btnStudents"
        '
        'btnDataEntry
        '
        Me.btnDataEntry.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDataEntry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDataEntry.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDataEntry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnDataEntry, "btnDataEntry")
        Me.btnDataEntry.FillColor = System.Drawing.Color.White
        Me.btnDataEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnDataEntry.Image = Global.LEMS_ES.My.Resources.Resources.data
        Me.btnDataEntry.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDataEntry.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnDataEntry.Name = "btnDataEntry"
        '
        'TransactionPanel
        '
        Me.TransactionPanel.BackColor = System.Drawing.Color.Silver
        Me.TransactionPanel.Controls.Add(Me.btnPayment)
        Me.TransactionPanel.Controls.Add(Me.btnScheduling)
        Me.TransactionPanel.Controls.Add(Me.BtnEnrollment)
        resources.ApplyResources(Me.TransactionPanel, "TransactionPanel")
        Me.TransactionPanel.Name = "TransactionPanel"
        '
        'btnPayment
        '
        Me.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnPayment, "btnPayment")
        Me.btnPayment.FillColor = System.Drawing.Color.Transparent
        Me.btnPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnPayment.Image = Global.LEMS_ES.My.Resources.Resources.sections
        Me.btnPayment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPayment.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnPayment.Name = "btnPayment"
        '
        'btnScheduling
        '
        Me.btnScheduling.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnScheduling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnScheduling.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnScheduling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnScheduling, "btnScheduling")
        Me.btnScheduling.FillColor = System.Drawing.Color.Transparent
        Me.btnScheduling.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnScheduling.Image = Global.LEMS_ES.My.Resources.Resources.Schedule
        Me.btnScheduling.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnScheduling.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnScheduling.Name = "btnScheduling"
        '
        'BtnEnrollment
        '
        Me.BtnEnrollment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEnrollment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnEnrollment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEnrollment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.BtnEnrollment, "BtnEnrollment")
        Me.BtnEnrollment.FillColor = System.Drawing.Color.Transparent
        Me.BtnEnrollment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BtnEnrollment.Image = Global.LEMS_ES.My.Resources.Resources.enrollment
        Me.BtnEnrollment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnEnrollment.ImageSize = New System.Drawing.Size(30, 30)
        Me.BtnEnrollment.Name = "BtnEnrollment"
        '
        'btnTransaction
        '
        Me.btnTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnTransaction, "btnTransaction")
        Me.btnTransaction.FillColor = System.Drawing.Color.White
        Me.btnTransaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnTransaction.Image = Global.LEMS_ES.My.Resources.Resources.credit_card
        Me.btnTransaction.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTransaction.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnTransaction.Name = "btnTransaction"
        '
        'btnDashboard
        '
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        resources.ApplyResources(Me.btnDashboard, "btnDashboard")
        Me.btnDashboard.FillColor = System.Drawing.Color.White
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnDashboard.Image = Global.LEMS_ES.My.Resources.Resources.dashboard
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.Name = "btnDashboard"
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.PanelLogo.Controls.Add(Me.Label3)
        Me.PanelLogo.Controls.Add(Me.Label4)
        Me.PanelLogo.Controls.Add(Me.Label5)
        resources.ApplyResources(Me.PanelLogo, "PanelLogo")
        Me.PanelLogo.Name = "PanelLogo"
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.DimGray
        Me.Guna2CirclePictureBox2.Image = Global.LEMS_ES.My.Resources.Resources._301880572_513192177473445_977701946028615649_n
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        resources.ApplyResources(Me.Guna2CirclePictureBox2, "Guna2CirclePictureBox2")
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Timer1
        '
        '
        'Panel3
        '
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'FrmDashboard
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelSidebar)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TopPanel.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSidebar.ResumeLayout(False)
        Me.GradingPanel.ResumeLayout(False)
        Me.DataEntryPanel.ResumeLayout(False)
        Me.TransactionPanel.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStudents As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTeachers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPayment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMaintenance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnEnrollment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents GradingPanel As Panel
    Friend WithEvents btnJHSGrading As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnElemGrading As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGrading As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataEntryPanel As Panel
    Friend WithEvents btnDataEntry As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TransactionPanel As Panel
    Friend WithEvents btnScheduling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTransaction As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSystemUtilities As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CirclePictureBox1 As PictureBox
End Class
