Imports System.ComponentModel

Public Class frmStudentsView
    Public idStud As Integer = 0
    Private Sub FrmStudentsView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadRequirements()
    End Sub
    Public Sub LoadStudentData()
        Query("SELECT * FROM student WHERE LRN = '" & txtStudNum.Text & "'")

        If ds.Tables("QueryTb").Rows.Count > 0 Then ' Check if there are any rows
            With ds.Tables("QueryTb").Rows(0) ' Access the first row
                cmbStudType.SelectedValue = .Item(1)
                txtStudLname.Text = .Item(3)
                txtStudFname.Text = .Item(4)
                txtStudMname.Text = .Item(5)
                cmbStudSuffix.Text = .Item(6)
                If .Item(7).ToString = "Male" Then
                    RbMale.Checked = True
                Else
                    RbFemale.Checked = True
                End If
                txtStudAge.Text = .Item(8)
                dtpBday.Value = .Item(9).ToString
                txtAddress.Text = .Item(10)
                txtCitizenship.Text = .Item(19)
            End With
        Else
            ' Handle the case when no rows are returned (e.g., clear fields or show a message)
            ClearFields(Me, idStud)
        End If
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
            Dim submittedvalue As String = row.Cells(3).Value 'Column named Column1 cannot be found.
            If submittedvalue = "Yes" Then
                row.Cells("colCheckBox").Value = True
            End If
        Next

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
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ClassStudents.StudRef()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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

    Private Sub DtpBday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBday.ValueChanged
        CalculateAge()
    End Sub
    Private Sub CmbStudType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudType.SelectedIndexChanged
        ' Check if an item is selected
        If cmbStudType.SelectedItem IsNot Nothing Then
            Dim selectedDataRowView As DataRowView = CType(cmbStudType.SelectedItem, DataRowView)
            Dim selectedID As Integer = Convert.ToInt32(selectedDataRowView("ID"))

            ' Load requirements based on the selected ID
            LoadRequirementsByStudType(selectedID)
        End If
    End Sub

    Private Sub LoadRequirementsByStudType(selectedID As Integer)
        ' Query to retrieve requirements based on the selected ID
        Query("SELECT r.id, r.Requirement, IF(sr.DateSubmitted IS NULL, 'No', 'Yes') AS issubmitted " &
          "FROM requirements r " &
          "LEFT JOIN submitted_requirements sr ON r.ID = sr.RequirementID AND sr.StudentID = " & idStud & " " &
          "WHERE r.Classification_ID = " & selectedID & " " &
          "ORDER BY r.Requirement")

        ' Check if the DataSet contains the "QueryTb" table and if it has rows
        If ds.Tables.Contains("QueryTb") AndAlso ds.Tables("QueryTb").Rows.Count > 0 Then
            ' If there are rows, bind the data to the DataGridView
            dgvRequirements.DataSource = ds.Tables("QueryTb")
        Else
            ' If no rows are found, clear the DataGridView
            dgvRequirements.DataSource = Nothing
        End If
    End Sub

End Class