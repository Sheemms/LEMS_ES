<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStudents
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.AddNew = New System.Windows.Forms.ToolStripButton()
        Me.TextSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.dgvStudents = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLRN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuffix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMother = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMothersMaiden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMotherOcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFather = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFatherOcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGuardianName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGuardianContact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCitizenship = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStudType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNew, Me.TextSearch, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(953, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'AddNew
        '
        Me.AddNew.Image = Global.LEMS_ES.My.Resources.Resources.new_document
        Me.AddNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(51, 22)
        Me.AddNew.Text = "New"
        '
        'TextSearch
        '
        Me.TextSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TextSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.LEMS_ES.My.Resources.Resources.search
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.LEMS_ES.My.Resources.Resources.printer
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "Print"
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvStudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudents.ColumnHeadersHeight = 44
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colLRN, Me.colStudName, Me.colSuffix, Me.colGender, Me.colAge, Me.colBday, Me.colAddress, Me.colMother, Me.colMothersMaiden, Me.colMotherOcc, Me.colFather, Me.colFatherOcc, Me.colGuardianName, Me.colGuardianContact, Me.colCitizenship, Me.Column15, Me.colStudType})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudents.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStudents.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudents.Location = New System.Drawing.Point(0, 25)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersVisible = False
        Me.dgvStudents.Size = New System.Drawing.Size(953, 566)
        Me.dgvStudents.TabIndex = 1
        Me.dgvStudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStudents.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvStudents.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.dgvStudents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStudents.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvStudents.ThemeStyle.HeaderStyle.Height = 44
        Me.dgvStudents.ThemeStyle.ReadOnly = True
        Me.dgvStudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStudents.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvStudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvStudents.ThemeStyle.RowsStyle.Height = 22
        Me.dgvStudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'colLRN
        '
        Me.colLRN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLRN.DataPropertyName = "LRN"
        Me.colLRN.HeaderText = "LRN"
        Me.colLRN.Name = "colLRN"
        Me.colLRN.ReadOnly = True
        Me.colLRN.Width = 54
        '
        'colStudName
        '
        Me.colStudName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStudName.DataPropertyName = "Fullname"
        Me.colStudName.HeaderText = "Student Name"
        Me.colStudName.Name = "colStudName"
        Me.colStudName.ReadOnly = True
        '
        'colSuffix
        '
        Me.colSuffix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSuffix.DataPropertyName = "Suffix"
        Me.colSuffix.HeaderText = "Suffix"
        Me.colSuffix.Name = "colSuffix"
        Me.colSuffix.ReadOnly = True
        Me.colSuffix.Width = 64
        '
        'colGender
        '
        Me.colGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colGender.DataPropertyName = "Gender"
        Me.colGender.HeaderText = "Gender"
        Me.colGender.Name = "colGender"
        Me.colGender.ReadOnly = True
        Me.colGender.Width = 72
        '
        'colAge
        '
        Me.colAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAge.DataPropertyName = "Age"
        Me.colAge.HeaderText = "Age"
        Me.colAge.Name = "colAge"
        Me.colAge.ReadOnly = True
        Me.colAge.Visible = False
        Me.colAge.Width = 52
        '
        'colBday
        '
        Me.colBday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colBday.DataPropertyName = "Birthday"
        Me.colBday.HeaderText = "Date of Birth"
        Me.colBday.Name = "colBday"
        Me.colBday.ReadOnly = True
        Me.colBday.Visible = False
        Me.colBday.Width = 67
        '
        'colAddress
        '
        Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAddress.DataPropertyName = "Address"
        Me.colAddress.HeaderText = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Visible = False
        Me.colAddress.Width = 75
        '
        'colMother
        '
        Me.colMother.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMother.DataPropertyName = "MotherName"
        Me.colMother.HeaderText = "Mother Name"
        Me.colMother.Name = "colMother"
        Me.colMother.ReadOnly = True
        Me.colMother.Visible = False
        Me.colMother.Width = 99
        '
        'colMothersMaiden
        '
        Me.colMothersMaiden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMothersMaiden.DataPropertyName = "MothersMaiden"
        Me.colMothersMaiden.HeaderText = "Mother's Maiden"
        Me.colMothersMaiden.Name = "colMothersMaiden"
        Me.colMothersMaiden.ReadOnly = True
        Me.colMothersMaiden.Visible = False
        Me.colMothersMaiden.Width = 112
        '
        'colMotherOcc
        '
        Me.colMotherOcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMotherOcc.DataPropertyName = "Mother_Occupation"
        Me.colMotherOcc.HeaderText = "Mother Occupation"
        Me.colMotherOcc.Name = "colMotherOcc"
        Me.colMotherOcc.ReadOnly = True
        Me.colMotherOcc.Visible = False
        Me.colMotherOcc.Width = 128
        '
        'colFather
        '
        Me.colFather.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colFather.DataPropertyName = "FatherName"
        Me.colFather.HeaderText = "Father Name"
        Me.colFather.Name = "colFather"
        Me.colFather.ReadOnly = True
        Me.colFather.Visible = False
        Me.colFather.Width = 97
        '
        'colFatherOcc
        '
        Me.colFatherOcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colFatherOcc.DataPropertyName = "Father_Occupation"
        Me.colFatherOcc.HeaderText = "Father's Occupation"
        Me.colFatherOcc.Name = "colFatherOcc"
        Me.colFatherOcc.ReadOnly = True
        Me.colFatherOcc.Visible = False
        Me.colFatherOcc.Width = 132
        '
        'colGuardianName
        '
        Me.colGuardianName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colGuardianName.DataPropertyName = "GuardianName"
        Me.colGuardianName.HeaderText = "Guardian Name"
        Me.colGuardianName.Name = "colGuardianName"
        Me.colGuardianName.ReadOnly = True
        Me.colGuardianName.Visible = False
        Me.colGuardianName.Width = 112
        '
        'colGuardianContact
        '
        Me.colGuardianContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colGuardianContact.DataPropertyName = "GuardianContact"
        Me.colGuardianContact.HeaderText = "Guardian Contact"
        Me.colGuardianContact.Name = "colGuardianContact"
        Me.colGuardianContact.ReadOnly = True
        Me.colGuardianContact.Visible = False
        Me.colGuardianContact.Width = 122
        '
        'colCitizenship
        '
        Me.colCitizenship.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCitizenship.DataPropertyName = "Citizenship"
        Me.colCitizenship.HeaderText = "Citizenship"
        Me.colCitizenship.Name = "colCitizenship"
        Me.colCitizenship.ReadOnly = True
        Me.colCitizenship.Visible = False
        Me.colCitizenship.Width = 94
        '
        'Column15
        '
        Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column15.DataPropertyName = "Status"
        Me.Column15.HeaderText = "Status"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Visible = False
        Me.Column15.Width = 67
        '
        'colStudType
        '
        Me.colStudType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStudType.DataPropertyName = "StudType"
        Me.colStudType.HeaderText = "Student Type"
        Me.colStudType.Name = "colStudType"
        Me.colStudType.ReadOnly = True
        Me.colStudType.Visible = False
        Me.colStudType.Width = 99
        '
        'FrmStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 591)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents AddNew As ToolStripButton
    Friend WithEvents dgvStudents As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colLRN As DataGridViewTextBoxColumn
    Friend WithEvents colStudName As DataGridViewTextBoxColumn
    Friend WithEvents colSuffix As DataGridViewTextBoxColumn
    Friend WithEvents colGender As DataGridViewTextBoxColumn
    Friend WithEvents colAge As DataGridViewTextBoxColumn
    Friend WithEvents colBday As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colMother As DataGridViewTextBoxColumn
    Friend WithEvents colMothersMaiden As DataGridViewTextBoxColumn
    Friend WithEvents colMotherOcc As DataGridViewTextBoxColumn
    Friend WithEvents colFather As DataGridViewTextBoxColumn
    Friend WithEvents colFatherOcc As DataGridViewTextBoxColumn
    Friend WithEvents colGuardianName As DataGridViewTextBoxColumn
    Friend WithEvents colGuardianContact As DataGridViewTextBoxColumn
    Friend WithEvents colCitizenship As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents colStudType As DataGridViewTextBoxColumn
    Friend WithEvents TextSearch As ToolStripTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
