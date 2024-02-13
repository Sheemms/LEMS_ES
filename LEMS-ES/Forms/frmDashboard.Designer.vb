<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEnrollment = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMaintenance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTeachers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStudents = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnEnrollment)
        Me.Panel2.Controls.Add(Me.btnMaintenance)
        Me.Panel2.Controls.Add(Me.btnReports)
        Me.Panel2.Controls.Add(Me.btnBilling)
        Me.Panel2.Controls.Add(Me.btnTeachers)
        Me.Panel2.Controls.Add(Me.btnStudents)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'btnLogout
        '
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnLogout, "btnLogout")
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnLogout.Image = Global.LEMS_ES.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnLogout.Name = "btnLogout"
        '
        'btnEnrollment
        '
        Me.btnEnrollment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEnrollment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEnrollment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEnrollment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEnrollment.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnEnrollment, "btnEnrollment")
        Me.btnEnrollment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnEnrollment.Image = Global.LEMS_ES.My.Resources.Resources.enrollment
        Me.btnEnrollment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEnrollment.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEnrollment.Name = "btnEnrollment"
        '
        'btnMaintenance
        '
        Me.btnMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMaintenance.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnMaintenance, "btnMaintenance")
        Me.btnMaintenance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnMaintenance.Image = Global.LEMS_ES.My.Resources.Resources.maintenance
        Me.btnMaintenance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMaintenance.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnMaintenance.Name = "btnMaintenance"
        '
        'btnReports
        '
        Me.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReports.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnReports, "btnReports")
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnReports.Image = Global.LEMS_ES.My.Resources.Resources.file_report
        Me.btnReports.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReports.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnReports.Name = "btnReports"
        '
        'btnBilling
        '
        Me.btnBilling.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBilling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBilling.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBilling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBilling.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnBilling, "btnBilling")
        Me.btnBilling.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnBilling.Image = Global.LEMS_ES.My.Resources.Resources.sections
        Me.btnBilling.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBilling.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnBilling.Name = "btnBilling"
        '
        'btnTeachers
        '
        Me.btnTeachers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTeachers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTeachers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTeachers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTeachers.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnTeachers, "btnTeachers")
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
        Me.btnStudents.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnStudents, "btnStudents")
        Me.btnStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnStudents.Image = Global.LEMS_ES.My.Resources.Resources.student_profile
        Me.btnStudents.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnStudents.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnStudents.Name = "btnStudents"
        '
        'btnDashboard
        '
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboard.FillColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnDashboard, "btnDashboard")
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnDashboard.Image = Global.LEMS_ES.My.Resources.Resources.dashboard
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.Name = "btnDashboard"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LEMS_ES.My.Resources.Resources._301880572_513192177473445_977701946028615649_n
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'frmDashboard
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStudents As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTeachers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReports As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMaintenance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEnrollment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
End Class
