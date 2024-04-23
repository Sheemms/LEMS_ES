Imports MySql.Data.MySqlClient
Public Class ClassSection
#Region "SectionParam"
    Public Shared Function SectionParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", FrmSections.idSection),
                    New MySqlParameter("@GradeLevel_ID", FrmSections.cmbGradeLevel.SelectedValue),
                    New MySqlParameter("@SectionRoom", FrmSections.txtSectionName.Text)
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub SectionRef()
        Try
            Dim dynamicParams As MySqlParameter() = SectionParameters()
            If FrmSections.idSection = 0 Then
                If MsgBox("Do you want to add?", vbQuestion + vbYesNo) = vbYes Then
                    Command("INSERT INTO section(GradeLevel_ID, SectionRoom) VALUES (@GradeLevel_ID, @SectionRoom)", dynamicParams)
                    Success("Successfully Added!")
                End If
            Else
                If MsgBox("Do you want to update it?", vbQuestion + vbYesNo) = vbYes Then
                    Command("UPDATE section SET GradeLevel_ID=@GradeLevel_ID, SectionRoom=@SectionRoom WHERE ID=@ID", dynamicParams)
                    Success("Successfully Updated!")
                End If
            End If
            FrmSections.Loadrecords()
            ClearFields(FrmSections, FrmSections.idSection)
        Catch ex As MySqlException When ex.Number = 1062
            Critical("Section already exists.")
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
