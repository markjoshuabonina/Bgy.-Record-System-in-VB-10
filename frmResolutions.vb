Public Class frmResolutions



    Dim yearSeries As String
    Dim no As String
    Dim explanatory As String


    Private Sub TblResolutionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblResolutionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblResolutionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub frmResolutions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblSecretary' table. You can move, or remove it, as needed.
        Me.TblSecretaryTableAdapter.Fill(Me.DataSet.tblSecretary)
        'TODO: This line of code loads data into the 'DataSet.tblResolution' table. You can move, or remove it, as needed.
        Me.TblResolutionTableAdapter.Fill(Me.DataSet.tblResolution)
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim countTotalRes As Integer
        countTotalRes = TblResolutionBindingSource.Count
        lblTotalRes.Text = countTotalRes.ToString
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        Me.TblResolutionBindingSource.AddNew()
        btnCancel.Enabled = True
        btnSave.Enabled = True
        btnAddNew.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        btnNext.Enabled = False
        btnPrevious.Enabled = False

        Date_IssuedDateTimePicker.Enabled = True
        Year__Series_TextBox.ReadOnly = False
        NoTextBox.ReadOnly = False
        ExplanatoryTextBox.ReadOnly = False


    End Sub

    Private Sub TblResolutionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblResolutionDataGridView.CellContentClick

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        TblResolutionBindingSource.RemoveCurrent()
        btnSave.Enabled = False
        btnAddNew.Enabled = True
        btnCancel.Enabled = False
        btnDelete.Enabled = True
        btnEdit.Enabled = True
        btnPrevious.Enabled = True
        btnNext.Enabled = True


        Year__Series_TextBox.ReadOnly = True
        NoTextBox.ReadOnly = True
        ExplanatoryTextBox.ReadOnly = True
    End Sub

    Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        btnCancelEdit.Enabled = True
        btnAddNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False

        Date_IssuedDateTimePicker.Enabled = True
        Year__Series_TextBox.ReadOnly = False
        NoTextBox.ReadOnly = False
        ExplanatoryTextBox.ReadOnly = False




        yearSeries = Year__Series_TextBox.Text
        no = NoTextBox.Text
        explanatory = ExplanatoryTextBox.Text



    End Sub

    Sub btnCancelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelEdit.Click
        btnAddNew.Enabled = True
        btnSave.Enabled = False
        btnCancelEdit.Enabled = False
        btnDelete.Enabled = True

        Date_IssuedDateTimePicker.Enabled = False
        Year__Series_TextBox.ReadOnly = True
        NoTextBox.ReadOnly = True
        ExplanatoryTextBox.ReadOnly = True



        Year__Series_TextBox.Text = yearSeries.ToString
        NoTextBox.Text = no.ToString
        ExplanatoryTextBox.Text = explanatory.ToString

    End Sub

    Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Res_delete.Show()

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        TblResolutionBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        TblResolutionBindingSource.MovePrevious()
    End Sub

    Private Sub ExplanatoryTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExplanatoryTextBox.TextChanged

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnAddNew.Enabled = True


        If Me.Year__Series_TextBox.Text = "" Then
            MessageBox.Show("Year is a required field.")

        ElseIf Me.NoTextBox.Text = "" Then
            MessageBox.Show("NO is a required field.")
        ElseIf Me.ExplanatoryTextBox.Text = "" Then
            MessageBox.Show("Explanatory is a required field.")


        Else

            Try
                TblResolutionBindingSource.EndEdit()
                TblResolutionTableAdapter.Update(DataSet.tblResolution)
                MessageBox.Show("Record Saved")

            Catch ex As Exception
                MessageBox.Show("Saving Error")
            End Try

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If btnCancel.Enabled = False Then
            Me.Hide()

        Else
            If Me.ExplanatoryTextBox.Text = "" And Me.Year__Series_TextBox.Text = "" And Me.NoTextBox.Text = "" Then
                Me.Hide()
                btnAddNew.Enabled = True
                btnCancel.Enabled = False
                Me.TblResolutionBindingSource.RemoveCurrent()


            Else

                ResolutionDialogSure.Show()

            End If
        End If
    End Sub

    Private Sub Date_IssuedDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Date_IssuedDateTimePicker.ValueChanged

    End Sub
End Class