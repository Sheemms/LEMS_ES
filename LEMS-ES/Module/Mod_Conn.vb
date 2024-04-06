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
        Try
            cmd = New MySqlCommand(CommandStatement, con)
            cmd.Parameters.AddRange(dynamicParam)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Catch ex As Exception
            MsgBox("Error executing command: " & ex.Message)
        End Try
    End Sub
    Public Function CmdScalar(ByVal ScalarStatement As String)
        Try
            cmd = New MySqlCommand(ScalarStatement, con)
            Dim scalar As Object = cmd.ExecuteScalar()
            Return scalar
        Catch ex As Exception
            MsgBox("Error executing scalar query: " & ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function ExecuteReader(ByVal query As String) As MySqlDataReader
        Try
            Dim reader As MySqlDataReader
            cmd = New MySqlCommand(query, con)
            reader = cmd.ExecuteReader()
            Return reader
        Catch ex As Exception
            MsgBox("Error executing query: " & ex.Message)
            Return Nothing
        End Try
    End Function
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
