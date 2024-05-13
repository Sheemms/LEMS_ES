Imports System.ComponentModel

Public Class FrmStudentsView
    Public idStud As Integer = 0
    Private Sub FrmStudentsView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadRequirements()
    End Sub
    Public Sub Clear()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {txtStudNum, txtStudLname, txtStudFname, txtStudMI, txtCitizenship,
            txtAddress, txtStudAge, txtFatherName, txtFatherOccupation, txtMother, txtMotherMaidenName, txtMotherOccupation, txtGuardianName,
            txtGuardianRelation, txtGuardianContact}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        cmbStudSuffix.Text = ""
        RbMale.Checked = False
        RbFemale.Checked = False
        idStud = 0
    End Sub
    Public Sub LoadStudentData()
        Query("SELECT * FROM student WHERE LRN = '" & txtStudNum.Text & "'")

        If ds.Tables("QueryTb").Rows.Count > 0 Then
            With ds.Tables("QueryTb").Rows(0)
                cmbStudType.SelectedValue = .Item(1)
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
                DtpBday.Value = .Item(9).ToString
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
            Clear()
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
        If IS_EMPTY(txtStudAge) Then Return
        If IS_EMPTY(txtGuardianName) Then Return
        If IS_EMPTY(txtGuardianRelation) Then Return
        If IS_EMPTY(txtGuardianContact) Then Return
#End Region


        If Not NoLeadingSpace(txtStudLname.Text.Trim()) Then
            MsgBox("Student last name must have no leading spaces.")
            Return
        ElseIf Not NoLeadingSpace(txtStudFname.Text.Trim()) Then
            MsgBox("Student first name must have no leading spaces.")
            Return
        ElseIf Not NoLeadingSpace(txtAddress.Text.Trim()) Then
            MsgBox("Address must have no leading spaces.")
            Return
        End If
        ClassStudents.StudRef()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ClassStudents.StudUpdate()
    End Sub
    Private Sub CalculateAge()
        Dim birthdate As Date = DtpBday.Value.Date
        Dim currentDate As Date = Date.Today
        Dim age As Integer = currentDate.Year - birthdate.Year
        If (birthdate.Month > currentDate.Month) OrElse (birthdate.Month = currentDate.Month AndAlso birthdate.Day > currentDate.Day) Then
            age -= 1
        End If

        txtStudAge.Text = age.ToString()
    End Sub

    Private Sub DtpBday_ValueChanged(sender As Object, e As EventArgs) Handles DtpBday.ValueChanged
        CalculateAge()
    End Sub
    Private Sub CmbStudType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudType.SelectedIndexChanged
        If cmbStudType.SelectedItem IsNot Nothing Then
            LoadRequirements()
        End If
    End Sub

    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudNum.KeyPress, txtGuardianContact.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudLname.KeyPress, txtStudFname.KeyPress, txtStudMI.KeyPress, txtCitizenship.KeyPress, txtFatherName.KeyPress, txtFatherOccupation.KeyPress, txtMother.KeyPress, txtMotherMaidenName.KeyPress, txtMotherOccupation.KeyPress, txtGuardianName.KeyPress, txtGuardianRelation.KeyPress
        If Not IsValidInput(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
    Private Sub TextBoxAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        If Not isValidAddress(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

End Class