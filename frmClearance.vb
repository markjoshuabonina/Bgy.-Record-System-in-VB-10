Public Class frmClearance
    Dim purpose As String
    Dim remarks As String
    Dim validity As String
    Dim dateissued As String
    Dim notes As String

    Private Sub TblRbiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblRbiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRbiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

      

    End Sub

    Private Sub frmClearance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TblSecretaryTableAdapter.Fill(Me.DataSet.tblSecretary)
        'TODO: This line of code loads data into the 'DataSet.tblSecretary' table. You can move, or remove it, as needed.
        Me.TblClearanceTableAdapter.Fill(Me.DataSet.tblClearance)
        'TODO: This line of code loads data into the 'DataSet.tblClearance' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet.tblRbi' table. You can move, or remove it, as needed.
        Me.TblRbiTableAdapter.Fill(Me.DataSet.tblRbi)

        Timer1.Start()
        Timer2.Start()


    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If tbFN.Text = "" And tbMN.Text = "" Then
            Me.TblRbiTableAdapter.test(DataSet.tblRbi, tbLN.Text)

        ElseIf tbMN.Text = "" And tbLN.Text = "" Then


            Me.TblRbiTableAdapter.FN(DataSet.tblRbi, tbFN.Text)

        ElseIf tbFN.Text = "" And tbLN.Text = "" Then
            Me.TblRbiTableAdapter.MN(DataSet.tblRbi, tbMN.Text)
        ElseIf tbMN.Text = "" Then
            Me.TblRbiTableAdapter.LNandFN(Me.DataSet.tblRbi, tbLN.Text, tbFN.Text)
        ElseIf tbFN.Text = "" Then
            Me.TblRbiTableAdapter.LNandMN(Me.DataSet.tblRbi, tbLN.Text, tbMN.Text)
        ElseIf tbLN.Text = "" Then
            Me.TblRbiTableAdapter.FNandMN(Me.DataSet.tblRbi, tbFN.Text, tbMN.Text)
        Else
            Me.TblRbiTableAdapter.ALL(Me.DataSet.tblRbi, tbLN.Text, tbFN.Text, tbMN.Text)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.TblRbiDataGridView.Update()
        Me.TblRbiDataGridView.Refresh()


        tbFN.Text = ""
        tbMN.Text = ""
        tbLN.Text = ""


        If tbFN.Text = "" And tbMN.Text = "" Then
            Me.TblRbiTableAdapter.test(DataSet.tblRbi, tbLN.Text)

        ElseIf tbMN.Text = "" And tbLN.Text = "" Then

            Me.TblRbiTableAdapter.FN(DataSet.tblRbi, tbFN.Text)

        ElseIf tbFN.Text = "" And tbLN.Text = "" Then
            Me.TblRbiTableAdapter.MN(DataSet.tblRbi, tbMN.Text)
        ElseIf tbMN.Text = "" Then
            Me.TblRbiTableAdapter.LN_FN(Me.DataSet.tblRbi, tbLN.Text, tbFN.Text)
        ElseIf tbFN.Text = "" Then
            Me.TblRbiTableAdapter.LN_MN(Me.DataSet.tblRbi, tbLN.Text, tbMN.Text)
        ElseIf tbLN.Text = "" Then
            Me.TblRbiTableAdapter.FN_MN(Me.DataSet.tblRbi, tbFN.Text, tbMN.Text)
        Else
            Me.TblRbiTableAdapter.ALL(Me.DataSet.tblRbi, tbLN.Text, tbFN.Text, tbMN.Text)
        End If
    End Sub

    Private Sub PhotoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        If btnCancel.Enabled = False Then
            Me.Hide()

        Else
            If Me.PurposeTextBox.Text = "" Then
                Me.Hide()
                btnAddNew.Enabled = True
                btnCancel .Enabled = false

                Me.TblClearanceBindingSource.RemoveCurrent()

            Else

                ClearanceDialogSure.Show()

            End If
        End If
    End Sub

    Private Sub PhotoTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotoTextBox.TextChanged
        If (System.IO.File.Exists(PhotoTextBox.Text)) Then '
            PictureBox1.Image = Image.FromFile(PhotoTextBox.Text)

        End If
        If PhotoTextBox.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
    End Sub

    Private Sub TblRbiBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblRbiBindingNavigator.RefreshItems

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim countTotalRbiw As Integer
        countTotalRbiw = TblRbiBindingSource.Count
        lblTotalRbi.Text = countTotalRbiw.ToString
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim countTotalCerf As Integer
        countTotalCerf = TblClearanceBindingSource.Count
        lblTotalClr.Text = countTotalCerf.ToString
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Me.TblClearanceBindingSource.AddNew()
        btnCancel.Enabled = True
        btnSave.Enabled = True
        btnAddNew.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnNext.Enabled = False
        btnPrevious.Enabled = False


        PurposeTextBox.ReadOnly = False
        RemarksTextBox.ReadOnly = False
        Validity_of_ClearanceTextBox.ReadOnly = False
        Date_IssuedDateTimePicker.Enabled = True
        NoteTextBox.ReadOnly = False


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        TblRbiBindingSource.RemoveCurrent()

        btnSave.Enabled = False
        btnAddNew.Enabled = True
        btnCancel.Enabled = False
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        btnPrevious.Enabled = True
        btnNext.Enabled = True


        PurposeTextBox.ReadOnly = True
        RemarksTextBox.ReadOnly = True
        Validity_of_ClearanceTextBox.ReadOnly = True
        Date_IssuedDateTimePicker.Enabled = False
        NoteTextBox.ReadOnly = True


    End Sub
    Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        btnCancelEdit.Enabled = True
        btnAddNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False



        PurposeTextBox.ReadOnly = False
        RemarksTextBox.ReadOnly = False
        Validity_of_ClearanceTextBox.ReadOnly = False
        Date_IssuedDateTimePicker.Enabled = True
        NoteTextBox.ReadOnly = False


        purpose = PurposeTextBox.Text
        remarks = RemarksTextBox.Text
        validity = Validity_of_ClearanceTextBox.Text
        dateissued = Date_IssuedDateTimePicker.Text
        notes = NoteTextBox.Text



    End Sub

    Sub btnCancelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelEdit.Click
        btnAddNew.Enabled = True
        btnSave.Enabled = False
        btnCancelEdit.Enabled = False
        btnDelete.Enabled = True


        PurposeTextBox.ReadOnly = True
        RemarksTextBox.ReadOnly = True
        Validity_of_ClearanceTextBox.ReadOnly = True
        Date_IssuedDateTimePicker.Enabled = False
        NoteTextBox.ReadOnly = True


        PurposeTextBox.Text = purpose.ToString
        RemarksTextBox.Text = remarks.ToString
        Validity_of_ClearanceTextBox.Text = validity.ToString
        Date_IssuedDateTimePicker.Text = dateissued.ToString
        NoteTextBox.Text = notes.ToString



    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnAddNew.Enabled = True

        If Me.TextBox1.Text = "" Then

            MessageBox.Show("Please input Clearance ID")

        ElseIf Me.PurposeTextBox.Text = "" Then
            MessageBox.Show("Purpose is a required field.")

        Else

            Try
                TblClearanceBindingSource.EndEdit()
                TblClearanceTableAdapter.Update(DataSet.tblClearance)
                MessageBox.Show("Record Saved")

            Catch ex As Exception
                MessageBox.Show("Saving Error")
            End Try

        End If







    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ClearanceDialogdelete.Show()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        TblClearanceBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        TblClearanceBindingSource.MoveNext()

    End Sub

    Private Sub RemarksTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemarksTextBox.TextChanged

    End Sub

    Private Sub RemarksLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class