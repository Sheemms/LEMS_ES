﻿Public Class FrmRoom
    Public idRoom As Integer = 0
    Private Sub FrmRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT * FROM room")
        DgvRoom.DataSource = ds.Tables("QueryTb")
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
        If IS_EMPTY(TxtRoom) = True Then Return

        ClassRoom.RoomRef()
        ClearFields(Me, idRoom)
    End Sub
End Class