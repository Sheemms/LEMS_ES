Imports MySql.Data.MySqlClient
Public Class FrmSY
    Public idSY As Integer = 0
    Private Sub FrmSY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Clear()
        TxtEndYear.Clear()
        idSY = 0
    End Sub
    Public Sub Loadrecords()
        Query("SELECT ID, CONCAT(Start_Year, '-', End_Year) SchoolYear, Status FROM schoolyear ORDER BY ID DESC ")
        DgvSY.DataSource = ds.Tables("QueryTb")
        TxtStartYear.Text = Year(Now)
    End Sub

    Private Sub BtnSaveSY_Click(sender As Object, e As EventArgs) Handles BtnSave.Click, BtnUpdate.Click
        If Not IsEmptyField(TxtEndYear.Text.Trim()) Then
            Info("Please enter the end year.")
            Return
        End If

        Dim endYear As Integer
        If Not Integer.TryParse(TxtEndYear.Text, endYear) Then
            Info("Invalid end year.")
            Return
        End If

        Dim currentYear As Integer = Year(Now)
        If endYear < currentYear OrElse endYear > currentYear + 1 Then
            Info("End year should be between " & currentYear & " and " & (currentYear + 1) & ".")
            Return
        End If

        ClassSchoolYear.SchoolYearRef()
    End Sub

    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEndYear.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub DgvSY_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSY.CellContentClick
        Dim column As String = DgvSY.Columns(e.ColumnIndex).Name

        If e.RowIndex >= 0 Then
            Dim syID As String = DgvSY.Rows(e.RowIndex).Cells("ID").Value.ToString()

            If column = "colOpen" Then
                Dim isActive As Boolean = Convert.ToBoolean(CmdScalarwithParam("SELECT COUNT(*) FROM schoolyear WHERE ID=@ID AND Status = 'Active'", New MySqlParameter("@ID", syID)))

                If isActive Then
                    Info("This school year is already active.")
                    Return
                End If

                If MsgBox("Do you want to open this school year?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        Command("UPDATE schoolyear SET Status = 'Inactive'")

                        Command("UPDATE schoolyear SET Status = 'Active' WHERE ID=@ID", New MySqlParameter("@ID", syID))

                        Success("School Year has been successfully opened!")
                        Loadrecords()
                    Catch ex As Exception
                        Critical("Error: " & ex.Message)
                    End Try
                End If

            ElseIf column = "colClose" Then
                Dim isActive As Boolean = Convert.ToBoolean(CmdScalarwithParam("SELECT COUNT(*) FROM schoolyear WHERE ID=@ID AND Status = 'Active'", New MySqlParameter("@ID", syID)))

                If Not isActive Then
                    Info("This school year is not active and cannot be closed.")
                    Return
                ElseIf isActive Then
                    Info("There is no active school year to close.")
                    Return
                End If

                If MsgBox("Do you want to close this school year?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        Command("UPDATE schoolyear SET Status = 'Inactive' WHERE ID=@ID", New MySqlParameter("@ID", syID))

                        Success("School Year has been successfully closed!")
                        Loadrecords()
                    Catch ex As Exception
                        Critical("Error: " & ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub
End Class