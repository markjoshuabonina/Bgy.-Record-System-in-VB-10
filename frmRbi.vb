Public Class frmRbi
    Dim countID As Integer
    Dim lastname As String
    Dim firstname As String
    Dim middlename As String
    Dim nickname As String
    Dim birthdate As String
    Dim age As Integer
    Dim civil As String
    Dim sex As Integer
    Dim religion As String
    Dim birthpalse As String
    Dim purok As Integer
    Dim statusres As String
    Dim dateofRes As String
    Dim deleteCount As Integer
    Dim temp As Integer
    Dim error1 As Boolean

    Private Sub TblRbiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblRbiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRbiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Sub frmRbi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblCounters' table. You can move, or remove it, as needed.
        Me.TblCountersTableAdapter.Fill(Me.DataSet.tblCounters)
        'TODO: This line of code loads data into the 'DataSet.tblRbi' table. You can move, or remove it, as needed.
        Me.TblRbiTableAdapter.Fill(Me.DataSet.tblRbi)

        Timer1.Start()





    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        TblRbiBindingSource.RemoveCurrent()

        btnSave.Enabled = False
        btnAddNew.Enabled = True
        btnCancel.Enabled = False
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        btnBrowse.Enabled = False
        btnPrevious.Enabled = True
        btnNext.Enabled = True





        Last_NameTextBox.ReadOnly = True
        First_NameTextBox.ReadOnly = True
        Middle_NameTextBox.ReadOnly = True
        Nick_NameTextBox.ReadOnly = True
        Birth_DateDateTimePicker.Enabled = False
        Civil_StatusComboBox.Enabled = False
        SexComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        Birth_PlaceTextBox.ReadOnly = True
        PurokComboBox.Enabled = False
        Status_of_ResidencyComboBox.Enabled = False
        Date_of_ResidencyDateTimePicker.Enabled = False




    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.ShowDialog()
        Me.PhotoTextBox.Text = OpenFileDialog1.FileName

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

    Private Sub TestToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Test1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TestToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripButton.Click
        Try
            Me.TblRbiTableAdapter.test(Me.DataSet.tblRbi, Last_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TestToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles TestToolStrip.ItemClicked

    End Sub

    Private Sub FNToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FNToolStripButton.Click
        Try
            Me.TblRbiTableAdapter.FN(Me.DataSet.tblRbi, First_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub MNToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.TblRbiTableAdapter.MN(Me.DataSet.tblRbi, Middle_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LN_FNToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LN_FNToolStripButton.Click
        Try
            Me.TblRbiTableAdapter.LN_FN(Me.DataSet.tblRbi, Last_NameToolStripTextBox1.Text, First_NameToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LN_MNToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LN_MNToolStripButton.Click
        Try
            Me.TblRbiTableAdapter.LN_MN(Me.DataSet.tblRbi, Last_NameToolStripTextBox2.Text, Middle_NameToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FN_MNToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FN_MNToolStripButton.Click
        Try
            Me.TblRbiTableAdapter.FN_MN(Me.DataSet.tblRbi, Middle_NameToolStripTextBox2.Text, First_NameToolStripTextBox2.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ALLToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALLToolStripButton.Click
        Try
            Me.TblRbiTableAdapter.ALL(Me.DataSet.tblRbi, Last_NameToolStripTextBox3.Text, First_NameToolStripTextBox3.Text, Middle_NameToolStripTextBox3.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MNToolStripButton_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNToolStripButton.Click
        Try
            Me.TblRbiTableAdapter.MN(Me.DataSet.tblRbi, Middle_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

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

    Private Sub ReligionLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbLN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLN.TextChanged

    End Sub

    Private Sub tbFN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFN.TextChanged

    End Sub

    Private Sub tbMN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMN.TextChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        If btnCancel.Enabled = False Then
            Me.Hide()

        Else
            If Me.Last_NameTextBox.Text = "" And Me.First_NameTextBox.Text = "" And Me.Middle_NameTextBox.Text = "" And Nick_NameTextBox.Text = "" And AgeTextBox.Text = "" And Civil_StatusComboBox.Text = "" And Me.SexComboBox.Text = "" And Birth_PlaceTextBox.Text = "" And Me.ReligionComboBox.Text = "" And Me.Status_of_ResidencyComboBox.Text = "" Then
                Me.Hide()

                Me.btnAddNew.Enabled = True
                Me.btnCancel.Enabled = False
                Me.TblRbiBindingSource.RemoveCurrent()

            Else

                RbiDialogSure.Show()

            End If
        End If
    End Sub

    Private Sub Birth_DateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Birth_DateDateTimePicker.ValueChanged
        With Birth_DateDateTimePicker.Value
            Dim celebrate As DateTime = New DateTime(Now.Year, .Month, .Day)
            Dim age As Integer = Now.Year - .Year
            If celebrate > Now Then age -= 1
            AgeTextBox.Text = CStr(age)
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim countTotalCerRbi As Integer
        countTotalCerRbi = TblRbiBindingSource.Count
        lblTotalRbi.Text = countTotalCerRbi.ToString

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnAddNew.Enabled = True
        btnCancel.Enabled = False
        btnEdit.Enabled = True

        btnDelete.Enabled = True

        Me.Birth_DateDateTimePicker.Enabled = False
        Me.Civil_StatusComboBox.Enabled = False
        Me.SexComboBox.Enabled = False
        Me.ReligionComboBox.Enabled = False
        Me.Birth_PlaceTextBox.Enabled = False
        Me.PurokComboBox.Enabled = False
        Me.Status_of_ResidencyComboBox.Enabled = False


        If Me.Last_NameTextBox.Text = "" Then
            MessageBox.Show("Last Name is Empty! This is a required field.")

        ElseIf Me.First_NameTextBox.Text = "" Then
            MessageBox.Show("First Name is Empty! This is a required field.")


        ElseIf Me.AgeTextBox.Text = "" Then
            MessageBox.Show("Age is Empty! This is a required field.")


        ElseIf Me.SexComboBox.Text = "" Then
            MessageBox.Show("Sex is Empty! This is a required field.")
        ElseIf Me.PurokComboBox.Text = "" Then
            MessageBox.Show("Purok is Empty! This is a required field.")
        Else


            gender()


            Try
                TblRbiBindingSource.EndEdit()
                TblRbiTableAdapter.Update(DataSet.tblRbi)
                MessageBox.Show("Record Saved")
                'working
                'Me.Button9.Enabled = False
                btnSave.Enabled = False



            Catch ex As Exception
                MessageBox.Show("Saving Error")
            End Try

        End If


    End Sub

    Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
  





        Me.TblRbiBindingSource.AddNew()
        btnCancel.Enabled = True
        btnSave.Enabled = True
        btnAddNew.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnBrowse.Enabled = True
        btnNext.Enabled = False
        btnPrevious.Enabled = False



        Last_NameTextBox.ReadOnly = False
        First_NameTextBox.ReadOnly = False
        Middle_NameTextBox.ReadOnly = False
        Nick_NameTextBox.ReadOnly = False
        Birth_DateDateTimePicker.Enabled = True
        Civil_StatusComboBox.Enabled = True
        SexComboBox.Enabled = True
        ReligionComboBox.Enabled = True
        Birth_PlaceTextBox.ReadOnly = False
        PurokComboBox.Enabled = True
        Status_of_ResidencyComboBox.Enabled = True
        Date_of_ResidencyDateTimePicker.Enabled = True


        temp = Val(ForIDTextBox.Text)
        countID = TblRbiBindingSource.Count
        countID = countID + temp + 1
        If countID <= 9 Then
            RBI_IDTextBox.Text = "RBI-ID-00000" + countID.ToString
        ElseIf countID > 9 And countID < 99 Then
            RBI_IDTextBox.Text = "RBI-ID-0000" + countID.ToString
        ElseIf countID > 99 And countID < 999 Then
            RBI_IDTextBox.Text = "RBI-ID-000" + countID.ToString
        ElseIf countID > 999 And countID < 9999 Then
            RBI_IDTextBox.Text = "RBI-ID-00" + countID.ToString
        ElseIf countID > 9999 And countID < 9999 Then
            RBI_IDTextBox.Text = "RBI-ID-0" + countID.ToString
        Else
            RBI_IDTextBox.Text = "RBI-ID-" + countID.ToString
        End If




    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        RbiDiagalog_delete.Show()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        TblRbiBindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        TblRbiBindingSource.MoveNext()

    End Sub

    Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        btnBrowse.Enabled = True
        btnCancelEdit.Enabled = True
        btnAddNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False

        RBI_IDTextBox.ReadOnly = True
        Last_NameTextBox.ReadOnly = False
        First_NameTextBox.ReadOnly = False
        Middle_NameTextBox.ReadOnly = False
        Nick_NameTextBox.ReadOnly = False
        Birth_DateDateTimePicker.Enabled = True
        Civil_StatusComboBox.Enabled = True
        SexComboBox.Enabled = True
        ReligionComboBox.Enabled = True
        Birth_PlaceTextBox.ReadOnly = False
        PurokComboBox.Enabled = True
        Status_of_ResidencyComboBox.Enabled = True
        Date_of_ResidencyDateTimePicker.Enabled = True


        lastname = Me.Last_NameTextBox.Text
        firstname = Me.First_NameTextBox.Text
        middlename = Me.Middle_NameTextBox.Text
        nickname = Me.Nick_NameTextBox.Text
        birthdate = Me.Birth_DateDateTimePicker.Text
        age = Me.AgeTextBox.Text
        civil = Me.Civil_StatusComboBox.Text
        religion = Me.ReligionComboBox.Text
        birthpalse = Me.Birth_PlaceTextBox.Text
        purok = Me.PurokComboBox.Text
        statusres = Me.Status_of_ResidencyComboBox.Text
        dateofRes = Me.Date_of_ResidencyDateTimePicker.Text




    End Sub

    Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelEdit.Click
        btnAddNew.Enabled = True
        btnSave.Enabled = False
        btnCancelEdit.Enabled = False
        btnDelete.Enabled = True
        btnBrowse.Enabled = False

        Last_NameTextBox.ReadOnly = True
        First_NameTextBox.ReadOnly = True
        Middle_NameTextBox.ReadOnly = True
        Nick_NameTextBox.ReadOnly = True
        Birth_DateDateTimePicker.Enabled = False
        Civil_StatusComboBox.Enabled = False
        SexComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        Birth_PlaceTextBox.ReadOnly = True
        PurokComboBox.Enabled = False
        Status_of_ResidencyComboBox.Enabled = False
        Date_of_ResidencyDateTimePicker.Enabled = False


        Last_NameTextBox.Text = lastname.ToString
        Middle_NameTextBox.Text = middlename.ToString
        First_NameTextBox.Text = firstname.ToString


        Me.Birth_DateDateTimePicker.Text = birthdate.ToString
        Me.AgeTextBox.Text = age.ToString
        Me.Civil_StatusComboBox.Text = civil.ToString
        Me.ReligionComboBox.Text = religion.ToString
        Me.Birth_PlaceTextBox.Text = birthpalse.ToString
        Me.PurokComboBox.Text = purok.ToString
        Me.Status_of_ResidencyComboBox.Text = statusres.ToString
        Me.Date_of_ResidencyDateTimePicker.Text = dateofRes.ToString

        Me.Nick_NameTextBox.Text = nickname.ToString


    End Sub

    Private Sub LNandFNToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LNandFNToolStripButton.Click
        Try
            Me.TblRbiTableAdapter.LNandFN(Me.DataSet.tblRbi, Last_NameToolStripTextBox4.Text, First_NameToolStripTextBox4.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LNandMNToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LNandMNToolStripButton.Click
        Try
            Me.TblRbiTableAdapter.LNandMN(Me.DataSet.tblRbi, Last_NameToolStripTextBox5.Text, Middle_NameToolStripTextBox4.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FNandMNToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FNandMNToolStripButton.Click
        Try
            Me.TblRbiTableAdapter.FNandMN(Me.DataSet.tblRbi, First_NameToolStripTextBox5.Text, Middle_NameToolStripTextBox5.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class