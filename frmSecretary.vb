Public Class frmSecretary

    Private Sub TblSecretaryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblSecretaryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblSecretaryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub frmSecretary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblSecretary' table. You can move, or remove it, as needed.
        Me.TblSecretaryTableAdapter.Fill(Me.DataSet.tblSecretary)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TblSecretaryBindingSource.AddNew()







     


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Me.First_NameTextBox.Text = "" Then
            MessageBox.Show("First name is empty.")

        ElseIf Me.Middle_NameTextBox.Text = "" Then
            MessageBox.Show("Middle name  is  empty.")
        ElseIf Me.Last_NameTextBox.Text = "" Then
            MessageBox.Show("Last name is empty.")

        Else

            Try
                TblSecretaryBindingSource.EndEdit()
                TblSecretaryTableAdapter.Update(DataSet.tblSecretary)
                MessageBox.Show("Successfully  Saved")

            Catch ex As Exception
                MessageBox.Show("Saving Error")
            End Try

        End If



    End Sub

    Private Sub Last_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Last_NameTextBox.TextChanged

    End Sub
End Class