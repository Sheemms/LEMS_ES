Imports MySql.Data.MySqlClient
Public Class FrmStudents
    Private Sub FrmStudents_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
    End Sub
    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        frmStudentsView.LoadReqClass()
        frmStudentsView.Show()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT a.ID, b.Classification, a.LRN, CONCAT(a.Lastname, ' ', a.Firstname, ' ', a.MiddleInitial) Fullname, a.Suffix, a.Gender, a.Age, a.Birthday, a.Address, 
                a.MotherName, a.MothersMaiden, a.Mother_Occupation, a.FatherName, a.Father_Occupation, a.GuardianName, a.GuardianContact, a.Citizenship
                FROM student a
                JOIN req_classification b ON a.StudType = b.ID")
        dgvStudents.AutoGenerateColumns = False
        dgvStudents.DataSource = ds.Tables("QueryTb")
    End Sub
    Private Sub DgvStudents_DoubleClick(sender As Object, e As EventArgs) Handles dgvStudents.DoubleClick
        If dgvStudents.SelectedRows.Count > 0 Then
            With dgvStudents.SelectedRows(0)
                frmStudentsView.idStud = .Cells(0).Value
                frmStudentsView.txtStudNum.Text = .Cells(1).Value
            End With
            frmStudentsView.LoadReqClass()
            frmStudentsView.LoadStudentData()
            FrmStudentsView.Show()
            FrmStudentsView.btnSave.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Query($"SELECT ID, StudType, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) Fullname, Suffix, Gender, Age, Birthday, Address, 
                MotherName, MothersMaiden, Mother_Occupation, FatherName, Father_Occupation, GuardianName, GuardianContact, Citizenship
                FROM student WHERE LRN LIKE '{TextSearch.Text}' OR Lastname LIKE '{TextSearch.Text}' OR Firstname LIKE '{TextSearch.Text}'")
        dgvStudents.DataSource = ds.Tables("QueryTb")
        dgvStudents.AutoGenerateColumns = False
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim dt = New DataTable("DS_StudentList")
        Dim adp = New MySqlDataAdapter("SELECT b.Classification, a.LRN, CONCAT(a.Lastname, ', ', a.Firstname, ' ', a.MiddleInitial) Fullname, a.Gender, a.Address
                                        FROM student a
                                        JOIN req_classification b ON a.StudType = b.ID", con)
        adp.Fill(dt)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No Records")
            Exit Sub
        End If

        Dim crystal As New StudentsReport
        crystal.SetDataSource(dt)
        FrmReportStudent.CrystalReportViewer1.ReportSource = crystal
        FrmReportStudent.CrystalReportViewer1.Refresh()
        FrmReportStudent.Show()
    End Sub
End Class