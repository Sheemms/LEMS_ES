Imports Guna.UI2.WinForms

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

    Public Sub ClearFields(ByVal form As Form, ByRef id As Integer)
        For Each ctrl As Control In form.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is Guna2TextBox Then
                DirectCast(ctrl, Guna2TextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cmbBox As ComboBox = DirectCast(ctrl, ComboBox)
                cmbBox.SelectedIndex = -1
            ElseIf TypeOf ctrl Is Guna2ComboBox Then
                Dim cmbBox As Guna2ComboBox = DirectCast(ctrl, Guna2ComboBox)
                cmbBox.SelectedIndex = -1
            ElseIf TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False
            ElseIf TypeOf ctrl Is Guna2CheckBox Then
                DirectCast(ctrl, Guna2CheckBox).Checked = False
            ElseIf TypeOf ctrl Is DataGridView Then
                DirectCast(ctrl, DataGridView).ClearSelection()
            ElseIf TypeOf ctrl Is Guna2DataGridView Then
                DirectCast(ctrl, Guna2DataGridView).ClearSelection()
            ElseIf TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False
            ElseIf TypeOf ctrl Is Guna2CheckBox Then
                DirectCast(ctrl, Guna2CheckBox).Checked = False
            End If
        Next
        id = 0
    End Sub
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

    Public Function EIDGenerate() As String
        Try
            Dim eidvalue As String
            Query("Select ID from enrollment order by ID DESC LIMIT 1")
            If ds.Tables("QueryTb").Rows.Count = 0 Then
                eidvalue = "EID" & Format(Now, "yyyyMMdd") & "001"
            Else
                eidvalue = "EID" & Format(Now, "yyyyMMdd") & "00" & (ds.Tables("QueryTb").Rows(0)(0) + 1)
            End If
            Return eidvalue
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function ORNOGenerate() As String
        Try
            Dim orvalue As String
            Query("Select ID from payment order by ID DESC LIMIT 1")
            If ds.Tables("QueryTb").Rows.Count = 0 Then
                orvalue = "ORNO" & Format(Now, "yyyyMMdd") & "001"
            Else
                orvalue = "ORNO" & Format(Now, "yyyyMMdd") & "00" & (ds.Tables("QueryTb").Rows(0)(0) + 1)
            End If
            Return orvalue
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Sub GetSchoolYear(ByVal lblSY As Label)
        Try
            Query("SELECT Start_Year, End_Year FROM schoolyear WHERE Status = 'Open'")
            Dim result As Object = CmdScalar("SELECT COUNT(*) FROM schoolyear WHERE Status = 'Open'")
            If result IsNot Nothing Then
                Dim startYear As String = ds.Tables("QueryTb").Rows(0)("Start_Year").ToString()
                Dim endYear As String = ds.Tables("QueryTb").Rows(0)("End_Year").ToString()
                lblSY.Text = startYear & "-" & endYear
            Else
                lblSY.Text = "No open school year found"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
