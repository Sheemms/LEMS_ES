Public Class frmTeacherMaintenance
    Public idTeacher As Integer = 0
    Private Sub frmTeacherMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
        clear()
        TextBoxOnlyLetters(txtMiddleInitial)
    End Sub
    Public Sub loadrecords()
        Query("SELECT t.ID, t.EmpID, d.Department, CONCAT(t.Lastname, ', ', t.Firstname, ' ', t.MiddleInitial) AS Fullname, 
                t.Contact, t.Address 
                FROM teacher t
                JOIN department d ON t.Department_ID = d.ID")
        dgvTeacher.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM department")
        cmbDept.DataSource = ds.Tables("QueryTb")
        cmbDept.ValueMember = "ID"
        cmbDept.DisplayMember = "Department"
    End Sub
    Public Sub clear()
        idTeacher = 0
        txtEmpID.Clear()
        cmbDept.Text = ""
        txtLastname.Clear()
        txtFirstname.Clear()
        txtMiddleInitial.Clear()
        txtContact.Clear()
        txtAddress.Clear()
    End Sub
    Private Sub dgvTeacher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeacher.CellClick
        Try
            For Each row As DataGridViewRow In dgvTeacher.SelectedRows
                idTeacher = row.Cells(0).Value
                txtEmpID.Text = row.Cells(1).Value
                cmbDept.Text = row.Cells(2).Value
                Dim fullName As String = row.Cells(3).Value.ToString()
                Dim names() As String = fullName.Split(","c)
                If names.Length >= 1 Then txtLastname.Text = names(0)
                If names.Length >= 2 Then
                    Dim firstNameAndInitial() As String = names(1).Trim().Split(" "c)
                    txtFirstname.Text = firstNameAndInitial(0)
                    If firstNameAndInitial.Length >= 2 Then
                        txtMiddleInitial.Text = firstNameAndInitial(1)
                    End If
                End If
                txtContact.Text = row.Cells(4).Value
                txtAddress.Text = row.Cells(5).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
        clear()
    End Sub

    Private Sub btnClearUserMaintenance_Click(sender As Object, e As EventArgs)
        clear()
    End Sub

#Region "TextBoxValidation"
    Private Sub txtFirstname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstname.KeyPress, txtLastname.KeyPress, txtMiddleInitial.KeyPress
        TextBoxOnlyLetters(txtFirstname)
        TextBoxOnlyLetters(txtLastname)
        TextBoxOnlyLetters(txtMiddleInitial)
    End Sub

    Private Sub txtEmpID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpID.KeyPress, txtContact.KeyPress
        TextBoxDigitsOnly(txtEmpID)
        TextBoxDigitsOnly(txtContact)
    End Sub
#End Region
End Class