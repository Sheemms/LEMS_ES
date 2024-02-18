Imports System.ComponentModel

Public Class frmStudentRegistration
    Private Sub frmStudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
    End Sub

    Public Sub loadrecords()
        Query("SELECT * FROM student")
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
#End Region

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class