Imports System.ComponentModel
Public Class frmStudentRegistration
    Public idStudent As Integer = 0

    Private Sub frmStudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT  rq.ID, reqclass.Classification, rq.Requirement
                FROM requirements rq
                JOIN req_classification reqclass ON rq.Classification_ID = reqclass.ID")
        dgvRequirements.DataSource = ds.Tables("QueryTb")

    End Sub
    Public Sub ClearFields()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {txtLRN, txtLastname, txtFirstname, txtMiddlename, txtAddress}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        cbMale.Checked = False
        cbFemale.Checked = False
    End Sub
    Public Function GenderSelection() As String
        If cbMale.Checked Then
            cbFemale.Checked = False
            Return "Male"
        ElseIf cbFemale.Checked Then
            cbMale.Checked = False
            Return "Female"
        Else
            Return "Not Specified"
        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
#Region "IS_EMPTY"
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {txtLRN, txtLastname, txtFirstname, txtMiddlename,
    txtAddress}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            If IS_EMPTY(textBox) Then
                Return
            End If
        Next
        If cbMale.Checked = False AndAlso cbFemale.Checked = False Then
            MsgBox("Please select a gender!")
            Return
        End If
#End Region

        ClassStudents.StudentRef(Me)
        'ClearFields()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

End Class