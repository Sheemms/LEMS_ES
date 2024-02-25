Imports MySql.Data.MySqlClient
Module Mod_Conn
    Public con As New MySqlConnection("server=localhost;user id=root;password=;database=lems_es")
    Public cmd As New MySqlCommand
    Public adp As New MySqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Public dr As MySqlDataReader
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
    Public Sub RemovePanel()
        frmCharts.Close()
        frmEnrollment.Close()
        frmStudents.Close()
        frmTeachers.Close()
        frmBilling.Close()
        frmReports.Close()
        frmMaintenance.Close()
    End Sub
    Public Sub MaintenanceRemovePanel()
        frmTeacherMaintenance.Close()
        frmRequirements.Close()
        frmSubjects.Close()
        frmSections.Close()
        frmGradeLevel.Close()
        frmRequirements.Close()
        frmSY.Close()
        frmMiscellaneous.Close()
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

End Module
