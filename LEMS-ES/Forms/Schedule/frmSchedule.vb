Public Class frmSchedule
    Private Sub frmSchedule_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub loadrecords()
        Query("")

        Query("SELECT * FROM department")
        cmbDepartment.DataSource = ds.Tables("QueryTb")
        cmbDepartment.ValueMember = "ID"
        cmbDepartment.DisplayMember = "Department"

        Query("SELECT * FROM gradelevel")
        cmbGradeLevel.DataSource = ds.Tables("QueryTb")
        cmbGradeLevel.ValueMember = "ID"
        cmbGradeLevel.DisplayMember = "GradeLevel"
    End Sub

    Private Sub txtAdviserID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdviserID.KeyPress
        'Command("SELECT * FROM teacher")

    End Sub

End Class