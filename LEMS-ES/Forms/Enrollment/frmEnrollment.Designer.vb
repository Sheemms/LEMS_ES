﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEnrollment
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
        Me.GBEnrollmentForm = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvEnrolled = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSearch = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLRN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGradeLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEnrollDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrint = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDrop = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GBEnrollmentForm.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvEnrolled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBEnrollmentForm
        '
        Me.GBEnrollmentForm.Controls.Add(Me.Panel2)
        Me.GBEnrollmentForm.CustomBorderColor = System.Drawing.Color.Gray
        Me.GBEnrollmentForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBEnrollmentForm.Font = New System.Drawing.Font("Bahnschrift", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEnrollmentForm.ForeColor = System.Drawing.Color.White
        Me.GBEnrollmentForm.Location = New System.Drawing.Point(0, 0)
        Me.GBEnrollmentForm.Name = "GBEnrollmentForm"
        Me.GBEnrollmentForm.Size = New System.Drawing.Size(953, 615)
        Me.GBEnrollmentForm.TabIndex = 0
        Me.GBEnrollmentForm.Text = "Enrollment"
        Me.GBEnrollmentForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvEnrolled)
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(953, 575)
        Me.Panel2.TabIndex = 5
        '
        'dgvEnrolled
        '
        Me.dgvEnrolled.AllowUserToAddRows = False
        Me.dgvEnrolled.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvEnrolled.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEnrolled.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvEnrolled.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvEnrolled.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEnrolled.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEnrolled.ColumnHeadersHeight = 44
        Me.dgvEnrolled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvEnrolled.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colSY, Me.Column1, Me.colLRN, Me.colFullname, Me.colGradeLevel, Me.colSection, Me.Column2, Me.colEnrollDate, Me.colStatus, Me.colPrint, Me.colDrop})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEnrolled.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEnrolled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEnrolled.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEnrolled.Location = New System.Drawing.Point(0, 25)
        Me.dgvEnrolled.MultiSelect = False
        Me.dgvEnrolled.Name = "dgvEnrolled"
        Me.dgvEnrolled.ReadOnly = True
        Me.dgvEnrolled.RowHeadersVisible = False
        Me.dgvEnrolled.Size = New System.Drawing.Size(953, 550)
        Me.dgvEnrolled.TabIndex = 2
        Me.dgvEnrolled.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEnrolled.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvEnrolled.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvEnrolled.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvEnrolled.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvEnrolled.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.dgvEnrolled.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEnrolled.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvEnrolled.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgvEnrolled.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEnrolled.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvEnrolled.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvEnrolled.ThemeStyle.HeaderStyle.Height = 44
        Me.dgvEnrolled.ThemeStyle.ReadOnly = True
        Me.dgvEnrolled.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvEnrolled.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgvEnrolled.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvEnrolled.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvEnrolled.ThemeStyle.RowsStyle.Height = 22
        Me.dgvEnrolled.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEnrolled.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.txtSearch, Me.ToolStripSeparator1, Me.BtnSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(953, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Image = Global.LEMS_ES.My.Resources.Resources.add
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripButton1.Text = "New"
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(172, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnSearch
        '
        Me.BtnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSearch.Image = Global.LEMS_ES.My.Resources.Resources.search
        Me.BtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(23, 22)
        Me.BtnSearch.Text = "Search"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.LEMS_ES.My.Resources.Resources.printer
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.LEMS_ES.My.Resources.Resources.drop
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 210
        '
        'colID
        '
        Me.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 42
        '
        'colSY
        '
        Me.colSY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSY.DataPropertyName = "SchoolYear"
        Me.colSY.HeaderText = "SchoolYear"
        Me.colSY.Name = "colSY"
        Me.colSY.ReadOnly = True
        Me.colSY.Width = 88
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.DataPropertyName = "EID"
        Me.Column1.HeaderText = "EID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 49
        '
        'colLRN
        '
        Me.colLRN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLRN.DataPropertyName = "LRN"
        Me.colLRN.HeaderText = "LRN"
        Me.colLRN.Name = "colLRN"
        Me.colLRN.ReadOnly = True
        Me.colLRN.Width = 53
        '
        'colFullname
        '
        Me.colFullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFullname.DataPropertyName = "Fullname"
        Me.colFullname.HeaderText = "Fullname"
        Me.colFullname.Name = "colFullname"
        Me.colFullname.ReadOnly = True
        '
        'colGradeLevel
        '
        Me.colGradeLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colGradeLevel.DataPropertyName = "GradeLevel"
        Me.colGradeLevel.HeaderText = "Grade"
        Me.colGradeLevel.Name = "colGradeLevel"
        Me.colGradeLevel.ReadOnly = True
        Me.colGradeLevel.Width = 62
        '
        'colSection
        '
        Me.colSection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSection.DataPropertyName = "Section"
        Me.colSection.HeaderText = "Section"
        Me.colSection.Name = "colSection"
        Me.colSection.ReadOnly = True
        Me.colSection.Width = 69
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.DataPropertyName = "Department"
        Me.Column2.HeaderText = "Department"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 91
        '
        'colEnrollDate
        '
        Me.colEnrollDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEnrollDate.DataPropertyName = "Enrollment_Date"
        Me.colEnrollDate.HeaderText = "Enrollment Date"
        Me.colEnrollDate.Name = "colEnrollDate"
        Me.colEnrollDate.ReadOnly = True
        Me.colEnrollDate.Width = 104
        '
        'colStatus
        '
        Me.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStatus.DataPropertyName = "Status"
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 65
        '
        'colPrint
        '
        Me.colPrint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPrint.HeaderText = ""
        Me.colPrint.Image = Global.LEMS_ES.My.Resources.Resources.printer
        Me.colPrint.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.colPrint.Name = "colPrint"
        Me.colPrint.ReadOnly = True
        Me.colPrint.Width = 5
        '
        'colDrop
        '
        Me.colDrop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDrop.HeaderText = ""
        Me.colDrop.Image = Global.LEMS_ES.My.Resources.Resources.drop
        Me.colDrop.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.colDrop.Name = "colDrop"
        Me.colDrop.ReadOnly = True
        Me.colDrop.Visible = False
        Me.colDrop.Width = 5
        '
        'FrmEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 615)
        Me.Controls.Add(Me.GBEnrollmentForm)
        Me.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEnrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GBEnrollmentForm.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvEnrolled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBEnrollmentForm As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvEnrolled As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnSearch As ToolStripButton
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colSY As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colLRN As DataGridViewTextBoxColumn
    Friend WithEvents colFullname As DataGridViewTextBoxColumn
    Friend WithEvents colGradeLevel As DataGridViewTextBoxColumn
    Friend WithEvents colSection As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents colEnrollDate As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colPrint As DataGridViewImageColumn
    Friend WithEvents colDrop As DataGridViewImageColumn
End Class
