<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaintenance
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditTrailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SubjectMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectionMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequirementsMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchoolYearMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscellaneousMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TuitionFeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherFeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMaintenanceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeLevelMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminControlsToolStripMenuItem, Me.AuditTrailToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(953, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminControlsToolStripMenuItem
        '
        Me.AdminControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubjectMaintenanceToolStripMenuItem, Me.SectionMaintenanceToolStripMenuItem, Me.GradeLevelMaintenanceToolStripMenuItem, Me.RequirementsMaintenanceToolStripMenuItem, Me.SchoolYearMaintenanceToolStripMenuItem, Me.MiscellaneousMaintenanceToolStripMenuItem, Me.TuitionFeeToolStripMenuItem, Me.OtherFeeToolStripMenuItem, Me.UserMaintenanceToolStripMenuItem1})
        Me.AdminControlsToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminControlsToolStripMenuItem.Name = "AdminControlsToolStripMenuItem"
        Me.AdminControlsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AdminControlsToolStripMenuItem.Text = "Admin Controls"
        '
        'AuditTrailToolStripMenuItem
        '
        Me.AuditTrailToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuditTrailToolStripMenuItem.Name = "AuditTrailToolStripMenuItem"
        Me.AuditTrailToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.AuditTrailToolStripMenuItem.Text = "Audit Trail"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 565)
        Me.Panel1.TabIndex = 1
        '
        'SubjectMaintenanceToolStripMenuItem
        '
        Me.SubjectMaintenanceToolStripMenuItem.Image = Global.LEMS_ES.My.Resources.Resources.subject
        Me.SubjectMaintenanceToolStripMenuItem.Name = "SubjectMaintenanceToolStripMenuItem"
        Me.SubjectMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.SubjectMaintenanceToolStripMenuItem.Text = "Subject Maintenance"
        '
        'SectionMaintenanceToolStripMenuItem
        '
        Me.SectionMaintenanceToolStripMenuItem.Image = Global.LEMS_ES.My.Resources.Resources.sections
        Me.SectionMaintenanceToolStripMenuItem.Name = "SectionMaintenanceToolStripMenuItem"
        Me.SectionMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.SectionMaintenanceToolStripMenuItem.Text = "Section Maintenance"
        '
        'RequirementsMaintenanceToolStripMenuItem
        '
        Me.RequirementsMaintenanceToolStripMenuItem.Image = Global.LEMS_ES.My.Resources.Resources.requirement
        Me.RequirementsMaintenanceToolStripMenuItem.Name = "RequirementsMaintenanceToolStripMenuItem"
        Me.RequirementsMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.RequirementsMaintenanceToolStripMenuItem.Text = "Requirements Maintenance"
        '
        'SchoolYearMaintenanceToolStripMenuItem
        '
        Me.SchoolYearMaintenanceToolStripMenuItem.Image = Global.LEMS_ES.My.Resources.Resources.calendar
        Me.SchoolYearMaintenanceToolStripMenuItem.Name = "SchoolYearMaintenanceToolStripMenuItem"
        Me.SchoolYearMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.SchoolYearMaintenanceToolStripMenuItem.Text = "School Year Maintenance"
        '
        'MiscellaneousMaintenanceToolStripMenuItem
        '
        Me.MiscellaneousMaintenanceToolStripMenuItem.Image = Global.LEMS_ES.My.Resources.Resources.invoice
        Me.MiscellaneousMaintenanceToolStripMenuItem.Name = "MiscellaneousMaintenanceToolStripMenuItem"
        Me.MiscellaneousMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.MiscellaneousMaintenanceToolStripMenuItem.Text = "Miscellaneous Maintenance"
        '
        'TuitionFeeToolStripMenuItem
        '
        Me.TuitionFeeToolStripMenuItem.Image = Global.LEMS_ES.My.Resources.Resources.invoice
        Me.TuitionFeeToolStripMenuItem.Name = "TuitionFeeToolStripMenuItem"
        Me.TuitionFeeToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.TuitionFeeToolStripMenuItem.Text = "Tuition Fee"
        '
        'OtherFeeToolStripMenuItem
        '
        Me.OtherFeeToolStripMenuItem.Image = Global.LEMS_ES.My.Resources.Resources.invoice
        Me.OtherFeeToolStripMenuItem.Name = "OtherFeeToolStripMenuItem"
        Me.OtherFeeToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.OtherFeeToolStripMenuItem.Text = "Other Fee"
        '
        'UserMaintenanceToolStripMenuItem1
        '
        Me.UserMaintenanceToolStripMenuItem1.Image = Global.LEMS_ES.My.Resources.Resources.skill
        Me.UserMaintenanceToolStripMenuItem1.Name = "UserMaintenanceToolStripMenuItem1"
        Me.UserMaintenanceToolStripMenuItem1.Size = New System.Drawing.Size(260, 22)
        Me.UserMaintenanceToolStripMenuItem1.Text = "User Maintenance"
        '
        'GradeLevelMaintenanceToolStripMenuItem
        '
        Me.GradeLevelMaintenanceToolStripMenuItem.Image = Global.LEMS_ES.My.Resources.Resources.subject
        Me.GradeLevelMaintenanceToolStripMenuItem.Name = "GradeLevelMaintenanceToolStripMenuItem"
        Me.GradeLevelMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.GradeLevelMaintenanceToolStripMenuItem.Text = "Grade Level Maintenance"
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 591)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdminControlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SectionMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequirementsMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SchoolYearMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiscellaneousMaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TuitionFeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuditTrailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OtherFeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserMaintenanceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GradeLevelMaintenanceToolStripMenuItem As ToolStripMenuItem
End Class
