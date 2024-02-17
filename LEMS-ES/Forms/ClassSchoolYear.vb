Imports MySql.Data.MySqlClient
Public Class ClassSchoolYear
#Region "SYparam"
    Public Shared Function SchoolYearParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmSY.idSY),
                    New MySqlParameter("@SchoolYear", frmSY.txtAddSY.Text)
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub SchoolYearRef()
        Dim dynamicParams As MySqlParameter() = SchoolYearParameters()
        If frmSY.idSY = 0 Then
            Command("INSERT INTO schoolyear(SchoolYear) VALUES (@SchoolYear)", dynamicParams)
        Else
            Command("UPDATE schoolyear SET SchoolYear=@SchoolYear WHERE ID=@ID", dynamicParams)
        End If
    End Sub
#End Region

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
#Region "SubjectParameters"
    Public Shared Function SubjectParameters() As MySqlParameter()
        Try
            Dim syParam() As MySqlParameter = {
                    New MySqlParameter("@ID", frmSubjects.idSubj),
                    New MySqlParameter("@SubjectCode", frmSubjects.txtSubjCode.Text),
                    New MySqlParameter("@SubjectName", frmSubjects.txtSubjName.Text)
                }
            Return syParam
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Sub SubjectRef()
        Dim dynamicParams As MySqlParameter() = SubjectParameters()
        If frmSubjects.idSubj = 0 Then
            Command("INSERT INTO subject(SubjectCode, SubjectName) VALUES (@SubjectCode, @SubjectName)", dynamicParams)
        Else
            Command("UPDATE subject SET SubjectCode=@SubjectCode, SubjectName=@SubjectName WHERE ID=@ID", dynamicParams)
        End If
    End Sub
#End Region
End Class
