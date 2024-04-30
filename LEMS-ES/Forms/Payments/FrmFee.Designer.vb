<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFee
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
        Me.BtnFees = New Guna.UI2.WinForms.Guna2Button()
        Me.LabelSY = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelORNO = New System.Windows.Forms.Label()
        Me.LabelEID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCurrentBalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtCurrentPayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTotalBalance = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTotalPayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotalTuition = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLRN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGradeLvl = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSection = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFees
        '
        Me.BtnFees.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnFees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnFees.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.BtnFees.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFees.ForeColor = System.Drawing.Color.White
        Me.BtnFees.Location = New System.Drawing.Point(23, 553)
        Me.BtnFees.Name = "BtnFees"
        Me.BtnFees.Size = New System.Drawing.Size(215, 36)
        Me.BtnFees.TabIndex = 20
        Me.BtnFees.Text = "Save"
        '
        'LabelSY
        '
        Me.LabelSY.AutoSize = True
        Me.LabelSY.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSY.ForeColor = System.Drawing.Color.Red
        Me.LabelSY.Location = New System.Drawing.Point(158, 29)
        Me.LabelSY.Name = "LabelSY"
        Me.LabelSY.Size = New System.Drawing.Size(80, 16)
        Me.LabelSY.TabIndex = 51
        Me.LabelSY.Text = "0000-0000"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelORNO)
        Me.GroupBox1.Controls.Add(Me.LabelEID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtCurrentBalance)
        Me.GroupBox1.Controls.Add(Me.TxtCurrentPayment)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtTotalBalance)
        Me.GroupBox1.Controls.Add(Me.LabelSY)
        Me.GroupBox1.Controls.Add(Me.BtnFees)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtTotalPayment)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtTotalTuition)
        Me.GroupBox1.Controls.Add(Me.txtLRN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStudName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtGradeLvl)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSection)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 600)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment"
        '
        'LabelORNO
        '
        Me.LabelORNO.AutoSize = True
        Me.LabelORNO.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelORNO.ForeColor = System.Drawing.Color.Red
        Me.LabelORNO.Location = New System.Drawing.Point(63, 65)
        Me.LabelORNO.Name = "LabelORNO"
        Me.LabelORNO.Size = New System.Drawing.Size(175, 21)
        Me.LabelORNO.TabIndex = 57
        Me.LabelORNO.Text = "ORNO00000000000"
        '
        'LabelEID
        '
        Me.LabelEID.AutoSize = True
        Me.LabelEID.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEID.ForeColor = System.Drawing.Color.Red
        Me.LabelEID.Location = New System.Drawing.Point(115, 47)
        Me.LabelEID.Name = "LabelEID"
        Me.LabelEID.Size = New System.Drawing.Size(120, 16)
        Me.LabelEID.TabIndex = 56
        Me.LabelEID.Text = "EID00000000000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 494)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 14)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Current Balance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 434)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 14)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Current Payment"
        '
        'TxtCurrentBalance
        '
        Me.TxtCurrentBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCurrentBalance.DefaultText = ""
        Me.TxtCurrentBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCurrentBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCurrentBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCurrentBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCurrentBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCurrentBalance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtCurrentBalance.ForeColor = System.Drawing.Color.Black
        Me.TxtCurrentBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCurrentBalance.Location = New System.Drawing.Point(23, 511)
        Me.TxtCurrentBalance.Name = "TxtCurrentBalance"
        Me.TxtCurrentBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCurrentBalance.PlaceholderText = ""
        Me.TxtCurrentBalance.ReadOnly = True
        Me.TxtCurrentBalance.SelectedText = ""
        Me.TxtCurrentBalance.Size = New System.Drawing.Size(215, 36)
        Me.TxtCurrentBalance.TabIndex = 54
        '
        'TxtCurrentPayment
        '
        Me.TxtCurrentPayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtCurrentPayment.DefaultText = ""
        Me.TxtCurrentPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtCurrentPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtCurrentPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCurrentPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtCurrentPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCurrentPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtCurrentPayment.ForeColor = System.Drawing.Color.Black
        Me.TxtCurrentPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtCurrentPayment.Location = New System.Drawing.Point(23, 451)
        Me.TxtCurrentPayment.Name = "TxtCurrentPayment"
        Me.TxtCurrentPayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtCurrentPayment.PlaceholderText = ""
        Me.TxtCurrentPayment.SelectedText = ""
        Me.TxtCurrentPayment.Size = New System.Drawing.Size(215, 36)
        Me.TxtCurrentPayment.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 14)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Total Balance"
        '
        'TxtTotalBalance
        '
        Me.TxtTotalBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTotalBalance.DefaultText = ""
        Me.TxtTotalBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTotalBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTotalBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotalBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotalBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotalBalance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTotalBalance.ForeColor = System.Drawing.Color.Black
        Me.TxtTotalBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotalBalance.Location = New System.Drawing.Point(23, 391)
        Me.TxtTotalBalance.Name = "TxtTotalBalance"
        Me.TxtTotalBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTotalBalance.PlaceholderText = ""
        Me.TxtTotalBalance.ReadOnly = True
        Me.TxtTotalBalance.SelectedText = ""
        Me.TxtTotalBalance.Size = New System.Drawing.Size(215, 36)
        Me.TxtTotalBalance.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 316)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 14)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Total Payment"
        '
        'TxtTotalPayment
        '
        Me.TxtTotalPayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTotalPayment.DefaultText = ""
        Me.TxtTotalPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTotalPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTotalPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotalPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotalPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotalPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTotalPayment.ForeColor = System.Drawing.Color.Black
        Me.TxtTotalPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotalPayment.Location = New System.Drawing.Point(23, 333)
        Me.TxtTotalPayment.Name = "TxtTotalPayment"
        Me.TxtTotalPayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTotalPayment.PlaceholderText = ""
        Me.TxtTotalPayment.ReadOnly = True
        Me.TxtTotalPayment.SelectedText = ""
        Me.TxtTotalPayment.Size = New System.Drawing.Size(215, 36)
        Me.TxtTotalPayment.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 14)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Total Tuition"
        '
        'TxtTotalTuition
        '
        Me.TxtTotalTuition.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtTotalTuition.DefaultText = ""
        Me.TxtTotalTuition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtTotalTuition.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtTotalTuition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotalTuition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtTotalTuition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotalTuition.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtTotalTuition.ForeColor = System.Drawing.Color.Black
        Me.TxtTotalTuition.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotalTuition.Location = New System.Drawing.Point(23, 277)
        Me.TxtTotalTuition.Name = "TxtTotalTuition"
        Me.TxtTotalTuition.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtTotalTuition.PlaceholderText = ""
        Me.TxtTotalTuition.ReadOnly = True
        Me.TxtTotalTuition.SelectedText = ""
        Me.TxtTotalTuition.Size = New System.Drawing.Size(215, 36)
        Me.TxtTotalTuition.TabIndex = 21
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
        Me.txtLRN.Location = New System.Drawing.Point(23, 109)
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
        Me.Label1.Location = New System.Drawing.Point(20, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LRN"
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
        Me.txtStudName.Location = New System.Drawing.Point(23, 165)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudName.PlaceholderText = ""
        Me.txtStudName.ReadOnly = True
        Me.txtStudName.SelectedText = ""
        Me.txtStudName.Size = New System.Drawing.Size(215, 36)
        Me.txtStudName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Student Name"
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
        Me.txtGradeLvl.Location = New System.Drawing.Point(23, 221)
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
        Me.Label4.Location = New System.Drawing.Point(131, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Section"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Grade Level"
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
        Me.txtSection.Location = New System.Drawing.Point(131, 221)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSection.PlaceholderText = ""
        Me.txtSection.ReadOnly = True
        Me.txtSection.SelectedText = ""
        Me.txtSection.Size = New System.Drawing.Size(107, 36)
        Me.txtSection.TabIndex = 6
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.LEMS_ES.My.Resources.Resources.delete
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'FrmFee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 600)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmFee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents BtnFees As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LabelSY As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCurrentBalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtCurrentPayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTotalBalance As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTotalPayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotalTuition As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLRN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGradeLvl As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSection As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LabelORNO As Label
    Friend WithEvents LabelEID As Label
End Class
