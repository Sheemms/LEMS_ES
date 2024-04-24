<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentsView
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbStudType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtStudNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.gbReq = New System.Windows.Forms.GroupBox()
        Me.dgvRequirements = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmbStudSuffix = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.RbFemale = New System.Windows.Forms.RadioButton()
        Me.RbMale = New System.Windows.Forms.RadioButton()
        Me.txtCitizenship = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.dtpBday = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtStudAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudMI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudFname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudLname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtGuardianRelation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtGuardianContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtGuardianName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtMotherMaidenName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMotherOccupation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMother = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtFatherOccupation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFatherName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.colCheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requirement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbReq.SuspendLayout()
        CType(Me.dgvRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(840, 73)
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
        Me.cmbStudType.Location = New System.Drawing.Point(518, 12)
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
        Me.txtStudNum.Location = New System.Drawing.Point(143, 12)
        Me.txtStudNum.Name = "txtStudNum"
        Me.txtStudNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudNum.PlaceholderText = ""
        Me.txtStudNum.SelectedText = ""
        Me.txtStudNum.Size = New System.Drawing.Size(224, 36)
        Me.txtStudNum.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student LRN"
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 73)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(840, 329)
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
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.gbReq)
        Me.TabPage1.Controls.Add(Me.cmbStudSuffix)
        Me.TabPage1.Controls.Add(Me.RbFemale)
        Me.TabPage1.Controls.Add(Me.RbMale)
        Me.TabPage1.Controls.Add(Me.txtCitizenship)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.dtpBday)
        Me.TabPage1.Controls.Add(Me.txtStudAge)
        Me.TabPage1.Controls.Add(Me.txtStudMI)
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
        Me.TabPage1.Size = New System.Drawing.Size(832, 281)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(281, 158)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = ""
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(210, 102)
        Me.txtAddress.TabIndex = 78
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(278, 141)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 14)
        Me.Label26.TabIndex = 77
        Me.Label26.Text = "Address"
        '
        'gbReq
        '
        Me.gbReq.Controls.Add(Me.dgvRequirements)
        Me.gbReq.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbReq.Location = New System.Drawing.Point(502, 13)
        Me.gbReq.Name = "gbReq"
        Me.gbReq.Size = New System.Drawing.Size(322, 247)
        Me.gbReq.TabIndex = 76
        Me.gbReq.TabStop = False
        Me.gbReq.Text = "Requirements"
        '
        'dgvRequirements
        '
        Me.dgvRequirements.AllowUserToAddRows = False
        Me.dgvRequirements.AllowUserToDeleteRows = False
        Me.dgvRequirements.AllowUserToResizeColumns = False
        Me.dgvRequirements.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvRequirements.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequirements.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRequirements.ColumnHeadersHeight = 30
        Me.dgvRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRequirements.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheckBox, Me.ID, Me.Requirement, Me.Column1})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRequirements.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRequirements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRequirements.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequirements.Location = New System.Drawing.Point(3, 21)
        Me.dgvRequirements.Name = "dgvRequirements"
        Me.dgvRequirements.RowHeadersVisible = False
        Me.dgvRequirements.Size = New System.Drawing.Size(316, 223)
        Me.dgvRequirements.TabIndex = 77
        Me.dgvRequirements.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRequirements.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRequirements.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRequirements.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRequirements.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRequirements.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvRequirements.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequirements.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequirements.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRequirements.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRequirements.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRequirements.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRequirements.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvRequirements.ThemeStyle.ReadOnly = False
        Me.dgvRequirements.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRequirements.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvRequirements.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRequirements.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvRequirements.ThemeStyle.RowsStyle.Height = 22
        Me.dgvRequirements.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequirements.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cmbStudSuffix
        '
        Me.cmbStudSuffix.BackColor = System.Drawing.Color.Transparent
        Me.cmbStudSuffix.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStudSuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudSuffix.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStudSuffix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbStudSuffix.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.cmbStudSuffix.ForeColor = System.Drawing.Color.Black
        Me.cmbStudSuffix.ItemHeight = 30
        Me.cmbStudSuffix.Items.AddRange(New Object() {"None", "Jr", "Sr", "I", "II", "III", "IV"})
        Me.cmbStudSuffix.Location = New System.Drawing.Point(155, 158)
        Me.cmbStudSuffix.Name = "cmbStudSuffix"
        Me.cmbStudSuffix.Size = New System.Drawing.Size(84, 36)
        Me.cmbStudSuffix.TabIndex = 75
        '
        'RbFemale
        '
        Me.RbFemale.AutoSize = True
        Me.RbFemale.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.RbFemale.ForeColor = System.Drawing.Color.Black
        Me.RbFemale.Location = New System.Drawing.Point(130, 229)
        Me.RbFemale.Name = "RbFemale"
        Me.RbFemale.Size = New System.Drawing.Size(67, 19)
        Me.RbFemale.TabIndex = 74
        Me.RbFemale.TabStop = True
        Me.RbFemale.Text = "Female"
        Me.RbFemale.UseVisualStyleBackColor = True
        '
        'RbMale
        '
        Me.RbMale.AutoSize = True
        Me.RbMale.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.RbMale.ForeColor = System.Drawing.Color.Black
        Me.RbMale.Location = New System.Drawing.Point(63, 229)
        Me.RbMale.Name = "RbMale"
        Me.RbMale.Size = New System.Drawing.Size(53, 19)
        Me.RbMale.TabIndex = 73
        Me.RbMale.TabStop = True
        Me.RbMale.Text = "Male"
        Me.RbMale.UseVisualStyleBackColor = True
        '
        'txtCitizenship
        '
        Me.txtCitizenship.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCitizenship.DefaultText = ""
        Me.txtCitizenship.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCitizenship.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCitizenship.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCitizenship.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCitizenship.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCitizenship.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCitizenship.ForeColor = System.Drawing.Color.Black
        Me.txtCitizenship.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCitizenship.Location = New System.Drawing.Point(281, 94)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCitizenship.PlaceholderText = ""
        Me.txtCitizenship.SelectedText = ""
        Me.txtCitizenship.Size = New System.Drawing.Size(210, 36)
        Me.txtCitizenship.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(282, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 14)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Citizenship"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(156, 141)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 14)
        Me.Label31.TabIndex = 25
        Me.Label31.Text = "Suffix"
        '
        'dtpBday
        '
        Me.dtpBday.AutoRoundedCorners = True
        Me.dtpBday.BorderRadius = 17
        Me.dtpBday.Checked = True
        Me.dtpBday.CustomFormat = "MMM / dd / yyyy"
        Me.dtpBday.FillColor = System.Drawing.Color.White
        Me.dtpBday.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpBday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBday.Location = New System.Drawing.Point(281, 30)
        Me.dtpBday.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpBday.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpBday.Name = "dtpBday"
        Me.dtpBday.Size = New System.Drawing.Size(135, 36)
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
        Me.txtStudAge.Location = New System.Drawing.Point(422, 30)
        Me.txtStudAge.Name = "txtStudAge"
        Me.txtStudAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudAge.PlaceholderText = ""
        Me.txtStudAge.ReadOnly = True
        Me.txtStudAge.SelectedText = ""
        Me.txtStudAge.Size = New System.Drawing.Size(69, 36)
        Me.txtStudAge.TabIndex = 14
        '
        'txtStudMI
        '
        Me.txtStudMI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudMI.DefaultText = ""
        Me.txtStudMI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudMI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudMI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudMI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudMI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudMI.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudMI.ForeColor = System.Drawing.Color.Black
        Me.txtStudMI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudMI.Location = New System.Drawing.Point(11, 158)
        Me.txtStudMI.Name = "txtStudMI"
        Me.txtStudMI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudMI.PlaceholderText = ""
        Me.txtStudMI.SelectedText = ""
        Me.txtStudMI.Size = New System.Drawing.Size(138, 36)
        Me.txtStudMI.TabIndex = 13
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
        Me.txtStudFname.Location = New System.Drawing.Point(11, 94)
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
        Me.Label9.Location = New System.Drawing.Point(12, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 14)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(286, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(423, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 14)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Middle Initial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
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
        Me.TabPage2.Controls.Add(Me.txtGuardianRelation)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.txtGuardianContact)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.txtGuardianName)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.txtMotherMaidenName)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.txtMotherOccupation)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.txtMother)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.txtFatherOccupation)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtFatherName)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(832, 281)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Parents/Guardian Details"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.txtGuardianRelation.Location = New System.Drawing.Point(281, 206)
        Me.txtGuardianRelation.Name = "txtGuardianRelation"
        Me.txtGuardianRelation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianRelation.PlaceholderText = ""
        Me.txtGuardianRelation.SelectedText = ""
        Me.txtGuardianRelation.Size = New System.Drawing.Size(210, 36)
        Me.txtGuardianRelation.TabIndex = 34
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(278, 189)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(114, 14)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Guardian Relation"
        '
        'txtGuardianContact
        '
        Me.txtGuardianContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardianContact.DefaultText = ""
        Me.txtGuardianContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuardianContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuardianContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianContact.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGuardianContact.ForeColor = System.Drawing.Color.Black
        Me.txtGuardianContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianContact.Location = New System.Drawing.Point(514, 206)
        Me.txtGuardianContact.Name = "txtGuardianContact"
        Me.txtGuardianContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianContact.PlaceholderText = ""
        Me.txtGuardianContact.SelectedText = ""
        Me.txtGuardianContact.Size = New System.Drawing.Size(210, 36)
        Me.txtGuardianContact.TabIndex = 30
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(511, 189)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(111, 14)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Guardian Contact"
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
        Me.txtGuardianName.Location = New System.Drawing.Point(11, 206)
        Me.txtGuardianName.Name = "txtGuardianName"
        Me.txtGuardianName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianName.PlaceholderText = ""
        Me.txtGuardianName.SelectedText = ""
        Me.txtGuardianName.Size = New System.Drawing.Size(247, 36)
        Me.txtGuardianName.TabIndex = 28
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 189)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 14)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "Guardian Name"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 160)
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
        Me.txtMotherMaidenName.Location = New System.Drawing.Point(281, 101)
        Me.txtMotherMaidenName.Name = "txtMotherMaidenName"
        Me.txtMotherMaidenName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotherMaidenName.PlaceholderText = ""
        Me.txtMotherMaidenName.SelectedText = ""
        Me.txtMotherMaidenName.Size = New System.Drawing.Size(247, 36)
        Me.txtMotherMaidenName.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(278, 84)
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
        Me.txtMotherOccupation.Location = New System.Drawing.Point(550, 34)
        Me.txtMotherOccupation.Name = "txtMotherOccupation"
        Me.txtMotherOccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotherOccupation.PlaceholderText = ""
        Me.txtMotherOccupation.SelectedText = ""
        Me.txtMotherOccupation.Size = New System.Drawing.Size(247, 36)
        Me.txtMotherOccupation.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(547, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 14)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Mother Occupation"
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
        Me.txtMother.Location = New System.Drawing.Point(281, 34)
        Me.txtMother.Name = "txtMother"
        Me.txtMother.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMother.PlaceholderText = ""
        Me.txtMother.SelectedText = ""
        Me.txtMother.Size = New System.Drawing.Size(247, 36)
        Me.txtMother.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(278, 17)
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
        Me.txtFatherOccupation.Location = New System.Drawing.Point(11, 101)
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
        Me.Label16.Location = New System.Drawing.Point(8, 84)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 14)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Father Occupation"
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
        Me.txtFatherName.Size = New System.Drawing.Size(247, 36)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 402)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 47)
        Me.Panel2.TabIndex = 3
        '
        'btnUpdate
        '
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(684, 6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(144, 36)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Update"
        '
        'btnSave
        '
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(547, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 36)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save"
        '
        'colCheckBox
        '
        Me.colCheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCheckBox.FalseValue = "False"
        Me.colCheckBox.HeaderText = ""
        Me.colCheckBox.Name = "colCheckBox"
        Me.colCheckBox.TrueValue = "True"
        Me.colCheckBox.Width = 5
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'Requirement
        '
        Me.Requirement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Requirement.DataPropertyName = "Requirement"
        Me.Requirement.HeaderText = "Description"
        Me.Requirement.Name = "Requirement"
        Me.Requirement.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "issubmitted"
        Me.Column1.HeaderText = "Value"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'frmStudentsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 453)
        Me.Controls.Add(Me.Panel2)
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
        Me.gbReq.ResumeLayout(False)
        CType(Me.dgvRequirements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbStudType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtStudNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dtpBday As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtStudMI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudFname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudLname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtGuardianRelation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtGuardianContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtGuardianName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtMotherMaidenName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtMotherOccupation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtMother As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtFatherOccupation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFatherName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtStudAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCitizenship As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RbFemale As RadioButton
    Friend WithEvents RbMale As RadioButton
    Friend WithEvents cmbStudSuffix As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents gbReq As GroupBox
    Friend WithEvents dgvRequirements As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents colCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Requirement As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
