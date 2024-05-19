Imports MySql.Data.MySqlClient
Module Mod_Conn
    Public con As New MySqlConnection(My.Settings.Conn_String)
    Public cmd As New MySqlCommand
    Public adp As New MySqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Public dr As MySqlDataReader
    Public userID As Integer
    Public str_user As String
    Public str_password As String
    Public str_role As String
    Public str_name As String
    Public pbox As Image

    Public Sub Connection()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As mysqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Query(ByVal QueryStatement As String)
        adp = New MySqlDataAdapter(QueryStatement, con)
        ds = New DataSet
        adp.Fill(ds, "QueryTb")
    End Sub
    Public Function QueryWithParams(ByVal query As String, ByVal ParamArray parameters() As MySqlParameter) As DataTable
        Dim dataTable As New DataTable()
        Dim connection As New MySqlConnection(My.Settings.Conn_String)
        Dim command As New MySqlCommand(query, connection)
        Try
            command.Parameters.AddRange(parameters)
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dataTable)
        Catch ex As Exception
            ' Handle the exception (e.g., log error, display message)
            MsgBox("Error executing parameterized query: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            command.Dispose()
            connection.Dispose()
        End Try
        Return dataTable
    End Function

    Public Sub Command(ByVal CommandStatement As String, ParamArray dynamicParam() As MySqlParameter)
        cmd = New MySqlCommand(CommandStatement, con)
        cmd.Parameters.AddRange(dynamicParam)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
    End Sub
    Public Sub OtherCommand(ByVal CommandStatement As String)
        cmd = New MySqlCommand(CommandStatement, con)
        cmd.ExecuteNonQuery()
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
    Public Function CmdScalarwithParam(ByVal ScalarStatement As String, ParamArray parameters() As MySqlParameter) As Object
        Try
            Dim cmd As New MySqlCommand(ScalarStatement, con)
            cmd.Parameters.AddRange(parameters)
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
            MsgBox("Audit Trail: " & ex.Message, vbCritical)
        End Try
    End Sub
End Module
