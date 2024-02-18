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
        Me.GBEnrollmentForm = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtGuardianContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFatherContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMotherContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGuardianOccup = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMotherOccup = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFatherOccup = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGuardianName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMothersName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCitizenship = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtReligion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSuffix = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpBday = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cbFemale = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.cbMale = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2TextBox12 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStudentContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFathersName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLRN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPlaceofBirth = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMiddlename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GBEnrollmentForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBEnrollmentForm
        '
        Me.GBEnrollmentForm.Controls.Add(Me.GroupBox1)
        Me.GBEnrollmentForm.CustomBorderColor = System.Drawing.Color.Gray
        Me.GBEnrollmentForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBEnrollmentForm.Font = New System.Drawing.Font("Georgia", 24.0!)
        Me.GBEnrollmentForm.ForeColor = System.Drawing.Color.White
        Me.GBEnrollmentForm.Location = New System.Drawing.Point(0, 0)
        Me.GBEnrollmentForm.Name = "GBEnrollmentForm"
        Me.GBEnrollmentForm.Size = New System.Drawing.Size(811, 504)
        Me.GBEnrollmentForm.TabIndex = 1
        Me.GBEnrollmentForm.Text = "Student Registration"
        Me.GBEnrollmentForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Guna2TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtGuardianContact)
        Me.GroupBox1.Controls.Add(Me.txtFatherContact)
        Me.GroupBox1.Controls.Add(Me.txtMotherContact)
        Me.GroupBox1.Controls.Add(Me.txtGuardianOccup)
        Me.GroupBox1.Controls.Add(Me.txtMotherOccup)
        Me.GroupBox1.Controls.Add(Me.txtFatherOccup)
        Me.GroupBox1.Controls.Add(Me.txtGuardianName)
        Me.GroupBox1.Controls.Add(Me.txtMothersName)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtEmailAddress)
        Me.GroupBox1.Controls.Add(Me.txtCitizenship)
        Me.GroupBox1.Controls.Add(Me.txtReligion)
        Me.GroupBox1.Controls.Add(Me.txtSuffix)
        Me.GroupBox1.Controls.Add(Me.dtpBday)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbFemale)
        Me.GroupBox1.Controls.Add(Me.cbMale)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Guna2TextBox12)
        Me.GroupBox1.Controls.Add(Me.txtStudentContact)
        Me.GroupBox1.Controls.Add(Me.txtFathersName)
        Me.GroupBox1.Controls.Add(Me.txtLRN)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtPlaceofBirth)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtMiddlename)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 464)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'btnClear
        '
        Me.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClear.FillColor = System.Drawing.Color.Gray
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(706, 416)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 36)
        Me.btnClear.TabIndex = 60
        Me.btnClear.Text = "Clear"
        '
        'btnSave
        '
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(609, 416)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 36)
        Me.btnSave.TabIndex = 59
        Me.btnSave.Text = "Save"
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
        Me.txtGuardianContact.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianContact.ForeColor = System.Drawing.Color.Black
        Me.txtGuardianContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianContact.Location = New System.Drawing.Point(597, 297)
        Me.txtGuardianContact.Name = "txtGuardianContact"
        Me.txtGuardianContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianContact.PlaceholderText = "Contact No."
        Me.txtGuardianContact.SelectedText = ""
        Me.txtGuardianContact.Size = New System.Drawing.Size(200, 36)
        Me.txtGuardianContact.TabIndex = 58
        '
        'txtFatherContact
        '
        Me.txtFatherContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFatherContact.DefaultText = ""
        Me.txtFatherContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFatherContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFatherContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherContact.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherContact.ForeColor = System.Drawing.Color.Black
        Me.txtFatherContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherContact.Location = New System.Drawing.Point(597, 255)
        Me.txtFatherContact.Name = "txtFatherContact"
        Me.txtFatherContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFatherContact.PlaceholderText = "Contact No."
        Me.txtFatherContact.SelectedText = ""
        Me.txtFatherContact.Size = New System.Drawing.Size(200, 36)
        Me.txtFatherContact.TabIndex = 57
        '
        'txtMotherContact
        '
        Me.txtMotherContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMotherContact.DefaultText = ""
        Me.txtMotherContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMotherContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMotherContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherContact.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotherContact.ForeColor = System.Drawing.Color.Black
        Me.txtMotherContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherContact.Location = New System.Drawing.Point(597, 213)
        Me.txtMotherContact.Name = "txtMotherContact"
        Me.txtMotherContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotherContact.PlaceholderText = "Contact No."
        Me.txtMotherContact.SelectedText = ""
        Me.txtMotherContact.Size = New System.Drawing.Size(200, 36)
        Me.txtMotherContact.TabIndex = 56
        '
        'txtGuardianOccup
        '
        Me.txtGuardianOccup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuardianOccup.DefaultText = ""
        Me.txtGuardianOccup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuardianOccup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuardianOccup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianOccup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuardianOccup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianOccup.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianOccup.ForeColor = System.Drawing.Color.Black
        Me.txtGuardianOccup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianOccup.Location = New System.Drawing.Point(391, 297)
        Me.txtGuardianOccup.Name = "txtGuardianOccup"
        Me.txtGuardianOccup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianOccup.PlaceholderText = "Guardian Occupation"
        Me.txtGuardianOccup.SelectedText = ""
        Me.txtGuardianOccup.Size = New System.Drawing.Size(200, 36)
        Me.txtGuardianOccup.TabIndex = 55
        '
        'txtMotherOccup
        '
        Me.txtMotherOccup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMotherOccup.DefaultText = ""
        Me.txtMotherOccup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMotherOccup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMotherOccup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherOccup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMotherOccup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherOccup.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotherOccup.ForeColor = System.Drawing.Color.Black
        Me.txtMotherOccup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMotherOccup.Location = New System.Drawing.Point(391, 213)
        Me.txtMotherOccup.Name = "txtMotherOccup"
        Me.txtMotherOccup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMotherOccup.PlaceholderText = "Mother's Occupation"
        Me.txtMotherOccup.SelectedText = ""
        Me.txtMotherOccup.Size = New System.Drawing.Size(200, 36)
        Me.txtMotherOccup.TabIndex = 54
        '
        'txtFatherOccup
        '
        Me.txtFatherOccup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFatherOccup.DefaultText = ""
        Me.txtFatherOccup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFatherOccup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFatherOccup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherOccup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFatherOccup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherOccup.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatherOccup.ForeColor = System.Drawing.Color.Black
        Me.txtFatherOccup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFatherOccup.Location = New System.Drawing.Point(391, 255)
        Me.txtFatherOccup.Name = "txtFatherOccup"
        Me.txtFatherOccup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFatherOccup.PlaceholderText = "Father's Occupation"
        Me.txtFatherOccup.SelectedText = ""
        Me.txtFatherOccup.Size = New System.Drawing.Size(200, 36)
        Me.txtFatherOccup.TabIndex = 53
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
        Me.txtGuardianName.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuardianName.ForeColor = System.Drawing.Color.Black
        Me.txtGuardianName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuardianName.Location = New System.Drawing.Point(112, 297)
        Me.txtGuardianName.Name = "txtGuardianName"
        Me.txtGuardianName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuardianName.PlaceholderText = "Guardian Name"
        Me.txtGuardianName.SelectedText = ""
        Me.txtGuardianName.Size = New System.Drawing.Size(273, 36)
        Me.txtGuardianName.TabIndex = 52
        '
        'txtMothersName
        '
        Me.txtMothersName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMothersName.DefaultText = ""
        Me.txtMothersName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMothersName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMothersName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMothersName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMothersName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMothersName.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMothersName.ForeColor = System.Drawing.Color.Black
        Me.txtMothersName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMothersName.Location = New System.Drawing.Point(112, 213)
        Me.txtMothersName.Name = "txtMothersName"
        Me.txtMothersName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMothersName.PlaceholderText = "Mother's Name"
        Me.txtMothersName.SelectedText = ""
        Me.txtMothersName.Size = New System.Drawing.Size(273, 36)
        Me.txtMothersName.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(16, 190)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 18)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Guardian Info:"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailAddress.DefaultText = ""
        Me.txtEmailAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAddress.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.ForeColor = System.Drawing.Color.Black
        Me.txtEmailAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAddress.Location = New System.Drawing.Point(231, 151)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailAddress.PlaceholderText = "Email Address"
        Me.txtEmailAddress.SelectedText = ""
        Me.txtEmailAddress.Size = New System.Drawing.Size(239, 36)
        Me.txtEmailAddress.TabIndex = 47
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
        Me.txtCitizenship.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCitizenship.ForeColor = System.Drawing.Color.Black
        Me.txtCitizenship.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCitizenship.Location = New System.Drawing.Point(12, 151)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCitizenship.PlaceholderText = "Citizenship"
        Me.txtCitizenship.SelectedText = ""
        Me.txtCitizenship.Size = New System.Drawing.Size(191, 36)
        Me.txtCitizenship.TabIndex = 45
        '
        'txtReligion
        '
        Me.txtReligion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReligion.DefaultText = ""
        Me.txtReligion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReligion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReligion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReligion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReligion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReligion.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReligion.ForeColor = System.Drawing.Color.Black
        Me.txtReligion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReligion.Location = New System.Drawing.Point(172, 109)
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReligion.PlaceholderText = "Religion"
        Me.txtReligion.SelectedText = ""
        Me.txtReligion.Size = New System.Drawing.Size(153, 36)
        Me.txtReligion.TabIndex = 41
        '
        'txtSuffix
        '
        Me.txtSuffix.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSuffix.DefaultText = ""
        Me.txtSuffix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSuffix.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSuffix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSuffix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSuffix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSuffix.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuffix.ForeColor = System.Drawing.Color.Black
        Me.txtSuffix.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSuffix.Location = New System.Drawing.Point(734, 67)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSuffix.PlaceholderText = "Suffix"
        Me.txtSuffix.SelectedText = ""
        Me.txtSuffix.Size = New System.Drawing.Size(63, 36)
        Me.txtSuffix.TabIndex = 37
        '
        'dtpBday
        '
        Me.dtpBday.Checked = True
        Me.dtpBday.FillColor = System.Drawing.Color.Transparent
        Me.dtpBday.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBday.ForeColor = System.Drawing.Color.Black
        Me.dtpBday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBday.Location = New System.Drawing.Point(453, 25)
        Me.dtpBday.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpBday.MinDate = New Date(2005, 12, 31, 0, 0, 0, 0)
        Me.dtpBday.Name = "dtpBday"
        Me.dtpBday.Size = New System.Drawing.Size(125, 36)
        Me.dtpBday.TabIndex = 35
        Me.dtpBday.Value = New Date(2020, 12, 31, 0, 0, 0, 0)
        '
        'cbFemale
        '
        Me.cbFemale.BackColor = System.Drawing.Color.Transparent
        Me.cbFemale.CheckedState.Image = Global.LEMS_ES.My.Resources.Resources.check_box
        Me.cbFemale.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.cbFemale.HoverState.Image = Global.LEMS_ES.My.Resources.Resources.woman
        Me.cbFemale.Image = Global.LEMS_ES.My.Resources.Resources.female
        Me.cbFemale.ImageOffset = New System.Drawing.Point(0, 0)
        Me.cbFemale.ImageRotate = 0!
        Me.cbFemale.ImageSize = New System.Drawing.Size(30, 30)
        Me.cbFemale.Location = New System.Drawing.Point(130, 109)
        Me.cbFemale.Name = "cbFemale"
        Me.cbFemale.Size = New System.Drawing.Size(36, 36)
        Me.cbFemale.TabIndex = 29
        '
        'cbMale
        '
        Me.cbMale.BackColor = System.Drawing.Color.Transparent
        Me.cbMale.CheckedState.Image = Global.LEMS_ES.My.Resources.Resources.check_box
        Me.cbMale.CheckedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.cbMale.HoverState.Image = Global.LEMS_ES.My.Resources.Resources.masculine_user
        Me.cbMale.Image = Global.LEMS_ES.My.Resources.Resources.male
        Me.cbMale.ImageOffset = New System.Drawing.Point(0, 0)
        Me.cbMale.ImageRotate = 0!
        Me.cbMale.ImageSize = New System.Drawing.Size(30, 30)
        Me.cbMale.Location = New System.Drawing.Point(88, 109)
        Me.cbMale.Name = "cbMale"
        Me.cbMale.Size = New System.Drawing.Size(36, 36)
        Me.cbMale.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Gender:"
        '
        'Guna2TextBox12
        '
        Me.Guna2TextBox12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox12.DefaultText = ""
        Me.Guna2TextBox12.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox12.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox12.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox12.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox12.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox12.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox12.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox12.Location = New System.Drawing.Point(112, 363)
        Me.Guna2TextBox12.Name = "Guna2TextBox12"
        Me.Guna2TextBox12.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox12.PlaceholderText = "Name of the School"
        Me.Guna2TextBox12.SelectedText = ""
        Me.Guna2TextBox12.Size = New System.Drawing.Size(375, 36)
        Me.Guna2TextBox12.TabIndex = 13
        '
        'txtStudentContact
        '
        Me.txtStudentContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentContact.DefaultText = ""
        Me.txtStudentContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentContact.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentContact.ForeColor = System.Drawing.Color.Black
        Me.txtStudentContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentContact.Location = New System.Drawing.Point(331, 109)
        Me.txtStudentContact.Name = "txtStudentContact"
        Me.txtStudentContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentContact.PlaceholderText = "Tel/Mobile No."
        Me.txtStudentContact.SelectedText = ""
        Me.txtStudentContact.Size = New System.Drawing.Size(139, 36)
        Me.txtStudentContact.TabIndex = 10
        '
        'txtFathersName
        '
        Me.txtFathersName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFathersName.DefaultText = ""
        Me.txtFathersName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFathersName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFathersName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFathersName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFathersName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFathersName.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFathersName.ForeColor = System.Drawing.Color.Black
        Me.txtFathersName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFathersName.Location = New System.Drawing.Point(112, 255)
        Me.txtFathersName.Name = "txtFathersName"
        Me.txtFathersName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFathersName.PlaceholderText = "Father's Name"
        Me.txtFathersName.SelectedText = ""
        Me.txtFathersName.Size = New System.Drawing.Size(273, 36)
        Me.txtFathersName.TabIndex = 9
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
        Me.txtLRN.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLRN.ForeColor = System.Drawing.Color.Black
        Me.txtLRN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLRN.Location = New System.Drawing.Point(12, 25)
        Me.txtLRN.Name = "txtLRN"
        Me.txtLRN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLRN.PlaceholderText = "LRN"
        Me.txtLRN.SelectedText = ""
        Me.txtLRN.Size = New System.Drawing.Size(259, 36)
        Me.txtLRN.TabIndex = 8
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
        Me.txtAddress.Location = New System.Drawing.Point(476, 109)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = "Address"
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.Size = New System.Drawing.Size(321, 78)
        Me.txtAddress.TabIndex = 7
        '
        'txtPlaceofBirth
        '
        Me.txtPlaceofBirth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPlaceofBirth.DefaultText = ""
        Me.txtPlaceofBirth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPlaceofBirth.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPlaceofBirth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPlaceofBirth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPlaceofBirth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPlaceofBirth.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaceofBirth.ForeColor = System.Drawing.Color.Black
        Me.txtPlaceofBirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPlaceofBirth.Location = New System.Drawing.Point(584, 25)
        Me.txtPlaceofBirth.Name = "txtPlaceofBirth"
        Me.txtPlaceofBirth.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPlaceofBirth.PlaceholderText = "Place of Birth"
        Me.txtPlaceofBirth.SelectedText = ""
        Me.txtPlaceofBirth.Size = New System.Drawing.Size(213, 36)
        Me.txtPlaceofBirth.TabIndex = 5
        '
        'txtAge
        '
        Me.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAge.DefaultText = ""
        Me.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.Location = New System.Drawing.Point(277, 25)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAge.PlaceholderText = "Age"
        Me.txtAge.SelectedText = ""
        Me.txtAge.Size = New System.Drawing.Size(89, 36)
        Me.txtAge.TabIndex = 4
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
        Me.txtMiddlename.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.ForeColor = System.Drawing.Color.Black
        Me.txtMiddlename.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMiddlename.Location = New System.Drawing.Point(528, 67)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddlename.PlaceholderText = "Middle Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtMiddlename.SelectedText = ""
        Me.txtMiddlename.Size = New System.Drawing.Size(200, 36)
        Me.txtMiddlename.TabIndex = 3
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
        Me.txtFirstname.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.ForeColor = System.Drawing.Color.Black
        Me.txtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstname.Location = New System.Drawing.Point(263, 67)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.PlaceholderText = "First Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.Size = New System.Drawing.Size(259, 36)
        Me.txtFirstname.TabIndex = 2
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
        Me.txtLastname.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.ForeColor = System.Drawing.Color.Black
        Me.txtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastname.Location = New System.Drawing.Point(12, 67)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.PlaceholderText = "Last Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtLastname.SelectedText = ""
        Me.txtLastname.Size = New System.Drawing.Size(245, 36)
        Me.txtLastname.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(372, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Birthday:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 18)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Previous School Attended:"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(493, 363)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Address of the School"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(304, 36)
        Me.Guna2TextBox1.TabIndex = 62
        '
        'frmStudentRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 504)
        Me.Controls.Add(Me.GBEnrollmentForm)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudentRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GBEnrollmentForm.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBEnrollmentForm As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtGuardianContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFatherContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMotherContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGuardianOccup As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMotherOccup As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFatherOccup As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGuardianName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMothersName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEmailAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCitizenship As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtReligion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSuffix As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpBday As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cbFemale As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents cbMale As Guna.UI2.WinForms.Guna2ImageCheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TextBox12 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStudentContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFathersName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLRN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPlaceofBirth As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMiddlename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
End Class
