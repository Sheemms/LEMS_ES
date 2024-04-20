Public Class frmStudents
    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        frmStudentsView.Show()
    End Sub
    Public Sub loadrecords()
        Query("SELECT ID, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS Fullname, Suffix, Gender, Age, Birthday, Address, 
                MotherName, MothersMaiden, Mother_Occupation, FatherName, Father_Occupation, GuardianName, GuardianContact, Citizenship
                FROM student")
        dgvStudents.AutoGenerateColumns = False
        dgvStudents.DataSource = ds.Tables("QueryTb")
    End Sub
    Private Sub dgvStudents_DoubleClick(sender As Object, e As EventArgs) Handles dgvStudents.DoubleClick
        If dgvStudents.SelectedRows.Count > 0 Then
            With dgvStudents.SelectedRows(0)
                frmStudentsView.idStud = .Cells(0).Value
                frmStudentsView.txtStudNum.Text = .Cells(1).Value
            End With
            frmStudentsView.Show()
        End If
    End Sub

End Class