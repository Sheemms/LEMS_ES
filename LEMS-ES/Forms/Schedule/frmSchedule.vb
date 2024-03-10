Public Class frmSchedule
    Private Sub frmSchedule_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub loadrecords()
        Query("")


        Query("SELECT * FROM gradelevel")
        cmbGradeLevel.DataSource = ds.Tables("QueryTb")
        cmbGradeLevel.ValueMember = "ID"
        cmbGradeLevel.DisplayMember = "GradeLevel"
    End Sub
End Class