<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmElementaryGrading
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvElemGrading = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TxtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.CmbSubject = New System.Windows.Forms.ToolStripComboBox()
        Me.CmbSubjCode = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLRN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.secondg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.thirdg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fourthg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvElemGrading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvElemGrading
        '
        Me.DgvElemGrading.AllowUserToAddRows = False
        Me.DgvElemGrading.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvElemGrading.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvElemGrading.BackgroundColor = System.Drawing.Color.DimGray
        Me.DgvElemGrading.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DgvElemGrading.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvElemGrading.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvElemGrading.ColumnHeadersHeight = 44
        Me.DgvElemGrading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvElemGrading.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Column13, Me.colEID, Me.colLRN, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.firstg, Me.secondg, Me.thirdg, Me.fourthg, Me.average, Me.remarks})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Courier New", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvElemGrading.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvElemGrading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvElemGrading.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvElemGrading.Location = New System.Drawing.Point(0, 25)
        Me.DgvElemGrading.MultiSelect = False
        Me.DgvElemGrading.Name = "DgvElemGrading"
        Me.DgvElemGrading.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvElemGrading.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvElemGrading.Size = New System.Drawing.Size(1109, 661)
        Me.DgvElemGrading.TabIndex = 5
        Me.DgvElemGrading.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvElemGrading.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvElemGrading.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvElemGrading.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvElemGrading.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvElemGrading.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.DgvElemGrading.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvElemGrading.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.DgvElemGrading.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.DgvElemGrading.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvElemGrading.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvElemGrading.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvElemGrading.ThemeStyle.HeaderStyle.Height = 44
        Me.DgvElemGrading.ThemeStyle.ReadOnly = False
        Me.DgvElemGrading.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvElemGrading.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DgvElemGrading.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvElemGrading.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvElemGrading.ThemeStyle.RowsStyle.Height = 22
        Me.DgvElemGrading.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvElemGrading.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1115, 711)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elementary Module"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DgvElemGrading)
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Panel2.Location = New System.Drawing.Point(3, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 686)
        Me.Panel2.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.TxtSearch, Me.ToolStripButton3, Me.CmbSubject, Me.CmbSubjCode, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1109, 25)
        Me.ToolStrip1.TabIndex = 27
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.LEMS_ES.My.Resources.Resources.floppy_disk
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripButton1.Text = "Save Changes"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.LEMS_ES.My.Resources.Resources.printer
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton2.Text = "Print"
        '
        'TxtSearch
        '
        Me.TxtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TxtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.LEMS_ES.My.Resources.Resources.search
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'CmbSubject
        '
        Me.CmbSubject.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbSubject.Name = "CmbSubject"
        Me.CmbSubject.Size = New System.Drawing.Size(121, 25)
        '
        'CmbSubjCode
        '
        Me.CmbSubjCode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CmbSubjCode.Name = "CmbSubjCode"
        Me.CmbSubjCode.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel1.Text = "Filtered By:"
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "SY"
        Me.Column13.HeaderText = "SY"
        Me.Column13.Name = "Column13"
        Me.Column13.Visible = False
        '
        'colEID
        '
        Me.colEID.DataPropertyName = "EID"
        Me.colEID.HeaderText = "EID"
        Me.colEID.Name = "colEID"
        Me.colEID.Visible = False
        '
        'colLRN
        '
        Me.colLRN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLRN.DataPropertyName = "LRN"
        Me.colLRN.HeaderText = "LRN"
        Me.colLRN.Name = "colLRN"
        Me.colLRN.Width = 53
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "Fullname"
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "SubjectCode"
        Me.Column3.HeaderText = "Subject Code"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.DataPropertyName = "SubjectName"
        Me.Column5.HeaderText = "Subject Name"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.DataPropertyName = "Units"
        Me.Column6.HeaderText = "Unit(s)"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 81
        '
        'firstg
        '
        Me.firstg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.firstg.DataPropertyName = "FirstGrd"
        Me.firstg.HeaderText = "1st Grd"
        Me.firstg.Name = "firstg"
        Me.firstg.Width = 81
        '
        'secondg
        '
        Me.secondg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.secondg.DataPropertyName = "SecondGrd"
        Me.secondg.HeaderText = "2nd Grd"
        Me.secondg.Name = "secondg"
        Me.secondg.Width = 81
        '
        'thirdg
        '
        Me.thirdg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.thirdg.DataPropertyName = "ThirdGrd"
        Me.thirdg.HeaderText = "3rd Grd"
        Me.thirdg.Name = "thirdg"
        Me.thirdg.Width = 81
        '
        'fourthg
        '
        Me.fourthg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fourthg.DataPropertyName = "FourthGrd"
        Me.fourthg.HeaderText = "4th Grd"
        Me.fourthg.Name = "fourthg"
        Me.fourthg.Width = 81
        '
        'average
        '
        Me.average.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.average.DataPropertyName = "Average"
        Me.average.HeaderText = "Average"
        Me.average.Name = "average"
        Me.average.Width = 81
        '
        'remarks
        '
        Me.remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.remarks.DataPropertyName = "Remarks"
        Me.remarks.HeaderText = "Remarks"
        Me.remarks.Name = "remarks"
        Me.remarks.Width = 81
        '
        'FrmElementaryGrading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 711)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmElementaryGrading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DgvElemGrading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvElemGrading As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents TxtSearch As ToolStripTextBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents CmbSubject As ToolStripComboBox
    Friend WithEvents CmbSubjCode As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents colEID As DataGridViewTextBoxColumn
    Friend WithEvents colLRN As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents firstg As DataGridViewTextBoxColumn
    Friend WithEvents secondg As DataGridViewTextBoxColumn
    Friend WithEvents thirdg As DataGridViewTextBoxColumn
    Friend WithEvents fourthg As DataGridViewTextBoxColumn
    Friend WithEvents average As DataGridViewTextBoxColumn
    Friend WithEvents remarks As DataGridViewTextBoxColumn
End Class
