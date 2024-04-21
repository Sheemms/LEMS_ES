Public Class frmUserMaintenance
    Public idUserMaintenance As Integer = 0
    Private Sub FrmUserMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM user")
        dgvUser.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM userlevel")
        cmbUserLevel.DataSource = ds.Tables("QueryTb")
        cmbUserLevel.ValueMember = "userlevel"
        cmbUserLevel.DisplayMember = "userlevel"
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
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
#Region "IS_EMPTY"
        If IS_EMPTY(txtUsername) = True Then Return
        If IS_EMPTY(txtPassword) = True Then Return
        If IS_EMPTY(txtFullname) = True Then Return
        If IS_EMPTY(cmbUserLevel) = True Then Return

        If txtPassword.Text <> txtRePassword.Text Then
            Critical("Password not match.")
            Return
        End If
#End Region

        ClassUserMaintenance.UserMRef()
        ClearFields(Me, idUserMaintenance)
    End Sub

    Private Sub BtnClearUserMaintenance_Click(sender As Object, e As EventArgs) Handles btnClearUserMaintenance.Click
        ClearFields(Me, idUserMaintenance)
    End Sub

    Private Sub BtnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        ClassUserMaintenance.UserMDeact()
        ClearFields(Me, idUserMaintenance)
    End Sub

    Private Sub BtnAddUserLevel_Click(sender As Object, e As EventArgs) Handles btnAddUserLevel.Click
        frmAddUserLevel.Show()
    End Sub

    Private Sub CmbUserLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUserLevel.KeyPress
        e.Handled = True
    End Sub
End Class