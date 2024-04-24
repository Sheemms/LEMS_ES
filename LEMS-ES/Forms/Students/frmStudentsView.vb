Imports System.ComponentModel

Public Class frmStudentsView
    Public idStud As Integer = 0
    Private Sub FrmStudentsView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadRequirements()
    End Sub
    Public Sub LoadStudentData()
        Query("SELECT * FROM student WHERE LRN = '" & txtStudNum.Text & "'")

        If ds.Tables("QueryTb").Rows.Count > 0 Then
            With ds.Tables("QueryTb").Rows(0)
                cmbStudType.SelectedValue = .Item(1) 'Cannot Set the SelectedValue In a ListControl With an empty ValueMember.'
                txtStudLname.Text = .Item(3)
                txtStudFname.Text = .Item(4)
                txtStudMI.Text = .Item(5)
                cmbStudSuffix.Text = .Item(6)
                If .Item(7).ToString = "Male" Then
                    RbMale.Checked = True
                ElseIf .Item(7).ToString = "Female" Then
                    RbFemale.Checked = True
                Else
                    RbMale.Checked = False
                    RbFemale.Checked = False
                End If
                txtStudAge.Text = .Item(8)
                dtpBday.Value = .Item(9).ToString
                txtAddress.Text = .Item(10)
                txtMother.Text = .Item(11)
                txtMotherMaidenName.Text = .Item(12)
                txtMotherOccupation.Text = .Item(13)
                txtFatherName.Text = .Item(14)
                txtFatherOccupation.Text = .Item(15)
                txtGuardianName.Text = .Item(16)
                txtGuardianRelation.Text = .Item(17)
                txtGuardianContact.Text = .Item(18)
                txtCitizenship.Text = .Item(19)
            End With
        Else
            ' Handle the case when no rows are returned (e.g., clear fields or show a message)
            ClearFields(Me, idStud)
        End If
    End Sub

    Public Sub LoadRequirements()
        If cmbStudType.SelectedItem IsNot Nothing Then
            Dim selectedDataRowView As DataRowView = CType(cmbStudType.SelectedItem, DataRowView)
            Dim selectedID As Integer = Convert.ToInt32(selectedDataRowView("ID"))

            'Query("SELECT
            '   r.ID,
            '   r.Requirement,
            '   IF(sr.DateSubmitted IS NULL , 'No','Yes') AS issubmitted
            '   FROM student s
            '   LEFT JOIN requirements r ON r.Classification_ID = s.StudType
            '   LEFT JOIN submitted_requirements sr ON s.ID = sr.StudentID AND r.ID = sr.RequirementID
            '   WHERE s.ID = '" & idStud & "' AND r.Classification_ID = '" & selectedID & "' ORDER BY s.Lastname, r.Requirement")
            Query("SELECT r.ID, r.Requirement, IF(sr.DateSubmitted IS NULL, 'No', 'Yes') AS issubmitted " &
          "FROM requirements r " &
          "LEFT JOIN submitted_requirements sr ON r.ID = sr.RequirementID AND sr.StudentID = " & idStud & " " &
          "WHERE r.Classification_ID = " & selectedID & " " &
          "ORDER BY r.Requirement")
            dgvRequirements.DataSource = ds.Tables("QueryTb")
            dgvRequirements.AutoGenerateColumns = False

            For Each row As DataGridViewRow In dgvRequirements.Rows
                Dim submittedvalue As String = row.Cells("Column1").Value.ToString()
                If submittedvalue = "Yes" Then
                    row.Cells("colCheckBox").Value = True
                End If
            Next
        Else
            ' Handle the case where no item is selected in cmbStudType
            ' For example, you might want to clear dgvRequirements
            dgvRequirements.DataSource = Nothing
        End If
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
#Region "IS_EMPTY"
        If IS_EMPTY(txtStudNum) Then Return
        If IS_EMPTY(cmbStudType) Then Return
        If IS_EMPTY(txtStudLname) Then Return
        If IS_EMPTY(txtStudFname) Then Return
        If IS_EMPTY(txtStudMI) Then Return
        If IS_EMPTY(cmbStudSuffix) Then Return
        If IS_EMPTY(txtAddress) Then Return
#End Region
        ClassStudents.StudRef()
        ClearFields(Me, idStud)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ClassStudents.StudUpdate()
        ClearFields(Me, idStud)
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
        If cmbStudType.SelectedItem IsNot Nothing Then
            'Dim selectedDataRowView As DataRowView = CType(cmbStudType.SelectedItem, DataRowView)
            'Dim selectedID As Integer = Convert.ToInt32(selectedDataRowView("ID"))

            'LoadRequirementsByStudType(selectedID)
            LoadRequirements()
        End If
    End Sub
End Class