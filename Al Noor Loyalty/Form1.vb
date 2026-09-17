Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtName.Text = "mustafa" AndAlso txtPassword.Text = "1" Then

            Dim dashboard As New FrmDashboard()
            dashboard.Show()
            Me.Hide()

        Else

            MessageBox.Show("Username or Password is incorrect.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        End If


    End Sub
End Class
