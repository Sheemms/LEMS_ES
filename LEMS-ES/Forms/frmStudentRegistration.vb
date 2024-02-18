Imports System.ComponentModel
Public Class frmStudentRegistration
    Public idStudent As Integer = 0
    Private Sub frmStudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
    End Sub
    Public Sub clear()
        txtLRN.Clear()
        txtLastname.Clear()
        txtFirstname.Clear()
        txtMiddlename.Clear()
        txtSuffix.Clear()
        txtStudentContact.Clear()
    End Sub
    Private Function GenderSelection() As String
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
        If IS_EMPTY(txtLRN) = True Then Return
        If IS_EMPTY(txtLastname) = True Then Return
        If IS_EMPTY(txtFirstname) = True Then Return
        If IS_EMPTY(txtLastname) = True Then Return
        If IS_EMPTY(txtSuffix) = True Then Return
#End Region

        ClassStudents.StudentRef()
        clear()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
End Class