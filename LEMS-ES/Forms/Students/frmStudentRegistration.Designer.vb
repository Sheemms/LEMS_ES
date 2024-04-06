<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentRegistration
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GBStudentRegistration = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbRequirements = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvRequirements = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCheckBoxReq = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbFemale = New System.Windows.Forms.RadioButton()
        Me.cbMale = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSuffix = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpBday = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLRN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMiddlename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GBStudentRegistration.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbRequirements.SuspendLayout()
        CType(Me.dgvRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBStudentRegistration
        '
        Me.GBStudentRegistration.Controls.Add(Me.GroupBox1)
        Me.GBStudentRegistration.CustomBorderColor = System.Drawing.Color.Gray
        Me.GBStudentRegistration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBStudentRegistration.Font = New System.Drawing.Font("Georgia", 24.0!)
        Me.GBStudentRegistration.ForeColor = System.Drawing.Color.White
        Me.GBStudentRegistration.Location = New System.Drawing.Point(0, 0)
        Me.GBStudentRegistration.Name = "GBStudentRegistration"
        Me.GBStudentRegistration.Size = New System.Drawing.Size(811, 561)
        Me.GBStudentRegistration.TabIndex = 1
        Me.GBStudentRegistration.Text = "Student Registration"
        Me.GBStudentRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gbRequirements)
        Me.GroupBox1.Controls.Add(Me.cbFemale)
        Me.GroupBox1.Controls.Add(Me.cbMale)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbSuffix)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.dtpBday)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtLRN)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtMiddlename)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 521)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'gbRequirements
        '
        Me.gbRequirements.Controls.Add(Me.dgvRequirements)
        Me.gbRequirements.CustomBorderColor = System.Drawing.Color.White
        Me.gbRequirements.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRequirements.ForeColor = System.Drawing.Color.Black
        Me.gbRequirements.Location = New System.Drawing.Point(346, 25)
        Me.gbRequirements.Name = "gbRequirements"
        Me.gbRequirements.Size = New System.Drawing.Size(453, 295)
        Me.gbRequirements.TabIndex = 73
        Me.gbRequirements.Text = "Requirement Details"
        '
        'dgvRequirements
        '
        Me.dgvRequirements.AllowUserToAddRows = False
        Me.dgvRequirements.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvRequirements.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRequirements.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvRequirements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvRequirements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequirements.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRequirements.ColumnHeadersHeight = 44
        Me.dgvRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRequirements.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.Column2, Me.Column3, Me.colCheckBoxReq})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRequirements.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRequirements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRequirements.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequirements.Location = New System.Drawing.Point(0, 40)
        Me.dgvRequirements.MultiSelect = False
        Me.dgvRequirements.Name = "dgvRequirements"
        Me.dgvRequirements.RowHeadersVisible = False
        Me.dgvRequirements.Size = New System.Drawing.Size(453, 255)
        Me.dgvRequirements.TabIndex = 3
        Me.dgvRequirements.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRequirements.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvRequirements.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvRequirements.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvRequirements.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvRequirements.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.dgvRequirements.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequirements.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvRequirements.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgvRequirements.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRequirements.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvRequirements.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRequirements.ThemeStyle.HeaderStyle.Height = 44
        Me.dgvRequirements.ThemeStyle.ReadOnly = False
        Me.dgvRequirements.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvRequirements.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvRequirements.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRequirements.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvRequirements.ThemeStyle.RowsStyle.Height = 22
        Me.dgvRequirements.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequirements.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.DataPropertyName = "Classification"
        Me.Column2.HeaderText = "Classification"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 115
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "Requirement"
        Me.Column3.HeaderText = "Requirements"
        Me.Column3.Name = "Column3"
        '
        'colCheckBoxReq
        '
        Me.colCheckBoxReq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCheckBoxReq.HeaderText = ""
        Me.colCheckBoxReq.Name = "colCheckBoxReq"
        Me.colCheckBoxReq.Width = 5
        '
        'cbFemale
        '
        Me.cbFemale.AutoSize = True
        Me.cbFemale.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.cbFemale.ForeColor = System.Drawing.Color.Black
        Me.cbFemale.Location = New System.Drawing.Point(98, 293)
        Me.cbFemale.Name = "cbFemale"
        Me.cbFemale.Size = New System.Drawing.Size(67, 19)
        Me.cbFemale.TabIndex = 72
        Me.cbFemale.TabStop = True
        Me.cbFemale.Text = "Female"
        Me.cbFemale.UseVisualStyleBackColor = True
        '
        'cbMale
        '
        Me.cbMale.AutoSize = True
        Me.cbMale.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.cbMale.ForeColor = System.Drawing.Color.Black
        Me.cbMale.Location = New System.Drawing.Point(12, 293)
        Me.cbMale.Name = "cbMale"
        Me.cbMale.Size = New System.Drawing.Size(53, 19)
        Me.cbMale.TabIndex = 71
        Me.cbMale.TabStop = True
        Me.cbMale.Text = "Male"
        Me.cbMale.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Georgia", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Address"
        '
        'cmbSuffix
        '
        Me.cmbSuffix.BackColor = System.Drawing.Color.Transparent
        Me.cmbSuffix.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSuffix.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSuffix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSuffix.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.cmbSuffix.ForeColor = System.Drawing.Color.Black
        Me.cmbSuffix.ItemHeight = 30
        Me.cmbSuffix.Items.AddRange(New Object() {"None", "Jr", "Sr", "I", "II", "III", "IV"})
        Me.cmbSuffix.Location = New System.Drawing.Point(241, 221)
        Me.cmbSuffix.Name = "cmbSuffix"
        Me.cmbSuffix.Size = New System.Drawing.Size(84, 36)
        Me.cmbSuffix.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Georgia", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(237, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Suffix"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Georgia", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 17)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Middle Initial (Optional)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Georgia", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Georgia", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 17)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Learning Reference Number (LRN)"
        '
        'btnSave
        '
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(133, 436)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 36)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        '
        'dtpBday
        '
        Me.dtpBday.Checked = True
        Me.dtpBday.FillColor = System.Drawing.Color.White
        Me.dtpBday.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBday.ForeColor = System.Drawing.Color.Black
        Me.dtpBday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBday.Location = New System.Drawing.Point(193, 284)
        Me.dtpBday.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpBday.MinDate = New Date(2005, 12, 31, 0, 0, 0, 0)
        Me.dtpBday.Name = "dtpBday"
        Me.dtpBday.Size = New System.Drawing.Size(131, 36)
        Me.dtpBday.TabIndex = 2
        Me.dtpBday.Value = New Date(2020, 12, 31, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Georgia", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(190, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Birthdate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Gender"
        '
        'txtLRN
        '
        Me.txtLRN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLRN.DefaultText = ""
        Me.txtLRN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLRN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLRN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLRN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLRN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLRN.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.txtLRN.ForeColor = System.Drawing.Color.Black
        Me.txtLRN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLRN.Location = New System.Drawing.Point(12, 44)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLRN.PlaceholderText = ""
        Me.txtLRN.SelectedText = ""
        Me.txtLRN.Size = New System.Drawing.Size(312, 36)
        Me.txtLRN.TabIndex = 0
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
        Me.txtAddress.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(9, 352)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = ""
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(315, 78)
        Me.txtAddress.TabIndex = 12
        '
        'txtMiddlename
        '
        Me.txtMiddlename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddlename.DefaultText = ""
        Me.txtMiddlename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMiddlename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMiddlename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddlename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiddlename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddlename.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.txtMiddlename.ForeColor = System.Drawing.Color.Black
        Me.txtMiddlename.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddlename.Location = New System.Drawing.Point(12, 162)
        Me.txtMiddlename.MaxLength = 2
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddlename.PlaceholderText = ""
        Me.txtMiddlename.SelectedText = ""
        Me.txtMiddlename.Size = New System.Drawing.Size(312, 36)
        Me.txtMiddlename.TabIndex = 6
        '
        'txtFirstname
        '
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.DefaultText = ""
        Me.txtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstname.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.txtFirstname.ForeColor = System.Drawing.Color.Black
        Me.txtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstname.Location = New System.Drawing.Point(12, 103)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.PlaceholderText = ""
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.Size = New System.Drawing.Size(312, 36)
        Me.txtFirstname.TabIndex = 5
        '
        'txtLastname
        '
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.DefaultText = ""
        Me.txtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastname.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.txtLastname.ForeColor = System.Drawing.Color.Black
        Me.txtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastname.Location = New System.Drawing.Point(12, 221)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.PlaceholderText = ""
        Me.txtLastname.SelectedText = ""
        Me.txtLastname.Size = New System.Drawing.Size(222, 36)
        Me.txtLastname.TabIndex = 4
        '
        'frmStudentRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 561)
        Me.Controls.Add(Me.GBStudentRegistration)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmStudentRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GBStudentRegistration.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbRequirements.ResumeLayout(False)
        CType(Me.dgvRequirements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBStudentRegistration As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpBday As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLRN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMiddlename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbSuffix As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbFemale As RadioButton
    Friend WithEvents cbMale As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents gbRequirements As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvRequirements As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents colCheckBoxReq As DataGridViewCheckBoxColumn
End Class
