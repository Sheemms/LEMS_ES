Imports MySql.Data.MySqlClient
Public Class ClassSection
#Region "SectionParam"
    Public Shared Function SectionParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmSections.idSection),
                    New MySqlParameter("@SectionRoom", frmSections.txtSectionName.Text),
                    New MySqlParameter("@Capacity", frmSections.txtSectionCapacity.Text)
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub SectionRef()
        Dim dynamicParams As MySqlParameter() = SectionParameters()
        If frmSections.idSection = 0 Then
            Command("INSERT INTO section(SectionRoom, Capacity) VALUES (@SectionRoom, @Capacity)", dynamicParams)
        Else
            Command("UPDATE section SET SectionRoom=@SectionRoom, Capacity=@Capacity WHERE ID=@ID", dynamicParams)
        End If
    End Sub
#End Region
End Class
