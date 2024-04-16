Imports System.ComponentModel

Public Class frmStudentsView
    Public idStud As Integer = 0
    Private Sub frmStudentsView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
        LoadReq()
        LoadReqClass()
    End Sub
    Public Sub loadrecords()
        Query("SELECT  rq.ID, reqclass.Classification, rq.Requirement
                FROM requirements rq
                JOIN req_classification reqclass ON rq.Classification_ID = reqclass.ID")
        dgvSubmittedRequirements.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub LoadReq()
        Query("SELECT rqc.Classification, r.Requirement
                FROM requirements r
                JOIN req_classification rqc ON r.Classification_ID = rqc.ID
                WHERE Classification = ")
        dgvRequirements.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub ClearFields()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox =
            {txtStudNum, txtStudLname, txtStudFname, txtStudMname, txtGuardianName, txtGuardianAddress}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        cmbStudSuffix.Items.Clear()
        cbMale.Checked = False
        cbFemale.Checked = False
    End Sub

    Public Sub LoadReqClass()
        Query("SELECT * FROM req_Classification")
        cmbStudType.DataSource = ds.Tables("QueryTb")
        cmbStudType.ValueMember = "ID"
        cmbStudType.DisplayMember = "Classification"
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
        ClassStudents.StudRef()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ClassStudents.StudUpdate()
    End Sub
    Private Sub CalculateAge()
        Dim birthdate As Date = dtpBday.Value.Date
        Dim currentDate As Date = Date.Today
        Dim age As Integer = currentDate.Year - birthdate.Year
        If (birthdate.Month > currentDate.Month) OrElse (birthdate.Month = currentDate.Month AndAlso birthdate.Day > currentDate.Day) Then
            age -= 1
        End If

        txtStudAge.Text = age.ToString()
    End Sub

    Private Sub dtpBday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBday.ValueChanged
        CalculateAge()
    End Sub

End Class