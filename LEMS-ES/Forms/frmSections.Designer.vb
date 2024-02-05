<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSections
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvSection = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSubjName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdateSubject = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearSubject = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSaveSubject = New Guna.UI2.WinForms.Guna2Button()
        Me.txtSubjCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.dgvSection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.dgvSection)
        Me.Guna2GroupBox1.Controls.Add(Me.Panel1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.DimGray
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(953, 565)
        Me.Guna2GroupBox1.TabIndex = 1
        Me.Guna2GroupBox1.Text = "SECTIONS"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvSection
        '
        Me.dgvSection.AllowUserToAddRows = False
        Me.dgvSection.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvSection.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSection.BackgroundColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSection.ColumnHeadersHeight = 44
        Me.dgvSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSection.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSection.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSection.Location = New System.Drawing.Point(230, 40)
        Me.dgvSection.Name = "dgvSection"
        Me.dgvSection.ReadOnly = True
        Me.dgvSection.RowHeadersVisible = False
        Me.dgvSection.Size = New System.Drawing.Size(723, 525)
        Me.dgvSection.TabIndex = 2
        Me.dgvSection.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSection.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvSection.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvSection.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvSection.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvSection.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.dgvSection.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSection.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSection.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSection.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSection.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSection.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSection.ThemeStyle.HeaderStyle.Height = 44
        Me.dgvSection.ThemeStyle.ReadOnly = True
        Me.dgvSection.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSection.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSection.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSection.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSection.ThemeStyle.RowsStyle.Height = 22
        Me.dgvSection.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSection.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSubjName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnUpdateSubject)
        Me.Panel1.Controls.Add(Me.btnClearSubject)
        Me.Panel1.Controls.Add(Me.btnSaveSubject)
        Me.Panel1.Controls.Add(Me.txtSubjCode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 525)
        Me.Panel1.TabIndex = 4
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
        Me.txtSubjName.Location = New System.Drawing.Point(3, 95)
        Me.txtSubjName.Name = "txtSubjName"
        Me.txtSubjName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubjName.PlaceholderText = ""
        Me.txtSubjName.SelectedText = ""
        Me.txtSubjName.Size = New System.Drawing.Size(221, 36)
        Me.txtSubjName.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 14)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Capacity"
        '
        'btnUpdateSubject
        '
        Me.btnUpdateSubject.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateSubject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateSubject.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSubject.ForeColor = System.Drawing.Color.White
        Me.btnUpdateSubject.Location = New System.Drawing.Point(114, 137)
        Me.btnUpdateSubject.Name = "btnUpdateSubject"
        Me.btnUpdateSubject.Size = New System.Drawing.Size(91, 36)
        Me.btnUpdateSubject.TabIndex = 10
        Me.btnUpdateSubject.Text = "Update"
        '
        'btnClearSubject
        '
        Me.btnClearSubject.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearSubject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClearSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClearSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClearSubject.FillColor = System.Drawing.Color.Gray
        Me.btnClearSubject.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSubject.ForeColor = System.Drawing.Color.White
        Me.btnClearSubject.Location = New System.Drawing.Point(66, 179)
        Me.btnClearSubject.Name = "btnClearSubject"
        Me.btnClearSubject.Size = New System.Drawing.Size(91, 36)
        Me.btnClearSubject.TabIndex = 9
        Me.btnClearSubject.Text = "Clear"
        '
        'btnSaveSubject
        '
        Me.btnSaveSubject.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveSubject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSaveSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSaveSubject.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSubject.ForeColor = System.Drawing.Color.White
        Me.btnSaveSubject.Location = New System.Drawing.Point(17, 137)
        Me.btnSaveSubject.Name = "btnSaveSubject"
        Me.btnSaveSubject.Size = New System.Drawing.Size(91, 36)
        Me.btnSaveSubject.TabIndex = 8
        Me.btnSaveSubject.Text = "Save"
        '
        'txtSubjCode
        '
        Me.txtSubjCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubjCode.DefaultText = ""
        Me.txtSubjCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubjCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubjCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubjCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubjCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubjCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSubjCode.ForeColor = System.Drawing.Color.Black
        Me.txtSubjCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubjCode.Location = New System.Drawing.Point(3, 36)
        Me.txtSubjCode.Name = "txtSubjCode"
        Me.txtSubjCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubjCode.PlaceholderText = ""
        Me.txtSubjCode.SelectedText = ""
        Me.txtSubjCode.Size = New System.Drawing.Size(221, 36)
        Me.txtSubjCode.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Section Name"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "SectionRoom"
        Me.Column2.HeaderText = "Section Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.DataPropertyName = "Capacity"
        Me.Column3.HeaderText = "Capacity"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 115
        '
        'frmSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 565)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.dgvSection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvSection As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSubjName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpdateSubject As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClearSubject As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSaveSubject As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSubjCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
