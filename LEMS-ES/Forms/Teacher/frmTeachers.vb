Public Class FrmTeachers
    Private Sub FrmTeachers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Try
            Query("SELECT t.ID, t.EmpID, d.Department, CONCAT(t.Lastname, ', ', t.Firstname, ' ', t.MiddleInitial) AS Fullname, 
                t.Contact, t.Address 
                FROM teacher t
                JOIN department d ON t.Department_ID = d.ID")
            dgvTeacher.DataSource = ds.Tables("QueryTb")
            dgvTeacher.AutoGenerateColumns = False
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        frmTeacherMaintenance.Show()
    End Sub

    Private Sub DgvTeacher_DoubleClick(sender As Object, e As EventArgs) Handles dgvTeacher.DoubleClick
        Try
            If dgvTeacher.SelectedRows.Count > 0 Then
                With dgvTeacher.SelectedRows(0)
                    FrmTeacherMaintenance.idTeacher = .Cells(0).Value
                    FrmTeacherMaintenance.txtEmpID.Text = .Cells(1).Value
                End With
                FrmTeacherMaintenance.LoadTeacherData()
                FrmTeacherMaintenance.Show()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
End Class