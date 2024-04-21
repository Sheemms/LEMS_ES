Public Class frmStudents
    Private Sub FrmStudents_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
    End Sub
    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        frmStudentsView.LoadReqClass()
        frmStudentsView.Show()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT ID, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) Fullname, Suffix, Gender, Age, Birthday, Address, 
                MotherName, MothersMaiden, Mother_Occupation, FatherName, Father_Occupation, GuardianName, GuardianContact, Citizenship
                FROM student")
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
            frmStudentsView.Show()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Query($"SELECT ID, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) Fullname, Suffix, Gender, Age, Birthday, Address, 
                MotherName, MothersMaiden, Mother_Occupation, FatherName, Father_Occupation, GuardianName, GuardianContact, Citizenship
                FROM student WHERE LRN LIKE '{TextSearch.Text}' OR Lastname LIKE '{TextSearch.Text}' OR Firstname LIKE '{TextSearch.Text}'")
        dgvStudents.DataSource = ds.Tables("QueryTb")
    End Sub
End Class