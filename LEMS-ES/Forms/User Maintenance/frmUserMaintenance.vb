Public Class FrmUserMaintenance
    Public idUserMaintenance As Integer = 0
    Private Sub FrmUserMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Try
            Query("SELECT * FROM user")
            dgvUser.DataSource = ds.Tables("QueryTb")
            dgvUser.AutoGenerateColumns = False

            Query("SELECT * FROM userlevel")
            cmbUserLevel.DataSource = ds.Tables("QueryTb")
            cmbUserLevel.ValueMember = "userlevel"
            cmbUserLevel.DisplayMember = "userlevel"
        Catch ex As Exception
            Critical(ex.Message)
        End Try
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
                TxtContact.Text = row.Cells(4).Value
                cmbUserLevel.Text = row.Cells(5).Value
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
#Region "IsEmptyField"
        If Not IsEmptyField(txtUsername.Text.Trim()) Then
            Info("Please enter a username.")
            Return
        End If
        If Not IsEmptyField(txtPassword.Text.Trim()) Then
            Info("Please enter a password.")
            Return
        End If
        If Not IsEmptyField(txtFullname.Text.Trim()) Then
            Info("Please enter a fullname.")
            Return
        End If
        If Not IsEmptyField(TxtContact.Text.Trim()) Then
            Info("Please enter a contact.")
            Return
        End If
        If Not IsEmptyField(cmbUserLevel.Text.Trim()) Then
            Info("Please select a user level.")
            Return
        End If
        If txtPassword.Text <> txtRePassword.Text Then
            Critical("Password not match.")
            Return
        End If
#End Region
        If Not NoLeadingSpace(txtUsername.Text.Trim()) Then
            Info("Username must have no multiple spaces between letters.")
            Return
        ElseIf Not NoLeadingSpace(txtFullname.Text.Trim()) Then
            Info("Fullname must have no multiple spaces between letters.")
            Return
        End If
        ClassUserMaintenance.UserMRef()
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
    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContact.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
End Class