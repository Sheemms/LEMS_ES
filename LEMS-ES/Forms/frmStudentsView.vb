Public Class frmStudentsView
    Private Sub frmStudentsView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
    End Sub
    Public Sub ValidationFields()
        If txtStudNum.Text = "" Or txtStudLname.Text = "" Or txtStudFname.Text = "" Or txtStudMname.Text = "" Or txtStudAge.Text = "" Or txtStudContact.Text = "" Or cmbStudGender.Text = "" Or cmbStudMaritalStatus.Text = "" Or txtStudCitizenship.Text = "" Or txtStudReligion.Text = "" Or txtStudAddress.Text = "" Then
            MsgBox("Fields are required!", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub
    Public Sub Parameters()
        cmd.Parameters.AddWithValue("@StudentNo", txtStudNum.Text)
        cmd.Parameters.AddWithValue("@Classification", txtStudType.Text)
        cmd.Parameters.AddWithValue("@Lastname", txtStudLname.Text)
        cmd.Parameters.AddWithValue("@Firstname", txtStudFname.Text)
        cmd.Parameters.AddWithValue("@MI", txtStudMname.Text)
        cmd.Parameters.AddWithValue("@Gender", txtStudAge.Text)
        cmd.Parameters.AddWithValue("@Birthday", Format(dtpBday.Value, "yyyy-mm-dd"))
        cmd.Parameters.AddWithValue("@GuardianContact", txtStudContact.Text)
        cmd.Parameters.AddWithValue("@Gender", cmbStudGender.Text)
        cmd.Parameters.AddWithValue("@MaritalStatus", cmbStudMaritalStatus.Text)
        cmd.Parameters.AddWithValue("@Citizenship", txtStudCitizenship.Text)
        cmd.Parameters.AddWithValue("@Religion", txtStudReligion.Text)
        cmd.Parameters.AddWithValue("@Address", txtStudAddress.Text)
    End Sub
End Class