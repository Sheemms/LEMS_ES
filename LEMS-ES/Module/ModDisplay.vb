Module ModDisplay
    Public Function IS_EMPTY(ByVal ptext As Object) As Boolean
        If ptext.text = String.Empty Then
            ptext.backcolor = Color.LemonChiffon
            ptext.focus
            Critical("Required Missing Field!")
            IS_EMPTY = True
        Else
            ptext.backcolor = Color.White
            IS_EMPTY = False
        End If
    End Function
    Public Sub RemovePanel()
        frmCharts.Close()
        frmEnrollment.Close()
        frmSchedule.Close()
        frmPayment.Close()
        frmStudents.Close()
        frmTeachers.Close()
        frmBilling.Close()
        frmReports.Close()
        frmMaintenance.Close()
    End Sub
    Public Sub MaintenanceRemovePanel()
        frmTeacherMaintenance.Close()
        frmDepartment.Close()
        frmRequirements.Close()
        frmSubjects.Close()
        frmSections.Close()
        frmGradeLevel.Close()
        frmRequirements.Close()
        frmSY.Close()
        frmTuitionFee.Close()
        frmUserMaintenance.Close()
        frmAuditTrail.Close()
    End Sub
    Public Sub Critical(ByVal MessageStatement As String)
        MsgBox(MessageStatement, MsgBoxStyle.Critical, "LEMS_ES")
    End Sub
    Public Sub Success(ByVal MessageStatement As String)
        MsgBox(MessageStatement, MsgBoxStyle.OkOnly, "LEMS_ES")
    End Sub

    Public Sub TextBoxOnlyLetters(ByVal textBox As Guna.UI2.WinForms.Guna2TextBox)
        AddHandler textBox.KeyPress, AddressOf TextBoxLetters_KeyPress
    End Sub
    Private Sub TextBoxLetters_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Public Sub TextBoxDigitsOnly(ByVal textBox As Guna.UI2.WinForms.Guna2TextBox)
        AddHandler textBox.KeyPress, AddressOf TextBoxDigits_Keypress
    End Sub
    Private Sub TextBoxDigits_Keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Module
