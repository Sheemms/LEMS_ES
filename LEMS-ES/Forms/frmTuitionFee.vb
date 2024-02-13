Public Class frmTuitionFee
    Dim id As String = ""
    Private Sub frmTuitionFee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM tuition")
        dgvTuitionFee.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        txtAmount.Clear()
        txtClassification.Clear()
    End Sub
    Private Sub btnSaveTuitionFee_Click(sender As Object, e As EventArgs) Handles btnSaveTuitionFee.Click
        If IS_EMPTY(txtAmount) Then Return
        If IS_EMPTY(txtClassification) Then Return

        Query("SELECT * FROM tuition WHERE Amount = '" & txtAmount.Text & "' OR Classification = '" & txtClassification.Text & "' AND ID <> '" & id & "'")
        If ds.Tables("QueryTb").Rows.Count > 0 Then
            Critical("Tuition fee already exist")
            Exit Sub
        End If

        Command("INSERT INTO tuition(Amount, Classification) VALUES(@Amount, @Classification)")
        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text)
        cmd.Parameters.AddWithValue("@Classification", txtClassification.Text)
        'cmd.ExecuteNonQuery()
        Success("Successfully Added!")
        loadrecords()
        Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnClearTuitionFee_Click(sender As Object, e As EventArgs) Handles btnClearTuitionFee.Click

    End Sub
End Class