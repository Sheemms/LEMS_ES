<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSchedule
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmbRoom = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbAdviser = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CmbSubjectCode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtendTime = New System.Windows.Forms.MaskedTextBox()
        Me.txtstartTime = New System.Windows.Forms.MaskedTextBox()
        Me.TxtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.searchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvSchedule = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TxtUnits = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbF = New System.Windows.Forms.CheckBox()
        Me.cbTH = New System.Windows.Forms.CheckBox()
        Me.cbW = New System.Windows.Forms.CheckBox()
        Me.cbT = New System.Windows.Forms.CheckBox()
        Me.cbM = New System.Windows.Forms.CheckBox()
        Me.lblSY = New System.Windows.Forms.Label()
        Me.txtTeacherName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTeacherID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSubjName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1007, 735)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scheduling"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.CmbRoom)
        Me.Panel1.Controls.Add(Me.CmbAdviser)
        Me.Panel1.Controls.Add(Me.CmbSubjectCode)
        Me.Panel1.Controls.Add(Me.txtendTime)
        Me.Panel1.Controls.Add(Me.txtstartTime)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Controls.Add(Me.searchBtn)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.TxtUnits)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cbF)
        Me.Panel1.Controls.Add(Me.cbTH)
        Me.Panel1.Controls.Add(Me.cbW)
        Me.Panel1.Controls.Add(Me.cbT)
        Me.Panel1.Controls.Add(Me.cbM)
        Me.Panel1.Controls.Add(Me.lblSY)
        Me.Panel1.Controls.Add(Me.txtTeacherName)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtTeacherID)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtSubjName)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
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
        Me.Panel1.Size = New System.Drawing.Size(1001, 698)
        Me.Panel1.TabIndex = 0
        '
        'CmbRoom
        '
        Me.CmbRoom.BackColor = System.Drawing.Color.Transparent
        Me.CmbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRoom.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbRoom.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbRoom.ForeColor = System.Drawing.Color.Black
        Me.CmbRoom.ItemHeight = 30
        Me.CmbRoom.Location = New System.Drawing.Point(103, 187)
        Me.CmbRoom.Name = "CmbRoom"
        Me.CmbRoom.Size = New System.Drawing.Size(200, 36)
        Me.CmbRoom.TabIndex = 54
        '
        'CmbAdviser
        '
        Me.CmbAdviser.BackColor = System.Drawing.Color.Transparent
        Me.CmbAdviser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbAdviser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAdviser.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbAdviser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbAdviser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbAdviser.ForeColor = System.Drawing.Color.Black
        Me.CmbAdviser.ItemHeight = 30
        Me.CmbAdviser.Location = New System.Drawing.Point(406, 61)
        Me.CmbAdviser.Name = "CmbAdviser"
        Me.CmbAdviser.Size = New System.Drawing.Size(200, 36)
        Me.CmbAdviser.TabIndex = 53
        '
        'CmbSubjectCode
        '
        Me.CmbSubjectCode.BackColor = System.Drawing.Color.Transparent
        Me.CmbSubjectCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbSubjectCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSubjectCode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbSubjectCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbSubjectCode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbSubjectCode.ForeColor = System.Drawing.Color.Black
        Me.CmbSubjectCode.ItemHeight = 30
        Me.CmbSubjectCode.Location = New System.Drawing.Point(406, 103)
        Me.CmbSubjectCode.Name = "CmbSubjectCode"
        Me.CmbSubjectCode.Size = New System.Drawing.Size(200, 36)
        Me.CmbSubjectCode.TabIndex = 52
        '
        'txtendTime
        '
        Me.txtendTime.Font = New System.Drawing.Font("Georgia", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtendTime.Location = New System.Drawing.Point(867, 61)
        Me.txtendTime.Mask = "00:00"
        Me.txtendTime.Name = "txtendTime"
        Me.txtendTime.Size = New System.Drawing.Size(100, 36)
        Me.txtendTime.TabIndex = 51
        '
        'txtstartTime
        '
        Me.txtstartTime.Font = New System.Drawing.Font("Georgia", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstartTime.Location = New System.Drawing.Point(720, 61)
        Me.txtstartTime.Mask = "00:00"
        Me.txtstartTime.Name = "txtstartTime"
        Me.txtstartTime.Size = New System.Drawing.Size(100, 36)
        Me.txtstartTime.TabIndex = 50
        '
        'TxtSearch
        '
        Me.TxtSearch.Animated = True
        Me.TxtSearch.AutoRoundedCorners = True
        Me.TxtSearch.BorderRadius = 17
        Me.TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSearch.DefaultText = ""
        Me.TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtSearch.FillColor = System.Drawing.Color.LemonChiffon
        Me.TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSearch.ForeColor = System.Drawing.Color.Black
        Me.TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSearch.IconLeft = Global.LEMS_ES.My.Resources.Resources.search
        Me.TxtSearch.Location = New System.Drawing.Point(720, 187)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSearch.PlaceholderText = ""
        Me.TxtSearch.SelectedText = ""
        Me.TxtSearch.Size = New System.Drawing.Size(247, 36)
        Me.TxtSearch.TabIndex = 49
        '
        'searchBtn
        '
        Me.searchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.searchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.searchBtn.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.Color.White
        Me.searchBtn.Location = New System.Drawing.Point(640, 187)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(78, 36)
        Me.searchBtn.TabIndex = 48
        Me.searchBtn.Text = "Search"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(42, 229)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(950, 379)
        Me.TabControl1.TabIndex = 46
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvSchedule)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(942, 352)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lists"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvSchedule.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSchedule.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSchedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSchedule.ColumnHeadersHeight = 44
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSchedule.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.Column8, Me.Column2, Me.Column1, Me.Column10, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSchedule.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSchedule.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSchedule.Location = New System.Drawing.Point(3, 3)
        Me.dgvSchedule.MultiSelect = False
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.ReadOnly = True
        Me.dgvSchedule.RowHeadersVisible = False
        Me.dgvSchedule.Size = New System.Drawing.Size(936, 346)
        Me.dgvSchedule.TabIndex = 29
        Me.dgvSchedule.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSchedule.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvSchedule.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvSchedule.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvSchedule.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvSchedule.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.dgvSchedule.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSchedule.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvSchedule.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgvSchedule.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSchedule.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSchedule.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSchedule.ThemeStyle.HeaderStyle.Height = 44
        Me.dgvSchedule.ThemeStyle.ReadOnly = True
        Me.dgvSchedule.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSchedule.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvSchedule.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSchedule.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSchedule.ThemeStyle.RowsStyle.Height = 22
        Me.dgvSchedule.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSchedule.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(942, 414)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Print Preview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(936, 408)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'TxtUnits
        '
        Me.TxtUnits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUnits.DefaultText = ""
        Me.TxtUnits.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUnits.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUnits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUnits.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUnits.Enabled = False
        Me.TxtUnits.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUnits.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtUnits.ForeColor = System.Drawing.Color.Black
        Me.TxtUnits.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUnits.Location = New System.Drawing.Point(406, 187)
        Me.TxtUnits.Name = "TxtUnits"
        Me.TxtUnits.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUnits.PlaceholderText = ""
        Me.TxtUnits.ReadOnly = True
        Me.TxtUnits.SelectedText = ""
        Me.TxtUnits.Size = New System.Drawing.Size(200, 36)
        Me.TxtUnits.TabIndex = 45
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(352, 199)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label15.Size = New System.Drawing.Size(48, 14)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Unit(s)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(58, 199)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label14.Size = New System.Drawing.Size(39, 14)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Room"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.btnSave.Location = New System.Drawing.Point(835, 628)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(153, 36)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "Save"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(824, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 14)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "[To]"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbF
        '
        Me.cbF.AutoSize = True
        Me.cbF.Location = New System.Drawing.Point(809, 37)
        Me.cbF.Name = "cbF"
        Me.cbF.Size = New System.Drawing.Size(65, 18)
        Me.cbF.TabIndex = 36
        Me.cbF.Text = "Friday"
        Me.cbF.UseVisualStyleBackColor = True
        '
        'cbTH
        '
        Me.cbTH.AutoSize = True
        Me.cbTH.Location = New System.Drawing.Point(720, 37)
        Me.cbTH.Name = "cbTH"
        Me.cbTH.Size = New System.Drawing.Size(83, 18)
        Me.cbTH.TabIndex = 35
        Me.cbTH.Text = "Thursday"
        Me.cbTH.UseVisualStyleBackColor = True
        '
        'cbW
        '
        Me.cbW.AutoSize = True
        Me.cbW.Location = New System.Drawing.Point(890, 19)
        Me.cbW.Name = "cbW"
        Me.cbW.Size = New System.Drawing.Size(92, 18)
        Me.cbW.TabIndex = 34
        Me.cbW.Text = "Wednesday"
        Me.cbW.UseVisualStyleBackColor = True
        '
        'cbT
        '
        Me.cbT.AutoSize = True
        Me.cbT.Location = New System.Drawing.Point(809, 19)
        Me.cbT.Name = "cbT"
        Me.cbT.Size = New System.Drawing.Size(75, 18)
        Me.cbT.TabIndex = 33
        Me.cbT.Text = "Tuesday"
        Me.cbT.UseVisualStyleBackColor = True
        '
        'cbM
        '
        Me.cbM.AutoSize = True
        Me.cbM.Location = New System.Drawing.Point(720, 19)
        Me.cbM.Name = "cbM"
        Me.cbM.Size = New System.Drawing.Size(72, 18)
        Me.cbM.TabIndex = 32
        Me.cbM.Text = "Monday"
        Me.cbM.UseVisualStyleBackColor = True
        '
        'lblSY
        '
        Me.lblSY.AutoSize = True
        Me.lblSY.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSY.ForeColor = System.Drawing.Color.Red
        Me.lblSY.Location = New System.Drawing.Point(100, 29)
        Me.lblSY.Name = "lblSY"
        Me.lblSY.Size = New System.Drawing.Size(86, 18)
        Me.lblSY.TabIndex = 31
        Me.lblSY.Text = "0000-0000"
        Me.lblSY.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.txtTeacherName.Location = New System.Drawing.Point(720, 145)
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
        Me.Label12.Location = New System.Drawing.Point(660, 152)
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
        Me.txtTeacherID.Location = New System.Drawing.Point(720, 103)
        Me.txtTeacherID.Name = "txtTeacherID"
        Me.txtTeacherID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTeacherID.PlaceholderText = ""
        Me.txtTeacherID.SelectedText = ""
        Me.txtTeacherID.Size = New System.Drawing.Size(247, 36)
        Me.txtTeacherID.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(645, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 14)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Teacher ID"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(633, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 14)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Time [From]"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(660, 23)
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
        Me.txtSubjName.Enabled = False
        Me.txtSubjName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubjName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSubjName.ForeColor = System.Drawing.Color.Black
        Me.txtSubjName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubjName.Location = New System.Drawing.Point(406, 145)
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
        Me.Label8.Location = New System.Drawing.Point(313, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(87, 14)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Subject Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(320, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(80, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Subject Code"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 73)
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
        Me.txtAdviserID.Enabled = False
        Me.txtAdviserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdviserID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdviserID.ForeColor = System.Drawing.Color.Black
        Me.txtAdviserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdviserID.Location = New System.Drawing.Point(406, 19)
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
        Me.Label5.Location = New System.Drawing.Point(330, 33)
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
        Me.cmbSection.Location = New System.Drawing.Point(103, 145)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(200, 36)
        Me.cmbSection.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 155)
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
        Me.cmbGradeLevel.Location = New System.Drawing.Point(103, 103)
        Me.cmbGradeLevel.Name = "cmbGradeLevel"
        Me.cmbGradeLevel.Size = New System.Drawing.Size(200, 36)
        Me.cmbGradeLevel.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 114)
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
        Me.cmbDepartment.Location = New System.Drawing.Point(103, 61)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(200, 36)
        Me.cmbDepartment.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Department"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "School Year"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "SchoolYear"
        Me.Column8.HeaderText = "School Year"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "Department"
        Me.Column2.HeaderText = "Department"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.DataPropertyName = "SubjectCode"
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 59
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.DataPropertyName = "SubjectName"
        Me.Column10.HeaderText = "Subject"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "SectionRoom"
        Me.Column3.HeaderText = "Section"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.DataPropertyName = "Room"
        Me.Column4.HeaderText = "Room"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 64
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.DataPropertyName = "Adviser"
        Me.Column5.HeaderText = "Adviser"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 77
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.DataPropertyName = "Days"
        Me.Column6.HeaderText = "Days"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 60
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.DataPropertyName = "Time"
        Me.Column7.HeaderText = "Time"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.DataPropertyName = "Teacher"
        Me.Column9.HeaderText = "Teacher"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 79
        '
        'FrmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 735)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTeacherName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTeacherID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSubjName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAdviserID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSection As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbGradeLevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbDepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvSchedule As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cbW As CheckBox
    Friend WithEvents cbT As CheckBox
    Friend WithEvents cbM As CheckBox
    Friend WithEvents lblSY As Label
    Friend WithEvents cbF As CheckBox
    Friend WithEvents cbTH As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtUnits As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents searchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtendTime As MaskedTextBox
    Friend WithEvents txtstartTime As MaskedTextBox
    Friend WithEvents CmbSubjectCode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbAdviser As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CmbRoom As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
