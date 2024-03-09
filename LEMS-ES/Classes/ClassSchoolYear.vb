Imports MySql.Data.MySqlClient
Public Class ClassSchoolYear
#Region "SYparam"
    Public Shared Function SchoolYearParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmSY.idSY),
                    New MySqlParameter("@SchoolYear", frmSY.txtAddSY.Text)
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
                    Command("UPDATE schoolyear SET Status = 'Closed' WHERE ID = (SELECT MAX(ID) FROM schoolyear)", New MySqlParameter() {})
                    Command("INSERT INTO schoolyear(SchoolYear) VALUES (@SchoolYear)", dynamicParams)
                    Success("Successfully Added!")
                End If
            ElseIf isOpen Then
                If MsgBox("Do you want to close it?", vbQuestion + vbYesNo) = vbYes Then
                    Dim closeParams() As MySqlParameter = {New MySqlParameter()}
                    Command("UPDATE schoolyear SET Status = 'Closed' WHERE ID = (SELECT MAX(ID) FROM schoolyear)", closeParams)
                    MsgBox("School Year is Closed.")
                End If
            Else
                MsgBox("You cannot close the current school year without having another one open.")
                Exit Sub
            End If
            frmSY.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("School year already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
