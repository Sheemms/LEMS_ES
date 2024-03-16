Public Class frmStudents
    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        '
        loadrecords()
    End Sub
    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        frmStudentRegistration.Show()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM student")
        dgvStudents.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub dgvStudents_DoubleClick(sender As Object, e As EventArgs) Handles dgvStudents.DoubleClick
        If dgvStudents.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvStudents.SelectedRows(0)

            Dim studID As String = selectedRow.Cells("colLRN").Value.ToString()
            'Dim studType As String = selectedRow.Cells("colStudType").Value.ToString()
            Dim studLname As String = selectedRow.Cells("colLastname").Value.ToString()
            Dim studFname As String = selectedRow.Cells("colFirstname").Value.ToString()
            Dim studMname As String = selectedRow.Cells("colMName").Value.ToString()
            Dim studSuffix As String = selectedRow.Cells("colSuffix").Value.ToString()
            Dim studGender As String = selectedRow.Cells("colGender").Value.ToString()
            Dim studAge As String = selectedRow.Cells("colAge").Value.ToString()
            Dim studBday As String = selectedRow.Cells("colBday").Value.ToString()
            Dim studMother As String = selectedRow.Cells("colMother").Value.ToString()
            Dim studMotherOcc As String = selectedRow.Cells("colMotherOcc").Value.ToString()
            Dim studFather As String = selectedRow.Cells("colFather").Value.ToString()
            Dim studFatherOcc As String = selectedRow.Cells("colFatherOcc").Value.ToString()

            frmStudentsView.txtStudNum.Text = studID
            'frmStudentsView.cmbStudType.ValueMember = studType
            frmStudentsView.txtStudLname.Text = studLname
            frmStudentsView.txtStudFname.Text = studFname
            frmStudentsView.txtStudMname.Text = studMname
            frmStudentsView.txtStudSuffix.Text = studSuffix
            frmStudentsView.cmbStudGender.Text = studGender
            frmStudentsView.txtStudAge.Text = studAge
            frmStudentsView.dtpBday.Value = studBday
            frmStudentsView.txtMother.Text = studMother
            frmStudentsView.txtMotherOccupation.Text = studMotherOcc
            frmStudentsView.txtFatherName.Text = studFather
            frmStudentsView.txtFatherOccupation.Text = studFatherOcc

            frmStudentsView.Show()
        End If
    End Sub
End Class