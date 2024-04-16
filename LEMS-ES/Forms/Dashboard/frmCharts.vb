Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmCharts
    Private Sub frmCharts_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        StudentsCount()
        TeachersCount()
        EnrolledCount()
        SectionsCount()
        ActiveSchoolYear()
        ChartEnrolled()
    End Sub
    Sub StudentsCount()
        Command("SELECT COUNT(*) FROM student")
        Dim total As Integer = CInt(cmd.ExecuteScalar())
        lblStud.Text = total.ToString()
    End Sub
    Sub TeachersCount()
        Command("SELECT COUNT(*) FROM teacher")
        Dim total As Integer = CInt(cmd.ExecuteScalar())
        lblTeacher.Text = total.ToString()
    End Sub
    Sub EnrolledCount()
        Command("SELECT COUNT(*) FROM enrollment")
        Dim total As Integer = CInt(cmd.ExecuteScalar())
        lblEnrolled.Text = total.ToString()
    End Sub
    Sub SectionsCount()
        Command("SELECT COUNT(*) FROM section")
        Dim total As Integer = CInt(cmd.ExecuteScalar())
        lblSections.Text = total.ToString()
    End Sub
    Sub ActiveSchoolYear()
        Command("SELECT CONCAT(Start_Year, '-', End_Year) as SchoolYear FROM schoolyear WHERE Status = 'Open'")
        Dim total As String = cmd.ExecuteScalar()
        lblSY.Text = total.ToString()
    End Sub
    Sub ChartEnrolled()
        With Chart1
            .Series.Clear()
            .Series.Add("Series1")
        End With

        Query("SELECT SchoolYear, COUNT(ID) FROM enrollment GROUP BY SchoolYear")

        Chart1.DataSource = ds.Tables("SchoolYear")
        Dim series1 As Series = Chart1.Series("Series1")
        series1.ChartType = SeriesChartType.FastLine
        series1.Name = "SchoolYear"

        With Chart1
            .Series(0).BorderWidth = 2
            .Series(0).Color = System.Drawing.Color.Blue

            .ChartAreas(0).Area3DStyle.Enable3D = False
            .Series(series1.Name).XValueMember = "SchoolYear"
            .Series(series1.Name).YValueMembers = "total"

            .Series(0).LabelFormat = "{#,##0}"
            .Series(0).IsValueShownAsLabel = True
            .Series(0).IsVisibleInLegend = False
        End With
    End Sub
End Class