Imports MySql.Data.MySqlClient
Module Mod_Conn
    Public con As New MySqlConnection("server=localhost;user id=root;password=;database=lems_es")
    Public cmd As New MySqlCommand
    Public adp As New MySqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Public dr As MySqlDataReader
    Public userID As Integer
    Public Sub Connection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub Query(ByVal QueryStatement As String)
        Try
            adp = New MySqlDataAdapter(QueryStatement, con)
            ds = New DataSet
            adp.Fill(ds, "QueryTb")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Command(ByVal CommandStatement As String, ParamArray dynamicParam() As MySqlParameter)
        cmd = New MySqlCommand(CommandStatement, con)
        cmd.Parameters.AddRange(dynamicParam)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
    End Sub
    Sub LogAction(ByVal plog As String)
        Try
            Command("INSERT INTO AuditTrail (UserID, Description) VALUES (@UserID, @Description)",
                    New MySqlParameter("@UserID", userID),
                    New MySqlParameter("@Description", plog))
        Catch ex As Exception
            MsgBox("Error logging action: " & ex.Message, vbCritical)
        End Try
    End Sub
End Module
