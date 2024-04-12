Imports MySql.Data.MySqlClient
Public Class ClassSection
#Region "SectionParam"
    Public Shared Function SectionParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmSections.idSection),
                    New MySqlParameter("@GradeLevel_ID", frmSections.cmbGradeLevel.SelectedValue),
                    New MySqlParameter("@SectionRoom", frmSections.txtSectionName.Text),
                    New MySqlParameter("@Capacity", frmSections.txtSectionCapacity.Text),
                    New MySqlParameter("@Adviser_ID", frmSections.cmbAdviser.SelectedValue)
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub SectionRef()
        Try
            Dim dynamicParams As MySqlParameter() = SectionParameters()
            If frmSections.idSection = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO section(GradeLevel_ID, SectionRoom, Capacity, Adviser_ID) VALUES (@GradeLevel_ID, @SectionRoom, @Capacity, @Adviser_ID)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE section SET GradeLevel_ID=@GradeLevel_ID, SectionRoom=@SectionRoom, Capacity=@Capacity, Adviser_ID=@Adviser_ID WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            frmSections.loadrecords()
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Section already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
