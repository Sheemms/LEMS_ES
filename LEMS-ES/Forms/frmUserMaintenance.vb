Public Class frmUserMaintenance
    Private Sub frmUserMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
    End Sub
    Public Sub clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtFullname.Clear()
        cmbUserLevel.Text = ""
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnClearUserMaintenance_Click(sender As Object, e As EventArgs) Handles btnClearUserMaintenance.Click
        clear()
    End Sub
End Class