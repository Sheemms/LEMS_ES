Public Class frmUserMaintenance
    Dim id As String = ""
    Private Sub frmUserMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM user")
        dgvUser.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtFullname.Clear()
        cmbUserLevel.Text = ""
    End Sub
    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        Try
            For Each row As DataGridViewRow In dgvUser.SelectedRows
                id = row.Cells(0).Value
                txtUsername.Text = row.Cells(1).Value
                txtPassword.Text = row.Cells(2).Value
                txtFullname.Text = row.Cells(3).Value
                cmbUserLevel.Text = row.Cells(4).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IS_EMPTY(txtUsername) = False Then Return
        If IS_EMPTY(txtPassword) = False Then Return
        If IS_EMPTY(txtFullname) = False Then Return
        If IS_EMPTY(cmbUserLevel) = False Then Return

        Query("SELECT * FROM user WHERE ID = '" & id & "'")
        If ds.Tables("QueryTb").Rows.Count > 0 Then
            Critical("User Account already exist!")
            Exit Sub
        End If

        Success("Succcessfully Added!")

        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnClearUserMaintenance_Click(sender As Object, e As EventArgs) Handles btnClearUserMaintenance.Click
        clear()
    End Sub

End Class