﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayments
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtLRN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGradeLvl = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSection = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbOtherFee = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.LabelORNO = New System.Windows.Forms.Label()
        Me.LabelEID = New System.Windows.Forms.Label()
        Me.Addbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvReceipt = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelSY = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvTransactionHistory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtChanges = New Guna.UI2.WinForms.Guna2TextBox()
        Me.RbDiscount = New System.Windows.Forms.RadioButton()
        Me.RbNoChanges = New System.Windows.Forms.RadioButton()
        Me.RbAdditional = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCurPayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnPayments = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbModeofPayment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMiscellaneous = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTuition = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelCurrentBalance = New System.Windows.Forms.Label()
        Me.LabelTotalPayment = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvTransactionHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txtLRN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLRN.ForeColor = System.Drawing.Color.Black
        Me.txtLRN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLRN.Location = New System.Drawing.Point(21, 96)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLRN.PlaceholderText = ""
        Me.txtLRN.ReadOnly = True
        Me.txtLRN.SelectedText = ""
        Me.txtLRN.Size = New System.Drawing.Size(215, 36)
        Me.txtLRN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LRN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Student Name"
        '
        'txtStudName
        '
        Me.txtStudName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudName.DefaultText = ""
        Me.txtStudName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudName.ForeColor = System.Drawing.Color.Black
        Me.txtStudName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudName.Location = New System.Drawing.Point(21, 152)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudName.PlaceholderText = ""
        Me.txtStudName.ReadOnly = True
        Me.txtStudName.SelectedText = ""
        Me.txtStudName.Size = New System.Drawing.Size(215, 36)
        Me.txtStudName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Grade Level"
        '
        'txtGradeLvl
        '
        Me.txtGradeLvl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGradeLvl.DefaultText = ""
        Me.txtGradeLvl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGradeLvl.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGradeLvl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGradeLvl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGradeLvl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGradeLvl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtGradeLvl.ForeColor = System.Drawing.Color.Black
        Me.txtGradeLvl.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGradeLvl.Location = New System.Drawing.Point(21, 208)
        Me.txtGradeLvl.Name = "txtGradeLvl"
        Me.txtGradeLvl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGradeLvl.PlaceholderText = ""
        Me.txtGradeLvl.ReadOnly = True
        Me.txtGradeLvl.SelectedText = ""
        Me.txtGradeLvl.Size = New System.Drawing.Size(102, 36)
        Me.txtGradeLvl.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(129, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Section"
        '
        'txtSection
        '
        Me.txtSection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSection.DefaultText = ""
        Me.txtSection.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSection.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSection.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSection.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSection.ForeColor = System.Drawing.Color.Black
        Me.txtSection.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSection.Location = New System.Drawing.Point(129, 208)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSection.PlaceholderText = ""
        Me.txtSection.ReadOnly = True
        Me.txtSection.SelectedText = ""
        Me.txtSection.Size = New System.Drawing.Size(107, 36)
        Me.txtSection.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Other Fee"
        '
        'cmbOtherFee
        '
        Me.cmbOtherFee.BackColor = System.Drawing.Color.Transparent
        Me.cmbOtherFee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbOtherFee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOtherFee.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbOtherFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbOtherFee.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbOtherFee.ForeColor = System.Drawing.Color.Black
        Me.cmbOtherFee.ItemHeight = 30
        Me.cmbOtherFee.Location = New System.Drawing.Point(21, 376)
        Me.cmbOtherFee.Name = "cmbOtherFee"
        Me.cmbOtherFee.Size = New System.Drawing.Size(146, 36)
        Me.cmbOtherFee.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(290, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 27)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Payment:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.GroupBox1.Controls.Add(Me.LabelORNO)
        Me.GroupBox1.Controls.Add(Me.LabelEID)
        Me.GroupBox1.Controls.Add(Me.Addbtn)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.LabelSY)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TxtChanges)
        Me.GroupBox1.Controls.Add(Me.RbDiscount)
        Me.GroupBox1.Controls.Add(Me.RbNoChanges)
        Me.GroupBox1.Controls.Add(Me.RbAdditional)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtCurPayment)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.BtnPayments)
        Me.GroupBox1.Controls.Add(Me.cmbModeofPayment)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMiscellaneous)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtTuition)
        Me.GroupBox1.Controls.Add(Me.txtLRN)
        Me.GroupBox1.Controls.Add(Me.LabelCurrentBalance)
        Me.GroupBox1.Controls.Add(Me.LabelTotalPayment)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStudName)
        Me.GroupBox1.Controls.Add(Me.cmbOtherFee)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtGradeLvl)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSection)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(673, 591)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(173, 543)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(63, 36)
        Me.Guna2Button1.TabIndex = 48
        Me.Guna2Button1.Text = "Add"
        '
        'LabelORNO
        '
        Me.LabelORNO.AutoSize = True
        Me.LabelORNO.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelORNO.ForeColor = System.Drawing.Color.Red
        Me.LabelORNO.Location = New System.Drawing.Point(467, 55)
        Me.LabelORNO.Name = "LabelORNO"
        Me.LabelORNO.Size = New System.Drawing.Size(175, 21)
        Me.LabelORNO.TabIndex = 47
        Me.LabelORNO.Text = "ORNO20240421001"
        '
        'LabelEID
        '
        Me.LabelEID.AutoSize = True
        Me.LabelEID.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEID.ForeColor = System.Drawing.Color.Red
        Me.LabelEID.Location = New System.Drawing.Point(522, 37)
        Me.LabelEID.Name = "LabelEID"
        Me.LabelEID.Size = New System.Drawing.Size(120, 16)
        Me.LabelEID.TabIndex = 46
        Me.LabelEID.Text = "EID20240421001"
        '
        'Addbtn
        '
        Me.Addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Addbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Addbtn.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbtn.ForeColor = System.Drawing.Color.White
        Me.Addbtn.Location = New System.Drawing.Point(173, 376)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(63, 36)
        Me.Addbtn.TabIndex = 44
        Me.Addbtn.Text = "Add"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvReceipt)
        Me.GroupBox3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(264, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(394, 312)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Receipt"
        '
        'DgvReceipt
        '
        Me.DgvReceipt.AllowUserToAddRows = False
        Me.DgvReceipt.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.DgvReceipt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DgvReceipt.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvReceipt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DgvReceipt.ColumnHeadersHeight = 32
        Me.DgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvReceipt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column9})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvReceipt.DefaultCellStyle = DataGridViewCellStyle15
        Me.DgvReceipt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvReceipt.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvReceipt.Location = New System.Drawing.Point(3, 20)
        Me.DgvReceipt.MultiSelect = False
        Me.DgvReceipt.Name = "DgvReceipt"
        Me.DgvReceipt.ReadOnly = True
        Me.DgvReceipt.RowHeadersVisible = False
        Me.DgvReceipt.Size = New System.Drawing.Size(388, 289)
        Me.DgvReceipt.TabIndex = 1
        Me.DgvReceipt.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvReceipt.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvReceipt.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvReceipt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvReceipt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvReceipt.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.DgvReceipt.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvReceipt.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvReceipt.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvReceipt.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvReceipt.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvReceipt.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvReceipt.ThemeStyle.HeaderStyle.Height = 32
        Me.DgvReceipt.ThemeStyle.ReadOnly = True
        Me.DgvReceipt.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvReceipt.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvReceipt.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvReceipt.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvReceipt.ThemeStyle.RowsStyle.Height = 22
        Me.DgvReceipt.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvReceipt.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Remarks"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Amount"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 85
        '
        'LabelSY
        '
        Me.LabelSY.AutoSize = True
        Me.LabelSY.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSY.ForeColor = System.Drawing.Color.Red
        Me.LabelSY.Location = New System.Drawing.Point(562, 21)
        Me.LabelSY.Name = "LabelSY"
        Me.LabelSY.Size = New System.Drawing.Size(80, 16)
        Me.LabelSY.TabIndex = 43
        Me.LabelSY.Text = "0000-0000"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvTransactionHistory)
        Me.GroupBox2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(748, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 271)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction History"
        Me.GroupBox2.Visible = False
        '
        'DgvTransactionHistory
        '
        Me.DgvTransactionHistory.AllowUserToAddRows = False
        Me.DgvTransactionHistory.AllowUserToDeleteRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.DgvTransactionHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DgvTransactionHistory.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTransactionHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DgvTransactionHistory.ColumnHeadersHeight = 32
        Me.DgvTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvTransactionHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTransactionHistory.DefaultCellStyle = DataGridViewCellStyle18
        Me.DgvTransactionHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvTransactionHistory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvTransactionHistory.Location = New System.Drawing.Point(3, 20)
        Me.DgvTransactionHistory.MultiSelect = False
        Me.DgvTransactionHistory.Name = "DgvTransactionHistory"
        Me.DgvTransactionHistory.ReadOnly = True
        Me.DgvTransactionHistory.RowHeadersVisible = False
        Me.DgvTransactionHistory.Size = New System.Drawing.Size(400, 248)
        Me.DgvTransactionHistory.TabIndex = 1
        Me.DgvTransactionHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvTransactionHistory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvTransactionHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvTransactionHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvTransactionHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvTransactionHistory.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.DgvTransactionHistory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvTransactionHistory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvTransactionHistory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvTransactionHistory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvTransactionHistory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvTransactionHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvTransactionHistory.ThemeStyle.HeaderStyle.Height = 32
        Me.DgvTransactionHistory.ThemeStyle.ReadOnly = True
        Me.DgvTransactionHistory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvTransactionHistory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvTransactionHistory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvTransactionHistory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvTransactionHistory.ThemeStyle.RowsStyle.Height = 22
        Me.DgvTransactionHistory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvTransactionHistory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "LRN"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 58
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Level"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 76
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Section"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 94
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Amount"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 85
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Date"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 67
        '
        'TxtChanges
        '
        Me.TxtChanges.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtChanges.DefaultText = ""
        Me.TxtChanges.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtChanges.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtChanges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtChanges.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtChanges.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtChanges.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtChanges.ForeColor = System.Drawing.Color.Black
        Me.TxtChanges.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtChanges.Location = New System.Drawing.Point(21, 544)
        Me.TxtChanges.Name = "TxtChanges"
        Me.TxtChanges.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtChanges.PlaceholderText = ""
        Me.TxtChanges.SelectedText = ""
        Me.TxtChanges.Size = New System.Drawing.Size(146, 36)
        Me.TxtChanges.TabIndex = 39
        '
        'RbDiscount
        '
        Me.RbDiscount.AutoSize = True
        Me.RbDiscount.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDiscount.Location = New System.Drawing.Point(21, 517)
        Me.RbDiscount.Name = "RbDiscount"
        Me.RbDiscount.Size = New System.Drawing.Size(81, 18)
        Me.RbDiscount.TabIndex = 38
        Me.RbDiscount.TabStop = True
        Me.RbDiscount.Text = "Discount"
        Me.RbDiscount.UseVisualStyleBackColor = True
        '
        'RbNoChanges
        '
        Me.RbNoChanges.AutoSize = True
        Me.RbNoChanges.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoChanges.Location = New System.Drawing.Point(122, 493)
        Me.RbNoChanges.Name = "RbNoChanges"
        Me.RbNoChanges.Size = New System.Drawing.Size(95, 18)
        Me.RbNoChanges.TabIndex = 37
        Me.RbNoChanges.TabStop = True
        Me.RbNoChanges.Text = "No Changes"
        Me.RbNoChanges.UseVisualStyleBackColor = True
        '
        'RbAdditional
        '
        Me.RbAdditional.AutoSize = True
        Me.RbAdditional.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAdditional.Location = New System.Drawing.Point(21, 493)
        Me.RbAdditional.Name = "RbAdditional"
        Me.RbAdditional.Size = New System.Drawing.Size(95, 18)
        Me.RbAdditional.TabIndex = 36
        Me.RbAdditional.TabStop = True
        Me.RbAdditional.Text = "Additional"
        Me.RbAdditional.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 476)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 14)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Changes"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Courier New", 18.0!)
        Me.Label12.Location = New System.Drawing.Point(262, 484)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(236, 27)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Current Payment:"
        '
        'TxtCurPayment
        '
        Me.TxtCurPayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCurPayment.DefaultText = ""
        Me.TxtCurPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCurPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCurPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCurPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCurPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCurPayment.Font = New System.Drawing.Font("Courier New", 18.0!)
        Me.TxtCurPayment.ForeColor = System.Drawing.Color.Black
        Me.TxtCurPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCurPayment.Location = New System.Drawing.Point(504, 484)
        Me.TxtCurPayment.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TxtCurPayment.Name = "TxtCurPayment"
        Me.TxtCurPayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCurPayment.PlaceholderText = ""
        Me.TxtCurPayment.SelectedText = ""
        Me.TxtCurPayment.Size = New System.Drawing.Size(154, 37)
        Me.TxtCurPayment.TabIndex = 32
        Me.TxtCurPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(262, 444)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(236, 27)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Current Balance:"
        '
        'BtnPayments
        '
        Me.BtnPayments.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnPayments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnPayments.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPayments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPayments.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnPayments.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPayments.ForeColor = System.Drawing.Color.White
        Me.BtnPayments.Location = New System.Drawing.Point(494, 544)
        Me.BtnPayments.Name = "BtnPayments"
        Me.BtnPayments.Size = New System.Drawing.Size(164, 36)
        Me.BtnPayments.TabIndex = 20
        Me.BtnPayments.Text = "Save"
        '
        'cmbModeofPayment
        '
        Me.cmbModeofPayment.BackColor = System.Drawing.Color.Transparent
        Me.cmbModeofPayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbModeofPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModeofPayment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbModeofPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbModeofPayment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbModeofPayment.ForeColor = System.Drawing.Color.Black
        Me.cmbModeofPayment.ItemHeight = 30
        Me.cmbModeofPayment.Location = New System.Drawing.Point(21, 432)
        Me.cmbModeofPayment.Name = "cmbModeofPayment"
        Me.cmbModeofPayment.Size = New System.Drawing.Size(215, 36)
        Me.cmbModeofPayment.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 415)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 14)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Mode of Payment"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 14)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Miscellaneous"
        '
        'txtMiscellaneous
        '
        Me.txtMiscellaneous.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiscellaneous.DefaultText = ""
        Me.txtMiscellaneous.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMiscellaneous.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMiscellaneous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiscellaneous.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMiscellaneous.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiscellaneous.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMiscellaneous.ForeColor = System.Drawing.Color.Black
        Me.txtMiscellaneous.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiscellaneous.Location = New System.Drawing.Point(21, 320)
        Me.txtMiscellaneous.Name = "txtMiscellaneous"
        Me.txtMiscellaneous.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiscellaneous.PlaceholderText = ""
        Me.txtMiscellaneous.ReadOnly = True
        Me.txtMiscellaneous.SelectedText = ""
        Me.txtMiscellaneous.Size = New System.Drawing.Size(215, 36)
        Me.txtMiscellaneous.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 14)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Tuition"
        '
        'txtTuition
        '
        Me.txtTuition.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTuition.DefaultText = ""
        Me.txtTuition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTuition.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTuition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTuition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTuition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTuition.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTuition.ForeColor = System.Drawing.Color.Black
        Me.txtTuition.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTuition.Location = New System.Drawing.Point(21, 264)
        Me.txtTuition.Name = "txtTuition"
        Me.txtTuition.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTuition.PlaceholderText = ""
        Me.txtTuition.ReadOnly = True
        Me.txtTuition.SelectedText = ""
        Me.txtTuition.Size = New System.Drawing.Size(215, 36)
        Me.txtTuition.TabIndex = 21
        '
        'LabelCurrentBalance
        '
        Me.LabelCurrentBalance.AutoSize = True
        Me.LabelCurrentBalance.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCurrentBalance.Location = New System.Drawing.Point(517, 444)
        Me.LabelCurrentBalance.Name = "LabelCurrentBalance"
        Me.LabelCurrentBalance.Size = New System.Drawing.Size(138, 27)
        Me.LabelCurrentBalance.TabIndex = 11
        Me.LabelCurrentBalance.Text = " 0,000.00"
        '
        'LabelTotalPayment
        '
        Me.LabelTotalPayment.AutoSize = True
        Me.LabelTotalPayment.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalPayment.Location = New System.Drawing.Point(517, 402)
        Me.LabelTotalPayment.Name = "LabelTotalPayment"
        Me.LabelTotalPayment.Size = New System.Drawing.Size(96, 27)
        Me.LabelTotalPayment.TabIndex = 11
        Me.LabelTotalPayment.Text = " 20200"
        '
        'frmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 591)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvTransactionHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtLRN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGradeLvl As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSection As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbOtherFee As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPayments As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMiscellaneous As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTuition As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbModeofPayment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCurPayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtChanges As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents RbDiscount As RadioButton
    Friend WithEvents RbNoChanges As RadioButton
    Friend WithEvents RbAdditional As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvTransactionHistory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents LabelSY As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgvReceipt As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Addbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LabelCurrentBalance As Label
    Friend WithEvents LabelTotalPayment As Label
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents LabelORNO As Label
    Friend WithEvents LabelEID As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
