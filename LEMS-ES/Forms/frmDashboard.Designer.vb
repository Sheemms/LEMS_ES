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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEnrollment = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMaintenance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReports = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTeachers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStudents = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.DimGray
        Me.Guna2CirclePictureBox1.Image = Global.LEMS_ES.My.Resources.Resources._301880572_513192177473445_977701946028615649_n
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        resources.ApplyResources(Me.Guna2CirclePictureBox1, "Guna2CirclePictureBox1")
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
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
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Timer1
        '
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
        Me.Panel2.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnEnrollment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
