Imports MySql.Data.MySqlClient
Public Class ClassSchoolYear
#Region "SYparam"
    Public Shared Function SchoolYearParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmSY.idSY),
                    New MySqlParameter("@Start_Year", frmSY.TxtStartYear.Text),
                    New MySqlParameter("@End_Year", frmSY.TxtEndYear.Text)
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub SchoolYearRef()
        Try
            Dim isOpen As Boolean = Convert.ToBoolean(CmdScalar("SELECT COUNT(*) FROM schoolyear WHERE Status = 'Open'"))
            If frmSY.idSY = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Dim dynamicParams() As MySqlParameter = SchoolYearParameters()
                    Command("UPDATE schoolyear SET Status = 'Closed'", New MySqlParameter() {})
                    Command("INSERT INTO schoolyear(End_Year) VALUES (@End_Year)", dynamicParams)
                    Success("Successfully Added!")
                    Dim name As String = FrmSY.TxtStartYear.Text & " - " & FrmSY.TxtEndYear.Text
                    LogAction("Added School Year |" & name)
                End If
            ElseIf isOpen Then
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Dim closeParams() As MySqlParameter = SchoolYearParameters()
                    Command("UPDATE schoolyear SET Start_Year=@Start_Year, End_Year=@End_Year WHERE ID=@ID", closeParams)
                    MsgBox("School Year is updated.")
                End If
            Else
                MsgBox("You cannot close the current school year without having another one open.")
                Exit Sub
            End If
            FrmSY.Loadrecords()
        Catch ex As MySqlException
            Critical("School year already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
#End Region
End Class
