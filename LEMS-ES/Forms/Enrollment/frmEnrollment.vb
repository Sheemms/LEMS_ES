Imports MySql.Data.MySqlClient
Public Class FrmEnrollment
    Private Sub FrmEnrollment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Try
            Query("SELECT e.ID,CONCAT(sy.Start_Year, '-', sy.End_Year) SchoolYear, e.EID, e.LRN, 
                CONCAT(st.Lastname, ' ',st.Firstname, ' ', st.MiddleInitial) as Fullname, 
                gl.GradeLevel, s.SectionRoom as Section, d.Department, e.Enrollment_Date, e.Status 
                FROM enrollment e 
                JOIN schoolyear sy ON e.SchoolYear = sy.ID
                JOIN student st ON e.LRN = st.LRN
                JOIN section s ON e.SectionID = s.ID
                JOIN gradelevel gl ON s.GradeLevel_ID = gl.ID
                JOIN department d ON gl.Department_ID = d.ID")
            dgvEnrolled.AutoGenerateColumns = False
            dgvEnrolled.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmEnrollmentRegistration.Show()
        FrmEnrollmentRegistration.LabelEID.Text = EIDGenerate()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'Dim searchText As String = txtSearch.Text.Trim()

        'If searchText <> String.Empty Then
        '    Dim dataTable As DataTable = CType(dgvEnrolled.DataSource, DataTable)
        '    Dim filteredData As New DataTable()

        '    filteredData = dataTable.Clone()

        '    For Each row As DataRow In dataTable.Rows
        '        For Each col As DataColumn In dataTable.Columns
        '            If row(col.ColumnName).ToString().Contains(searchText) Then
        '                filteredData.ImportRow(row)
        '                Exit For
        '            End If
        '        Next
        '    Next

        '    dgvEnrolled.DataSource = filteredData
        'Else
        '    Loadrecords()
        'End If
    End Sub

    'Private Sub DgvEnrolled_DoubleClick(sender As Object, e As EventArgs) Handles dgvEnrolled.DoubleClick
    'FrmEnrollmentRegistration.Clear()
    'If dgvEnrolled.SelectedRows.Count > 0 Then
    '    With dgvEnrolled.SelectedRows(0)

    '        FrmEnrollmentRegistration.lblSY.Text = .Cells(1).Value
    '        FrmEnrollmentRegistration.LabelEID.Text = .Cells(2).Value
    '        FrmEnrollmentRegistration.txtStudLRN.Text = .Cells(3).Value.ToString
    '        Dim sql As New MySqlCommand("SELECT e.ID,CONCAT(sy.Start_Year, '-', sy.End_Year) SchoolYear, e.EID, e.LRN, 
    '        CONCAT(st.Lastname, ' ',st.Firstname, ' ', st.MiddleInitial) as Fullname, 
    '        gl.GradeLevel, s.SectionRoom as Section, d.Department, e.Enrollment_Date, e.Status, st.ID student_id, s.ID section_id,  d.ID dept_id, gl.ID grade_lvl
    '        FROM enrollment e 
    '        JOIN schoolyear sy ON e.SchoolYear = sy.ID
    '        JOIN student st ON e.LRN = st.LRN
    '        JOIN section s ON e.SectionID = s.ID
    '        JOIN gradelevel gl ON s.GradeLevel_ID = gl.ID
    '        JOIN department d ON gl.Department_ID = d.ID WHERE e.ID = @id", con)
    '        sql.Parameters.AddWithValue("@id", .Cells(0).Value)
    '        Dim adapter As New MySqlDataAdapter(sql)
    '        Dim dt As New DataTable()
    '        adapter.Fill(dt)

    '        If dt.Rows.Count > 0 Then
    '            For Each row As DataRow In dt.Rows

    '                FrmEnrollmentRegistration.enrolledStudent = row("id").ToString()
    '                FrmEnrollmentRegistration.selectedStudent = 2


    '                FrmEnrollmentRegistration.CmbStudName.SelectedValue = ' Text Sample sample id

    '                FrmEnrollmentRegistration.CmbGradeLevel.SelectedValue = row("grade_lvl").ToString
    '                FrmEnrollmentRegistration.CmbSection.SelectedValue = row("section_id").ToString
    '            Next
    '        End If
    '        FrmEnrollmentRegistration.CmbDepartment.SelectedValue = .Cells(7).Value
    '    End With
    '    FrmEnrollmentRegistration.LoadSub()
    '    FrmEnrollmentRegistration.LoadEnrolledStudent()
    '    FrmEnrollmentRegistration.Show()
    'End If
    'End Sub
    'Private Sub DgvEnrolled_DoubleClick(sender As Object, e As EventArgs) Handles dgvEnrolled.DoubleClick
    '    If dgvEnrolled.SelectedRows.Count > 0 Then
    '        With dgvEnrolled.SelectedRows(0)
    '            FrmEnrollmentRegistration.enrolledStudent = .Cells(0).Value
    '            FrmEnrollmentRegistration.txtStudLRN.Text = .Cells(3).Value
    '        End With
    '        FrmEnrollmentRegistration.LoadEnrolledStudent()
    '        FrmEnrollmentRegistration.LoadSub()
    '        FrmEnrollmentRegistration.Show()
    '    End If
    'End Sub
    Private Sub DgvEnrolled_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrolled.CellDoubleClick
        Try
            If e.RowIndex >= 0 AndAlso dgvEnrolled.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvEnrolled.SelectedRows(0)
                FrmEnrollmentRegistration.enrolledStudent = Convert.ToInt32(selectedRow.Cells("colID").Value)
                FrmEnrollmentRegistration.CmbStudName.Text = selectedRow.Cells("colFullname").Value

                FrmEnrollmentRegistration.LoadEnrolledStudent()
                FrmEnrollmentRegistration.LoadSub()
                FrmEnrollmentRegistration.Show()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Query($"SELECT e.ID, CONCAT(sy.Start_Year, '-', sy.End_Year) SchoolYear, e.EID, e.LRN, 
                CONCAT(st.Lastname, ' ',st.Firstname, ' ', st.MiddleInitial) as Fullname, 
                gl.GradeLevel, s.SectionRoom As Section, d.Department, e.Enrollment_Date, e.Status 
                From enrollment e 
                JOIN schoolyear sy ON e.SchoolYear = sy.ID
                JOIN student st ON e.LRN = st.LRN
                JOIN section s ON e.SectionID = s.ID
                JOIN gradelevel gl ON s.GradeLevel_ID = gl.ID
                JOIN department d ON gl.Department_ID = d.ID
                WHERE st.LRN LIKE '%{txtSearch.Text}%' OR st.Lastname LIKE '%{txtSearch.Text}%' OR st.Firstname LIKE '%{txtSearch.Text}%' OR d.Department LIKE '%{txtSearch.Text}%' ")
            dgvEnrolled.DataSource = ds.Tables("QueryTb")
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub

    Private Sub DgvEnrolled_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrolled.CellContentClick
        Try
            Dim column As String = dgvEnrolled.Columns(e.ColumnIndex).Name

            If column = "colDrop" AndAlso e.RowIndex >= 0 Then
                If MsgBox("Do you want to drop this student?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        Dim enrollmentId As String = dgvEnrolled.Rows(e.RowIndex).Cells("colID").Value.ToString()

                        Command("UPDATE enrollment SET Status = 'Dropped' WHERE ID=" & enrollmentId)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MsgBox("Student has been successfully dropped!")
                            Loadrecords()
                            Dim name As String = dgvEnrolled.Rows(e.RowIndex).Cells("colLRN").Value.ToString() & " - " & dgvEnrolled.Rows(e.RowIndex).Cells("colFullname").Value.ToString()
                            LogAction("Dropped Students |" & name)
                        Else
                            MsgBox("No student was dropped.")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            ElseIf column = "colPrint" AndAlso e.RowIndex >= 0 Then
                Dim enrollmentId As String = dgvEnrolled.Rows(e.RowIndex).Cells(0).Value.ToString()
                Dim dt = New DataTable("DS_RegForm")
                Dim adp = New MySqlDataAdapter("SELECT  CONCAT(b.Start_Year, '-', b.End_Year) SY, a.EID, c.LRN,
                                            CONCAT(c.Lastname, ', ', c.Firstname, ' ',c.MiddleInitial) Fullname, c.Gender, e.GradeLevel as Grade,
                                            d.SectionRoom as Section, f.Classification as Type, i.SubjectCode as Code, i.SubjectName as Subject, j.Room,
                                            h.Days, CONCAT(h.Time_From,'-',h.Time_To) Time, CONCAT(k.Lastname, ', ', k.Firstname) Teacher, 
                                            CONCAT(l.Lastname, ', ', l.Firstname) Adviser
                                            FROM enrollment a
                                            JOIN schoolyear b ON a.SchoolYear = b.ID
                                            JOIN student c ON a.LRN = c.LRN
                                            JOIN section d ON a.SectionID = d.ID
                                            JOIN gradelevel e ON d.GradeLevel_ID = e.ID
                                            JOIN req_classification f ON c.StudType = f.ID
                                            JOIN enrolled_sched g ON c.LRN= g.LRN
                                            JOIN schedule h ON g.ScheduleID = h.ID
                                            JOIN subject i ON h.SubjectID = i.ID
                                            JOIN room j ON h.Room = j.ID
                                            JOIN teacher k ON h.TeacherID = k.ID
                                            JOIN teacher l ON d.AdviserID = l.ID
                                            WHERE a.ID = " & enrollmentId, con)
                adp.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No Records")
                    Exit Sub
                End If

                Dim crystal As New RegForm
                crystal.SetDataSource(dt)
                FrmRegForm.CrystalReportViewer1.ReportSource = crystal
                FrmRegForm.CrystalReportViewer1.Refresh()
                FrmRegForm.Show()
            End If
        Catch ex As Exception
            Critical(ex.Message)
        End Try
    End Sub
End Class