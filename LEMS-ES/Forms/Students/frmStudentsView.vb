Imports System.ComponentModel

Public Class frmStudentsView
    Public idStud As Integer = 0
    Private Sub frmStudentsView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadRequirements()
        LoadReqClass()
        LoadStudentData()
    End Sub
    Public Sub LoadStudentData()
        Query("SELECT * FROM student WHERE LRN = '" & txtStudNum.Text & "'")
        With ds.Tables("QueryTb")
            cmbStudType.SelectedValue = .Rows(0)(1)
            txtStudLname.Text = .Rows(0)(3)
            txtStudFname.Text = .Rows(0)(4)
            txtStudMname.Text = .Rows(0)(5)
            cmbStudSuffix.Text = .Rows(0)(6)
            If .Rows(0)(7).ToString = "Male" Then
                RbMale.Checked = True
            Else
                RbFemale.Checked = True
            End If
            txtStudAge.Text = .Rows(0)(8)
            dtpBday.Value = .Rows(0)(9).ToString
            txtAddress.Text = .Rows(0)(10)
            txtCitizenship.Text = .Rows(0)(19)
        End With
    End Sub
    Public Sub LoadRequirements()
        Query("SELECT
               r.id,
               r.Requirement,
               if(sr.DateSubmitted IS NULL , 'No','Yes') as issubmitted
               FROM student s
               LEFT JOIN requirements r ON r.Classification_ID = s.StudType
               LEFT JOIN submitted_requirements sr ON s.ID = sr.StudentID AND r.ID = sr.RequirementID
               WHERE s.ID = '" & idStud & "' ORDER BY s.Lastname, r.Requirement")
        dgvRequirements.DataSource = ds.Tables("QueryTb")

        For Each row As DataGridViewRow In dgvRequirements.Rows
            Dim submittedvalue As String = row.Cells("Column1").Value
            If submittedvalue = "Yes" Then
                row.Cells("colCheckBox").Value = True
            End If
        Next

    End Sub

    Public Sub ClearFields()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox =
            {txtStudNum, txtStudLname, txtStudFname, txtStudMname, txtGuardianName, txtAddress}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        cmbStudSuffix.Items.Clear()
        RbMale.Checked = False
        RbFemale.Checked = False
    End Sub
    Public Sub LoadReqClass()
        Query("SELECT * FROM req_classification")
        cmbStudType.DataSource = ds.Tables("QueryTb")
        cmbStudType.ValueMember = "ID"
        cmbStudType.DisplayMember = "Classification"
        cmbStudType.SelectedIndex = -1
    End Sub
    Public Function GenderSelection() As String
        If RbMale.Checked Then
            RbFemale.Checked = False
            Return "Male"
        ElseIf RbFemale.Checked Then
            RbMale.Checked = False
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