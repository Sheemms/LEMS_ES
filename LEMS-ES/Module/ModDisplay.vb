Imports System.Text.RegularExpressions
Imports Guna.UI2.WinForms

Module ModDisplay
    Public Function IsEmptyField(input As String) As Boolean
        Dim regex As New Regex("^.+$")
        Return regex.IsMatch(input)
    End Function

    Public Sub ClearFields(ByVal form As Form, ByRef id As Integer)
        For Each ctrl As Control In form.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is Guna2TextBox Then
                DirectCast(ctrl, Guna2TextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox OrElse TypeOf ctrl Is Guna2ComboBox Then
                Dim cmbBox As ComboBox = TryCast(ctrl, ComboBox)
                Dim cmbGuna2Box As Guna2ComboBox = TryCast(ctrl, Guna2ComboBox)
                If cmbBox IsNot Nothing Then
                    cmbBox.SelectedIndex = -1
                ElseIf cmbGuna2Box IsNot Nothing Then
                    cmbGuna2Box.SelectedIndex = -1
                End If
            ElseIf TypeOf ctrl Is CheckBox OrElse TypeOf ctrl Is Guna2CheckBox Then
                Dim chkBox As CheckBox = TryCast(ctrl, CheckBox)
                Dim chkGuna2Box As Guna2CheckBox = TryCast(ctrl, Guna2CheckBox)
                If chkBox IsNot Nothing Then
                    chkBox.Checked = False
                ElseIf chkGuna2Box IsNot Nothing Then
                    chkGuna2Box.Checked = False
                End If
            ElseIf TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False
            ElseIf TypeOf ctrl Is DataGridView Then
                DirectCast(ctrl, DataGridView).ClearSelection()
            ElseIf TypeOf ctrl Is Guna2DataGridView Then
                DirectCast(ctrl, Guna2DataGridView).ClearSelection()
            End If
        Next
        id = 0
    End Sub

    Public Sub RemovePanel()
        FrmCharts.Close()
        FrmEnrollment.Close()
        FrmSchedule.Close()
        FrmBillingRecords.Close()
        FrmStudents.Close()
        FrmTeachers.Close()
        FrmBilling.Close()
        FrmPayments.Close()
        FrmFee.Close()
        FrmElementaryGrading.Close()
        FrmJHSGrading.Close()
        FrmMaintenance.Close()
        frmReports.Close()
    End Sub
    Public Sub MaintenanceRemovePanel()
        FrmEnrollmentRegistration.Close()
        FrmTeacherMaintenance.Close()
        FrmStudentsView.Close()
        FrmDepartment.Close()
        FrmRequirements.Close()
        FrmSubjects.Close()
        FrmSections.Close()
        FrmRoom.Close()
        FrmGradeLevel.Close()
        FrmRequirements.Close()
        FrmSY.Close()
        FrmTuitionFee.Close()
        FrmUserMaintenance.Close()
        FrmAuditTrail.Close()
    End Sub
    Public Sub Critical(ByVal MessageStatement As String)
        MsgBox(MessageStatement, MsgBoxStyle.Critical, "LEMSEJHS_CES")
    End Sub
    Public Sub Success(ByVal MessageStatement As String)
        MsgBox(MessageStatement, MsgBoxStyle.OkOnly, "LEMSEJHS_CES")
    End Sub
    Public Sub Info(ByVal messagestatement As String)
        MsgBox(messagestatement, MsgBoxStyle.Information, "LEMSEJHS_CES")
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
            Query("SELECT Start_Year, End_Year FROM schoolyear WHERE Status = 'Active'")
            Dim result As Object = CmdScalar("SELECT COUNT(*) FROM schoolyear WHERE Status = 'Active'")
            If result IsNot Nothing Then
                Dim startYear As String = ds.Tables("QueryTb").Rows(0)("Start_Year").ToString()
                Dim endYear As String = ds.Tables("QueryTb").Rows(0)("End_Year").ToString()
                lblSY.Text = startYear & "-" & endYear
            Else
                lblSY.Text = "0000-0000"
            End If
        Catch ex As Exception
            MsgBox("No open school year found")
        End Try
    End Sub
    Public Function GetSchoolYearID() As Integer
        Try
            Query("SELECT ID FROM schoolyear WHERE Status = 'Active'")

            If ds.Tables("QueryTb").Rows.Count > 0 Then
                Dim schoolYearID As Integer = Convert.ToInt32(ds.Tables("QueryTb").Rows(0)("ID"))
                Return schoolYearID
            Else
                Return -1
            End If
        Catch ex As Exception
            MsgBox("Error getting school year ID: " & ex.Message)
            Return -1
        End Try
    End Function

    Public Function IsValidTime(timeString As String) As Boolean
        Dim regex As New Regex("^([01]?[0-9]|2[0-3]):[0-5][0-9]$")

        Return regex.IsMatch(timeString)
    End Function
    Public Function IsValidInput(inputChar As Char) As Boolean
        Dim regexPattern As String = "^[a-zA-Z\s]*$"

        If Not Regex.IsMatch(inputChar.ToString(), regexPattern) AndAlso Not Char.IsControl(inputChar) Then
            Return False
        End If

        Return True
    End Function
    Public Function IsValidAddress(inputAddress As Char) As Boolean
        Dim regexPattern As String = "^[a-zA-Z0-9\s\.,#-]+$"

        If Not Regex.IsMatch(inputAddress.ToString(), regexPattern) AndAlso Not Char.IsControl(inputAddress) Then
            Return False
        End If

        Return True
    End Function
    Public Function IsValidDigits(inputDigits As Char) As Boolean
        Dim regexPattern As String = "^\d+$"

        If Not Regex.IsMatch(inputDigits.ToString(), regexPattern) AndAlso Not Char.IsControl(inputDigits) Then
            Return False
        End If

        Return True
    End Function
    Public Function IsValidLettersDigits(input As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9\s]+$"
        Return Regex.IsMatch(input, pattern)
    End Function
    Public Function IsValidAmount(inputAmount As String) As Boolean
        Dim regex As New Regex("^(100000(\.0{1,2})?|[0-9]{1,5}(\.[0-9]{1,2})?)$")
        Return regex.IsMatch(inputAmount)
    End Function
    Public Function NoLeadingSpace(input As String) As Boolean
        Dim regex As New Regex("^\S+( \S+)*$")
        Return regex.IsMatch(input)
    End Function
    Public Function SpacebetweenLetters(input As String) As Boolean
        Dim regex As New Regex("^[^\s]+(?:\s[^\s]+)*$")
        Return regex.IsMatch(input)
    End Function
End Module
