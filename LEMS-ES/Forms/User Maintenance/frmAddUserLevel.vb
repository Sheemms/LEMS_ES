Public Class FrmAddUserLevel
    Public Sub Clear()
        txtUserLevel.Clear()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ClassUserMaintenance.UserLevelRef()
        Clear()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class