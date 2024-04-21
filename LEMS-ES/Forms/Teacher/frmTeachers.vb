Public Class FrmTeachers
    Private Sub FrmTeachers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT t.ID, t.EmpID, d.Department, CONCAT(t.Lastname, ', ', t.Firstname, ' ', t.MiddleInitial) AS Fullname, 
                t.Contact, t.Address 
                FROM teacher t
                JOIN department d ON t.Department_ID = d.ID")
        dgvTeacher.DataSource = ds.Tables("QueryTb")
    End Sub
    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        frmTeacherMaintenance.Show()
    End Sub
End Class