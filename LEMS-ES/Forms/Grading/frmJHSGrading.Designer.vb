<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmJHSGrading
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DgvJHSGrading = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.CmbSubject = New System.Windows.Forms.ToolStripComboBox()
        Me.CmbSubjCode = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvJHSGrading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1115, 711)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Junior High Module"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DgvJHSGrading)
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Panel2.Location = New System.Drawing.Point(3, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 686)
        Me.Panel2.TabIndex = 0
        '
        'DgvJHSGrading
        '
        Me.DgvJHSGrading.AllowUserToAddRows = False
        Me.DgvJHSGrading.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvJHSGrading.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvJHSGrading.BackgroundColor = System.Drawing.Color.DimGray
        Me.DgvJHSGrading.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DgvJHSGrading.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvJHSGrading.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvJHSGrading.ColumnHeadersHeight = 44
        Me.DgvJHSGrading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvJHSGrading.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column13, Me.Column14, Me.Column4, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.firstg, Me.secondg, Me.thirdg, Me.fourthg, Me.average, Me.remarks})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Courier New", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvJHSGrading.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvJHSGrading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvJHSGrading.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvJHSGrading.Location = New System.Drawing.Point(0, 25)
        Me.DgvJHSGrading.MultiSelect = False
        Me.DgvJHSGrading.Name = "DgvJHSGrading"
        Me.DgvJHSGrading.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvJHSGrading.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvJHSGrading.Size = New System.Drawing.Size(1109, 661)
        Me.DgvJHSGrading.TabIndex = 29
        Me.DgvJHSGrading.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvJHSGrading.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvJHSGrading.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvJHSGrading.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvJHSGrading.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvJHSGrading.ThemeStyle.BackColor = System.Drawing.Color.DimGray
        Me.DgvJHSGrading.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvJHSGrading.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.DgvJHSGrading.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.DgvJHSGrading.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvJHSGrading.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvJHSGrading.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvJHSGrading.ThemeStyle.HeaderStyle.Height = 44
        Me.DgvJHSGrading.ThemeStyle.ReadOnly = False
        Me.DgvJHSGrading.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvJHSGrading.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DgvJHSGrading.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvJHSGrading.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvJHSGrading.ThemeStyle.RowsStyle.Height = 22
        Me.DgvJHSGrading.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvJHSGrading.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "SY"
        Me.Column13.HeaderText = "SY"
        Me.Column13.Name = "Column13"
        Me.Column13.Visible = False
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "EID"
        Me.Column14.HeaderText = "EID"
        Me.Column14.Name = "Column14"
        Me.Column14.Visible = False
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.DataPropertyName = "LRN"
        Me.Column4.HeaderText = "LRN"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 53
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
        Me.firstg.HeaderText = "1st Grd"
        Me.firstg.Name = "firstg"
        Me.firstg.Width = 81
        '
        'secondg
        '
        Me.secondg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.secondg.HeaderText = "2nd Grd"
        Me.secondg.Name = "secondg"
        Me.secondg.Width = 81
        '
        'thirdg
        '
        Me.thirdg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.thirdg.HeaderText = "3rd Grd"
        Me.thirdg.Name = "thirdg"
        Me.thirdg.Width = 81
        '
        'fourthg
        '
        Me.fourthg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripTextBox1, Me.ToolStripButton3, Me.CmbSubject, Me.CmbSubjCode, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1109, 25)
        Me.ToolStrip1.TabIndex = 28
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
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(200, 25)
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
        'FrmJHSGrading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 711)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmJHSGrading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvJHSGrading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents CmbSubject As ToolStripComboBox
    Friend WithEvents CmbSubjCode As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents DgvJHSGrading As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
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
