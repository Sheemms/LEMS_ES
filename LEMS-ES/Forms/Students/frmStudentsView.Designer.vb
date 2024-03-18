<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentsView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbStudType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtStudNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvSubmittedRequirements = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2TextBox18 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStudSuffix = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmbStudGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpBday = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtStudAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudMname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudFname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudLname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtGuardianAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtGuardianRelation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtGuardianOccupation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtGuardianPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtGuardianName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtMotherMaidenName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMotherOccupation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMotherPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtMother = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtFatherOccupation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFatherPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFatherName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtSchoolAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtYrAttended = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtGrAttended = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtSchoolName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcbSubmittedReq = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvSubmittedRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbStudType)
        Me.Panel1.Controls.Add(Me.txtStudNum)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(813, 53)
        Me.Panel1.TabIndex = 1
        '
        'cmbStudType
        '
        Me.cmbStudType.BackColor = System.Drawing.Color.Transparent
        Me.cmbStudType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStudType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStudType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStudType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStudType.ForeColor = System.Drawing.Color.Black
        Me.cmbStudType.ItemHeight = 30
        Me.cmbStudType.Location = New System.Drawing.Point(480, 11)
        Me.cmbStudType.Name = "cmbStudType"
        Me.cmbStudType.Size = New System.Drawing.Size(201, 36)
        Me.cmbStudType.TabIndex = 3
        '
        'txtStudNum
        '
        Me.txtStudNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudNum.DefaultText = ""
        Me.txtStudNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudNum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudNum.ForeColor = System.Drawing.Color.Black
        Me.txtStudNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudNum.Location = New System.Drawing.Point(122, 11)
        Me.txtStudNum.Name = "txtStudNum"
        Me.txtStudNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudNum.PlaceholderText = ""
        Me.txtStudNum.SelectedText = ""
        Me.txtStudNum.Size = New System.Drawing.Size(240, 36)
        Me.txtStudNum.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Number"
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage3)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 53)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(813, 431)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 2
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvSubmittedRequirements)
        Me.TabPage1.Controls.Add(Me.Guna2TextBox18)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtStudSuffix)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.cmbStudGender)
        Me.TabPage1.Controls.Add(Me.dtpBday)
        Me.TabPage1.Controls.Add(Me.txtStudAge)
        Me.TabPage1.Controls.Add(Me.txtStudMname)
        Me.TabPage1.Controls.Add(Me.txtStudFname)
        Me.TabPage1.Controls.Add(Me.txtStudLname)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(805, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvSubmittedRequirements
        '
        Me.dgvSubmittedRequirements.AllowUserToAddRows = False
        Me.dgvSubmittedRequirements.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvSubmittedRequirements.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubmittedRequirements.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSubmittedRequirements.ColumnHeadersHeight = 30
        Me.dgvSubmittedRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSubmittedRequirements.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Column1, Me.colcbSubmittedReq})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSubmittedRequirements.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSubmittedRequirements.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubmittedRequirements.Location = New System.Drawing.Point(15, 152)
        Me.dgvSubmittedRequirements.Name = "dgvSubmittedRequirements"
        Me.dgvSubmittedRequirements.ReadOnly = True
        Me.dgvSubmittedRequirements.RowHeadersVisible = False
        Me.dgvSubmittedRequirements.Size = New System.Drawing.Size(419, 207)
        Me.dgvSubmittedRequirements.TabIndex = 30
        Me.dgvSubmittedRequirements.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubmittedRequirements.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvSubmittedRequirements.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvSubmittedRequirements.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvSubmittedRequirements.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvSubmittedRequirements.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubmittedRequirements.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubmittedRequirements.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubmittedRequirements.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSubmittedRequirements.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSubmittedRequirements.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSubmittedRequirements.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSubmittedRequirements.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvSubmittedRequirements.ThemeStyle.ReadOnly = True
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.Height = 22
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2TextBox18
        '
        Me.Guna2TextBox18.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox18.DefaultText = ""
        Me.Guna2TextBox18.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox18.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox18.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox18.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox18.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox18.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox18.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox18.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox18.Location = New System.Drawing.Point(228, 95)
        Me.Guna2TextBox18.Name = "Guna2TextBox18"
        Me.Guna2TextBox18.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox18.PlaceholderText = ""
        Me.Guna2TextBox18.SelectedText = ""
        Me.Guna2TextBox18.Size = New System.Drawing.Size(206, 36)
        Me.Guna2TextBox18.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(225, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 14)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Place of Birth"
        '
        'txtStudSuffix
        '
        Me.txtStudSuffix.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudSuffix.DefaultText = ""
        Me.txtStudSuffix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudSuffix.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudSuffix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudSuffix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudSuffix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudSuffix.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudSuffix.ForeColor = System.Drawing.Color.Black
        Me.txtStudSuffix.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudSuffix.Location = New System.Drawing.Point(720, 30)
        Me.txtStudSuffix.Name = "txtStudSuffix"
        Me.txtStudSuffix.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudSuffix.PlaceholderText = ""
        Me.txtStudSuffix.SelectedText = ""
        Me.txtStudSuffix.Size = New System.Drawing.Size(69, 36)
        Me.txtStudSuffix.TabIndex = 26
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(717, 13)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 14)
        Me.Label31.TabIndex = 25
        Me.Label31.Text = "Suffix"
        '
        'cmbStudGender
        '
        Me.cmbStudGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbStudGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStudGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudGender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStudGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStudGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStudGender.ForeColor = System.Drawing.Color.Black
        Me.cmbStudGender.ItemHeight = 30
        Me.cmbStudGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbStudGender.Location = New System.Drawing.Point(440, 95)
        Me.cmbStudGender.Name = "cmbStudGender"
        Me.cmbStudGender.Size = New System.Drawing.Size(200, 36)
        Me.cmbStudGender.TabIndex = 17
        '
        'dtpBday
        '
        Me.dtpBday.Checked = True
        Me.dtpBday.FillColor = System.Drawing.Color.White
        Me.dtpBday.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpBday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBday.Location = New System.Drawing.Point(99, 95)
        Me.dtpBday.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpBday.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpBday.Name = "dtpBday"
        Me.dtpBday.Size = New System.Drawing.Size(123, 36)
        Me.dtpBday.TabIndex = 15
        Me.dtpBday.Value = New Date(2024, 1, 29, 19, 23, 5, 488)
        '
        'txtStudAge
        '
        Me.txtStudAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudAge.DefaultText = ""
        Me.txtStudAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudAge.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudAge.ForeColor = System.Drawing.Color.Black
        Me.txtStudAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudAge.Location = New System.Drawing.Point(11, 95)
        Me.txtStudAge.Name = "txtStudAge"
        Me.txtStudAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudAge.PlaceholderText = ""
        Me.txtStudAge.SelectedText = ""
        Me.txtStudAge.Size = New System.Drawing.Size(81, 36)
        Me.txtStudAge.TabIndex = 14
        '
        'txtStudMname
        '
        Me.txtStudMname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudMname.DefaultText = ""
        Me.txtStudMname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudMname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudMname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudMname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudMname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudMname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudMname.ForeColor = System.Drawing.Color.Black
        Me.txtStudMname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudMname.Location = New System.Drawing.Point(483, 30)
        Me.txtStudMname.Name = "txtStudMname"
        Me.txtStudMname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudMname.PlaceholderText = ""
        Me.txtStudMname.SelectedText = ""
        Me.txtStudMname.Size = New System.Drawing.Size(228, 36)
        Me.txtStudMname.TabIndex = 13
        '
        'txtStudFname
        '
        Me.txtStudFname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudFname.DefaultText = ""
        Me.txtStudFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudFname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudFname.ForeColor = System.Drawing.Color.Black
        Me.txtStudFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudFname.Location = New System.Drawing.Point(246, 30)
        Me.txtStudFname.Name = "txtStudFname"
        Me.txtStudFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudFname.PlaceholderText = ""
        Me.txtStudFname.SelectedText = ""
        Me.txtStudFname.Size = New System.Drawing.Size(228, 36)
        Me.txtStudFname.TabIndex = 12
        '
        'txtStudLname
        '
        Me.txtStudLname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudLname.DefaultText = ""
        Me.txtStudLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudLname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudLname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudLname.ForeColor = System.Drawing.Color.Black
        Me.txtStudLname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudLname.Location = New System.Drawing.Point(11, 30)
        Me.txtStudLname.Name = "txtStudLname"
        Me.txtStudLname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudLname.PlaceholderText = ""
        Me.txtStudLname.SelectedText = ""
        Me.txtStudLname.Size = New System.Drawing.Size(228, 36)
        Me.txtStudLname.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(440, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 14)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 14)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(480, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Last Name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtGuardianAddress)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.txtGuardianRelation)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.txtGuardianOccupation)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.txtGuardianPhone)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.txtGuardianName)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.txtMotherMaidenName)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.txtMotherOccupation)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.txtMotherPhone)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.txtMother)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.txtFatherOccupation)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtFatherPhone)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtFatherName)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(805, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Parents/Guardian Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtGuardianAddress
        '
        Me.txtGuardianAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardianAddress.DefaultText = ""
        Me.txtGuardianAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuardianAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuardianAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGuardianAddress.ForeColor = System.Drawing.Color.Black
        Me.txtGuardianAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianAddress.Location = New System.Drawing.Point(11, 264)
        Me.txtGuardianAddress.Multiline = True
        Me.txtGuardianAddress.Name = "txtGuardianAddress"
        Me.txtGuardianAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianAddress.PlaceholderText = ""
        Me.txtGuardianAddress.SelectedText = ""
        Me.txtGuardianAddress.Size = New System.Drawing.Size(267, 67)
        Me.txtGuardianAddress.TabIndex = 36
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(8, 247)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(111, 14)
        Me.Label26.TabIndex = 35
        Me.Label26.Text = "Guardian Address"
        '
        'txtGuardianRelation
        '
        Me.txtGuardianRelation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardianRelation.DefaultText = ""
        Me.txtGuardianRelation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuardianRelation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuardianRelation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianRelation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianRelation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianRelation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGuardianRelation.ForeColor = System.Drawing.Color.Black
        Me.txtGuardianRelation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianRelation.Location = New System.Drawing.Point(623, 201)
        Me.txtGuardianRelation.Name = "txtGuardianRelation"
        Me.txtGuardianRelation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianRelation.PlaceholderText = ""
        Me.txtGuardianRelation.SelectedText = ""
        Me.txtGuardianRelation.Size = New System.Drawing.Size(174, 36)
        Me.txtGuardianRelation.TabIndex = 34
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(620, 184)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(114, 14)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Guardian Relation"
        '
        'txtGuardianOccupation
        '
        Me.txtGuardianOccupation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardianOccupation.DefaultText = ""
        Me.txtGuardianOccupation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuardianOccupation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuardianOccupation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianOccupation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianOccupation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianOccupation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGuardianOccupation.ForeColor = System.Drawing.Color.Black
        Me.txtGuardianOccupation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianOccupation.Location = New System.Drawing.Point(420, 201)
        Me.txtGuardianOccupation.Name = "txtGuardianOccupation"
        Me.txtGuardianOccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianOccupation.PlaceholderText = ""
        Me.txtGuardianOccupation.SelectedText = ""
        Me.txtGuardianOccupation.Size = New System.Drawing.Size(197, 36)
        Me.txtGuardianOccupation.TabIndex = 32
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(417, 184)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(132, 14)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Guardian Occupation"
        '
        'txtGuardianPhone
        '
        Me.txtGuardianPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardianPhone.DefaultText = ""
        Me.txtGuardianPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuardianPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuardianPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGuardianPhone.ForeColor = System.Drawing.Color.Black
        Me.txtGuardianPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianPhone.Location = New System.Drawing.Point(227, 201)
        Me.txtGuardianPhone.Name = "txtGuardianPhone"
        Me.txtGuardianPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianPhone.PlaceholderText = ""
        Me.txtGuardianPhone.SelectedText = ""
        Me.txtGuardianPhone.Size = New System.Drawing.Size(187, 36)
        Me.txtGuardianPhone.TabIndex = 30
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(224, 184)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(101, 14)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Guardian Phone"
        '
        'txtGuardianName
        '
        Me.txtGuardianName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardianName.DefaultText = ""
        Me.txtGuardianName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuardianName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuardianName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGuardianName.ForeColor = System.Drawing.Color.Black
        Me.txtGuardianName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianName.Location = New System.Drawing.Point(11, 201)
        Me.txtGuardianName.Name = "txtGuardianName"
        Me.txtGuardianName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianName.PlaceholderText = ""
        Me.txtGuardianName.SelectedText = ""
        Me.txtGuardianName.Size = New System.Drawing.Size(210, 36)
        Me.txtGuardianName.TabIndex = 28
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 184)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 14)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "Guardian Name"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 153)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(132, 14)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "If Guardian is Other *"
        '
        'txtMotherMaidenName
        '
        Me.txtMotherMaidenName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMotherMaidenName.DefaultText = ""
        Me.txtMotherMaidenName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMotherMaidenName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMotherMaidenName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherMaidenName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherMaidenName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherMaidenName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMotherMaidenName.ForeColor = System.Drawing.Color.Black
        Me.txtMotherMaidenName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherMaidenName.Location = New System.Drawing.Point(623, 103)
        Me.txtMotherMaidenName.Name = "txtMotherMaidenName"
        Me.txtMotherMaidenName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotherMaidenName.PlaceholderText = ""
        Me.txtMotherMaidenName.SelectedText = ""
        Me.txtMotherMaidenName.Size = New System.Drawing.Size(174, 36)
        Me.txtMotherMaidenName.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(620, 86)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(137, 14)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Mother's Maiden Name"
        '
        'txtMotherOccupation
        '
        Me.txtMotherOccupation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMotherOccupation.DefaultText = ""
        Me.txtMotherOccupation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMotherOccupation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMotherOccupation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherOccupation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherOccupation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherOccupation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMotherOccupation.ForeColor = System.Drawing.Color.Black
        Me.txtMotherOccupation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherOccupation.Location = New System.Drawing.Point(420, 103)
        Me.txtMotherOccupation.Name = "txtMotherOccupation"
        Me.txtMotherOccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotherOccupation.PlaceholderText = ""
        Me.txtMotherOccupation.SelectedText = ""
        Me.txtMotherOccupation.Size = New System.Drawing.Size(197, 36)
        Me.txtMotherOccupation.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(417, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 14)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Mother Occupation"
        '
        'txtMotherPhone
        '
        Me.txtMotherPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMotherPhone.DefaultText = ""
        Me.txtMotherPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMotherPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMotherPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMotherPhone.ForeColor = System.Drawing.Color.Black
        Me.txtMotherPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherPhone.Location = New System.Drawing.Point(227, 103)
        Me.txtMotherPhone.Name = "txtMotherPhone"
        Me.txtMotherPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotherPhone.PlaceholderText = ""
        Me.txtMotherPhone.SelectedText = ""
        Me.txtMotherPhone.Size = New System.Drawing.Size(187, 36)
        Me.txtMotherPhone.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(224, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 14)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Mother Phone"
        '
        'txtMother
        '
        Me.txtMother.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMother.DefaultText = ""
        Me.txtMother.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMother.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMother.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMother.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMother.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMother.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMother.ForeColor = System.Drawing.Color.Black
        Me.txtMother.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMother.Location = New System.Drawing.Point(11, 103)
        Me.txtMother.Name = "txtMother"
        Me.txtMother.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMother.PlaceholderText = ""
        Me.txtMother.SelectedText = ""
        Me.txtMother.Size = New System.Drawing.Size(210, 36)
        Me.txtMother.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 14)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Mother Name"
        '
        'txtFatherOccupation
        '
        Me.txtFatherOccupation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFatherOccupation.DefaultText = ""
        Me.txtFatherOccupation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFatherOccupation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFatherOccupation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherOccupation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherOccupation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherOccupation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFatherOccupation.ForeColor = System.Drawing.Color.Black
        Me.txtFatherOccupation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherOccupation.Location = New System.Drawing.Point(497, 34)
        Me.txtFatherOccupation.Name = "txtFatherOccupation"
        Me.txtFatherOccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFatherOccupation.PlaceholderText = ""
        Me.txtFatherOccupation.SelectedText = ""
        Me.txtFatherOccupation.Size = New System.Drawing.Size(247, 36)
        Me.txtFatherOccupation.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(494, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 14)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Father Occupation"
        '
        'txtFatherPhone
        '
        Me.txtFatherPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFatherPhone.DefaultText = ""
        Me.txtFatherPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFatherPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFatherPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFatherPhone.ForeColor = System.Drawing.Color.Black
        Me.txtFatherPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherPhone.Location = New System.Drawing.Point(270, 34)
        Me.txtFatherPhone.Name = "txtFatherPhone"
        Me.txtFatherPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFatherPhone.PlaceholderText = ""
        Me.txtFatherPhone.SelectedText = ""
        Me.txtFatherPhone.Size = New System.Drawing.Size(221, 36)
        Me.txtFatherPhone.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(267, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 14)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Father Phone"
        '
        'txtFatherName
        '
        Me.txtFatherName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFatherName.DefaultText = ""
        Me.txtFatherName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFatherName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFatherName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFatherName.ForeColor = System.Drawing.Color.Black
        Me.txtFatherName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherName.Location = New System.Drawing.Point(11, 34)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFatherName.PlaceholderText = ""
        Me.txtFatherName.SelectedText = ""
        Me.txtFatherName.Size = New System.Drawing.Size(253, 36)
        Me.txtFatherName.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 14)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Father Name"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtSchoolAddress)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.txtYrAttended)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.txtGrAttended)
        Me.TabPage3.Controls.Add(Me.Label29)
        Me.TabPage3.Controls.Add(Me.txtSchoolName)
        Me.TabPage3.Controls.Add(Me.Label30)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(805, 383)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Educational Background"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtSchoolAddress
        '
        Me.txtSchoolAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSchoolAddress.DefaultText = ""
        Me.txtSchoolAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSchoolAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSchoolAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchoolAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSchoolAddress.ForeColor = System.Drawing.Color.Black
        Me.txtSchoolAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchoolAddress.Location = New System.Drawing.Point(623, 35)
        Me.txtSchoolAddress.Name = "txtSchoolAddress"
        Me.txtSchoolAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSchoolAddress.PlaceholderText = ""
        Me.txtSchoolAddress.SelectedText = ""
        Me.txtSchoolAddress.Size = New System.Drawing.Size(174, 36)
        Me.txtSchoolAddress.TabIndex = 42
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(620, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(92, 14)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "School Address"
        '
        'txtYrAttended
        '
        Me.txtYrAttended.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYrAttended.DefaultText = ""
        Me.txtYrAttended.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtYrAttended.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtYrAttended.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYrAttended.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYrAttended.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYrAttended.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtYrAttended.ForeColor = System.Drawing.Color.Black
        Me.txtYrAttended.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtYrAttended.Location = New System.Drawing.Point(420, 35)
        Me.txtYrAttended.Name = "txtYrAttended"
        Me.txtYrAttended.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYrAttended.PlaceholderText = ""
        Me.txtYrAttended.SelectedText = ""
        Me.txtYrAttended.Size = New System.Drawing.Size(197, 36)
        Me.txtYrAttended.TabIndex = 40
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(417, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(90, 14)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Year Attended"
        '
        'txtGrAttended
        '
        Me.txtGrAttended.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGrAttended.DefaultText = ""
        Me.txtGrAttended.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGrAttended.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGrAttended.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGrAttended.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGrAttended.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGrAttended.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGrAttended.ForeColor = System.Drawing.Color.Black
        Me.txtGrAttended.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGrAttended.Location = New System.Drawing.Point(227, 35)
        Me.txtGrAttended.Name = "txtGrAttended"
        Me.txtGrAttended.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGrAttended.PlaceholderText = ""
        Me.txtGrAttended.SelectedText = ""
        Me.txtGrAttended.Size = New System.Drawing.Size(187, 36)
        Me.txtGrAttended.TabIndex = 38
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(224, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(98, 14)
        Me.Label29.TabIndex = 37
        Me.Label29.Text = "Grade Attended"
        '
        'txtSchoolName
        '
        Me.txtSchoolName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSchoolName.DefaultText = ""
        Me.txtSchoolName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSchoolName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSchoolName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchoolName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSchoolName.ForeColor = System.Drawing.Color.Black
        Me.txtSchoolName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchoolName.Location = New System.Drawing.Point(11, 35)
        Me.txtSchoolName.Name = "txtSchoolName"
        Me.txtSchoolName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSchoolName.PlaceholderText = ""
        Me.txtSchoolName.SelectedText = ""
        Me.txtSchoolName.Size = New System.Drawing.Size(210, 36)
        Me.txtSchoolName.TabIndex = 36
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(8, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(81, 14)
        Me.Label30.TabIndex = 35
        Me.Label30.Text = "School Name"
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "Requirement"
        Me.Column1.HeaderText = "Submitted Requirements"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'colcbSubmittedReq
        '
        Me.colcbSubmittedReq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colcbSubmittedReq.HeaderText = ""
        Me.colcbSubmittedReq.Name = "colcbSubmittedReq"
        Me.colcbSubmittedReq.ReadOnly = True
        Me.colcbSubmittedReq.Width = 5
        '
        'frmStudentsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 484)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmStudentsView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvSubmittedRequirements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbStudType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtStudNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cmbStudGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpBday As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtStudMname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudFname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudLname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtGuardianAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtGuardianRelation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtGuardianOccupation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtGuardianPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtGuardianName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtMotherMaidenName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtMotherOccupation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtMotherPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtMother As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtFatherOccupation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFatherPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtFatherName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSchoolAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtYrAttended As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtGrAttended As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtSchoolName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents dgvSubmittedRequirements As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2TextBox18 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtStudSuffix As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txtStudAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colcbSubmittedReq As DataGridViewCheckBoxColumn
End Class
