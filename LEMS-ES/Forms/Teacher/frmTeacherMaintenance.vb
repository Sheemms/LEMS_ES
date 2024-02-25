Public Class frmTeacherMaintenance
    Public idTeacher As Integer = 0
    Private Sub frmTeacherMaintenance_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT ID, EmpID, CONCAT(Lastname, ', ', Firstname, ' ', Middlename) AS Fullname, Birthday, Contact, Address FROM teacher")
        dgvTeacher.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        idTeacher = 0
        txtEmpID.Clear()
        txtLastname.Clear()
        txtFirstname.Clear()
        txtMiddlename.Clear()
        txtBday.Clear()
        txtContact.Clear()
        txtAddress.Clear()
    End Sub
    Private Sub dgvTeacher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeacher.CellClick
        Try
            For Each row As DataGridViewRow In dgvTeacher.SelectedRows
                idTeacher = row.Cells(0).Value
                txtEmpID.Text = row.Cells(1).Value
                Dim fullName As String = row.Cells(2).Value.ToString()
                Dim names() As String = fullName.Split(" "c)
                If names.Length >= 1 Then txtLastname.Text = names(0)
                If names.Length >= 2 Then txtFirstname.Text = names(1)
                If names.Length >= 3 Then txtMiddlename.Text = names(2)
                txtBday.Text = row.Cells(3).Value
                txtContact.Text = row.Cells(4).Value
                txtAddress.Text = row.Cells(5).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
#Region "IS_EMPTY"
        If IS_EMPTY(txtEmpID) = True Then Return
        If IS_EMPTY(txtLastname) = True Then Return
        If IS_EMPTY(txtFirstname) = True Then Return
        If IS_EMPTY(txtMiddlename) = True Then Return
        If IS_EMPTY(txtBday) = True Then Return
        If IS_EMPTY(txtContact) = True Then Return
        If IS_EMPTY(txtAddress) = True Then Return
#End Region

        ClassTeacher.TeacherRef()
        clear()
    End Sub

    Private Sub btnClearUserMaintenance_Click(sender As Object, e As EventArgs) Handles btnClearUserMaintenance.Click
        clear()
    End Sub
End Class