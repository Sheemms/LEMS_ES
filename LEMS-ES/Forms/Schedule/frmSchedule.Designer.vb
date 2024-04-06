<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedule
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbW = New System.Windows.Forms.CheckBox()
        Me.cbT = New System.Windows.Forms.CheckBox()
        Me.cbM = New System.Windows.Forms.CheckBox()
        Me.lblSY = New System.Windows.Forms.Label()
        Me.dgvRequirements = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.txtTeacherName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTeacherID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtendTime = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtstartTime = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSubjName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSubjCode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAdviser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdviserID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSection = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbGradeLevel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDepartment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTH = New System.Windows.Forms.CheckBox()
        Me.cbF = New System.Windows.Forms.CheckBox()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRequirements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 615)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scheduling"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cbF)
        Me.Panel1.Controls.Add(Me.cbTH)
        Me.Panel1.Controls.Add(Me.cbW)
        Me.Panel1.Controls.Add(Me.cbT)
        Me.Panel1.Controls.Add(Me.cbM)
        Me.Panel1.Controls.Add(Me.lblSY)
        Me.Panel1.Controls.Add(Me.dgvRequirements)
        Me.Panel1.Controls.Add(Me.txtTeacherName)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtTeacherID)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtendTime)
        Me.Panel1.Controls.Add(Me.txtstartTime)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtSubjName)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmbSubjCode)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtAdviser)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtAdviserID)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmbSection)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbGradeLevel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbDepartment)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 578)
        Me.Panel1.TabIndex = 0
        '
        'cbW
        '
        Me.cbW.AutoSize = True
        Me.cbW.Location = New System.Drawing.Point(885, 14)
        Me.cbW.Name = "cbW"
        Me.cbW.Size = New System.Drawing.Size(92, 18)
        Me.cbW.TabIndex = 34
        Me.cbW.Text = "Wednesday"
        Me.cbW.UseVisualStyleBackColor = True
        '
        'cbT
        '
        Me.cbT.AutoSize = True
        Me.cbT.Location = New System.Drawing.Point(804, 14)
        Me.cbT.Name = "cbT"
        Me.cbT.Size = New System.Drawing.Size(75, 18)
        Me.cbT.TabIndex = 33
        Me.cbT.Text = "Tuesday"
        Me.cbT.UseVisualStyleBackColor = True
        '
        'cbM
        '
        Me.cbM.AutoSize = True
        Me.cbM.Location = New System.Drawing.Point(715, 14)
        Me.cbM.Name = "cbM"
        Me.cbM.Size = New System.Drawing.Size(72, 18)
        Me.cbM.TabIndex = 32
        Me.cbM.Text = "Monday"
        Me.cbM.UseVisualStyleBackColor = True
        '
        'lblSY
        '
        Me.lblSY.AutoSize = True
        Me.lblSY.Location = New System.Drawing.Point(95, 28)
        Me.lblSY.Name = "lblSY"
        Me.lblSY.Size = New System.Drawing.Size(75, 14)
        Me.lblSY.TabIndex = 31
        Me.lblSY.Text = "2024-2025"
        Me.lblSY.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dgvRequirements
        '
        Me.dgvRequirements.AllowUserToAddRows = False
        Me.dgvRequirements.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvRequirements.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRequirements.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvRequirements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvRequirements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequirements.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRequirements.ColumnHeadersHeight = 44
        Me.dgvRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvRequirements.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRequirements.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRequirements.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvRequirements.Location = New System.Drawing.Point(18, 206)
        Me.dgvRequirements.MultiSelect = False
        Me.dgvRequirements.Name = "dgvRequirements"
        Me.dgvRequirements.RowHeadersVisible = False
        Me.dgvRequirements.Size = New System.Drawing.Size(1100, 352)
        Me.dgvRequirements.TabIndex = 29
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
        'txtTeacherName
        '
        Me.txtTeacherName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTeacherName.DefaultText = ""
        Me.txtTeacherName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTeacherName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTeacherName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTeacherName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTeacherName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTeacherName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTeacherName.ForeColor = System.Drawing.Color.Black
        Me.txtTeacherName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTeacherName.Location = New System.Drawing.Point(715, 140)
        Me.txtTeacherName.Name = "txtTeacherName"
        Me.txtTeacherName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTeacherName.PlaceholderText = ""
        Me.txtTeacherName.SelectedText = ""
        Me.txtTeacherName.Size = New System.Drawing.Size(247, 36)
        Me.txtTeacherName.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(655, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 14)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Teacher"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTeacherID
        '
        Me.txtTeacherID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTeacherID.DefaultText = ""
        Me.txtTeacherID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTeacherID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTeacherID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTeacherID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTeacherID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTeacherID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTeacherID.ForeColor = System.Drawing.Color.Black
        Me.txtTeacherID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTeacherID.Location = New System.Drawing.Point(715, 98)
        Me.txtTeacherID.Name = "txtTeacherID"
        Me.txtTeacherID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTeacherID.PlaceholderText = ""
        Me.txtTeacherID.SelectedText = ""
        Me.txtTeacherID.Size = New System.Drawing.Size(98, 36)
        Me.txtTeacherID.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(640, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 14)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Teacher ID"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtendTime
        '
        Me.txtendTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtendTime.DefaultText = ""
        Me.txtendTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtendTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtendTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtendTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtendTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtendTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtendTime.ForeColor = System.Drawing.Color.Black
        Me.txtendTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtendTime.Location = New System.Drawing.Point(864, 56)
        Me.txtendTime.Name = "txtendTime"
        Me.txtendTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtendTime.PlaceholderText = "__:__"
        Me.txtendTime.SelectedText = ""
        Me.txtendTime.Size = New System.Drawing.Size(98, 36)
        Me.txtendTime.TabIndex = 24
        '
        'txtstartTime
        '
        Me.txtstartTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstartTime.DefaultText = ""
        Me.txtstartTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtstartTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtstartTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstartTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstartTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstartTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtstartTime.ForeColor = System.Drawing.Color.Black
        Me.txtstartTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstartTime.Location = New System.Drawing.Point(715, 56)
        Me.txtstartTime.Name = "txtstartTime"
        Me.txtstartTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstartTime.PlaceholderText = "__:__"
        Me.txtstartTime.SelectedText = ""
        Me.txtstartTime.Size = New System.Drawing.Size(98, 36)
        Me.txtstartTime.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(628, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 14)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Time [From]"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(655, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 14)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Day(s)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSubjName
        '
        Me.txtSubjName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubjName.DefaultText = ""
        Me.txtSubjName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubjName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubjName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubjName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubjName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubjName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSubjName.ForeColor = System.Drawing.Color.Black
        Me.txtSubjName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubjName.Location = New System.Drawing.Point(398, 140)
        Me.txtSubjName.Name = "txtSubjName"
        Me.txtSubjName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubjName.PlaceholderText = ""
        Me.txtSubjName.SelectedText = ""
        Me.txtSubjName.Size = New System.Drawing.Size(200, 36)
        Me.txtSubjName.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(87, 14)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Subject Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbSubjCode
        '
        Me.cmbSubjCode.BackColor = System.Drawing.Color.Transparent
        Me.cmbSubjCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSubjCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubjCode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSubjCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSubjCode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSubjCode.ForeColor = System.Drawing.Color.Black
        Me.cmbSubjCode.ItemHeight = 30
        Me.cmbSubjCode.Location = New System.Drawing.Point(398, 98)
        Me.cmbSubjCode.Name = "cmbSubjCode"
        Me.cmbSubjCode.Size = New System.Drawing.Size(200, 36)
        Me.cmbSubjCode.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(315, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(80, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Subject Code"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAdviser
        '
        Me.txtAdviser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdviser.DefaultText = ""
        Me.txtAdviser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdviser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdviser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdviser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdviser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdviser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdviser.ForeColor = System.Drawing.Color.Black
        Me.txtAdviser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdviser.Location = New System.Drawing.Point(398, 56)
        Me.txtAdviser.Name = "txtAdviser"
        Me.txtAdviser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdviser.PlaceholderText = ""
        Me.txtAdviser.SelectedText = ""
        Me.txtAdviser.Size = New System.Drawing.Size(200, 36)
        Me.txtAdviser.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Adviser"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAdviserID
        '
        Me.txtAdviserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdviserID.DefaultText = ""
        Me.txtAdviserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdviserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdviserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdviserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdviserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdviserID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdviserID.ForeColor = System.Drawing.Color.Black
        Me.txtAdviserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdviserID.Location = New System.Drawing.Point(398, 14)
        Me.txtAdviserID.Name = "txtAdviserID"
        Me.txtAdviserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdviserID.PlaceholderText = ""
        Me.txtAdviserID.SelectedText = ""
        Me.txtAdviserID.Size = New System.Drawing.Size(200, 36)
        Me.txtAdviserID.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Adviser ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbSection
        '
        Me.cmbSection.BackColor = System.Drawing.Color.Transparent
        Me.cmbSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSection.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSection.ForeColor = System.Drawing.Color.Black
        Me.cmbSection.ItemHeight = 30
        Me.cmbSection.Location = New System.Drawing.Point(98, 140)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(200, 36)
        Me.cmbSection.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Section"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbGradeLevel
        '
        Me.cmbGradeLevel.BackColor = System.Drawing.Color.Transparent
        Me.cmbGradeLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGradeLevel.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbGradeLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbGradeLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbGradeLevel.ForeColor = System.Drawing.Color.Black
        Me.cmbGradeLevel.ItemHeight = 30
        Me.cmbGradeLevel.Location = New System.Drawing.Point(98, 98)
        Me.cmbGradeLevel.Name = "cmbGradeLevel"
        Me.cmbGradeLevel.Size = New System.Drawing.Size(200, 36)
        Me.cmbGradeLevel.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Grade Level"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbDepartment
        '
        Me.cmbDepartment.BackColor = System.Drawing.Color.Transparent
        Me.cmbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDepartment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDepartment.ForeColor = System.Drawing.Color.Black
        Me.cmbDepartment.ItemHeight = 30
        Me.cmbDepartment.Location = New System.Drawing.Point(98, 56)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(200, 36)
        Me.cmbDepartment.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Department"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "School Year"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbTH
        '
        Me.cbTH.AutoSize = True
        Me.cbTH.Location = New System.Drawing.Point(715, 32)
        Me.cbTH.Name = "cbTH"
        Me.cbTH.Size = New System.Drawing.Size(83, 18)
        Me.cbTH.TabIndex = 35
        Me.cbTH.Text = "Thursday"
        Me.cbTH.UseVisualStyleBackColor = True
        '
        'cbF
        '
        Me.cbF.AutoSize = True
        Me.cbF.Location = New System.Drawing.Point(804, 32)
        Me.cbF.Name = "cbF"
        Me.cbF.Size = New System.Drawing.Size(65, 18)
        Me.cbF.TabIndex = 36
        Me.cbF.Text = "Friday"
        Me.cbF.UseVisualStyleBackColor = True
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Subject Code"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 96
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Subject Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Time"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 62
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Day"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 55
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Grade"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 67
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Section"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 74
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Teacher"
        Me.Column7.Name = "Column7"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(819, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 14)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "[To]"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 615)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvRequirements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTeacherName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTeacherID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtendTime As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtstartTime As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSubjName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbSubjCode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAdviser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAdviserID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSection As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbGradeLevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvRequirements As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cbW As CheckBox
    Friend WithEvents cbT As CheckBox
    Friend WithEvents cbM As CheckBox
    Friend WithEvents lblSY As Label
    Friend WithEvents cbF As CheckBox
    Friend WithEvents cbTH As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
