Imports System.ComponentModel
Public Class frmStudentRegistration
    Public idStudent As Integer = 0

    Private Sub frmStudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
    End Sub

    Public Sub ClearFields()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {txtLRN, txtLastname, txtFirstname, txtMiddlename, txtSuffix, txtStudentContact,
    txtAddress, txtMothersName, txtMotherOccup, txtMotherContact, txtFathersName, txtFatherOccup, txtFatherContact, txtPlaceofBirth, txtReligion, txtCitizenship, txtEmailAddress}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        cbMale.Checked = False
        cbFemale.Checked = False
    End Sub
    Public Function GenderSelection() As String
        If cbMale.Checked Then
            Return "Male"
        ElseIf cbFemale.Checked Then
            Return "Female"
        Else
            Return "Not Specified"
        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
#Region "IS_EMPTY"
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {txtLRN, txtLastname, txtFirstname, txtMiddlename, txtSuffix, txtStudentContact,
    txtAddress, txtMothersName, txtMotherOccup, txtMotherContact, txtFathersName, txtFatherOccup, txtFatherContact, txtPlaceofBirth, txtReligion, txtCitizenship, txtEmailAddress}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            If IS_EMPTY(textBox) Then
                Return ' or do something else if the textbox is empty
            End If
        Next
        If cbMale.Checked = False AndAlso cbFemale.Checked = False Then
            MsgBox("Please select a gender!")
            Return
        End If
#End Region

        ClassStudents.StudentRef()

        ClearFields()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub
    Private Sub cbMale_CheckedChanged(sender As Object, e As EventArgs) Handles cbMale.CheckedChanged
        If cbMale.Checked Then
            cbFemale.Checked = False
        End If
    End Sub

    Private Sub cbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles cbFemale.CheckedChanged
        If cbFemale.Checked Then
            cbMale.Checked = False
        End If
    End Sub
End Class