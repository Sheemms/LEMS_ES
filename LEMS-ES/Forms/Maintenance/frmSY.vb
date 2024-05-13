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
        If IS_EMPTY(TxtEndYear) = True Then Return
        Dim endYear As Integer
        If Not Integer.TryParse(TxtEndYear.Text, endYear) Then
            MsgBox("Invalid end year.")
            Return
        End If

        Dim currentYear As Integer = Year(Now)
        If endYear < currentYear OrElse endYear > currentYear + 1 Then
            MsgBox("End year should be between " & currentYear & " and " & (currentYear + 1) & ".")
            Return
        End If

        ClassSchoolYear.SchoolYearRef()
        Clear()
    End Sub

    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEndYear.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub

    Private Sub DgvSY_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSY.CellContentClick
        Dim column As String = DgvSY.Columns(e.ColumnIndex).Name
        Dim isOpen As Boolean = Convert.ToBoolean(CmdScalar("SELECT COUNT(*) FROM schoolyear WHERE Status = 'Active'"))
        If column = "colOpen" AndAlso e.RowIndex >= 0 Then
            If MsgBox("Do you want to open this school year?") Then
                Try
                    Dim syID As String = DgvSY.Rows(e.RowIndex).Cells("ID").Value.ToString()
                    Command("UPDATE schoolyear SET Status = 'Inactive'", New MySqlParameter() {})
                    Command("UPDATE schoolyear SET Status = 'Active' WHERE ID=" & syID)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MsgBox("School Year has been successfully open!")
                        Loadrecords()
                    Else
                        MsgBox("There is no active school year.")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf column = "colClose" AndAlso e.RowIndex >= 0 Then
            If MsgBox("Do you want to close this school year?") Then
                Try
                    Dim syID As String = DgvSY.Rows(e.RowIndex).Cells("ID").Value.ToString()

                    Command("UPDATE schoolyear SET Status = 'Inactive' WHERE ID=" & syID)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MsgBox("School Year has been successfully closed!")
                        Loadrecords()
                    Else
                        MsgBox("There is no inactive school year.")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

End Class