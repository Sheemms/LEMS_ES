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
        frmElementaryGrading.Close()
        frmJHSGrading.Close()
        frmMaintenance.Close()
        frmReports.Close()

    End Sub
    Public Sub MaintenanceRemovePanel()
        frmEnrollmentRegistration.Close()
        frmPayments.Close()
        frmTeacherMaintenance.Close()
        frmStudentsView.Close()
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

    Public Sub GetSchoolYear(ByVal lblSY As Label)
        Try
            Query("SELECT Start_Year, End_Year FROM schoolyear WHERE Status = 'Open'")
            Dim result As Object = CmdScalar("SELECT COUNT(*) FROM schoolyear WHERE Status = 'Open'")
            If result IsNot Nothing Then
                Dim startYear As String = ds.Tables("QueryTb").Rows(0)("Start_Year").ToString()
                Dim endYear As String = ds.Tables("QueryTb").Rows(0)("End_Year").ToString()
                lblSY.Text = startYear & " - " & endYear
            Else
                lblSY.Text = "No open school year found"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
