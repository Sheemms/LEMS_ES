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
        Me.gbReq = New System.Windows.Forms.GroupBox()
        Me.dgvRequirements = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmbStudSuffix = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbFemale = New System.Windows.Forms.RadioButton()
        Me.cbMale = New System.Windows.Forms.RadioButton()
        Me.txtCitizenship = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtSchoolAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtYrAttended = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtGrAttended = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtSchoolName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtGuardianAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.colCheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSubmittedRequirements = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colSubmittedCheckBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colSubmittedID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbReq.SuspendLayout()
        CType(Me.dgvRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSubmittedRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmbStudType.Location = New System.Drawing.Point(285, 31)
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
        Me.txtStudNum.Location = New System.Drawing.Point(19, 31)
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
        Me.Label2.Location = New System.Drawing.Point(286, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student LRN"
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage3)
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
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.txtGuardianAddress)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.gbReq)
        Me.TabPage1.Controls.Add(Me.cmbStudSuffix)
        Me.TabPage1.Controls.Add(Me.cbFemale)
        Me.TabPage1.Controls.Add(Me.cbMale)
        Me.TabPage1.Controls.Add(Me.txtCitizenship)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label31)
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
        Me.TabPage1.Size = New System.Drawing.Size(832, 281)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal Information"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.dgvRequirements.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheckBox, Me.colID, Me.Column2, Me.DataGridViewTextBoxColumn2})
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
        Me.dgvRequirements.MultiSelect = False
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
        Me.cmbStudSuffix.Location = New System.Drawing.Point(11, 220)
        Me.cmbStudSuffix.Name = "cmbStudSuffix"
        Me.cmbStudSuffix.Size = New System.Drawing.Size(84, 36)
        Me.cmbStudSuffix.TabIndex = 75
        '
        'cbFemale
        '
        Me.cbFemale.AutoSize = True
        Me.cbFemale.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.cbFemale.ForeColor = System.Drawing.Color.Black
        Me.cbFemale.Location = New System.Drawing.Point(172, 227)
        Me.cbFemale.Name = "cbFemale"
        Me.cbFemale.Size = New System.Drawing.Size(67, 19)
        Me.cbFemale.TabIndex = 74
        Me.cbFemale.TabStop = True
        Me.cbFemale.Text = "Female"
        Me.cbFemale.UseVisualStyleBackColor = True
        '
        'cbMale
        '
        Me.cbMale.AutoSize = True
        Me.cbMale.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.cbMale.ForeColor = System.Drawing.Color.Black
        Me.cbMale.Location = New System.Drawing.Point(105, 227)
        Me.cbMale.Name = "cbMale"
        Me.cbMale.Size = New System.Drawing.Size(53, 19)
        Me.cbMale.TabIndex = 73
        Me.cbMale.TabStop = True
        Me.cbMale.Text = "Male"
        Me.cbMale.UseVisualStyleBackColor = True
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
        Me.Label31.Location = New System.Drawing.Point(12, 203)
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
        Me.dtpBday.FillColor = System.Drawing.Color.White
        Me.dtpBday.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpBday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBday.Location = New System.Drawing.Point(368, 30)
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
        Me.txtStudAge.Location = New System.Drawing.Point(281, 30)
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
        Me.txtStudMname.Location = New System.Drawing.Point(11, 158)
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
        Me.Label9.Location = New System.Drawing.Point(102, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 14)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(365, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 13)
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
        Me.Label5.Size = New System.Drawing.Size(82, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Middle Name"
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
        Me.TabPage3.Size = New System.Drawing.Size(832, 281)
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
        Me.btnUpdate.Location = New System.Drawing.Point(411, 6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 36)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Update"
        '
        'btnSave
        '
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(314, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 36)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save"
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
        Me.txtGuardianAddress.Location = New System.Drawing.Point(281, 158)
        Me.txtGuardianAddress.Multiline = True
        Me.txtGuardianAddress.Name = "txtGuardianAddress"
        Me.txtGuardianAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianAddress.PlaceholderText = ""
        Me.txtGuardianAddress.SelectedText = ""
        Me.txtGuardianAddress.Size = New System.Drawing.Size(210, 102)
        Me.txtGuardianAddress.TabIndex = 78
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
        'colCheckBox
        '
        Me.colCheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCheckBox.HeaderText = ""
        Me.colCheckBox.Name = "colCheckBox"
        Me.colCheckBox.Width = 5
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.DataPropertyName = "Classification_ID"
        Me.Column2.HeaderText = "Classification"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 119
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Requirement"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSubmittedRequirements)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(502, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 124)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Submitted Requirements"
        Me.GroupBox1.Visible = False
        '
        'dgvSubmittedRequirements
        '
        Me.dgvSubmittedRequirements.AllowUserToAddRows = False
        Me.dgvSubmittedRequirements.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvSubmittedRequirements.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubmittedRequirements.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSubmittedRequirements.ColumnHeadersHeight = 30
        Me.dgvSubmittedRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSubmittedRequirements.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSubmittedCheckBox, Me.colSubmittedID, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSubmittedRequirements.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSubmittedRequirements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSubmittedRequirements.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubmittedRequirements.Location = New System.Drawing.Point(3, 21)
        Me.dgvSubmittedRequirements.MultiSelect = False
        Me.dgvSubmittedRequirements.Name = "dgvSubmittedRequirements"
        Me.dgvSubmittedRequirements.RowHeadersVisible = False
        Me.dgvSubmittedRequirements.Size = New System.Drawing.Size(316, 100)
        Me.dgvSubmittedRequirements.TabIndex = 77
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
        Me.dgvSubmittedRequirements.ThemeStyle.ReadOnly = False
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.Height = 22
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSubmittedRequirements.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'colSubmittedCheckBox
        '
        Me.colSubmittedCheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSubmittedCheckBox.HeaderText = ""
        Me.colSubmittedCheckBox.Name = "colSubmittedCheckBox"
        Me.colSubmittedCheckBox.Width = 5
        '
        'colSubmittedID
        '
        Me.colSubmittedID.DataPropertyName = "ID"
        Me.colSubmittedID.HeaderText = "ID"
        Me.colSubmittedID.Name = "colSubmittedID"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RequirementID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
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
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSubmittedRequirements, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtStudMname As Guna.UI2.WinForms.Guna2TextBox
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
    Friend WithEvents cbFemale As RadioButton
    Friend WithEvents cbMale As RadioButton
    Friend WithEvents cmbStudSuffix As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtSchoolAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtYrAttended As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtGrAttended As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtSchoolName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents gbReq As GroupBox
    Friend WithEvents dgvRequirements As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtGuardianAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents colCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSubmittedRequirements As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colSubmittedCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents colSubmittedID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
