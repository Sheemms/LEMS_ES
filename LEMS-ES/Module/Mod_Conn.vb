Imports MySql.Data.MySqlClient
Module Mod_Conn
    Public con As New MySqlConnection("server=localhost;user id=root;password=;database=lems_es")
    Public cmd As New MySqlCommand
    Public adp As New MySqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
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
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function IS_EMPTY(ByVal ptext As Object) As Boolean
        If ptext.text = String.Empty Then
            ptext.backcolor = Color.LemonChiffon
            ptext.focus
            MsgBox("Required Missing Field!", vbCritical)
            IS_EMPTY = True
        Else
            ptext.backcolor = Color.White
            IS_EMPTY = False
        End If
    End Function
    Public Sub RemovePanel()
        frmEnrollment.Close()
        frmStudents.Close()
        frmTeachers.Close()
    End Sub
    Public Sub MaintenanceRemovePanel()
        frmRequirements.Close()
        frmSubjects.Close()
        frmSections.Close()
        frmUserMaintenance.Close()
        frmSY.Close()
        frmMiscellaneous.Close()
        frmTuitionFee.Close()
        frmAuditTrail.Close()
    End Sub
    Public Sub Critical(ByVal MessageStatement As String)
        MsgBox(MessageStatement, MsgBoxStyle.Critical, "LEMS_ES")
    End Sub
    Public Sub Success(ByVal MessageStatement As String)
        MsgBox(MessageStatement, MsgBoxStyle.OkOnly, "LEMS_ES")
    End Sub


    Public Function SchoolYearParameters(row As DataGridViewRow) As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", If(row.Cells(0).Value Is Nothing Or IsDBNull(row.Cells(0).Value), "", row.Cells(0).Value)),
                    New MySqlParameter("@SchoolYear", If(row.Cells(1).Value Is Nothing Or IsDBNull(row.Cells(1).Value), "", row.Cells(1).Value))
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Sub SchoolYearRef()
        For Each row As DataGridViewRow In frmSY.dgvSY.Rows
            If Not row.IsNewRow Then
                Dim dynamicParams As MySqlParameter() = SchoolYearParameters(row)
                If row.Cells(0).Value IsNot Nothing AndAlso Not IsDBNull(row.Cells(0).Value) Then
                    Command("UPDATE schoolyear SET SchoolYear = @SchoolYear WHERE ID = @ID", dynamicParams)
                ElseIf row.Cells(0).Value Is Nothing Or IsDBNull(row.Cells(0).Value) Then
                    Command("INSERT INTO schoolyear (ID, SchoolYear) VALUES (@ID, @SchoolYear)", dynamicParams)
                End If
            End If
        Next
    End Sub
End Module
