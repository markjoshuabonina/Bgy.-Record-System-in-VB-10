Imports System.Windows.Forms

Public Class ResolutionDialogSure

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        frmResolutions.TblResolutionBindingSource.RemoveCurrent()
        frmResolutions.btnAddNew.Enabled = True
        frmResolutions.btnCancel.Enabled = False
        frmResolutions.Hide()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
