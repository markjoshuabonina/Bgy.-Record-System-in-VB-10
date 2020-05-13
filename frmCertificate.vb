Public Class frmCertificate
    Dim subject As String
    Dim year As String
    Dim OrN As String
    Dim fulldetails As String


    Private Sub TblRbiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblRbiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRbiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)


    End Sub

    Private Sub frmCertificate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TblSecretaryTableAdapter.Fill(Me.DataSet.tblSecretary)


        'TODO: This line of code loads data into the 'DataSet.tblClearance' table. You can move, or remove it, as needed.
        Me.TblClearanceTableAdapter.Fill(Me.DataSet.tblClearance)
        'TODO: This line of code loads data into the 'DataSet.tblSecretary' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet.tblCertificates' table. You can move, or remove it, as needed.
        Me.TblCertificatesTableAdapter.Fill(Me.DataSet.tblCertificates)
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

    Private Sub PhotoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotoTextBox.TextChanged
        If (System.IO.File.Exists(PhotoTextBox.Text)) Then '
            PictureBox1.Image = Image.FromFile(PhotoTextBox.Text)

        End If
        If PhotoTextBox.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
    End Sub

    Private Sub Receipt_YearTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Receipt_YearTextBox.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalRbi.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim countTotalrbi As Integer
        countTotalrbi = TblRbiBindingSource.Count
        lblTotalRbi.Text = countTotalrbi.ToString
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim countTotalCerf As Integer
        countTotalCerf = TblCertificatesBindingSource.Count
        lblTotalCerf.Text = countTotalCerf.ToString

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click

    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Me.TblCertificatesBindingSource.AddNew()
        btnCancel.Enabled = True
        btnSave.Enabled = True
        btnAddNew.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnNext.Enabled = False
        btnPrevious.Enabled = False


        SubjectComboBox.Enabled = True
        Receipt_YearTextBox.ReadOnly = False
        OR_NoTextBox.ReadOnly = False
        Dates_IssuedDateTimePicker.Enabled = True
        Full_DetailTextBox.ReadOnly = False





    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        TblCertificatesBindingSource.RemoveCurrent()

        btnSave.Enabled = False
        btnAddNew.Enabled = True
        btnCancel.Enabled = False
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        btnPrevious.Enabled = True
        btnNext.Enabled = True


        SubjectComboBox.Enabled = False
        Receipt_YearTextBox.ReadOnly = True
        OR_NoTextBox.ReadOnly = True
        Dates_IssuedDateTimePicker.Enabled = False
        Full_DetailTextBox.ReadOnly = True




    End Sub

    Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        btnCancelEdit.Enabled = True
        btnAddNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False


        SubjectComboBox.Enabled = True
        Receipt_YearTextBox.ReadOnly = False
        OR_NoTextBox.ReadOnly = False
        Dates_IssuedDateTimePicker.Enabled = True
        Full_DetailTextBox.ReadOnly = False

        subject = SubjectComboBox.Text
        year = Receipt_YearTextBox.Text
        OrN = OR_NoTextBox.Text
        fulldetails = Full_DetailTextBox.Text


    End Sub

    Sub btnCancelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelEdit.Click



        btnAddNew.Enabled = True
        btnSave.Enabled = False
        btnCancelEdit.Enabled = False
        btnDelete.Enabled = True

        SubjectComboBox.Text = subject.ToString
        Receipt_YearTextBox.Text = year.ToString
        OR_NoTextBox.Text = OrN.ToString
        Full_DetailTextBox.Text = fulldetails.ToString



    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnAddNew.Enabled = True

        If Me.Cerf_IDTextBox.Text = "" Then
            MessageBox.Show("Please input Certificate ID")
        ElseIf Me.Full_DetailTextBox.Text = "" Then
            MessageBox.Show("Full details is a required field.")

        Else

            Try
                TblCertificatesBindingSource.EndEdit()
                TblCertificatesTableAdapter.Update(DataSet.tblCertificates)
                MessageBox.Show("Record Saved")

            Catch ex As Exception
                MessageBox.Show("Certificate ID is duplicated.")
            End Try

        End If
    End Sub

    Private Sub SubjectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectComboBox.SelectedIndexChanged

    End Sub

    Private Sub SubjectLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Receipt_YearLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OR_NoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OR_NoTextBox.TextChanged

    End Sub

    Private Sub OR_NoLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Full_DetailLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Dates_IssuedLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Full_DetailTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Full_DetailTextBox.TextChanged

    End Sub

    Private Sub Dates_IssuedDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dates_IssuedDateTimePicker.ValueChanged

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        CerfDialogdelete.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If btnCancel.Enabled = False Then
            Me.Hide()

        Else
            If Text = "" Then
                Me.Hide()

                Me.TblCertificatesBindingSource.RemoveCurrent()

            Else

                cerfDialogSure.Show()

            End If
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class