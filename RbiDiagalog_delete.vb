Imports System.Windows.Forms

Public Class RbiDiagalog_delete
    Dim deleteCount As Integer

    Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        frmRbi.TblRbiBindingSource.RemoveCurrent()
        frmRbi.btnBrowse.Enabled = False


        deleteCount = Val(frmRbi.lblCount.Text) + 1
        frmRbi.lblCount.Text = deleteCount





        Try
            frmRbi.TblCountersBindingSource.EndEdit()
            frmRbi.TblCountersTableAdapter.Update(DataSet.tblCounters)
            frmRbi.ForIDTextBox.Text = deleteCount
            'working
            'Me.Button9.Enabled = False




        Catch ex As Exception

        End Try


        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TblCountersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblCountersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblCountersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub RbiDiagalog_delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.tblCounters' table. You can move, or remove it, as needed.
        Me.TblCountersTableAdapter.Fill(Me.DataSet.tblCounters)

    End Sub
End Class
