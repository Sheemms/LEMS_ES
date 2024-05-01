Public Class FrmTeacherMaintenance
    Public idTeacher As Integer = 0
    Private Sub FrmTeacherMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
        ClearFields(Me, idTeacher)
        TextBoxOnlyLetters(txtMiddleInitial)
    End Sub
    Public Sub Clear()
        txtLastname.Clear()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT * FROM department")
        cmbDept.DataSource = ds.Tables("QueryTb")
        cmbDept.ValueMember = "ID"
        cmbDept.DisplayMember = "Department"
    End Sub
    Public Sub LoadStudentData()
        Query("SELECT * FROM teacher WHERE EmpID = '" & txtEmpID.Text & "'")
        With ds.Tables("QueryTb")
            txtLastname.Text = .Rows(0)(3)
            txtFirstname.Text = .Rows(0)(4)
            txtMiddleInitial.Text = .Rows(0)(5)
            txtContact.Text = .Rows(0)(6)
            txtAddress.Text = .Rows(0)(7)
        End With
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
#Region "IS_EMPTY"
        If IS_EMPTY(txtEmpID) = True Then Return
        If IS_EMPTY(cmbDept) = True Then Return
        If IS_EMPTY(txtLastname) = True Then Return
        If IS_EMPTY(txtFirstname) = True Then Return
        If IS_EMPTY(txtMiddleInitial) = True Then Return
        If IS_EMPTY(txtContact) = True Then Return
        If IS_EMPTY(txtAddress) = True Then Return
#End Region

        ClassTeacher.TeacherRef()
        ClearFields(Me, idTeacher)
    End Sub

    Private Sub BtnClearUserMaintenance_Click(sender As Object, e As EventArgs)
        ClearFields(Me, idTeacher)
    End Sub

#Region "TextBoxValidation"
    Private Sub TxtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress, txtLastname.KeyPress, txtMiddleInitial.KeyPress
        TextBoxOnlyLetters(txtFirstname)
        TextBoxOnlyLetters(txtLastname)
        TextBoxOnlyLetters(txtMiddleInitial)
    End Sub

    Private Sub TxtEmpID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpID.KeyPress, txtContact.KeyPress
        TextBoxDigitsOnly(txtEmpID)
        TextBoxDigitsOnly(txtContact)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()

    End Sub
#End Region
End Class