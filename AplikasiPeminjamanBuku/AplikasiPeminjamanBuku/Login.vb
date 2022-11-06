Public Class Login

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text = "admin" And TxtPassword.Text = "admin" Then
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau Password Salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class