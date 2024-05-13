Public Class FrmUserMaintenance
    Public idUserMaintenance As Integer = 0
    Private Sub FrmUserMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT * FROM user")
        dgvUser.DataSource = ds.Tables("QueryTb")
        dgvUser.AutoGenerateColumns = False

        Query("SELECT * FROM userlevel")
        cmbUserLevel.DataSource = ds.Tables("QueryTb")
        cmbUserLevel.ValueMember = "userlevel"
        cmbUserLevel.DisplayMember = "userlevel"
    End Sub
    Public Sub Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtRePassword.Clear()
        txtFullname.Clear()
        cmbUserLevel.Text = ""
    End Sub
    Private Sub DgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        Try
            For Each row As DataGridViewRow In dgvUser.SelectedRows
                idUserMaintenance = row.Cells(0).Value
                txtUsername.Text = row.Cells(1).Value
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
        Clear()
    End Sub

    Private Sub BtnClearUserMaintenance_Click(sender As Object, e As EventArgs) Handles btnClearUserMaintenance.Click
        Clear()
    End Sub

    Private Sub BtnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        ClassUserMaintenance.UserMDeact()
    End Sub
    Private Sub CmbUserLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUserLevel.KeyPress
        e.Handled = True
    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullname.KeyPress
        If Not IsValidInput(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
End Class