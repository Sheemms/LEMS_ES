Public Class frmUserMaintenance
    Public idUserMaintenance As Integer = 0
    Private Sub frmUserMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM user")
        dgvUser.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        idUserMaintenance = 0
        txtUsername.Clear()
        txtPassword.Clear()
        txtFullname.Clear()
        cmbUserLevel.Text = ""
    End Sub
    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        Try
            For Each row As DataGridViewRow In dgvUser.SelectedRows
                idUserMaintenance = row.Cells(0).Value
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
#Region "IS_EMPTY"
        If IS_EMPTY(txtUsername) = True Then Return
        If IS_EMPTY(txtPassword) = True Then Return
        If IS_EMPTY(txtFullname) = True Then Return
        If IS_EMPTY(cmbUserLevel) = True Then Return
#End Region

        ClassUserMaintenance.UserMRef()
        clear()
    End Sub

    Private Sub btnClearUserMaintenance_Click(sender As Object, e As EventArgs) Handles btnClearUserMaintenance.Click
        clear()
    End Sub

End Class