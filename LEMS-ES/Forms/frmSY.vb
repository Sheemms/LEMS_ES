Imports MySql.Data.MySqlClient
Public Class frmSY
    Dim id As String = ""
    Private Sub frmSY_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM schoolyear")
        dgvSY.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub dgvSY_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSY.CellClick
        Try
            For Each row As DataGridViewRow In dgvSY.SelectedRows
                id = row.Cells(0).Value
                txtAddSY.Text = row.Cells(1).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub

    Private Sub btnSaveSY_Click(sender As Object, e As EventArgs) Handles btnSaveSY.Click
        If IS_EMPTY(txtAddSY) = True Then Return

        Query("SELECT * FROM schoolyear WHERE SchoolYear= '" & txtAddSY.Text & "' and ID <> '" & id & "'")
        If ds.Tables("QueryTb").Rows.Count > 0 Then
            Critical("School Year already exist")
            Exit Sub
        End If

        Command("INSERT INTO schoolyear (SchoolYear) VALUES (@SchoolYear)")
        cmd.Parameters.AddWithValue("SchoolYear", txtAddSY.Text)
        cmd.ExecuteNonQuery()
        Success("Successfully Added!")
        txtAddSY.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If IS_EMPTY(txtAddSY) = True Then Return

        Query("SELECT * FROM schoolyear WHERE SchoolYear= '" & txtAddSY.Text & "' and ID <> '" & id & "'")
        If ds.Tables("QueryTb").Rows.Count > 0 Then
            Critical("School Year already exist")
            Exit Sub
        End If

        Command("UPDATE schoolyear SET SchoolYear = @SchoolYear WHERE ID = '" & id & "'")
        cmd.Parameters.AddWithValue("SchoolYear", txtAddSY.Text)
        cmd.ExecuteNonQuery()
        Success("Successfully Updated!")
        txtAddSY.Clear()
        loadrecords()
    End Sub

    Private Sub btnCancelSY_Click(sender As Object, e As EventArgs) Handles btnCancelSY.Click
        txtAddSY.Clear()
    End Sub
End Class