Public Class FrmRoom
    Public idRoom As Integer = 0
    Private Sub FrmRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT * FROM room")
        DgvRoom.DataSource = ds.Tables("QueryTb")
    End Sub
    Public Sub Clear()
        TxtRoom.Clear()
        TxtCapacity.Clear()
        idRoom = 0
    End Sub
    Private Sub DgvRoom_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRoom.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DgvRoom.Rows(e.RowIndex)
                idRoom = row.Cells(0).Value
                TxtRoom.Text = row.Cells(1).Value
                TxtCapacity.Text = row.Cells(2).Value
            ElseIf e.ColumnIndex >= 0 Then
                ClearFields(Me, idRoom)
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
            Exit Sub
        End Try
    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not IsEmptyField(TxtRoom.Text.Trim()) Then
            MsgBox("Please enter a room name.")
            Return
        End If
        If Not IsEmptyField(TxtCapacity.Text.Trim()) Then
            MsgBox("Please enter a room capacity.")
            Return
        End If

        If Not NoLeadingSpace(TxtRoom.Text.Trim()) Then
            MsgBox("Room name must have no leading spaces.")
            Return
        ElseIf Not NoLeadingSpace(TxtCapacity.Text.Trim()) Then
            MsgBox("Capacity must have no leading spaces.")
        End If
        ClassRoom.RoomRef()
        Clear()
    End Sub
    Private Sub TextBoxDigits_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCapacity.KeyPress
        If Not IsValidDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRoom.KeyPress
        If Not IsValidLettersDigits(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
    End Sub
End Class