Public Class FrmRequirements
    Public idRequirements As Integer = 0
    Private Sub FrmRequirements_Load(sender As Object, e As EventArgs) Handles Me.Load
        Connection()
        Loadrecords()
        Clear()
    End Sub
    Public Sub Loadrecords()
        Query("SELECT  rq.ID, reqclass.Classification, rq.Requirement
                FROM requirements rq
                JOIN req_classification reqclass ON rq.Classification_ID = reqclass.ID")
        dgvRequirements.DataSource = ds.Tables("QueryTb")

        Query("SELECT * FROM req_classification")
        cmbClassification.DataSource = ds.Tables("QueryTb")
        cmbClassification.ValueMember = "ID"
        cmbClassification.DisplayMember = "Classification"
    End Sub
    Public Sub Clear()
        txtRequirements.Clear()
        idRequirements = 0
    End Sub
    Private Sub DgvRequirements_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequirements.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvRequirements.Rows(e.RowIndex)
                idRequirements = row.Cells(0).Value
                cmbClassification.Text = row.Cells(1).Value
                txtRequirements.Text = row.Cells(2).Value
            ElseIf e.ColumnIndex >= 0 Then
                Clear()
            End If
        Catch ex As Exception
            MsgBox("ERROR!", vbCritical)
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not IsEmptyField(cmbClassification.Text.Trim()) Then
            Info("Please select a classification.")
            Return
        End If

        If Not IsEmptyField(txtRequirements.Text.Trim()) Then
            Info("Please enter a requirement name.")
            Return
        End If

        If Not NoLeadingSpace(txtRequirements.Text.Trim()) Then
            Info("Requirement name must have no multiple spaces between letters.")
            Return
        End If
        ClassRequirements.RequirementsRef()
        Clear()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        Clear()
    End Sub
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRequirements.KeyPress
        If Not IsValidLettersDigits(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class