﻿Public Class FrmAuditTrail
    Private Sub FrmAuditTrail_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub LoadAudittrail()
        Try
            Query("SELECT * FROM audittrail")
            DgvAudittrail.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Sub Load_usertype()
        Try
            CmbUserLevel.Items.Clear()
            CmbUserLevel.Items.Add("All")
            OtherCommand("SELECT DISTINCT b.UserLevel 
                        FROM audittrail a
                        JOIN user b ON a.UserID = b.ID")
            dr = cmd.ExecuteReader
            While dr.Read
                CmbUserLevel.Items.Add(dr.Item("UserLevel").ToString)
            End While
            dr.Close()
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub Load_records(ByVal sql As String)
        Try
            Dim i As Integer
            DgvAudittrail.Rows.Clear()


            OtherCommand("SELECT a.ID, a.UserID, b.UserLevel, b.Fullname, a.Description, a.Time 
                        FROM audittrail a
                        JOIN user b ON a.UserID = b.ID")
            dr = cmd.ExecuteReader

            While dr.Read
                i += 1

                Dim formattedTime As String = DirectCast(dr.Item("Time"), DateTime).ToString("hh:mm tt")

                DgvAudittrail.Rows.Add(i, dr.Item("ID").ToString, dr.Item("UserID").ToString, dr.Item("UserLevel").ToString, dr.Item("Fullname").ToString, dr.Item("Description").ToString, formattedTime)
            End While
            dr.Close()
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Try
            If Not IsEmptyField(CmbUserLevel.Text.Trim()) Then
                MsgBox("Please select a user level.")
                Return
            End If

            Load_records("SELECT * FROM audittrail")

            If CmbUserLevel.Text = "All" And TxtSearch.Text = String.Empty Then
                Load_records("Select * from audittrail")
            ElseIf CmbUserLevel.Text = "All" And TxtSearch.Text.Length > 0 Then
                Load_records("Select * from audittrail where UserLevel  like '%" & TxtSearch.Text & "%'")
            ElseIf CmbUserLevel.Text <> "All" And TxtSearch.Text.Length = 0 Then
                Load_records("Select * from audittrail where UserLevel  like '" & CmbUserLevel.Text & "'")

            ElseIf CmbUserLevel.Text <> "All" And TxtSearch.Text.Length > 0 Then
                Load_records("Select * from audittrail where UserLevel like '" & CmbUserLevel.Text & "' and Description like '%" & TxtSearch.Text & "%'")
            ElseIf CmbUserLevel.Text = "All" And TxtSearch.Text.Length > 0 Then
                Load_records("Select * from audittrail where UserLevel like '%" & TxtSearch.Text & "%'")

            ElseIf CmbUserLevel.Text <> "All" And TxtSearch.Text.Length = 0 Then
                Load_records("Select * from audittrail where UserLevel like '" & CmbUserLevel.Text & "'")
            ElseIf CmbUserLevel.Text <> "All" And TxtSearch.Text.Length > 0 Then
                Load_records("Select * from audittrail where UserLevel like '" & CmbUserLevel.Text & "' and Description like '%" & TxtSearch.Text & "%'")
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
End Class