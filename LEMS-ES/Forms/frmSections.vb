Public Class frmSections
    Public idSection As Integer = 0
    Private Sub frmSections_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        loadrecords()
    End Sub
    Public Sub loadrecords()
        Query("SELECT * FROM section")
        dgvSection.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub clear()
        txtSectionName.Clear()
        txtSectionCapacity.Clear()
    End Sub
    Private Sub dgvSection_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSection.CellClick
        Try
            For Each row As DataGridViewRow In dgvSection.SelectedRows
                idSection = row.Cells(0).Value
                txtSectionName.Text = row.Cells(1).Value
                txtSectionCapacity.Text = row.Cells(2).Value
            Next
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub btnSaveSubject_Click(sender As Object, e As EventArgs) Handles btnSaveSubject.Click
        If IS_EMPTY(txtSectionName) = True Then Return
        If IS_EMPTY(txtSectionCapacity) = True Then Return

        Query("SELECT * FROM section WHERE SectionRoom= '" & txtSectionName.Text & "' and ID <> '" & idSection & "'")
        If ds.Tables("QueryTb").Rows.Count > 0 Then
            Critical("Room already exist")
            Exit Sub
        End If

        ClassSection.SectionRef()
        Success("Successfully Added!")
        loadrecords()
        clear()
    End Sub

    Private Sub btnClearSubject_Click(sender As Object, e As EventArgs) Handles btnClearSubject.Click
        clear()
    End Sub


End Class