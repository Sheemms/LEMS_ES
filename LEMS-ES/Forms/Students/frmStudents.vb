Public Class frmStudents
    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        frmStudentsView.Show()
    End Sub
    Public Sub loadrecords()
        Query("SELECT ID, StudType, LRN, CONCAT(Lastname, ' ', Firstname, ' ', MiddleInitial) AS Fullname, Suffix, Gender, Age, Birthday, Address, 
                MotherName, MothersMaiden, Mother_Occupation, FatherName, Father_Occupation, GuardianName, GuardianContact, Citizenship
                FROM student")
        dgvStudents.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub dgvStudents_DoubleClick(sender As Object, e As EventArgs) Handles dgvStudents.DoubleClick
        If dgvStudents.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvStudents.SelectedRows(0)
            Dim studID As Integer = Convert.ToInt32(selectedRow.Cells("colID").Value)

            Query("SELECT rq.ID, reqclass.Classification, rq.Requirement, IF(sr.ID IS NOT NULL, 1, 0) AS IsSubmitted
            FROM requirements rq
            JOIN req_classification reqclass ON rq.Classification_ID = reqclass.ID
            LEFT JOIN submitted_requirements sr ON rq.ID = sr.RequirementID AND sr.StudentID = " & studID)
            frmStudentsView.dgvRequirements.DataSource = ds.Tables("QueryTb")

            For Each row As DataGridViewRow In frmStudentsView.dgvRequirements.Rows
                Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("IsSubmitted").Value)
                row.Cells("colCheckBox").Value = isChecked
            Next

            Dim studLRN As String = selectedRow.Cells("colLRN").Value.ToString()
            Dim studType As String = selectedRow.Cells("colStudType").Value.ToString()
            Dim studFullname As String = selectedRow.Cells("colStudName").Value.ToString()
            Dim nameParts() As String = studFullname.Split(" "c)

            If nameParts.Length >= 1 Then
                frmStudentsView.txtStudLname.Text = nameParts(0) ' Lastname
            End If
            If nameParts.Length >= 2 Then
                frmStudentsView.txtStudFname.Text = nameParts(1) ' Firstname
            End If
            If nameParts.Length >= 3 Then
                frmStudentsView.txtStudMname.Text = nameParts(2) ' Middle Initial
            End If

            Dim studSuffix As String = selectedRow.Cells("colSuffix").Value.ToString()
            Dim studGender As String = selectedRow.Cells("colGender").Value.ToString()
            Dim studAge As String = selectedRow.Cells("colAge").Value.ToString()
            Dim studBday As String = selectedRow.Cells("colBday").Value.ToString()
            Dim studAddress As String = selectedRow.Cells("colAddress").Value.ToString()
            Dim studMother As String = selectedRow.Cells("colMother").Value.ToString()
            Dim studMothersMaiden As String = selectedRow.Cells("colMothersMaiden").Value.ToString()
            Dim studMotherOcc As String = selectedRow.Cells("colMotherOcc").Value.ToString()
            Dim studFather As String = selectedRow.Cells("colFather").Value.ToString()
            Dim studFatherOcc As String = selectedRow.Cells("colFatherOcc").Value.ToString()
            Dim studGuardianName As String = selectedRow.Cells("colGuardianName").Value.ToString()
            Dim studGuardianContact As String = selectedRow.Cells("colGuardianContact").Value.ToString()
            Dim studCitizenship As String = selectedRow.Cells("colCitizenship").Value.ToString()

            frmStudentsView.idStud = studID
            frmStudentsView.txtStudNum.Text = studLRN
            frmStudentsView.cmbStudType.ValueMember = studType
            frmStudentsView.cmbStudSuffix.Text = studSuffix
            If studGender = "Male" Then
                frmStudentsView.cbMale.Checked = True
            ElseIf studGender = "Female" Then
                frmStudentsView.cbFemale.Checked = True
            Else
                frmStudentsView.cbMale.Checked = False
                frmStudentsView.cbFemale.Checked = False
            End If
            frmStudentsView.txtStudAge.Text = studAge
            frmStudentsView.dtpBday.Value = studBday
            frmStudentsView.txtMother.Text = studMother
            frmStudentsView.txtMotherMaidenName.Text = studMothersMaiden
            frmStudentsView.txtMotherOccupation.Text = studMotherOcc
            frmStudentsView.txtFatherName.Text = studFather
            frmStudentsView.txtFatherOccupation.Text = studFatherOcc
            frmStudentsView.txtGuardianName.Text = studGuardianName
            frmStudentsView.txtGuardianContact.Text = studGuardianContact
            frmStudentsView.txtCitizenship.Text = studCitizenship

            frmStudentsView.Show()
        End If
    End Sub
End Class