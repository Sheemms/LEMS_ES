Public Class FrmTeacherMaintenance
    Public idTeacher As Integer = 0
    Private Sub FrmTeacherMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        LoadDept()
    End Sub
    Public Sub Clear()
        Dim textBoxes() As Guna.UI2.WinForms.Guna2TextBox = {txtEmpID, txtLastname, txtFirstname, txtMiddleInitial, txtContact,
            txtAddress}
        For Each textBox As Guna.UI2.WinForms.Guna2TextBox In textBoxes
            textBox.Clear()
        Next
        cmbDept.SelectedIndex = -1
        idTeacher = 0
    End Sub
    Public Sub LoadDept()
        Query("SELECT * FROM department")
        cmbDept.DataSource = ds.Tables("QueryTb")
        cmbDept.ValueMember = "ID"
        cmbDept.DisplayMember = "Department"
    End Sub
    Public Sub LoadTeacherData()
        Query("SELECT * FROM teacher WHERE EmpID = '" & txtEmpID.Text & "'")

        If ds.Tables("QueryTb").Rows.Count > 0 Then
            With ds.Tables("QueryTb").Rows(0)
                txtEmpID.Text = .Item(1)
                cmbDept.SelectedValue = .Item(2)
                txtLastname.Text = .Item(3)
                txtFirstname.Text = .Item(4)
                txtMiddleInitial.Text = .Item(5)
                txtContact.Text = .Item(6)
                txtAddress.Text = .Item(7)
            End With
        Else
            Clear()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
#Region "IsEmptyField"
        If Not IsEmptyField(txtEmpID.Text.Trim()) Then
            Info("Please enter a employee id.")
            Return
        End If
        If Not IsEmptyField(cmbDept.Text.Trim()) Then
            Info("Please select a department.")
            Return
        End If
        If Not IsEmptyField(txtLastname.Text.Trim()) Then
            Info("Please enter a lastname.")
            Return
        End If
        If Not IsEmptyField(txtFirstname.Text.Trim()) Then
            Info("Please enter a firstname.")
            Return
        End If
        If Not IsEmptyField(txtContact.Text.Trim()) Then
            Info("Please enter a contact.")
            Return
        End If
        If Not IsEmptyField(txtAddress.Text.Trim()) Then
            Info("Please enter a address.")
            Return
        End If
#End Region
        If Not NoLeadingSpace(txtLastname.Text.Trim()) Then
            Info("Lastname must have no multiple spaces between letters.")
            Return
        ElseIf Not NoLeadingSpace(txtFirstname.Text.Trim()) Then
            Info("Firstname must have no multiple spaces between letters.")
            Return
        ElseIf Not NoLeadingSpace(txtAddress.Text.Trim()) Then
            Info("Address must have no multiple spaces between letters and numbers.")
            Return
        End If
        ClassTeacher.TeacherRef()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Clear()
    End Sub

#Region "TextBoxValidation"
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastname.KeyPress, txtFirstname.KeyPress, txtMiddleInitial.KeyPress
        If Not IsValidInput(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
    Private Sub TextBoxAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        If Not IsValidAddress(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpID.KeyPress, txtContact.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
#End Region
End Class