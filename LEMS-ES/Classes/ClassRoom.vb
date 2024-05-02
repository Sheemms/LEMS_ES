Imports MySql.Data.MySqlClient
Public Class ClassRoom
    Public Shared Function RoomParameters() As MySqlParameter()
        Try
            Dim RoomParam() As MySqlParameter = {
                    New MySqlParameter("@ID", FrmRoom.idRoom),
                    New MySqlParameter("@Room", FrmRoom.TxtRoom.Text),
                    New MySqlParameter("@Capacity", FrmRoom.TxtCapacity.Text)
                }
            Return RoomParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub RoomRef()
        Try
            Dim dynamicParams As MySqlParameter() = RoomParameters()
            If FrmRoom.idRoom = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO room(Room, Capacity) VALUES (@Room, @Capacity)", dynamicParams)
                    Success("Successfully Added!")
                    Dim name As String = FrmRoom.TxtRoom.Text & FrmRoom.TxtCapacity.Text
                    LogAction("Added Room |" & name)
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE room SET Room=@Room, Capacity=@Capacity WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            FrmRoom.Loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Room already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
