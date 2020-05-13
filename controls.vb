Module controls
    Public Sub gender()
        Dim gender As String
        Dim countmale As Integer = -1
        Dim countfemale As Integer = 0
        For I = 0 To frmRbi.TblRbiDataGridView.Rows.Count - 1
            gender = frmRbi.TblRbiDataGridView.Rows(I).Cells(8).Value
            If gender = "Female" Then
                countfemale += 1
            Else
                countmale += 1
            End If
        Next
        frmMain.lblFemale.Text = countfemale
        frmMain.lblMale.Text = countmale
        frmMain.lblTotal.Text = countfemale + countmale
    End Sub
    Public Sub Updategender()
        Dim gender As String
        Dim countmale As Integer = -1
        Dim countfemale As Integer = 0
        For I = 0 To frmMain.TblRbiDataGridView.Rows.Count - 1
            gender = frmMain.TblRbiDataGridView.Rows(I).Cells(8).Value
            If gender = "Female" Then
                countfemale += 1
            Else
                countmale += 1
            End If
        Next
        frmMain.lblFemale.Text = countfemale
        frmMain.lblMale.Text = countmale
        frmMain.lblTotal.Text = countfemale + countmale
    End Sub

End Module
