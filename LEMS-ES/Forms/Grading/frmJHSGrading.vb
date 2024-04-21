Public Class frmJHSGrading
    Private Sub frmJHSGrading_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub LoadRecords()
        Query("SELECT * FROM subject")
        CmbSubjCode.DataSource = ds.Tables("QueryTb")
        CmbSubj.ValueMember = "ID"
        CmbSubj.DisplayMember = "Department"
    End Sub
End Class