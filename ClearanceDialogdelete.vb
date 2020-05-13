Imports System.Windows.Forms

Public Class ClearanceDialogdelete

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        frmClearance.TblClearanceBindingSource.RemoveCurrent()
        frmCertificate.btnAddNew.Enabled = True
        frmCertificate.btnCancel.Enabled = False

        frmClearance.Hide()

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
