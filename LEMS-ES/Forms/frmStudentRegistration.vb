Imports System.ComponentModel

Public Class frmStudentRegistration
    Private Sub frmStudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
    End Sub


    Private Sub btnCancelSY_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class