Imports MySql.Data.MySqlClient
Public Class FrmEnrollment
    Private Sub FrmEnrollment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT e.ID,CONCAT(sy.Start_Year, '-', sy.End_Year) SchoolYear, e.EID, e.LRN, 
                CONCAT(st.Lastname, ', ',st.Firstname, ' ',st.MiddleInitial) as Fullname, 
                gl.GradeLevel, s.SectionRoom as Section, e.Enrollment_Date, e.Status 
                FROM enrollment e 
                JOIN schoolyear sy ON e.SchoolYear = sy.ID
                JOIN student st ON e.LRN = st.LRN
                JOIN section s ON e.SectionID = s.ID
                JOIN gradelevel gl ON e.GradeLevel_ID = gl.ID")
        dgvEnrolled.AutoGenerateColumns = False
        dgvEnrolled.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmEnrollmentRegistration.Show()
        FrmEnrollmentRegistration.LabelEID.Text = EIDGenerate()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim()

        If searchText <> String.Empty Then
            Dim dataTable As DataTable = CType(dgvEnrolled.DataSource, DataTable)
            Dim filteredData As New DataTable()

            filteredData = dataTable.Clone()

            For Each row As DataRow In dataTable.Rows
                For Each col As DataColumn In dataTable.Columns
                    If row(col.ColumnName).ToString().Contains(searchText) Then
                        filteredData.ImportRow(row)
                        Exit For
                    End If
                Next
            Next

            dgvEnrolled.DataSource = filteredData
        Else
            Loadrecords()
        End If
    End Sub

    Private Sub DgvEnrolled_DoubleClick(sender As Object, e As EventArgs) Handles dgvEnrolled.DoubleClick
        If dgvEnrolled.SelectedRows.Count > 0 Then
            With dgvEnrolled.SelectedRows(0)
                FrmEnrollmentRegistration.EnrollmentID = .Cells(0).Value
                FrmEnrollmentRegistration.lblSY.Text = .Cells(1).Value
                FrmEnrollmentRegistration.LabelEID.Text = .Cells(2).Value
                FrmEnrollmentRegistration.txtStudLRN.Text = .Cells(3).Value
                FrmEnrollmentRegistration.txtStudName.Text = .Cells(4).Value
                FrmEnrollmentRegistration.CmbGradeLevel.SelectedValue = .Cells(5).Value
                FrmEnrollmentRegistration.CmbSection.SelectedValue = .Cells(6).Value
            End With
            FrmEnrollmentRegistration.LoadSubjectEnrolled()
            FrmEnrollmentRegistration.Show()
        End If
        'If dgvEnrolled.SelectedRows.Count > 0 Then
        '    Dim selectedRow As DataGridViewRow = dgvEnrolled.SelectedRows(0)
        '    Dim enrollID As Integer = Convert.ToInt32(selectedRow.Cells("colID").Value)
        '    Dim EID As String = selectedRow.Cells("Column1").Value.ToString

        '    Dim studLRN As String = selectedRow.Cells("colLRN").Value.ToString()
        '    Dim studFullname As String = selectedRow.Cells("colFullname").Value.ToString()
        '    'Dim nameParts() As String = studFullname.Split(" "c)

        '    'If nameParts.Length >= 1 Then
        '    '    frmStudentsView.txtStudLname.Text = nameParts(0) ' Lastname
        '    'End If
        '    'If nameParts.Length >= 2 Then
        '    '    frmStudentsView.txtStudFname.Text = nameParts(1) ' Firstname
        '    'End If
        '    'If nameParts.Length >= 3 Then
        '    '    frmStudentsView.txtStudMname.Text = nameParts(2) ' Middle Initial
        '    'End If

        '    Dim studSection As String = selectedRow.Cells("colSection").Value.ToString()
        '    Dim studGradelevel As String = selectedRow.Cells("colGradeLevel").Value.ToString()

        '    FrmEnrollmentRegistration.EnrollmentID = enrollID
        '    FrmEnrollmentRegistration.LabelEID.Text = EID
        '    FrmEnrollmentRegistration.txtStudLRN.Text = studLRN
        '    FrmEnrollmentRegistration.txtStudName.Text = studFullname
        '    FrmEnrollmentRegistration.CmbSection.ValueMember = studSection
        '    FrmEnrollmentRegistration.CmbGradeLevel.ValueMember = studGradelevel

        '    FrmEnrollmentRegistration.Show()
        'End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Query($"SELECT e.ID, e.SchoolYear, e.LRN, CONCAT(st.Lastname, ' ',st.Firstname, ' ',st.MiddleInitial) as Fullname, s.SectionRoom as Section, gl.GradeLevel, e.Enrollment_Date, e.Status 
                FROM enrollment e 
                JOIN student st ON e.LRN = st.LRN
                JOIN section s ON e.SectionID = s.ID
                JOIN gradelevel gl ON e.GradeLevel_ID = gl.ID
                WHERE st.LRN LIKE '{txtSearch.Text}' OR st.Lastname LIKE '{txtSearch.Text}' OR st.Firstname LIKE '{txtSearch.Text}' ")
        dgvEnrolled.DataSource = ds.Tables("QueryTb")
    End Sub

    Private Sub DgvEnrolled_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnrolled.CellContentClick
    Dim column As String = dgvEnrolled.Columns(e.ColumnIndex).Name

        If column = "colDrop" AndAlso e.RowIndex >= 0 Then
            If MsgBox("Do you want to drop this student?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    Dim enrollmentId As String = dgvEnrolled.Rows(e.RowIndex).Cells("colID").Value.ToString()

                    ' Using parameterized query to prevent SQL injection
                    Command("UPDATE enrollment SET Status = 'Dropped' WHERE ID=" & enrollmentId)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MsgBox("Student has been successfully dropped!")
                        Loadrecords()
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
                                            CONCAT(c.Lastname, ', ', c.Firstname, ' ',c.MiddleInitial) Fullname, c.Gender, d.GradeLevel as Grade,
                                            e.SectionRoom as Section, f.Classification as Type, i.SubjectCode as Code, i.SubjectName as Subject, j.Room, h.Days, CONCAT(h.Time_From,'-',h.Time_To) Time, CONCAT(k.Lastname, ', ', k.Firstname) Teacher
                                            FROM enrollment a
                                            JOIN schoolyear b ON a.SchoolYear = b.ID
                                            JOIN student c ON a.LRN = c.LRN
                                            JOIN gradelevel d ON a.GradeLevel_ID = d.ID
                                            JOIN section e ON a.SectionID = e.ID
                                            JOIN req_classification f ON c.StudType = f.ID
                                            JOIN enrolled_sched g ON c.LRN= g.LRN
                                            JOIN schedule h ON g.ScheduleID = h.ID
                                            JOIN subject i ON h.Subj_ID = i.ID
                                            JOIN room j ON h.Room = j.ID
                                            JOIN teacher k ON h.Teacher_ID = k.ID
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
    End Sub
End Class