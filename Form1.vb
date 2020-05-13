Public Class loginform

    Private Sub UserpasswordBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UserpasswordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Login_FormDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Login_FormDataSet.userpassword' table. You can move, or remove it, as needed.
        Me.UserpasswordTableAdapter.Fill(Me.Login_FormDataSet.userpassword)

    End Sub

    Private Sub txtboxusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxusername.TextChanged
        Me.UserpasswordTableAdapter.FillBy(Me.Login_FormDataSet.userpassword, txtboxusername.Text, txtboxpassword.Text)
    End Sub

    Private Sub txtboxpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboxpassword.TextChanged
        Me.UserpasswordTableAdapter.FillBy(Me.Login_FormDataSet.userpassword, txtboxusername.Text, txtboxpassword.Text)
    End Sub

    Private Sub loginbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginbtn.Click

        If txtboxusername.Text = "" Then 'And txtboxpassword.Text = "" Then
            MsgBox("Invalid Username", MsgBoxStyle.OkCancel, "Message")

        ElseIf txtboxpassword.Text = "" Then 'And txtboxpassword.Text = "" Then
            MsgBox("Invalid Password", MsgBoxStyle.OkCancel, "Message")

        ElseIf txtboxpassword.Text = "" And txtboxpassword.Text = "" Then
            MsgBox("Invalid Password and Username", MsgBoxStyle.OkCancel, "Message")

        ElseIf txtboxusername.Text = UsernameTextBox.Text And txtboxpassword.Text = PasswordTextBox.Text Then
            MsgBox("Successful Log-in!", MsgBoxStyle.OkOnly, "Welcome!")

        Else
            MsgBox("Invalid username and password", MsgBoxStyle.OkCancel, "Message")
        End If
    End Sub

    Private Sub cancelbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelbtn.Click
        End
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If txtboxpassword.UseSystemPasswordChar = True Then
            txtboxpassword.UseSystemPasswordChar = False
        Else
            txtboxpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        forgotpassword.Show()
        Me.Hide()
    End Sub
End Class