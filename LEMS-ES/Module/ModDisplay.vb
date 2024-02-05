Module ModDisplay
    Public Sub SectionDisplay(DGV As DataGridView)
        Command("SELECT * FROM section")
    End Sub
    Public Sub SchoolYearDisplay(DGV As DataGridView)
        Command("SELECT * FROM schoolyear")
    End Sub
End Module
