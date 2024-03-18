
Public Class frmEnrollmentRegistration
    Public EnrollmentID = 0
    Private Sub frmEnrollmentRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub loadrecords()

    End Sub
    Public Sub loadSubject()
        Query("SELECT ID, LRN, SchoolYear, SectionID, GradeLevel_ID 
               FROM enrollment e
               JOIN section s ON e.SectionID = s.ID
               JOIN gradelevel gl ON e.GradeLevel_ID = gl.ID")
        dgvSubjectList.DataSource = ds.Tables("QueryTb")

        Query("SELECT ID, GradeLevel FROM gradelevel")
        cmbGradeLevel.DataSource = ds.Tables("QueryTb")
        cmbGradeLevel.ValueMember = "ID"
        cmbGradeLevel.DisplayMember = "GradeLevel"
    End Sub
    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click

    End Sub
End Class